using eb4395u202312031.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using eb4395u202312031.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using eb4395u202312031.Inventories.Domain.Model.Aggregates;
using eb4395u202312031.Inventories.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace eb4395u202312031.Inventories.Infrastructure.Persistence.EFC.Repositories;

/// <summary>
/// Provides database access methods for the Product aggregate using Entity Framework Core.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public class ProductRepository(AppDbContext context) : BaseRepository<Product>(context), IProductRepository
{
    /// <summary>
    /// Finds a Product entity by its serial number.
    /// </summary>
    /// <param name="serialNumber">The GUID representing the unique serial number of the Product.</param>
    /// <returns>
    /// A task representing the asynchronous operation, which returns the Product if found; otherwise, null.
    /// </returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
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