namespace eb4395u202312031.Inventories.Interfaces.REST.Resources;


public record CreateProductResource(
    string name, string productType, int maxProductionQuantity);