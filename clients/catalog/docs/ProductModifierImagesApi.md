# Catalog.Api.ProductModifierImagesApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateModifierImage**](ProductModifierImagesApi.md#createmodifierimage) | **POST** /catalog/products/{product_id}/modifiers/{modifier_id}/values/{value_id}/image | Create Modifier Image
[**DeleteModifierImage**](ProductModifierImagesApi.md#deletemodifierimage) | **DELETE** /catalog/products/{product_id}/modifiers/{modifier_id}/values/{value_id}/image | Delete Modifier Image

<a name="createmodifierimage"></a>
# **CreateModifierImage**
> ImageResponse CreateModifierImage (string accept, string contentType, int? productId, int? modifierId, int? valueId)

Create Modifier Image

Creates a *Modifier Image*.  The image will show on the storefront when the value is selected.   **Required Fields** - image_file: Form posts are the only accepted upload option.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class CreateModifierImageExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductModifierImagesApi();
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var modifierId = 56;  // int? | The ID of the `Modifier`. 
            var valueId = 56;  // int? | The ID of the `Modifier`. 

            try
            {
                // Create Modifier Image
                ImageResponse result = apiInstance.CreateModifierImage(accept, contentType, productId, modifierId, valueId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductModifierImagesApi.CreateModifierImage: " + e.Message );
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
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **modifierId** | **int?**| The ID of the &#x60;Modifier&#x60;.  | 
 **valueId** | **int?**| The ID of the &#x60;Modifier&#x60;.  | 

### Return type

[**ImageResponse**](ImageResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletemodifierimage"></a>
# **DeleteModifierImage**
> void DeleteModifierImage (int? productId, int? modifierId, int? valueId, string accept, string contentType)

Delete Modifier Image

Deletes a *Modifier Image*.  Deletes the image that was set to show when the modifier value is selected.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class DeleteModifierImageExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductModifierImagesApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var modifierId = 56;  // int? | The ID of the `Modifier`. 
            var valueId = 56;  // int? | The ID of the `Modifier`. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)

            try
            {
                // Delete Modifier Image
                apiInstance.DeleteModifierImage(productId, modifierId, valueId, accept, contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductModifierImagesApi.DeleteModifierImage: " + e.Message );
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
 **valueId** | **int?**| The ID of the &#x60;Modifier&#x60;.  | 
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
