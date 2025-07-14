using eb4395u202312031.Inventories.Domain.Model.Aggregates;
using Microsoft.EntityFrameworkCore;

namespace eb4395u202312031.Inventories.Infrastructure.Persistence.EFC.Configuration.Extensions;


public static class ModelBuilderExtensions
{
   
    public static void ApplyProductConfiguration(this ModelBuilder builder)
    {
        builder.Entity<Product>().HasKey(t => t.Id);

        builder.Entity<Product>()
            .Property(t => t.Id)
            .IsRequired()
            .ValueGeneratedOnAdd();

        builder.Entity<Product>().OwnsOne(i => i.ProductNumber, sn =>
        {
            sn.WithOwner().HasForeignKey("Id");
            sn.Property(p => p.Identifier).HasColumnName("ProductNumber");
        });
    }
}