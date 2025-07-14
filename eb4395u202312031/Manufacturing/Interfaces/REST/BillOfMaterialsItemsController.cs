using System.Net.Mime;
using eb4395u202312031.Manufacturing.Domain.Services;
using eb4395u202312031.Manufacturing.Interfaces.REST.Resources;
using eb4395u202312031.Manufacturing.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace eb4395u202312031.Manufacturing.Interfaces.REST;

/// <summary>
/// Exposes RESTful endpoints for managing BillOfMaterialsItem entities in the Manufacturing context.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
[SwaggerTag("Available Product State Endpoints.")]
public class BillOfMaterialsItemsController(IBillOfMaterialsItemCommandService BillOfMaterialsItemCommandService)
    : ControllerBase
{
    /// <summary>
    /// Creates a new BillOfMaterialsItem entity based on the provided input resource.
    /// </summary>
    /// <param name="resource">The resource containing the data to create the BillOfMaterialsItem.</param>
    /// <returns>
    /// A 201 Created response with the created BillOfMaterialsItemResource if successful; otherwise, 400 BadRequest.
    /// </returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    [HttpPost]
    [SwaggerOperation("Create BillOfMaterialsItem", "Create a new BillOfMaterialsItem.", OperationId = "CreateBillOfMaterialsItem")]
    [SwaggerResponse(201, "The BillOfMaterialsItem was created.", typeof(BillOfMaterialsItemResource))]
    [SwaggerResponse(400, "The BillOfMaterialsItem was not created.")]
    public async Task<IActionResult> CreateProfile(CreateBillOfMaterialsItemResource resource)
    {
        var createBillOfMaterialsItemCommand = CreateBillOfMaterialsItemCommandFromResourceAssembler.ToCommandFromResource(resource);
        var BillOfMaterialsItem = await BillOfMaterialsItemCommandService.Handle(createBillOfMaterialsItemCommand);
        if (BillOfMaterialsItem is null) return BadRequest();
        var ProductResource = BillOfMaterialsItemResourceFromEntityAssembler.ToResourceFromEntity(BillOfMaterialsItem);
        return StatusCode(201, ProductResource);    
    }
}