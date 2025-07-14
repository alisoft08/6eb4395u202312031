using eb4395u202312031.Manufacturing.Domain.Model.Queries;
using eb4395u202312031.Manufacturing.Domain.Services;
using eb4395u202312031.Manufacturing.Interfaces.ACL;

namespace eb4395u202312031.Manufacturing.Application.ACL;

/// <summary>
/// Concrete implementation of the IBillOfMaterialsItemsContextFacade interface.
/// Provides access to the latest required quantity from BillOfMaterialsItem data by querying the domain service.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public class BillOfMaterialsItemsContextFacade(IBillOfMaterialsItemQueryService BillOfMaterialsItemQueryService) : IBillOfMaterialsItemsContextFacade
{
    /// <summary>
    /// Retrieves the most recently recorded required quantity from BillOfMaterialsItem data.
    /// </summary>
    /// <returns>An integer representing the latest required quantity.</returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public async Task<int> FetchLatestRequiredQuantity()
    {
        var getLastRequiredQuantity = new GetLastRequiredQuantityQuery();
        var BillOfMaterialsItem = await BillOfMaterialsItemQueryService.Handle(getLastRequiredQuantity);
        return BillOfMaterialsItem;
    }
    
}