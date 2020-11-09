# BigCommerce.Api.BrandsApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBrand**](BrandsApi.md#createbrand) | **POST** /catalog/brands | Create a Brand
[**DeleteBrandById**](BrandsApi.md#deletebrandbyid) | **DELETE** /catalog/brands/{brand_id} | Delete a Brand
[**DeleteBrands**](BrandsApi.md#deletebrands) | **DELETE** /catalog/brands | Delete Brands
[**GetBrandById**](BrandsApi.md#getbrandbyid) | **GET** /catalog/brands/{brand_id} | Get a Brand
[**GetBrands**](BrandsApi.md#getbrands) | **GET** /catalog/brands | Get All Brands
[**UpdateBrand**](BrandsApi.md#updatebrand) | **PUT** /catalog/brands/{brand_id} | Update a Brand

<a name="createbrand"></a>
# **CreateBrand**
> BrandResponse CreateBrand (Brand body, string accept, string contentType)

Create a Brand

Creates a *Brand*.  **Required Fields** - name  **Read-Only Fields** - id

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class CreateBrandExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new BrandsApi();
            var body = new Brand(); // Brand | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)

            try
            {
                // Create a Brand
                BrandResponse result = apiInstance.CreateBrand(body, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandsApi.CreateBrand: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Brand**](Brand.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]

### Return type

[**BrandResponse**](BrandResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletebrandbyid"></a>
# **DeleteBrandById**
> void DeleteBrandById (int? brandId, string accept, string contentType)

Delete a Brand

Deletes a *Brand*.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class DeleteBrandByIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new BrandsApi();
            var brandId = 56;  // int? | The ID of the `Brand` to which the resource belongs. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)

            try
            {
                // Delete a Brand
                apiInstance.DeleteBrandById(brandId, accept, contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandsApi.DeleteBrandById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
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
<a name="deletebrands"></a>
# **DeleteBrands**
> void DeleteBrands (string accept, string contentType, string name = null, string pageTitle = null)

Delete Brands

By default, it deletes all *Brand* objects. A filter should be added to avoid deleting all *Brand* objects in a store.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class DeleteBrandsExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new BrandsApi();
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var name = name_example;  // string | Filter items by name.  (optional) 
            var pageTitle = pageTitle_example;  // string | Filter items by page_title.  (optional) 

            try
            {
                // Delete Brands
                apiInstance.DeleteBrands(accept, contentType, name, pageTitle);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandsApi.DeleteBrands: " + e.Message );
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
 **name** | **string**| Filter items by name.  | [optional] 
 **pageTitle** | **string**| Filter items by page_title.  | [optional] 

### Return type

void (empty response body)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbrandbyid"></a>
# **GetBrandById**
> BrandResponse1 GetBrandById (int? brandId, string contentType, string accept, string includeFields = null, string excludeFields = null)

Get a Brand

Returns a single *Brand*. Optional filter parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class GetBrandByIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new BrandsApi();
            var brandId = 56;  // int? | The ID of the `Brand` to which the resource belongs. 
            var contentType = contentType_example;  // string |  (default to application/json)
            var accept = accept_example;  // string |  (default to application/json)
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 

            try
            {
                // Get a Brand
                BrandResponse1 result = apiInstance.GetBrandById(brandId, contentType, accept, includeFields, excludeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandsApi.GetBrandById: " + e.Message );
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
 **includeFields** | **string**| Fields to include, in a comma-separated list. The ID and the specified fields will be returned. | [optional] 
 **excludeFields** | **string**| Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. | [optional] 

### Return type

[**BrandResponse1**](BrandResponse1.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbrands"></a>
# **GetBrands**
> BrandCollectionResponse GetBrands (string accept, string contentType, int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, string name = null, string pageTitle = null, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null)

Get All Brands

Returns a list of *Brands*. Optional filter parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class GetBrandsExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new BrandsApi();
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var id = 56;  // int? | Filter items by id.  (optional) 
            var idin = new List<int?>(); // List<int?> |  (optional) 
            var idnotIn = new List<int?>(); // List<int?> |  (optional) 
            var idmin = new List<int?>(); // List<int?> |  (optional) 
            var idmax = new List<int?>(); // List<int?> |  (optional) 
            var idgreater = new List<int?>(); // List<int?> |  (optional) 
            var idless = new List<int?>(); // List<int?> |  (optional) 
            var name = name_example;  // string | Filter items by name.  (optional) 
            var pageTitle = pageTitle_example;  // string | Filter items by page_title.  (optional) 
            var page = 56;  // int? | Specifies the page number in a limited (paginated) list of products. (optional) 
            var limit = 56;  // int? | Controls the number of items per page in a limited (paginated) list of products. (optional) 
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 

            try
            {
                // Get All Brands
                BrandCollectionResponse result = apiInstance.GetBrands(accept, contentType, id, idin, idnotIn, idmin, idmax, idgreater, idless, name, pageTitle, page, limit, includeFields, excludeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandsApi.GetBrands: " + e.Message );
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
 **id** | **int?**| Filter items by id.  | [optional] 
 **idin** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **idnotIn** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **idmin** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **idmax** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **idgreater** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **idless** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **name** | **string**| Filter items by name.  | [optional] 
 **pageTitle** | **string**| Filter items by page_title.  | [optional] 
 **page** | **int?**| Specifies the page number in a limited (paginated) list of products. | [optional] 
 **limit** | **int?**| Controls the number of items per page in a limited (paginated) list of products. | [optional] 
 **includeFields** | **string**| Fields to include, in a comma-separated list. The ID and the specified fields will be returned. | [optional] 
 **excludeFields** | **string**| Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. | [optional] 

### Return type

[**BrandCollectionResponse**](BrandCollectionResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatebrand"></a>
# **UpdateBrand**
> BrandResponse UpdateBrand (Brand1 body, string contentType, string accept, int? brandId)

Update a Brand

Updates a *Brand*.  **Required Fields** - None  **Read-Only Fields** - id  To update a *Brand Image*, send a request with an `image_url`.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class UpdateBrandExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new BrandsApi();
            var body = new Brand1(); // Brand1 | 
            var contentType = contentType_example;  // string |  (default to application/json)
            var accept = accept_example;  // string |  (default to application/json)
            var brandId = 56;  // int? | The ID of the `Brand` to which the resource belongs. 

            try
            {
                // Update a Brand
                BrandResponse result = apiInstance.UpdateBrand(body, contentType, accept, brandId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BrandsApi.UpdateBrand: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Brand1**](Brand1.md)|  | 
 **contentType** | **string**|  | [default to application/json]
 **accept** | **string**|  | [default to application/json]
 **brandId** | **int?**| The ID of the &#x60;Brand&#x60; to which the resource belongs.  | 

### Return type

[**BrandResponse**](BrandResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
