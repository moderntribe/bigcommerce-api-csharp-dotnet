# Catalog.Api.ProductCustomFieldsApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCustomField**](ProductCustomFieldsApi.md#createcustomfield) | **POST** /catalog/products/{product_id}/custom-fields | Create a Custom Fields
[**DeleteCustomFieldById**](ProductCustomFieldsApi.md#deletecustomfieldbyid) | **DELETE** /catalog/products/{product_id}/custom-fields/{custom_field_id} | Delete a Custom Field
[**GetCustomFieldById**](ProductCustomFieldsApi.md#getcustomfieldbyid) | **GET** /catalog/products/{product_id}/custom-fields/{custom_field_id} | Get a Custom Field
[**GetCustomFields**](ProductCustomFieldsApi.md#getcustomfields) | **GET** /catalog/products/{product_id}/custom-fields | Get Custom Fields
[**UpdateCustomField**](ProductCustomFieldsApi.md#updatecustomfield) | **PUT** /catalog/products/{product_id}/custom-fields/{custom_field_id} | Update a Custom Field

<a name="createcustomfield"></a>
# **CreateCustomField**
> InlineResponse2007 CreateCustomField (CustomField body, string accept, string contentType, int? productId)

Create a Custom Fields

Creates a *Custom Field*.  **Required Fields:** - name - value  **Read-Only:** - id

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class CreateCustomFieldExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductCustomFieldsApi();
            var body = new CustomField(); // CustomField | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 

            try
            {
                // Create a Custom Fields
                InlineResponse2007 result = apiInstance.CreateCustomField(body, accept, contentType, productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductCustomFieldsApi.CreateCustomField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomField**](CustomField.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletecustomfieldbyid"></a>
# **DeleteCustomFieldById**
> void DeleteCustomFieldById (int? productId, int? customFieldId, string accept, string contentType)

Delete a Custom Field

Deletes a product *Custom Field*.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class DeleteCustomFieldByIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductCustomFieldsApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var customFieldId = 56;  // int? | The ID of the `CustomField`. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)

            try
            {
                // Delete a Custom Field
                apiInstance.DeleteCustomFieldById(productId, customFieldId, accept, contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductCustomFieldsApi.DeleteCustomFieldById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **customFieldId** | **int?**| The ID of the &#x60;CustomField&#x60;.  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]

### Return type

void (empty response body)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcustomfieldbyid"></a>
# **GetCustomFieldById**
> InlineResponse2008 GetCustomFieldById (int? productId, int? customFieldId, string accept, string contentType, string includeFields = null, string excludeFields = null)

Get a Custom Field

Returns a single *Custom Field*. Optional parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class GetCustomFieldByIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductCustomFieldsApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var customFieldId = 56;  // int? | The ID of the `CustomField`. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 

            try
            {
                // Get a Custom Field
                InlineResponse2008 result = apiInstance.GetCustomFieldById(productId, customFieldId, accept, contentType, includeFields, excludeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductCustomFieldsApi.GetCustomFieldById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **customFieldId** | **int?**| The ID of the &#x60;CustomField&#x60;.  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **includeFields** | **string**| Fields to include, in a comma-separated list. The ID and the specified fields will be returned. | [optional] 
 **excludeFields** | **string**| Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. | [optional] 

### Return type

[**InlineResponse2008**](InlineResponse2008.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcustomfields"></a>
# **GetCustomFields**
> InlineResponse2006 GetCustomFields (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null, int? page = null, int? limit = null)

Get Custom Fields

Returns a list of product *Custom Fields*. Optional parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class GetCustomFieldsExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductCustomFieldsApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 
            var page = 56;  // int? | Specifies the page number in a limited (paginated) list of products. (optional) 
            var limit = 56;  // int? | Controls the number of items per page in a limited (paginated) list of products. (optional) 

            try
            {
                // Get Custom Fields
                InlineResponse2006 result = apiInstance.GetCustomFields(productId, accept, contentType, includeFields, excludeFields, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductCustomFieldsApi.GetCustomFields: " + e.Message );
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

[**InlineResponse2006**](InlineResponse2006.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatecustomfield"></a>
# **UpdateCustomField**
> InlineResponse2007 UpdateCustomField (CustomField1 body, string accept, string contentType, int? productId, int? customFieldId)

Update a Custom Field

Updates a *Custom Field*.   **Required Fields** - none  **Read-Only** - id

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class UpdateCustomFieldExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductCustomFieldsApi();
            var body = new CustomField1(); // CustomField1 | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var customFieldId = 56;  // int? | The ID of the `CustomField`. 

            try
            {
                // Update a Custom Field
                InlineResponse2007 result = apiInstance.UpdateCustomField(body, accept, contentType, productId, customFieldId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductCustomFieldsApi.UpdateCustomField: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CustomField1**](CustomField1.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **customFieldId** | **int?**| The ID of the &#x60;CustomField&#x60;.  | 

### Return type

[**InlineResponse2007**](InlineResponse2007.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
