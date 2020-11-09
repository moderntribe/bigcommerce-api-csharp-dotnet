# OrdersV3.Api.TransactionsApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTransactions**](TransactionsApi.md#gettransactions) | **GET** /orders/{order_id}/transactions | Get Transactions

<a name="gettransactions"></a>
# **GetTransactions**
> InlineResponse200 GetTransactions (int? orderId, string accept = null, string contentType = null)

Get Transactions

Returns an **order's** transactions.   **Usage Notes** * Depending on the payment method, different information will be available (not all payment gateways return full card or fraud detail). * Transactions are not created for the following payment methods:  * Test Payment Gateway  * PayPal Express  * Amazon Pay

### Example
```csharp
using System;
using System.Diagnostics;
using OrdersV3.Api;
using OrdersV3.Client;
using OrdersV3.Model;

namespace Example
{
    public class GetTransactionsExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new TransactionsApi();
            var orderId = 56;  // int? | The ID of the `Order` to which the transactions belong. 
            var accept = accept_example;  // string |  (optional)  (default to application/json)
            var contentType = contentType_example;  // string |  (optional)  (default to application/json)

            try
            {
                // Get Transactions
                InlineResponse200 result = apiInstance.GetTransactions(orderId, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling TransactionsApi.GetTransactions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **orderId** | **int?**| The ID of the &#x60;Order&#x60; to which the transactions belong.  | 
 **accept** | **string**|  | [optional] [default to application/json]
 **contentType** | **string**|  | [optional] [default to application/json]

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
