# Themes.Api.ThemeJobsApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetJob**](ThemeJobsApi.md#getjob) | **GET** /themes/jobs/{job_id} | Get a Theme Job

<a name="getjob"></a>
# **GetJob**
> JobResponse GetJob (string jobId, string accept, string contentType)

Get a Theme Job

Returns a theme *Job*. If job is completed, the result is included in the response.

### Example
```csharp
using System;
using System.Diagnostics;
using Themes.Api;
using Themes.Client;
using Themes.Model;

namespace Example
{
    public class GetJobExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new ThemeJobsApi();
            var jobId = jobId_example;  // string | The job identifier.
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)

            try
            {
                // Get a Theme Job
                JobResponse result = apiInstance.GetJob(jobId, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ThemeJobsApi.GetJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobId** | **string**| The job identifier. | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]

### Return type

[**JobResponse**](JobResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
