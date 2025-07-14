using eb4395u202312031.Inventories.Domain.Model.Commands;
using eb4395u202312031.Inventories.Domain.Model.ValueObjects;

namespace eb4395u202312031.Inventories.Domain.Model.Aggregates;

/// <summary>
/// Represents a Product aggregate root in the Inventories domain.
/// </summary>
/// <remarks>Alison Jimena Arrieta Quispe</remarks>
public partial class Product
{
    /// <summary>
    /// Gets the unique identifier for the Product.
    /// </summary>
    public int Id { get; }

    /// <summary>
    /// Gets or sets the serial number of the Product.
    /// </summary>
    public ProductNumber ProductNumber { get; private set; } = new();

    /// <summary>
    /// Gets or sets the name of the Product.
    /// </summary>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the type of the Product.
    /// </summary>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public EProductType ProductType { get; set; }

    /// <summary>
    /// Gets or sets the current production quantity for the Product.
    /// </summary>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public int CurrentProductionQuantity { get; set; } = 0;

    /// <summary>
    /// Gets or sets the maximum production quantity for the Product.
    /// </summary>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public int MaxProductionQuantity { get; set; }
    
    /// <summary>
    /// Initializes a new instance of the <see cref="Product"/> class.
    /// </summary>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public Product(){}

    /// <summary>
    /// Sets the production capacity for the Product, validating the provided thresholds.
    /// </summary>
    /// <param name="maxProductionQuantity">The maximum production quantity to set.</param>
    /// <param name="minCapacityThreshold">The minimum allowed production quantity.</param>
    /// <param name="maxCapacityThreshold">The maximum allowed production quantity.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if <paramref name="maxProductionQuantity"/> is not between <paramref name="minCapacityThreshold"/> and <paramref name="maxCapacityThreshold"/>.</exception>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public void SetProductionCapacity(int maxProductionQuantity, int minCapacityThreshold, int maxCapacityThreshold)
    {
        if (maxProductionQuantity < minCapacityThreshold || maxProductionQuantity > maxCapacityThreshold)
        {
            throw new ArgumentOutOfRangeException(nameof(maxProductionQuantity), 
                $"Max production quantity {maxProductionQuantity} must be between {minCapacityThreshold} and {maxCapacityThreshold}.");
        }
        
        MaxProductionQuantity = maxProductionQuantity;
    }
    
    public Product(string name, string productType, int maxProductionQuantity)
    {
        Name = name;
        if(productType != "BTP" &&
           productType != "BTS" &&
           productType != "MTS" &&
           productType != "MTO" &&
           productType != "MTA")
        {
            throw new ArgumentOutOfRangeException(nameof(productType), 
                $"Invalid product type: {productType}, valid types are BTP, BTS, MTS, MTO, MTA.");
        }
        switch (productType)
        {
            case "BTP":
                ProductType = EProductType.BuildToPrint;
                break;
            case "BTS":
                ProductType = EProductType.BuildToSpecification;
                break;
            case "MTS":
                ProductType = EProductType.MadeToStock;
                break;
            case "MTO":
                ProductType = EProductType.MadeToOrder;
                break;
            case "MTA":
                ProductType = EProductType.MadeToAssemble;
                break;
                
        }
        MaxProductionQuantity = maxProductionQuantity;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="Product"/> class using a create command.
    /// </summary>
    /// <param name="command">The command containing Product creation data.</param>
    /// <exception cref="ArgumentOutOfRangeException">
    /// Thrown when temperature or humidity thresholds are out of valid range.
    /// </exception>
    /// <remarks>Alison Jimena Arrieta Quispe</remarks>
    public Product(CreateProductCommand command)
    {
        Name = command.name;
        if(command.productType != "BTP" &&
           command.productType != "BTS" &&
           command.productType != "MTS" &&
           command.productType != "MTO" &&
           command.productType != "MTA")
        {
            throw new ArgumentOutOfRangeException(nameof(command.productType), 
                $"Invalid product type: {command.productType}, valid types are BTP, BTS, MTS, MTO, MTA.");
        }
        switch (command.productType)
        {
            case "BTP":
                ProductType = EProductType.BuildToPrint;
                break;
            case "BTS":
                ProductType = EProductType.BuildToSpecification;
                break;
            case "MTS":
                ProductType = EProductType.MadeToStock;
                break;
            case "MTO":
                ProductType = EProductType.MadeToOrder;
                break;
            case "MTA":
                ProductType = EProductType.MadeToAssemble;
                break;
                
        }
        
       
        MaxProductionQuantity = command.maxProductionQuantity;
    }

    /// <summary>
    /// Updates the operation mode of the Product.
    /// </summary>
    /// <param name="operationMode">The new operation mode as an integer.</param>
    /// <remarks>Alison Jimena Arrieta Quispe</remarks>
    public void UpdateCurrentProductionQuantity(int currentProductionQuantity)
    {
        CurrentProductionQuantity = currentProductionQuantity;
    }
}