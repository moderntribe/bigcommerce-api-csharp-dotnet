# BigCommerce.Api.SummaryApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetCatalogSummary**](SummaryApi.md#getcatalogsummary) | **GET** /catalog/summary | Get a Catalog Summary

<a name="getcatalogsummary"></a>
# **GetCatalogSummary**
> CatalogSummaryResponse GetCatalogSummary (string accept, string contentType)

Get a Catalog Summary

Returns a lightweight inventory summary from the BigCommerce Catalog.  The inventory summary includes: * \"inventory_count\" * \"variant_count\" * \"inventory_value\" * \"highest_variant_price\" * \"average_variant_price\" * \"lowest_variant_price\" * \"oldest_variant_date\" * \"newest_variant_date\" * \"primary_category_id\" * \"primary_category_name\"

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class GetCatalogSummaryExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new SummaryApi();
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)

            try
            {
                // Get a Catalog Summary
                CatalogSummaryResponse result = apiInstance.GetCatalogSummary(accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SummaryApi.GetCatalogSummary: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]

### Return type

[**CatalogSummaryResponse**](CatalogSummaryResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
