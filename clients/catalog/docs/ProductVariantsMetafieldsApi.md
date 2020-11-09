# Catalog.Api.ProductVariantsMetafieldsApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateVariantMetafield**](ProductVariantsMetafieldsApi.md#createvariantmetafield) | **POST** /catalog/products/{product_id}/variants/{variant_id}/metafields | Create a Product Variant Metafield
[**DeleteVariantMetafieldById**](ProductVariantsMetafieldsApi.md#deletevariantmetafieldbyid) | **DELETE** /catalog/products/{product_id}/variants/{variant_id}/metafields/{metafield_id} | Delete a Variant Metafield
[**GetVariantMetafieldByProductIdAndVariantId**](ProductVariantsMetafieldsApi.md#getvariantmetafieldbyproductidandvariantid) | **GET** /catalog/products/{product_id}/variants/{variant_id}/metafields/{metafield_id} | Get Product Variant Metafields
[**GetVariantMetafieldsByProductIdAndVariantId**](ProductVariantsMetafieldsApi.md#getvariantmetafieldsbyproductidandvariantid) | **GET** /catalog/products/{product_id}/variants/{variant_id}/metafields | Get Product Variant Metafields
[**UpdateVariantMetafield**](ProductVariantsMetafieldsApi.md#updatevariantmetafield) | **PUT** /catalog/products/{product_id}/variants/{variant_id}/metafields/{metafield_id} | Update Product Variant Metafields

<a name="createvariantmetafield"></a>
# **CreateVariantMetafield**
> MetafieldResponse2 CreateVariantMetafield (MetafieldPost body, string accept, string contentType, int? productId, int? variantId)

Create a Product Variant Metafield

Creates a product variant *Metafield*.  **Required Fields:** * permission_set * namespace * key * value  **Read-Only Fields** * id  **Note:** The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class CreateVariantMetafieldExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductVariantsMetafieldsApi();
            var body = new MetafieldPost(); // MetafieldPost | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var variantId = 56;  // int? | ID of the variant on a product, or on an associated Price List Record. 

            try
            {
                // Create a Product Variant Metafield
                MetafieldResponse2 result = apiInstance.CreateVariantMetafield(body, accept, contentType, productId, variantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductVariantsMetafieldsApi.CreateVariantMetafield: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MetafieldPost**](MetafieldPost.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **variantId** | **int?**| ID of the variant on a product, or on an associated Price List Record.  | 

### Return type

[**MetafieldResponse2**](MetafieldResponse2.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletevariantmetafieldbyid"></a>
# **DeleteVariantMetafieldById**
> void DeleteVariantMetafieldById (int? metafieldId, int? productId, int? variantId, string accept, string contentType)

Delete a Variant Metafield

Deletes a product variant *Metafield*.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class DeleteVariantMetafieldByIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductVariantsMetafieldsApi();
            var metafieldId = 56;  // int? | The ID of the `Metafield`. 
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var variantId = 56;  // int? | ID of the variant on a product, or on an associated Price List Record. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)

            try
            {
                // Delete a Variant Metafield
                apiInstance.DeleteVariantMetafieldById(metafieldId, productId, variantId, accept, contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductVariantsMetafieldsApi.DeleteVariantMetafieldById: " + e.Message );
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
 **variantId** | **int?**| ID of the variant on a product, or on an associated Price List Record.  | 
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
<a name="getvariantmetafieldbyproductidandvariantid"></a>
# **GetVariantMetafieldByProductIdAndVariantId**
> MetafieldResponse1 GetVariantMetafieldByProductIdAndVariantId (int? metafieldId, int? productId, int? variantId, string accept, string contentType, string includeFields = null, string excludeFields = null)

Get Product Variant Metafields

Returns a single product variant *Metafield*. Optional parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class GetVariantMetafieldByProductIdAndVariantIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductVariantsMetafieldsApi();
            var metafieldId = 56;  // int? | The ID of the `Metafield`. 
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var variantId = 56;  // int? | ID of the variant on a product, or on an associated Price List Record. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 

            try
            {
                // Get Product Variant Metafields
                MetafieldResponse1 result = apiInstance.GetVariantMetafieldByProductIdAndVariantId(metafieldId, productId, variantId, accept, contentType, includeFields, excludeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductVariantsMetafieldsApi.GetVariantMetafieldByProductIdAndVariantId: " + e.Message );
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
 **variantId** | **int?**| ID of the variant on a product, or on an associated Price List Record.  | 
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
<a name="getvariantmetafieldsbyproductidandvariantid"></a>
# **GetVariantMetafieldsByProductIdAndVariantId**
> MetaFieldCollectionResponse1 GetVariantMetafieldsByProductIdAndVariantId (int? productId, int? variantId, string accept, string contentType, int? page = null, int? limit = null, string key = null, string _namespace = null, string includeFields = null, string excludeFields = null)

Get Product Variant Metafields

Returns a list of product variant *Metafields*. Optional parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class GetVariantMetafieldsByProductIdAndVariantIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductVariantsMetafieldsApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var variantId = 56;  // int? | ID of the variant on a product, or on an associated Price List Record. 
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
                // Get Product Variant Metafields
                MetaFieldCollectionResponse1 result = apiInstance.GetVariantMetafieldsByProductIdAndVariantId(productId, variantId, accept, contentType, page, limit, key, _namespace, includeFields, excludeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductVariantsMetafieldsApi.GetVariantMetafieldsByProductIdAndVariantId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **variantId** | **int?**| ID of the variant on a product, or on an associated Price List Record.  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **page** | **int?**| Specifies the page number in a limited (paginated) list of products. | [optional] 
 **limit** | **int?**| Controls the number of items per page in a limited (paginated) list of products. | [optional] 
 **key** | **string**| Filter based on a metafield&#x27;s key.  | [optional] 
 **_namespace** | **string**| Filter based on a metafield&#x27;s namespace. | [optional] 
 **includeFields** | **string**| Fields to include, in a comma-separated list. The ID and the specified fields will be returned. | [optional] 
 **excludeFields** | **string**| Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. | [optional] 

### Return type

[**MetaFieldCollectionResponse1**](MetaFieldCollectionResponse1.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatevariantmetafield"></a>
# **UpdateVariantMetafield**
> MetafieldResponse1 UpdateVariantMetafield (MetafieldPut4 body, string accept, string contentType, int? metafieldId, int? productId, int? variantId)

Update Product Variant Metafields

Updates a product variant *Metafield*.  **Required Fields:** * none  **Read-Only Fields** * id * These fields can only be modified by the app (API credentials) that created the metafield:  * namespace  * key  * permission_set  **Usage Notes** * Attempting to modify `namespace`, `key`, and `permission_set` fields using a client ID different from the one used to create those metafields will result in a 403 error message. 

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class UpdateVariantMetafieldExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductVariantsMetafieldsApi();
            var body = new MetafieldPut4(); // MetafieldPut4 | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var metafieldId = 56;  // int? | The ID of the `Metafield`. 
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var variantId = 56;  // int? | ID of the variant on a product, or on an associated Price List Record. 

            try
            {
                // Update Product Variant Metafields
                MetafieldResponse1 result = apiInstance.UpdateVariantMetafield(body, accept, contentType, metafieldId, productId, variantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductVariantsMetafieldsApi.UpdateVariantMetafield: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MetafieldPut4**](MetafieldPut4.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **metafieldId** | **int?**| The ID of the &#x60;Metafield&#x60;.  | 
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **variantId** | **int?**| ID of the variant on a product, or on an associated Price List Record.  | 

### Return type

[**MetafieldResponse1**](MetafieldResponse1.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
