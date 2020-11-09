# Widgets.Api.WidgetApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateWidget**](WidgetApi.md#createwidget) | **POST** /content/widgets | Create a Widget
[**DeleteWidget**](WidgetApi.md#deletewidget) | **DELETE** /content/widgets/{uuid} | Delete a Widget
[**GetWidget**](WidgetApi.md#getwidget) | **GET** /content/widgets/{uuid} | Get a Widget
[**GetWidgets**](WidgetApi.md#getwidgets) | **GET** /content/widgets | Get All Widgets
[**UpdateWidget**](WidgetApi.md#updatewidget) | **PUT** /content/widgets/{uuid} | Update a Widget

<a name="createwidget"></a>
# **CreateWidget**
> InlineResponse2002 CreateWidget (WidgetPost1 body, string accept = null, string contentType = null)

Create a Widget

Creates a **Widget**.  ***Note:*** *There is a limit of 1000 widgets per store.*  **Required Fields** * name * widget_template_uuid

### Example
```csharp
using System;
using System.Diagnostics;
using Widgets.Api;
using Widgets.Client;
using Widgets.Model;

namespace Example
{
    public class CreateWidgetExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new WidgetApi();
            var body = new WidgetPost1(); // WidgetPost1 | 
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Create a Widget
                InlineResponse2002 result = apiInstance.CreateWidget(body, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WidgetApi.CreateWidget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WidgetPost1**](WidgetPost1.md)|  | 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletewidget"></a>
# **DeleteWidget**
> void DeleteWidget (Guid? uuid, string accept = null, string contentType = null)

Delete a Widget

Deletes a **Widget**.

### Example
```csharp
using System;
using System.Diagnostics;
using Widgets.Api;
using Widgets.Client;
using Widgets.Model;

namespace Example
{
    public class DeleteWidgetExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new WidgetApi();
            var uuid = new Guid?(); // Guid? | The identifier for a specific widget.
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Delete a Widget
                apiInstance.DeleteWidget(uuid, accept, contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WidgetApi.DeleteWidget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | [**Guid?**](Guid?.md)| The identifier for a specific widget. | 
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
<a name="getwidget"></a>
# **GetWidget**
> InlineResponse2002 GetWidget (Guid? uuid, string accept = null, string contentType = null)

Get a Widget

Returns a single **Widget**.

### Example
```csharp
using System;
using System.Diagnostics;
using Widgets.Api;
using Widgets.Client;
using Widgets.Model;

namespace Example
{
    public class GetWidgetExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new WidgetApi();
            var uuid = new Guid?(); // Guid? | The identifier for a specific widget.
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Get a Widget
                InlineResponse2002 result = apiInstance.GetWidget(uuid, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WidgetApi.GetWidget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | [**Guid?**](Guid?.md)| The identifier for a specific widget. | 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getwidgets"></a>
# **GetWidgets**
> InlineResponse2001 GetWidgets (int? page = null, int? limit = null, string widgetTemplateKind = null, Guid? widgetTemplateUuid = null, string accept = null, string contentType = null, string name = null)

Get All Widgets

Returns a list of **Widgets**. Optional parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using Widgets.Api;
using Widgets.Client;
using Widgets.Model;

namespace Example
{
    public class GetWidgetsExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new WidgetApi();
            var page = 56;  // int? | Specifies the page number in a limited (paginated) list of products.  (optional) 
            var limit = 56;  // int? | Controls the number of items per page in a limited (paginated) list of products.  (optional) 
            var widgetTemplateKind = widgetTemplateKind_example;  // string | The kind of widget template. (optional) 
            var widgetTemplateUuid = new Guid?(); // Guid? | The identifier for a specific widget template. (optional) 
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)
            var name = name_example;  // string | The URL encoded name of the widget. Use `name:in` to pass in comma-separated list of widget names. **Ex**: `/widgets?name:in=test-widget-name,header%20images` (optional) 

            try
            {
                // Get All Widgets
                InlineResponse2001 result = apiInstance.GetWidgets(page, limit, widgetTemplateKind, widgetTemplateUuid, accept, contentType, name);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WidgetApi.GetWidgets: " + e.Message );
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
 **widgetTemplateUuid** | [**Guid?**](Guid?.md)| The identifier for a specific widget template. | [optional] 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]
 **name** | **string**| The URL encoded name of the widget. Use &#x60;name:in&#x60; to pass in comma-separated list of widget names. **Ex**: &#x60;/widgets?name:in&#x3D;test-widget-name,header%20images&#x60; | [optional] 

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatewidget"></a>
# **UpdateWidget**
> InlineResponse2002 UpdateWidget (WidgetPut1 body, Guid? uuid, string accept = null, string contentType = null)

Update a Widget

Updates a **Widget**.

### Example
```csharp
using System;
using System.Diagnostics;
using Widgets.Api;
using Widgets.Client;
using Widgets.Model;

namespace Example
{
    public class UpdateWidgetExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new WidgetApi();
            var body = new WidgetPut1(); // WidgetPut1 | 
            var uuid = new Guid?(); // Guid? | The identifier for a specific widget.
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Update a Widget
                InlineResponse2002 result = apiInstance.UpdateWidget(body, uuid, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling WidgetApi.UpdateWidget: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WidgetPut1**](WidgetPut1.md)|  | 
 **uuid** | [**Guid?**](Guid?.md)| The identifier for a specific widget. | 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
