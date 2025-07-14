namespace eb4395u202312031.Manufacturing.Interfaces.REST.Resources;

/// <summary>
/// Represents the data returned by the API for a BillOfMaterialsItem entity, including all relevant fields and metadata.
/// </summary>
/// <param name="Id">The unique identifier of the BillOfMaterialsItem record.</param>
/// <param name="BillOfMaterialsId">The identifier of the Bill of Materials.</param>
/// <param name="ItemProductNumber">The product number associated with the item.</param>
/// <param name="BatchId">The batch identifier.</param>
/// <param name="RequiredQuantity">The required quantity for the item.</param>
/// <param name="ScheduledStartedAt">The scheduled start date and time for the item.</param>
/// <param name="RequiredAt">The required date and time for the item to be available.</param>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public record BillOfMaterialsItemResource(
    int Id,
    int BillOfMaterialsId,
    Guid ItemProductNumber,
    int BatchId,
    int RequiredQuantity,
    DateTime ScheduledStartedAt,
    DateTime RequiredAt);