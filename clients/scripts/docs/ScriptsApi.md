# Scripts.Api.ScriptsApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateScript**](ScriptsApi.md#createscript) | **POST** /content/scripts | Create a Script
[**DeleteScript**](ScriptsApi.md#deletescript) | **DELETE** /content/scripts/{uuid} | Delete a Script
[**GetScript**](ScriptsApi.md#getscript) | **GET** /content/scripts/{uuid} | Get a Script
[**GetScripts**](ScriptsApi.md#getscripts) | **GET** /content/scripts | Get All Scripts
[**UpdateScript**](ScriptsApi.md#updatescript) | **PUT** /content/scripts/{uuid} | Update a Script

<a name="createscript"></a>
# **CreateScript**
> ScriptResponse1 CreateScript (ScriptPost1 body, string accept, string contentType)

Create a Script

Creates a *Script*.  **Required Fields** * name  **Read Only Fields** * uuid  **Notes** * If kind is `src` –- Only the `src` property is needed, and you can optionally supply a `load_method`. The `html` field should not be specified. * If kind is script_tag - - Only the `script_tag` is needed. The `src` field should not be specified. * Each app can have 10 scripts installed. * Multiple scripts can be created [per call](https://developer.bigcommerce.com/api-docs/storefront/scripts-overview#scripts_scripts-notes). 

### Example
```csharp
using System;
using System.Diagnostics;
using Scripts.Api;
using Scripts.Client;
using Scripts.Model;

namespace Example
{
    public class CreateScriptExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ScriptsApi();
            var body = new ScriptPost1(); // ScriptPost1 | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)

            try
            {
                // Create a Script
                ScriptResponse1 result = apiInstance.CreateScript(body, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.CreateScript: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**ScriptPost1**](ScriptPost1.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]

### Return type

[**ScriptResponse1**](ScriptResponse1.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletescript"></a>
# **DeleteScript**
> NoContent DeleteScript (Guid? uuid, string accept, string contentType)

Delete a Script

Deletes a *Script*.

### Example
```csharp
using System;
using System.Diagnostics;
using Scripts.Api;
using Scripts.Client;
using Scripts.Model;

namespace Example
{
    public class DeleteScriptExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ScriptsApi();
            var uuid = new Guid?(); // Guid? | The identifier for a specific script.
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)

            try
            {
                // Delete a Script
                NoContent result = apiInstance.DeleteScript(uuid, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.DeleteScript: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | [**Guid?**](Guid?.md)| The identifier for a specific script. | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]

### Return type

[**NoContent**](NoContent.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getscript"></a>
# **GetScript**
> ScriptResponse1 GetScript (Guid? uuid, string accept, string contentType)

Get a Script

Returns a single *Script*.

### Example
```csharp
using System;
using System.Diagnostics;
using Scripts.Api;
using Scripts.Client;
using Scripts.Model;

namespace Example
{
    public class GetScriptExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ScriptsApi();
            var uuid = new Guid?(); // Guid? | The identifier for a specific script.
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)

            try
            {
                // Get a Script
                ScriptResponse1 result = apiInstance.GetScript(uuid, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScript: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | [**Guid?**](Guid?.md)| The identifier for a specific script. | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]

### Return type

[**ScriptResponse1**](ScriptResponse1.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getscripts"></a>
# **GetScripts**
> ScriptsResponse GetScripts (string accept, string contentType, int? page = null, int? limit = null, string sort = null, string direction = null)

Get All Scripts

Returns a list of *Scripts*. Optional parameters can be passed in.  This will only return scripts that have been created by the api key and password that created the script originally. 

### Example
```csharp
using System;
using System.Diagnostics;
using Scripts.Api;
using Scripts.Client;
using Scripts.Model;

namespace Example
{
    public class GetScriptsExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ScriptsApi();
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var page = 56;  // int? | Specifies the page number in a limited (paginated) list of products. (optional) 
            var limit = 56;  // int? | Controls the number of items per page in a limited (paginated) list of products. (optional) 
            var sort = sort_example;  // string | Scripts field name to sort by.  (optional) 
            var direction = direction_example;  // string | Sort direction. Acceptable values are: `asc`, `desc`.  (optional) 

            try
            {
                // Get All Scripts
                ScriptsResponse result = apiInstance.GetScripts(accept, contentType, page, limit, sort, direction);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.GetScripts: " + e.Message );
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
 **page** | **int?**| Specifies the page number in a limited (paginated) list of products. | [optional] 
 **limit** | **int?**| Controls the number of items per page in a limited (paginated) list of products. | [optional] 
 **sort** | **string**| Scripts field name to sort by.  | [optional] 
 **direction** | **string**| Sort direction. Acceptable values are: &#x60;asc&#x60;, &#x60;desc&#x60;.  | [optional] 

### Return type

[**ScriptsResponse**](ScriptsResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatescript"></a>
# **UpdateScript**
> ScriptResponse1 UpdateScript (Body body, string contentType, string accept, Guid? uuid)

Update a Script

Updates a *Script*.

### Example
```csharp
using System;
using System.Diagnostics;
using Scripts.Api;
using Scripts.Client;
using Scripts.Model;

namespace Example
{
    public class UpdateScriptExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ScriptsApi();
            var body = new Body(); // Body | 
            var contentType = contentType_example;  // string |  (default to application/json)
            var accept = accept_example;  // string |  (default to application/json)
            var uuid = new Guid?(); // Guid? | The identifier for a specific script.

            try
            {
                // Update a Script
                ScriptResponse1 result = apiInstance.UpdateScript(body, contentType, accept, uuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ScriptsApi.UpdateScript: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body**](Body.md)|  | 
 **contentType** | **string**|  | [default to application/json]
 **accept** | **string**|  | [default to application/json]
 **uuid** | [**Guid?**](Guid?.md)| The identifier for a specific script. | 

### Return type

[**ScriptResponse1**](ScriptResponse1.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
