using eb4395u202312031.API.Shared.Domain.Repositories;
using eb4395u202312031.Manufacturing.Domain.Model.Aggregates;

namespace eb4395u202312031.Manufacturing.Domain.Repositories;

/// <summary>
/// Defines custom data access operations for the BillOfMaterialsItem aggregate in the Manufacturing context.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public interface IBillOfMaterialsItemRepository : IBaseRepository<BillOfMaterialsItem>
{
    /// <summary>
    /// Checks whether a BillOfMaterialsItem already exists for the given item product number, batch ID, and Bill of Materials ID.
    /// </summary>
    /// <param name="ItemProductNumber">The unique identifier of the item product.</param>
    /// <param name="BatchId">The batch identifier.</param>
    /// <param name="BillOfMaterialsId">The Bill of Materials identifier.</param>
    /// <returns>
    /// A task representing the asynchronous operation, returning true if a matching BillOfMaterialsItem exists; otherwise, false.
    /// </returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    Task<bool> ExistsByItemProductNumberAndBatchIdAndBillOfMaterialsId(Guid ItemProductNumber, int BatchId, int BillOfMaterialsId);

    /// <summary>
    /// Retrieves the last recorded required quantity from the most recent BillOfMaterialsItem.
    /// </summary>
    /// <returns>
    /// A task representing the asynchronous operation, returning the latest required quantity as an integer.
    /// </returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    Task<int> FindLastRequiredQuantity();
}