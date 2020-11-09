# OrdersV3.Api.OrderRefundsApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Getorderrefunds**](OrderRefundsApi.md#getorderrefunds) | **GET** /orders/{order_id}/payment_actions/refunds | Get Refunds for Order
[**Postrefund**](OrderRefundsApi.md#postrefund) | **POST** /orders/{order_id}/payment_actions/refunds | Create a Refund
[**Postrefundquote**](OrderRefundsApi.md#postrefundquote) | **POST** /orders/{order_id}/payment_actions/refund_quotes | Create a Refund Quote

<a name="getorderrefunds"></a>
# **Getorderrefunds**
> InlineResponse2001 Getorderrefunds (string orderId, string accept = null, string contentType = null)

Get Refunds for Order

Returns a list of refunds ordered by refund ID in ascending order for the given order.

### Example
```csharp
using System;
using System.Diagnostics;
using OrdersV3.Api;
using OrdersV3.Client;
using OrdersV3.Model;

namespace Example
{
    public class GetorderrefundsExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new OrderRefundsApi();
            var orderId = orderId_example;  // string | 
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Get Refunds for Order
                InlineResponse2001 result = apiInstance.Getorderrefunds(orderId, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderRefundsApi.Getorderrefunds: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **string**|  | 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

[**InlineResponse2001**](InlineResponse2001.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postrefund"></a>
# **Postrefund**
> InlineResponse2011 Postrefund (RefundRequestPost1 body, int? orderId, string accept = null, string contentType = null)

Create a Refund

Creates a refund.

### Example
```csharp
using System;
using System.Diagnostics;
using OrdersV3.Api;
using OrdersV3.Client;
using OrdersV3.Model;

namespace Example
{
    public class PostrefundExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new OrderRefundsApi();
            var body = new RefundRequestPost1(); // RefundRequestPost1 | 
            var orderId = 56;  // int? | order id
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Create a Refund
                InlineResponse2011 result = apiInstance.Postrefund(body, orderId, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderRefundsApi.Postrefund: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RefundRequestPost1**](RefundRequestPost1.md)|  | 
 **orderId** | **int?**| order id | 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

[**InlineResponse2011**](InlineResponse2011.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="postrefundquote"></a>
# **Postrefundquote**
> InlineResponse201 Postrefundquote (RefundQuotePost1 body, int? orderId, string accept = null, string contentType = null)

Create a Refund Quote

Calculate the tax amount, total refund amount and get availble payment options for an order refund by providing items and costs or quantities to refund.

### Example
```csharp
using System;
using System.Diagnostics;
using OrdersV3.Api;
using OrdersV3.Client;
using OrdersV3.Model;

namespace Example
{
    public class PostrefundquoteExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new OrderRefundsApi();
            var body = new RefundQuotePost1(); // RefundQuotePost1 | 
            var orderId = 56;  // int? | Order id
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Create a Refund Quote
                InlineResponse201 result = apiInstance.Postrefundquote(body, orderId, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrderRefundsApi.Postrefundquote: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**RefundQuotePost1**](RefundQuotePost1.md)|  | 
 **orderId** | **int?**| Order id | 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
