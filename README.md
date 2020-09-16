# Introduction 
VOC is a web application used to help track and classify vessels of concerns across Canada. It uses an ASP.NET Core Web Application to run a RESTful API and a node.js site to run the front end. Authentication is handled by CCG Account - an ASP.NET Core Web Application running Identity Server 4 to support OAUth 2 and Open ID Connect.

# Getting Started
## Software dependencies
- [Visual Studio Professional](https://visualstudio.microsoft.com/vs/professional/) 2017 or 2019
- [ASP.NET Core 2.1](https://dotnet.microsoft.com/download/dotnet-core/2.1)
- [Visual Studio Code](https://code.visualstudio.com/)
  - Vetur extension
  - Prettier extension
- [Node.js](https://nodejs.org/en/)

## Package and tool references
The following packages/tools are used in the project.

- API:
  - [Fluent Validation](https://fluentvalidation.net/)
  - [Simple Injector](https://simpleinjector.readthedocs.io/en/latest/quickstart.html)
  - [Json.NET](https://www.newtonsoft.com/json)
  - [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/) with [migrations](https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/)
  - [xUnit](https://github.com/xunit/xunit)
  - [EfCore.TestSupport](https://github.com/JonPSmith/EfCore.TestSupport): utility library providing methods to help unit test application using EF Core

- Node.js
  - [Vue.js](https://vuejs.org/v2/guide/): front-end framework
  - [Vuetify](https://vuetifyjs.com/en/): material design front end components
  - [Vue Router](https://router.vuejs.org/): official page router for vue.js (handles switching pages, params, transitions, etc.)
  - [Vue Auto Routing Plugin](https://github.com/ktsn/vue-cli-plugin-auto-routing): a plugin to support auto configuring vue router
  - [Vuex](https://vuex.vuejs.org/): a state management pattern + library for Vue.js applications
  - [Vue I18n](https://kazupon.github.io/vue-i18n/): an internationalization plugin to handle translations in vue pages
  - [VeeValidate](https://baianat.github.io/vee-validate/): form validation framework that integrates with Vuetify components
  - [Axios](https://github.com/axios/axios): a promise based http client
  - [Lodash](https://lodash.com/): js utility library that provides useful methods for filtering, sorting, etc.
  - [vuex-oidc](https://github.com/perarnborg/vuex-oidc/wiki): oidc-client that integrates with vuex and vue-router

## Running locally
To run the site locally you download the latest source from Azure Devops and start both the ASP.NET Core website and the node.js website separately. 
- ASP.NET core website
  - open the solution file
  - set the Service project as the startup
  - Build the project
  - Run the Entity Framework migrations
    - open a powershell window in the DataModel folder
    - type `dotnet ef database update`
  - Run the site 

- node.js website:
  - open the Web folder in Visual Studio Code
  - Open a terminal in Visual Studio Code
  - type `npm install`
  - type `npm run serve`

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
