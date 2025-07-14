namespace eb4395u202312031.Manufacturing.Domain.Model.ValueObjects;

/// <summary>
/// Represents the unique serial number used to identify a Product entity in the Manufacturing context.
/// </summary>
/// <param name="Identifier">The globally unique identifier (GUID) associated with the BillOfMaterialsItem.</param>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public record ItemProductNumber(Guid Identifier)
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ItemProductNumber"/> record with a randomly generated GUID.
    /// </summary>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public ItemProductNumber() : this(Guid.NewGuid()) { }
}