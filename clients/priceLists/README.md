# BigCommerce - the C# library for the Price Lists

Populate different versions of catalog pricing and assign them to different [customer groups](/api-reference/customer-subscribers/customers-api) at the variant level.  - [Authentication](#authentication) - [Price Lists](#price-lists) - [Price list assignments](#price-list-assignments) - [Usage notes](#usage-notes) - [Additional information](#additional-information)  ## Authentication  Authenticate requests by including an [OAuth](https://developer.bigcommerce.com/api-docs/getting-started/authentication) `access_token` in the request headers.  ```http GET https://api.bigcommerce.com/stores/{{STORE_HASH}}/v3/{{ENDPOINT}} Content-Type: application/json X-Auth-Token: {{ACCESS_TOKEN}} ```  ### OAuth Scopes  | UI Name                                      | Permission | Parameter                                     | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | Products                                     | modify     | `store_v2_products`                           | | Products                                     | read-only  | `store_v2_products_read_only`                 |  ## Price Lists  The association of a Price List to a Customer Group can be done either via the Control Panel or using the [Customer Groups API.](/api-reference/customer-subscribers/customers-api)  Additionally, [Price List Assignments](https://developer.bigcommerce.com/api-reference/store-management/price-lists/price-lists-records/) can be created to assign Price Lists to a specific [Channel](https://developer.bigcommerce.com/api-reference/cart-checkout/channels-listings-api). Price lists assigned to a channel apply to all shoppers on that channel, unless there is a more specific assignment.  If an active Price List does not contain prices for a variant then the Catalog pricing will be used. The association of a Price List to a Customer Group can be done either via the Control Panel or using the [Customer Groups API.](/api-reference/customer-subscribers/customers-api)  Price Lists will provide overridden price values to the Stencil storefront. Final price display can be further customized within the Stencil template. See the [Price Object](https://stencil.bigcommerce.com/docs/price-object-properties) in Stencil for further documentation.  To learn more about Price Lists, see [here](/api-docs/price-lists/price-list-overview).  ## Price list assignments  ### Order of operations  The `Price List Assignment` Pricing Order of Operations is as follows:  **IF** `Price list` assigned to current `Customer Group` **AND** `Price List` assigned to current `Channel`: * Use this Price List - - any prices not found fall back to the catalog price (or in the case of multi-currency, auto-converted prices)  **ELSE IF**: `Price List` assigned to current `Channel`: * Use this price list - - any prices not found fall back to the catalog price (or in the case of multi-currency, auto-converted prices)  **ELSE IF** `Price List` assigned to current `Customer Group`: * Use this price list - - any prices not found fall back to the catalog price (or in the case of multi-currency, auto-converted prices)  **ELSE IF** `Customer Group Discounts`: * Use them - - any prices not found fall back to the catalog price (or in the case of multi-currency, auto-converted prices)  **ELSE IF** `channel` has a `default price list`: * Use this price list - - any prices not found fall back to the catalog price (or in the case of multi-currency, auto-converted prices)  **ELSE**: * Fall back to the catalog price (or in the case of multi-currency, auto-converted prices)  **Note:** Price Lists cannot be assigned to a customer group that has custom group discounts - - the customer group discounts must be deleted first.  ## Usage notes - Price Lists cannot be assigned to a customer group that has custom group discounts - - the customer group discounts must be deleted first. - Bulk pricing Tiers may additionally be associated with a price record to indicate different pricing as the quantity in cart increases. - If a variant has a `Price Record` any existing product-level bulk pricing will not apply in the cart. For variants without `Price Records`, any existing product bulk pricing will apply. - Price Lists Records accepts bulk upsert. Only one [Bulk upsert](https://developer.bigcommerce.com/api-reference/catalog/pricelists-api/price-lists-records/setpricelistrecordcollection) can done at a time. Running more than one in parallel on the **same store** will cause a 429 error and the request will fail. - There are no direct webhooks available for Price Lists. Since Price Lists directly relate to products, webhooks related to products will fire for corresponding changes such as pricing.  ## Additional information  ### Webhooks  * [Products](/api-docs/getting-started/webhooks/webhook-events#webhook-events_products) * [SKU](/api-docs/getting-started/webhooks/webhook-events#webhook-events_sku)  ### Related endpoints * [Get Price List Collection](/api-reference/catalog/pricelists-api/price-lists/getpricelistcollection)

This C# SDK is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0.0
- SDK version: 1.0.0
- Build package: io.swagger.codegen.v3.generators.dotnet.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out BigCommerce.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.ApiKey.Add("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("X-Auth-Token", "Bearer");

            var apiInstance = new PriceListsApi();
            var body = new PriceListPost(); // PriceListPost | 
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Create a Price List
                PriceListResponse result = apiInstance.CreatePriceList(body, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceListsApi.CreatePriceList: " + e.Message );
            }
        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*PriceListsApi* | [**CreatePriceList**](docs/PriceListsApi.md#createpricelist) | **POST** /pricelists | Create a Price List
*PriceListsApi* | [**DeletePriceList**](docs/PriceListsApi.md#deletepricelist) | **DELETE** /pricelists/{price_list_id} | Delete a Price List
*PriceListsApi* | [**DeletePriceListsByFilter**](docs/PriceListsApi.md#deletepricelistsbyfilter) | **DELETE** /pricelists | Delete All Price Lists
*PriceListsApi* | [**GetPriceList**](docs/PriceListsApi.md#getpricelist) | **GET** /pricelists/{price_list_id} | Get a Price List
*PriceListsApi* | [**GetPriceListCollection**](docs/PriceListsApi.md#getpricelistcollection) | **GET** /pricelists | Get All Price Lists
*PriceListsApi* | [**UpdatePriceList**](docs/PriceListsApi.md#updatepricelist) | **PUT** /pricelists/{price_list_id} | Update a Price List
*PriceListsAssignmentsApi* | [**CreatePriceListAssignments**](docs/PriceListsAssignmentsApi.md#createpricelistassignments) | **POST** /pricelists/assignments | Create Price List Assignments
*PriceListsAssignmentsApi* | [**DeletePriceListAssignmentsByFilter**](docs/PriceListsAssignmentsApi.md#deletepricelistassignmentsbyfilter) | **DELETE** /pricelists/assignments | Delete Price List Assignments
*PriceListsAssignmentsApi* | [**GetListOfPriceListAssignments**](docs/PriceListsAssignmentsApi.md#getlistofpricelistassignments) | **GET** /pricelists/assignments | Get Price List Assignments
*PriceListsRecordsApi* | [**DeletePriceListRecord**](docs/PriceListsRecordsApi.md#deletepricelistrecord) | **DELETE** /pricelists/{price_list_id}/records/{variant_id}/{currency_code} | Delete a Price Record by Currency Code
*PriceListsRecordsApi* | [**DeletePriceListRecordsByFilter**](docs/PriceListsRecordsApi.md#deletepricelistrecordsbyfilter) | **DELETE** /pricelists/{price_list_id}/records | Delete a Price List Record
*PriceListsRecordsApi* | [**GetPriceListRecord**](docs/PriceListsRecordsApi.md#getpricelistrecord) | **GET** /pricelists/{price_list_id}/records/{variant_id}/{currency_code} | Get a Price Record by Currency Code
*PriceListsRecordsApi* | [**GetPriceListRecordCollection**](docs/PriceListsRecordsApi.md#getpricelistrecordcollection) | **GET** /pricelists/{price_list_id}/records | Get All Price List Records
*PriceListsRecordsApi* | [**GetPriceListRecordsByVariantId**](docs/PriceListsRecordsApi.md#getpricelistrecordsbyvariantid) | **GET** /pricelists/{price_list_id}/records/{variant_id} | Get Price Records by Variant
*PriceListsRecordsApi* | [**SetPriceListRecord**](docs/PriceListsRecordsApi.md#setpricelistrecord) | **PUT** /pricelists/{price_list_id}/records/{variant_id}/{currency_code} | Set Price List Record by Currency Code
*PriceListsRecordsApi* | [**SetPriceListRecordCollection**](docs/PriceListsRecordsApi.md#setpricelistrecordcollection) | **PUT** /pricelists/{price_list_id}/records | Upsert Price List Records

<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.AllOfPriceListAssignmentsBatchErrorResponseBatchErrorsData](docs/AllOfPriceListAssignmentsBatchErrorResponseBatchErrorsData.md)
 - [Model.AllOfPriceListAssignmentsBatchErrorSetData](docs/AllOfPriceListAssignmentsBatchErrorSetData.md)
 - [Model.AllOfPriceListCollectionResponseDataItems](docs/AllOfPriceListCollectionResponseDataItems.md)
 - [Model.AllOfPriceListResponseData](docs/AllOfPriceListResponseData.md)
 - [Model.AllOfPriceRecordBatchErrorSetData](docs/AllOfPriceRecordBatchErrorSetData.md)
 - [Model.AllOfPriceRecordCollectionResponseDataItems](docs/AllOfPriceRecordCollectionResponseDataItems.md)
 - [Model.AllOfPriceRecordResponseData](docs/AllOfPriceRecordResponseData.md)
 - [Model.AssignmentForGetResponse](docs/AssignmentForGetResponse.md)
 - [Model.AssignmentsForGetResponse](docs/AssignmentsForGetResponse.md)
 - [Model.AssignmentsForGetResponseData](docs/AssignmentsForGetResponseData.md)
 - [Model.AssignmentsForRequest](docs/AssignmentsForRequest.md)
 - [Model.BaseError](docs/BaseError.md)
 - [Model.Body](docs/Body.md)
 - [Model.BulkPricingTier](docs/BulkPricingTier.md)
 - [Model.CollectionMeta](docs/CollectionMeta.md)
 - [Model.CreateBatchPriceListAssignmentsRequest](docs/CreateBatchPriceListAssignmentsRequest.md)
 - [Model.DetailedErrors](docs/DetailedErrors.md)
 - [Model.ErrorResponse](docs/ErrorResponse.md)
 - [Model.InlineResponse200](docs/InlineResponse200.md)
 - [Model.InlineResponse204](docs/InlineResponse204.md)
 - [Model.InlineResponse422](docs/InlineResponse422.md)
 - [Model.Meta](docs/Meta.md)
 - [Model.NoContent](docs/NoContent.md)
 - [Model.NotFound](docs/NotFound.md)
 - [Model.Pagination](docs/Pagination.md)
 - [Model.Pagination1](docs/Pagination1.md)
 - [Model.Pagination1Links](docs/Pagination1Links.md)
 - [Model.PriceList](docs/PriceList.md)
 - [Model.PriceListAssignmentsBatchErrorResponse](docs/PriceListAssignmentsBatchErrorResponse.md)
 - [Model.PriceListAssignmentsBatchErrorResponseBatchErrors](docs/PriceListAssignmentsBatchErrorResponseBatchErrors.md)
 - [Model.PriceListAssignmentsBatchErrorSet](docs/PriceListAssignmentsBatchErrorSet.md)
 - [Model.PriceListAssignmentsIdentifiers](docs/PriceListAssignmentsIdentifiers.md)
 - [Model.PriceListBase](docs/PriceListBase.md)
 - [Model.PriceListCollectionResponse](docs/PriceListCollectionResponse.md)
 - [Model.PriceListPost](docs/PriceListPost.md)
 - [Model.PriceListPut](docs/PriceListPut.md)
 - [Model.PriceListResponse](docs/PriceListResponse.md)
 - [Model.PriceListResponse1](docs/PriceListResponse1.md)
 - [Model.PriceRecord](docs/PriceRecord.md)
 - [Model.PriceRecordBase](docs/PriceRecordBase.md)
 - [Model.PriceRecordBatchErrorResponse](docs/PriceRecordBatchErrorResponse.md)
 - [Model.PriceRecordBatchErrorSet](docs/PriceRecordBatchErrorSet.md)
 - [Model.PriceRecordBatchItem](docs/PriceRecordBatchItem.md)
 - [Model.PriceRecordCollectionPut](docs/PriceRecordCollectionPut.md)
 - [Model.PriceRecordCollectionResponse](docs/PriceRecordCollectionResponse.md)
 - [Model.PriceRecordIdentifiers](docs/PriceRecordIdentifiers.md)
 - [Model.PriceRecordPut](docs/PriceRecordPut.md)
 - [Model.PriceRecordResponse](docs/PriceRecordResponse.md)
 - [Model.SuccessBatchResponse](docs/SuccessBatchResponse.md)

<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="X-Auth-Token"></a>
### X-Auth-Token

- **Type**: API key
- **API key parameter name**: X-Auth-Token
- **Location**: HTTP header

