using eb4395u202312031.API.Shared.Domain.Repositories;
using eb4395u202312031.Inventories.Domain.Model.Aggregates;
using eb4395u202312031.Inventories.Domain.Model.Commands;
using eb4395u202312031.Inventories.Domain.Repositories;
using eb4395u202312031.Inventories.Domain.Services;
using eb4395u202312031.Manufacturing.Interfaces.ACL;

namespace eb4395u202312031.Inventories.Application.Internal.CommandServices;

/// <summary>
/// Handles the creation of Product entities by applying business rules and coordinating data persistence.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public class ProductCommandService(IProductRepository repository, IUnitOfWork unitOfWork, IBillOfMaterialsItemsContextFacade facade, IConfiguration configuration) : IProductCommandService
{
    /// <summary>
    /// Processes a command to create a new Product, assigning the latest current operation mode and saving it to the repository.
    /// </summary>
    /// <param name="command">The command containing the required data to create the Product.</param>
    /// <returns>The newly created Product if successful; otherwise, null.</returns>
    /// <exception cref="Exception">Thrown if the maximum production quantity is less than the required quantity.</exception>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public async Task<Product?> Handle(CreateProductCommand command)
    {
        var minCapacityThreshold = configuration.GetValue<int>("CapacityThresholds:minCapacityThreshold");
        var maxProductionQuantity = configuration.GetValue<int>("CapacityThresholds:maxCapacityThreshold");
        
        var Product = new Product(command);
        Product.SetProductionCapacity(command.maxProductionQuantity, minCapacityThreshold, maxProductionQuantity);
        
        var requiredQuantity = await facade.FetchLatestRequiredQuantity();
        var lastCurrentProductionQuantity = await repository.FindLastCurrentProductionQuantity();
        var sum = requiredQuantity + lastCurrentProductionQuantity;
        Product.UpdateCurrentProductionQuantity(sum);
        
        if(command.maxProductionQuantity < sum)
        {
            throw new Exception($"The maximum production quantity {command.maxProductionQuantity} cannot be less than the required quantity {sum}.");
        }
        
       

        try
        {
            await repository.AddAsync(Product);
            await unitOfWork.CompleteAsync();
            return Product;
        }
        catch (Exception ex)
        {
            return null;
        }
    }
}