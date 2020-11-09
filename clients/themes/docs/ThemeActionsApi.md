# BigCommerce.Api.ThemeActionsApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ActivateStoreTheme**](ThemeActionsApi.md#activatestoretheme) | **POST** /themes/actions/activate | Activate a Theme
[**DownloadTheme**](ThemeActionsApi.md#downloadtheme) | **POST** /themes/{uuid}/actions/download | Download a Theme

<a name="activatestoretheme"></a>
# **ActivateStoreTheme**
> NoContent ActivateStoreTheme (Activate1 body, string accept, string contentType)

Activate a Theme

Actives a store *Theme*.   This returns a 204 response upon success.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class ActivateStoreThemeExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ThemeActionsApi();
            var body = new Activate1(); // Activate1 | Request parameters.
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)

            try
            {
                // Activate a Theme
                NoContent result = apiInstance.ActivateStoreTheme(body, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ThemeActionsApi.ActivateStoreTheme: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Activate1**](Activate1.md)| Request parameters. | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]

### Return type

[**NoContent**](NoContent.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="downloadtheme"></a>
# **DownloadTheme**
> JobId DownloadTheme (WhichThemeToDownload body, string accept, string contentType, string uuid)

Download a Theme

Downloads a stores *Theme*.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class DownloadThemeExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ThemeActionsApi();
            var body = new WhichThemeToDownload(); // WhichThemeToDownload | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var uuid = uuid_example;  // string | The theme identifier.

            try
            {
                // Download a Theme
                JobId result = apiInstance.DownloadTheme(body, accept, contentType, uuid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ThemeActionsApi.DownloadTheme: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**WhichThemeToDownload**](WhichThemeToDownload.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **uuid** | **string**| The theme identifier. | 

### Return type

[**JobId**](JobId.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
