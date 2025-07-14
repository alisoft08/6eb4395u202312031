using eb4395u202312031.Manufacturing.Domain.Model.Commands;
using eb4395u202312031.Manufacturing.Domain.Model.ValueObjects;
using eb4395u202312031.Manufacturing.Interfaces.REST.Resources;

namespace eb4395u202312031.Manufacturing.Interfaces.REST.Transform;

/// <summary>
/// Provides a method to convert a CreateBillOfMaterialsItemResource into a CreateBillOfMaterialsItemCommand.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public static class CreateBillOfMaterialsItemCommandFromResourceAssembler
{
    /// <summary>
    /// Transforms a REST resource into a domain command for creating a BillOfMaterialsItem entity.
    /// </summary>
    /// <param name="resource">The input resource received from the API request.</param>
    /// <returns>A CreateBillOfMaterialsItemCommand instance containing the mapped data from the resource.</returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public static CreateBillOfMaterialsItemCommand ToCommandFromResource(CreateBillOfMaterialsItemResource resource, int billOfMaterialsId)
    {
        return new CreateBillOfMaterialsItemCommand(
            billOfMaterialsId,
            new ItemProductNumber(resource.ItemProductNumber),
            resource.BatchId,
            resource.RequiredQuantity,
            resource.ScheduledStartAt,
            resource.RequiredAt);
    }
}