# Catalog.Api.BrandImagesApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBrandImage**](BrandImagesApi.md#createbrandimage) | **POST** /catalog/brands/{brand_id}/image | Create a Brand Image
[**DeleteBrandImage**](BrandImagesApi.md#deletebrandimage) | **DELETE** /catalog/brands/{brand_id}/image | Delete a Brand Image

<a name="createbrandimage"></a>
# **CreateBrandImage**
> InlineResponse200 CreateBrandImage (string accept, string contentType, int? brandId)

Create a Brand Image

Creates a *Brand Image*.  **Required Fields** - image_file: Form posts are the only accepted upload option.  **Read-Only Fields** - id  Only one image at a time can be created. To update a *Brand Image*, use the [PUT Brands](/api-reference/catalog/catalog-api/brands/updatebrand) and an `image_url`.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class CreateBrandImageExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new BrandImagesApi();
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var brandId = 56;  // int? | The ID of the `Brand` to which the resource belongs. 

            try
            {
                // Create a Brand Image
                InlineResponse200 result = apiInstance.CreateBrandImage(accept, contentType, brandId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandImagesApi.CreateBrandImage: " + e.Message );
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
 **brandId** | **int?**| The ID of the &#x60;Brand&#x60; to which the resource belongs.  | 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletebrandimage"></a>
# **DeleteBrandImage**
> void DeleteBrandImage (int? brandId, string contentType, string accept)

Delete a Brand Image

Deletes a *Brand Image*.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class DeleteBrandImageExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new BrandImagesApi();
            var brandId = 56;  // int? | The ID of the `Brand` to which the resource belongs. 
            var contentType = contentType_example;  // string |  (default to application/json)
            var accept = accept_example;  // string |  (default to application/json)

            try
            {
                // Delete a Brand Image
                apiInstance.DeleteBrandImage(brandId, contentType, accept);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandImagesApi.DeleteBrandImage: " + e.Message );
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

### Return type

void (empty response body)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
