namespace eb4395u202312031.Inventories.Interfaces.REST.Resources;

/// <summary>
/// Represents the data returned by the API for a Product entity, including identifiers, configuration, and thresholds.
/// </summary>
/// <param name="id">The internal identifier of the Product.</param>
/// <param name="productNumber">The globally unique serial number of the Product.</param>
/// <param name="name">The name of the Product.</param>
/// <param name="productType">The type of the Product.</param>
/// <param name="currentProductionQuantity">The current production quantity of the Product.</param>
/// <param name="maxProductionQuantity">The maximum production quantity for the Product.</param>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public record ProductResource(
    int id,
    Guid productNumber,
    string name,
    string productType,
    int currentProductionQuantity,
    int maxProductionQuantity
    );