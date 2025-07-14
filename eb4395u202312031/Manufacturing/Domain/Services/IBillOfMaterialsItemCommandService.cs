using eb4395u202312031.Manufacturing.Domain.Model.Aggregates;
using eb4395u202312031.Manufacturing.Domain.Model.Commands;

namespace eb4395u202312031.Manufacturing.Domain.Services;

/// <summary>
/// Defines the contract for handling commands related to the creation of BillOfMaterialsItem entities.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public interface IBillOfMaterialsItemCommandService
{
    /// <summary>
    /// Processes a command to create a new BillOfMaterialsItem entity.
    /// </summary>
    /// <param name="command">The command containing the data required to create the BillOfMaterialsItem.</param>
    /// <returns>
    /// A task representing the asynchronous operation, returning the created BillOfMaterialsItem if successful; otherwise, null.
    /// </returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    Task<BillOfMaterialsItem?> Handle(CreateBillOfMaterialsItemCommand command);
}