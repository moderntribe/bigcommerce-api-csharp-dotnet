### BigCommerce C# API

This is a collection of clients, designed to connect to the Big Commerce APIs. There is one
client per API.

https://developer.bigcommerce.com/api-reference/

## Getting started

The clients are already built and tested, though this project is designed to be easily rebuilt
as changes are made to the published BC apis. To get started though, that is not required.

* Clone this repo
* Follow the steps under Authentication
* Use npm to install dependencies
* Build and install the java clients (includes tests)
* Run sample code

## Authentication

* Create your BigCommerce Store and App if you haven't already
* Obtain your store hash, client id and access token
  * [BigCommerce Authentication](https://developer.bigcommerce.com/api-docs/getting-started/authentication/rest-api-authentication#obtaining-store-api-credentials#obtaining-store-api-credentials)
* Rename gulpfile.config.sample.json to gulpfile.config.json and fill in the values

## Build and run tests

```bash
cd clients
mvn clean install
```

### Run sample code

Build the libraries first and setup authentication.

```bash
cd samples/themes
mvn clean install
mvn exec:java -Dexec.mainClass="be.tri.App"
```

## Updating the client libraries

You can either update a single library, or all of them. The spec files are grabbed from bigcommerce servers, and processed on the fly, so
there is no need to download or maintain them. The swagger codegen tool will also be downloaded automatically if needed.

```
npm install
gulp buildAll
```

or

```
gulp buildOne --name StoreInfo
```

## Adding a new API

Make sure it is in the gulpfile.esm.js. Update as above.
