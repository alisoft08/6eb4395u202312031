using eb4395u202312031.Inventories.Domain.Model.Queries;
using eb4395u202312031.Inventories.Domain.Services;
using eb4395u202312031.Inventories.Interfaces.ACL;

namespace eb4395u202312031.Inventories.Application.ACL;


public class ProductsContextFacade(IProductQueryService ProductQueryService) : IProductsContextFacade
{
    
    public async Task<int> FetchProductByProductNumberAsync(Guid productNumber)
    {
        var getProductByProductNumber = new GetProductByProductNumberQuery(productNumber);
        var Product = await ProductQueryService.Handle(getProductByProductNumber);
        return Product?.Id ?? 0;
    }
}