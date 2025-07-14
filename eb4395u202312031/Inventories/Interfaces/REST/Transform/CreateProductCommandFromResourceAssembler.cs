using eb4395u202312031.Inventories.Domain.Model.Commands;
using eb4395u202312031.Inventories.Interfaces.REST.Resources;

namespace eb4395u202312031.Inventories.Interfaces.REST.Transform;

public static class CreateProductCommandFromResourceAssembler
{
  
    public static CreateProductCommand ToCommandFromResource(CreateProductResource resource)
    {
        return new CreateProductCommand(
            resource.name,
            resource.productType,
            resource.maxProductionQuantity);
    }
}