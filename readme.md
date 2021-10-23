
# Ardalis.Specification Example project

This is an example project created with Visual Studio 2019, using .NET 5 runtime.
It aims to show the benefits of using the `ISpecification` pattern, and how to use `Ardalis.Specification` package that greatly simplifies pattern implementation.

## Benefits
- Code decoupling between Domain and Infrastructure layers
- Unit testable in isolation
- User-friendly naming (e.g. SearchOrdersByName) instead of LINQ queries 
- Reusable


## Requirements
- Visual Studio 2019
- .NET 5
- Microsoft.EntityFramework.Core
- Swashbuckle.AspNetCore (*for Swagger UI*)
- Ardalis.Specification
- Ardalis.Specification.EntityFrameworkCore


## Solution is built upon DDD principles, projects are structured as:

### Core
Defines your Core (or Domain) Layer, where business logic remains. Here lays both Entities and Specifications. If Value Objects or Events are needed, they should be placed in this project.  
Project Uses `Ardalis.Specification package`

### Infrastructure
Layer for Data Access uses Entity Framework and Repository pattern (*although without UnitOfWork*)  
Project Uses `Ardalis.Specification package`  
Project references `Core` layer  

### Api
UI Layer, built as a Web API project  
Project references  `Infrastructure`  layer