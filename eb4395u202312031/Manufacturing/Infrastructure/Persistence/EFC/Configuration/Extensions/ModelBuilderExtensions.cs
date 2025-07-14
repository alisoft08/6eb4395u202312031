using eb4395u202312031.Manufacturing.Domain.Model.Aggregates;
using Microsoft.EntityFrameworkCore;

namespace eb4395u202312031.Manufacturing.Infrastructure.Persistence.EFC.Configuration.Extensions;


public static class ModelBuilderExtensions
{
    public static void ApplyBillOfMaterialsItemConfiguration(this ModelBuilder builder)
    {
        builder.Entity<BillOfMaterialsItem>().HasKey(t => t.Id);

        builder.Entity<BillOfMaterialsItem>()
            .Property(t => t.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();

        builder.Entity<BillOfMaterialsItem>().OwnsOne(i => i.ItemProductNumber, sn =>
        {
            sn.WithOwner().HasForeignKey("Id");
            sn.Property(p => p.Identifier).HasColumnName("ItemProductNumber");
        });
        

    }
}