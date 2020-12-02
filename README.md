### BigCommerce C# API

This is a collection of clients, designed to connect to the Big Commerce APIs. There is one
client per API.

https://developer.bigcommerce.com/api-reference/

## Getting started

The clients are already built and tested, though this project is designed to be easily rebuilt
as changes are made to the published BC apis. To get started though, that is not required.

* Clone this repo
* Follow the steps under Authentication
* Open the Sample project in Visual Studio
* Run sample code

## Authentication

* Create your BigCommerce Store and App if you haven't already
* Obtain your store hash, client id and access token
  * [BigCommerce Authentication](https://developer.bigcommerce.com/api-docs/getting-started/authentication/rest-api-authentication#obtaining-store-api-credentials#obtaining-store-api-credentials)
* Rename gulpfile.config.sample.json to gulpfile.config.json and fill in the values

## Updating the client libraries

You can either update a single library, or all of them. The spec files are grabbed from bigcommerce servers, and processed on the fly, so
there is no need to download or maintain them. The swagger codegen tool will also be downloaded automatically if needed.

On Windows, make sure you install a bash client. A decent one is included with the git install (Git Bash).
Also, install node/npm.

```bash
npm install
gulp buildAll
```

or

```bash
gulp buildOne --name StoreInfo
```

## Adding a new API

Make sure it is in the gulpfile.esm.js. Update as above.

## Creating a new project in VS2019

* Create a new .NET Framework. Target 4.7 or later.
* On your solution, add an existing project. Locate for example clients/storeInfo/src/StoreInfo/StoreInfo.csproj
* On your project, add a reference. Choose the Project you just added.
* Now you can use the code in your own project, as exemplified in the Sample project.
* You'll need to include NewtonSoft.Json as a dependency if you want to read your gulpfile.config.json file.
