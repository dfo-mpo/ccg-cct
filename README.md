# ccg-cct
Career Competency Tool for Canadian Coast Guard

<div>
  <a href="https://dev.azure.com/foc-poc/CCG-CCT/_build?definitionId=645">
    <img src="https://dev.azure.com/foc-poc/CCG-CCT/_apis/build/status/dfo-mpo.ccg-cct?branchName=master" alt="Azure Pipeline Status">
  </a>
</div>

# Getting Started
## Software dependencies
- [Visual Studio Professional](https://visualstudio.microsoft.com/vs/professional/) 2017 or 2019
- [ASP.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/3.1)

## Package and tool references
The following packages/tools are used in the project.

- API:
  - [Fluent Validation](https://fluentvalidation.net/)
  - [Simple Injector](https://simpleinjector.readthedocs.io/en/latest/quickstart.html)
  - [Json.NET](https://www.newtonsoft.com/json)
  - [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) with [migrations](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/)
  - [xUnit](https://github.com/xunit/xunit)
  - [EfCore.TestSupport](https://github.com/JonPSmith/EfCore.TestSupport): utility library providing methods to help unit test application using EF Core
  - [Serilog](https://serilog.net/): Serilog provides diagnostic logging to files, the console, and database.

Most of the API endpoints should be using the [CQRS pattern](https://martinfowler.com/bliki/CQRS.html). The classification endpoints in the project can be used as a reference. Some key points are:
  - Commands are used to update the database. They must have a Fluent Validation validator class. The command handler will only execute if the validator passes.
  - Queries are used to read from the database. They generally do not require a validator, but you can add one if required. 
  - Error messages return HTTP400 Bad Request with bilingual error messages. The error messages can be used to identify the specific property and give custom error messages.

Authentication is handled by CCG Account with OAUTH2 and OIDC. Each application is responsible for Authorization. There are packages in CCG.AspNetCore and CCG.AspNetCore.Web for setting up our standard model for users, roles, and privileges. The basics are:
 - Users can be assigned a role
 - Roles can be assigned many privileges
 - All API authorization is based on privileges and never against roles. This allows roles to be created/removed as required. Roles can be assigned any combination of privileges based on business needs.

## Running locally
To run the site locally you:
  - open the solution file
  - set the Service project as the startup
  - Build the project
  - Run the Entity Framework migrations
    - open a powershell window in the DataModel folder
    - type `dotnet ef database update`
  - Run the site 

## Code Review guidelines
Things to look out for:
- Dead code blocks, needless comments etc.
- Debugging hooks such as console.log functions, etc.
- Compile errors for vue pages such as no-mixed-spaces-and-tabs, etc: should be error/warning free
- Long or confusing methods
- Validator without rules or incorrect rules
- Files changed that don't involve their ticket
- Keep pull requests small and specific

# Contribute
All contributions to the project must be done through pull requests. This means you will have to complete your work in a different branch and create a pull request when your work is finished. Pull requests will only complete when the follow policies are meet:
- linked to a work item
- build succeeds
- all unit tests passing
- another team member approves the change

Additionally, all query and commands should have unit tests created to validate their functionality. 
