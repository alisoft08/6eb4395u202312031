using eb4395u202312031.Manufacturing.Domain.Model.Queries;
using eb4395u202312031.Manufacturing.Domain.Repositories;
using eb4395u202312031.Manufacturing.Domain.Services;

namespace eb4395u202312031.Manufacturing.Application.Internal.QueryServices;

/// <summary>
/// Provides query handling logic for BillOfMaterialsItem-related data in the Manufacturing context.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public class BillOfMaterialsItemQueryService(IBillOfMaterialsItemRepository BillOfMaterialsItemRepository) : IBillOfMaterialsItemQueryService
{
    /// <summary>
    /// Handles a query to retrieve the most recent required quantity from BillOfMaterialsItem records.
    /// </summary>
    /// <param name="query">The query object requesting the last required quantity.</param>
    /// <returns>
    /// A task representing the asynchronous operation, returning the last recorded required quantity as an integer.
    /// </returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public async Task<int> Handle(GetLastRequiredQuantityQuery query)
    {
        return await BillOfMaterialsItemRepository.FindLastRequiredQuantity();
    }
}