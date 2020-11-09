# Widgets.Api.RegionsApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetContentRegions**](RegionsApi.md#getcontentregions) | **GET** /content/regions | Get Theme Regions

<a name="getcontentregions"></a>
# **GetContentRegions**
> InlineResponse2005 GetContentRegions (string templateFile, string accept = null, string contentType = null)

Get Theme Regions

Returns a list of unique **Theme Regions** in a file.  **Required Query** * `template_file`

### Example
```csharp
using System;
using System.Diagnostics;
using Widgets.Api;
using Widgets.Client;
using Widgets.Model;

namespace Example
{
    public class GetContentRegionsExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new RegionsApi();
            var templateFile = templateFile_example;  // string | The template file, for example: `templateFile=pages/home`.
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Get Theme Regions
                InlineResponse2005 result = apiInstance.GetContentRegions(templateFile, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RegionsApi.GetContentRegions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **templateFile** | **string**| The template file, for example: &#x60;templateFile&#x3D;pages/home&#x60;. | 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

[**InlineResponse2005**](InlineResponse2005.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
