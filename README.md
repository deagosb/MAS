# MAS
## .NET Core Web API & Angular Client App
### About the project  
### [Follow Me on Twitter for Updates](https://twitter.com/intent/follow?screen_name=deagosb&tw_p=followbutton)

This project attempts to demonstrate the use of some [SOLID Principles](https://medium.com/backticks-tildes/the-s-o-l-i-d-principles-in-pictures-b34ce2f1e898) and design based on best practices.
Also, the code was builded using some design patterns like [Factory Method](https://code-maze.com/factory-method/) and [Repository](https://code-maze.com/net-core-web-development-part4/). 
The Unit Test was builded using [XUnit](https://xunit.github.io/) 


## Components 

This implementation includes an .NET Core Web API and a Angular Client App. 
The .NET Core Web API was builded on Visual Studio Community Edition 2017.
The Angular App Client was generated with [Angular CLI](https://github.com/angular/angular-cli) version 9.1.11.
## Running the .NET Core Web API
Open the solution `MAS.sln` and run over `IIS Express` the URL `http://localhost:65504/api/employee` will be displayed. (Please do not close while run the Client App) 
## Running the Angular Client App
Open a command line on the directory `AngularClient` and run `ng serve -o` for a dev server. Navigate to `http://localhost:4200/`. 



## Related Posts
[Factory pattern using built-in dependency injection of ASP.Net Core](https://medium.com/@mailbox.viksharma/factory-pattern-using-built-in-dependency-injection-of-asp-net-core-f91bd3b58665)

[Repository Design Pattern in C#](https://dotnettutorials.net/lesson/repository-design-pattern-csharp/)

[Unit testing C# in .NET Core using dotnet test and xUnit](https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test)