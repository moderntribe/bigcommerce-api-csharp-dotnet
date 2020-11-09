# BigCommerce.Api.SubscribersApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSubscriber**](SubscribersApi.md#createsubscriber) | **POST** /customers/subscribers | Create a Subscriber
[**DeleteSubscriberById**](SubscribersApi.md#deletesubscriberbyid) | **DELETE** /customers/subscribers/{subscriber_id} | Delete a Subscriber
[**DeleteSubscribers**](SubscribersApi.md#deletesubscribers) | **DELETE** /customers/subscribers | Delete Subscribers
[**GetSubscriberById**](SubscribersApi.md#getsubscriberbyid) | **GET** /customers/subscribers/{subscriber_id} | Get a Subscriber
[**GetSubscribers**](SubscribersApi.md#getsubscribers) | **GET** /customers/subscribers | Get Subscribers
[**UpdateSubscriber**](SubscribersApi.md#updatesubscriber) | **PUT** /customers/subscribers/{subscriber_id} | Update a Subscriber

<a name="createsubscriber"></a>
# **CreateSubscriber**
> SubscriberResponse CreateSubscriber (SubscriberPost1 body, string accept = null, string contentType = null)

Create a Subscriber

Creates a *Subscriber*.  **Required Fields** * email  **Read Only Fields** * id

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class CreateSubscriberExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new SubscribersApi();
            var body = new SubscriberPost1(); // SubscriberPost1 | 
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Create a Subscriber
                SubscriberResponse result = apiInstance.CreateSubscriber(body, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscribersApi.CreateSubscriber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubscriberPost1**](SubscriberPost1.md)|  | 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

[**SubscriberResponse**](SubscriberResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletesubscriberbyid"></a>
# **DeleteSubscriberById**
> void DeleteSubscriberById (int? subscriberId, string contentType = null, string accept = null)

Delete a Subscriber

Deletes a *Subscriber*.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class DeleteSubscriberByIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new SubscribersApi();
            var subscriberId = 56;  // int? | The ID of the `Subscriber` requested. 
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)
            var accept = accept_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Delete a Subscriber
                apiInstance.DeleteSubscriberById(subscriberId, contentType, accept);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscribersApi.DeleteSubscriberById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subscriberId** | **int?**| The ID of the &#x60;Subscriber&#x60; requested.  | 
 **contentType** | **string**|  | [optional] [default to application/json]
 **accept** | **string**|  | [optional] [default to application/json]

### Return type

void (empty response body)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deletesubscribers"></a>
# **DeleteSubscribers**
> void DeleteSubscribers (string email = null, string firstName = null, string lastName = null, string source = null, int? orderId = null, DateTime? dateCreated = null, DateTime? dateModified = null, string accept = null, string contentType = null)

Delete Subscribers

By default, it deletes all *Subscribers*. A filter should be added to avoid deleting all subscribers in a store.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class DeleteSubscribersExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new SubscribersApi();
            var email = email_example;  // string | Filter items by email.  (optional) 
            var firstName = firstName_example;  // string | Filter items by first_name.  (optional) 
            var lastName = lastName_example;  // string | Filter items by last_name.  (optional) 
            var source = source_example;  // string | Filter items by source.  (optional) 
            var orderId = 56;  // int? | Filter items by order_id.  (optional) 
            var dateCreated = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter items by date_created.  (optional) 
            var dateModified = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter items by date_modified. For example `v3/catalog/products?date_last_imported:min=2018-06-15` (optional) 
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Delete Subscribers
                apiInstance.DeleteSubscribers(email, firstName, lastName, source, orderId, dateCreated, dateModified, accept, contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscribersApi.DeleteSubscribers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| Filter items by email.  | [optional] 
 **firstName** | **string**| Filter items by first_name.  | [optional] 
 **lastName** | **string**| Filter items by last_name.  | [optional] 
 **source** | **string**| Filter items by source.  | [optional] 
 **orderId** | **int?**| Filter items by order_id.  | [optional] 
 **dateCreated** | **DateTime?**| Filter items by date_created.  | [optional] 
 **dateModified** | **DateTime?**| Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; | [optional] 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

void (empty response body)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsubscriberbyid"></a>
# **GetSubscriberById**
> SubscriberResponse GetSubscriberById (int? subscriberId, string accept = null, string contentType = null)

Get a Subscriber

Returns a *Subscriber*.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class GetSubscriberByIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new SubscribersApi();
            var subscriberId = 56;  // int? | The ID of the `Subscriber` requested. 
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Get a Subscriber
                SubscriberResponse result = apiInstance.GetSubscriberById(subscriberId, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscribersApi.GetSubscriberById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **subscriberId** | **int?**| The ID of the &#x60;Subscriber&#x60; requested.  | 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

[**SubscriberResponse**](SubscriberResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getsubscribers"></a>
# **GetSubscribers**
> SubscriberCollectionResponse GetSubscribers (string email = null, string firstName = null, string lastName = null, string source = null, int? orderId = null, DateTime? dateCreated = null, DateTime? dateModified = null, int? page = null, int? limit = null, string accept = null, string contentType = null)

Get Subscribers

Returns a list of *Subscribers*. Optional filter parameters can be passed in.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class GetSubscribersExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new SubscribersApi();
            var email = email_example;  // string | Filter items by email.  (optional) 
            var firstName = firstName_example;  // string | Filter items by first_name.  (optional) 
            var lastName = lastName_example;  // string | Filter items by last_name.  (optional) 
            var source = source_example;  // string | Filter items by source.  (optional) 
            var orderId = 56;  // int? | Filter items by order_id.  (optional) 
            var dateCreated = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter items by date_created.  (optional) 
            var dateModified = 2013-10-20T19:20:30+01:00;  // DateTime? | Filter items by date_modified. For example `v3/catalog/products?date_last_imported:min=2018-06-15` (optional) 
            var page = 56;  // int? | Specifies the page number in a limited (paginated) list of products. (optional) 
            var limit = 56;  // int? | Controls the number of items per page in a limited (paginated) list of products. (optional) 
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Get Subscribers
                SubscriberCollectionResponse result = apiInstance.GetSubscribers(email, firstName, lastName, source, orderId, dateCreated, dateModified, page, limit, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscribersApi.GetSubscribers: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **email** | **string**| Filter items by email.  | [optional] 
 **firstName** | **string**| Filter items by first_name.  | [optional] 
 **lastName** | **string**| Filter items by last_name.  | [optional] 
 **source** | **string**| Filter items by source.  | [optional] 
 **orderId** | **int?**| Filter items by order_id.  | [optional] 
 **dateCreated** | **DateTime?**| Filter items by date_created.  | [optional] 
 **dateModified** | **DateTime?**| Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; | [optional] 
 **page** | **int?**| Specifies the page number in a limited (paginated) list of products. | [optional] 
 **limit** | **int?**| Controls the number of items per page in a limited (paginated) list of products. | [optional] 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

[**SubscriberCollectionResponse**](SubscriberCollectionResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updatesubscriber"></a>
# **UpdateSubscriber**
> SubscriberResponse UpdateSubscriber (SubscriberPut1 body, int? subscriberId, string accept = null, string contentType = null)

Update a Subscriber

Updates a *Subscriber*.  **Read Only Fields** * id

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class UpdateSubscriberExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new SubscribersApi();
            var body = new SubscriberPut1(); // SubscriberPut1 | 
            var subscriberId = 56;  // int? | The ID of the `Subscriber` requested. 
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Update a Subscriber
                SubscriberResponse result = apiInstance.UpdateSubscriber(body, subscriberId, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SubscribersApi.UpdateSubscriber: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**SubscriberPut1**](SubscriberPut1.md)|  | 
 **subscriberId** | **int?**| The ID of the &#x60;Subscriber&#x60; requested.  | 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

[**SubscriberResponse**](SubscriberResponse.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
