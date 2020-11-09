# Catalog.Api.BrandMetafieldsApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBrandMetafield**](BrandMetafieldsApi.md#createbrandmetafield) | **POST** /catalog/brands/{brand_id}/metafields | Create a Brand Metafield
[**DeleteBrandMetafieldById**](BrandMetafieldsApi.md#deletebrandmetafieldbyid) | **DELETE** /catalog/brands/{brand_id}/metafields/{metafield_id} | Delete a Brand Metafield
[**GetBrandMetafieldByBrandId**](BrandMetafieldsApi.md#getbrandmetafieldbybrandid) | **GET** /catalog/brands/{brand_id}/metafields/{metafield_id} | Get a Brand Metafields
[**GetBrandMetafieldsByBrandId**](BrandMetafieldsApi.md#getbrandmetafieldsbybrandid) | **GET** /catalog/brands/{brand_id}/metafields | Get All Brand Metafields
[**UpdateBrandMetafield**](BrandMetafieldsApi.md#updatebrandmetafield) | **PUT** /catalog/brands/{brand_id}/metafields/{metafield_id} | Update a Brand Metafield

<a name="createbrandmetafield"></a>
# **CreateBrandMetafield**
> MetafieldResponse CreateBrandMetafield (MetafieldPost1 body, string contentType, string accept, int? brandId)

Create a Brand Metafield

Creates a *Brand Metafield*.  **Required Fields** - permission_set - namespace - key - value  **Read-Only Fields** - id  **Note:** The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class CreateBrandMetafieldExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new BrandMetafieldsApi();
            var body = new MetafieldPost1(); // MetafieldPost1 | 
            var contentType = contentType_example;  // string |  (default to application/json)
            var accept = accept_example;  // string |  (default to application/json)
            var brandId = 56;  // int? | The ID of the `Brand` to which the resource belongs. 

            try
            {
                // Create a Brand Metafield
                MetafieldResponse result = apiInstance.CreateBrandMetafield(body, contentType, accept, brandId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandMetafieldsApi.CreateBrandMetafield: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MetafieldPost1**](MetafieldPost1.md)|  | 
 **contentType** | **string**|  | [default to application/json]
 **accept** | **string**|  | [default to application/json]
 **brandId** | **int?**| The ID of the &#x60;Brand&#x60; to which the resource belongs.  | 

### Return type

[**MetafieldResponse**](MetafieldResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletebrandmetafieldbyid"></a>
# **DeleteBrandMetafieldById**
> void DeleteBrandMetafieldById (int? metafieldId, int? brandId, string accept, string contentType)

Delete a Brand Metafield

Deletes a *Brand Metafield*.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class DeleteBrandMetafieldByIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new BrandMetafieldsApi();
            var metafieldId = 56;  // int? | The ID of the `Metafield`. 
            var brandId = 56;  // int? | The ID of the `Brand` to which the resource belongs. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)

            try
            {
                // Delete a Brand Metafield
                apiInstance.DeleteBrandMetafieldById(metafieldId, brandId, accept, contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandMetafieldsApi.DeleteBrandMetafieldById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **metafieldId** | **int?**| The ID of the &#x60;Metafield&#x60;.  | 
 **brandId** | **int?**| The ID of the &#x60;Brand&#x60; to which the resource belongs.  | 
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
<a name="getbrandmetafieldbybrandid"></a>
# **GetBrandMetafieldByBrandId**
> MetafieldResponse1 GetBrandMetafieldByBrandId (int? metafieldId, int? brandId, string accept, string contentType, string includeFields = null, string excludeFields = null)

Get a Brand Metafields

Returns a *Brand Metafield*. Optional filter parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class GetBrandMetafieldByBrandIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new BrandMetafieldsApi();
            var metafieldId = 56;  // int? | The ID of the `Metafield`. 
            var brandId = 56;  // int? | The ID of the `Brand` to which the resource belongs. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 

            try
            {
                // Get a Brand Metafields
                MetafieldResponse1 result = apiInstance.GetBrandMetafieldByBrandId(metafieldId, brandId, accept, contentType, includeFields, excludeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandMetafieldsApi.GetBrandMetafieldByBrandId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **metafieldId** | **int?**| The ID of the &#x60;Metafield&#x60;.  | 
 **brandId** | **int?**| The ID of the &#x60;Brand&#x60; to which the resource belongs.  | 
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
<a name="getbrandmetafieldsbybrandid"></a>
# **GetBrandMetafieldsByBrandId**
> MetaFieldCollectionResponse GetBrandMetafieldsByBrandId (int? brandId, string contentType, string accept, int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, int? page = null, int? limit = null, string key = null, string _namespace = null, string includeFields = null, string excludeFields = null)

Get All Brand Metafields

Returns a list of *Brand Metafields*. Optional filter parameters can be passed in. 

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class GetBrandMetafieldsByBrandIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new BrandMetafieldsApi();
            var brandId = 56;  // int? | The ID of the `Brand` to which the resource belongs. 
            var contentType = contentType_example;  // string |  (default to application/json)
            var accept = accept_example;  // string |  (default to application/json)
            var id = 56;  // int? | Filter items by id.  (optional) 
            var idin = new List<int?>(); // List<int?> |  (optional) 
            var idnotIn = new List<int?>(); // List<int?> |  (optional) 
            var idmin = new List<int?>(); // List<int?> |  (optional) 
            var idmax = new List<int?>(); // List<int?> |  (optional) 
            var idgreater = new List<int?>(); // List<int?> |  (optional) 
            var idless = new List<int?>(); // List<int?> |  (optional) 
            var page = 56;  // int? | Specifies the page number in a limited (paginated) list of products. (optional) 
            var limit = 56;  // int? | Controls the number of items per page in a limited (paginated) list of products. (optional) 
            var key = key_example;  // string | Filter based on a metafield's key.  (optional) 
            var _namespace = _namespace_example;  // string | Filter based on a metafield's namespace. (optional) 
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 

            try
            {
                // Get All Brand Metafields
                MetaFieldCollectionResponse result = apiInstance.GetBrandMetafieldsByBrandId(brandId, contentType, accept, id, idin, idnotIn, idmin, idmax, idgreater, idless, page, limit, key, _namespace, includeFields, excludeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandMetafieldsApi.GetBrandMetafieldsByBrandId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **brandId** | **int?**| The ID of the &#x60;Brand&#x60; to which the resource belongs.  | 
 **contentType** | **string**|  | [default to application/json]
 **accept** | **string**|  | [default to application/json]
 **id** | **int?**| Filter items by id.  | [optional] 
 **idin** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **idnotIn** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **idmin** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **idmax** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **idgreater** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **idless** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
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
<a name="updatebrandmetafield"></a>
# **UpdateBrandMetafield**
> MetafieldResponse1 UpdateBrandMetafield (MetafieldPut1 body, string accept, string contentType, int? metafieldId, int? brandId)

Update a Brand Metafield

Updates a *Brand Metafield*.  **Required Fields**   * none  **Read-Only Fields** * id * These fields can only be modified by the app (API credentials) that created the metafield:  * namespace  * key  * permission_set  **Usage Notes** * Attempting to modify `namespace`, `key`, and `permission_set` fields using a client ID different from the one used to create those metafields will result in a 403 error message. * The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class UpdateBrandMetafieldExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new BrandMetafieldsApi();
            var body = new MetafieldPut1(); // MetafieldPut1 | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var metafieldId = 56;  // int? | The ID of the `Metafield`. 
            var brandId = 56;  // int? | The ID of the `Brand` to which the resource belongs. 

            try
            {
                // Update a Brand Metafield
                MetafieldResponse1 result = apiInstance.UpdateBrandMetafield(body, accept, contentType, metafieldId, brandId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandMetafieldsApi.UpdateBrandMetafield: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MetafieldPut1**](MetafieldPut1.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **metafieldId** | **int?**| The ID of the &#x60;Metafield&#x60;.  | 
 **brandId** | **int?**| The ID of the &#x60;Brand&#x60; to which the resource belongs.  | 

### Return type

[**MetafieldResponse1**](MetafieldResponse1.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
