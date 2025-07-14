using eb4395u202312031.Manufacturing.Domain.Model.Queries;

namespace eb4395u202312031.Manufacturing.Domain.Services;

/// <summary>
/// Defines the contract for handling queries related to BillOfMaterialsItem entities in the Manufacturing context.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public interface IBillOfMaterialsItemQueryService
{
    /// <summary>
    /// Handles the retrieval of the most recent required quantity from BillOfMaterialsItem records.
    /// </summary>
    /// <param name="query">The query requesting the last required quantity.</param>
    /// <returns>
    /// A task representing the asynchronous operation, returning the last recorded required quantity as an integer.
    /// </returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    Task<int> Handle(GetLastRequiredQuantityQuery query);
}