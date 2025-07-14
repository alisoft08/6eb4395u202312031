namespace eb4395u202312031.Manufacturing.Interfaces.REST.Resources;

/// <summary>
/// Represents the data required to create a new BillOfMaterialsItem entity via the API.
/// </summary>
/// <param name="BillOfMaterialsId">The identifier of the Bill of Materials.</param>
/// <param name="ItemProductNumber">The product number associated with the item.</param>
/// <param name="BatchId">The batch identifier.</param>
/// <param name="RequiredQuantity">The required quantity for the item.</param>
/// <param name="ScheduledStartAt">The scheduled start date and time for the item.</param>
/// <param name="RequiredAt">The required date and time for the item to be available.</param>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public record CreateBillOfMaterialsItemResource(
    int BillOfMaterialsId,
    Guid ItemProductNumber,
    int BatchId,
    int RequiredQuantity,
    DateTime ScheduledStartAt,
    DateTime RequiredAt);