using eb4395u202312031.Inventories.Domain.Model.Aggregates;
using Microsoft.EntityFrameworkCore;

namespace eb4395u202312031.Inventories.Infrastructure.Persistence.EFC.Configuration.Extensions;

/// <summary>
/// Provides extension methods to apply entity configurations for the Product aggregate using the Fluent API.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public static class ModelBuilderExtensions
{
    /// <summary>
    /// Applies the configuration for the Product entity, including its key, identity generation, and value object mapping.
    /// </summary>
    /// <param name="builder">The <see cref="ModelBuilder"/> instance used to configure the EF Core model.</param>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
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