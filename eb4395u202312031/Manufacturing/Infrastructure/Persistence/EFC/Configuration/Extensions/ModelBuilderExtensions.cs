using eb4395u202312031.Manufacturing.Domain.Model.Aggregates;
using Microsoft.EntityFrameworkCore;

namespace eb4395u202312031.Manufacturing.Infrastructure.Persistence.EFC.Configuration.Extensions;

/// <summary>
/// Provides Fluent API configuration for the BillOfMaterialsItem aggregate in the Manufacturing context.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public static class ModelBuilderExtensions
{
    /// <summary>
    /// Applies entity configuration for the BillOfMaterialsItem aggregate, including key setup and mapping of value objects.
    /// </summary>
    /// <param name="builder">The <see cref="ModelBuilder"/> used to configure the EF Core model.</param>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
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