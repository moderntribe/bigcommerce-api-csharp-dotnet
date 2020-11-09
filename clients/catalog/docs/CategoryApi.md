# Catalog.Api.CategoryApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCategory**](CategoryApi.md#createcategory) | **POST** /catalog/categories | Create a Category
[**DeleteCategories**](CategoryApi.md#deletecategories) | **DELETE** /catalog/categories | Delete Categories
[**DeleteCategoryById**](CategoryApi.md#deletecategorybyid) | **DELETE** /catalog/categories/{category_id} | Delete a Category
[**GetCategories**](CategoryApi.md#getcategories) | **GET** /catalog/categories | Get All Categories
[**GetCategoryById**](CategoryApi.md#getcategorybyid) | **GET** /catalog/categories/{category_id} | Get a Category
[**GetCategoryTree**](CategoryApi.md#getcategorytree) | **GET** /catalog/categories/tree | Get Category Tree
[**UpdateCategory**](CategoryApi.md#updatecategory) | **PUT** /catalog/categories/{category_id} | Update a Category

<a name="createcategory"></a>
# **CreateCategory**
> CategoryResponse CreateCategory (Category body, string accept, string contentType)

Create a Category

Creates a *Category*.  **Required Fields**: - parent_id:   - To create a child category, set the parent_id to the parent category.  - To create a top level category, set the parent_id to 0. - name  **Read-Only Fields**: - id

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class CreateCategoryExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new CategoryApi();
            var body = new Category(); // Category | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)

            try
            {
                // Create a Category
                CategoryResponse result = apiInstance.CreateCategory(body, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoryApi.CreateCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Category**](Category.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]

### Return type

[**CategoryResponse**](CategoryResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletecategories"></a>
# **DeleteCategories**
> void DeleteCategories (string accept, string contentType, string name = null, int? parentId = null, string pageTitle = null, string keyword = null, bool? isVisible = null)

Delete Categories

By default, it deletes all *Category* objects. A filter should be added to avoid deleting all *Category* objects in a store.  Sending a `DELETE` to this endpoint will result in a `422` error. Move products to a new category by sending a `PUT` to the `/catalog/products/{product_id}` endpoint before deleting a category.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class DeleteCategoriesExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new CategoryApi();
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var name = name_example;  // string | Filter items by name.  (optional) 
            var parentId = 56;  // int? | Filter items by parent_id. If the category is a child or sub category it can be filtered with the parent_id.  (optional) 
            var pageTitle = pageTitle_example;  // string | Filter items by page_title.  (optional) 
            var keyword = keyword_example;  // string | Filter items by keywords. eg. new, towel, bath (optional) 
            var isVisible = true;  // bool? | Filter items by if visible on the storefront.  (optional) 

            try
            {
                // Delete Categories
                apiInstance.DeleteCategories(accept, contentType, name, parentId, pageTitle, keyword, isVisible);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoryApi.DeleteCategories: " + e.Message );
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
 **parentId** | **int?**| Filter items by parent_id. If the category is a child or sub category it can be filtered with the parent_id.  | [optional] 
 **pageTitle** | **string**| Filter items by page_title.  | [optional] 
 **keyword** | **string**| Filter items by keywords. eg. new, towel, bath | [optional] 
 **isVisible** | **bool?**| Filter items by if visible on the storefront.  | [optional] 

### Return type

void (empty response body)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletecategorybyid"></a>
# **DeleteCategoryById**
> void DeleteCategoryById (int? categoryId, string accept, string contentType)

Delete a Category

Deletes a *Category*.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class DeleteCategoryByIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new CategoryApi();
            var categoryId = 56;  // int? | The ID of the `Category` to which the resource belongs. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)

            try
            {
                // Delete a Category
                apiInstance.DeleteCategoryById(categoryId, accept, contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoryApi.DeleteCategoryById: " + e.Message );
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
<a name="getcategories"></a>
# **GetCategories**
> CategoryBase GetCategories (string accept, string contentType, int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, string name = null, int? parentId = null, string pageTitle = null, string keyword = null, bool? isVisible = null, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null)

Get All Categories

Returns a list of *Categories*. Optional filter parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class GetCategoriesExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new CategoryApi();
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
            var parentId = 56;  // int? | Filter items by parent_id. If the category is a child or sub category it can be filtered with the parent_id.  (optional) 
            var pageTitle = pageTitle_example;  // string | Filter items by page_title.  (optional) 
            var keyword = keyword_example;  // string | Filter items by keywords. eg. new, towel, bath (optional) 
            var isVisible = true;  // bool? | Filter items by if visible on the storefront.  (optional) 
            var page = 56;  // int? | Specifies the page number in a limited (paginated) list of products. (optional) 
            var limit = 56;  // int? | Controls the number of items per page in a limited (paginated) list of products. (optional) 
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 

            try
            {
                // Get All Categories
                CategoryBase result = apiInstance.GetCategories(accept, contentType, id, idin, idnotIn, idmin, idmax, idgreater, idless, name, parentId, pageTitle, keyword, isVisible, page, limit, includeFields, excludeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoryApi.GetCategories: " + e.Message );
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
 **parentId** | **int?**| Filter items by parent_id. If the category is a child or sub category it can be filtered with the parent_id.  | [optional] 
 **pageTitle** | **string**| Filter items by page_title.  | [optional] 
 **keyword** | **string**| Filter items by keywords. eg. new, towel, bath | [optional] 
 **isVisible** | **bool?**| Filter items by if visible on the storefront.  | [optional] 
 **page** | **int?**| Specifies the page number in a limited (paginated) list of products. | [optional] 
 **limit** | **int?**| Controls the number of items per page in a limited (paginated) list of products. | [optional] 
 **includeFields** | **string**| Fields to include, in a comma-separated list. The ID and the specified fields will be returned. | [optional] 
 **excludeFields** | **string**| Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. | [optional] 

### Return type

[**CategoryBase**](CategoryBase.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcategorybyid"></a>
# **GetCategoryById**
> CategoryResponse GetCategoryById (int? categoryId, string includeFields = null, string excludeFields = null)

Get a Category

Returns a single *Category*. Optional parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class GetCategoryByIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new CategoryApi();
            var categoryId = 56;  // int? | The ID of the `Category` to which the resource belongs. 
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 

            try
            {
                // Get a Category
                CategoryResponse result = apiInstance.GetCategoryById(categoryId, includeFields, excludeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoryApi.GetCategoryById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **categoryId** | **int?**| The ID of the &#x60;Category&#x60; to which the resource belongs.  | 
 **includeFields** | **string**| Fields to include, in a comma-separated list. The ID and the specified fields will be returned. | [optional] 
 **excludeFields** | **string**| Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. | [optional] 

### Return type

[**CategoryResponse**](CategoryResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcategorytree"></a>
# **GetCategoryTree**
> CategoriesTreeResp1 GetCategoryTree (string accept, string contentType)

Get Category Tree

Returns the categories tree, a nested lineage of the categories with parent->child relationship. The Category objects returned are simplified versions of the category objects returned in the rest of this API.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class GetCategoryTreeExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new CategoryApi();
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)

            try
            {
                // Get Category Tree
                CategoriesTreeResp1 result = apiInstance.GetCategoryTree(accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoryApi.GetCategoryTree: " + e.Message );
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

### Return type

[**CategoriesTreeResp1**](CategoriesTreeResp1.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatecategory"></a>
# **UpdateCategory**
> CategoryResponse1 UpdateCategory (Category1 body, string accept, string contentType, int? categoryId)

Update a Category

Updates a *Category*.  **Required Fields** * none  **Read-Only Fields** - id

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class UpdateCategoryExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new CategoryApi();
            var body = new Category1(); // Category1 | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var categoryId = 56;  // int? | The ID of the `Category` to which the resource belongs. 

            try
            {
                // Update a Category
                CategoryResponse1 result = apiInstance.UpdateCategory(body, accept, contentType, categoryId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CategoryApi.UpdateCategory: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Category1**](Category1.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **categoryId** | **int?**| The ID of the &#x60;Category&#x60; to which the resource belongs.  | 

### Return type

[**CategoryResponse1**](CategoryResponse1.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
