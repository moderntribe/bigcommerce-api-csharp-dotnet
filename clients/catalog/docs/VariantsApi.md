# Catalog.Api.VariantsApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetVariants**](VariantsApi.md#getvariants) | **GET** /catalog/variants | Get All Variants
[**UpdateVariantsBatch**](VariantsApi.md#updatevariantsbatch) | **PUT** /catalog/variants | Update Variants (Batch)

<a name="getvariants"></a>
# **GetVariants**
> VariantCollectionResponse1 GetVariants (string accept, string contentType, int? id = null, string sku = null, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null, string productId = null)

Get All Variants

Returns a list of all variants in your catalog. Optional parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class GetVariantsExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new VariantsApi();
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var id = 56;  // int? | Filter items by id.  (optional) 
            var sku = sku_example;  // string | Filter items by sku.  (optional) 
            var page = 56;  // int? | Specifies the page number in a limited (paginated) list of products. (optional) 
            var limit = 56;  // int? | Controls the number of items per page in a limited (paginated) list of products. (optional) 
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 
            var productId = productId_example;  // string | A comma-separated list of ids of Products whose prices were requested. For example: `?product_id=:id` `?product_id:in=77,80,81` (optional) 

            try
            {
                // Get All Variants
                VariantCollectionResponse1 result = apiInstance.GetVariants(accept, contentType, id, sku, page, limit, includeFields, excludeFields, productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VariantsApi.GetVariants: " + e.Message );
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
 **id** | **int?**| Filter items by id.  | [optional] 
 **sku** | **string**| Filter items by sku.  | [optional] 
 **page** | **int?**| Specifies the page number in a limited (paginated) list of products. | [optional] 
 **limit** | **int?**| Controls the number of items per page in a limited (paginated) list of products. | [optional] 
 **includeFields** | **string**| Fields to include, in a comma-separated list. The ID and the specified fields will be returned. | [optional] 
 **excludeFields** | **string**| Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. | [optional] 
 **productId** | **string**| A comma-separated list of ids of Products whose prices were requested. For example: &#x60;?product_id&#x3D;:id&#x60; &#x60;?product_id:in&#x3D;77,80,81&#x60; | [optional] 

### Return type

[**VariantCollectionResponse1**](VariantCollectionResponse1.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatevariantsbatch"></a>
# **UpdateVariantsBatch**
> VariantCollectionResponse2 UpdateVariantsBatch (List<Object> body, string accept, string contentType)

Update Variants (Batch)

Creates or updates a batch of `Variant` objects. At the time of writing, the current limit is `50` variants. This limit is subject to change.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class UpdateVariantsBatchExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new VariantsApi();
            var body = new List<Object>(); // List<Object> | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)

            try
            {
                // Update Variants (Batch)
                VariantCollectionResponse2 result = apiInstance.UpdateVariantsBatch(body, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling VariantsApi.UpdateVariantsBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;Object&gt;**](Object.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]

### Return type

[**VariantCollectionResponse2**](VariantCollectionResponse2.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
