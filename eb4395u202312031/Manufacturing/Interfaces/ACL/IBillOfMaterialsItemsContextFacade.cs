namespace eb4395u202312031.Manufacturing.Interfaces.ACL;

/// <summary>
/// Facade interface to provide access to BillOfMaterialsItem context information from external bounded contexts.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public interface IBillOfMaterialsItemsContextFacade
{
    /// <summary>
    /// Fetches the latest recorded required quantity from BillOfMaterialsItem data.
    /// </summary>
    /// <returns>The most recent required quantity as an integer.</returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    Task<int> FetchLatestRequiredQuantity();
}