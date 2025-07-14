using eb4395u202312031.Manufacturing.Domain.Model.Commands;
using eb4395u202312031.Manufacturing.Domain.Model.ValueObjects;

namespace eb4395u202312031.Manufacturing.Domain.Model.Aggregates;


public partial class BillOfMaterialsItem
{
   
    public int Id { get; }


    public int BillOfMaterialsId { get; set; }

   
    public ItemProductNumber ItemProductNumber { get; protected set; }

    public int BatchId { get; set; }

  
    public int RequiredQuantity { get; set; }

  
    public DateTime ScheduledStartedAt { get; set; }

   
    public DateTime RequiredAt { get; set; }

    
    public BillOfMaterialsItem() { }

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
