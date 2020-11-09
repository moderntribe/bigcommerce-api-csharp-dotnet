# PriceLists.Api.PriceListsApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePriceList**](PriceListsApi.md#createpricelist) | **POST** /pricelists | Create a Price List
[**DeletePriceList**](PriceListsApi.md#deletepricelist) | **DELETE** /pricelists/{price_list_id} | Delete a Price List
[**DeletePriceListsByFilter**](PriceListsApi.md#deletepricelistsbyfilter) | **DELETE** /pricelists | Delete All Price Lists
[**GetPriceList**](PriceListsApi.md#getpricelist) | **GET** /pricelists/{price_list_id} | Get a Price List
[**GetPriceListCollection**](PriceListsApi.md#getpricelistcollection) | **GET** /pricelists | Get All Price Lists
[**UpdatePriceList**](PriceListsApi.md#updatepricelist) | **PUT** /pricelists/{price_list_id} | Update a Price List

<a name="createpricelist"></a>
# **CreatePriceList**
> PriceListResponse CreatePriceList (PriceListPost body, string accept = null, string contentType = null)

Create a Price List

Creates a *Price List*.  **Required Fields** * name

### Example
```csharp
using System;
using System.Diagnostics;
using PriceLists.Api;
using PriceLists.Client;
using PriceLists.Model;

namespace Example
{
    public class CreatePriceListExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PriceListPost**](PriceListPost.md)|  | 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

[**PriceListResponse**](PriceListResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletepricelist"></a>
# **DeletePriceList**
> void DeletePriceList (int? priceListId)

Delete a Price List

Deletes a *Price List*. All associated price records are also removed.

### Example
```csharp
using System;
using System.Diagnostics;
using PriceLists.Api;
using PriceLists.Client;
using PriceLists.Model;

namespace Example
{
    public class DeletePriceListExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new PriceListsApi();
            var priceListId = 56;  // int? | The ID of the `Price List` requested. 

            try
            {
                // Delete a Price List
                apiInstance.DeletePriceList(priceListId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceListsApi.DeletePriceList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **priceListId** | **int?**| The ID of the &#x60;Price List&#x60; requested.  | 

### Return type

void (empty response body)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletepricelistsbyfilter"></a>
# **DeletePriceListsByFilter**
> void DeletePriceListsByFilter (int? id = null, string name = null, string accept = null, string contentType = null)

Delete All Price Lists

Deletes a *Price List*. All associated price records are also removed. Optional parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using PriceLists.Api;
using PriceLists.Client;
using PriceLists.Model;

namespace Example
{
    public class DeletePriceListsByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new PriceListsApi();
            var id = 56;  // int? | Filter items by id.  (optional) 
            var name = name_example;  // string | Filter items by name.  (optional) 
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Delete All Price Lists
                apiInstance.DeletePriceListsByFilter(id, name, accept, contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceListsApi.DeletePriceListsByFilter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Filter items by id.  | [optional] 
 **name** | **string**| Filter items by name.  | [optional] 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

void (empty response body)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpricelist"></a>
# **GetPriceList**
> PriceListResponse1 GetPriceList (int? priceListId, int? id = null, string name = null, DateTime? dateCreated = null, DateTime? dateModified = null, int? page = null, int? limit = null)

Get a Price List

 Returns a single *Price List*.

### Example
```csharp
using System;
using System.Diagnostics;
using PriceLists.Api;
using PriceLists.Client;
using PriceLists.Model;

namespace Example
{
    public class GetPriceListExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new PriceListsApi();
            var priceListId = 56;  // int? | The ID of the `Price List` requested. 
            var id = 56;  // int? | Filter items by id. (optional) 
            var name = name_example;  // string | Filter items by name. (optional) 
            var dateCreated = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter items by date_created. (optional) 
            var dateModified = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter items by date_modified. For example `v3/catalog/products?date_last_imported:min=2018-06-15` (optional) 
            var page = 56;  // int? | Specifies the page number in a limited (paginated) list of products. (optional) 
            var limit = 56;  // int? | Controls the number of items per page in a limited (paginated) list of products. (optional) 

            try
            {
                // Get a Price List
                PriceListResponse1 result = apiInstance.GetPriceList(priceListId, id, name, dateCreated, dateModified, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceListsApi.GetPriceList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **priceListId** | **int?**| The ID of the &#x60;Price List&#x60; requested.  | 
 **id** | **int?**| Filter items by id. | [optional] 
 **name** | **string**| Filter items by name. | [optional] 
 **dateCreated** | **DateTime?**| Filter items by date_created. | [optional] 
 **dateModified** | **DateTime?**| Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; | [optional] 
 **page** | **int?**| Specifies the page number in a limited (paginated) list of products. | [optional] 
 **limit** | **int?**| Controls the number of items per page in a limited (paginated) list of products. | [optional] 

### Return type

[**PriceListResponse1**](PriceListResponse1.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getpricelistcollection"></a>
# **GetPriceListCollection**
> PriceListCollectionResponse GetPriceListCollection (int? id = null, string name = null, DateTime? dateCreated = null, DateTime? dateModified = null, int? page = null, int? limit = null, string contentType = null, string accept = null)

Get All Price Lists

Returns a list of *Price Lists*. Optional parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using PriceLists.Api;
using PriceLists.Client;
using PriceLists.Model;

namespace Example
{
    public class GetPriceListCollectionExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new PriceListsApi();
            var id = 56;  // int? | Filter items by id.  (optional) 
            var name = name_example;  // string | Filter items by name.  (optional) 
            var dateCreated = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter items by date_created.  (optional) 
            var dateModified = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter items by date_modified. For example `v3/catalog/products?date_last_imported:min=2018-06-15` (optional) 
            var page = 56;  // int? | Specifies the page number in a limited (paginated) list of products. (optional) 
            var limit = 56;  // int? | Controls the number of items per page in a limited (paginated) list of products. (optional) 
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)
            var accept = accept_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Get All Price Lists
                PriceListCollectionResponse result = apiInstance.GetPriceListCollection(id, name, dateCreated, dateModified, page, limit, contentType, accept);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceListsApi.GetPriceListCollection: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Filter items by id.  | [optional] 
 **name** | **string**| Filter items by name.  | [optional] 
 **dateCreated** | **DateTime?**| Filter items by date_created.  | [optional] 
 **dateModified** | **DateTime?**| Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; | [optional] 
 **page** | **int?**| Specifies the page number in a limited (paginated) list of products. | [optional] 
 **limit** | **int?**| Controls the number of items per page in a limited (paginated) list of products. | [optional] 
 **contentType** | **string**|  | [optional] [default to application/json]
 **accept** | **string**|  | [optional] [default to application/json]

### Return type

[**PriceListCollectionResponse**](PriceListCollectionResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatepricelist"></a>
# **UpdatePriceList**
> PriceListResponse UpdatePriceList (PriceListPut body, int? priceListId)

Update a Price List

Updates a *Price List*.

### Example
```csharp
using System;
using System.Diagnostics;
using PriceLists.Api;
using PriceLists.Client;
using PriceLists.Model;

namespace Example
{
    public class UpdatePriceListExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new PriceListsApi();
            var body = new PriceListPut(); // PriceListPut | 
            var priceListId = 56;  // int? | The ID of the `Price List` requested. 

            try
            {
                // Update a Price List
                PriceListResponse result = apiInstance.UpdatePriceList(body, priceListId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceListsApi.UpdatePriceList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PriceListPut**](PriceListPut.md)|  | 
 **priceListId** | **int?**| The ID of the &#x60;Price List&#x60; requested.  | 

### Return type

[**PriceListResponse**](PriceListResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
