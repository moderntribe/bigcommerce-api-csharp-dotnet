# Catalog.Api.ProductsApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateProduct**](ProductsApi.md#createproduct) | **POST** /catalog/products | Create a Product
[**DeleteProductById**](ProductsApi.md#deleteproductbyid) | **DELETE** /catalog/products/{product_id} | Delete a Product
[**DeleteProducts**](ProductsApi.md#deleteproducts) | **DELETE** /catalog/products | Delete Products
[**GetProductById**](ProductsApi.md#getproductbyid) | **GET** /catalog/products/{product_id} | Get a Product
[**GetProducts**](ProductsApi.md#getproducts) | **GET** /catalog/products | Get All Products
[**UpdateProduct**](ProductsApi.md#updateproduct) | **PUT** /catalog/products/{product_id} | Update a Product
[**UpdateProducts**](ProductsApi.md#updateproducts) | **PUT** /catalog/products | Update Products (Batch)

<a name="createproduct"></a>
# **CreateProduct**
> ProductResponse CreateProduct (ProductPost1 body, string contentType, string accept, string includeFields = null)

Create a Product

Creates a *Product*. Only one product can be created at a time.  **Required Fields:** - `name` - `type` - `weight` - `price`  **Read-Only Fields** - `id` - `date_created` - `date_modified` - `calculated_price` - `base_variant_id`  **Usage Notes** * `POST` requests to `/products` accepts a single `video` object; to send an array of video objects, see: `/products/{product_id}/videos`.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class CreateProductExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductsApi();
            var body = new ProductPost1(); // ProductPost1 | 
            var contentType = contentType_example;  // string |  (default to application/json)
            var accept = accept_example;  // string |  (default to application/json)
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 

            try
            {
                // Create a Product
                ProductResponse result = apiInstance.CreateProduct(body, contentType, accept, includeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.CreateProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductPost1**](ProductPost1.md)|  | 
 **contentType** | **string**|  | [default to application/json]
 **accept** | **string**|  | [default to application/json]
 **includeFields** | **string**| Fields to include, in a comma-separated list. The ID and the specified fields will be returned. | [optional] 

### Return type

[**ProductResponse**](ProductResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteproductbyid"></a>
# **DeleteProductById**
> void DeleteProductById (int? productId, string accept, string contentType)

Delete a Product

Deletes a *Product*.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class DeleteProductByIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductsApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)

            try
            {
                // Delete a Product
                apiInstance.DeleteProductById(productId, accept, contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.DeleteProductById: " + e.Message );
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

            var apiInstance = new ProductsApi();
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
                Debug.Print("Exception when calling ProductsApi.DeleteProducts: " + e.Message );
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
<a name="getproductbyid"></a>
# **GetProductById**
> ProductResponse GetProductById (int? productId, string accept, string contentType, string include = null, string includeFields = null, string excludeFields = null)

Get a Product

Returns a single *Product*. Optional parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class GetProductByIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductsApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var include = include_example;  // string | Sub-resources to include on a product, in a comma-separated list. If `options` or `modifiers` is used, results are limited to 10 per page. (optional) 
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 

            try
            {
                // Get a Product
                ProductResponse result = apiInstance.GetProductById(productId, accept, contentType, include, includeFields, excludeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProductById: " + e.Message );
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
 **include** | **string**| Sub-resources to include on a product, in a comma-separated list. If &#x60;options&#x60; or &#x60;modifiers&#x60; is used, results are limited to 10 per page. | [optional] 
 **includeFields** | **string**| Fields to include, in a comma-separated list. The ID and the specified fields will be returned. | [optional] 
 **excludeFields** | **string**| Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. | [optional] 

### Return type

[**ProductResponse**](ProductResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getproducts"></a>
# **GetProducts**
> InlineResponse2001 GetProducts (int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, string name = null, string sku = null, string upc = null, decimal? price = null, decimal? weight = null, string condition = null, int? brandId = null, DateTime? dateModified = null, DateTime? dateLastImported = null, bool? isVisible = null, int? isFeatured = null, int? isFreeShipping = null, int? inventoryLevel = null, int? inventoryLow = null, int? outOfStock = null, int? totalSold = null, string type = null, int? categories = null, string keyword = null, string keywordContext = null, int? status = null, string include = null, string includeFields = null, string excludeFields = null, string availability = null, int? priceListId = null, int? page = null, int? limit = null, string direction = null, string sort = null)

Get All Products

Returns a list of **Products**. Optional filter parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class GetProductsExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductsApi();
            var id = 56;  // int? | Filter items by id.  (optional) 
            var idin = new List<int?>(); // List<int?> |  (optional) 
            var idnotIn = new List<int?>(); // List<int?> |  (optional) 
            var idmin = new List<int?>(); // List<int?> |  (optional) 
            var idmax = new List<int?>(); // List<int?> |  (optional) 
            var idgreater = new List<int?>(); // List<int?> |  (optional) 
            var idless = new List<int?>(); // List<int?> |  (optional) 
            var name = name_example;  // string | Filter items by name.  (optional) 
            var sku = sku_example;  // string | Filter items by sku.  (optional) 
            var upc = upc_example;  // string | Filter items by upc.  (optional) 
            var price = 1.2;  // decimal? | Filter items by price.  (optional) 
            var weight = 1.2;  // decimal? | Filter items by weight.  (optional) 
            var condition = condition_example;  // string | Filter items by condition.  (optional) 
            var brandId = 56;  // int? | Filter items by brand_id.  (optional) 
            var dateModified = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter items by date_modified. For example `v3/catalog/products?date_modified:min=2018-06-15` (optional) 
            var dateLastImported = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter items by date_last_imported. For example `v3/catalog/products?date_last_imported:min=2018-06-15` (optional) 
            var isVisible = true;  // bool? | Filter items by if visible on the storefront.  (optional) 
            var isFeatured = 56;  // int? | Filter items by is_featured. `0` for true, `1` for false.  (optional) 
            var isFreeShipping = 56;  // int? | Filter items by is_free_shipping.  (optional) 
            var inventoryLevel = 56;  // int? | Filter items by inventory_level.  (optional) 
            var inventoryLow = 56;  // int? | Filter items by inventory_low. Values: 1, 0.  (optional) 
            var outOfStock = 56;  // int? | Filter items by out_of_stock. To enable the filter, pass `out_of_stock`=`1`.  (optional) 
            var totalSold = 56;  // int? | Filter items by total_sold.  (optional) 
            var type = type_example;  // string | Filter items by type: `physical` or `digital`. (optional) 
            var categories = 56;  // int? | Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use `categories:in=12`. (optional) 
            var keyword = keyword_example;  // string | Filter items by keywords found in the `name`, `description`, or `sku` fields, or in the brand name.  (optional) 
            var keywordContext = keywordContext_example;  // string | Set context used by the search algorithm to return results targeted towards the specified group. Use `merchant` to help merchants search their own catalog. Use `shopper` to return shopper-facing search results. (optional) 
            var status = 56;  // int? | Filter items by status.  (optional) 
            var include = include_example;  // string | Sub-resources to include on a product, in a comma-separated list. If `options` or `modifiers` is used, results are limited to 10 per page. (optional) 
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 
            var availability = availability_example;  // string | Filter items by availability. Values are: available, disabled, preorder.  (optional) 
            var priceListId = 56;  // int? | This filter returns the product pricing with the *Price List* pricing instead. To use:  `?price_list_id=1`. If there are variants use: `?price_list_id=1&include=variants` (optional) 
            var page = 56;  // int? | Specifies the page number in a limited (paginated) list of products. (optional) 
            var limit = 56;  // int? | Controls the number of items per page in a limited (paginated) list of products. (optional) 
            var direction = direction_example;  // string | Sort direction. Acceptable values are: `asc`, `desc`.  (optional) 
            var sort = sort_example;  // string | Field name to sort by. Note: Since `id` increments when new products are added, you can use that field to sort by product create date.  (optional) 

            try
            {
                // Get All Products
                InlineResponse2001 result = apiInstance.GetProducts(id, idin, idnotIn, idmin, idmax, idgreater, idless, name, sku, upc, price, weight, condition, brandId, dateModified, dateLastImported, isVisible, isFeatured, isFreeShipping, inventoryLevel, inventoryLow, outOfStock, totalSold, type, categories, keyword, keywordContext, status, include, includeFields, excludeFields, availability, priceListId, page, limit, direction, sort);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.GetProducts: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**| Filter items by id.  | [optional] 
 **idin** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **idnotIn** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **idmin** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **idmax** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **idgreater** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **idless** | [**List&lt;int?&gt;**](int?.md)|  | [optional] 
 **name** | **string**| Filter items by name.  | [optional] 
 **sku** | **string**| Filter items by sku.  | [optional] 
 **upc** | **string**| Filter items by upc.  | [optional] 
 **price** | **decimal?**| Filter items by price.  | [optional] 
 **weight** | **decimal?**| Filter items by weight.  | [optional] 
 **condition** | **string**| Filter items by condition.  | [optional] 
 **brandId** | **int?**| Filter items by brand_id.  | [optional] 
 **dateModified** | **DateTime?**| Filter items by date_modified. For example &#x60;v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60; | [optional] 
 **dateLastImported** | **DateTime?**| Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; | [optional] 
 **isVisible** | **bool?**| Filter items by if visible on the storefront.  | [optional] 
 **isFeatured** | **int?**| Filter items by is_featured. &#x60;0&#x60; for true, &#x60;1&#x60; for false.  | [optional] 
 **isFreeShipping** | **int?**| Filter items by is_free_shipping.  | [optional] 
 **inventoryLevel** | **int?**| Filter items by inventory_level.  | [optional] 
 **inventoryLow** | **int?**| Filter items by inventory_low. Values: 1, 0.  | [optional] 
 **outOfStock** | **int?**| Filter items by out_of_stock. To enable the filter, pass &#x60;out_of_stock&#x60;&#x3D;&#x60;1&#x60;.  | [optional] 
 **totalSold** | **int?**| Filter items by total_sold.  | [optional] 
 **type** | **string**| Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;. | [optional] 
 **categories** | **int?**| Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;. | [optional] 
 **keyword** | **string**| Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name.  | [optional] 
 **keywordContext** | **string**| Set context used by the search algorithm to return results targeted towards the specified group. Use &#x60;merchant&#x60; to help merchants search their own catalog. Use &#x60;shopper&#x60; to return shopper-facing search results. | [optional] 
 **status** | **int?**| Filter items by status.  | [optional] 
 **include** | **string**| Sub-resources to include on a product, in a comma-separated list. If &#x60;options&#x60; or &#x60;modifiers&#x60; is used, results are limited to 10 per page. | [optional] 
 **includeFields** | **string**| Fields to include, in a comma-separated list. The ID and the specified fields will be returned. | [optional] 
 **excludeFields** | **string**| Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. | [optional] 
 **availability** | **string**| Filter items by availability. Values are: available, disabled, preorder.  | [optional] 
 **priceListId** | **int?**| This filter returns the product pricing with the *Price List* pricing instead. To use:  &#x60;?price_list_id&#x3D;1&#x60;. If there are variants use: &#x60;?price_list_id&#x3D;1&amp;include&#x3D;variants&#x60; | [optional] 
 **page** | **int?**| Specifies the page number in a limited (paginated) list of products. | [optional] 
 **limit** | **int?**| Controls the number of items per page in a limited (paginated) list of products. | [optional] 
 **direction** | **string**| Sort direction. Acceptable values are: &#x60;asc&#x60;, &#x60;desc&#x60;.  | [optional] 
 **sort** | **string**| Field name to sort by. Note: Since &#x60;id&#x60; increments when new products are added, you can use that field to sort by product create date.  | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateproduct"></a>
# **UpdateProduct**
> ProductResponse UpdateProduct (ProductPut1 body, string accept, string contentType, int? productId, string includeFields = null)

Update a Product

Updates a *Product*.  **Read-Only Fields** - id - date_created - date_modified - calculated_price - base_variant_id 

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class UpdateProductExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductsApi();
            var body = new ProductPut1(); // ProductPut1 | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 

            try
            {
                // Update a Product
                ProductResponse result = apiInstance.UpdateProduct(body, accept, contentType, productId, includeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.UpdateProduct: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ProductPut1**](ProductPut1.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **includeFields** | **string**| Fields to include, in a comma-separated list. The ID and the specified fields will be returned. | [optional] 

### Return type

[**ProductResponse**](ProductResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateproducts"></a>
# **UpdateProducts**
> InlineResponse2001 UpdateProducts (string accept, string contentType, List<Object> body = null, string includeFields = null)

Update Products (Batch)

Updates products in batches. At the time of writing, batches are limited to 10 products.  **Required Fields** * `id` - product `id` is required for batch updates to products.  **Read-Only Fields** - `id` - `date_created` - `date_modified` - `calculated_price` - `base_variant_id`

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class UpdateProductsExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductsApi();
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var body = new List<Object>(); // List<Object> |  (optional) 
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 

            try
            {
                // Update Products (Batch)
                InlineResponse2001 result = apiInstance.UpdateProducts(accept, contentType, body, includeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductsApi.UpdateProducts: " + e.Message );
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
 **body** | [**List&lt;Object&gt;**](Object.md)|  | [optional] 
 **includeFields** | **string**| Fields to include, in a comma-separated list. The ID and the specified fields will be returned. | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
