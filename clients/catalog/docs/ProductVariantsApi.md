# Catalog.Api.ProductVariantsApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateVariant**](ProductVariantsApi.md#createvariant) | **POST** /catalog/products/{product_id}/variants | Create a Product Variant
[**CreateVariantImage**](ProductVariantsApi.md#createvariantimage) | **POST** /catalog/products/{product_id}/variants/{variant_id}/image | Create a Variant Image
[**DeleteVariantById**](ProductVariantsApi.md#deletevariantbyid) | **DELETE** /catalog/products/{product_id}/variants/{variant_id} | Delete a Product Variant
[**GetVariantById**](ProductVariantsApi.md#getvariantbyid) | **GET** /catalog/products/{product_id}/variants/{variant_id} | Get a Product Variant
[**GetVariantsByProductId**](ProductVariantsApi.md#getvariantsbyproductid) | **GET** /catalog/products/{product_id}/variants | Get All Product Variants
[**UpdateVariant**](ProductVariantsApi.md#updatevariant) | **PUT** /catalog/products/{product_id}/variants/{variant_id} | Update a Product Variant

<a name="createvariant"></a>
# **CreateVariant**
> VariantResponse CreateVariant (VariantPost body, int? productId)

Create a Product Variant

Creates a *Product Variant*.   **Required Fields** * sku * option_values  **Read-Only Fields** * id  Variants need to be created one at a time using this endpoint. To use a variant array and create products and variants in the same call use the [Create Products](/api-reference/catalog/catalog-api/products/createproduct) during the initial product creation.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class CreateVariantExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductVariantsApi();
            var body = new VariantPost(); // VariantPost | 
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 

            try
            {
                // Create a Product Variant
                VariantResponse result = apiInstance.CreateVariant(body, productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductVariantsApi.CreateVariant: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**VariantPost**](VariantPost.md)|  | 
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 

### Return type

[**VariantResponse**](VariantResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="createvariantimage"></a>
# **CreateVariantImage**
> ImageResponse CreateVariantImage (int? productId, int? variantId, ResourceImage body = null)

Create a Variant Image

Creates a *Variant Image*.  The image will show on the storefront when the value is selected.   **Required Fields** - image_file: Form posts. Files larger than 1 MB are not accepted - image_url: Any publicly available URL

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class CreateVariantImageExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductVariantsApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var variantId = 56;  // int? | ID of the variant on a product, or on an associated Price List Record. 
            var body = new ResourceImage(); // ResourceImage |  (optional) 

            try
            {
                // Create a Variant Image
                ImageResponse result = apiInstance.CreateVariantImage(productId, variantId, body);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductVariantsApi.CreateVariantImage: " + e.Message );
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
 **body** | [**ResourceImage**](ResourceImage.md)|  | [optional] 

### Return type

[**ImageResponse**](ImageResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json, multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletevariantbyid"></a>
# **DeleteVariantById**
> void DeleteVariantById (int? productId, int? variantId, string accept, string contentType)

Delete a Product Variant

Deletes a product *Variant*.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class DeleteVariantByIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductVariantsApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var variantId = 56;  // int? | ID of the variant on a product, or on an associated Price List Record. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)

            try
            {
                // Delete a Product Variant
                apiInstance.DeleteVariantById(productId, variantId, accept, contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductVariantsApi.DeleteVariantById: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getvariantbyid"></a>
# **GetVariantById**
> VariantResponse1 GetVariantById (int? productId, int? variantId, string accept, string contentType, string includeFields = null, string excludeFields = null)

Get a Product Variant

Returns a single product *Variant*. Optional parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class GetVariantByIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductVariantsApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var variantId = 56;  // int? | ID of the variant on a product, or on an associated Price List Record. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 

            try
            {
                // Get a Product Variant
                VariantResponse1 result = apiInstance.GetVariantById(productId, variantId, accept, contentType, includeFields, excludeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductVariantsApi.GetVariantById: " + e.Message );
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
 **includeFields** | **string**| Fields to include, in a comma-separated list. The ID and the specified fields will be returned. | [optional] 
 **excludeFields** | **string**| Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. | [optional] 

### Return type

[**VariantResponse1**](VariantResponse1.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getvariantsbyproductid"></a>
# **GetVariantsByProductId**
> VariantCollectionResponse GetVariantsByProductId (int? productId, string accept, string contentType, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null)

Get All Product Variants

Returns a list of product *Variants*. Optional parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class GetVariantsByProductIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductVariantsApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var page = 56;  // int? | Specifies the page number in a limited (paginated) list of products. (optional) 
            var limit = 56;  // int? | Controls the number of items per page in a limited (paginated) list of products. (optional) 
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 

            try
            {
                // Get All Product Variants
                VariantCollectionResponse result = apiInstance.GetVariantsByProductId(productId, accept, contentType, page, limit, includeFields, excludeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductVariantsApi.GetVariantsByProductId: " + e.Message );
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

[**VariantCollectionResponse**](VariantCollectionResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatevariant"></a>
# **UpdateVariant**
> VariantResponse1 UpdateVariant (ProductVariantPut1 body, string accept, string contentType, int? productId, int? variantId)

Update a Product Variant

Updates a product *Variant*.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class UpdateVariantExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductVariantsApi();
            var body = new ProductVariantPut1(); // ProductVariantPut1 | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var variantId = 56;  // int? | ID of the variant on a product, or on an associated Price List Record. 

            try
            {
                // Update a Product Variant
                VariantResponse1 result = apiInstance.UpdateVariant(body, accept, contentType, productId, variantId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductVariantsApi.UpdateVariant: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductVariantPut1**](ProductVariantPut1.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **variantId** | **int?**| ID of the variant on a product, or on an associated Price List Record.  | 

### Return type

[**VariantResponse1**](VariantResponse1.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
