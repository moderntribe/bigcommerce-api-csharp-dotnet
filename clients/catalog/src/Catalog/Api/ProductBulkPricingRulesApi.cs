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
        public interface IProductBulkPricingRulesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Creates a Bulk Pricing Rule
        /// </summary>
        /// <remarks>
        /// Creates a *Bulk Pricing Rule*.  **Required Fields** - quantity_min - quantity_max - type - amount  **Read-Only Fields** - id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>InlineResponse2003</returns>
        InlineResponse2003 CreateBulkPricingRule (BulkPricingRuleFull2 body, string accept, string contentType, int? productId, int? page = null, int? limit = null);

        /// <summary>
        /// Creates a Bulk Pricing Rule
        /// </summary>
        /// <remarks>
        /// Creates a *Bulk Pricing Rule*.  **Required Fields** - quantity_min - quantity_max - type - amount  **Read-Only Fields** - id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2003</returns>
        ApiResponse<InlineResponse2003> CreateBulkPricingRuleWithHttpInfo (BulkPricingRuleFull2 body, string accept, string contentType, int? productId, int? page = null, int? limit = null);
        /// <summary>
        /// Delete a Bulk Pricing Rule
        /// </summary>
        /// <remarks>
        /// Deletes a *Bulk Pricing Rule*.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="bulkPricingRuleId">The ID of the &#x60;BulkPricingRule&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void DeleteBulkPricingRuleById (int? productId, int? bulkPricingRuleId, string accept, string contentType);

        /// <summary>
        /// Delete a Bulk Pricing Rule
        /// </summary>
        /// <remarks>
        /// Deletes a *Bulk Pricing Rule*.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="bulkPricingRuleId">The ID of the &#x60;BulkPricingRule&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteBulkPricingRuleByIdWithHttpInfo (int? productId, int? bulkPricingRuleId, string accept, string contentType);
        /// <summary>
        /// Get a Bulk Pricing Rule
        /// </summary>
        /// <remarks>
        /// Returns a single *Bulk Pricing Rule*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="bulkPricingRuleId">The ID of the &#x60;BulkPricingRule&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>InlineResponse2003</returns>
        InlineResponse2003 GetBulkPricingRuleById (int? productId, int? bulkPricingRuleId, string accept, string contentType, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get a Bulk Pricing Rule
        /// </summary>
        /// <remarks>
        /// Returns a single *Bulk Pricing Rule*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="bulkPricingRuleId">The ID of the &#x60;BulkPricingRule&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2003</returns>
        ApiResponse<InlineResponse2003> GetBulkPricingRuleByIdWithHttpInfo (int? productId, int? bulkPricingRuleId, string accept, string contentType, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Get All Bulk Pricing Rules
        /// </summary>
        /// <remarks>
        /// Returns a list of *Bulk Pricing Rules*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>InlineResponse2002</returns>
        InlineResponse2002 GetBulkPricingRules (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get All Bulk Pricing Rules
        /// </summary>
        /// <remarks>
        /// Returns a list of *Bulk Pricing Rules*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        ApiResponse<InlineResponse2002> GetBulkPricingRulesWithHttpInfo (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null, int? page = null, int? limit = null);
        /// <summary>
        /// Update a Bulk Pricing Rule
        /// </summary>
        /// <remarks>
        /// Updates a *Bulk Pricing Rule*.  **Required Fields** * none  **Read-Only Fields** - id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="bulkPricingRuleId">The ID of the &#x60;BulkPricingRule&#x60;. </param>
        /// <returns>InlineResponse2004</returns>
        InlineResponse2004 UpdateBulkPricingRule (BulkPricingRuleFull3 body, string accept, string contentType, int? productId, int? bulkPricingRuleId);

        /// <summary>
        /// Update a Bulk Pricing Rule
        /// </summary>
        /// <remarks>
        /// Updates a *Bulk Pricing Rule*.  **Required Fields** * none  **Read-Only Fields** - id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="bulkPricingRuleId">The ID of the &#x60;BulkPricingRule&#x60;. </param>
        /// <returns>ApiResponse of InlineResponse2004</returns>
        ApiResponse<InlineResponse2004> UpdateBulkPricingRuleWithHttpInfo (BulkPricingRuleFull3 body, string accept, string contentType, int? productId, int? bulkPricingRuleId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Creates a Bulk Pricing Rule
        /// </summary>
        /// <remarks>
        /// Creates a *Bulk Pricing Rule*.  **Required Fields** - quantity_min - quantity_max - type - amount  **Read-Only Fields** - id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>Task of InlineResponse2003</returns>
        System.Threading.Tasks.Task<InlineResponse2003> CreateBulkPricingRuleAsync (BulkPricingRuleFull2 body, string accept, string contentType, int? productId, int? page = null, int? limit = null);

        /// <summary>
        /// Creates a Bulk Pricing Rule
        /// </summary>
        /// <remarks>
        /// Creates a *Bulk Pricing Rule*.  **Required Fields** - quantity_min - quantity_max - type - amount  **Read-Only Fields** - id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2003)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2003>> CreateBulkPricingRuleAsyncWithHttpInfo (BulkPricingRuleFull2 body, string accept, string contentType, int? productId, int? page = null, int? limit = null);
        /// <summary>
        /// Delete a Bulk Pricing Rule
        /// </summary>
        /// <remarks>
        /// Deletes a *Bulk Pricing Rule*.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="bulkPricingRuleId">The ID of the &#x60;BulkPricingRule&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteBulkPricingRuleByIdAsync (int? productId, int? bulkPricingRuleId, string accept, string contentType);

        /// <summary>
        /// Delete a Bulk Pricing Rule
        /// </summary>
        /// <remarks>
        /// Deletes a *Bulk Pricing Rule*.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="bulkPricingRuleId">The ID of the &#x60;BulkPricingRule&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBulkPricingRuleByIdAsyncWithHttpInfo (int? productId, int? bulkPricingRuleId, string accept, string contentType);
        /// <summary>
        /// Get a Bulk Pricing Rule
        /// </summary>
        /// <remarks>
        /// Returns a single *Bulk Pricing Rule*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="bulkPricingRuleId">The ID of the &#x60;BulkPricingRule&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of InlineResponse2003</returns>
        System.Threading.Tasks.Task<InlineResponse2003> GetBulkPricingRuleByIdAsync (int? productId, int? bulkPricingRuleId, string accept, string contentType, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get a Bulk Pricing Rule
        /// </summary>
        /// <remarks>
        /// Returns a single *Bulk Pricing Rule*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="bulkPricingRuleId">The ID of the &#x60;BulkPricingRule&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2003)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2003>> GetBulkPricingRuleByIdAsyncWithHttpInfo (int? productId, int? bulkPricingRuleId, string accept, string contentType, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Get All Bulk Pricing Rules
        /// </summary>
        /// <remarks>
        /// Returns a list of *Bulk Pricing Rules*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>Task of InlineResponse2002</returns>
        System.Threading.Tasks.Task<InlineResponse2002> GetBulkPricingRulesAsync (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get All Bulk Pricing Rules
        /// </summary>
        /// <remarks>
        /// Returns a list of *Bulk Pricing Rules*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> GetBulkPricingRulesAsyncWithHttpInfo (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null, int? page = null, int? limit = null);
        /// <summary>
        /// Update a Bulk Pricing Rule
        /// </summary>
        /// <remarks>
        /// Updates a *Bulk Pricing Rule*.  **Required Fields** * none  **Read-Only Fields** - id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="bulkPricingRuleId">The ID of the &#x60;BulkPricingRule&#x60;. </param>
        /// <returns>Task of InlineResponse2004</returns>
        System.Threading.Tasks.Task<InlineResponse2004> UpdateBulkPricingRuleAsync (BulkPricingRuleFull3 body, string accept, string contentType, int? productId, int? bulkPricingRuleId);

        /// <summary>
        /// Update a Bulk Pricing Rule
        /// </summary>
        /// <remarks>
        /// Updates a *Bulk Pricing Rule*.  **Required Fields** * none  **Read-Only Fields** - id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="bulkPricingRuleId">The ID of the &#x60;BulkPricingRule&#x60;. </param>
        /// <returns>Task of ApiResponse (InlineResponse2004)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2004>> UpdateBulkPricingRuleAsyncWithHttpInfo (BulkPricingRuleFull3 body, string accept, string contentType, int? productId, int? bulkPricingRuleId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class ProductBulkPricingRulesApi : IProductBulkPricingRulesApi
    {
        private Catalog.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductBulkPricingRulesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductBulkPricingRulesApi(String basePath)
        {
            this.Configuration = new Catalog.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Catalog.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductBulkPricingRulesApi"/> class
        /// </summary>
        /// <returns></returns>
        public ProductBulkPricingRulesApi()
        {
            this.Configuration = Catalog.Client.Configuration.Default;

            ExceptionFactory = Catalog.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductBulkPricingRulesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProductBulkPricingRulesApi(Catalog.Client.Configuration configuration = null)
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
        /// Creates a Bulk Pricing Rule Creates a *Bulk Pricing Rule*.  **Required Fields** - quantity_min - quantity_max - type - amount  **Read-Only Fields** - id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>InlineResponse2003</returns>
        public InlineResponse2003 CreateBulkPricingRule (BulkPricingRuleFull2 body, string accept, string contentType, int? productId, int? page = null, int? limit = null)
        {
             ApiResponse<InlineResponse2003> localVarResponse = CreateBulkPricingRuleWithHttpInfo(body, accept, contentType, productId, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Creates a Bulk Pricing Rule Creates a *Bulk Pricing Rule*.  **Required Fields** - quantity_min - quantity_max - type - amount  **Read-Only Fields** - id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2003</returns>
        public ApiResponse< InlineResponse2003 > CreateBulkPricingRuleWithHttpInfo (BulkPricingRuleFull2 body, string accept, string contentType, int? productId, int? page = null, int? limit = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductBulkPricingRulesApi->CreateBulkPricingRule");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductBulkPricingRulesApi->CreateBulkPricingRule");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductBulkPricingRulesApi->CreateBulkPricingRule");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductBulkPricingRulesApi->CreateBulkPricingRule");

            var localVarPath = "/catalog/products/{product_id}/bulk-pricing-rules";
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
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
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
                Exception exception = ExceptionFactory("CreateBulkPricingRule", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2003>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2003) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2003)));
        }

        /// <summary>
        /// Creates a Bulk Pricing Rule Creates a *Bulk Pricing Rule*.  **Required Fields** - quantity_min - quantity_max - type - amount  **Read-Only Fields** - id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>Task of InlineResponse2003</returns>
        public async System.Threading.Tasks.Task<InlineResponse2003> CreateBulkPricingRuleAsync (BulkPricingRuleFull2 body, string accept, string contentType, int? productId, int? page = null, int? limit = null)
        {
             ApiResponse<InlineResponse2003> localVarResponse = await CreateBulkPricingRuleAsyncWithHttpInfo(body, accept, contentType, productId, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Creates a Bulk Pricing Rule Creates a *Bulk Pricing Rule*.  **Required Fields** - quantity_min - quantity_max - type - amount  **Read-Only Fields** - id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2003)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2003>> CreateBulkPricingRuleAsyncWithHttpInfo (BulkPricingRuleFull2 body, string accept, string contentType, int? productId, int? page = null, int? limit = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductBulkPricingRulesApi->CreateBulkPricingRule");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductBulkPricingRulesApi->CreateBulkPricingRule");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductBulkPricingRulesApi->CreateBulkPricingRule");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductBulkPricingRulesApi->CreateBulkPricingRule");

            var localVarPath = "/catalog/products/{product_id}/bulk-pricing-rules";
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
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
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
                Exception exception = ExceptionFactory("CreateBulkPricingRule", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2003>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2003) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2003)));
        }

        /// <summary>
        /// Delete a Bulk Pricing Rule Deletes a *Bulk Pricing Rule*.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="bulkPricingRuleId">The ID of the &#x60;BulkPricingRule&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public void DeleteBulkPricingRuleById (int? productId, int? bulkPricingRuleId, string accept, string contentType)
        {
             DeleteBulkPricingRuleByIdWithHttpInfo(productId, bulkPricingRuleId, accept, contentType);
        }

        /// <summary>
        /// Delete a Bulk Pricing Rule Deletes a *Bulk Pricing Rule*.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="bulkPricingRuleId">The ID of the &#x60;BulkPricingRule&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteBulkPricingRuleByIdWithHttpInfo (int? productId, int? bulkPricingRuleId, string accept, string contentType)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductBulkPricingRulesApi->DeleteBulkPricingRuleById");
            // verify the required parameter 'bulkPricingRuleId' is set
            if (bulkPricingRuleId == null)
                throw new ApiException(400, "Missing required parameter 'bulkPricingRuleId' when calling ProductBulkPricingRulesApi->DeleteBulkPricingRuleById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductBulkPricingRulesApi->DeleteBulkPricingRuleById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductBulkPricingRulesApi->DeleteBulkPricingRuleById");

            var localVarPath = "/catalog/products/{product_id}/bulk-pricing-rules/{bulk_pricing_rule_id}";
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
            if (bulkPricingRuleId != null) localVarPathParams.Add("bulk_pricing_rule_id", this.Configuration.ApiClient.ParameterToString(bulkPricingRuleId)); // path parameter
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
                Exception exception = ExceptionFactory("DeleteBulkPricingRuleById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Delete a Bulk Pricing Rule Deletes a *Bulk Pricing Rule*.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="bulkPricingRuleId">The ID of the &#x60;BulkPricingRule&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteBulkPricingRuleByIdAsync (int? productId, int? bulkPricingRuleId, string accept, string contentType)
        {
             await DeleteBulkPricingRuleByIdAsyncWithHttpInfo(productId, bulkPricingRuleId, accept, contentType);

        }

        /// <summary>
        /// Delete a Bulk Pricing Rule Deletes a *Bulk Pricing Rule*.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="bulkPricingRuleId">The ID of the &#x60;BulkPricingRule&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBulkPricingRuleByIdAsyncWithHttpInfo (int? productId, int? bulkPricingRuleId, string accept, string contentType)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductBulkPricingRulesApi->DeleteBulkPricingRuleById");
            // verify the required parameter 'bulkPricingRuleId' is set
            if (bulkPricingRuleId == null)
                throw new ApiException(400, "Missing required parameter 'bulkPricingRuleId' when calling ProductBulkPricingRulesApi->DeleteBulkPricingRuleById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductBulkPricingRulesApi->DeleteBulkPricingRuleById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductBulkPricingRulesApi->DeleteBulkPricingRuleById");

            var localVarPath = "/catalog/products/{product_id}/bulk-pricing-rules/{bulk_pricing_rule_id}";
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
            if (bulkPricingRuleId != null) localVarPathParams.Add("bulk_pricing_rule_id", this.Configuration.ApiClient.ParameterToString(bulkPricingRuleId)); // path parameter
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
                Exception exception = ExceptionFactory("DeleteBulkPricingRuleById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Get a Bulk Pricing Rule Returns a single *Bulk Pricing Rule*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="bulkPricingRuleId">The ID of the &#x60;BulkPricingRule&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>InlineResponse2003</returns>
        public InlineResponse2003 GetBulkPricingRuleById (int? productId, int? bulkPricingRuleId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<InlineResponse2003> localVarResponse = GetBulkPricingRuleByIdWithHttpInfo(productId, bulkPricingRuleId, accept, contentType, includeFields, excludeFields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Bulk Pricing Rule Returns a single *Bulk Pricing Rule*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="bulkPricingRuleId">The ID of the &#x60;BulkPricingRule&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2003</returns>
        public ApiResponse< InlineResponse2003 > GetBulkPricingRuleByIdWithHttpInfo (int? productId, int? bulkPricingRuleId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductBulkPricingRulesApi->GetBulkPricingRuleById");
            // verify the required parameter 'bulkPricingRuleId' is set
            if (bulkPricingRuleId == null)
                throw new ApiException(400, "Missing required parameter 'bulkPricingRuleId' when calling ProductBulkPricingRulesApi->GetBulkPricingRuleById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductBulkPricingRulesApi->GetBulkPricingRuleById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductBulkPricingRulesApi->GetBulkPricingRuleById");

            var localVarPath = "/catalog/products/{product_id}/bulk-pricing-rules/{bulk_pricing_rule_id}";
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
            if (bulkPricingRuleId != null) localVarPathParams.Add("bulk_pricing_rule_id", this.Configuration.ApiClient.ParameterToString(bulkPricingRuleId)); // path parameter
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
                Exception exception = ExceptionFactory("GetBulkPricingRuleById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2003>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2003) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2003)));
        }

        /// <summary>
        /// Get a Bulk Pricing Rule Returns a single *Bulk Pricing Rule*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="bulkPricingRuleId">The ID of the &#x60;BulkPricingRule&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of InlineResponse2003</returns>
        public async System.Threading.Tasks.Task<InlineResponse2003> GetBulkPricingRuleByIdAsync (int? productId, int? bulkPricingRuleId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<InlineResponse2003> localVarResponse = await GetBulkPricingRuleByIdAsyncWithHttpInfo(productId, bulkPricingRuleId, accept, contentType, includeFields, excludeFields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Bulk Pricing Rule Returns a single *Bulk Pricing Rule*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="bulkPricingRuleId">The ID of the &#x60;BulkPricingRule&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2003)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2003>> GetBulkPricingRuleByIdAsyncWithHttpInfo (int? productId, int? bulkPricingRuleId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductBulkPricingRulesApi->GetBulkPricingRuleById");
            // verify the required parameter 'bulkPricingRuleId' is set
            if (bulkPricingRuleId == null)
                throw new ApiException(400, "Missing required parameter 'bulkPricingRuleId' when calling ProductBulkPricingRulesApi->GetBulkPricingRuleById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductBulkPricingRulesApi->GetBulkPricingRuleById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductBulkPricingRulesApi->GetBulkPricingRuleById");

            var localVarPath = "/catalog/products/{product_id}/bulk-pricing-rules/{bulk_pricing_rule_id}";
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
            if (bulkPricingRuleId != null) localVarPathParams.Add("bulk_pricing_rule_id", this.Configuration.ApiClient.ParameterToString(bulkPricingRuleId)); // path parameter
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
                Exception exception = ExceptionFactory("GetBulkPricingRuleById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2003>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2003) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2003)));
        }

        /// <summary>
        /// Get All Bulk Pricing Rules Returns a list of *Bulk Pricing Rules*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>InlineResponse2002</returns>
        public InlineResponse2002 GetBulkPricingRules (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null, int? page = null, int? limit = null)
        {
             ApiResponse<InlineResponse2002> localVarResponse = GetBulkPricingRulesWithHttpInfo(productId, accept, contentType, includeFields, excludeFields, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get All Bulk Pricing Rules Returns a list of *Bulk Pricing Rules*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2002</returns>
        public ApiResponse< InlineResponse2002 > GetBulkPricingRulesWithHttpInfo (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductBulkPricingRulesApi->GetBulkPricingRules");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductBulkPricingRulesApi->GetBulkPricingRules");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductBulkPricingRulesApi->GetBulkPricingRules");

            var localVarPath = "/catalog/products/{product_id}/bulk-pricing-rules";
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
            if (includeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_fields", includeFields)); // query parameter
            if (excludeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "exclude_fields", excludeFields)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
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
                Exception exception = ExceptionFactory("GetBulkPricingRules", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2002>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2002) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2002)));
        }

        /// <summary>
        /// Get All Bulk Pricing Rules Returns a list of *Bulk Pricing Rules*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>Task of InlineResponse2002</returns>
        public async System.Threading.Tasks.Task<InlineResponse2002> GetBulkPricingRulesAsync (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null, int? page = null, int? limit = null)
        {
             ApiResponse<InlineResponse2002> localVarResponse = await GetBulkPricingRulesAsyncWithHttpInfo(productId, accept, contentType, includeFields, excludeFields, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get All Bulk Pricing Rules Returns a list of *Bulk Pricing Rules*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2002)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2002>> GetBulkPricingRulesAsyncWithHttpInfo (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductBulkPricingRulesApi->GetBulkPricingRules");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductBulkPricingRulesApi->GetBulkPricingRules");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductBulkPricingRulesApi->GetBulkPricingRules");

            var localVarPath = "/catalog/products/{product_id}/bulk-pricing-rules";
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
            if (includeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_fields", includeFields)); // query parameter
            if (excludeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "exclude_fields", excludeFields)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
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
                Exception exception = ExceptionFactory("GetBulkPricingRules", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2002>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2002) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2002)));
        }

        /// <summary>
        /// Update a Bulk Pricing Rule Updates a *Bulk Pricing Rule*.  **Required Fields** * none  **Read-Only Fields** - id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="bulkPricingRuleId">The ID of the &#x60;BulkPricingRule&#x60;. </param>
        /// <returns>InlineResponse2004</returns>
        public InlineResponse2004 UpdateBulkPricingRule (BulkPricingRuleFull3 body, string accept, string contentType, int? productId, int? bulkPricingRuleId)
        {
             ApiResponse<InlineResponse2004> localVarResponse = UpdateBulkPricingRuleWithHttpInfo(body, accept, contentType, productId, bulkPricingRuleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a Bulk Pricing Rule Updates a *Bulk Pricing Rule*.  **Required Fields** * none  **Read-Only Fields** - id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="bulkPricingRuleId">The ID of the &#x60;BulkPricingRule&#x60;. </param>
        /// <returns>ApiResponse of InlineResponse2004</returns>
        public ApiResponse< InlineResponse2004 > UpdateBulkPricingRuleWithHttpInfo (BulkPricingRuleFull3 body, string accept, string contentType, int? productId, int? bulkPricingRuleId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductBulkPricingRulesApi->UpdateBulkPricingRule");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductBulkPricingRulesApi->UpdateBulkPricingRule");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductBulkPricingRulesApi->UpdateBulkPricingRule");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductBulkPricingRulesApi->UpdateBulkPricingRule");
            // verify the required parameter 'bulkPricingRuleId' is set
            if (bulkPricingRuleId == null)
                throw new ApiException(400, "Missing required parameter 'bulkPricingRuleId' when calling ProductBulkPricingRulesApi->UpdateBulkPricingRule");

            var localVarPath = "/catalog/products/{product_id}/bulk-pricing-rules/{bulk_pricing_rule_id}";
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
            if (bulkPricingRuleId != null) localVarPathParams.Add("bulk_pricing_rule_id", this.Configuration.ApiClient.ParameterToString(bulkPricingRuleId)); // path parameter
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
                Exception exception = ExceptionFactory("UpdateBulkPricingRule", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2004>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2004) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2004)));
        }

        /// <summary>
        /// Update a Bulk Pricing Rule Updates a *Bulk Pricing Rule*.  **Required Fields** * none  **Read-Only Fields** - id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="bulkPricingRuleId">The ID of the &#x60;BulkPricingRule&#x60;. </param>
        /// <returns>Task of InlineResponse2004</returns>
        public async System.Threading.Tasks.Task<InlineResponse2004> UpdateBulkPricingRuleAsync (BulkPricingRuleFull3 body, string accept, string contentType, int? productId, int? bulkPricingRuleId)
        {
             ApiResponse<InlineResponse2004> localVarResponse = await UpdateBulkPricingRuleAsyncWithHttpInfo(body, accept, contentType, productId, bulkPricingRuleId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a Bulk Pricing Rule Updates a *Bulk Pricing Rule*.  **Required Fields** * none  **Read-Only Fields** - id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="bulkPricingRuleId">The ID of the &#x60;BulkPricingRule&#x60;. </param>
        /// <returns>Task of ApiResponse (InlineResponse2004)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2004>> UpdateBulkPricingRuleAsyncWithHttpInfo (BulkPricingRuleFull3 body, string accept, string contentType, int? productId, int? bulkPricingRuleId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductBulkPricingRulesApi->UpdateBulkPricingRule");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductBulkPricingRulesApi->UpdateBulkPricingRule");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductBulkPricingRulesApi->UpdateBulkPricingRule");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductBulkPricingRulesApi->UpdateBulkPricingRule");
            // verify the required parameter 'bulkPricingRuleId' is set
            if (bulkPricingRuleId == null)
                throw new ApiException(400, "Missing required parameter 'bulkPricingRuleId' when calling ProductBulkPricingRulesApi->UpdateBulkPricingRule");

            var localVarPath = "/catalog/products/{product_id}/bulk-pricing-rules/{bulk_pricing_rule_id}";
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
            if (bulkPricingRuleId != null) localVarPathParams.Add("bulk_pricing_rule_id", this.Configuration.ApiClient.ParameterToString(bulkPricingRuleId)); // path parameter
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
                Exception exception = ExceptionFactory("UpdateBulkPricingRule", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2004>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2004) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2004)));
        }

    }
}
