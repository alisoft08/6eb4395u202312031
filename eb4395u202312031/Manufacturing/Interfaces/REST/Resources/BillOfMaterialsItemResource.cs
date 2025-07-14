namespace eb4395u202312031.Manufacturing.Interfaces.REST.Resources;


public record BillOfMaterialsItemResource(
    int Id,
    int BillOfMaterialsId,
    Guid ItemProductNumber,
    int BatchId,
    int RequiredQuantity,
    DateTime ScheduledStartedAt,
    DateTime RequiredAt);