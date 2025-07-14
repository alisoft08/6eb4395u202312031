using eb4395u202312031.Inventories.Domain.Model.Aggregates;
using eb4395u202312031.Inventories.Interfaces.REST.Resources;

namespace eb4395u202312031.Inventories.Interfaces.REST.Transform;

/// <summary>
/// Provides a method to transform a Product entity from the domain layer into a REST resource representation.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public static class ProductResourceFromEntityAssembler
{
    /// <summary>
    /// Converts a Product domain entity into a ProductResource suitable for API responses.
    /// </summary>
    /// <param name="entity">The Product entity from the domain model.</param>
    /// <returns>A ProductResource object containing the mapped data.</returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public static ProductResource ToResourceFromEntity(Product entity)
    {
        return new ProductResource(
            entity.Id,
            entity.ProductNumber.Identifier,
            entity.Name,
            entity.ProductType.ToString(),
            entity.CurrentProductionQuantity,
            entity.MaxProductionQuantity);

    }
}