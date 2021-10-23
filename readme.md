# Ardalis.Specification Example project

This is a example project created with Visual Studio 2019, using .NET 5 runtime.
It aims to show benefits of using `ISpecification` pattern, and how to use `Ardalis.Specification` package that greatly simplifies pattern implementation.


## Requirements
- Visual Studio 2019
- .NET 5
- Microsoft.EntityFramework.Core
- Swashbuckle.AspNetCore (*for Swagger UI*)
- Ardalis.Specification
- Ardalis.Specification.EntityFrameworkCore


### Solution is built upon DDD principles, and projects are structured:

#### Core
Defines your Core (or Domain) Layer, where business logic remains. Here lays both Entitites and Specifications. If Value Objects or Events are needed, they should be placed in this project. __
Project Uses `Ardalis.Specification package`

#### Infrastructure
Layer for Data Access, uses Entity Framework and Repository pattern (*although without UnitOfWork*) __
Project Uses `Ardalis.Specification package` __
Project references `Core` layer __

#### Api
UI Layer, built as a Web Api project __
Project references  `Infrastructure`  layer