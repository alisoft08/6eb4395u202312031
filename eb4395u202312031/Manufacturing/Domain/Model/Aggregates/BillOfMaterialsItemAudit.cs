using System.ComponentModel.DataAnnotations.Schema;
using EntityFrameworkCore.CreatedUpdatedDate.Contracts;

namespace eb4395u202312031.Manufacturing.Domain.Model.Aggregates;

/// <summary>
/// Extends the BillOfMaterialsItem aggregate with audit properties for tracking creation and update timestamps.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public partial class BillOfMaterialsItem : IEntityWithCreatedUpdatedDate
{
    /// <summary>
    /// Gets or sets the timestamp when the entity was created.
    /// </summary>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    [Column("CreatedAt")]
    public DateTimeOffset? CreatedDate { get; set; }

    /// <summary>
    /// Gets or sets the timestamp when the entity was last updated.
    /// </summary>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    [Column("UpdatedAt")]
    public DateTimeOffset? UpdatedDate { get; set; }
}