﻿using eb4395u202312031.Manufacturing.Domain.Model.Aggregates;
using eb4395u202312031.Manufacturing.Domain.Model.Commands;

namespace eb4395u202312031.Manufacturing.Domain.Services;


public interface IBillOfMaterialsItemCommandService
{
    Task<BillOfMaterialsItem?> Handle(CreateBillOfMaterialsItemCommand command);
}