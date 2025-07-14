using eb4395u202312031.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using eb4395u202312031.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using eb4395u202312031.Manufacturing.Domain.Model.Aggregates;
using eb4395u202312031.Manufacturing.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace eb4395u202312031.Manufacturing.Infrastructure.Persistence.EFC.Repositories;

/// <summary>
/// Repository implementation for the BillOfMaterialsItem aggregate. Provides persistence operations for BillOfMaterialsItem.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public class BillOfMaterialsItemRepository(AppDbContext context)
    : BaseRepository<BillOfMaterialsItem>(context), IBillOfMaterialsItemRepository
{
    /// <summary>
    /// Checks if a BillOfMaterialsItem exists for the given item product number, batch ID, and Bill of Materials ID.
    /// </summary>
    /// <param name="ItemProductNumber">The unique identifier of the item product.</param>
    /// <param name="BatchId">The batch identifier.</param>
    /// <param name="BillOfMaterialsId">The Bill of Materials identifier.</param>
    /// <returns>True if a matching BillOfMaterialsItem exists; otherwise, false.</returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public async Task<bool> ExistsByItemProductNumberAndBatchIdAndBillOfMaterialsId(Guid ItemProductNumber, int BatchId,
        int BillOfMaterialsId)
    {
        return await Context.Set<BillOfMaterialsItem>()
            .AnyAsync(BillOfMaterialsItem =>
                BillOfMaterialsItem.ItemProductNumber.Identifier == ItemProductNumber &&
                BillOfMaterialsItem.BatchId == BatchId &&
                BillOfMaterialsItem.BillOfMaterialsId == BillOfMaterialsId);
    }

    /// <summary>
    /// Retrieves the last recorded required quantity from the most recent BillOfMaterialsItem.
    /// </summary>
    /// <returns>The latest required quantity as an integer.</returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public async Task<int> FindLastRequiredQuantity()
    {
        return await Context.Set<BillOfMaterialsItem>()
            .OrderByDescending(b => b.RequiredAt)
            .Select(b => b.RequiredQuantity)
            .FirstOrDefaultAsync();
    }
}
