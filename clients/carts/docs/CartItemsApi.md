# BigCommerce.Api.CartItemsApi

All URIs are relative to *https://api.bigcommerce.com/stores/{$$.env.store_hash}/v3*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddCartLineItem**](CartItemsApi.md#addcartlineitem) | **POST** /carts/{cartId}/items | Add Cart Line Items
[**DeleteCartLineItem**](CartItemsApi.md#deletecartlineitem) | **DELETE** /carts/{cartId}/items/{itemId} | Delete Cart Line Item
[**UpdateCartLineItem**](CartItemsApi.md#updatecartlineitem) | **PUT** /carts/{cartId}/items/{itemId} | Update Cart Line Item

<a name="addcartlineitem"></a>
# **AddCartLineItem**
> CartFull1 AddCartLineItem (CartLineItemUpdatePost1 body, string accept, string contentType, string cartId, string include = null)

Add Cart Line Items

Adds line items to the *Cart*.  **Usage Notes**  To add a custom item use `custom_items`.   If a product has modifiers, omit the `variant_id` and instead use the `option_selections` array to describe both the **variant** and the **modifier** selections.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class AddCartLineItemExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new CartItemsApi();
            var body = new CartLineItemUpdatePost1(); // CartLineItemUpdatePost1 | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var cartId = cartId_example;  // string | 
            var include = include_example;  // string | * `redirect_urls`: Create a direct link to a Cart. This can be used during the /POST request for Carts. * `line_items.physical_items.options`: The Cart returns an abbreviated result. Use this to return physical items product options. Can also be used in a /POST to have the extended Cart object return. * `line_items.digital_items.options`: The Cart returns an abbreviated result. Use this to return digital items product options.  Can also be used in a /POST to have the extended Cart object return. (optional) 

            try
            {
                // Add Cart Line Items
                CartFull1 result = apiInstance.AddCartLineItem(body, accept, contentType, cartId, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartItemsApi.AddCartLineItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CartLineItemUpdatePost1**](CartLineItemUpdatePost1.md)|  | 
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
<a name="deletecartlineitem"></a>
# **DeleteCartLineItem**
> CartFull1 DeleteCartLineItem (string cartId, decimal? itemId, string accept, string contentType, string include = null)

Delete Cart Line Item

Deletes a *Cart* line item.   **Notes**  Removing the last `line_item` in the *Cart* deletes the *Cart*.

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class DeleteCartLineItemExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new CartItemsApi();
            var cartId = cartId_example;  // string | 
            var itemId = itemId_example;  // decimal? | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var include = include_example;  // string | * `redirect_urls`: Create a direct link to a Cart. This can be used during the /POST request for Carts. * `line_items.physical_items.options`: The Cart returns an abbreviated result. Use this to return physical items product options. Can also be used in a /POST to have the extended Cart object return. * `line_items.digital_items.options`: The Cart returns an abbreviated result. Use this to return digital items product options.  Can also be used in a /POST to have the extended Cart object return. (optional) 

            try
            {
                // Delete Cart Line Item
                CartFull1 result = apiInstance.DeleteCartLineItem(cartId, itemId, accept, contentType, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartItemsApi.DeleteCartLineItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **cartId** | **string**|  | 
 **itemId** | **decimal?**|  | 
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
<a name="updatecartlineitem"></a>
# **UpdateCartLineItem**
> CartFull1 UpdateCartLineItem (CartLineItemUpdatePost2 body, string accept, string contentType, string cartId, decimal? itemId, string include = null)

Update Cart Line Item

Updates an existing, single line item in the *Cart*.   **Notes**  Currently, only updating `list_price` and `quantity` are supported. Updating a product's `list_price` will make that item ineligible for V3 product level promotions.   If the product has modifiers, omit the `variant_id` and instead use the `option_selections` array to describe both the **variant** and the **modifier** selections.  If a variant needs to be changed or updated, the product will need to be removed and re-added to the cart with the correct variants using the Add Cart Line Items endpoint.  `custom_items` cannot be updated via the API at this time. To update your cart, add a new updated custom item and delete the outdated one. If your cart contains only one line item, perform the add operation before the delete operation.  Deleting all line items from the cart will invalidate the cart. 

### Example
```csharp
using System;
using System.Diagnostics;
using BigCommerce.Api;
using BigCommerce.Client;
using BigCommerce.Model;

namespace Example
{
    public class UpdateCartLineItemExample
    {
        public void main()
        {
            // Configure API key authorization: X-Auth-Token
            Configuration.Default.AddApiKey("X-Auth-Token", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("X-Auth-Token", "Bearer");

            var apiInstance = new CartItemsApi();
            var body = new CartLineItemUpdatePost2(); // CartLineItemUpdatePost2 | 
            var accept = accept_example;  // string |  (default to application/json)
            var contentType = contentType_example;  // string |  (default to application/json)
            var cartId = cartId_example;  // string | 
            var itemId = itemId_example;  // decimal? | 
            var include = include_example;  // string | * `redirect_urls`: Create a direct link to a Cart. This can be used during the /POST request for Carts. * `line_items.physical_items.options`: The Cart returns an abbreviated result. Use this to return physical items product options. Can also be used in a /POST to have the extended Cart object return. * `line_items.digital_items.options`: The Cart returns an abbreviated result. Use this to return digital items product options.  Can also be used in a /POST to have the extended Cart object return. (optional) 

            try
            {
                // Update Cart Line Item
                CartFull1 result = apiInstance.UpdateCartLineItem(body, accept, contentType, cartId, itemId, include);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CartItemsApi.UpdateCartLineItem: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **body** | [**CartLineItemUpdatePost2**](CartLineItemUpdatePost2.md)|  | 
 **accept** | **string**|  | [default to application/json]
 **contentType** | **string**|  | [default to application/json]
 **cartId** | **string**|  | 
 **itemId** | **decimal?**|  | 
 **include** | **string**| * &#x60;redirect_urls&#x60;: Create a direct link to a Cart. This can be used during the /POST request for Carts. * &#x60;line_items.physical_items.options&#x60;: The Cart returns an abbreviated result. Use this to return physical items product options. Can also be used in a /POST to have the extended Cart object return. * &#x60;line_items.digital_items.options&#x60;: The Cart returns an abbreviated result. Use this to return digital items product options.  Can also be used in a /POST to have the extended Cart object return. | [optional] 

### Return type

[**CartFull1**](CartFull1.md)

### Authorization

[X-Auth-Token](../README.md#X-Auth-Token)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)
