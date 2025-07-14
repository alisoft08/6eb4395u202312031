using eb4395u202312031.Inventories.Domain.Model.Aggregates;
using eb4395u202312031.Inventories.Domain.Model.Queries;

namespace eb4395u202312031.Inventories.Domain.Services;


public interface IProductQueryService
{
    
    Task<IEnumerable<Product>> Handle(GetAllProductsQuery query);

    Task<Product?> Handle(GetProductByProductNumberQuery query);

}