using eb4395u202312031.Manufacturing.Domain.Model.Queries;

namespace eb4395u202312031.Manufacturing.Domain.Services;


public interface IBillOfMaterialsItemQueryService
{
    Task<int> Handle(GetLastRequiredQuantityQuery query);
}