namespace eb4395u202312031.Inventories.Interfaces.REST.Resources;

/// <summary>
/// Represents the data required to create a new Product entity via the REST API.
/// </summary>
/// <param name="name">The name of the Product.</param>
/// <param name="productType">The type of the Product.</param>
/// <param name="maxProductionQuantity">The maximum production quantity for the Product.</param>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public record CreateProductResource(
    string name, string productType, int maxProductionQuantity);