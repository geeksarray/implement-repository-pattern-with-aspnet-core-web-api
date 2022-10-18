# Implement Repository Pattern with ASP.NET Core Web API
This blog explains how to implement a Repository Pattern with ASP.NET Web API, AutoMapper, Entity Framework, CRUD operations, and async operations.

## Repository Pattern
A repository pattern is an abstraction that isolates business logic from the database access layer resulting in a decoupled architecture. Repositories hide logic that involves communication with the data store. Repository Pattern provides low-level abstraction.

You would usually have one repository per entity, for example, to perform CRUD operations on a Category entity you will have CategoryRepository.

## Advantages of Repository Pattern
1. Dependency Injection: you can inject interface dependency and mock repository, this increases the testability of your code. Directly using DBContext of EF Core in API Controller is not testable. For more details on Dependency Injection

2. Decouples Persistence Framework
Using Repository Pattern, it is easy to change the persistence framework for example from EF Core to Dapper or something else. So DataAccess Layer and Business Layer can be tested separately.

For More details visit - https://geeksarray.com/blog/implement-repository-pattern-with-aspnet-core-web-api

Test CRUD operations created using Repository Pattern

!(https://geeksarray.com/images/blog/implement-repository-pattern-with-aspnet-core-web-api.png)[Implement Repository Pattern With ASP.NET Web API]
