using eb4395u202312031.API.Shared.Domain.Repositories;
using eb4395u202312031.Manufacturing.Domain.Model.Aggregates;

namespace eb4395u202312031.Manufacturing.Domain.Repositories;


public interface IBillOfMaterialsItemRepository : IBaseRepository<BillOfMaterialsItem>
{
    Task<bool> ExistsByItemProductNumberAndBatchIdAndBillOfMaterialsId(Guid ItemProductNumber, int BatchId, int BillOfMaterialsId);
    
    Task<int> FindLastRequiredQuantity();
}