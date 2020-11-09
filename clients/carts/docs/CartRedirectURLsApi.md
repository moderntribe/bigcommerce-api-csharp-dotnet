# Carts.Api.CartRedirectURLsApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateCartRedirectURL**](CartRedirectURLsApi.md#createcartredirecturl) | **POST** /carts/{cartId}/redirect_urls | Create Cart Redirect URL

<a name="createcartredirecturl"></a>
# **CreateCartRedirectURL**
> InlineResponse201 CreateCartRedirectURL (string cartId, string accept, string contentType)

Create Cart Redirect URL

Creates a **Cart** redirect URL for redirecting a shopper to an already created cart using the `cartId`.  **Usage Notes**  * Redirect URLs can also be created via **Create a Cart** requests by appending `include=redirect_urls`. * A **Carts** redirect URLs may only be used once.  * Once a redirect URL has been visited, it will be invalidated and cannot be used again.  * If your application requires URLs to be visited more than once, consider generating a fresh one each time you need to restore a cart, and redirecting to the URL from your own application. * Redirect URLs can be generated only from carts created using the Server to Server Cart API.  * To restore a cart that was created on the storefront, either by a shopper or the Storefront Cart API, first recreate the cart using the Server to Server Cart API.

### Example
```csharp
using System;
using System.Diagnostics;
using Carts.Api;
using Carts.Client;
using Carts.Model;

namespace Example
{
    public class CreateCartRedirectURLExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new CartRedirectURLsApi();
            var cartId = cartId_example;  // string | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)

            try
            {
                // Create Cart Redirect URL
                InlineResponse201 result = apiInstance.CreateCartRedirectURL(cartId, accept, contentType);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartRedirectURLsApi.CreateCartRedirectURL: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartId** | **string**|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]

### Return type

[**InlineResponse201**](InlineResponse201.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
