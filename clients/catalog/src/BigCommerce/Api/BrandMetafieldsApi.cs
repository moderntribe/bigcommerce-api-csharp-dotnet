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
        public interface IBrandMetafieldsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a Brand Metafield
        /// </summary>
        /// <remarks>
        /// Creates a *Brand Metafield*.  **Required Fields** - permission_set - namespace - key - value  **Read-Only Fields** - id  **Note:** The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <returns>MetafieldResponse</returns>
        MetafieldResponse CreateBrandMetafield (MetafieldPost1 body, string contentType, string accept, int? brandId);

        /// <summary>
        /// Create a Brand Metafield
        /// </summary>
        /// <remarks>
        /// Creates a *Brand Metafield*.  **Required Fields** - permission_set - namespace - key - value  **Read-Only Fields** - id  **Note:** The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <returns>ApiResponse of MetafieldResponse</returns>
        ApiResponse<MetafieldResponse> CreateBrandMetafieldWithHttpInfo (MetafieldPost1 body, string contentType, string accept, int? brandId);
        /// <summary>
        /// Delete a Brand Metafield
        /// </summary>
        /// <remarks>
        /// Deletes a *Brand Metafield*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void DeleteBrandMetafieldById (int? metafieldId, int? brandId, string accept, string contentType);

        /// <summary>
        /// Delete a Brand Metafield
        /// </summary>
        /// <remarks>
        /// Deletes a *Brand Metafield*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteBrandMetafieldByIdWithHttpInfo (int? metafieldId, int? brandId, string accept, string contentType);
        /// <summary>
        /// Get a Brand Metafields
        /// </summary>
        /// <remarks>
        /// Returns a *Brand Metafield*. Optional filter parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>MetafieldResponse1</returns>
        MetafieldResponse1 GetBrandMetafieldByBrandId (int? metafieldId, int? brandId, string accept, string contentType, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get a Brand Metafields
        /// </summary>
        /// <remarks>
        /// Returns a *Brand Metafield*. Optional filter parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of MetafieldResponse1</returns>
        ApiResponse<MetafieldResponse1> GetBrandMetafieldByBrandIdWithHttpInfo (int? metafieldId, int? brandId, string accept, string contentType, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Get All Brand Metafields
        /// </summary>
        /// <remarks>
        /// Returns a list of *Brand Metafields*. Optional filter parameters can be passed in. 
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="key">Filter based on a metafield&#x27;s key.  (optional)</param>
        /// <param name="_namespace">Filter based on a metafield&#x27;s namespace. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>MetaFieldCollectionResponse</returns>
        MetaFieldCollectionResponse GetBrandMetafieldsByBrandId (int? brandId, string contentType, string accept, int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, int? page = null, int? limit = null, string key = null, string _namespace = null, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get All Brand Metafields
        /// </summary>
        /// <remarks>
        /// Returns a list of *Brand Metafields*. Optional filter parameters can be passed in. 
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="key">Filter based on a metafield&#x27;s key.  (optional)</param>
        /// <param name="_namespace">Filter based on a metafield&#x27;s namespace. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of MetaFieldCollectionResponse</returns>
        ApiResponse<MetaFieldCollectionResponse> GetBrandMetafieldsByBrandIdWithHttpInfo (int? brandId, string contentType, string accept, int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, int? page = null, int? limit = null, string key = null, string _namespace = null, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Update a Brand Metafield
        /// </summary>
        /// <remarks>
        /// Updates a *Brand Metafield*.  **Required Fields**   * none  **Read-Only Fields** * id * These fields can only be modified by the app (API credentials) that created the metafield:  * namespace  * key  * permission_set  **Usage Notes** * Attempting to modify &#x60;namespace&#x60;, &#x60;key&#x60;, and &#x60;permission_set&#x60; fields using a client ID different from the one used to create those metafields will result in a 403 error message. * The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <returns>MetafieldResponse1</returns>
        MetafieldResponse1 UpdateBrandMetafield (MetafieldPut1 body, string accept, string contentType, int? metafieldId, int? brandId);

        /// <summary>
        /// Update a Brand Metafield
        /// </summary>
        /// <remarks>
        /// Updates a *Brand Metafield*.  **Required Fields**   * none  **Read-Only Fields** * id * These fields can only be modified by the app (API credentials) that created the metafield:  * namespace  * key  * permission_set  **Usage Notes** * Attempting to modify &#x60;namespace&#x60;, &#x60;key&#x60;, and &#x60;permission_set&#x60; fields using a client ID different from the one used to create those metafields will result in a 403 error message. * The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <returns>ApiResponse of MetafieldResponse1</returns>
        ApiResponse<MetafieldResponse1> UpdateBrandMetafieldWithHttpInfo (MetafieldPut1 body, string accept, string contentType, int? metafieldId, int? brandId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create a Brand Metafield
        /// </summary>
        /// <remarks>
        /// Creates a *Brand Metafield*.  **Required Fields** - permission_set - namespace - key - value  **Read-Only Fields** - id  **Note:** The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <returns>Task of MetafieldResponse</returns>
        System.Threading.Tasks.Task<MetafieldResponse> CreateBrandMetafieldAsync (MetafieldPost1 body, string contentType, string accept, int? brandId);

        /// <summary>
        /// Create a Brand Metafield
        /// </summary>
        /// <remarks>
        /// Creates a *Brand Metafield*.  **Required Fields** - permission_set - namespace - key - value  **Read-Only Fields** - id  **Note:** The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <returns>Task of ApiResponse (MetafieldResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MetafieldResponse>> CreateBrandMetafieldAsyncWithHttpInfo (MetafieldPost1 body, string contentType, string accept, int? brandId);
        /// <summary>
        /// Delete a Brand Metafield
        /// </summary>
        /// <remarks>
        /// Deletes a *Brand Metafield*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteBrandMetafieldByIdAsync (int? metafieldId, int? brandId, string accept, string contentType);

        /// <summary>
        /// Delete a Brand Metafield
        /// </summary>
        /// <remarks>
        /// Deletes a *Brand Metafield*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBrandMetafieldByIdAsyncWithHttpInfo (int? metafieldId, int? brandId, string accept, string contentType);
        /// <summary>
        /// Get a Brand Metafields
        /// </summary>
        /// <remarks>
        /// Returns a *Brand Metafield*. Optional filter parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of MetafieldResponse1</returns>
        System.Threading.Tasks.Task<MetafieldResponse1> GetBrandMetafieldByBrandIdAsync (int? metafieldId, int? brandId, string accept, string contentType, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get a Brand Metafields
        /// </summary>
        /// <remarks>
        /// Returns a *Brand Metafield*. Optional filter parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (MetafieldResponse1)</returns>
        System.Threading.Tasks.Task<ApiResponse<MetafieldResponse1>> GetBrandMetafieldByBrandIdAsyncWithHttpInfo (int? metafieldId, int? brandId, string accept, string contentType, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Get All Brand Metafields
        /// </summary>
        /// <remarks>
        /// Returns a list of *Brand Metafields*. Optional filter parameters can be passed in. 
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="key">Filter based on a metafield&#x27;s key.  (optional)</param>
        /// <param name="_namespace">Filter based on a metafield&#x27;s namespace. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of MetaFieldCollectionResponse</returns>
        System.Threading.Tasks.Task<MetaFieldCollectionResponse> GetBrandMetafieldsByBrandIdAsync (int? brandId, string contentType, string accept, int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, int? page = null, int? limit = null, string key = null, string _namespace = null, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get All Brand Metafields
        /// </summary>
        /// <remarks>
        /// Returns a list of *Brand Metafields*. Optional filter parameters can be passed in. 
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="key">Filter based on a metafield&#x27;s key.  (optional)</param>
        /// <param name="_namespace">Filter based on a metafield&#x27;s namespace. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (MetaFieldCollectionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<MetaFieldCollectionResponse>> GetBrandMetafieldsByBrandIdAsyncWithHttpInfo (int? brandId, string contentType, string accept, int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, int? page = null, int? limit = null, string key = null, string _namespace = null, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Update a Brand Metafield
        /// </summary>
        /// <remarks>
        /// Updates a *Brand Metafield*.  **Required Fields**   * none  **Read-Only Fields** * id * These fields can only be modified by the app (API credentials) that created the metafield:  * namespace  * key  * permission_set  **Usage Notes** * Attempting to modify &#x60;namespace&#x60;, &#x60;key&#x60;, and &#x60;permission_set&#x60; fields using a client ID different from the one used to create those metafields will result in a 403 error message. * The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <returns>Task of MetafieldResponse1</returns>
        System.Threading.Tasks.Task<MetafieldResponse1> UpdateBrandMetafieldAsync (MetafieldPut1 body, string accept, string contentType, int? metafieldId, int? brandId);

        /// <summary>
        /// Update a Brand Metafield
        /// </summary>
        /// <remarks>
        /// Updates a *Brand Metafield*.  **Required Fields**   * none  **Read-Only Fields** * id * These fields can only be modified by the app (API credentials) that created the metafield:  * namespace  * key  * permission_set  **Usage Notes** * Attempting to modify &#x60;namespace&#x60;, &#x60;key&#x60;, and &#x60;permission_set&#x60; fields using a client ID different from the one used to create those metafields will result in a 403 error message. * The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <returns>Task of ApiResponse (MetafieldResponse1)</returns>
        System.Threading.Tasks.Task<ApiResponse<MetafieldResponse1>> UpdateBrandMetafieldAsyncWithHttpInfo (MetafieldPut1 body, string accept, string contentType, int? metafieldId, int? brandId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class BrandMetafieldsApi : IBrandMetafieldsApi
    {
        private BigCommerce.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BrandMetafieldsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BrandMetafieldsApi(String basePath)
        {
            this.Configuration = new BigCommerce.Client.Configuration { BasePath = basePath };

            ExceptionFactory = BigCommerce.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrandMetafieldsApi"/> class
        /// </summary>
        /// <returns></returns>
        public BrandMetafieldsApi()
        {
            this.Configuration = BigCommerce.Client.Configuration.Default;

            ExceptionFactory = BigCommerce.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrandMetafieldsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BrandMetafieldsApi(BigCommerce.Client.Configuration configuration = null)
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
        /// Create a Brand Metafield Creates a *Brand Metafield*.  **Required Fields** - permission_set - namespace - key - value  **Read-Only Fields** - id  **Note:** The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <returns>MetafieldResponse</returns>
        public MetafieldResponse CreateBrandMetafield (MetafieldPost1 body, string contentType, string accept, int? brandId)
        {
             ApiResponse<MetafieldResponse> localVarResponse = CreateBrandMetafieldWithHttpInfo(body, contentType, accept, brandId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Brand Metafield Creates a *Brand Metafield*.  **Required Fields** - permission_set - namespace - key - value  **Read-Only Fields** - id  **Note:** The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <returns>ApiResponse of MetafieldResponse</returns>
        public ApiResponse< MetafieldResponse > CreateBrandMetafieldWithHttpInfo (MetafieldPost1 body, string contentType, string accept, int? brandId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling BrandMetafieldsApi->CreateBrandMetafield");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling BrandMetafieldsApi->CreateBrandMetafield");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling BrandMetafieldsApi->CreateBrandMetafield");
            // verify the required parameter 'brandId' is set
            if (brandId == null)
                throw new ApiException(400, "Missing required parameter 'brandId' when calling BrandMetafieldsApi->CreateBrandMetafield");

            var localVarPath = "/catalog/brands/{brand_id}/metafields";
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

            if (brandId != null) localVarPathParams.Add("brand_id", this.Configuration.ApiClient.ParameterToString(brandId)); // path parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
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
                Exception exception = ExceptionFactory("CreateBrandMetafield", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MetafieldResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (MetafieldResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MetafieldResponse)));
        }

        /// <summary>
        /// Create a Brand Metafield Creates a *Brand Metafield*.  **Required Fields** - permission_set - namespace - key - value  **Read-Only Fields** - id  **Note:** The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <returns>Task of MetafieldResponse</returns>
        public async System.Threading.Tasks.Task<MetafieldResponse> CreateBrandMetafieldAsync (MetafieldPost1 body, string contentType, string accept, int? brandId)
        {
             ApiResponse<MetafieldResponse> localVarResponse = await CreateBrandMetafieldAsyncWithHttpInfo(body, contentType, accept, brandId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Brand Metafield Creates a *Brand Metafield*.  **Required Fields** - permission_set - namespace - key - value  **Read-Only Fields** - id  **Note:** The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <returns>Task of ApiResponse (MetafieldResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MetafieldResponse>> CreateBrandMetafieldAsyncWithHttpInfo (MetafieldPost1 body, string contentType, string accept, int? brandId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling BrandMetafieldsApi->CreateBrandMetafield");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling BrandMetafieldsApi->CreateBrandMetafield");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling BrandMetafieldsApi->CreateBrandMetafield");
            // verify the required parameter 'brandId' is set
            if (brandId == null)
                throw new ApiException(400, "Missing required parameter 'brandId' when calling BrandMetafieldsApi->CreateBrandMetafield");

            var localVarPath = "/catalog/brands/{brand_id}/metafields";
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

            if (brandId != null) localVarPathParams.Add("brand_id", this.Configuration.ApiClient.ParameterToString(brandId)); // path parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
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
                Exception exception = ExceptionFactory("CreateBrandMetafield", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MetafieldResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (MetafieldResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MetafieldResponse)));
        }

        /// <summary>
        /// Delete a Brand Metafield Deletes a *Brand Metafield*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public void DeleteBrandMetafieldById (int? metafieldId, int? brandId, string accept, string contentType)
        {
             DeleteBrandMetafieldByIdWithHttpInfo(metafieldId, brandId, accept, contentType);
        }

        /// <summary>
        /// Delete a Brand Metafield Deletes a *Brand Metafield*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteBrandMetafieldByIdWithHttpInfo (int? metafieldId, int? brandId, string accept, string contentType)
        {
            // verify the required parameter 'metafieldId' is set
            if (metafieldId == null)
                throw new ApiException(400, "Missing required parameter 'metafieldId' when calling BrandMetafieldsApi->DeleteBrandMetafieldById");
            // verify the required parameter 'brandId' is set
            if (brandId == null)
                throw new ApiException(400, "Missing required parameter 'brandId' when calling BrandMetafieldsApi->DeleteBrandMetafieldById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling BrandMetafieldsApi->DeleteBrandMetafieldById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling BrandMetafieldsApi->DeleteBrandMetafieldById");

            var localVarPath = "/catalog/brands/{brand_id}/metafields/{metafield_id}";
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
            if (brandId != null) localVarPathParams.Add("brand_id", this.Configuration.ApiClient.ParameterToString(brandId)); // path parameter
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
                Exception exception = ExceptionFactory("DeleteBrandMetafieldById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Delete a Brand Metafield Deletes a *Brand Metafield*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteBrandMetafieldByIdAsync (int? metafieldId, int? brandId, string accept, string contentType)
        {
             await DeleteBrandMetafieldByIdAsyncWithHttpInfo(metafieldId, brandId, accept, contentType);

        }

        /// <summary>
        /// Delete a Brand Metafield Deletes a *Brand Metafield*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBrandMetafieldByIdAsyncWithHttpInfo (int? metafieldId, int? brandId, string accept, string contentType)
        {
            // verify the required parameter 'metafieldId' is set
            if (metafieldId == null)
                throw new ApiException(400, "Missing required parameter 'metafieldId' when calling BrandMetafieldsApi->DeleteBrandMetafieldById");
            // verify the required parameter 'brandId' is set
            if (brandId == null)
                throw new ApiException(400, "Missing required parameter 'brandId' when calling BrandMetafieldsApi->DeleteBrandMetafieldById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling BrandMetafieldsApi->DeleteBrandMetafieldById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling BrandMetafieldsApi->DeleteBrandMetafieldById");

            var localVarPath = "/catalog/brands/{brand_id}/metafields/{metafield_id}";
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
            if (brandId != null) localVarPathParams.Add("brand_id", this.Configuration.ApiClient.ParameterToString(brandId)); // path parameter
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
                Exception exception = ExceptionFactory("DeleteBrandMetafieldById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Get a Brand Metafields Returns a *Brand Metafield*. Optional filter parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>MetafieldResponse1</returns>
        public MetafieldResponse1 GetBrandMetafieldByBrandId (int? metafieldId, int? brandId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<MetafieldResponse1> localVarResponse = GetBrandMetafieldByBrandIdWithHttpInfo(metafieldId, brandId, accept, contentType, includeFields, excludeFields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Brand Metafields Returns a *Brand Metafield*. Optional filter parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of MetafieldResponse1</returns>
        public ApiResponse< MetafieldResponse1 > GetBrandMetafieldByBrandIdWithHttpInfo (int? metafieldId, int? brandId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'metafieldId' is set
            if (metafieldId == null)
                throw new ApiException(400, "Missing required parameter 'metafieldId' when calling BrandMetafieldsApi->GetBrandMetafieldByBrandId");
            // verify the required parameter 'brandId' is set
            if (brandId == null)
                throw new ApiException(400, "Missing required parameter 'brandId' when calling BrandMetafieldsApi->GetBrandMetafieldByBrandId");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling BrandMetafieldsApi->GetBrandMetafieldByBrandId");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling BrandMetafieldsApi->GetBrandMetafieldByBrandId");

            var localVarPath = "/catalog/brands/{brand_id}/metafields/{metafield_id}";
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
            if (brandId != null) localVarPathParams.Add("brand_id", this.Configuration.ApiClient.ParameterToString(brandId)); // path parameter
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
                Exception exception = ExceptionFactory("GetBrandMetafieldByBrandId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MetafieldResponse1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (MetafieldResponse1) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MetafieldResponse1)));
        }

        /// <summary>
        /// Get a Brand Metafields Returns a *Brand Metafield*. Optional filter parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of MetafieldResponse1</returns>
        public async System.Threading.Tasks.Task<MetafieldResponse1> GetBrandMetafieldByBrandIdAsync (int? metafieldId, int? brandId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<MetafieldResponse1> localVarResponse = await GetBrandMetafieldByBrandIdAsyncWithHttpInfo(metafieldId, brandId, accept, contentType, includeFields, excludeFields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Brand Metafields Returns a *Brand Metafield*. Optional filter parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (MetafieldResponse1)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MetafieldResponse1>> GetBrandMetafieldByBrandIdAsyncWithHttpInfo (int? metafieldId, int? brandId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'metafieldId' is set
            if (metafieldId == null)
                throw new ApiException(400, "Missing required parameter 'metafieldId' when calling BrandMetafieldsApi->GetBrandMetafieldByBrandId");
            // verify the required parameter 'brandId' is set
            if (brandId == null)
                throw new ApiException(400, "Missing required parameter 'brandId' when calling BrandMetafieldsApi->GetBrandMetafieldByBrandId");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling BrandMetafieldsApi->GetBrandMetafieldByBrandId");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling BrandMetafieldsApi->GetBrandMetafieldByBrandId");

            var localVarPath = "/catalog/brands/{brand_id}/metafields/{metafield_id}";
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
            if (brandId != null) localVarPathParams.Add("brand_id", this.Configuration.ApiClient.ParameterToString(brandId)); // path parameter
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
                Exception exception = ExceptionFactory("GetBrandMetafieldByBrandId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MetafieldResponse1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (MetafieldResponse1) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MetafieldResponse1)));
        }

        /// <summary>
        /// Get All Brand Metafields Returns a list of *Brand Metafields*. Optional filter parameters can be passed in. 
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="key">Filter based on a metafield&#x27;s key.  (optional)</param>
        /// <param name="_namespace">Filter based on a metafield&#x27;s namespace. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>MetaFieldCollectionResponse</returns>
        public MetaFieldCollectionResponse GetBrandMetafieldsByBrandId (int? brandId, string contentType, string accept, int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, int? page = null, int? limit = null, string key = null, string _namespace = null, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<MetaFieldCollectionResponse> localVarResponse = GetBrandMetafieldsByBrandIdWithHttpInfo(brandId, contentType, accept, id, idin, idnotIn, idmin, idmax, idgreater, idless, page, limit, key, _namespace, includeFields, excludeFields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get All Brand Metafields Returns a list of *Brand Metafields*. Optional filter parameters can be passed in. 
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="key">Filter based on a metafield&#x27;s key.  (optional)</param>
        /// <param name="_namespace">Filter based on a metafield&#x27;s namespace. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of MetaFieldCollectionResponse</returns>
        public ApiResponse< MetaFieldCollectionResponse > GetBrandMetafieldsByBrandIdWithHttpInfo (int? brandId, string contentType, string accept, int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, int? page = null, int? limit = null, string key = null, string _namespace = null, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'brandId' is set
            if (brandId == null)
                throw new ApiException(400, "Missing required parameter 'brandId' when calling BrandMetafieldsApi->GetBrandMetafieldsByBrandId");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling BrandMetafieldsApi->GetBrandMetafieldsByBrandId");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling BrandMetafieldsApi->GetBrandMetafieldsByBrandId");

            var localVarPath = "/catalog/brands/{brand_id}/metafields";
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

            if (brandId != null) localVarPathParams.Add("brand_id", this.Configuration.ApiClient.ParameterToString(brandId)); // path parameter
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter
            if (idin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:in", idin)); // query parameter
            if (idnotIn != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:not_in", idnotIn)); // query parameter
            if (idmin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:min", idmin)); // query parameter
            if (idmax != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:max", idmax)); // query parameter
            if (idgreater != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:greater", idgreater)); // query parameter
            if (idless != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:less", idless)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (key != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "key", key)); // query parameter
            if (_namespace != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "namespace", _namespace)); // query parameter
            if (includeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_fields", includeFields)); // query parameter
            if (excludeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "exclude_fields", excludeFields)); // query parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
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
                Exception exception = ExceptionFactory("GetBrandMetafieldsByBrandId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MetaFieldCollectionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (MetaFieldCollectionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MetaFieldCollectionResponse)));
        }

        /// <summary>
        /// Get All Brand Metafields Returns a list of *Brand Metafields*. Optional filter parameters can be passed in. 
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="key">Filter based on a metafield&#x27;s key.  (optional)</param>
        /// <param name="_namespace">Filter based on a metafield&#x27;s namespace. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of MetaFieldCollectionResponse</returns>
        public async System.Threading.Tasks.Task<MetaFieldCollectionResponse> GetBrandMetafieldsByBrandIdAsync (int? brandId, string contentType, string accept, int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, int? page = null, int? limit = null, string key = null, string _namespace = null, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<MetaFieldCollectionResponse> localVarResponse = await GetBrandMetafieldsByBrandIdAsyncWithHttpInfo(brandId, contentType, accept, id, idin, idnotIn, idmin, idmax, idgreater, idless, page, limit, key, _namespace, includeFields, excludeFields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get All Brand Metafields Returns a list of *Brand Metafields*. Optional filter parameters can be passed in. 
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="key">Filter based on a metafield&#x27;s key.  (optional)</param>
        /// <param name="_namespace">Filter based on a metafield&#x27;s namespace. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (MetaFieldCollectionResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MetaFieldCollectionResponse>> GetBrandMetafieldsByBrandIdAsyncWithHttpInfo (int? brandId, string contentType, string accept, int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, int? page = null, int? limit = null, string key = null, string _namespace = null, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'brandId' is set
            if (brandId == null)
                throw new ApiException(400, "Missing required parameter 'brandId' when calling BrandMetafieldsApi->GetBrandMetafieldsByBrandId");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling BrandMetafieldsApi->GetBrandMetafieldsByBrandId");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling BrandMetafieldsApi->GetBrandMetafieldsByBrandId");

            var localVarPath = "/catalog/brands/{brand_id}/metafields";
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

            if (brandId != null) localVarPathParams.Add("brand_id", this.Configuration.ApiClient.ParameterToString(brandId)); // path parameter
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter
            if (idin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:in", idin)); // query parameter
            if (idnotIn != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:not_in", idnotIn)); // query parameter
            if (idmin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:min", idmin)); // query parameter
            if (idmax != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:max", idmax)); // query parameter
            if (idgreater != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:greater", idgreater)); // query parameter
            if (idless != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:less", idless)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (key != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "key", key)); // query parameter
            if (_namespace != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "namespace", _namespace)); // query parameter
            if (includeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_fields", includeFields)); // query parameter
            if (excludeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "exclude_fields", excludeFields)); // query parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
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
                Exception exception = ExceptionFactory("GetBrandMetafieldsByBrandId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MetaFieldCollectionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (MetaFieldCollectionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MetaFieldCollectionResponse)));
        }

        /// <summary>
        /// Update a Brand Metafield Updates a *Brand Metafield*.  **Required Fields**   * none  **Read-Only Fields** * id * These fields can only be modified by the app (API credentials) that created the metafield:  * namespace  * key  * permission_set  **Usage Notes** * Attempting to modify &#x60;namespace&#x60;, &#x60;key&#x60;, and &#x60;permission_set&#x60; fields using a client ID different from the one used to create those metafields will result in a 403 error message. * The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <returns>MetafieldResponse1</returns>
        public MetafieldResponse1 UpdateBrandMetafield (MetafieldPut1 body, string accept, string contentType, int? metafieldId, int? brandId)
        {
             ApiResponse<MetafieldResponse1> localVarResponse = UpdateBrandMetafieldWithHttpInfo(body, accept, contentType, metafieldId, brandId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a Brand Metafield Updates a *Brand Metafield*.  **Required Fields**   * none  **Read-Only Fields** * id * These fields can only be modified by the app (API credentials) that created the metafield:  * namespace  * key  * permission_set  **Usage Notes** * Attempting to modify &#x60;namespace&#x60;, &#x60;key&#x60;, and &#x60;permission_set&#x60; fields using a client ID different from the one used to create those metafields will result in a 403 error message. * The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <returns>ApiResponse of MetafieldResponse1</returns>
        public ApiResponse< MetafieldResponse1 > UpdateBrandMetafieldWithHttpInfo (MetafieldPut1 body, string accept, string contentType, int? metafieldId, int? brandId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling BrandMetafieldsApi->UpdateBrandMetafield");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling BrandMetafieldsApi->UpdateBrandMetafield");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling BrandMetafieldsApi->UpdateBrandMetafield");
            // verify the required parameter 'metafieldId' is set
            if (metafieldId == null)
                throw new ApiException(400, "Missing required parameter 'metafieldId' when calling BrandMetafieldsApi->UpdateBrandMetafield");
            // verify the required parameter 'brandId' is set
            if (brandId == null)
                throw new ApiException(400, "Missing required parameter 'brandId' when calling BrandMetafieldsApi->UpdateBrandMetafield");

            var localVarPath = "/catalog/brands/{brand_id}/metafields/{metafield_id}";
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
            if (brandId != null) localVarPathParams.Add("brand_id", this.Configuration.ApiClient.ParameterToString(brandId)); // path parameter
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
                Exception exception = ExceptionFactory("UpdateBrandMetafield", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MetafieldResponse1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (MetafieldResponse1) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MetafieldResponse1)));
        }

        /// <summary>
        /// Update a Brand Metafield Updates a *Brand Metafield*.  **Required Fields**   * none  **Read-Only Fields** * id * These fields can only be modified by the app (API credentials) that created the metafield:  * namespace  * key  * permission_set  **Usage Notes** * Attempting to modify &#x60;namespace&#x60;, &#x60;key&#x60;, and &#x60;permission_set&#x60; fields using a client ID different from the one used to create those metafields will result in a 403 error message. * The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <returns>Task of MetafieldResponse1</returns>
        public async System.Threading.Tasks.Task<MetafieldResponse1> UpdateBrandMetafieldAsync (MetafieldPut1 body, string accept, string contentType, int? metafieldId, int? brandId)
        {
             ApiResponse<MetafieldResponse1> localVarResponse = await UpdateBrandMetafieldAsyncWithHttpInfo(body, accept, contentType, metafieldId, brandId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a Brand Metafield Updates a *Brand Metafield*.  **Required Fields**   * none  **Read-Only Fields** * id * These fields can only be modified by the app (API credentials) that created the metafield:  * namespace  * key  * permission_set  **Usage Notes** * Attempting to modify &#x60;namespace&#x60;, &#x60;key&#x60;, and &#x60;permission_set&#x60; fields using a client ID different from the one used to create those metafields will result in a 403 error message. * The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="metafieldId">The ID of the &#x60;Metafield&#x60;. </param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <returns>Task of ApiResponse (MetafieldResponse1)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<MetafieldResponse1>> UpdateBrandMetafieldAsyncWithHttpInfo (MetafieldPut1 body, string accept, string contentType, int? metafieldId, int? brandId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling BrandMetafieldsApi->UpdateBrandMetafield");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling BrandMetafieldsApi->UpdateBrandMetafield");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling BrandMetafieldsApi->UpdateBrandMetafield");
            // verify the required parameter 'metafieldId' is set
            if (metafieldId == null)
                throw new ApiException(400, "Missing required parameter 'metafieldId' when calling BrandMetafieldsApi->UpdateBrandMetafield");
            // verify the required parameter 'brandId' is set
            if (brandId == null)
                throw new ApiException(400, "Missing required parameter 'brandId' when calling BrandMetafieldsApi->UpdateBrandMetafield");

            var localVarPath = "/catalog/brands/{brand_id}/metafields/{metafield_id}";
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
            if (brandId != null) localVarPathParams.Add("brand_id", this.Configuration.ApiClient.ParameterToString(brandId)); // path parameter
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
                Exception exception = ExceptionFactory("UpdateBrandMetafield", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<MetafieldResponse1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (MetafieldResponse1) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(MetafieldResponse1)));
        }

    }
}
