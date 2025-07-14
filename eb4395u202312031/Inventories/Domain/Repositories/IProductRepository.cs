using eb4395u202312031.API.Shared.Domain.Repositories;
using eb4395u202312031.Inventories.Domain.Model.Aggregates;

namespace eb4395u202312031.Inventories.Domain.Repositories;


public interface IProductRepository : IBaseRepository<Product>
{
  
    Task<Product?> FindProductByProductNumberAsync(Guid ProductNumber);
  
    Task<int> FindLastCurrentProductionQuantity();
    
    

    
    
}