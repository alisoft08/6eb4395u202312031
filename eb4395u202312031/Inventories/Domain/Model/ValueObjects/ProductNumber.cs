namespace eb4395u202312031.Inventories.Domain.Model.ValueObjects;

/// <summary>
/// Represents the unique serial number used to identify a Product entity.
/// </summary>
/// <param name="Identifier">The globally unique identifier (GUID) associated with the Product.</param>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public record ProductNumber(Guid Identifier)
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductNumber"/> record with a randomly generated GUID.
    /// </summary>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public ProductNumber() : this(Guid.NewGuid()) { }
}