# BigCommerce.Api.PriceListsRecordsApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletePriceListRecord**](PriceListsRecordsApi.md#deletepricelistrecord) | **DELETE** /pricelists/{price_list_id}/records/{variant_id}/{currency_code} | Delete a Price Record by Currency Code
[**DeletePriceListRecordsByFilter**](PriceListsRecordsApi.md#deletepricelistrecordsbyfilter) | **DELETE** /pricelists/{price_list_id}/records | Delete a Price List Record
[**GetPriceListRecord**](PriceListsRecordsApi.md#getpricelistrecord) | **GET** /pricelists/{price_list_id}/records/{variant_id}/{currency_code} | Get a Price Record by Currency Code
[**GetPriceListRecordCollection**](PriceListsRecordsApi.md#getpricelistrecordcollection) | **GET** /pricelists/{price_list_id}/records | Get All Price List Records
[**GetPriceListRecordsByVariantId**](PriceListsRecordsApi.md#getpricelistrecordsbyvariantid) | **GET** /pricelists/{price_list_id}/records/{variant_id} | Get Price Records by Variant
[**SetPriceListRecord**](PriceListsRecordsApi.md#setpricelistrecord) | **PUT** /pricelists/{price_list_id}/records/{variant_id}/{currency_code} | Set Price List Record by Currency Code
[**SetPriceListRecordCollection**](PriceListsRecordsApi.md#setpricelistrecordcollection) | **PUT** /pricelists/{price_list_id}/records | Upsert Price List Records

<a name="deletepricelistrecord"></a>
# **DeletePriceListRecord**
> void DeletePriceListRecord (int? priceListId, int? variantId, string currencyCode, string contentType = null, string accept = null)

Delete a Price Record by Currency Code

Deletes a *Price List Record* using the currency code. 

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class DeletePriceListRecordExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new PriceListsRecordsApi();
            var priceListId = 56;  // int? | The ID of the `Price List` requested. 
            var variantId = 56;  // int? | ID of the variant on a product, or on an associated Price List Record. 
            var currencyCode = currencyCode_example;  // string | The currency code associated with the price record being acted upon. 
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)
            var accept = accept_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Delete a Price Record by Currency Code
                apiInstance.DeletePriceListRecord(priceListId, variantId, currencyCode, contentType, accept);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceListsRecordsApi.DeletePriceListRecord: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **priceListId** | **int?**| The ID of the &#x60;Price List&#x60; requested.  | 
 **variantId** | **int?**| ID of the variant on a product, or on an associated Price List Record.  | 
 **currencyCode** | **string**| The currency code associated with the price record being acted upon.  | 
 **contentType** | **string**|  | [optional] [default to application/json]
 **accept** | **string**|  | [optional] [default to application/json]

### Return type

void (empty response body)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletepricelistrecordsbyfilter"></a>
# **DeletePriceListRecordsByFilter**
> NoContent DeletePriceListRecordsByFilter (int? priceListId, int? variantIdin = null, string accept = null, string contentType = null)

Delete a Price List Record

Deletes a *Price List Record*. Deleting the records does not delete the Price List. Optional parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class DeletePriceListRecordsByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new PriceListsRecordsApi();
            var priceListId = 56;  // int? | The ID of the `Price List` requested. 
            var variantIdin = 56;  // int? | The ID of the `Variant` whose prices were requested. (optional) 
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Delete a Price List Record
                NoContent result = apiInstance.DeletePriceListRecordsByFilter(priceListId, variantIdin, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceListsRecordsApi.DeletePriceListRecordsByFilter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **priceListId** | **int?**| The ID of the &#x60;Price List&#x60; requested.  | 
 **variantIdin** | **int?**| The ID of the &#x60;Variant&#x60; whose prices were requested. | [optional] 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

[**NoContent**](NoContent.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpricelistrecord"></a>
# **GetPriceListRecord**
> PriceRecordResponse GetPriceListRecord (int? priceListId, int? variantId, string currencyCode, string include = null, string accept = null, string contentType = null)

Get a Price Record by Currency Code

Returns a *Price List Record* using the currency code. Optional parameters can be used.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class GetPriceListRecordExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new PriceListsRecordsApi();
            var priceListId = 56;  // int? | The ID of the `Price List` requested. 
            var variantId = 56;  // int? | ID of the variant on a product, or on an associated Price List Record. 
            var currencyCode = currencyCode_example;  // string | The currency code associated with the price record being acted upon. 
            var include = include_example;  // string | Sub-resources to include on a price record, in a comma-separated list. Valid expansions currently include `bulk_pricing_tiers` and `sku`.  Other valies will be ignored.  (optional) 
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Get a Price Record by Currency Code
                PriceRecordResponse result = apiInstance.GetPriceListRecord(priceListId, variantId, currencyCode, include, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceListsRecordsApi.GetPriceListRecord: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **priceListId** | **int?**| The ID of the &#x60;Price List&#x60; requested.  | 
 **variantId** | **int?**| ID of the variant on a product, or on an associated Price List Record.  | 
 **currencyCode** | **string**| The currency code associated with the price record being acted upon.  | 
 **include** | **string**| Sub-resources to include on a price record, in a comma-separated list. Valid expansions currently include &#x60;bulk_pricing_tiers&#x60; and &#x60;sku&#x60;.  Other valies will be ignored.  | [optional] 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

[**PriceRecordResponse**](PriceRecordResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpricelistrecordcollection"></a>
# **GetPriceListRecordCollection**
> PriceRecordCollectionResponse GetPriceListRecordCollection (int? priceListId, int? variantIdin = null, string productIdin = null, string currency = null, int? page = null, int? limit = null, string include = null, decimal? price = null, decimal? salePrice = null, decimal? retailPrice = null, decimal? mapPrice = null, decimal? calculatedPrice = null, DateTime? dateCreated = null, DateTime? dateModified = null, string sku = null, string contentType = null, string accept = null)

Get All Price List Records

Returns a list of *Price List Records* associated with a *Price List*.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class GetPriceListRecordCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new PriceListsRecordsApi();
            var priceListId = 56;  // int? | The ID of the `Price List` requested. 
            var variantIdin = 56;  // int? | The ID of the `Variant` whose prices were requested. (optional) 
            var productIdin = productIdin_example;  // string | A comma-separated list of ids of `Product`s whose prices were requested.  (optional) 
            var currency = currency_example;  // string | Filter items by currency.  (optional) 
            var page = 56;  // int? | Specifies the page number in a limited (paginated) list of products. (optional) 
            var limit = 56;  // int? | Controls the number of items per page in a limited (paginated) list of products. (optional) 
            var include = include_example;  // string | Sub-resources to include on a price record, in a comma-separated list. Valid expansions currently include `bulk_pricing_tiers` and `sku`.  Other valies will be ignored.  (optional) 
            var price = 1.2;  // decimal? | Filter items by price.  (optional) 
            var salePrice = 1.2;  // decimal? | Filter items by sale_price.  (optional) 
            var retailPrice = 1.2;  // decimal? | Filter items by retail_price.  (optional) 
            var mapPrice = 1.2;  // decimal? | Filter items by map_price.  (optional) 
            var calculatedPrice = 1.2;  // decimal? | Filter items by calculated_price.  (optional) 
            var dateCreated = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter items by date_created.  (optional) 
            var dateModified = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter items by date_modified. For example `v3/catalog/products?date_last_imported:min=2018-06-15` (optional) 
            var sku = sku_example;  // string | Filter items by sku.  (optional) 
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)
            var accept = accept_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Get All Price List Records
                PriceRecordCollectionResponse result = apiInstance.GetPriceListRecordCollection(priceListId, variantIdin, productIdin, currency, page, limit, include, price, salePrice, retailPrice, mapPrice, calculatedPrice, dateCreated, dateModified, sku, contentType, accept);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceListsRecordsApi.GetPriceListRecordCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **priceListId** | **int?**| The ID of the &#x60;Price List&#x60; requested.  | 
 **variantIdin** | **int?**| The ID of the &#x60;Variant&#x60; whose prices were requested. | [optional] 
 **productIdin** | **string**| A comma-separated list of ids of &#x60;Product&#x60;s whose prices were requested.  | [optional] 
 **currency** | **string**| Filter items by currency.  | [optional] 
 **page** | **int?**| Specifies the page number in a limited (paginated) list of products. | [optional] 
 **limit** | **int?**| Controls the number of items per page in a limited (paginated) list of products. | [optional] 
 **include** | **string**| Sub-resources to include on a price record, in a comma-separated list. Valid expansions currently include &#x60;bulk_pricing_tiers&#x60; and &#x60;sku&#x60;.  Other valies will be ignored.  | [optional] 
 **price** | **decimal?**| Filter items by price.  | [optional] 
 **salePrice** | **decimal?**| Filter items by sale_price.  | [optional] 
 **retailPrice** | **decimal?**| Filter items by retail_price.  | [optional] 
 **mapPrice** | **decimal?**| Filter items by map_price.  | [optional] 
 **calculatedPrice** | **decimal?**| Filter items by calculated_price.  | [optional] 
 **dateCreated** | **DateTime?**| Filter items by date_created.  | [optional] 
 **dateModified** | **DateTime?**| Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; | [optional] 
 **sku** | **string**| Filter items by sku.  | [optional] 
 **contentType** | **string**|  | [optional] [default to application/json]
 **accept** | **string**|  | [optional] [default to application/json]

### Return type

[**PriceRecordCollectionResponse**](PriceRecordCollectionResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpricelistrecordsbyvariantid"></a>
# **GetPriceListRecordsByVariantId**
> PriceRecordCollectionResponse GetPriceListRecordsByVariantId (int? priceListId, int? variantId, string accept = null, string contentType = null)

Get Price Records by Variant

Returns *Price List Records* using the variant ID. Will also contain currency records.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class GetPriceListRecordsByVariantIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new PriceListsRecordsApi();
            var priceListId = 56;  // int? | The ID of the `Price List` requested. 
            var variantId = 56;  // int? | ID of the variant on a product, or on an associated Price List Record. 
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Get Price Records by Variant
                PriceRecordCollectionResponse result = apiInstance.GetPriceListRecordsByVariantId(priceListId, variantId, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceListsRecordsApi.GetPriceListRecordsByVariantId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **priceListId** | **int?**| The ID of the &#x60;Price List&#x60; requested.  | 
 **variantId** | **int?**| ID of the variant on a product, or on an associated Price List Record.  | 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

[**PriceRecordCollectionResponse**](PriceRecordCollectionResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="setpricelistrecord"></a>
# **SetPriceListRecord**
> PriceRecordResponse SetPriceListRecord (PriceRecordPut body, int? priceListId, int? variantId, string currencyCode, string accept = null, string contentType = null)

Set Price List Record by Currency Code

Creates or updates a*Price List Record* using the currency code.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class SetPriceListRecordExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new PriceListsRecordsApi();
            var body = new PriceRecordPut(); // PriceRecordPut | 
            var priceListId = 56;  // int? | The ID of the `Price List` requested. 
            var variantId = 56;  // int? | ID of the variant on a product, or on an associated Price List Record. 
            var currencyCode = currencyCode_example;  // string | The currency code associated with the price record being acted upon. 
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Set Price List Record by Currency Code
                PriceRecordResponse result = apiInstance.SetPriceListRecord(body, priceListId, variantId, currencyCode, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceListsRecordsApi.SetPriceListRecord: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PriceRecordPut**](PriceRecordPut.md)|  | 
 **priceListId** | **int?**| The ID of the &#x60;Price List&#x60; requested.  | 
 **variantId** | **int?**| ID of the variant on a product, or on an associated Price List Record.  | 
 **currencyCode** | **string**| The currency code associated with the price record being acted upon.  | 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

[**PriceRecordResponse**](PriceRecordResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="setpricelistrecordcollection"></a>
# **SetPriceListRecordCollection**
> Object SetPriceListRecordCollection (List<Object> body, int? priceListId, int? xStrictMode = null, string accept = null, string contentType = null)

Upsert Price List Records

Creates or updates *Price List Records*.   **Required Fields** * currency  **Notes**  * Batch updates are supported by this endpoint, meaning that several price objects can be updated in one request. This allows you to do the same work as many individual requests to singleton endpoints * Batch requests support up to 1,000 items per request. * Up to 2 concurrent batch upsert requests are supported with this API. Running more than the allowed concurrent requests in parallel on the **same store** will cause a 429 error and your additional requests will fail. You are encouraged to run requests sequentially with as many records per request as possible, in order to maximize performance.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class SetPriceListRecordCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new PriceListsRecordsApi();
            var body = new List<Object>(); // List<Object> | 
            var priceListId = 56;  // int? | The ID of the `Price List` requested. 
            var xStrictMode = 56;  // int? | Header that determines whether the Batch API operates in strict mode or not.  Strict mode will reject the entire request if any item in the batch has an error.  (optional)  (default to 0)
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Upsert Price List Records
                Object result = apiInstance.SetPriceListRecordCollection(body, priceListId, xStrictMode, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceListsRecordsApi.SetPriceListRecordCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;Object&gt;**](Object.md)|  | 
 **priceListId** | **int?**| The ID of the &#x60;Price List&#x60; requested.  | 
 **xStrictMode** | **int?**| Header that determines whether the Batch API operates in strict mode or not.  Strict mode will reject the entire request if any item in the batch has an error.  | [optional] [default to 0]
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

**Object**

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
