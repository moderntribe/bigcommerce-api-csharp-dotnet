# BigCommerce.Api.CartApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateACart**](CartApi.md#createacart) | **POST** /carts | Create a Cart
[**DeleteACart**](CartApi.md#deleteacart) | **DELETE** /carts/{cartId} | Delete a Cart
[**GetACart**](CartApi.md#getacart) | **GET** /carts/{cartId} | Get a Cart
[**UpdateACart**](CartApi.md#updateacart) | **PUT** /carts/{cartId} | Update Customer ID

<a name="createacart"></a>
# **CreateACart**
> CartFull1 CreateACart (CartCreatePostData body, string accept, string contentType, string include = null)

Create a Cart

Creates a **Cart**.   **Required Fields** |Field|Details| |-|-| |`line_items`||  |`custom_items`|Only required if adding a custom item to the cart.| |`gift_certificates`|Only required if adding a gift certificate to the cart.|  **Usage Notes**  * A **cart** `id` (UUID) is returned in the response. * A **cart** `id` is the same as a **checkout** `id`. * A cart can be created by adding an existing **catalog item** or a **custom item**. * Carts are valid for **30 days** from the **last modification** (this includes creating the cart or editing the cart). * If a product has modifiers, omit the `variant_id` and instead use the `option_selections` array to describe both the **variant** and the **modifier** selections. * Redirect URLs can only be generated from carts created using the **Server-to-Server Carts API**.  * To get cart `redirect_urls` in the response, append the following query parameter to the request URL: `include=redirect_urls`. * To restore a cart that was created by a shopper or via the Storefront Cart API, first recreate the cart using the Server to Server Cart API.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class CreateACartExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new CartApi();
            var body = new CartCreatePostData(); // CartCreatePostData | **Examples:**

1. Creating a cart by adding a simple product (a product without option selections).
2. Creating a cart with a variant. This works when a product can be specified purely by a variant, without any other required options.
3. Creating a cart with a variant, a checkbox, and a picklist modifier added.
4. Creating a cart using a custom item.
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var include = include_example;  // string | * `redirect_urls`: Create a direct link to a Cart. This can be used during the /POST request for Carts. * `line_items.physical_items.options`: The Cart returns an abbreviated result. Use this to return physical items product options. Can also be used in a /POST to have the extended Cart object return. * `line_items.digital_items.options`: The Cart returns an abbreviated result. Use this to return digital items product options.  Can also be used in a /POST to have the extended Cart object return. (optional) 

            try
            {
                // Create a Cart
                CartFull1 result = apiInstance.CreateACart(body, accept, contentType, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartApi.CreateACart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CartCreatePostData**](CartCreatePostData.md)| **Examples:**

1. Creating a cart by adding a simple product (a product without option selections).
2. Creating a cart with a variant. This works when a product can be specified purely by a variant, without any other required options.
3. Creating a cart with a variant, a checkbox, and a picklist modifier added.
4. Creating a cart using a custom item. | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **include** | **string**| * &#x60;redirect_urls&#x60;: Create a direct link to a Cart. This can be used during the /POST request for Carts. * &#x60;line_items.physical_items.options&#x60;: The Cart returns an abbreviated result. Use this to return physical items product options. Can also be used in a /POST to have the extended Cart object return. * &#x60;line_items.digital_items.options&#x60;: The Cart returns an abbreviated result. Use this to return digital items product options.  Can also be used in a /POST to have the extended Cart object return. | [optional] 

### Return type

[**CartFull1**](CartFull1.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="deleteacart"></a>
# **DeleteACart**
> void DeleteACart (string cartId, string accept, string contentType)

Delete a Cart

Deletes a *Cart*. Once a *Cart* has been deleted it can not be recovered.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class DeleteACartExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new CartApi();
            var cartId = cartId_example;  // string | This cart's unique ID.
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)

            try
            {
                // Delete a Cart
                apiInstance.DeleteACart(cartId, accept, contentType);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartApi.DeleteACart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartId** | **string**| This cart&#x27;s unique ID. | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]

### Return type

void (empty response body)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="getacart"></a>
# **GetACart**
> CartFull1 GetACart (string cartId, string accept, string contentType, string include = null)

Get a Cart

Returns a stores *Cart*.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class GetACartExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new CartApi();
            var cartId = cartId_example;  // string | The identifier of a specific cart.
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var include = include_example;  // string | * `redirect_urls`: Create a direct link to a Cart. This can be used during the /POST request for Carts. * `line_items.physical_items.options`: The Cart returns an abbreviated result. Use this to return physical items product options. Can also be used in a /POST to have the extended Cart object return. * `line_items.digital_items.options`: The Cart returns an abbreviated result. Use this to return digital items product options.  Can also be used in a /POST to have the extended Cart object return. (optional) 

            try
            {
                // Get a Cart
                CartFull1 result = apiInstance.GetACart(cartId, accept, contentType, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartApi.GetACart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartId** | **string**| The identifier of a specific cart. | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **include** | **string**| * &#x60;redirect_urls&#x60;: Create a direct link to a Cart. This can be used during the /POST request for Carts. * &#x60;line_items.physical_items.options&#x60;: The Cart returns an abbreviated result. Use this to return physical items product options. Can also be used in a /POST to have the extended Cart object return. * &#x60;line_items.digital_items.options&#x60;: The Cart returns an abbreviated result. Use this to return digital items product options.  Can also be used in a /POST to have the extended Cart object return. | [optional] 

### Return type

[**CartFull1**](CartFull1.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
<a name="updateacart"></a>
# **UpdateACart**
> CartFull1 UpdateACart (CartUpdatePutRequestData body, string accept, string contentType, string cartId, string include = null)

Update Customer ID

Updates a *Carts* `customer_id`.  **Notes**  Changing the *Cart* `customer_id` will remove any promotions or shipping on the *Cart*. These are tied to the customer depending on cart conditions and any customer groups. 

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class UpdateACartExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new CartApi();
            var body = new CartUpdatePutRequestData(); // CartUpdatePutRequestData | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var cartId = cartId_example;  // string | 
            var include = include_example;  // string | * `redirect_urls`: Create a direct link to a Cart. This can be used during the /POST request for Carts. * `line_items.physical_items.options`: The Cart returns an abbreviated result. Use this to return physical items product options. Can also be used in a /POST to have the extended Cart object return. * `line_items.digital_items.options`: The Cart returns an abbreviated result. Use this to return digital items product options.  Can also be used in a /POST to have the extended Cart object return. (optional) 

            try
            {
                // Update Customer ID
                CartFull1 result = apiInstance.UpdateACart(body, accept, contentType, cartId, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartApi.UpdateACart: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CartUpdatePutRequestData**](CartUpdatePutRequestData.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **cartId** | **string**|  | 
 **include** | **string**| * &#x60;redirect_urls&#x60;: Create a direct link to a Cart. This can be used during the /POST request for Carts. * &#x60;line_items.physical_items.options&#x60;: The Cart returns an abbreviated result. Use this to return physical items product options. Can also be used in a /POST to have the extended Cart object return. * &#x60;line_items.digital_items.options&#x60;: The Cart returns an abbreviated result. Use this to return digital items product options.  Can also be used in a /POST to have the extended Cart object return. | [optional] 

### Return type

[**CartFull1**](CartFull1.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
