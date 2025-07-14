using eb4395u202312031.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using eb4395u202312031.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using eb4395u202312031.Inventories.Domain.Model.Aggregates;
using eb4395u202312031.Inventories.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace eb4395u202312031.Inventories.Infrastructure.Persistence.EFC.Repositories;


public class ProductRepository(AppDbContext context) : BaseRepository<Product>(context), IProductRepository
{

    public async Task<Product?> FindProductByProductNumberAsync(Guid productNumber)
    {
        return await Context.Set<Product>().FirstOrDefaultAsync(sn => sn.ProductNumber.Identifier == productNumber);
    }

    public async Task<int> FindLastCurrentProductionQuantity()
    {
        return await Context.Set<Product>()
            .OrderByDescending(b => b.CreatedDate)
            .Select(b => b.CurrentProductionQuantity)
            .FirstOrDefaultAsync();
    }

    
}