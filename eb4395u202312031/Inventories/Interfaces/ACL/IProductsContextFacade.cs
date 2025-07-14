namespace eb4395u202312031.Inventories.Interfaces.ACL;


public interface IProductsContextFacade
{
 
    Task<int> FetchProductByProductNumberAsync(Guid productNumber);
}