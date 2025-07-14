using eb4395u202312031.API.Shared.Infrastructure.Persistence.EFC.Configuration;
using eb4395u202312031.API.Shared.Infrastructure.Persistence.EFC.Repositories;
using eb4395u202312031.Manufacturing.Domain.Model.Aggregates;
using eb4395u202312031.Manufacturing.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace eb4395u202312031.Manufacturing.Infrastructure.Persistence.EFC.Repositories;


public class BillOfMaterialsItemRepository(AppDbContext context)
    : BaseRepository<BillOfMaterialsItem>(context), IBillOfMaterialsItemRepository
{

    public async Task<bool> ExistsByItemProductNumberAndBatchIdAndBillOfMaterialsId(Guid ItemProductNumber, int BatchId,
        int BillOfMaterialsId)
    {
        return await Context.Set<BillOfMaterialsItem>()
            .AnyAsync(BillOfMaterialsItem =>
                BillOfMaterialsItem.ItemProductNumber.Identifier == ItemProductNumber &&
                BillOfMaterialsItem.BatchId == BatchId &&
                BillOfMaterialsItem.BillOfMaterialsId == BillOfMaterialsId);
    }

   
    public async Task<int> FindLastRequiredQuantity()
    {
        return await Context.Set<BillOfMaterialsItem>()
            .OrderByDescending(b => b.RequiredAt)
            .Select(b => b.RequiredQuantity)
            .FirstOrDefaultAsync();
    }
}
