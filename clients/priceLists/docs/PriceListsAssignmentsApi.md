# PriceLists.Api.PriceListsAssignmentsApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePriceListAssignments**](PriceListsAssignmentsApi.md#createpricelistassignments) | **POST** /pricelists/assignments | Create Price List Assignments
[**DeletePriceListAssignmentsByFilter**](PriceListsAssignmentsApi.md#deletepricelistassignmentsbyfilter) | **DELETE** /pricelists/assignments | Delete Price List Assignments
[**GetListOfPriceListAssignments**](PriceListsAssignmentsApi.md#getlistofpricelistassignments) | **GET** /pricelists/assignments | Get Price List Assignments

<a name="createpricelistassignments"></a>
# **CreatePriceListAssignments**
> Object CreatePriceListAssignments (List<Body> body)

Create Price List Assignments

Creates a batch of `Price List Assignments`.

### Example
```csharp
using System;
using System.Diagnostics;
using PriceLists.Api;
using PriceLists.Client;
using PriceLists.Model;

namespace Example
{
    public class CreatePriceListAssignmentsExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new PriceListsAssignmentsApi();
            var body = new List<Body>(); // List<Body> | A BigCommerce `Price List Assignments` request.

            try
            {
                // Create Price List Assignments
                Object result = apiInstance.CreatePriceListAssignments(body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceListsAssignmentsApi.CreatePriceListAssignments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;Body&gt;**](Body.md)| A BigCommerce &#x60;Price List Assignments&#x60; request. | 

### Return type

**Object**

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletepricelistassignmentsbyfilter"></a>
# **DeletePriceListAssignmentsByFilter**
> InlineResponse204 DeletePriceListAssignmentsByFilter (int? id = null, int? priceListId = null, int? customerGroupId = null, int? channelId = null)

Delete Price List Assignments

Deletes one or more `Price List Assignments` objects from BigCommerce using a filter.

### Example
```csharp
using System;
using System.Diagnostics;
using PriceLists.Api;
using PriceLists.Client;
using PriceLists.Model;

namespace Example
{
    public class DeletePriceListAssignmentsByFilterExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new PriceListsAssignmentsApi();
            var id = 56;  // int? | The ID of the `Price List Assignment`. (optional) 
            var priceListId = 56;  // int? | The ID of the `Price List`. (optional) 
            var customerGroupId = 56;  // int? | The ID of the `Customer Group`. (optional) 
            var channelId = 56;  // int? | The ID of the `Channel`. (optional) 

            try
            {
                // Delete Price List Assignments
                InlineResponse204 result = apiInstance.DeletePriceListAssignmentsByFilter(id, priceListId, customerGroupId, channelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceListsAssignmentsApi.DeletePriceListAssignmentsByFilter: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The ID of the &#x60;Price List Assignment&#x60;. | [optional] 
 **priceListId** | **int?**| The ID of the &#x60;Price List&#x60;. | [optional] 
 **customerGroupId** | **int?**| The ID of the &#x60;Customer Group&#x60;. | [optional] 
 **channelId** | **int?**| The ID of the &#x60;Channel&#x60;. | [optional] 

### Return type

[**InlineResponse204**](InlineResponse204.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getlistofpricelistassignments"></a>
# **GetListOfPriceListAssignments**
> InlineResponse200 GetListOfPriceListAssignments (int? id = null, int? priceListId = null, int? customerGroupId = null, int? channelId = null)

Get Price List Assignments

Fetches an array of `Price List Assignments` matching a particular Customer Group and Price List and Channel.

### Example
```csharp
using System;
using System.Diagnostics;
using PriceLists.Api;
using PriceLists.Client;
using PriceLists.Model;

namespace Example
{
    public class GetListOfPriceListAssignmentsExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new PriceListsAssignmentsApi();
            var id = 56;  // int? | The ID of the `Price List Assignment`. (optional) 
            var priceListId = 56;  // int? | The ID of the `Price List`. (optional) 
            var customerGroupId = 56;  // int? | The ID of the `Customer Group`. (optional) 
            var channelId = 56;  // int? | The ID of the `Channel`. (optional) 

            try
            {
                // Get Price List Assignments
                InlineResponse200 result = apiInstance.GetListOfPriceListAssignments(id, priceListId, customerGroupId, channelId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PriceListsAssignmentsApi.GetListOfPriceListAssignments: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| The ID of the &#x60;Price List Assignment&#x60;. | [optional] 
 **priceListId** | **int?**| The ID of the &#x60;Price List&#x60;. | [optional] 
 **customerGroupId** | **int?**| The ID of the &#x60;Customer Group&#x60;. | [optional] 
 **channelId** | **int?**| The ID of the &#x60;Channel&#x60;. | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
