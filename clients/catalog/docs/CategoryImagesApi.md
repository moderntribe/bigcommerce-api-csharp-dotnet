# Catalog.Api.CategoryImagesApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCategoryImage**](CategoryImagesApi.md#createcategoryimage) | **POST** /catalog/categories/{category_id}/image | Create a Category Image
[**DeleteCategoryImage**](CategoryImagesApi.md#deletecategoryimage) | **DELETE** /catalog/categories/{category_id}/image | Delete a Category Image

<a name="createcategoryimage"></a>
# **CreateCategoryImage**
> InlineResponse200 CreateCategoryImage (string accept, string contentType, int? categoryId)

Create a Category Image

Create a *Category Image*.   **Required Fields** - image_file: Form posts are the only accepted upload option.  Only one image at a time can be created. Limit image size to 1MB. To update a *Category Image*, use the [PUT Categories](/api-reference/catalog/catalog-api/category/updatecategory) and an `image_url`.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class CreateCategoryImageExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new CategoryImagesApi();
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var categoryId = 56;  // int? | The ID of the `Category` to which the resource belongs. 

            try
            {
                // Create a Category Image
                InlineResponse200 result = apiInstance.CreateCategoryImage(accept, contentType, categoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoryImagesApi.CreateCategoryImage: " + e.Message );
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
 **categoryId** | **int?**| The ID of the &#x60;Category&#x60; to which the resource belongs.  | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletecategoryimage"></a>
# **DeleteCategoryImage**
> void DeleteCategoryImage (int? categoryId, string accept, string contentType)

Delete a Category Image

Deletes a *Cateogory Image*.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class DeleteCategoryImageExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new CategoryImagesApi();
            var categoryId = 56;  // int? | The ID of the `Category` to which the resource belongs. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)

            try
            {
                // Delete a Category Image
                apiInstance.DeleteCategoryImage(categoryId, accept, contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoryImagesApi.DeleteCategoryImage: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
