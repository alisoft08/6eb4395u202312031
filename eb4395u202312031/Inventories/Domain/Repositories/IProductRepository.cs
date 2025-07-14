using eb4395u202312031.API.Shared.Domain.Repositories;
using eb4395u202312031.Inventories.Domain.Model.Aggregates;

namespace eb4395u202312031.Inventories.Domain.Repositories;

/// <summary>
/// Defines a contract for Product-specific data access operations in the inventory domain.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public interface IProductRepository : IBaseRepository<Product>
{
    /// <summary>
    /// Finds a Product entity by its associated serial number.
    /// </summary>
    /// <param name="SerialNumber">The GUID representing the unique serial number of the Product.</param>
    /// <returns>A task that represents the asynchronous operation, containing the Product if found; otherwise, null.</returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    Task<Product?> FindProductByProductNumberAsync(Guid ProductNumber);
    /// <summary>
    /// Finds the last recorded current production quantity from the most recent Product entity.
    /// </summary>
    /// <returns>A task representing the asynchronous operation, returning the latest current production quantity as an integer.</returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    Task<int> FindLastCurrentProductionQuantity();
    
    

    
    
}