# StoreInfo.Api.TimeZoneApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v2*

Method | HTTP request | Description
------------- | ------------- | -------------
[**TimeGet**](TimeZoneApi.md#timeget) | **GET** /time | Get System Timestamp

<a name="timeget"></a>
# **TimeGet**
> TimeStampFull1 TimeGet (string accept, string contentType)

Get System Timestamp

Returns the system timestamp at the time of the request. The time resource is useful for validating API authentication details and testing client connections.

### Example
```csharp
using System;
using System.Diagnostics;
using StoreInfo.Api;
using StoreInfo.Client;
using StoreInfo.Model;

namespace Example
{
    public class TimeGetExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new TimeZoneApi();
            var accept = accept_example;  // string | 
            var contentType = contentType_example;  // string | 

            try
            {
                // Get System Timestamp
                TimeStampFull1 result = apiInstance.TimeGet(accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TimeZoneApi.TimeGet: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **accept** | **string**|  | 
 **contentType** | **string**|  | 

### Return type

[**TimeStampFull1**](TimeStampFull1.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
