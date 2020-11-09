# BigCommerce.Api.WidgetTemplateApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateWidgetTemplate**](WidgetTemplateApi.md#createwidgettemplate) | **POST** /content/widget-templates | Create a Widget Template
[**DeleteWidgetTemplate**](WidgetTemplateApi.md#deletewidgettemplate) | **DELETE** /content/widget-templates/{uuid} | Delete A Widget Template
[**GetWidgetTemplate**](WidgetTemplateApi.md#getwidgettemplate) | **GET** /content/widget-templates/{uuid} | Get a Widget Template
[**GetWidgetTemplates**](WidgetTemplateApi.md#getwidgettemplates) | **GET** /content/widget-templates | Get All Widget Templates
[**UpdateWidgetTemplate**](WidgetTemplateApi.md#updatewidgettemplate) | **PUT** /content/widget-templates/{uuid} | Update a Widget Template

<a name="createwidgettemplate"></a>
# **CreateWidgetTemplate**
> Object CreateWidgetTemplate (WidgetTemplatePost1 body, string accept = null, string contentType = null)

Create a Widget Template

Creates a **Widget Template**.  ***Note:*** *There is a limit of 100 custom widget templates per store.*  **Required Fields** * name * template

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class CreateWidgetTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new WidgetTemplateApi();
            var body = new WidgetTemplatePost1(); // WidgetTemplatePost1 | 
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Create a Widget Template
                Object result = apiInstance.CreateWidgetTemplate(body, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WidgetTemplateApi.CreateWidgetTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WidgetTemplatePost1**](WidgetTemplatePost1.md)|  | 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

**Object**

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletewidgettemplate"></a>
# **DeleteWidgetTemplate**
> void DeleteWidgetTemplate (Guid? uuid, string accept = null, string contentType = null)

Delete A Widget Template

Delete a **Widget Template**.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class DeleteWidgetTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new WidgetTemplateApi();
            var uuid = new Guid?(); // Guid? | The identifier for a specific template.
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Delete A Widget Template
                apiInstance.DeleteWidgetTemplate(uuid, accept, contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WidgetTemplateApi.DeleteWidgetTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | [**Guid?**](Guid?.md)| The identifier for a specific template. | 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

void (empty response body)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getwidgettemplate"></a>
# **GetWidgetTemplate**
> Object GetWidgetTemplate (Guid? uuid, string accept = null, string contentType = null)

Get a Widget Template

Return a single **Widget Template**.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class GetWidgetTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new WidgetTemplateApi();
            var uuid = new Guid?(); // Guid? | The identifier for a specific template.
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Get a Widget Template
                Object result = apiInstance.GetWidgetTemplate(uuid, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WidgetTemplateApi.GetWidgetTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | [**Guid?**](Guid?.md)| The identifier for a specific template. | 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

**Object**

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getwidgettemplates"></a>
# **GetWidgetTemplates**
> InlineResponse200 GetWidgetTemplates (int? page = null, int? limit = null, string widgetTemplateKind = null, string accept = null, string contentType = null)

Get All Widget Templates

Returns a list of **Widget Templates**.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class GetWidgetTemplatesExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new WidgetTemplateApi();
            var page = 56;  // int? | Specifies the page number in a limited (paginated) list of products.  (optional) 
            var limit = 56;  // int? | Controls the number of items per page in a limited (paginated) list of products.  (optional) 
            var widgetTemplateKind = widgetTemplateKind_example;  // string | The kind of widget template. (optional) 
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Get All Widget Templates
                InlineResponse200 result = apiInstance.GetWidgetTemplates(page, limit, widgetTemplateKind, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WidgetTemplateApi.GetWidgetTemplates: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **page** | **int?**| Specifies the page number in a limited (paginated) list of products.  | [optional] 
 **limit** | **int?**| Controls the number of items per page in a limited (paginated) list of products.  | [optional] 
 **widgetTemplateKind** | **string**| The kind of widget template. | [optional] 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatewidgettemplate"></a>
# **UpdateWidgetTemplate**
> Object UpdateWidgetTemplate (WidgetTemplatePut1 body, Guid? uuid, string accept = null, string contentType = null)

Update a Widget Template

Update a **Widget Template**.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class UpdateWidgetTemplateExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new WidgetTemplateApi();
            var body = new WidgetTemplatePut1(); // WidgetTemplatePut1 | 
            var uuid = new Guid?(); // Guid? | The identifier for a specific template.
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Update a Widget Template
                Object result = apiInstance.UpdateWidgetTemplate(body, uuid, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WidgetTemplateApi.UpdateWidgetTemplate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WidgetTemplatePut1**](WidgetTemplatePut1.md)|  | 
 **uuid** | [**Guid?**](Guid?.md)| The identifier for a specific template. | 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

**Object**

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
