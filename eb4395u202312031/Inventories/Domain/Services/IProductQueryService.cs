using eb4395u202312031.Inventories.Domain.Model.Aggregates;
using eb4395u202312031.Inventories.Domain.Model.Queries;

namespace eb4395u202312031.Inventories.Domain.Services;

/// <summary>
/// Defines query operations for retrieving Product entities based on specified criteria.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public interface IProductQueryService
{
    /// <summary>
    /// Handles the retrieval of all Product entities in the system.
    /// </summary>
    /// <param name="query">The query object used to trigger the retrieval.</param>
    /// <returns>
    /// A task representing the asynchronous operation, which returns a collection of Product entities.
    /// </returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    Task<IEnumerable<Product>> Handle(GetAllProductsQuery query);

    /// <summary>
    /// Handles the retrieval of a Product entity by its product number.
    /// </summary>
    /// <param name="query">The query containing the product number of the Product to retrieve.</param>
    /// <returns>
    /// A task representing the asynchronous operation, which returns the Product entity if found; otherwise, null.
    /// </returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    Task<Product?> Handle(GetProductByProductNumberQuery query);

}