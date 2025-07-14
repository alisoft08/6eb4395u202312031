using eb4395u202312031.Inventories.Domain.Model.Commands;
using eb4395u202312031.Inventories.Interfaces.REST.Resources;

namespace eb4395u202312031.Inventories.Interfaces.REST.Transform;

/// <summary>
/// Provides a method to convert a CreateProductResource into a CreateProductCommand.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public static class CreateProductCommandFromResourceAssembler
{
    /// <summary>
    /// Transforms a REST resource into a domain command for creating a Product entity.
    /// </summary>
    /// <param name="resource">The input resource received from the API request.</param>
    /// <returns>A CreateProductCommand instance containing the mapped data from the resource.</returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public static CreateProductCommand ToCommandFromResource(CreateProductResource resource)
    {
        return new CreateProductCommand(
            resource.name,
            resource.productType,
            resource.maxProductionQuantity);
    }
}