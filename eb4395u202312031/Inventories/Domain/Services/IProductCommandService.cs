﻿using eb4395u202312031.Inventories.Domain.Model.Aggregates;
using eb4395u202312031.Inventories.Domain.Model.Commands;

namespace eb4395u202312031.Inventories.Domain.Services;

/// <summary>
/// Defines the contract for handling commands related to the creation of Product entities.
/// </summary>
/// <remarks>
/// Alison Jimena Arrieta Quispe
/// </remarks>
public interface IProductCommandService
{
    /// <summary>
    /// Handles the creation of a Product entity based on the provided command data.
    /// </summary>
    /// <param name="command">The command containing the data required to create a Product.</param>
    /// <returns>
    /// A task representing the asynchronous operation, which returns the created Product if successful; otherwise, null.
    /// </returns>
    /// <remarks>
    /// Alison Jimena Arrieta Quispe
    /// </remarks>
    Task<Product?> Handle(CreateProductCommand command);
}