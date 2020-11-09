# OrdersV3.Api.MetafieldsApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOrderMetafield**](MetafieldsApi.md#createordermetafield) | **POST** /orders/{order_id}/metafields | Create Metafields
[**DeleteOrderMetafieldById**](MetafieldsApi.md#deleteordermetafieldbyid) | **DELETE** /orders/{order_id}/metafields/{metafield_id} | Delete a Metafield
[**GetOrderMetafieldByOrderIdAndMetafieldId**](MetafieldsApi.md#getordermetafieldbyorderidandmetafieldid) | **GET** /orders/{order_id}/metafields/{metafield_id} | Get a Metafield
[**GetOrderMetafieldsByOrderId**](MetafieldsApi.md#getordermetafieldsbyorderid) | **GET** /orders/{order_id}/metafields | Get Metafields
[**UpdateOrderMetafield**](MetafieldsApi.md#updateordermetafield) | **PUT** /orders/{order_id}/metafields/{metafield_id} | Update a Metafield

<a name="createordermetafield"></a>
# **CreateOrderMetafield**
> InlineResponse2003 CreateOrderMetafield (Body body, int? orderId)

Create Metafields

Creates an order `Metafield`.

### Example
```csharp
using System;
using System.Diagnostics;
using OrdersV3.Api;
using OrdersV3.Client;
using OrdersV3.Model;

namespace Example
{
    public class CreateOrderMetafieldExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new MetafieldsApi();
            var body = new Body(); // Body | A `Metafield` object.

            var orderId = 56;  // int? | The ID of the `Order` to which the transactions belong. 

            try
            {
                // Create Metafields
                InlineResponse2003 result = apiInstance.CreateOrderMetafield(body, orderId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetafieldsApi.CreateOrderMetafield: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body**](Body.md)| A &#x60;Metafield&#x60; object.
 | 
 **orderId** | **int?**| The ID of the &#x60;Order&#x60; to which the transactions belong.  | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteordermetafieldbyid"></a>
# **DeleteOrderMetafieldById**
> void DeleteOrderMetafieldById (int? orderId, int? metafieldId)

Delete a Metafield

Deletes a `Metafield`. 

### Example
```csharp
using System;
using System.Diagnostics;
using OrdersV3.Api;
using OrdersV3.Client;
using OrdersV3.Model;

namespace Example
{
    public class DeleteOrderMetafieldByIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new MetafieldsApi();
            var orderId = 56;  // int? | The ID of the `Order` to which the transactions belong. 
            var metafieldId = 56;  // int? | The ID of the `Metafield`. 

            try
            {
                // Delete a Metafield
                apiInstance.DeleteOrderMetafieldById(orderId, metafieldId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetafieldsApi.DeleteOrderMetafieldById: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **int?**| The ID of the &#x60;Order&#x60; to which the transactions belong.  | 
 **metafieldId** | **int?**| The ID of the &#x60;Metafield&#x60;.  | 

### Return type

void (empty response body)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getordermetafieldbyorderidandmetafieldid"></a>
# **GetOrderMetafieldByOrderIdAndMetafieldId**
> InlineResponse2003 GetOrderMetafieldByOrderIdAndMetafieldId (int? orderId, int? metafieldId)

Get a Metafield

Gets a `Metafield`, by `order_id`. 

### Example
```csharp
using System;
using System.Diagnostics;
using OrdersV3.Api;
using OrdersV3.Client;
using OrdersV3.Model;

namespace Example
{
    public class GetOrderMetafieldByOrderIdAndMetafieldIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new MetafieldsApi();
            var orderId = 56;  // int? | The ID of the `Order` to which the transactions belong. 
            var metafieldId = 56;  // int? | The ID of the `Metafield`. 

            try
            {
                // Get a Metafield
                InlineResponse2003 result = apiInstance.GetOrderMetafieldByOrderIdAndMetafieldId(orderId, metafieldId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetafieldsApi.GetOrderMetafieldByOrderIdAndMetafieldId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **int?**| The ID of the &#x60;Order&#x60; to which the transactions belong.  | 
 **metafieldId** | **int?**| The ID of the &#x60;Metafield&#x60;.  | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getordermetafieldsbyorderid"></a>
# **GetOrderMetafieldsByOrderId**
> InlineResponse2002 GetOrderMetafieldsByOrderId (int? orderId, int? page = null, int? limit = null, string key = null, string _namespace = null)

Get Metafields

Gets a `Metafield` object list, by `order_id`. 

### Example
```csharp
using System;
using System.Diagnostics;
using OrdersV3.Api;
using OrdersV3.Client;
using OrdersV3.Model;

namespace Example
{
    public class GetOrderMetafieldsByOrderIdExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new MetafieldsApi();
            var orderId = 56;  // int? | The ID of the `Order` to which the transactions belong. 
            var page = 56;  // int? | Specifies the page number in a limited (paginated) list of products.  (optional) 
            var limit = 56;  // int? | Controls the number of items per page in a limited (paginated) list of products.  (optional) 
            var key = key_example;  // string | Filter based on a metafield's key.  (optional) 
            var _namespace = _namespace_example;  // string | Filter based on a metafield's key.  (optional) 

            try
            {
                // Get Metafields
                InlineResponse2002 result = apiInstance.GetOrderMetafieldsByOrderId(orderId, page, limit, key, _namespace);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetafieldsApi.GetOrderMetafieldsByOrderId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **int?**| The ID of the &#x60;Order&#x60; to which the transactions belong.  | 
 **page** | **int?**| Specifies the page number in a limited (paginated) list of products.  | [optional] 
 **limit** | **int?**| Controls the number of items per page in a limited (paginated) list of products.  | [optional] 
 **key** | **string**| Filter based on a metafield&#x27;s key.  | [optional] 
 **_namespace** | **string**| Filter based on a metafield&#x27;s key.  | [optional] 

### Return type

[**InlineResponse2002**](InlineResponse2002.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateordermetafield"></a>
# **UpdateOrderMetafield**
> InlineResponse2003 UpdateOrderMetafield (Body1 body, int? orderId, int? metafieldId)

Update a Metafield

Updates a `Metafield` object.

### Example
```csharp
using System;
using System.Diagnostics;
using OrdersV3.Api;
using OrdersV3.Client;
using OrdersV3.Model;

namespace Example
{
    public class UpdateOrderMetafieldExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new MetafieldsApi();
            var body = new Body1(); // Body1 | A `Metafield` object.

            var orderId = 56;  // int? | The ID of the `Order` to which the transactions belong. 
            var metafieldId = 56;  // int? | The ID of the `Metafield`. 

            try
            {
                // Update a Metafield
                InlineResponse2003 result = apiInstance.UpdateOrderMetafield(body, orderId, metafieldId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling MetafieldsApi.UpdateOrderMetafield: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**Body1**](Body1.md)| A &#x60;Metafield&#x60; object.
 | 
 **orderId** | **int?**| The ID of the &#x60;Order&#x60; to which the transactions belong.  | 
 **metafieldId** | **int?**| The ID of the &#x60;Metafield&#x60;.  | 

### Return type

[**InlineResponse2003**](InlineResponse2003.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
