# WebApp
- Use ASP.NET Core MVC with controllers and views. 
- Razor Pages is a new alternative in ASP.NET Core 2.0, a page-based programming model that makes building web UI easier and more productive. 

# Reference
- [Introduction to Razor Pages in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/mvc/razor-pages/index?tabs=visual-studio)
- [Get started with Razor Pages in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/razor-pages-start)
- [Introduction to IIS Express](https://docs.microsoft.com/en-gb/iis/extensions/introduction-to-iis-express/iis-express-overview)
- [Windows Web App Gallery](https://webgallery.microsoft.com/gallery)
- [Configure an ASP.NET Core App](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/configuration/?tabs=basicconfiguration)
- [Configure sample](https://github.com/aspnet/Docs/tree/master/aspnetcore/fundamentals/configuration/index/sample)
- [Working with multiple environments: Development, Staging, Production](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/environments)
- [ASP.NET Core Module configuration reference](https://docs.microsoft.com/en-us/aspnet/core/host-and-deploy/aspnet-core-module#setting-environment-variables)
- [Safe storage of app secrets during development in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/security/app-secrets?tabs=visual-studio)
- [Hosting in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/hosting?tabs=aspnetcore2x)
- [Introduction to Dependency Injection in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection)
- [Working with static files in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/fundamentals/static-files)
- [Migrations - EF Core with ASP.NET Core MVC tutorial (4 of 10)](https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/migrations)
- [Preventing Cross-Site Request Forgery (XSRF/CSRF) Attacks in ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/security/anti-request-forgery)
- [Publish an ASP.NET Core web app to Azure App Service using Visual Studio](https://docs.microsoft.com/en-us/aspnet/core/tutorials/publish-to-azure-webapp-using-vs)

# NuGet package 
- "Microsoft.Extensions.Configuration.Binder"
- "Microsoft.AspNetCore.StaticFiles"
- [Microsoft.VisualStudio.Web.CodeGeneration.Design](https://www.nuget.org/packages/Microsoft.VisualStudio.Web.CodeGeneration.Design/)

# Tutorial 
- [Create a web app with ASP.NET Core MVC using Visual Studio](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/)
> macOS: [Getting started with ASP.NET Core MVC on Mac, Linux, or Windows](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app-mac/start-mvc)

> macOS, Linux, and Windows: [Getting started with ASP.NET Core MVC on Mac, Linux, or Windows](https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app-xplat/start-mvc)

## Commands
- Install-Package Microsoft.VisualStudio.Web.CodeGeneration.Design -Version 2.0.0
- Add-Migration Initial | Rating
- Update-Database
- dotnet aspnet-codegenerator razorpage -m Movie -dc MovieContext -udl -outDir Pages\Movies --referenceScriptLibraries
> -m: The name of the model. 
> -dc: The data context. 
> -udl: Use the default layout. 
> -outDir: The relative output folder path to create the views. 
> --referenceScriptLibraries: Adds _ValidationScriptsPartial to Edit and Create pages 

## Routing in the Startup.cs file
- http://server:port/[Controller]/[ActionName]/[Parameters]?[query-strings] => "{controller=HelloWorld}/{action=Welcome}/77?[name=Pedro&city=Oslo]"
- Eksempler:
> http://localhost:51038/

> http://localhost:51038/HelloWorld

> http://localhost:51038/HelloWorld/Welcome

> http://localhost:51038/HelloWorld/Welcome?name=Rick&numtimes=4

> http://localhost:51038/HelloWorld/Welcome/77?name=Rick&numtimes=4
