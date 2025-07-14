# MRPeasyManufacturing Platform

## Summary
MRPeasy Manufacturing Platform API,
made with Microsoft C#, ASP.NET Core, Entity Framework Core and MySQL persistence.
It also illustrates open-api documentation configuration and integration with Swagger UI.

## Features
- RESTful API
- OpenAPI Documentation
- Swagger UI
- ASP.NET Framework
- Entity Framework Core
- Audit Creation and Update Date
- Custom Route Naming Conventions
- Custom Object-Relational Mapping Naming Conventions.
- MySQL Database
- Domain-Driven Design

## Bounded Contexts
This version of MRPeas Manufacturing Platform is divided into two bounded contexts: Inventories, and Manufacturing.

### Inventories Context

The Inventories' Context is responsible for managing the products. It includes the following features:

- Create products
- Get all products
- Get a product by Product Number


This context includes also an anti-corruption layer to communicate with the Manufacturing Context.
The anti-corruption layer is responsible
for managing the communication between the Inventories' Context and the Manufacturing Context.
It offers the following capabilities to other bounded contexts:

- Get product by Product Number

### Manufacturing Context

The Manufacturing Context is responsible for managing the Bill of Materials Items.
Its features include:

- Create Bill of Materials Item
- Get all Bill of Materials Items
- Get Last Required Quantity

This context includes also an anti-corruption layer to communicate with the Manufacturing Context.
The anti-corruption layer is responsible
for managing the communication between the Manufacturing Context and the Inventories' Context.
It offers the following capabilities to other bounded contexts:

- Get Last Required Quantity.