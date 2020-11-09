# BigCommerce.Api.ProductModifierValuesApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateModifierValue**](ProductModifierValuesApi.md#createmodifiervalue) | **POST** /catalog/products/{product_id}/modifiers/{modifier_id}/values | Create Modifier Value
[**DeleteModifierValueById**](ProductModifierValuesApi.md#deletemodifiervaluebyid) | **DELETE** /catalog/products/{product_id}/modifiers/{modifier_id}/values/{value_id} | Delete Modifier Value
[**GetModifierValueById**](ProductModifierValuesApi.md#getmodifiervaluebyid) | **GET** /catalog/products/{product_id}/modifiers/{modifier_id}/values/{value_id} | Get a Modifier Value
[**GetModifierValues**](ProductModifierValuesApi.md#getmodifiervalues) | **GET** /catalog/products/{product_id}/modifiers/{modifier_id}/values | Get All Modifier Values
[**UpdateModifierValue**](ProductModifierValuesApi.md#updatemodifiervalue) | **PUT** /catalog/products/{product_id}/modifiers/{modifier_id}/values/{value_id} | Update a Modifier Value

<a name="createmodifiervalue"></a>
# **CreateModifierValue**
> ModifierValueResponse CreateModifierValue (ModifierValuePost body, string accept, string contentType, int? productId, int? modifierId)

Create Modifier Value

Creates a *Modifier Value*.  **Required Fields** * label * sort_order  **Read-Only Fields** * id

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class CreateModifierValueExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductModifierValuesApi();
            var body = new ModifierValuePost(); // ModifierValuePost | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var modifierId = 56;  // int? | The ID of the `Modifier`. 

            try
            {
                // Create Modifier Value
                ModifierValueResponse result = apiInstance.CreateModifierValue(body, accept, contentType, productId, modifierId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductModifierValuesApi.CreateModifierValue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ModifierValuePost**](ModifierValuePost.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **modifierId** | **int?**| The ID of the &#x60;Modifier&#x60;.  | 

### Return type

[**ModifierValueResponse**](ModifierValueResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletemodifiervaluebyid"></a>
# **DeleteModifierValueById**
> void DeleteModifierValueById (int? productId, int? modifierId, int? valueId, string accept, string contentType)

Delete Modifier Value

Deletes a *Modifier Value*.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class DeleteModifierValueByIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductModifierValuesApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var modifierId = 56;  // int? | The ID of the `Modifier`. 
            var valueId = 56;  // int? | The ID of the `Modifier/Option Value`. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)

            try
            {
                // Delete Modifier Value
                apiInstance.DeleteModifierValueById(productId, modifierId, valueId, accept, contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductModifierValuesApi.DeleteModifierValueById: " + e.Message );
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
 **valueId** | **int?**| The ID of the &#x60;Modifier/Option Value&#x60;.  | 
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
<a name="getmodifiervaluebyid"></a>
# **GetModifierValueById**
> ModifierValueResponse1 GetModifierValueById (int? productId, int? modifierId, int? valueId, string accept, string contentType, string includeFields = null, string excludeFields = null)

Get a Modifier Value

Returns a single *Modifier Value*. Optional parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class GetModifierValueByIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductModifierValuesApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var modifierId = 56;  // int? | The ID of the `Modifier`. 
            var valueId = 56;  // int? | The ID of the `Modifier/Option Value`. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 

            try
            {
                // Get a Modifier Value
                ModifierValueResponse1 result = apiInstance.GetModifierValueById(productId, modifierId, valueId, accept, contentType, includeFields, excludeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductModifierValuesApi.GetModifierValueById: " + e.Message );
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
 **valueId** | **int?**| The ID of the &#x60;Modifier/Option Value&#x60;.  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **includeFields** | **string**| Fields to include, in a comma-separated list. The ID and the specified fields will be returned. | [optional] 
 **excludeFields** | **string**| Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. | [optional] 

### Return type

[**ModifierValueResponse1**](ModifierValueResponse1.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getmodifiervalues"></a>
# **GetModifierValues**
> ModifierValueCollectionResponse GetModifierValues (int? productId, int? modifierId, string accept, string contentType, string includeFields = null, string excludeFields = null)

Get All Modifier Values

Returns a list of all product *Modifier Values*. Optional parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class GetModifierValuesExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductModifierValuesApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var modifierId = 56;  // int? | The ID of the `Modifier`. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 

            try
            {
                // Get All Modifier Values
                ModifierValueCollectionResponse result = apiInstance.GetModifierValues(productId, modifierId, accept, contentType, includeFields, excludeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductModifierValuesApi.GetModifierValues: " + e.Message );
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

[**ModifierValueCollectionResponse**](ModifierValueCollectionResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatemodifiervalue"></a>
# **UpdateModifierValue**
> ModifierValueResponse UpdateModifierValue (ModifierValuePut body, string accept, string contentType, int? productId, int? modifierId, int? valueId)

Update a Modifier Value

Updates a *Modifier Value*.  **Required Fields** * none  **Read-Only Fields** * id

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class UpdateModifierValueExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductModifierValuesApi();
            var body = new ModifierValuePut(); // ModifierValuePut | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var modifierId = 56;  // int? | The ID of the `Modifier`. 
            var valueId = 56;  // int? | The ID of the `Modifier/Option Value`. 

            try
            {
                // Update a Modifier Value
                ModifierValueResponse result = apiInstance.UpdateModifierValue(body, accept, contentType, productId, modifierId, valueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductModifierValuesApi.UpdateModifierValue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ModifierValuePut**](ModifierValuePut.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **modifierId** | **int?**| The ID of the &#x60;Modifier&#x60;.  | 
 **valueId** | **int?**| The ID of the &#x60;Modifier/Option Value&#x60;.  | 

### Return type

[**ModifierValueResponse**](ModifierValueResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
