# BigCommerce.Api.ProductModifiersApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateModifier**](ProductModifiersApi.md#createmodifier) | **POST** /catalog/products/{product_id}/modifiers | Create a Product Modifier
[**DeleteModifierById**](ProductModifiersApi.md#deletemodifierbyid) | **DELETE** /catalog/products/{product_id}/modifiers/{modifier_id} | Delete a Modifier
[**GetModifierById**](ProductModifiersApi.md#getmodifierbyid) | **GET** /catalog/products/{product_id}/modifiers/{modifier_id} | Get a Modifier
[**GetModifiers**](ProductModifiersApi.md#getmodifiers) | **GET** /catalog/products/{product_id}/modifiers | Get All Product Modifiers
[**UpdateModifier**](ProductModifiersApi.md#updatemodifier) | **PUT** /catalog/products/{product_id}/modifiers/{modifier_id} | Update a Modifier

<a name="createmodifier"></a>
# **CreateModifier**
> ModifierResponse CreateModifier (ModifierPost body, string accept, string contentType, int? productId)

Create a Product Modifier

Creates a *Product Modifier*.  **Required Fields** * `required` * `display_name` * `type`  **Read-Only Fields** * `id`

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class CreateModifierExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductModifiersApi();
            var body = new ModifierPost(); // ModifierPost | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 

            try
            {
                // Create a Product Modifier
                ModifierResponse result = apiInstance.CreateModifier(body, accept, contentType, productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductModifiersApi.CreateModifier: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ModifierPost**](ModifierPost.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 

### Return type

[**ModifierResponse**](ModifierResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletemodifierbyid"></a>
# **DeleteModifierById**
> void DeleteModifierById (int? productId, int? modifierId, string contentType, string accept)

Delete a Modifier

Deletes a *Product Modifier*.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class DeleteModifierByIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductModifiersApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var modifierId = 56;  // int? | The ID of the `Modifier`. 
            var contentType = contentType_example;  // string |  (default to application/json)
            var accept = accept_example;  // string |  (default to application/json)

            try
            {
                // Delete a Modifier
                apiInstance.DeleteModifierById(productId, modifierId, contentType, accept);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductModifiersApi.DeleteModifierById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **modifierId** | **int?**| The ID of the &#x60;Modifier&#x60;.  | 
 **contentType** | **string**|  | [default to application/json]
 **accept** | **string**|  | [default to application/json]

### Return type

void (empty response body)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getmodifierbyid"></a>
# **GetModifierById**
> ModifierResponse1 GetModifierById (int? productId, int? modifierId, string accept, string contentType, string includeFields = null, string excludeFields = null)

Get a Modifier

Returns a single *Product Modifier*. Optional parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class GetModifierByIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductModifiersApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var modifierId = 56;  // int? | The ID of the `Modifier`. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 

            try
            {
                // Get a Modifier
                ModifierResponse1 result = apiInstance.GetModifierById(productId, modifierId, accept, contentType, includeFields, excludeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductModifiersApi.GetModifierById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **modifierId** | **int?**| The ID of the &#x60;Modifier&#x60;.  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **includeFields** | **string**| Fields to include, in a comma-separated list. The ID and the specified fields will be returned. | [optional] 
 **excludeFields** | **string**| Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. | [optional] 

### Return type

[**ModifierResponse1**](ModifierResponse1.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getmodifiers"></a>
# **GetModifiers**
> ModifierCollectionResponse GetModifiers (int? productId, string accept, string contentType, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null)

Get All Product Modifiers

Returns a list of all *Product Modifiers*. Optional parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class GetModifiersExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductModifiersApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var page = 56;  // int? | Specifies the page number in a limited (paginated) list of products. (optional) 
            var limit = 56;  // int? | Controls the number of items per page in a limited (paginated) list of products. (optional) 
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 

            try
            {
                // Get All Product Modifiers
                ModifierCollectionResponse result = apiInstance.GetModifiers(productId, accept, contentType, page, limit, includeFields, excludeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductModifiersApi.GetModifiers: " + e.Message );
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
 **includeFields** | **string**| Fields to include, in a comma-separated list. The ID and the specified fields will be returned. | [optional] 
 **excludeFields** | **string**| Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. | [optional] 

### Return type

[**ModifierCollectionResponse**](ModifierCollectionResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatemodifier"></a>
# **UpdateModifier**
> ModifierResponse UpdateModifier (ModifierPut body, string accept, string contentType, int? productId, int? modifierId)

Update a Modifier

Updates a *Product Modifier*.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class UpdateModifierExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductModifiersApi();
            var body = new ModifierPut(); // ModifierPut | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var modifierId = 56;  // int? | The ID of the `Modifier`. 

            try
            {
                // Update a Modifier
                ModifierResponse result = apiInstance.UpdateModifier(body, accept, contentType, productId, modifierId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductModifiersApi.UpdateModifier: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ModifierPut**](ModifierPut.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **modifierId** | **int?**| The ID of the &#x60;Modifier&#x60;.  | 

### Return type

[**ModifierResponse**](ModifierResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
