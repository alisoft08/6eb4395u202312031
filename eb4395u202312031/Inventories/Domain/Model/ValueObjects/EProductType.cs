namespace eb4395u202312031.Inventories.Domain.Model.ValueObjects;

/// <summary>
/// Defines the available product types for a Product in the Inventories domain.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public enum EProductType
{
    /// <summary>
    /// Product is built to print (BTP).
    /// </summary>
    /// <remarks>Alison Jimena Arrieta Quispe</remarks>
    BuildToPrint,

    /// <summary>
    /// Product is built to specification (BTS).
    /// </summary>
    /// <remarks>Alison Jimena Arrieta Quispe</remarks>
    BuildToSpecification,

    /// <summary>
    /// Product is made to stock (MTS).
    /// </summary>
    /// <remarks>Alison Jimena Arrieta Quispe</remarks>
    MadeToStock,

    /// <summary>
    /// Product is made to order (MTO).
    /// </summary>
    /// <remarks>Alison Jimena Arrieta Quispe</remarks>
    MadeToOrder,

    /// <summary>
    /// Product is made to assemble (MTA).
    /// </summary>
    /// <remarks>Alison Jimena Arrieta Quispe</remarks>
    MadeToAssemble
}