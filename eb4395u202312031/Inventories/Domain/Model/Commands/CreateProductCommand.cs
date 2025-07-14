namespace eb4395u202312031.Inventories.Domain.Model.Commands;

public record CreateProductCommand(string name, string productType, int maxProductionQuantity);