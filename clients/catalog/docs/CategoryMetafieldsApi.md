# Catalog.Api.CategoryMetafieldsApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCategoryMetafield**](CategoryMetafieldsApi.md#createcategorymetafield) | **POST** /catalog/categories/{category_id}/metafields | Create a Category Metafield
[**DeleteCategoryMetafieldById**](CategoryMetafieldsApi.md#deletecategorymetafieldbyid) | **DELETE** /catalog/categories/{category_id}/metafields/{metafield_id} | Delete a Category Metafield
[**GetCategoryMetafieldByCategoryId**](CategoryMetafieldsApi.md#getcategorymetafieldbycategoryid) | **GET** /catalog/categories/{category_id}/metafields/{metafield_id} | Get a Category Metafield
[**GetCategoryMetafieldsByCategoryId**](CategoryMetafieldsApi.md#getcategorymetafieldsbycategoryid) | **GET** /catalog/categories/{category_id}/metafields | Get All Category Metafields
[**UpdateCategoryMetafield**](CategoryMetafieldsApi.md#updatecategorymetafield) | **PUT** /catalog/categories/{category_id}/metafields/{metafield_id} | Update a Category Metafield

<a name="createcategorymetafield"></a>
# **CreateCategoryMetafield**
> MetafieldResponse2 CreateCategoryMetafield (MetafieldPost2 body, string accept, string contentType, int? categoryId)

Create a Category Metafield

Creates a *Cateory Metafield*.  **Required Fields:** - permission_set - namespace - key - value  **Read-Only Fields** - id  **Note:** The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class CreateCategoryMetafieldExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new CategoryMetafieldsApi();
            var body = new MetafieldPost2(); // MetafieldPost2 | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var categoryId = 56;  // int? | The ID of the `Category` to which the resource belongs. 

            try
            {
                // Create a Category Metafield
                MetafieldResponse2 result = apiInstance.CreateCategoryMetafield(body, accept, contentType, categoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoryMetafieldsApi.CreateCategoryMetafield: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MetafieldPost2**](MetafieldPost2.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **categoryId** | **int?**| The ID of the &#x60;Category&#x60; to which the resource belongs.  | 

### Return type

[**MetafieldResponse2**](MetafieldResponse2.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletecategorymetafieldbyid"></a>
# **DeleteCategoryMetafieldById**
> void DeleteCategoryMetafieldById (int? metafieldId, int? categoryId, string accept, string contentType)

Delete a Category Metafield

Deletes a *Category Metafield*.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class DeleteCategoryMetafieldByIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new CategoryMetafieldsApi();
            var metafieldId = 56;  // int? | The ID of the `Metafield`. 
            var categoryId = 56;  // int? | The ID of the `Category` to which the resource belongs. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)

            try
            {
                // Delete a Category Metafield
                apiInstance.DeleteCategoryMetafieldById(metafieldId, categoryId, accept, contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoryMetafieldsApi.DeleteCategoryMetafieldById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **metafieldId** | **int?**| The ID of the &#x60;Metafield&#x60;.  | 
 **categoryId** | **int?**| The ID of the &#x60;Category&#x60; to which the resource belongs.  | 
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
<a name="getcategorymetafieldbycategoryid"></a>
# **GetCategoryMetafieldByCategoryId**
> MetafieldResponse3 GetCategoryMetafieldByCategoryId (int? metafieldId, int? categoryId, string accept, string contentType, string includeFields = null, string excludeFields = null)

Get a Category Metafield

Returns a single *Category Metafield*. Optional parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class GetCategoryMetafieldByCategoryIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new CategoryMetafieldsApi();
            var metafieldId = 56;  // int? | The ID of the `Metafield`. 
            var categoryId = 56;  // int? | The ID of the `Category` to which the resource belongs. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 

            try
            {
                // Get a Category Metafield
                MetafieldResponse3 result = apiInstance.GetCategoryMetafieldByCategoryId(metafieldId, categoryId, accept, contentType, includeFields, excludeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoryMetafieldsApi.GetCategoryMetafieldByCategoryId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **metafieldId** | **int?**| The ID of the &#x60;Metafield&#x60;.  | 
 **categoryId** | **int?**| The ID of the &#x60;Category&#x60; to which the resource belongs.  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **includeFields** | **string**| Fields to include, in a comma-separated list. The ID and the specified fields will be returned. | [optional] 
 **excludeFields** | **string**| Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. | [optional] 

### Return type

[**MetafieldResponse3**](MetafieldResponse3.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcategorymetafieldsbycategoryid"></a>
# **GetCategoryMetafieldsByCategoryId**
> MetaFieldCollectionResponse GetCategoryMetafieldsByCategoryId (int? categoryId, string accept, string contentType, int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, int? page = null, int? limit = null, string key = null, string _namespace = null, string includeFields = null, string excludeFields = null)

Get All Category Metafields

Returns a list of *Metafields* on a *Category*. Optional filter parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class GetCategoryMetafieldsByCategoryIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new CategoryMetafieldsApi();
            var categoryId = 56;  // int? | The ID of the `Category` to which the resource belongs. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
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
                // Get All Category Metafields
                MetaFieldCollectionResponse result = apiInstance.GetCategoryMetafieldsByCategoryId(categoryId, accept, contentType, id, idin, idnotIn, idmin, idmax, idgreater, idless, page, limit, key, _namespace, includeFields, excludeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoryMetafieldsApi.GetCategoryMetafieldsByCategoryId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categoryId** | **int?**| The ID of the &#x60;Category&#x60; to which the resource belongs.  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
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
<a name="updatecategorymetafield"></a>
# **UpdateCategoryMetafield**
> MetafieldResponse1 UpdateCategoryMetafield (MetafieldPut2 body, string accept, string contentType, int? metafieldId, int? categoryId)

Update a Category Metafield

Updates a *Category Metafield*.  **Required Fields** * none  **Read-Only Fields** * id * These fields can only be modified by the app (API credentials) that created the metafield:  * namespace  * key  * permission_set  **Usage Notes** * Attempting to modify `namespace`, `key`, and `permission_set` fields using a client ID different from the one used to create those metafields will result in a 403 error message. 

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class UpdateCategoryMetafieldExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new CategoryMetafieldsApi();
            var body = new MetafieldPut2(); // MetafieldPut2 | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var metafieldId = 56;  // int? | The ID of the `Metafield`. 
            var categoryId = 56;  // int? | The ID of the `Category` to which the resource belongs. 

            try
            {
                // Update a Category Metafield
                MetafieldResponse1 result = apiInstance.UpdateCategoryMetafield(body, accept, contentType, metafieldId, categoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoryMetafieldsApi.UpdateCategoryMetafield: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**MetafieldPut2**](MetafieldPut2.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **metafieldId** | **int?**| The ID of the &#x60;Metafield&#x60;.  | 
 **categoryId** | **int?**| The ID of the &#x60;Category&#x60; to which the resource belongs.  | 

### Return type

[**MetafieldResponse1**](MetafieldResponse1.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
