using eb4395u202312031.Inventories.Domain.Model.Queries;
using eb4395u202312031.Inventories.Domain.Services;
using eb4395u202312031.Inventories.Interfaces.ACL;

namespace eb4395u202312031.Inventories.Application.ACL;

/// <summary>
/// Provides an abstraction layer to query Product data from the domain using a service-based approach.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public class ProductsContextFacade(IProductQueryService ProductQueryService) : IProductsContextFacade
{
    /// <summary>
    /// Fetches a Product entity by its product number and returns its internal identifier.
    /// </summary>
    /// <param name="productNumber">The unique product number of the Product to be searched.</param>
    /// <returns>The identifier of the Product if found; otherwise, 0.</returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public async Task<int> FetchProductByProductNumberAsync(Guid productNumber)
    {
        var getProductByProductNumber = new GetProductByProductNumberQuery(productNumber);
        var Product = await ProductQueryService.Handle(getProductByProductNumber);
        return Product?.Id ?? 0;
    }
}