using System.Net.Mime;
using eb4395u202312031.Inventories.Domain.Model.Queries;
using eb4395u202312031.Inventories.Domain.Services;
using eb4395u202312031.Inventories.Interfaces.REST.Resources;
using eb4395u202312031.Inventories.Interfaces.REST.Transform;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace eb4395u202312031.Inventories.Interfaces.REST;

/// <summary>
/// Exposes RESTful endpoints for managing Product entities in the Inventories context.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
[ApiController]
[Route("api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
[SwaggerTag("Available Product Endpoints.")]
public class ProductsController(IProductCommandService ProductCommandService, IProductQueryService ProductQueryService)
    : ControllerBase
{
    /// <summary>
    /// Retrieves all Product entities available in the system.
    /// </summary>
    /// <returns>An HTTP 201 response with a list of Product resources if found; otherwise, 400.</returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    [HttpGet]
    [SwaggerOperation("Get All Products", "Get all Products", OperationId = "GetAllProducts")]
    [SwaggerResponse(201, "The Products were found and returned", typeof(IEnumerable<ProductResource>))]
    [SwaggerResponse(400, "The Products were not found")]
    public async Task<IActionResult> GetAllProducts()
    {
        var getAllProducts = new GetAllProductsQuery();
        var Products = await ProductQueryService.Handle(getAllProducts);
        var ProductsResources = Products.Select(ProductResourceFromEntityAssembler.ToResourceFromEntity);
        return StatusCode(201, ProductsResources);
    }

    /// <summary>
    /// Creates a new Product entity based on the provided resource data.
    /// </summary>
    /// <param name="resource">The resource containing the information required to create a Product.</param>
    /// <returns>
    /// An HTTP 201 response with the created Product resource if successful; otherwise, 400.
    /// </returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    [HttpPost]
    [SwaggerOperation("Create Product", "Create a new Product.", OperationId = "CreateProduct")]
    [SwaggerResponse(201, "The Product was created.", typeof(ProductResource))]
    [SwaggerResponse(400, "The Product was not created.")]
    public async Task<IActionResult> CreateProfile(CreateProductResource resource)
    {
        var createProductCommand = CreateProductCommandFromResourceAssembler.ToCommandFromResource(resource);
        var Product = await ProductCommandService.Handle(createProductCommand);
        if (Product is null) return BadRequest();
        var ProductResource = ProductResourceFromEntityAssembler.ToResourceFromEntity(Product);
        return StatusCode(201, ProductResource);    
    }
}
