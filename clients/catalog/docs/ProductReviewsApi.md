# BigCommerce.Api.ProductReviewsApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateProductReview**](ProductReviewsApi.md#createproductreview) | **POST** /catalog/products/{product_id}/reviews | Create a Product Review
[**DeleteProductReview**](ProductReviewsApi.md#deleteproductreview) | **DELETE** /catalog/products/{product_id}/reviews/{review_id} | Delete a Product Review
[**GetProductReviewById**](ProductReviewsApi.md#getproductreviewbyid) | **GET** /catalog/products/{product_id}/reviews/{review_id} | Get a Product Review
[**GetProductReviews**](ProductReviewsApi.md#getproductreviews) | **GET** /catalog/products/{product_id}/reviews | Get Product Reviews
[**UpdateProductReview**](ProductReviewsApi.md#updateproductreview) | **PUT** /catalog/products/{product_id}/reviews/{review_id} | Update a Product Review

<a name="createproductreview"></a>
# **CreateProductReview**
> ProductReviewResponse CreateProductReview (ProductReviewPost body, string accept, string contentType, int? productId)

Create a Product Review

Creates a *Product Review*.  **Required Fields** - title - date_reviewed  **Read-Only Fields** * id

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class CreateProductReviewExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductReviewsApi();
            var body = new ProductReviewPost(); // ProductReviewPost | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 

            try
            {
                // Create a Product Review
                ProductReviewResponse result = apiInstance.CreateProductReview(body, accept, contentType, productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductReviewsApi.CreateProductReview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductReviewPost**](ProductReviewPost.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 

### Return type

[**ProductReviewResponse**](ProductReviewResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteproductreview"></a>
# **DeleteProductReview**
> void DeleteProductReview (int? productId, int? reviewId, string accept, string contentType)

Delete a Product Review

Deletes a *Product Review*.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class DeleteProductReviewExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductReviewsApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var reviewId = 56;  // int? | The ID of the `review` that is being operated on. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)

            try
            {
                // Delete a Product Review
                apiInstance.DeleteProductReview(productId, reviewId, accept, contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductReviewsApi.DeleteProductReview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **reviewId** | **int?**| The ID of the &#x60;review&#x60; that is being operated on.  | 
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
<a name="getproductreviewbyid"></a>
# **GetProductReviewById**
> ProductReviewResponse GetProductReviewById (int? productId, int? reviewId, string accept, string contentType, string includeFields = null, string excludeFields = null)

Get a Product Review

Returns a single *Product Review*. Optional parameters maybe passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class GetProductReviewByIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductReviewsApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var reviewId = 56;  // int? | The ID of the `review` that is being operated on. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 

            try
            {
                // Get a Product Review
                ProductReviewResponse result = apiInstance.GetProductReviewById(productId, reviewId, accept, contentType, includeFields, excludeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductReviewsApi.GetProductReviewById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **reviewId** | **int?**| The ID of the &#x60;review&#x60; that is being operated on.  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **includeFields** | **string**| Fields to include, in a comma-separated list. The ID and the specified fields will be returned. | [optional] 
 **excludeFields** | **string**| Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. | [optional] 

### Return type

[**ProductReviewResponse**](ProductReviewResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproductreviews"></a>
# **GetProductReviews**
> ProductReviewCollectionResponse GetProductReviews (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null, int? page = null, int? limit = null)

Get Product Reviews

Returns a list of all *Product Reviews*. Optional parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class GetProductReviewsExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductReviewsApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 
            var page = 56;  // int? | Specifies the page number in a limited (paginated) list of products. (optional) 
            var limit = 56;  // int? | Controls the number of items per page in a limited (paginated) list of products. (optional) 

            try
            {
                // Get Product Reviews
                ProductReviewCollectionResponse result = apiInstance.GetProductReviews(productId, accept, contentType, includeFields, excludeFields, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductReviewsApi.GetProductReviews: " + e.Message );
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
 **includeFields** | **string**| Fields to include, in a comma-separated list. The ID and the specified fields will be returned. | [optional] 
 **excludeFields** | **string**| Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. | [optional] 
 **page** | **int?**| Specifies the page number in a limited (paginated) list of products. | [optional] 
 **limit** | **int?**| Controls the number of items per page in a limited (paginated) list of products. | [optional] 

### Return type

[**ProductReviewCollectionResponse**](ProductReviewCollectionResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateproductreview"></a>
# **UpdateProductReview**
> ProductReviewResponse UpdateProductReview (ProductReviewPut body, string accept, string contentType, int? productId, int? reviewId)

Update a Product Review

Updates a *Product Review*.  **Required Fields** * none  **Read-Only Fields** * id

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class UpdateProductReviewExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductReviewsApi();
            var body = new ProductReviewPut(); // ProductReviewPut | A BigCommerce `ProductReview` object.

            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var reviewId = 56;  // int? | The ID of the `review` that is being operated on. 

            try
            {
                // Update a Product Review
                ProductReviewResponse result = apiInstance.UpdateProductReview(body, accept, contentType, productId, reviewId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductReviewsApi.UpdateProductReview: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductReviewPut**](ProductReviewPut.md)| A BigCommerce &#x60;ProductReview&#x60; object.
 | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **reviewId** | **int?**| The ID of the &#x60;review&#x60; that is being operated on.  | 

### Return type

[**ProductReviewResponse**](ProductReviewResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
