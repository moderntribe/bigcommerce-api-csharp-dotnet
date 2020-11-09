# BigCommerce.Api.ProductOptionValuesApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOptionValue**](ProductOptionValuesApi.md#createoptionvalue) | **POST** /catalog/products/{product_id}/options/{option_id}/values | Create Product Option Values
[**DeleteOptionValueById**](ProductOptionValuesApi.md#deleteoptionvaluebyid) | **DELETE** /catalog/products/{product_id}/options/{option_id}/values/{value_id} | Delete a Product Option Value
[**GetOptionValueById**](ProductOptionValuesApi.md#getoptionvaluebyid) | **GET** /catalog/products/{product_id}/options/{option_id}/values/{value_id} | Get a Product Option Value
[**GetOptionValues**](ProductOptionValuesApi.md#getoptionvalues) | **GET** /catalog/products/{product_id}/options/{option_id}/values | Get all Product Option Values
[**UpdateOptionValue**](ProductOptionValuesApi.md#updateoptionvalue) | **PUT** /catalog/products/{product_id}/options/{option_id}/values/{value_id} | Update a Product Option Value

<a name="createoptionvalue"></a>
# **CreateOptionValue**
> OptionValueResponse CreateOptionValue (OptionValuePost body, string accept, string contentType, int? productId, int? optionId)

Create Product Option Values

Creates a *Variant Option Value*.  **Required Fields** * label * sort_order  **Read-Only Fields** * id

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class CreateOptionValueExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductOptionValuesApi();
            var body = new OptionValuePost(); // OptionValuePost | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var optionId = 56;  // int? | The ID of the `Option`. 

            try
            {
                // Create Product Option Values
                OptionValueResponse result = apiInstance.CreateOptionValue(body, accept, contentType, productId, optionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductOptionValuesApi.CreateOptionValue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OptionValuePost**](OptionValuePost.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **optionId** | **int?**| The ID of the &#x60;Option&#x60;.  | 

### Return type

[**OptionValueResponse**](OptionValueResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteoptionvaluebyid"></a>
# **DeleteOptionValueById**
> void DeleteOptionValueById (int? productId, int? optionId, int? valueId, string accept, string contentType)

Delete a Product Option Value

Deletea a *Variant Option Value*.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class DeleteOptionValueByIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductOptionValuesApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var optionId = 56;  // int? | The ID of the `Option`. 
            var valueId = 56;  // int? | The ID of the `Modifier/Option Value`. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)

            try
            {
                // Delete a Product Option Value
                apiInstance.DeleteOptionValueById(productId, optionId, valueId, accept, contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductOptionValuesApi.DeleteOptionValueById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **optionId** | **int?**| The ID of the &#x60;Option&#x60;.  | 
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
<a name="getoptionvaluebyid"></a>
# **GetOptionValueById**
> OptionValueResponse GetOptionValueById (int? productId, int? optionId, int? valueId, string includeFields = null, string excludeFields = null)

Get a Product Option Value

Returns a single *Variant Option Value*. Optional parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class GetOptionValueByIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductOptionValuesApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var optionId = 56;  // int? | The ID of the `Option`. 
            var valueId = 56;  // int? | The ID of the `Modifier/Option Value`. 
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 

            try
            {
                // Get a Product Option Value
                OptionValueResponse result = apiInstance.GetOptionValueById(productId, optionId, valueId, includeFields, excludeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductOptionValuesApi.GetOptionValueById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **optionId** | **int?**| The ID of the &#x60;Option&#x60;.  | 
 **valueId** | **int?**| The ID of the &#x60;Modifier/Option Value&#x60;.  | 
 **includeFields** | **string**| Fields to include, in a comma-separated list. The ID and the specified fields will be returned. | [optional] 
 **excludeFields** | **string**| Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. | [optional] 

### Return type

[**OptionValueResponse**](OptionValueResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getoptionvalues"></a>
# **GetOptionValues**
> OptionValueCollectionResponse GetOptionValues (int? productId, int? optionId, string accept, string contentType, string includeFields = null, string excludeFields = null)

Get all Product Option Values

Returns a list of all *Variant Option Values*. Optional parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class GetOptionValuesExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductOptionValuesApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var optionId = 56;  // int? | The ID of the `Option`. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 

            try
            {
                // Get all Product Option Values
                OptionValueCollectionResponse result = apiInstance.GetOptionValues(productId, optionId, accept, contentType, includeFields, excludeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductOptionValuesApi.GetOptionValues: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **optionId** | **int?**| The ID of the &#x60;Option&#x60;.  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **includeFields** | **string**| Fields to include, in a comma-separated list. The ID and the specified fields will be returned. | [optional] 
 **excludeFields** | **string**| Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. | [optional] 

### Return type

[**OptionValueCollectionResponse**](OptionValueCollectionResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateoptionvalue"></a>
# **UpdateOptionValue**
> OptionValueResponse UpdateOptionValue (OptionValuePut body, string accept, string contentType, int? productId, int? optionId, int? valueId)

Update a Product Option Value

Updates a *Variant Option Value*.  **Read-Only Fields** * id

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class UpdateOptionValueExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductOptionValuesApi();
            var body = new OptionValuePut(); // OptionValuePut | A BigCommerce `OptionValue` object.

            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var optionId = 56;  // int? | The ID of the `Option`. 
            var valueId = 56;  // int? | The ID of the `Modifier/Option Value`. 

            try
            {
                // Update a Product Option Value
                OptionValueResponse result = apiInstance.UpdateOptionValue(body, accept, contentType, productId, optionId, valueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductOptionValuesApi.UpdateOptionValue: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**OptionValuePut**](OptionValuePut.md)| A BigCommerce &#x60;OptionValue&#x60; object.
 | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **optionId** | **int?**| The ID of the &#x60;Option&#x60;.  | 
 **valueId** | **int?**| The ID of the &#x60;Modifier/Option Value&#x60;.  | 

### Return type

[**OptionValueResponse**](OptionValueResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
