namespace eb4395u202312031.Inventories.Domain.Model.ValueObjects;


public record ProductNumber(Guid Identifier)
{
   
    public ProductNumber() : this(Guid.NewGuid()) { }
}