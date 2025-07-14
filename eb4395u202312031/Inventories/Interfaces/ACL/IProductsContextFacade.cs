namespace eb4395u202312031.Inventories.Interfaces.ACL;

/// <summary>
/// Defines the contract for accessing external data related to Product entities from another bounded context.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public interface IProductsContextFacade
{
    /// <summary>
    /// Fetches the internal identifier of a Product entity by its serial number from an external context.
    /// </summary>
    /// <param name="productNumber">The globally unique serial number of the Product to fetch.</param>
    /// <returns>
    /// A task representing the asynchronous operation, returning the Product ID if found; otherwise, 0.
    /// </returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    Task<int> FetchProductByProductNumberAsync(Guid productNumber);
}