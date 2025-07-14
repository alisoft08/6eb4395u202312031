using eb4395u202312031.Inventories.Domain.Model.Aggregates;
using eb4395u202312031.Inventories.Domain.Model.Queries;
using eb4395u202312031.Inventories.Domain.Repositories;
using eb4395u202312031.Inventories.Domain.Services;

namespace eb4395u202312031.Inventories.Application.Internal.QueryServices;

/// <summary>
/// Provides query operations to retrieve Product entities from the repository based on specific criteria.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public class ProductQueryService(IProductRepository repository) : IProductQueryService
{
    /// <summary>
    /// Handles a query to retrieve all Product entities from the repository.
    /// </summary>
    /// <param name="query">The query object that triggers the retrieval of all Products.</param>
    /// <returns>An asynchronous task that returns a list of all Products.</returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery query)
    {
        return await repository.ListAsync();
    }

    /// <summary>
    /// Handles a query to retrieve a Product entity by its product number.
    /// </summary>
    /// <param name="query">The query containing the product number to search for.</param>
    /// <returns>An asynchronous task that returns the Product if found; otherwise, null.</returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public async Task<Product?> Handle(GetProductByProductNumberQuery query)
    {
        return await repository.FindProductByProductNumberAsync(query.productNumber);
    }
}