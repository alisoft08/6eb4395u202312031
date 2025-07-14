using eb4395u202312031.Inventories.Domain.Model.Aggregates;
using eb4395u202312031.Inventories.Domain.Model.Queries;
using eb4395u202312031.Inventories.Domain.Repositories;
using eb4395u202312031.Inventories.Domain.Services;

namespace eb4395u202312031.Inventories.Application.Internal.QueryServices;

public class ProductQueryService(IProductRepository repository) : IProductQueryService
{
 
    public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery query)
    {
        return await repository.ListAsync();
    }

    
    public async Task<Product?> Handle(GetProductByProductNumberQuery query)
    {
        return await repository.FindProductByProductNumberAsync(query.productNumber);
    }
}