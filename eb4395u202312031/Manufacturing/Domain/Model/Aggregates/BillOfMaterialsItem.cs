using eb4395u202312031.Manufacturing.Domain.Model.Commands;
using eb4395u202312031.Manufacturing.Domain.Model.ValueObjects;

namespace eb4395u202312031.Manufacturing.Domain.Model.Aggregates;

/// <summary>
/// Represents the state of a Product at a specific point in time, including environmental readings and operation mode.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public partial class BillOfMaterialsItem
{
    /// <summary>
    /// Gets the internal identifier of the BillOfMaterialsItem entity.
    /// </summary>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public int Id { get; }

    /// <summary>
    /// Gets or sets the identifier of the Bill of Materials.
    /// </summary>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public int BillOfMaterialsId { get; set; }

    /// <summary>
    /// Gets or sets the product number of the item.
    /// </summary>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public ItemProductNumber ItemProductNumber { get; protected set; }

    /// <summary>
    /// Gets or sets the batch identifier.
    /// </summary>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public int BatchId { get; set; }

    /// <summary>
    /// Gets or sets the required quantity of the item.
    /// </summary>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public int RequiredQuantity { get; set; }

    /// <summary>
    /// Gets or sets the scheduled start date and time for the item.
    /// </summary>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public DateTime ScheduledStartedAt { get; set; }

    /// <summary>
    /// Gets or sets the required date and time for the item to be available.
    /// </summary>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public DateTime RequiredAt { get; set; }

    /// <summary>
    /// Initializes an empty instance of the <see cref="BillOfMaterialsItem"/> class.
    /// </summary>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public BillOfMaterialsItem() { }

    /// <summary>
    /// Initializes a new instance of the <see cref="BillOfMaterialsItem"/> class with the specified parameters.
    /// </summary>
    /// <param name="billOfMaterialsId">The identifier of the Bill of Materials.</param>
    /// <param name="itemProductNumber">The product number of the item.</param>
    /// <param name="batchId">The batch identifier.</param>
    /// <param name="requiredQuantity">The required quantity of the item.</param>
    /// <param name="scheduledStartedAt">The scheduled start date and time.</param>
    /// <param name="requiredAt">The required date and time for the item.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="requiredAt"/> is in the future or when <paramref name="scheduledStartedAt"/> is less than 30 days after <paramref name="requiredAt"/>.</exception>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public BillOfMaterialsItem(int billOfMaterialsId, ItemProductNumber itemProductNumber, int batchId, int requiredQuantity, DateTime scheduledStartedAt, DateTime requiredAt)
    {
        BillOfMaterialsId = billOfMaterialsId;
        ItemProductNumber = itemProductNumber;
        BatchId = batchId;
        RequiredQuantity = requiredQuantity;
        if(requiredAt > DateTime.Now)
        {
            throw new ArgumentOutOfRangeException(nameof(requiredAt), "Required at time cannot be in the future.");
        }
        RequiredAt = requiredAt;
        
        if((scheduledStartedAt - requiredAt).TotalDays < 30)
        {
            throw new ArgumentOutOfRangeException(nameof(scheduledStartedAt), "El valor de ScheduledStartedAt debe ser al menos 30 días mayor que RequiredAt.");
        }
        ScheduledStartedAt = scheduledStartedAt;
        
        
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="BillOfMaterialsItem"/> class based on a command input.
    /// Includes validations for operation mode range and collected at.
    /// </summary>
    /// <param name="command">The command containing all data to create a BillOfMaterialsItem.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when values are outside allowed ranges.</exception>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    public BillOfMaterialsItem(CreateBillOfMaterialsItemCommand command)
    {
        BillOfMaterialsId = command.billOfMaterialId;
        ItemProductNumber = command.itemProductNumber;
        BatchId = command.batchId;
        RequiredQuantity = command.requiredQuantity;
        if(command.requiredAt > DateTime.Now)
        {
            throw new ArgumentOutOfRangeException(nameof(command.requiredAt), "Required at time cannot be in the future.");
        }
        RequiredAt = command.requiredAt;
        
        if((command.scheduledStartedAt - command.requiredAt).TotalDays < 30)
        {
            throw new ArgumentOutOfRangeException(nameof(command.scheduledStartedAt), "El valor de ScheduledStartedAt debe ser al menos 30 días mayor que RequiredAt.");
        }
        ScheduledStartedAt = command.scheduledStartedAt;
        
        
        
        
    }
}
