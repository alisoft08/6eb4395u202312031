using eb4395u202312031.Inventories.Domain.Model.Aggregates;
using eb4395u202312031.Inventories.Domain.Model.Commands;

namespace eb4395u202312031.Inventories.Domain.Services;


public interface IProductCommandService
{

    Task<Product?> Handle(CreateProductCommand command);
}