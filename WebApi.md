
## WebApi
Need to describe API's parameters, responses, errors, and document evertyhing, all in one place, all through our codebase

In order to automatically connect our frontend code with our backend APIs, we need to establish a common language between the two. 
The backend APIs must be documented in a way that our frontend can understand and consume, and this is where OpenAPI comes into play.

### Documentation 
OpenAPI Uprising

## Swagger (via Swashbuckle) 

**Swagger** = Ui
**Swashbuckle** = Content Generator - xml parsing to create content from [DataAnnotation] that generated xml file from project

https://dev.to/vorillaz/how-to-automatically-consume-restful-apis-in-your-frontend-48ba

Swagger is an open-source software framework that implements the OpenAPI Specification—an API description format for REST APIs. 

The OpenAPI Specification defines a standard, language-agnostic interface to HTTP APIs, enabling both humans and computers to discover and understand the capabilities of the API.

Using the specification, we can describe our API's parameters, responses, errors, and document evertyhing, all in one place, all through our codebase.

-  Built-in OpenAPI support: .NET 9 will include AddOpenApi() and MapOpenApi() methods, allowing you to generate OpenAPI specifications without Swagger.
-  .http files: Visual Studio now supports .http files, giving you a new way to interact with your APIs.
-  Endpoints Explorer: This new tool in Visual Studio provides another avenue for API exploration and testing.
-  Scalar: A rising star in the API documentation world, Scalar offers an interactive API documentation experience based on OpenAPI/Swagger documents.

Note: Swagger is being removed (.net9+) https://medium.com/@choudharyr/swaggers-swan-song-the-bold-new-era-of-api-documentation-in-net-9-d24c8fcc4853

## ScalaR (like swaggerhub?)

To incorporate the Scalar UI, simply expose an OpenAPI schema by using **Swashbuckle or NSwag**  

Scalar: A rising star in the API documentation world, Scalar offers an interactive API documentation experience based on OpenAPI/Swagger documents.
https://github.com/ScalaR/ScalaR 
### An alternative to swagger : Scalar
https://eminvergil.vercel.app/blog/scalar

Import an URL (you can even create a “Live Link”, which means it’ll fetch updates from the URL vs. just fetching it once)

## Embrace, Extend & Extinguish

https://github.com/dotnet/aspnetcore/discussions/58103

Swagger (Swashbuckle) is being removed from .NET 9 due to maintenance issues and evolving ASP.NET Core capabilities.

Microsoft is focusing on making OpenAPI a first-class citizen in ASP.NET Core.

New alternatives include built-in OpenAPI support, .http files, Endpoints Explorer, and third-party tools like Scalar.

Developers can still manually install Swagger if needed, but are encouraged to explore new options.

This change reflects Microsoft’s strategy to reduce external dependencies and streamline API documentation.
