using eb4395u202312031.Inventories.Domain.Model.Commands;
using eb4395u202312031.Inventories.Domain.Model.ValueObjects;

namespace eb4395u202312031.Inventories.Domain.Model.Aggregates;


public partial class Product
{
    
    public int Id { get; }

   
    public ProductNumber ProductNumber { get; private set; } = new();

    
    public string Name { get; set; }

    
    public EProductType ProductType { get; set; }

    
    public int CurrentProductionQuantity { get; set; } = 0;

    
    public int MaxProductionQuantity { get; set; }
    
    public Product(){}

    
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

    
    public void UpdateCurrentProductionQuantity(int currentProductionQuantity)
    {
        CurrentProductionQuantity = currentProductionQuantity;
    }
}