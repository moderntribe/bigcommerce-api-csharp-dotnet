# Catalog.Api.ProductMetafieldsApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateProductMetafield**](ProductMetafieldsApi.md#createproductmetafield) | **POST** /catalog/products/{product_id}/metafields | Create a Product Metafield
[**DeleteProductMetafieldById**](ProductMetafieldsApi.md#deleteproductmetafieldbyid) | **DELETE** /catalog/products/{product_id}/metafields/{metafield_id} | Delete a Product Metafield
[**GetProductMetafieldByProductId**](ProductMetafieldsApi.md#getproductmetafieldbyproductid) | **GET** /catalog/products/{product_id}/metafields/{metafield_id} | Get a Product Metafield
[**GetProductMetafieldsByProductId**](ProductMetafieldsApi.md#getproductmetafieldsbyproductid) | **GET** /catalog/products/{product_id}/metafields | Get All Product Metafields
[**UpdateProductMetafield**](ProductMetafieldsApi.md#updateproductmetafield) | **PUT** /catalog/products/{product_id}/metafields/{metafield_id} | Update a Product Metafield

<a name="createproductmetafield"></a>
# **CreateProductMetafield**
> MetafieldResponse1 CreateProductMetafield (MetafieldPost3 body, string accept, string contentType, int? productId)

Create a Product Metafield

Creates a *Product Metafield*.  **Required Fields:** * permission_set * namespace * key * value  **Read-Only Fields** * id  **Note:** The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class CreateProductMetafieldExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductMetafieldsApi();
            var body = new MetafieldPost3(); // MetafieldPost3 | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 

            try
            {
                // Create a Product Metafield
                MetafieldResponse1 result = apiInstance.CreateProductMetafield(body, accept, contentType, productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductMetafieldsApi.CreateProductMetafield: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MetafieldPost3**](MetafieldPost3.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 

### Return type

[**MetafieldResponse1**](MetafieldResponse1.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteproductmetafieldbyid"></a>
# **DeleteProductMetafieldById**
> void DeleteProductMetafieldById (int? metafieldId, int? productId, string accept, string contentType)

Delete a Product Metafield

Deletes a *Product Metafield*.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class DeleteProductMetafieldByIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductMetafieldsApi();
            var metafieldId = 56;  // int? | The ID of the `Metafield`. 
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)

            try
            {
                // Delete a Product Metafield
                apiInstance.DeleteProductMetafieldById(metafieldId, productId, accept, contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductMetafieldsApi.DeleteProductMetafieldById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **metafieldId** | **int?**| The ID of the &#x60;Metafield&#x60;.  | 
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]

### Return type

void (empty response body)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproductmetafieldbyproductid"></a>
# **GetProductMetafieldByProductId**
> MetafieldResponse1 GetProductMetafieldByProductId (int? metafieldId, int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null)

Get a Product Metafield

Returns a single *Product Metafield*. Optional parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class GetProductMetafieldByProductIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductMetafieldsApi();
            var metafieldId = 56;  // int? | The ID of the `Metafield`. 
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 

            try
            {
                // Get a Product Metafield
                MetafieldResponse1 result = apiInstance.GetProductMetafieldByProductId(metafieldId, productId, accept, contentType, includeFields, excludeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductMetafieldsApi.GetProductMetafieldByProductId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **metafieldId** | **int?**| The ID of the &#x60;Metafield&#x60;.  | 
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **includeFields** | **string**| Fields to include, in a comma-separated list. The ID and the specified fields will be returned. | [optional] 
 **excludeFields** | **string**| Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. | [optional] 

### Return type

[**MetafieldResponse1**](MetafieldResponse1.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproductmetafieldsbyproductid"></a>
# **GetProductMetafieldsByProductId**
> MetaFieldCollectionResponse GetProductMetafieldsByProductId (int? productId, string accept, string contentType, int? page = null, int? limit = null, string key = null, string _namespace = null, string includeFields = null, string excludeFields = null)

Get All Product Metafields

Returns a list of *Product Metafields*. Optional parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class GetProductMetafieldsByProductIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductMetafieldsApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var page = 56;  // int? | Specifies the page number in a limited (paginated) list of products. (optional) 
            var limit = 56;  // int? | Controls the number of items per page in a limited (paginated) list of products. (optional) 
            var key = key_example;  // string | Filter based on a metafield's key.  (optional) 
            var _namespace = _namespace_example;  // string | Filter based on a metafield's namespace. (optional) 
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 

            try
            {
                // Get All Product Metafields
                MetaFieldCollectionResponse result = apiInstance.GetProductMetafieldsByProductId(productId, accept, contentType, page, limit, key, _namespace, includeFields, excludeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductMetafieldsApi.GetProductMetafieldsByProductId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **page** | **int?**| Specifies the page number in a limited (paginated) list of products. | [optional] 
 **limit** | **int?**| Controls the number of items per page in a limited (paginated) list of products. | [optional] 
 **key** | **string**| Filter based on a metafield&#x27;s key.  | [optional] 
 **_namespace** | **string**| Filter based on a metafield&#x27;s namespace. | [optional] 
 **includeFields** | **string**| Fields to include, in a comma-separated list. The ID and the specified fields will be returned. | [optional] 
 **excludeFields** | **string**| Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. | [optional] 

### Return type

[**MetaFieldCollectionResponse**](MetaFieldCollectionResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateproductmetafield"></a>
# **UpdateProductMetafield**
> MetafieldResponse2 UpdateProductMetafield (MetafieldPut3 body, string accept, string contentType, int? metafieldId, int? productId)

Update a Product Metafield

Updates a *Product Metafield*.  **Required Fields** * none  **Read-Only Fields** * id * These fields can only be modified by the app (API credentials) that created the metafield:  * namespace  * key  * permission_set  **Usage Notes** * Attempting to modify `namespace`, `key`, and `permission_set` fields using a client ID different from the one used to create those metafields will result in a 403 error message. 

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class UpdateProductMetafieldExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductMetafieldsApi();
            var body = new MetafieldPut3(); // MetafieldPut3 | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var metafieldId = 56;  // int? | The ID of the `Metafield`. 
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 

            try
            {
                // Update a Product Metafield
                MetafieldResponse2 result = apiInstance.UpdateProductMetafield(body, accept, contentType, metafieldId, productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductMetafieldsApi.UpdateProductMetafield: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MetafieldPut3**](MetafieldPut3.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **metafieldId** | **int?**| The ID of the &#x60;Metafield&#x60;.  | 
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 

### Return type

[**MetafieldResponse2**](MetafieldResponse2.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
