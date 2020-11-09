# Catalog.Api.CatalogApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteBrands**](CatalogApi.md#deletebrands) | **DELETE** /catalog/brands | Delete Brands
[**DeleteProducts**](CatalogApi.md#deleteproducts) | **DELETE** /catalog/products | Delete Products
[**UpdateVariantsBatch**](CatalogApi.md#updatevariantsbatch) | **PUT** /catalog/variants | Update Variants (Batch)

<a name="deletebrands"></a>
# **DeleteBrands**
> void DeleteBrands (string accept, string contentType, string name = null, string pageTitle = null)

Delete Brands

By default, it deletes all *Brand* objects. A filter should be added to avoid deleting all *Brand* objects in a store.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

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

            var apiInstance = new CatalogApi();
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
                Debug.Print("Exception when calling CatalogApi.DeleteBrands: " + e.Message );
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
<a name="deleteproducts"></a>
# **DeleteProducts**
> void DeleteProducts (string accept, string contentType, string name = null, string sku = null, decimal? price = null, decimal? weight = null, string condition = null, int? brandId = null, DateTime? dateModified = null, DateTime? dateLastImported = null, bool? isVisible = null, int? isFeatured = null, int? inventoryLevel = null, int? totalSold = null, string type = null, int? categories = null, string keyword = null)

Delete Products

To delete *Product* objects, you must include a filter. This prevents inadvertently deleting all *Product* objects in a store.  **Example**: To delete products with the id's of 1,2 and 3, use `DELETE /v3/catalog/products?id:in=1,2,3`.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class DeleteProductsExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new CatalogApi();
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var name = name_example;  // string | Filter items by name.  (optional) 
            var sku = sku_example;  // string | Filter items by sku.  (optional) 
            var price = 1.2;  // decimal? | Filter items by price.  (optional) 
            var weight = 1.2;  // decimal? | Filter items by weight.  (optional) 
            var condition = condition_example;  // string | Filter items by condition.  (optional) 
            var brandId = 56;  // int? | Filter items by brand_id.  (optional) 
            var dateModified = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter items by date_modified. For example `v3/catalog/products?date_modified:min=2018-06-15` (optional) 
            var dateLastImported = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter items by date_last_imported. For example `v3/catalog/products?date_last_imported:min=2018-06-15` (optional) 
            var isVisible = true;  // bool? | Filter items by if visible on the storefront.  (optional) 
            var isFeatured = 56;  // int? | Filter items by is_featured.  (optional) 
            var inventoryLevel = 56;  // int? | Filter items by inventory_level.  (optional) 
            var totalSold = 56;  // int? | Filter items by total_sold.  (optional) 
            var type = type_example;  // string | Filter items by type: `physical` or `digital`. (optional) 
            var categories = 56;  // int? | Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use `categories:in=12`. (optional) 
            var keyword = keyword_example;  // string | Filter items by keywords found in the `name`, `description`, or `sku` fields, or in the brand name.  (optional) 

            try
            {
                // Delete Products
                apiInstance.DeleteProducts(accept, contentType, name, sku, price, weight, condition, brandId, dateModified, dateLastImported, isVisible, isFeatured, inventoryLevel, totalSold, type, categories, keyword);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogApi.DeleteProducts: " + e.Message );
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
 **sku** | **string**| Filter items by sku.  | [optional] 
 **price** | **decimal?**| Filter items by price.  | [optional] 
 **weight** | **decimal?**| Filter items by weight.  | [optional] 
 **condition** | **string**| Filter items by condition.  | [optional] 
 **brandId** | **int?**| Filter items by brand_id.  | [optional] 
 **dateModified** | **DateTime?**| Filter items by date_modified. For example &#x60;v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60; | [optional] 
 **dateLastImported** | **DateTime?**| Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; | [optional] 
 **isVisible** | **bool?**| Filter items by if visible on the storefront.  | [optional] 
 **isFeatured** | **int?**| Filter items by is_featured.  | [optional] 
 **inventoryLevel** | **int?**| Filter items by inventory_level.  | [optional] 
 **totalSold** | **int?**| Filter items by total_sold.  | [optional] 
 **type** | **string**| Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;. | [optional] 
 **categories** | **int?**| Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;. | [optional] 
 **keyword** | **string**| Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name.  | [optional] 

### Return type

void (empty response body)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatevariantsbatch"></a>
# **UpdateVariantsBatch**
> VariantCollectionResponse2 UpdateVariantsBatch (List<Object> body, string accept, string contentType)

Update Variants (Batch)

Creates or updates a batch of `Variant` objects. At the time of writing, the current limit is `50` variants. This limit is subject to change.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class UpdateVariantsBatchExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new CatalogApi();
            var body = new List<Object>(); // List<Object> | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)

            try
            {
                // Update Variants (Batch)
                VariantCollectionResponse2 result = apiInstance.UpdateVariantsBatch(body, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CatalogApi.UpdateVariantsBatch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**List&lt;Object&gt;**](Object.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]

### Return type

[**VariantCollectionResponse2**](VariantCollectionResponse2.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
