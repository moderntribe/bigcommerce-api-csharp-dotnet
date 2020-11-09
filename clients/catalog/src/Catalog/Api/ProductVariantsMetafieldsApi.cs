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
using Catalog.Client;
using Catalog.Model;

namespace Catalog.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IProductVariantsMetafieldsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a Product Variant Metafield
        /// </summary>
        /// <remarks>
        /// Creates a product variant *Metafield*.  **Required Fields:** * permission_set * namespace * key * value  **Read-Only Fields** * id  **Note:** The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <returns>MetafieldResponse2</returns>
        MetafieldResponse2 CreateVariantMetafield (MetafieldPost body, string accept, string contentType, int? productId, int? variantId);

        /// <summary>
        /// Create a Product Variant Metafield
        /// </summary>
        /// <remarks>
        /// Creates a product variant *Metafield*.  **Required Fields:** * permission_set * namespace * key * value  **Read-Only Fields** * id  **Note:** The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <returns>ApiResponse of MetafieldResponse2</returns>
        ApiResponse<MetafieldResponse2> CreateVariantMetafieldWithHttpInfo (MetafieldPost body, string accept, string contentType, int? productId, int? variantId);
        /// <summary>
        /// Delete a Variant Metafield
        /// </summary>
        /// <remarks>
        /// Deletes a product variant *Metafield*.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void DeleteVariantMetafieldById (int? metafieldId, int? productId, int? variantId, string accept, string contentType);

        /// <summary>
        /// Delete a Variant Metafield
        /// </summary>
        /// <remarks>
        /// Deletes a product variant *Metafield*.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteVariantMetafieldByIdWithHttpInfo (int? metafieldId, int? productId, int? variantId, string accept, string contentType);
        /// <summary>
        /// Get Product Variant Metafields
        /// </summary>
        /// <remarks>
        /// Returns a single product variant *Metafield*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>MetafieldResponse1</returns>
        MetafieldResponse1 GetVariantMetafieldByProductIdAndVariantId (int? metafieldId, int? productId, int? variantId, string accept, string contentType, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get Product Variant Metafields
        /// </summary>
        /// <remarks>
        /// Returns a single product variant *Metafield*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of MetafieldResponse1</returns>
        ApiResponse<MetafieldResponse1> GetVariantMetafieldByProductIdAndVariantIdWithHttpInfo (int? metafieldId, int? productId, int? variantId, string accept, string contentType, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Get Product Variant Metafields
        /// </summary>
        /// <remarks>
        /// Returns a list of product variant *Metafields*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="key">Filter based on a metafield&#x27;s key.  (optional)</param>
        /// <param name="_namespace">Filter based on a metafield&#x27;s namespace. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>MetaFieldCollectionResponse1</returns>
        MetaFieldCollectionResponse1 GetVariantMetafieldsByProductIdAndVariantId (int? productId, int? variantId, string accept, string contentType, int? page = null, int? limit = null, string key = null, string _namespace = null, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get Product Variant Metafields
        /// </summary>
        /// <remarks>
        /// Returns a list of product variant *Metafields*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="key">Filter based on a metafield&#x27;s key.  (optional)</param>
        /// <param name="_namespace">Filter based on a metafield&#x27;s namespace. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of MetaFieldCollectionResponse1</returns>
        ApiResponse<MetaFieldCollectionResponse1> GetVariantMetafieldsByProductIdAndVariantIdWithHttpInfo (int? productId, int? variantId, string accept, string contentType, int? page = null, int? limit = null, string key = null, string _namespace = null, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Update Product Variant Metafields
        /// </summary>
        /// <remarks>
        /// Updates a product variant *Metafield*.  **Required Fields:** * none  **Read-Only Fields** * id * These fields can only be modified by the app (API credentials) that created the metafield:  * namespace  * key  * permission_set  **Usage Notes** * Attempting to modify &#x60;namespace&#x60;, &#x60;key&#x60;, and &#x60;permission_set&#x60; fields using a client ID different from the one used to create those metafields will result in a 403 error message. 
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <returns>MetafieldResponse1</returns>
        MetafieldResponse1 UpdateVariantMetafield (MetafieldPut4 body, string accept, string contentType, int? metafieldId, int? productId, int? variantId);

        /// <summary>
        /// Update Product Variant Metafields
        /// </summary>
        /// <remarks>
        /// Updates a product variant *Metafield*.  **Required Fields:** * none  **Read-Only Fields** * id * These fields can only be modified by the app (API credentials) that created the metafield:  * namespace  * key  * permission_set  **Usage Notes** * Attempting to modify &#x60;namespace&#x60;, &#x60;key&#x60;, and &#x60;permission_set&#x60; fields using a client ID different from the one used to create those metafields will result in a 403 error message. 
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <returns>ApiResponse of MetafieldResponse1</returns>
        ApiResponse<MetafieldResponse1> UpdateVariantMetafieldWithHttpInfo (MetafieldPut4 body, string accept, string contentType, int? metafieldId, int? productId, int? variantId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create a Product Variant Metafield
        /// </summary>
        /// <remarks>
        /// Creates a product variant *Metafield*.  **Required Fields:** * permission_set * namespace * key * value  **Read-Only Fields** * id  **Note:** The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <returns>Task of MetafieldResponse2</returns>
        System.Threading.Tasks.Task<MetafieldResponse2> CreateVariantMetafieldAsync (MetafieldPost body, string accept, string contentType, int? productId, int? variantId);

        /// <summary>
        /// Create a Product Variant Metafield
        /// </summary>
        /// <remarks>
        /// Creates a product variant *Metafield*.  **Required Fields:** * permission_set * namespace * key * value  **Read-Only Fields** * id  **Note:** The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <returns>Task of ApiResponse (MetafieldResponse2)</returns>
        System.Threading.Tasks.Task<ApiResponse<MetafieldResponse2>> CreateVariantMetafieldAsyncWithHttpInfo (MetafieldPost body, string accept, string contentType, int? productId, int? variantId);
        /// <summary>
        /// Delete a Variant Metafield
        /// </summary>
        /// <remarks>
        /// Deletes a product variant *Metafield*.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteVariantMetafieldByIdAsync (int? metafieldId, int? productId, int? variantId, string accept, string contentType);

        /// <summary>
        /// Delete a Variant Metafield
        /// </summary>
        /// <remarks>
        /// Deletes a product variant *Metafield*.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteVariantMetafieldByIdAsyncWithHttpInfo (int? metafieldId, int? productId, int? variantId, string accept, string contentType);
        /// <summary>
        /// Get Product Variant Metafields
        /// </summary>
        /// <remarks>
        /// Returns a single product variant *Metafield*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of MetafieldResponse1</returns>
        System.Threading.Tasks.Task<MetafieldResponse1> GetVariantMetafieldByProductIdAndVariantIdAsync (int? metafieldId, int? productId, int? variantId, string accept, string contentType, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get Product Variant Metafields
        /// </summary>
        /// <remarks>
        /// Returns a single product variant *Metafield*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (MetafieldResponse1)</returns>
        System.Threading.Tasks.Task<ApiResponse<MetafieldResponse1>> GetVariantMetafieldByProductIdAndVariantIdAsyncWithHttpInfo (int? metafieldId, int? productId, int? variantId, string accept, string contentType, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Get Product Variant Metafields
        /// </summary>
        /// <remarks>
        /// Returns a list of product variant *Metafields*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="key">Filter based on a metafield&#x27;s key.  (optional)</param>
        /// <param name="_namespace">Filter based on a metafield&#x27;s namespace. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of MetaFieldCollectionResponse1</returns>
        System.Threading.Tasks.Task<MetaFieldCollectionResponse1> GetVariantMetafieldsByProductIdAndVariantIdAsync (int? productId, int? variantId, string accept, string contentType, int? page = null, int? limit = null, string key = null, string _namespace = null, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get Product Variant Metafields
        /// </summary>
        /// <remarks>
        /// Returns a list of product variant *Metafields*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="key">Filter based on a metafield&#x27;s key.  (optional)</param>
        /// <param name="_namespace">Filter based on a metafield&#x27;s namespace. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (MetaFieldCollectionResponse1)</returns>
        System.Threading.Tasks.Task<ApiResponse<MetaFieldCollectionResponse1>> GetVariantMetafieldsByProductIdAndVariantIdAsyncWithHttpInfo (int? productId, int? variantId, string accept, string contentType, int? page = null, int? limit = null, string key = null, string _namespace = null, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Update Product Variant Metafields
        /// </summary>
        /// <remarks>
        /// Updates a product variant *Metafield*.  **Required Fields:** * none  **Read-Only Fields** * id * These fields can only be modified by the app (API credentials) that created the metafield:  * namespace  * key  * permission_set  **Usage Notes** * Attempting to modify &#x60;namespace&#x60;, &#x60;key&#x60;, and &#x60;permission_set&#x60; fields using a client ID different from the one used to create those metafields will result in a 403 error message. 
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <returns>Task of MetafieldResponse1</returns>
        System.Threading.Tasks.Task<MetafieldResponse1> UpdateVariantMetafieldAsync (MetafieldPut4 body, string accept, string contentType, int? metafieldId, int? productId, int? variantId);

        /// <summary>
        /// Update Product Variant Metafields
        /// </summary>
        /// <remarks>
        /// Updates a product variant *Metafield*.  **Required Fields:** * none  **Read-Only Fields** * id * These fields can only be modified by the app (API credentials) that created the metafield:  * namespace  * key  * permission_set  **Usage Notes** * Attempting to modify &#x60;namespace&#x60;, &#x60;key&#x60;, and &#x60;permission_set&#x60; fields using a client ID different from the one used to create those metafields will result in a 403 error message. 
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <returns>Task of ApiResponse (MetafieldResponse1)</returns>
        System.Threading.Tasks.Task<ApiResponse<MetafieldResponse1>> UpdateVariantMetafieldAsyncWithHttpInfo (MetafieldPut4 body, string accept, string contentType, int? metafieldId, int? productId, int? variantId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class ProductVariantsMetafieldsApi : IProductVariantsMetafieldsApi
    {
        private Catalog.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductVariantsMetafieldsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductVariantsMetafieldsApi(String basePath)
        {
            this.Configuration = new Catalog.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Catalog.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductVariantsMetafieldsApi"/> class
        /// </summary>
        /// <returns></returns>
        public ProductVariantsMetafieldsApi()
        {
            this.Configuration = Catalog.Client.Configuration.Default;

            ExceptionFactory = Catalog.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductVariantsMetafieldsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProductVariantsMetafieldsApi(Catalog.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Catalog.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Catalog.Client.Configuration.DefaultExceptionFactory;
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
        public Catalog.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Catalog.Client.ExceptionFactory ExceptionFactory
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
        /// Create a Product Variant Metafield Creates a product variant *Metafield*.  **Required Fields:** * permission_set * namespace * key * value  **Read-Only Fields** * id  **Note:** The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <returns>MetafieldResponse2</returns>
        public MetafieldResponse2 CreateVariantMetafield (MetafieldPost body, string accept, string contentType, int? productId, int? variantId)
        {
             ApiResponse<MetafieldResponse2> localVarResponse = CreateVariantMetafieldWithHttpInfo(body, accept, contentType, productId, variantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Product Variant Metafield Creates a product variant *Metafield*.  **Required Fields:** * permission_set * namespace * key * value  **Read-Only Fields** * id  **Note:** The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <returns>ApiResponse of MetafieldResponse2</returns>
        public ApiResponse< MetafieldResponse2 > CreateVariantMetafieldWithHttpInfo (MetafieldPost body, string accept, string contentType, int? productId, int? variantId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductVariantsMetafieldsApi->CreateVariantMetafield");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductVariantsMetafieldsApi->CreateVariantMetafield");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductVariantsMetafieldsApi->CreateVariantMetafield");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVariantsMetafieldsApi->CreateVariantMetafield");
            // verify the required parameter 'variantId' is set
            if (variantId == null)
                throw new ApiException(400, "Missing required parameter 'variantId' when calling ProductVariantsMetafieldsApi->CreateVariantMetafield");

            var localVarPath = "/catalog/products/{product_id}/variants/{variant_id}/metafields";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateVariantMetafield", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MetafieldResponse2>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (MetafieldResponse2) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MetafieldResponse2)));
        }

        /// <summary>
        /// Create a Product Variant Metafield Creates a product variant *Metafield*.  **Required Fields:** * permission_set * namespace * key * value  **Read-Only Fields** * id  **Note:** The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <returns>Task of MetafieldResponse2</returns>
        public async System.Threading.Tasks.Task<MetafieldResponse2> CreateVariantMetafieldAsync (MetafieldPost body, string accept, string contentType, int? productId, int? variantId)
        {
             ApiResponse<MetafieldResponse2> localVarResponse = await CreateVariantMetafieldAsyncWithHttpInfo(body, accept, contentType, productId, variantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Product Variant Metafield Creates a product variant *Metafield*.  **Required Fields:** * permission_set * namespace * key * value  **Read-Only Fields** * id  **Note:** The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <returns>Task of ApiResponse (MetafieldResponse2)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MetafieldResponse2>> CreateVariantMetafieldAsyncWithHttpInfo (MetafieldPost body, string accept, string contentType, int? productId, int? variantId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductVariantsMetafieldsApi->CreateVariantMetafield");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductVariantsMetafieldsApi->CreateVariantMetafield");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductVariantsMetafieldsApi->CreateVariantMetafield");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVariantsMetafieldsApi->CreateVariantMetafield");
            // verify the required parameter 'variantId' is set
            if (variantId == null)
                throw new ApiException(400, "Missing required parameter 'variantId' when calling ProductVariantsMetafieldsApi->CreateVariantMetafield");

            var localVarPath = "/catalog/products/{product_id}/variants/{variant_id}/metafields";
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
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateVariantMetafield", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MetafieldResponse2>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (MetafieldResponse2) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MetafieldResponse2)));
        }

        /// <summary>
        /// Delete a Variant Metafield Deletes a product variant *Metafield*.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public void DeleteVariantMetafieldById (int? metafieldId, int? productId, int? variantId, string accept, string contentType)
        {
             DeleteVariantMetafieldByIdWithHttpInfo(metafieldId, productId, variantId, accept, contentType);
        }

        /// <summary>
        /// Delete a Variant Metafield Deletes a product variant *Metafield*.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteVariantMetafieldByIdWithHttpInfo (int? metafieldId, int? productId, int? variantId, string accept, string contentType)
        {
            // verify the required parameter 'metafieldId' is set
            if (metafieldId == null)
                throw new ApiException(400, "Missing required parameter 'metafieldId' when calling ProductVariantsMetafieldsApi->DeleteVariantMetafieldById");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVariantsMetafieldsApi->DeleteVariantMetafieldById");
            // verify the required parameter 'variantId' is set
            if (variantId == null)
                throw new ApiException(400, "Missing required parameter 'variantId' when calling ProductVariantsMetafieldsApi->DeleteVariantMetafieldById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductVariantsMetafieldsApi->DeleteVariantMetafieldById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductVariantsMetafieldsApi->DeleteVariantMetafieldById");

            var localVarPath = "/catalog/products/{product_id}/variants/{variant_id}/metafields/{metafield_id}";
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

            if (metafieldId != null) localVarPathParams.Add("metafield_id", this.Configuration.ApiClient.ParameterToString(metafieldId)); // path parameter
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
                Exception exception = ExceptionFactory("DeleteVariantMetafieldById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Delete a Variant Metafield Deletes a product variant *Metafield*.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteVariantMetafieldByIdAsync (int? metafieldId, int? productId, int? variantId, string accept, string contentType)
        {
             await DeleteVariantMetafieldByIdAsyncWithHttpInfo(metafieldId, productId, variantId, accept, contentType);

        }

        /// <summary>
        /// Delete a Variant Metafield Deletes a product variant *Metafield*.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteVariantMetafieldByIdAsyncWithHttpInfo (int? metafieldId, int? productId, int? variantId, string accept, string contentType)
        {
            // verify the required parameter 'metafieldId' is set
            if (metafieldId == null)
                throw new ApiException(400, "Missing required parameter 'metafieldId' when calling ProductVariantsMetafieldsApi->DeleteVariantMetafieldById");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVariantsMetafieldsApi->DeleteVariantMetafieldById");
            // verify the required parameter 'variantId' is set
            if (variantId == null)
                throw new ApiException(400, "Missing required parameter 'variantId' when calling ProductVariantsMetafieldsApi->DeleteVariantMetafieldById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductVariantsMetafieldsApi->DeleteVariantMetafieldById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductVariantsMetafieldsApi->DeleteVariantMetafieldById");

            var localVarPath = "/catalog/products/{product_id}/variants/{variant_id}/metafields/{metafield_id}";
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

            if (metafieldId != null) localVarPathParams.Add("metafield_id", this.Configuration.ApiClient.ParameterToString(metafieldId)); // path parameter
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
                Exception exception = ExceptionFactory("DeleteVariantMetafieldById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Get Product Variant Metafields Returns a single product variant *Metafield*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>MetafieldResponse1</returns>
        public MetafieldResponse1 GetVariantMetafieldByProductIdAndVariantId (int? metafieldId, int? productId, int? variantId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<MetafieldResponse1> localVarResponse = GetVariantMetafieldByProductIdAndVariantIdWithHttpInfo(metafieldId, productId, variantId, accept, contentType, includeFields, excludeFields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Product Variant Metafields Returns a single product variant *Metafield*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of MetafieldResponse1</returns>
        public ApiResponse< MetafieldResponse1 > GetVariantMetafieldByProductIdAndVariantIdWithHttpInfo (int? metafieldId, int? productId, int? variantId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'metafieldId' is set
            if (metafieldId == null)
                throw new ApiException(400, "Missing required parameter 'metafieldId' when calling ProductVariantsMetafieldsApi->GetVariantMetafieldByProductIdAndVariantId");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVariantsMetafieldsApi->GetVariantMetafieldByProductIdAndVariantId");
            // verify the required parameter 'variantId' is set
            if (variantId == null)
                throw new ApiException(400, "Missing required parameter 'variantId' when calling ProductVariantsMetafieldsApi->GetVariantMetafieldByProductIdAndVariantId");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductVariantsMetafieldsApi->GetVariantMetafieldByProductIdAndVariantId");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductVariantsMetafieldsApi->GetVariantMetafieldByProductIdAndVariantId");

            var localVarPath = "/catalog/products/{product_id}/variants/{variant_id}/metafields/{metafield_id}";
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

            if (metafieldId != null) localVarPathParams.Add("metafield_id", this.Configuration.ApiClient.ParameterToString(metafieldId)); // path parameter
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
                Exception exception = ExceptionFactory("GetVariantMetafieldByProductIdAndVariantId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MetafieldResponse1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (MetafieldResponse1) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MetafieldResponse1)));
        }

        /// <summary>
        /// Get Product Variant Metafields Returns a single product variant *Metafield*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of MetafieldResponse1</returns>
        public async System.Threading.Tasks.Task<MetafieldResponse1> GetVariantMetafieldByProductIdAndVariantIdAsync (int? metafieldId, int? productId, int? variantId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<MetafieldResponse1> localVarResponse = await GetVariantMetafieldByProductIdAndVariantIdAsyncWithHttpInfo(metafieldId, productId, variantId, accept, contentType, includeFields, excludeFields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Product Variant Metafields Returns a single product variant *Metafield*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (MetafieldResponse1)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MetafieldResponse1>> GetVariantMetafieldByProductIdAndVariantIdAsyncWithHttpInfo (int? metafieldId, int? productId, int? variantId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'metafieldId' is set
            if (metafieldId == null)
                throw new ApiException(400, "Missing required parameter 'metafieldId' when calling ProductVariantsMetafieldsApi->GetVariantMetafieldByProductIdAndVariantId");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVariantsMetafieldsApi->GetVariantMetafieldByProductIdAndVariantId");
            // verify the required parameter 'variantId' is set
            if (variantId == null)
                throw new ApiException(400, "Missing required parameter 'variantId' when calling ProductVariantsMetafieldsApi->GetVariantMetafieldByProductIdAndVariantId");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductVariantsMetafieldsApi->GetVariantMetafieldByProductIdAndVariantId");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductVariantsMetafieldsApi->GetVariantMetafieldByProductIdAndVariantId");

            var localVarPath = "/catalog/products/{product_id}/variants/{variant_id}/metafields/{metafield_id}";
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

            if (metafieldId != null) localVarPathParams.Add("metafield_id", this.Configuration.ApiClient.ParameterToString(metafieldId)); // path parameter
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
                Exception exception = ExceptionFactory("GetVariantMetafieldByProductIdAndVariantId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MetafieldResponse1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (MetafieldResponse1) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MetafieldResponse1)));
        }

        /// <summary>
        /// Get Product Variant Metafields Returns a list of product variant *Metafields*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="key">Filter based on a metafield&#x27;s key.  (optional)</param>
        /// <param name="_namespace">Filter based on a metafield&#x27;s namespace. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>MetaFieldCollectionResponse1</returns>
        public MetaFieldCollectionResponse1 GetVariantMetafieldsByProductIdAndVariantId (int? productId, int? variantId, string accept, string contentType, int? page = null, int? limit = null, string key = null, string _namespace = null, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<MetaFieldCollectionResponse1> localVarResponse = GetVariantMetafieldsByProductIdAndVariantIdWithHttpInfo(productId, variantId, accept, contentType, page, limit, key, _namespace, includeFields, excludeFields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Product Variant Metafields Returns a list of product variant *Metafields*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="key">Filter based on a metafield&#x27;s key.  (optional)</param>
        /// <param name="_namespace">Filter based on a metafield&#x27;s namespace. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of MetaFieldCollectionResponse1</returns>
        public ApiResponse< MetaFieldCollectionResponse1 > GetVariantMetafieldsByProductIdAndVariantIdWithHttpInfo (int? productId, int? variantId, string accept, string contentType, int? page = null, int? limit = null, string key = null, string _namespace = null, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVariantsMetafieldsApi->GetVariantMetafieldsByProductIdAndVariantId");
            // verify the required parameter 'variantId' is set
            if (variantId == null)
                throw new ApiException(400, "Missing required parameter 'variantId' when calling ProductVariantsMetafieldsApi->GetVariantMetafieldsByProductIdAndVariantId");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductVariantsMetafieldsApi->GetVariantMetafieldsByProductIdAndVariantId");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductVariantsMetafieldsApi->GetVariantMetafieldsByProductIdAndVariantId");

            var localVarPath = "/catalog/products/{product_id}/variants/{variant_id}/metafields";
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
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (key != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "key", key)); // query parameter
            if (_namespace != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "namespace", _namespace)); // query parameter
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
                Exception exception = ExceptionFactory("GetVariantMetafieldsByProductIdAndVariantId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MetaFieldCollectionResponse1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (MetaFieldCollectionResponse1) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MetaFieldCollectionResponse1)));
        }

        /// <summary>
        /// Get Product Variant Metafields Returns a list of product variant *Metafields*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="key">Filter based on a metafield&#x27;s key.  (optional)</param>
        /// <param name="_namespace">Filter based on a metafield&#x27;s namespace. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of MetaFieldCollectionResponse1</returns>
        public async System.Threading.Tasks.Task<MetaFieldCollectionResponse1> GetVariantMetafieldsByProductIdAndVariantIdAsync (int? productId, int? variantId, string accept, string contentType, int? page = null, int? limit = null, string key = null, string _namespace = null, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<MetaFieldCollectionResponse1> localVarResponse = await GetVariantMetafieldsByProductIdAndVariantIdAsyncWithHttpInfo(productId, variantId, accept, contentType, page, limit, key, _namespace, includeFields, excludeFields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Product Variant Metafields Returns a list of product variant *Metafields*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="key">Filter based on a metafield&#x27;s key.  (optional)</param>
        /// <param name="_namespace">Filter based on a metafield&#x27;s namespace. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (MetaFieldCollectionResponse1)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MetaFieldCollectionResponse1>> GetVariantMetafieldsByProductIdAndVariantIdAsyncWithHttpInfo (int? productId, int? variantId, string accept, string contentType, int? page = null, int? limit = null, string key = null, string _namespace = null, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVariantsMetafieldsApi->GetVariantMetafieldsByProductIdAndVariantId");
            // verify the required parameter 'variantId' is set
            if (variantId == null)
                throw new ApiException(400, "Missing required parameter 'variantId' when calling ProductVariantsMetafieldsApi->GetVariantMetafieldsByProductIdAndVariantId");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductVariantsMetafieldsApi->GetVariantMetafieldsByProductIdAndVariantId");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductVariantsMetafieldsApi->GetVariantMetafieldsByProductIdAndVariantId");

            var localVarPath = "/catalog/products/{product_id}/variants/{variant_id}/metafields";
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
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (key != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "key", key)); // query parameter
            if (_namespace != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "namespace", _namespace)); // query parameter
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
                Exception exception = ExceptionFactory("GetVariantMetafieldsByProductIdAndVariantId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MetaFieldCollectionResponse1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (MetaFieldCollectionResponse1) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MetaFieldCollectionResponse1)));
        }

        /// <summary>
        /// Update Product Variant Metafields Updates a product variant *Metafield*.  **Required Fields:** * none  **Read-Only Fields** * id * These fields can only be modified by the app (API credentials) that created the metafield:  * namespace  * key  * permission_set  **Usage Notes** * Attempting to modify &#x60;namespace&#x60;, &#x60;key&#x60;, and &#x60;permission_set&#x60; fields using a client ID different from the one used to create those metafields will result in a 403 error message. 
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <returns>MetafieldResponse1</returns>
        public MetafieldResponse1 UpdateVariantMetafield (MetafieldPut4 body, string accept, string contentType, int? metafieldId, int? productId, int? variantId)
        {
             ApiResponse<MetafieldResponse1> localVarResponse = UpdateVariantMetafieldWithHttpInfo(body, accept, contentType, metafieldId, productId, variantId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Product Variant Metafields Updates a product variant *Metafield*.  **Required Fields:** * none  **Read-Only Fields** * id * These fields can only be modified by the app (API credentials) that created the metafield:  * namespace  * key  * permission_set  **Usage Notes** * Attempting to modify &#x60;namespace&#x60;, &#x60;key&#x60;, and &#x60;permission_set&#x60; fields using a client ID different from the one used to create those metafields will result in a 403 error message. 
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <returns>ApiResponse of MetafieldResponse1</returns>
        public ApiResponse< MetafieldResponse1 > UpdateVariantMetafieldWithHttpInfo (MetafieldPut4 body, string accept, string contentType, int? metafieldId, int? productId, int? variantId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductVariantsMetafieldsApi->UpdateVariantMetafield");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductVariantsMetafieldsApi->UpdateVariantMetafield");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductVariantsMetafieldsApi->UpdateVariantMetafield");
            // verify the required parameter 'metafieldId' is set
            if (metafieldId == null)
                throw new ApiException(400, "Missing required parameter 'metafieldId' when calling ProductVariantsMetafieldsApi->UpdateVariantMetafield");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVariantsMetafieldsApi->UpdateVariantMetafield");
            // verify the required parameter 'variantId' is set
            if (variantId == null)
                throw new ApiException(400, "Missing required parameter 'variantId' when calling ProductVariantsMetafieldsApi->UpdateVariantMetafield");

            var localVarPath = "/catalog/products/{product_id}/variants/{variant_id}/metafields/{metafield_id}";
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

            if (metafieldId != null) localVarPathParams.Add("metafield_id", this.Configuration.ApiClient.ParameterToString(metafieldId)); // path parameter
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
                Exception exception = ExceptionFactory("UpdateVariantMetafield", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MetafieldResponse1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (MetafieldResponse1) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MetafieldResponse1)));
        }

        /// <summary>
        /// Update Product Variant Metafields Updates a product variant *Metafield*.  **Required Fields:** * none  **Read-Only Fields** * id * These fields can only be modified by the app (API credentials) that created the metafield:  * namespace  * key  * permission_set  **Usage Notes** * Attempting to modify &#x60;namespace&#x60;, &#x60;key&#x60;, and &#x60;permission_set&#x60; fields using a client ID different from the one used to create those metafields will result in a 403 error message. 
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <returns>Task of MetafieldResponse1</returns>
        public async System.Threading.Tasks.Task<MetafieldResponse1> UpdateVariantMetafieldAsync (MetafieldPut4 body, string accept, string contentType, int? metafieldId, int? productId, int? variantId)
        {
             ApiResponse<MetafieldResponse1> localVarResponse = await UpdateVariantMetafieldAsyncWithHttpInfo(body, accept, contentType, metafieldId, productId, variantId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update Product Variant Metafields Updates a product variant *Metafield*.  **Required Fields:** * none  **Read-Only Fields** * id * These fields can only be modified by the app (API credentials) that created the metafield:  * namespace  * key  * permission_set  **Usage Notes** * Attempting to modify &#x60;namespace&#x60;, &#x60;key&#x60;, and &#x60;permission_set&#x60; fields using a client ID different from the one used to create those metafields will result in a 403 error message. 
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <returns>Task of ApiResponse (MetafieldResponse1)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MetafieldResponse1>> UpdateVariantMetafieldAsyncWithHttpInfo (MetafieldPut4 body, string accept, string contentType, int? metafieldId, int? productId, int? variantId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductVariantsMetafieldsApi->UpdateVariantMetafield");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductVariantsMetafieldsApi->UpdateVariantMetafield");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductVariantsMetafieldsApi->UpdateVariantMetafield");
            // verify the required parameter 'metafieldId' is set
            if (metafieldId == null)
                throw new ApiException(400, "Missing required parameter 'metafieldId' when calling ProductVariantsMetafieldsApi->UpdateVariantMetafield");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVariantsMetafieldsApi->UpdateVariantMetafield");
            // verify the required parameter 'variantId' is set
            if (variantId == null)
                throw new ApiException(400, "Missing required parameter 'variantId' when calling ProductVariantsMetafieldsApi->UpdateVariantMetafield");

            var localVarPath = "/catalog/products/{product_id}/variants/{variant_id}/metafields/{metafield_id}";
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

            if (metafieldId != null) localVarPathParams.Add("metafield_id", this.Configuration.ApiClient.ParameterToString(metafieldId)); // path parameter
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
                Exception exception = ExceptionFactory("UpdateVariantMetafield", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MetafieldResponse1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (MetafieldResponse1) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MetafieldResponse1)));
        }

    }
}
