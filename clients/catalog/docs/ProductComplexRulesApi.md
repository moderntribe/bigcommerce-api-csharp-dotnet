# BigCommerce.Api.ProductComplexRulesApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateComplexRule**](ProductComplexRulesApi.md#createcomplexrule) | **POST** /catalog/products/{product_id}/complex-rules | Create a Complex Rule
[**DeleteComplexRuleById**](ProductComplexRulesApi.md#deletecomplexrulebyid) | **DELETE** /catalog/products/{product_id}/complex-rules/{complex_rule_id} | Delete a Complex Rule
[**GetComplexRuleById**](ProductComplexRulesApi.md#getcomplexrulebyid) | **GET** /catalog/products/{product_id}/complex-rules/{complex_rule_id} | Get a Complex Rule
[**GetComplexRules**](ProductComplexRulesApi.md#getcomplexrules) | **GET** /catalog/products/{product_id}/complex-rules | Get Complex Rules
[**UpdateComplexRule**](ProductComplexRulesApi.md#updatecomplexrule) | **PUT** /catalog/products/{product_id}/complex-rules/{complex_rule_id} | Update a Complex Rule

<a name="createcomplexrule"></a>
# **CreateComplexRule**
> InlineResponse2005 CreateComplexRule (ComplexRule body, string accept, string contentType, int? productId)

Create a Complex Rule

Creates a product *Complex Rule*.  **Required Fields** - modifier_id - modifier_value_id - modifier_value_id - variant_id  **Read-Only Fields** - complex_rule_id - conditions_id - rule_id - combination_id - id

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class CreateComplexRuleExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductComplexRulesApi();
            var body = new ComplexRule(); // ComplexRule | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 

            try
            {
                // Create a Complex Rule
                InlineResponse2005 result = apiInstance.CreateComplexRule(body, accept, contentType, productId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductComplexRulesApi.CreateComplexRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ComplexRule**](ComplexRule.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletecomplexrulebyid"></a>
# **DeleteComplexRuleById**
> void DeleteComplexRuleById (int? productId, int? complexRuleId, string contentType, string accept)

Delete a Complex Rule

Deletes a product *Complex Rule*.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class DeleteComplexRuleByIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductComplexRulesApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var complexRuleId = 56;  // int? | The ID of the `ComplexRule`. 
            var contentType = contentType_example;  // string |  (default to application/json)
            var accept = accept_example;  // string |  (default to application/json)

            try
            {
                // Delete a Complex Rule
                apiInstance.DeleteComplexRuleById(productId, complexRuleId, contentType, accept);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductComplexRulesApi.DeleteComplexRuleById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **complexRuleId** | **int?**| The ID of the &#x60;ComplexRule&#x60;.  | 
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
<a name="getcomplexrulebyid"></a>
# **GetComplexRuleById**
> InlineResponse2005 GetComplexRuleById (int? productId, int? complexRuleId, string accept, string contentType, string includeFields = null, string excludeFields = null)

Get a Complex Rule

Returns a single *Complex Rule*. Optional parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class GetComplexRuleByIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductComplexRulesApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var complexRuleId = 56;  // int? | The ID of the `ComplexRule`. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 

            try
            {
                // Get a Complex Rule
                InlineResponse2005 result = apiInstance.GetComplexRuleById(productId, complexRuleId, accept, contentType, includeFields, excludeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductComplexRulesApi.GetComplexRuleById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **complexRuleId** | **int?**| The ID of the &#x60;ComplexRule&#x60;.  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **includeFields** | **string**| Fields to include, in a comma-separated list. The ID and the specified fields will be returned. | [optional] 
 **excludeFields** | **string**| Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. | [optional] 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getcomplexrules"></a>
# **GetComplexRules**
> ComplexRuleCollectionResponse GetComplexRules (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null)

Get Complex Rules

Returns a list of all product *Complex Rules*. Optional parameters may be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class GetComplexRulesExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductComplexRulesApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 

            try
            {
                // Get Complex Rules
                ComplexRuleCollectionResponse result = apiInstance.GetComplexRules(productId, accept, contentType, includeFields, excludeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductComplexRulesApi.GetComplexRules: " + e.Message );
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

### Return type

[**ComplexRuleCollectionResponse**](ComplexRuleCollectionResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatecomplexrule"></a>
# **UpdateComplexRule**
> InlineResponse2005 UpdateComplexRule (ComplexRule1 body, int? productId, int? complexRuleId)

Update a Complex Rule

Updates a *Complex Rule*.  **Required Fields**: - none  **Read-Only Fields**: - complex_rule_id - conditions_id - rule_id - combination_id - id

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class UpdateComplexRuleExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductComplexRulesApi();
            var body = new ComplexRule1(); // ComplexRule1 | 
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var complexRuleId = 56;  // int? | The ID of the `ComplexRule`. 

            try
            {
                // Update a Complex Rule
                InlineResponse2005 result = apiInstance.UpdateComplexRule(body, productId, complexRuleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductComplexRulesApi.UpdateComplexRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ComplexRule1**](ComplexRule1.md)|  | 
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **complexRuleId** | **int?**| The ID of the &#x60;ComplexRule&#x60;.  | 

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
