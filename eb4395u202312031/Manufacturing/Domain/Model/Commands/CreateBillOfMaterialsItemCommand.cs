using eb4395u202312031.Manufacturing.Domain.Model.ValueObjects;

namespace eb4395u202312031.Manufacturing.Domain.Model.Commands;

public record CreateBillOfMaterialsItemCommand(int billOfMaterialId, ItemProductNumber itemProductNumber, int batchId, int requiredQuantity, DateTime scheduledStartedAt, DateTime requiredAt);