using eb4395u202312031.Inventories.Domain.Model.Aggregates;
using eb4395u202312031.Inventories.Interfaces.REST.Resources;

namespace eb4395u202312031.Inventories.Interfaces.REST.Transform;


public static class ProductResourceFromEntityAssembler
{

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