namespace eb4395u202312031.Manufacturing.Interfaces.ACL;

/// <summary>
/// Facade interface to provide access to BillOfMaterialsItem context information from external bounded contexts.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public interface IBillOfMaterialsItemsContextFacade
{
  
    Task<int> FetchLatestRequiredQuantity();
}