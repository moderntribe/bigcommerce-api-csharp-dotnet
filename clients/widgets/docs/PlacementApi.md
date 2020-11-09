# Widgets.Api.PlacementApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreatePlacement**](PlacementApi.md#createplacement) | **POST** /content/placements | Create a Placement
[**DeletePlacement**](PlacementApi.md#deleteplacement) | **DELETE** /content/placements/{uuid} | Delete a Placement
[**GetPlacement**](PlacementApi.md#getplacement) | **GET** /content/placements/{uuid} | Get a Placement
[**GetPlacements**](PlacementApi.md#getplacements) | **GET** /content/placements | Get All Placements
[**UpdatePlacement**](PlacementApi.md#updateplacement) | **PUT** /content/placements/{uuid} | Update a Placement

<a name="createplacement"></a>
# **CreatePlacement**
> InlineResponse2004 CreatePlacement (PlacementPost1 body, string accept = null, string contentType = null)

Create a Placement

Creates a **Placement**.  ## Template files  The `template_file` property accepts the following values.  |Template File|Description| |-|-| |`pages/blog-post`|Blog posts template| |`pages/blog`|Blog posts template| |`pages/brand`|Brand page template| |`pages/category`|Category page template| |`pages/home`|Home page template| |`pages/page`|Content page template| |`pages/product`|Product page template| |`pages/search`|Search page template|

### Example
```csharp
using System;
using System.Diagnostics;
using Widgets.Api;
using Widgets.Client;
using Widgets.Model;

namespace Example
{
    public class CreatePlacementExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new PlacementApi();
            var body = new PlacementPost1(); // PlacementPost1 | 
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Create a Placement
                InlineResponse2004 result = apiInstance.CreatePlacement(body, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlacementApi.CreatePlacement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PlacementPost1**](PlacementPost1.md)|  | 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteplacement"></a>
# **DeletePlacement**
> void DeletePlacement (Guid? uuid, string accept = null, string contentType = null)

Delete a Placement

Deletes a **Placement**.

### Example
```csharp
using System;
using System.Diagnostics;
using Widgets.Api;
using Widgets.Client;
using Widgets.Model;

namespace Example
{
    public class DeletePlacementExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new PlacementApi();
            var uuid = new Guid?(); // Guid? | The identifier for a specific placement.
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Delete a Placement
                apiInstance.DeletePlacement(uuid, accept, contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlacementApi.DeletePlacement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | [**Guid?**](Guid?.md)| The identifier for a specific placement. | 
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
<a name="getplacement"></a>
# **GetPlacement**
> InlineResponse2004 GetPlacement (Guid? uuid, string accept = null, string contentType = null)

Get a Placement

Returns a single **Placement**.

### Example
```csharp
using System;
using System.Diagnostics;
using Widgets.Api;
using Widgets.Client;
using Widgets.Model;

namespace Example
{
    public class GetPlacementExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new PlacementApi();
            var uuid = new Guid?(); // Guid? | The identifier for a specific placement.
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Get a Placement
                InlineResponse2004 result = apiInstance.GetPlacement(uuid, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlacementApi.GetPlacement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **uuid** | [**Guid?**](Guid?.md)| The identifier for a specific placement. | 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getplacements"></a>
# **GetPlacements**
> InlineResponse2003 GetPlacements (int? page = null, int? limit = null, string widgetTemplateKind = null, string templateFile = null, Guid? widgetUuid = null, Guid? widgetTemplateUuid = null, string accept = null, string contentType = null)

Get All Placements

Returns a list of **Placements**. Optional parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using Widgets.Api;
using Widgets.Client;
using Widgets.Model;

namespace Example
{
    public class GetPlacementsExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new PlacementApi();
            var page = 56;  // int? | Specifies the page number in a limited (paginated) list of products.  (optional) 
            var limit = 56;  // int? | Controls the number of items per page in a limited (paginated) list of products.  (optional) 
            var widgetTemplateKind = widgetTemplateKind_example;  // string | The kind of widget template. (optional) 
            var templateFile = templateFile_example;  // string | The template file, for example: `pages/home`. (optional) 
            var widgetUuid = new Guid?(); // Guid? | The identifier for a specific widget. (optional) 
            var widgetTemplateUuid = new Guid?(); // Guid? | The identifier for a specific widget template. (optional) 
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Get All Placements
                InlineResponse2003 result = apiInstance.GetPlacements(page, limit, widgetTemplateKind, templateFile, widgetUuid, widgetTemplateUuid, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlacementApi.GetPlacements: " + e.Message );
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
 **templateFile** | **string**| The template file, for example: &#x60;pages/home&#x60;. | [optional] 
 **widgetUuid** | [**Guid?**](Guid?.md)| The identifier for a specific widget. | [optional] 
 **widgetTemplateUuid** | [**Guid?**](Guid?.md)| The identifier for a specific widget template. | [optional] 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateplacement"></a>
# **UpdatePlacement**
> InlineResponse2004 UpdatePlacement (PlacementPut1 body, Guid? uuid, string accept = null, string contentType = null)

Update a Placement

Updates a **Placement**.

### Example
```csharp
using System;
using System.Diagnostics;
using Widgets.Api;
using Widgets.Client;
using Widgets.Model;

namespace Example
{
    public class UpdatePlacementExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new PlacementApi();
            var body = new PlacementPut1(); // PlacementPut1 | 
            var uuid = new Guid?(); // Guid? | The identifier for a specific placement.
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Update a Placement
                InlineResponse2004 result = apiInstance.UpdatePlacement(body, uuid, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PlacementApi.UpdatePlacement: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**PlacementPut1**](PlacementPut1.md)|  | 
 **uuid** | [**Guid?**](Guid?.md)| The identifier for a specific placement. | 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

[**InlineResponse2004**](InlineResponse2004.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
