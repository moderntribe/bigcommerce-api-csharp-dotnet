# Catalog.Api.ProductBulkPricingRulesApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateBulkPricingRule**](ProductBulkPricingRulesApi.md#createbulkpricingrule) | **POST** /catalog/products/{product_id}/bulk-pricing-rules | Creates a Bulk Pricing Rule
[**DeleteBulkPricingRuleById**](ProductBulkPricingRulesApi.md#deletebulkpricingrulebyid) | **DELETE** /catalog/products/{product_id}/bulk-pricing-rules/{bulk_pricing_rule_id} | Delete a Bulk Pricing Rule
[**GetBulkPricingRuleById**](ProductBulkPricingRulesApi.md#getbulkpricingrulebyid) | **GET** /catalog/products/{product_id}/bulk-pricing-rules/{bulk_pricing_rule_id} | Get a Bulk Pricing Rule
[**GetBulkPricingRules**](ProductBulkPricingRulesApi.md#getbulkpricingrules) | **GET** /catalog/products/{product_id}/bulk-pricing-rules | Get All Bulk Pricing Rules
[**UpdateBulkPricingRule**](ProductBulkPricingRulesApi.md#updatebulkpricingrule) | **PUT** /catalog/products/{product_id}/bulk-pricing-rules/{bulk_pricing_rule_id} | Update a Bulk Pricing Rule

<a name="createbulkpricingrule"></a>
# **CreateBulkPricingRule**
> InlineResponse2003 CreateBulkPricingRule (BulkPricingRuleFull2 body, string accept, string contentType, int? productId, int? page = null, int? limit = null)

Creates a Bulk Pricing Rule

Creates a *Bulk Pricing Rule*.  **Required Fields** - quantity_min - quantity_max - type - amount  **Read-Only Fields** - id

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class CreateBulkPricingRuleExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductBulkPricingRulesApi();
            var body = new BulkPricingRuleFull2(); // BulkPricingRuleFull2 | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var page = 56;  // int? | Specifies the page number in a limited (paginated) list of products. (optional) 
            var limit = 56;  // int? | Controls the number of items per page in a limited (paginated) list of products. (optional) 

            try
            {
                // Creates a Bulk Pricing Rule
                InlineResponse2003 result = apiInstance.CreateBulkPricingRule(body, accept, contentType, productId, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductBulkPricingRulesApi.CreateBulkPricingRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BulkPricingRuleFull2**](BulkPricingRuleFull2.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **page** | **int?**| Specifies the page number in a limited (paginated) list of products. | [optional] 
 **limit** | **int?**| Controls the number of items per page in a limited (paginated) list of products. | [optional] 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletebulkpricingrulebyid"></a>
# **DeleteBulkPricingRuleById**
> void DeleteBulkPricingRuleById (int? productId, int? bulkPricingRuleId, string accept, string contentType)

Delete a Bulk Pricing Rule

Deletes a *Bulk Pricing Rule*.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class DeleteBulkPricingRuleByIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductBulkPricingRulesApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var bulkPricingRuleId = 56;  // int? | The ID of the `BulkPricingRule`. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)

            try
            {
                // Delete a Bulk Pricing Rule
                apiInstance.DeleteBulkPricingRuleById(productId, bulkPricingRuleId, accept, contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductBulkPricingRulesApi.DeleteBulkPricingRuleById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **bulkPricingRuleId** | **int?**| The ID of the &#x60;BulkPricingRule&#x60;.  | 
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
<a name="getbulkpricingrulebyid"></a>
# **GetBulkPricingRuleById**
> InlineResponse2003 GetBulkPricingRuleById (int? productId, int? bulkPricingRuleId, string accept, string contentType, string includeFields = null, string excludeFields = null)

Get a Bulk Pricing Rule

Returns a single *Bulk Pricing Rule*. Optional parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class GetBulkPricingRuleByIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductBulkPricingRulesApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var bulkPricingRuleId = 56;  // int? | The ID of the `BulkPricingRule`. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 

            try
            {
                // Get a Bulk Pricing Rule
                InlineResponse2003 result = apiInstance.GetBulkPricingRuleById(productId, bulkPricingRuleId, accept, contentType, includeFields, excludeFields);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductBulkPricingRulesApi.GetBulkPricingRuleById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **bulkPricingRuleId** | **int?**| The ID of the &#x60;BulkPricingRule&#x60;.  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **includeFields** | **string**| Fields to include, in a comma-separated list. The ID and the specified fields will be returned. | [optional] 
 **excludeFields** | **string**| Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. | [optional] 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getbulkpricingrules"></a>
# **GetBulkPricingRules**
> InlineResponse2002 GetBulkPricingRules (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null, int? page = null, int? limit = null)

Get All Bulk Pricing Rules

Returns a list of *Bulk Pricing Rules*. Optional parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class GetBulkPricingRulesExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductBulkPricingRulesApi();
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var includeFields = includeFields_example;  // string | Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional) 
            var excludeFields = excludeFields_example;  // string | Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional) 
            var page = 56;  // int? | Specifies the page number in a limited (paginated) list of products. (optional) 
            var limit = 56;  // int? | Controls the number of items per page in a limited (paginated) list of products. (optional) 

            try
            {
                // Get All Bulk Pricing Rules
                InlineResponse2002 result = apiInstance.GetBulkPricingRules(productId, accept, contentType, includeFields, excludeFields, page, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductBulkPricingRulesApi.GetBulkPricingRules: " + e.Message );
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

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatebulkpricingrule"></a>
# **UpdateBulkPricingRule**
> InlineResponse2004 UpdateBulkPricingRule (BulkPricingRuleFull3 body, string accept, string contentType, int? productId, int? bulkPricingRuleId)

Update a Bulk Pricing Rule

Updates a *Bulk Pricing Rule*.  **Required Fields** * none  **Read-Only Fields** - id

### Example
```csharp
using System;
using System.Diagnostics;
using Catalog.Api;
using Catalog.Client;
using Catalog.Model;

namespace Example
{
    public class UpdateBulkPricingRuleExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ProductBulkPricingRulesApi();
            var body = new BulkPricingRuleFull3(); // BulkPricingRuleFull3 | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var productId = 56;  // int? | The ID of the `Product` to which the resource belongs. 
            var bulkPricingRuleId = 56;  // int? | The ID of the `BulkPricingRule`. 

            try
            {
                // Update a Bulk Pricing Rule
                InlineResponse2004 result = apiInstance.UpdateBulkPricingRule(body, accept, contentType, productId, bulkPricingRuleId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProductBulkPricingRulesApi.UpdateBulkPricingRule: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**BulkPricingRuleFull3**](BulkPricingRuleFull3.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **productId** | **int?**| The ID of the &#x60;Product&#x60; to which the resource belongs.  | 
 **bulkPricingRuleId** | **int?**| The ID of the &#x60;BulkPricingRule&#x60;.  | 

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
