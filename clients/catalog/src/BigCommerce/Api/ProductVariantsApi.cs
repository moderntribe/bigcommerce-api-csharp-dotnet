/* 
 * Catalog
 *
 * Manage products, brands and categories. To learn more about catalog resources see [Catalog Overview](https://developer.bigcommerce.com/api-docs/catalog/products-overview).  - [Authentication](#authentication) - [Differentiating Variants & Modifiers](#variants-and-modifiers) - [Available Endpoints](#available-endpoints) - [Resources](#resources)  ## Authentication Requests can be authenticated by sending an `access_token` via `X-Auth-Token` HTTP header:  ```http GET /stores/{$$.env.store_hash}/v3/catalog/summary host: api.bigcommerce.com Accept: application/json X-Auth-Token: {access_token} ```  |Header|Parameter|Description| |-|-|-| |`X-Auth-Token`|`access_token `|Obtained by creating an API account or installing an app in a BigCommerce control panel.|  ### OAuth Scopes | UI Name  | Permission | Parameter                     | |- -- -- -- -- -|- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | Products | modify     | `store_v2_products`           | | Products | read-only  | `store_v2_products_read_only` |  For more information on OAuth Scopes, see: [Authentication](https://developer.bigcommerce.com/api-docs/getting-started/authentication).  For more information on Authenticating BigCommerce APIs, see: [Authentication](https://developer.bigcommerce.com/api-docs/getting-started/authentication).  ## Differentiating Variants and Modifiers [Variants](https://support.bigcommerce.com/s/article/Product-Options-v3#variations) represent a physical product made up of [Product Option](https://support.bigcommerce.com/s/article/Product-Options-v3) choices, i.e. a large blue t-shirt. Each variant can have a unique SKU.  Modifiers represent a choice a customer makes about a product that doesn't represent a physical item, i.e. text to be printed on a t-shirt. Assigning a SKU to a modifier will turn it into a variant.  See [Variant Options](https://developer.bigcommerce.com/api-docs/catalog/products-overview#variant-options) and [Modifier Options](https://developer.bigcommerce.com/api-docs/catalog/products-overview#modifier-options) for more information.  ## Available Endpoints | Resource / Endpoint                     | Description                                                             | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | Brand Images                            | Create and manage brand images                                          | | Brand Metafields                        | Create and manage brand metafields                                      | | Brands                                  | Create and manage brands                                                | | Catalog                                 | Create and manage store categories, products, and brands                | | Categories                              | Create and manage categorties                                           | | Category Images                         | Create and manage category images                                       | | Category Metafields                     | Create and manage category metafields                                   | | Product Bulk Pricing Rules              | Create and manage product bulk pricing rules                            | | Product Complex Rules                   | Create and manage product complex rules                                 | | Product Custom Fields                   | Create and manage product custom fields                                 | | Product Images                          | Create and manage product images                                        | | Product Metafields                      | Create and manage product meta fields                                   | | Product Modifier Images                 | Create and manage product modifer images                                | | Product Modifier Values                 | Create and manage product modifier values                               | | Product Modifiers                       | Create and manage product midifiers                                     | | Product Reviews                         | Create and manage product reviews                                       | | Product Variant Option Values           | Create and manage product variant option values                         | | Product Variant Options                 | Create and manage product variant options                               | | Product Variants                        | Create and manage product variants                                      | | Product Videos                          | Create and manage product videos                                        | | Products                                | Create and manage products                                              | | ProductVariant Metafields               | Create and manage product meta flields                                  | | Variants                                | Get and update all variants                                             |  ## Resources  ### Webhooks * [Products](/api-docs/getting-started/webhooks/webhook-events#webhook-events_products) * [Categories](/api-docs/getting-started/webhooks/webhook-events#webhook-events_category) * [SKU](/api-docs/getting-started/webhooks/webhook-events#webhook-events_sku)  ### Related Endpoints * [Catalog API](/api-reference/catalog/catalog-api)
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using BigCommerce.Client;
using BigCommerce.Model;

namespace BigCommerce.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IProductVariantsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a Product Variant
        /// </summary>
        /// <remarks>
        /// Creates a *Product Variant*.   **Required Fields** * sku * option_values  **Read-Only Fields** * id  Variants need to be created one at a time using this endpoint. To use a variant array and create products and variants in the same call use the [Create Products](/api-reference/catalog/catalog-api/products/createproduct) during the initial product creation.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>VariantResponse</returns>
        VariantResponse CreateVariant (VariantPost body, int? productId);

        /// <summary>
        /// Create a Product Variant
        /// </summary>
        /// <remarks>
        /// Creates a *Product Variant*.   **Required Fields** * sku * option_values  **Read-Only Fields** * id  Variants need to be created one at a time using this endpoint. To use a variant array and create products and variants in the same call use the [Create Products](/api-reference/catalog/catalog-api/products/createproduct) during the initial product creation.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>ApiResponse of VariantResponse</returns>
        ApiResponse<VariantResponse> CreateVariantWithHttpInfo (VariantPost body, int? productId);
        /// <summary>
        /// Create a Variant Image
        /// </summary>
        /// <remarks>
        /// Creates a *Variant Image*.  The image will show on the storefront when the value is selected.   **Required Fields** - image_file: Form posts. Files larger than 1 MB are not accepted - image_url: Any publicly available URL
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="body"> (optional)</param>
        /// <returns>ImageResponse</returns>
        ImageResponse CreateVariantImage (int? productId, int? variantId, ResourceImage body = null);

        /// <summary>
        /// Create a Variant Image
        /// </summary>
        /// <remarks>
        /// Creates a *Variant Image*.  The image will show on the storefront when the value is selected.   **Required Fields** - image_file: Form posts. Files larger than 1 MB are not accepted - image_url: Any publicly available URL
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ImageResponse</returns>
        ApiResponse<ImageResponse> CreateVariantImageWithHttpInfo (int? productId, int? variantId, ResourceImage body = null);
        /// <summary>
        /// Create a Variant Image
        /// </summary>
        /// <remarks>
        /// Creates a *Variant Image*.  The image will show on the storefront when the value is selected.   **Required Fields** - image_file: Form posts. Files larger than 1 MB are not accepted - image_url: Any publicly available URL
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="body"> (optional)</param>
        /// <returns>ImageResponse</returns>
        ImageResponse CreateVariantImage (int? productId, int? variantId, ResourceImage body = null);

        /// <summary>
        /// Create a Variant Image
        /// </summary>
        /// <remarks>
        /// Creates a *Variant Image*.  The image will show on the storefront when the value is selected.   **Required Fields** - image_file: Form posts. Files larger than 1 MB are not accepted - image_url: Any publicly available URL
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ImageResponse</returns>
        ApiResponse<ImageResponse> CreateVariantImageWithHttpInfo (int? productId, int? variantId, ResourceImage body = null);
        /// <summary>
        /// Delete a Product Variant
        /// </summary>
        /// <remarks>
        /// Deletes a product *Variant*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void DeleteVariantById (int? productId, int? variantId, string accept, string contentType);

        /// <summary>
        /// Delete a Product Variant
        /// </summary>
        /// <remarks>
        /// Deletes a product *Variant*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteVariantByIdWithHttpInfo (int? productId, int? variantId, string accept, string contentType);
        /// <summary>
        /// Get a Product Variant
        /// </summary>
        /// <remarks>
        /// Returns a single product *Variant*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>VariantResponse1</returns>
        VariantResponse1 GetVariantById (int? productId, int? variantId, string accept, string contentType, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get a Product Variant
        /// </summary>
        /// <remarks>
        /// Returns a single product *Variant*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of VariantResponse1</returns>
        ApiResponse<VariantResponse1> GetVariantByIdWithHttpInfo (int? productId, int? variantId, string accept, string contentType, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Get All Product Variants
        /// </summary>
        /// <remarks>
        /// Returns a list of product *Variants*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>VariantCollectionResponse</returns>
        VariantCollectionResponse GetVariantsByProductId (int? productId, string accept, string contentType, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get All Product Variants
        /// </summary>
        /// <remarks>
        /// Returns a list of product *Variants*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of VariantCollectionResponse</returns>
        ApiResponse<VariantCollectionResponse> GetVariantsByProductIdWithHttpInfo (int? productId, string accept, string contentType, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Update a Product Variant
        /// </summary>
        /// <remarks>
        /// Updates a product *Variant*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <returns>VariantResponse1</returns>
        VariantResponse1 UpdateVariant (ProductVariantPut1 body, string accept, string contentType, int? productId, int? variantId);

        /// <summary>
        /// Update a Product Variant
        /// </summary>
        /// <remarks>
        /// Updates a product *Variant*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <returns>ApiResponse of VariantResponse1</returns>
        ApiResponse<VariantResponse1> UpdateVariantWithHttpInfo (ProductVariantPut1 body, string accept, string contentType, int? productId, int? variantId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create a Product Variant
        /// </summary>
        /// <remarks>
        /// Creates a *Product Variant*.   **Required Fields** * sku * option_values  **Read-Only Fields** * id  Variants need to be created one at a time using this endpoint. To use a variant array and create products and variants in the same call use the [Create Products](/api-reference/catalog/catalog-api/products/createproduct) during the initial product creation.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>Task of VariantResponse</returns>
        System.Threading.Tasks.Task<VariantResponse> CreateVariantAsync (VariantPost body, int? productId);

        /// <summary>
        /// Create a Product Variant
        /// </summary>
        /// <remarks>
        /// Creates a *Product Variant*.   **Required Fields** * sku * option_values  **Read-Only Fields** * id  Variants need to be created one at a time using this endpoint. To use a variant array and create products and variants in the same call use the [Create Products](/api-reference/catalog/catalog-api/products/createproduct) during the initial product creation.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>Task of ApiResponse (VariantResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<VariantResponse>> CreateVariantAsyncWithHttpInfo (VariantPost body, int? productId);
        /// <summary>
        /// Create a Variant Image
        /// </summary>
        /// <remarks>
        /// Creates a *Variant Image*.  The image will show on the storefront when the value is selected.   **Required Fields** - image_file: Form posts. Files larger than 1 MB are not accepted - image_url: Any publicly available URL
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ImageResponse</returns>
        System.Threading.Tasks.Task<ImageResponse> CreateVariantImageAsync (int? productId, int? variantId, ResourceImage body = null);

        /// <summary>
        /// Create a Variant Image
        /// </summary>
        /// <remarks>
        /// Creates a *Variant Image*.  The image will show on the storefront when the value is selected.   **Required Fields** - image_file: Form posts. Files larger than 1 MB are not accepted - image_url: Any publicly available URL
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ImageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageResponse>> CreateVariantImageAsyncWithHttpInfo (int? productId, int? variantId, ResourceImage body = null);
        /// <summary>
        /// Create a Variant Image
        /// </summary>
        /// <remarks>
        /// Creates a *Variant Image*.  The image will show on the storefront when the value is selected.   **Required Fields** - image_file: Form posts. Files larger than 1 MB are not accepted - image_url: Any publicly available URL
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ImageResponse</returns>
        System.Threading.Tasks.Task<ImageResponse> CreateVariantImageAsync (int? productId, int? variantId, ResourceImage body = null);

        /// <summary>
        /// Create a Variant Image
        /// </summary>
        /// <remarks>
        /// Creates a *Variant Image*.  The image will show on the storefront when the value is selected.   **Required Fields** - image_file: Form posts. Files larger than 1 MB are not accepted - image_url: Any publicly available URL
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ImageResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ImageResponse>> CreateVariantImageAsyncWithHttpInfo (int? productId, int? variantId, ResourceImage body = null);
        /// <summary>
        /// Delete a Product Variant
        /// </summary>
        /// <remarks>
        /// Deletes a product *Variant*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteVariantByIdAsync (int? productId, int? variantId, string accept, string contentType);

        /// <summary>
        /// Delete a Product Variant
        /// </summary>
        /// <remarks>
        /// Deletes a product *Variant*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteVariantByIdAsyncWithHttpInfo (int? productId, int? variantId, string accept, string contentType);
        /// <summary>
        /// Get a Product Variant
        /// </summary>
        /// <remarks>
        /// Returns a single product *Variant*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of VariantResponse1</returns>
        System.Threading.Tasks.Task<VariantResponse1> GetVariantByIdAsync (int? productId, int? variantId, string accept, string contentType, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get a Product Variant
        /// </summary>
        /// <remarks>
        /// Returns a single product *Variant*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (VariantResponse1)</returns>
        System.Threading.Tasks.Task<ApiResponse<VariantResponse1>> GetVariantByIdAsyncWithHttpInfo (int? productId, int? variantId, string accept, string contentType, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Get All Product Variants
        /// </summary>
        /// <remarks>
        /// Returns a list of product *Variants*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of VariantCollectionResponse</returns>
        System.Threading.Tasks.Task<VariantCollectionResponse> GetVariantsByProductIdAsync (int? productId, string accept, string contentType, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get All Product Variants
        /// </summary>
        /// <remarks>
        /// Returns a list of product *Variants*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (VariantCollectionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<VariantCollectionResponse>> GetVariantsByProductIdAsyncWithHttpInfo (int? productId, string accept, string contentType, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Update a Product Variant
        /// </summary>
        /// <remarks>
        /// Updates a product *Variant*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <returns>Task of VariantResponse1</returns>
        System.Threading.Tasks.Task<VariantResponse1> UpdateVariantAsync (ProductVariantPut1 body, string accept, string contentType, int? productId, int? variantId);

        /// <summary>
        /// Update a Product Variant
        /// </summary>
        /// <remarks>
        /// Updates a product *Variant*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <returns>Task of ApiResponse (VariantResponse1)</returns>
        System.Threading.Tasks.Task<ApiResponse<VariantResponse1>> UpdateVariantAsyncWithHttpInfo (ProductVariantPut1 body, string accept, string contentType, int? productId, int? variantId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class ProductVariantsApi : IProductVariantsApi
    {
        private BigCommerce.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductVariantsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductVariantsApi(String basePath)
        {
            this.Configuration = new BigCommerce.Client.Configuration { BasePath = basePath };

            ExceptionFactory = BigCommerce.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductVariantsApi"/> class
        /// </summary>
        /// <returns></returns>
        public ProductVariantsApi()
        {
            this.Configuration = BigCommerce.Client.Configuration.Default;

            ExceptionFactory = BigCommerce.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductVariantsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProductVariantsApi(BigCommerce.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = BigCommerce.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = BigCommerce.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public BigCommerce.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public BigCommerce.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Create a Product Variant Creates a *Product Variant*.   **Required Fields** * sku * option_values  **Read-Only Fields** * id  Variants need to be created one at a time using this endpoint. To use a variant array and create products and variants in the same call use the [Create Products](/api-reference/catalog/catalog-api/products/createproduct) during the initial product creation.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>VariantResponse</returns>
        public VariantResponse CreateVariant (VariantPost body, int? productId)
        {
             ApiResponse<VariantResponse> localVarResponse = CreateVariantWithHttpInfo(body, productId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Product Variant Creates a *Product Variant*.   **Required Fields** * sku * option_values  **Read-Only Fields** * id  Variants need to be created one at a time using this endpoint. To use a variant array and create products and variants in the same call use the [Create Products](/api-reference/catalog/catalog-api/products/createproduct) during the initial product creation.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>ApiResponse of VariantResponse</returns>
        public ApiResponse< VariantResponse > CreateVariantWithHttpInfo (VariantPost body, int? productId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductVariantsApi->CreateVariant");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVariantsApi->CreateVariant");

            var localVarPath = "/catalog/products/{product_id}/variants";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (productId != null) localVarPathParams.Add("product_id", this.Configuration.ApiClient.ParameterToString(productId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            // authentication (X-Auth-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Auth-Token")))
            {
                localVarHeaderParams["X-Auth-Token"] = this.Configuration.GetApiKeyWithPrefix("X-Auth-Token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateVariant", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VariantResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (VariantResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VariantResponse)));
        }

        /// <summary>
        /// Create a Product Variant Creates a *Product Variant*.   **Required Fields** * sku * option_values  **Read-Only Fields** * id  Variants need to be created one at a time using this endpoint. To use a variant array and create products and variants in the same call use the [Create Products](/api-reference/catalog/catalog-api/products/createproduct) during the initial product creation.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>Task of VariantResponse</returns>
        public async System.Threading.Tasks.Task<VariantResponse> CreateVariantAsync (VariantPost body, int? productId)
        {
             ApiResponse<VariantResponse> localVarResponse = await CreateVariantAsyncWithHttpInfo(body, productId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Product Variant Creates a *Product Variant*.   **Required Fields** * sku * option_values  **Read-Only Fields** * id  Variants need to be created one at a time using this endpoint. To use a variant array and create products and variants in the same call use the [Create Products](/api-reference/catalog/catalog-api/products/createproduct) during the initial product creation.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>Task of ApiResponse (VariantResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VariantResponse>> CreateVariantAsyncWithHttpInfo (VariantPost body, int? productId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductVariantsApi->CreateVariant");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVariantsApi->CreateVariant");

            var localVarPath = "/catalog/products/{product_id}/variants";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (productId != null) localVarPathParams.Add("product_id", this.Configuration.ApiClient.ParameterToString(productId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            // authentication (X-Auth-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Auth-Token")))
            {
                localVarHeaderParams["X-Auth-Token"] = this.Configuration.GetApiKeyWithPrefix("X-Auth-Token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateVariant", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VariantResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (VariantResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VariantResponse)));
        }

        /// <summary>
        /// Create a Variant Image Creates a *Variant Image*.  The image will show on the storefront when the value is selected.   **Required Fields** - image_file: Form posts. Files larger than 1 MB are not accepted - image_url: Any publicly available URL
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="body"> (optional)</param>
        /// <returns>ImageResponse</returns>
        public ImageResponse CreateVariantImage (int? productId, int? variantId, ResourceImage body = null)
        {
             ApiResponse<ImageResponse> localVarResponse = CreateVariantImageWithHttpInfo(productId, variantId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Variant Image Creates a *Variant Image*.  The image will show on the storefront when the value is selected.   **Required Fields** - image_file: Form posts. Files larger than 1 MB are not accepted - image_url: Any publicly available URL
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ImageResponse</returns>
        public ApiResponse< ImageResponse > CreateVariantImageWithHttpInfo (int? productId, int? variantId, ResourceImage body = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVariantsApi->CreateVariantImage");
            // verify the required parameter 'variantId' is set
            if (variantId == null)
                throw new ApiException(400, "Missing required parameter 'variantId' when calling ProductVariantsApi->CreateVariantImage");

            var localVarPath = "/catalog/products/{product_id}/variants/{variant_id}/image";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "multipart/form-data"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (productId != null) localVarPathParams.Add("product_id", this.Configuration.ApiClient.ParameterToString(productId)); // path parameter
            if (variantId != null) localVarPathParams.Add("variant_id", this.Configuration.ApiClient.ParameterToString(variantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            // authentication (X-Auth-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Auth-Token")))
            {
                localVarHeaderParams["X-Auth-Token"] = this.Configuration.GetApiKeyWithPrefix("X-Auth-Token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateVariantImage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageResponse)));
        }

        /// <summary>
        /// Create a Variant Image Creates a *Variant Image*.  The image will show on the storefront when the value is selected.   **Required Fields** - image_file: Form posts. Files larger than 1 MB are not accepted - image_url: Any publicly available URL
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ImageResponse</returns>
        public async System.Threading.Tasks.Task<ImageResponse> CreateVariantImageAsync (int? productId, int? variantId, ResourceImage body = null)
        {
             ApiResponse<ImageResponse> localVarResponse = await CreateVariantImageAsyncWithHttpInfo(productId, variantId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Variant Image Creates a *Variant Image*.  The image will show on the storefront when the value is selected.   **Required Fields** - image_file: Form posts. Files larger than 1 MB are not accepted - image_url: Any publicly available URL
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ImageResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageResponse>> CreateVariantImageAsyncWithHttpInfo (int? productId, int? variantId, ResourceImage body = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVariantsApi->CreateVariantImage");
            // verify the required parameter 'variantId' is set
            if (variantId == null)
                throw new ApiException(400, "Missing required parameter 'variantId' when calling ProductVariantsApi->CreateVariantImage");

            var localVarPath = "/catalog/products/{product_id}/variants/{variant_id}/image";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "multipart/form-data"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (productId != null) localVarPathParams.Add("product_id", this.Configuration.ApiClient.ParameterToString(productId)); // path parameter
            if (variantId != null) localVarPathParams.Add("variant_id", this.Configuration.ApiClient.ParameterToString(variantId)); // path parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            // authentication (X-Auth-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Auth-Token")))
            {
                localVarHeaderParams["X-Auth-Token"] = this.Configuration.GetApiKeyWithPrefix("X-Auth-Token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateVariantImage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageResponse)));
        }

        /// <summary>
        /// Create a Variant Image Creates a *Variant Image*.  The image will show on the storefront when the value is selected.   **Required Fields** - image_file: Form posts. Files larger than 1 MB are not accepted - image_url: Any publicly available URL
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="body"> (optional)</param>
        /// <returns>ImageResponse</returns>
        public ImageResponse CreateVariantImage (int? productId, int? variantId, ResourceImage body = null)
        {
             ApiResponse<ImageResponse> localVarResponse = CreateVariantImageWithHttpInfo(productId, variantId, body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Variant Image Creates a *Variant Image*.  The image will show on the storefront when the value is selected.   **Required Fields** - image_file: Form posts. Files larger than 1 MB are not accepted - image_url: Any publicly available URL
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="body"> (optional)</param>
        /// <returns>ApiResponse of ImageResponse</returns>
        public ApiResponse< ImageResponse > CreateVariantImageWithHttpInfo (int? productId, int? variantId, ResourceImage body = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVariantsApi->CreateVariantImage");
            // verify the required parameter 'variantId' is set
            if (variantId == null)
                throw new ApiException(400, "Missing required parameter 'variantId' when calling ProductVariantsApi->CreateVariantImage");

            var localVarPath = "/catalog/products/{product_id}/variants/{variant_id}/image";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "multipart/form-data"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (productId != null) localVarPathParams.Add("product_id", this.Configuration.ApiClient.ParameterToString(productId)); // path parameter
            if (variantId != null) localVarPathParams.Add("variant_id", this.Configuration.ApiClient.ParameterToString(variantId)); // path parameter
            if (imageUrl != null) localVarFormParams.Add("image_url", this.Configuration.ApiClient.ParameterToString(imageUrl)); // form parameter
            // authentication (X-Auth-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Auth-Token")))
            {
                localVarHeaderParams["X-Auth-Token"] = this.Configuration.GetApiKeyWithPrefix("X-Auth-Token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateVariantImage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageResponse)));
        }

        /// <summary>
        /// Create a Variant Image Creates a *Variant Image*.  The image will show on the storefront when the value is selected.   **Required Fields** - image_file: Form posts. Files larger than 1 MB are not accepted - image_url: Any publicly available URL
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ImageResponse</returns>
        public async System.Threading.Tasks.Task<ImageResponse> CreateVariantImageAsync (int? productId, int? variantId, ResourceImage body = null)
        {
             ApiResponse<ImageResponse> localVarResponse = await CreateVariantImageAsyncWithHttpInfo(productId, variantId, body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Variant Image Creates a *Variant Image*.  The image will show on the storefront when the value is selected.   **Required Fields** - image_file: Form posts. Files larger than 1 MB are not accepted - image_url: Any publicly available URL
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="body"> (optional)</param>
        /// <returns>Task of ApiResponse (ImageResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ImageResponse>> CreateVariantImageAsyncWithHttpInfo (int? productId, int? variantId, ResourceImage body = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVariantsApi->CreateVariantImage");
            // verify the required parameter 'variantId' is set
            if (variantId == null)
                throw new ApiException(400, "Missing required parameter 'variantId' when calling ProductVariantsApi->CreateVariantImage");

            var localVarPath = "/catalog/products/{product_id}/variants/{variant_id}/image";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "multipart/form-data"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (productId != null) localVarPathParams.Add("product_id", this.Configuration.ApiClient.ParameterToString(productId)); // path parameter
            if (variantId != null) localVarPathParams.Add("variant_id", this.Configuration.ApiClient.ParameterToString(variantId)); // path parameter
            if (imageUrl != null) localVarFormParams.Add("image_url", this.Configuration.ApiClient.ParameterToString(imageUrl)); // form parameter
            // authentication (X-Auth-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Auth-Token")))
            {
                localVarHeaderParams["X-Auth-Token"] = this.Configuration.GetApiKeyWithPrefix("X-Auth-Token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateVariantImage", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ImageResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ImageResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ImageResponse)));
        }

        /// <summary>
        /// Delete a Product Variant Deletes a product *Variant*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public void DeleteVariantById (int? productId, int? variantId, string accept, string contentType)
        {
             DeleteVariantByIdWithHttpInfo(productId, variantId, accept, contentType);
        }

        /// <summary>
        /// Delete a Product Variant Deletes a product *Variant*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteVariantByIdWithHttpInfo (int? productId, int? variantId, string accept, string contentType)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVariantsApi->DeleteVariantById");
            // verify the required parameter 'variantId' is set
            if (variantId == null)
                throw new ApiException(400, "Missing required parameter 'variantId' when calling ProductVariantsApi->DeleteVariantById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductVariantsApi->DeleteVariantById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductVariantsApi->DeleteVariantById");

            var localVarPath = "/catalog/products/{product_id}/variants/{variant_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (productId != null) localVarPathParams.Add("product_id", this.Configuration.ApiClient.ParameterToString(productId)); // path parameter
            if (variantId != null) localVarPathParams.Add("variant_id", this.Configuration.ApiClient.ParameterToString(variantId)); // path parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            // authentication (X-Auth-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Auth-Token")))
            {
                localVarHeaderParams["X-Auth-Token"] = this.Configuration.GetApiKeyWithPrefix("X-Auth-Token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteVariantById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Delete a Product Variant Deletes a product *Variant*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteVariantByIdAsync (int? productId, int? variantId, string accept, string contentType)
        {
             await DeleteVariantByIdAsyncWithHttpInfo(productId, variantId, accept, contentType);

        }

        /// <summary>
        /// Delete a Product Variant Deletes a product *Variant*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteVariantByIdAsyncWithHttpInfo (int? productId, int? variantId, string accept, string contentType)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVariantsApi->DeleteVariantById");
            // verify the required parameter 'variantId' is set
            if (variantId == null)
                throw new ApiException(400, "Missing required parameter 'variantId' when calling ProductVariantsApi->DeleteVariantById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductVariantsApi->DeleteVariantById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductVariantsApi->DeleteVariantById");

            var localVarPath = "/catalog/products/{product_id}/variants/{variant_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (productId != null) localVarPathParams.Add("product_id", this.Configuration.ApiClient.ParameterToString(productId)); // path parameter
            if (variantId != null) localVarPathParams.Add("variant_id", this.Configuration.ApiClient.ParameterToString(variantId)); // path parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            // authentication (X-Auth-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Auth-Token")))
            {
                localVarHeaderParams["X-Auth-Token"] = this.Configuration.GetApiKeyWithPrefix("X-Auth-Token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteVariantById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Get a Product Variant Returns a single product *Variant*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>VariantResponse1</returns>
        public VariantResponse1 GetVariantById (int? productId, int? variantId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<VariantResponse1> localVarResponse = GetVariantByIdWithHttpInfo(productId, variantId, accept, contentType, includeFields, excludeFields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Product Variant Returns a single product *Variant*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of VariantResponse1</returns>
        public ApiResponse< VariantResponse1 > GetVariantByIdWithHttpInfo (int? productId, int? variantId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVariantsApi->GetVariantById");
            // verify the required parameter 'variantId' is set
            if (variantId == null)
                throw new ApiException(400, "Missing required parameter 'variantId' when calling ProductVariantsApi->GetVariantById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductVariantsApi->GetVariantById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductVariantsApi->GetVariantById");

            var localVarPath = "/catalog/products/{product_id}/variants/{variant_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (productId != null) localVarPathParams.Add("product_id", this.Configuration.ApiClient.ParameterToString(productId)); // path parameter
            if (variantId != null) localVarPathParams.Add("variant_id", this.Configuration.ApiClient.ParameterToString(variantId)); // path parameter
            if (includeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_fields", includeFields)); // query parameter
            if (excludeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "exclude_fields", excludeFields)); // query parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            // authentication (X-Auth-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Auth-Token")))
            {
                localVarHeaderParams["X-Auth-Token"] = this.Configuration.GetApiKeyWithPrefix("X-Auth-Token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetVariantById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VariantResponse1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (VariantResponse1) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VariantResponse1)));
        }

        /// <summary>
        /// Get a Product Variant Returns a single product *Variant*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of VariantResponse1</returns>
        public async System.Threading.Tasks.Task<VariantResponse1> GetVariantByIdAsync (int? productId, int? variantId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<VariantResponse1> localVarResponse = await GetVariantByIdAsyncWithHttpInfo(productId, variantId, accept, contentType, includeFields, excludeFields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Product Variant Returns a single product *Variant*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (VariantResponse1)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VariantResponse1>> GetVariantByIdAsyncWithHttpInfo (int? productId, int? variantId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVariantsApi->GetVariantById");
            // verify the required parameter 'variantId' is set
            if (variantId == null)
                throw new ApiException(400, "Missing required parameter 'variantId' when calling ProductVariantsApi->GetVariantById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductVariantsApi->GetVariantById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductVariantsApi->GetVariantById");

            var localVarPath = "/catalog/products/{product_id}/variants/{variant_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (productId != null) localVarPathParams.Add("product_id", this.Configuration.ApiClient.ParameterToString(productId)); // path parameter
            if (variantId != null) localVarPathParams.Add("variant_id", this.Configuration.ApiClient.ParameterToString(variantId)); // path parameter
            if (includeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_fields", includeFields)); // query parameter
            if (excludeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "exclude_fields", excludeFields)); // query parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            // authentication (X-Auth-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Auth-Token")))
            {
                localVarHeaderParams["X-Auth-Token"] = this.Configuration.GetApiKeyWithPrefix("X-Auth-Token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetVariantById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VariantResponse1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (VariantResponse1) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VariantResponse1)));
        }

        /// <summary>
        /// Get All Product Variants Returns a list of product *Variants*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>VariantCollectionResponse</returns>
        public VariantCollectionResponse GetVariantsByProductId (int? productId, string accept, string contentType, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<VariantCollectionResponse> localVarResponse = GetVariantsByProductIdWithHttpInfo(productId, accept, contentType, page, limit, includeFields, excludeFields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get All Product Variants Returns a list of product *Variants*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of VariantCollectionResponse</returns>
        public ApiResponse< VariantCollectionResponse > GetVariantsByProductIdWithHttpInfo (int? productId, string accept, string contentType, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVariantsApi->GetVariantsByProductId");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductVariantsApi->GetVariantsByProductId");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductVariantsApi->GetVariantsByProductId");

            var localVarPath = "/catalog/products/{product_id}/variants";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (productId != null) localVarPathParams.Add("product_id", this.Configuration.ApiClient.ParameterToString(productId)); // path parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (includeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_fields", includeFields)); // query parameter
            if (excludeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "exclude_fields", excludeFields)); // query parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            // authentication (X-Auth-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Auth-Token")))
            {
                localVarHeaderParams["X-Auth-Token"] = this.Configuration.GetApiKeyWithPrefix("X-Auth-Token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetVariantsByProductId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VariantCollectionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (VariantCollectionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VariantCollectionResponse)));
        }

        /// <summary>
        /// Get All Product Variants Returns a list of product *Variants*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of VariantCollectionResponse</returns>
        public async System.Threading.Tasks.Task<VariantCollectionResponse> GetVariantsByProductIdAsync (int? productId, string accept, string contentType, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<VariantCollectionResponse> localVarResponse = await GetVariantsByProductIdAsyncWithHttpInfo(productId, accept, contentType, page, limit, includeFields, excludeFields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get All Product Variants Returns a list of product *Variants*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (VariantCollectionResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VariantCollectionResponse>> GetVariantsByProductIdAsyncWithHttpInfo (int? productId, string accept, string contentType, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVariantsApi->GetVariantsByProductId");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductVariantsApi->GetVariantsByProductId");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductVariantsApi->GetVariantsByProductId");

            var localVarPath = "/catalog/products/{product_id}/variants";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (productId != null) localVarPathParams.Add("product_id", this.Configuration.ApiClient.ParameterToString(productId)); // path parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (includeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_fields", includeFields)); // query parameter
            if (excludeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "exclude_fields", excludeFields)); // query parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            // authentication (X-Auth-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Auth-Token")))
            {
                localVarHeaderParams["X-Auth-Token"] = this.Configuration.GetApiKeyWithPrefix("X-Auth-Token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetVariantsByProductId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VariantCollectionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (VariantCollectionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VariantCollectionResponse)));
        }

        /// <summary>
        /// Update a Product Variant Updates a product *Variant*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <returns>VariantResponse1</returns>
        public VariantResponse1 UpdateVariant (ProductVariantPut1 body, string accept, string contentType, int? productId, int? variantId)
        {
             ApiResponse<VariantResponse1> localVarResponse = UpdateVariantWithHttpInfo(body, accept, contentType, productId, variantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a Product Variant Updates a product *Variant*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <returns>ApiResponse of VariantResponse1</returns>
        public ApiResponse< VariantResponse1 > UpdateVariantWithHttpInfo (ProductVariantPut1 body, string accept, string contentType, int? productId, int? variantId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductVariantsApi->UpdateVariant");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductVariantsApi->UpdateVariant");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductVariantsApi->UpdateVariant");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVariantsApi->UpdateVariant");
            // verify the required parameter 'variantId' is set
            if (variantId == null)
                throw new ApiException(400, "Missing required parameter 'variantId' when calling ProductVariantsApi->UpdateVariant");

            var localVarPath = "/catalog/products/{product_id}/variants/{variant_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (productId != null) localVarPathParams.Add("product_id", this.Configuration.ApiClient.ParameterToString(productId)); // path parameter
            if (variantId != null) localVarPathParams.Add("variant_id", this.Configuration.ApiClient.ParameterToString(variantId)); // path parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            // authentication (X-Auth-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Auth-Token")))
            {
                localVarHeaderParams["X-Auth-Token"] = this.Configuration.GetApiKeyWithPrefix("X-Auth-Token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateVariant", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VariantResponse1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (VariantResponse1) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VariantResponse1)));
        }

        /// <summary>
        /// Update a Product Variant Updates a product *Variant*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <returns>Task of VariantResponse1</returns>
        public async System.Threading.Tasks.Task<VariantResponse1> UpdateVariantAsync (ProductVariantPut1 body, string accept, string contentType, int? productId, int? variantId)
        {
             ApiResponse<VariantResponse1> localVarResponse = await UpdateVariantAsyncWithHttpInfo(body, accept, contentType, productId, variantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a Product Variant Updates a product *Variant*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <returns>Task of ApiResponse (VariantResponse1)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VariantResponse1>> UpdateVariantAsyncWithHttpInfo (ProductVariantPut1 body, string accept, string contentType, int? productId, int? variantId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductVariantsApi->UpdateVariant");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductVariantsApi->UpdateVariant");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductVariantsApi->UpdateVariant");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVariantsApi->UpdateVariant");
            // verify the required parameter 'variantId' is set
            if (variantId == null)
                throw new ApiException(400, "Missing required parameter 'variantId' when calling ProductVariantsApi->UpdateVariant");

            var localVarPath = "/catalog/products/{product_id}/variants/{variant_id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (productId != null) localVarPathParams.Add("product_id", this.Configuration.ApiClient.ParameterToString(productId)); // path parameter
            if (variantId != null) localVarPathParams.Add("variant_id", this.Configuration.ApiClient.ParameterToString(variantId)); // path parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            // authentication (X-Auth-Token) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Auth-Token")))
            {
                localVarHeaderParams["X-Auth-Token"] = this.Configuration.GetApiKeyWithPrefix("X-Auth-Token");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateVariant", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VariantResponse1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (VariantResponse1) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VariantResponse1)));
        }

    }
}
