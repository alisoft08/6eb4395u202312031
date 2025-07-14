using eb4395u202312031.API.Shared.Domain.Repositories;
using eb4395u202312031.Inventories.Interfaces.ACL;
using eb4395u202312031.Manufacturing.Domain.Model.Aggregates;
using eb4395u202312031.Manufacturing.Domain.Model.Commands;
using eb4395u202312031.Manufacturing.Domain.Repositories;
using eb4395u202312031.Manufacturing.Domain.Services;

namespace eb4395u202312031.Manufacturing.Application.Internal.CommandServices;

/// <summary>
/// Handles the creation of BillOfMaterialsItem entities, applying business validations and coordinating persistence.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public class BillOfMaterialsItemCommandService(IBillOfMaterialsItemRepository repository, IUnitOfWork unitOfWork, IProductsContextFacade facade)
    : IBillOfMaterialsItemCommandService
{
    /// <summary>
    /// Processes a command to create a new BillOfMaterialsItem. Validates uniqueness and existence of related Product entity.
    /// </summary>
    /// <param name="command">The command containing data required to create a BillOfMaterialsItem.</param>
    /// <returns>
    /// A task representing the asynchronous operation. Returns the created BillOfMaterialsItem if successful; otherwise, throws exception.
    /// </returns>
    /// <exception cref="Exception">
    /// Thrown if the BillOfMaterialsItem already exists for the given item product number, batch ID, and Bill of Materials ID,
    /// or if the related Product is not found.
    /// </exception>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public async Task<BillOfMaterialsItem?> Handle(CreateBillOfMaterialsItemCommand command)
    {

        var productNumber = await facade.FetchProductByProductNumberAsync(command.itemProductNumber.Identifier);
        if (productNumber == 0)
        {
            throw new Exception($"Product with product number {command.itemProductNumber.Identifier} not found.");
        }
        
        if (await repository.ExistsByItemProductNumberAndBatchIdAndBillOfMaterialsId(command.itemProductNumber.Identifier, command.batchId, command.billOfMaterialId))
        {
            throw new Exception($"Bill of Materials Item with item product number {command.itemProductNumber.Identifier}, batch ID {command.batchId}, and Bill of Materials ID {command.billOfMaterialId} already exists.");
        }
        

        var BillOfMaterialsItem = new BillOfMaterialsItem(command);
        
        await repository.AddAsync(BillOfMaterialsItem);
        await unitOfWork.CompleteAsync();

        return BillOfMaterialsItem;
    }
}
