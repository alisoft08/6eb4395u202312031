namespace eb4395u202312031.Manufacturing.Interfaces.REST.Resources;


public record CreateBillOfMaterialsItemResource(
    Guid ItemProductNumber,
    int BatchId,
    int RequiredQuantity,
    DateTime ScheduledStartAt,
    DateTime RequiredAt);