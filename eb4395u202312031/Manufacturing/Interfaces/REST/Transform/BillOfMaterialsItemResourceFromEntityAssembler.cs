using eb4395u202312031.Manufacturing.Domain.Model.Aggregates;
using eb4395u202312031.Manufacturing.Interfaces.REST.Resources;

namespace eb4395u202312031.Manufacturing.Interfaces.REST.Transform;

/// <summary>
/// Provides a method to convert a BillOfMaterialsItem domain entity into a BillOfMaterialsItemResource for API responses.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public static class BillOfMaterialsItemResourceFromEntityAssembler
{
    /// <summary>
    /// Converts a BillOfMaterialsItem entity into its corresponding REST resource representation.
    /// </summary>
    /// <param name="entity">The BillOfMaterialsItem entity from the domain model.</param>
    /// <returns>A BillOfMaterialsItemResource object containing the mapped values.</returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public static BillOfMaterialsItemResource ToResourceFromEntity(BillOfMaterialsItem entity)
    {
        return new BillOfMaterialsItemResource(
            entity.Id,
            entity.BillOfMaterialsId,
            entity.ItemProductNumber.Identifier,
            entity.BatchId,
            entity.RequiredQuantity,
            entity.ScheduledStartedAt,
            entity.RequiredAt);

    }
}