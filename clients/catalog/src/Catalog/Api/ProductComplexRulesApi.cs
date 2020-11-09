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
        public interface IProductComplexRulesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a Complex Rule
        /// </summary>
        /// <remarks>
        /// Creates a product *Complex Rule*.  **Required Fields** - modifier_id - modifier_value_id - modifier_value_id - variant_id  **Read-Only Fields** - complex_rule_id - conditions_id - rule_id - combination_id - id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>InlineResponse2005</returns>
        InlineResponse2005 CreateComplexRule (ComplexRule body, string accept, string contentType, int? productId);

        /// <summary>
        /// Create a Complex Rule
        /// </summary>
        /// <remarks>
        /// Creates a product *Complex Rule*.  **Required Fields** - modifier_id - modifier_value_id - modifier_value_id - variant_id  **Read-Only Fields** - complex_rule_id - conditions_id - rule_id - combination_id - id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>ApiResponse of InlineResponse2005</returns>
        ApiResponse<InlineResponse2005> CreateComplexRuleWithHttpInfo (ComplexRule body, string accept, string contentType, int? productId);
        /// <summary>
        /// Delete a Complex Rule
        /// </summary>
        /// <remarks>
        /// Deletes a product *Complex Rule*.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="complexRuleId">The ID of the &#x60;ComplexRule&#x60;. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <returns></returns>
        void DeleteComplexRuleById (int? productId, int? complexRuleId, string contentType, string accept);

        /// <summary>
        /// Delete a Complex Rule
        /// </summary>
        /// <remarks>
        /// Deletes a product *Complex Rule*.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="complexRuleId">The ID of the &#x60;ComplexRule&#x60;. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteComplexRuleByIdWithHttpInfo (int? productId, int? complexRuleId, string contentType, string accept);
        /// <summary>
        /// Get a Complex Rule
        /// </summary>
        /// <remarks>
        /// Returns a single *Complex Rule*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="complexRuleId">The ID of the &#x60;ComplexRule&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>InlineResponse2005</returns>
        InlineResponse2005 GetComplexRuleById (int? productId, int? complexRuleId, string accept, string contentType, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get a Complex Rule
        /// </summary>
        /// <remarks>
        /// Returns a single *Complex Rule*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="complexRuleId">The ID of the &#x60;ComplexRule&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2005</returns>
        ApiResponse<InlineResponse2005> GetComplexRuleByIdWithHttpInfo (int? productId, int? complexRuleId, string accept, string contentType, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Get Complex Rules
        /// </summary>
        /// <remarks>
        /// Returns a list of all product *Complex Rules*. Optional parameters may be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ComplexRuleCollectionResponse</returns>
        ComplexRuleCollectionResponse GetComplexRules (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get Complex Rules
        /// </summary>
        /// <remarks>
        /// Returns a list of all product *Complex Rules*. Optional parameters may be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of ComplexRuleCollectionResponse</returns>
        ApiResponse<ComplexRuleCollectionResponse> GetComplexRulesWithHttpInfo (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Update a Complex Rule
        /// </summary>
        /// <remarks>
        /// Updates a *Complex Rule*.  **Required Fields**: - none  **Read-Only Fields**: - complex_rule_id - conditions_id - rule_id - combination_id - id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="complexRuleId">The ID of the &#x60;ComplexRule&#x60;. </param>
        /// <returns>InlineResponse2005</returns>
        InlineResponse2005 UpdateComplexRule (ComplexRule1 body, int? productId, int? complexRuleId);

        /// <summary>
        /// Update a Complex Rule
        /// </summary>
        /// <remarks>
        /// Updates a *Complex Rule*.  **Required Fields**: - none  **Read-Only Fields**: - complex_rule_id - conditions_id - rule_id - combination_id - id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="complexRuleId">The ID of the &#x60;ComplexRule&#x60;. </param>
        /// <returns>ApiResponse of InlineResponse2005</returns>
        ApiResponse<InlineResponse2005> UpdateComplexRuleWithHttpInfo (ComplexRule1 body, int? productId, int? complexRuleId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create a Complex Rule
        /// </summary>
        /// <remarks>
        /// Creates a product *Complex Rule*.  **Required Fields** - modifier_id - modifier_value_id - modifier_value_id - variant_id  **Read-Only Fields** - complex_rule_id - conditions_id - rule_id - combination_id - id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>Task of InlineResponse2005</returns>
        System.Threading.Tasks.Task<InlineResponse2005> CreateComplexRuleAsync (ComplexRule body, string accept, string contentType, int? productId);

        /// <summary>
        /// Create a Complex Rule
        /// </summary>
        /// <remarks>
        /// Creates a product *Complex Rule*.  **Required Fields** - modifier_id - modifier_value_id - modifier_value_id - variant_id  **Read-Only Fields** - complex_rule_id - conditions_id - rule_id - combination_id - id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>Task of ApiResponse (InlineResponse2005)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2005>> CreateComplexRuleAsyncWithHttpInfo (ComplexRule body, string accept, string contentType, int? productId);
        /// <summary>
        /// Delete a Complex Rule
        /// </summary>
        /// <remarks>
        /// Deletes a product *Complex Rule*.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="complexRuleId">The ID of the &#x60;ComplexRule&#x60;. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteComplexRuleByIdAsync (int? productId, int? complexRuleId, string contentType, string accept);

        /// <summary>
        /// Delete a Complex Rule
        /// </summary>
        /// <remarks>
        /// Deletes a product *Complex Rule*.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="complexRuleId">The ID of the &#x60;ComplexRule&#x60;. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteComplexRuleByIdAsyncWithHttpInfo (int? productId, int? complexRuleId, string contentType, string accept);
        /// <summary>
        /// Get a Complex Rule
        /// </summary>
        /// <remarks>
        /// Returns a single *Complex Rule*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="complexRuleId">The ID of the &#x60;ComplexRule&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of InlineResponse2005</returns>
        System.Threading.Tasks.Task<InlineResponse2005> GetComplexRuleByIdAsync (int? productId, int? complexRuleId, string accept, string contentType, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get a Complex Rule
        /// </summary>
        /// <remarks>
        /// Returns a single *Complex Rule*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="complexRuleId">The ID of the &#x60;ComplexRule&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2005)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2005>> GetComplexRuleByIdAsyncWithHttpInfo (int? productId, int? complexRuleId, string accept, string contentType, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Get Complex Rules
        /// </summary>
        /// <remarks>
        /// Returns a list of all product *Complex Rules*. Optional parameters may be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ComplexRuleCollectionResponse</returns>
        System.Threading.Tasks.Task<ComplexRuleCollectionResponse> GetComplexRulesAsync (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get Complex Rules
        /// </summary>
        /// <remarks>
        /// Returns a list of all product *Complex Rules*. Optional parameters may be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (ComplexRuleCollectionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ComplexRuleCollectionResponse>> GetComplexRulesAsyncWithHttpInfo (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Update a Complex Rule
        /// </summary>
        /// <remarks>
        /// Updates a *Complex Rule*.  **Required Fields**: - none  **Read-Only Fields**: - complex_rule_id - conditions_id - rule_id - combination_id - id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="complexRuleId">The ID of the &#x60;ComplexRule&#x60;. </param>
        /// <returns>Task of InlineResponse2005</returns>
        System.Threading.Tasks.Task<InlineResponse2005> UpdateComplexRuleAsync (ComplexRule1 body, int? productId, int? complexRuleId);

        /// <summary>
        /// Update a Complex Rule
        /// </summary>
        /// <remarks>
        /// Updates a *Complex Rule*.  **Required Fields**: - none  **Read-Only Fields**: - complex_rule_id - conditions_id - rule_id - combination_id - id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="complexRuleId">The ID of the &#x60;ComplexRule&#x60;. </param>
        /// <returns>Task of ApiResponse (InlineResponse2005)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2005>> UpdateComplexRuleAsyncWithHttpInfo (ComplexRule1 body, int? productId, int? complexRuleId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class ProductComplexRulesApi : IProductComplexRulesApi
    {
        private Catalog.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductComplexRulesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductComplexRulesApi(String basePath)
        {
            this.Configuration = new Catalog.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Catalog.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductComplexRulesApi"/> class
        /// </summary>
        /// <returns></returns>
        public ProductComplexRulesApi()
        {
            this.Configuration = Catalog.Client.Configuration.Default;

            ExceptionFactory = Catalog.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductComplexRulesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProductComplexRulesApi(Catalog.Client.Configuration configuration = null)
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
        /// Create a Complex Rule Creates a product *Complex Rule*.  **Required Fields** - modifier_id - modifier_value_id - modifier_value_id - variant_id  **Read-Only Fields** - complex_rule_id - conditions_id - rule_id - combination_id - id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>InlineResponse2005</returns>
        public InlineResponse2005 CreateComplexRule (ComplexRule body, string accept, string contentType, int? productId)
        {
             ApiResponse<InlineResponse2005> localVarResponse = CreateComplexRuleWithHttpInfo(body, accept, contentType, productId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Complex Rule Creates a product *Complex Rule*.  **Required Fields** - modifier_id - modifier_value_id - modifier_value_id - variant_id  **Read-Only Fields** - complex_rule_id - conditions_id - rule_id - combination_id - id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>ApiResponse of InlineResponse2005</returns>
        public ApiResponse< InlineResponse2005 > CreateComplexRuleWithHttpInfo (ComplexRule body, string accept, string contentType, int? productId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductComplexRulesApi->CreateComplexRule");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductComplexRulesApi->CreateComplexRule");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductComplexRulesApi->CreateComplexRule");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductComplexRulesApi->CreateComplexRule");

            var localVarPath = "/catalog/products/{product_id}/complex-rules";
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
                Exception exception = ExceptionFactory("CreateComplexRule", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2005>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2005) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2005)));
        }

        /// <summary>
        /// Create a Complex Rule Creates a product *Complex Rule*.  **Required Fields** - modifier_id - modifier_value_id - modifier_value_id - variant_id  **Read-Only Fields** - complex_rule_id - conditions_id - rule_id - combination_id - id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>Task of InlineResponse2005</returns>
        public async System.Threading.Tasks.Task<InlineResponse2005> CreateComplexRuleAsync (ComplexRule body, string accept, string contentType, int? productId)
        {
             ApiResponse<InlineResponse2005> localVarResponse = await CreateComplexRuleAsyncWithHttpInfo(body, accept, contentType, productId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Complex Rule Creates a product *Complex Rule*.  **Required Fields** - modifier_id - modifier_value_id - modifier_value_id - variant_id  **Read-Only Fields** - complex_rule_id - conditions_id - rule_id - combination_id - id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>Task of ApiResponse (InlineResponse2005)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2005>> CreateComplexRuleAsyncWithHttpInfo (ComplexRule body, string accept, string contentType, int? productId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductComplexRulesApi->CreateComplexRule");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductComplexRulesApi->CreateComplexRule");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductComplexRulesApi->CreateComplexRule");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductComplexRulesApi->CreateComplexRule");

            var localVarPath = "/catalog/products/{product_id}/complex-rules";
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
                Exception exception = ExceptionFactory("CreateComplexRule", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2005>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2005) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2005)));
        }

        /// <summary>
        /// Delete a Complex Rule Deletes a product *Complex Rule*.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="complexRuleId">The ID of the &#x60;ComplexRule&#x60;. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <returns></returns>
        public void DeleteComplexRuleById (int? productId, int? complexRuleId, string contentType, string accept)
        {
             DeleteComplexRuleByIdWithHttpInfo(productId, complexRuleId, contentType, accept);
        }

        /// <summary>
        /// Delete a Complex Rule Deletes a product *Complex Rule*.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="complexRuleId">The ID of the &#x60;ComplexRule&#x60;. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteComplexRuleByIdWithHttpInfo (int? productId, int? complexRuleId, string contentType, string accept)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductComplexRulesApi->DeleteComplexRuleById");
            // verify the required parameter 'complexRuleId' is set
            if (complexRuleId == null)
                throw new ApiException(400, "Missing required parameter 'complexRuleId' when calling ProductComplexRulesApi->DeleteComplexRuleById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductComplexRulesApi->DeleteComplexRuleById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductComplexRulesApi->DeleteComplexRuleById");

            var localVarPath = "/catalog/products/{product_id}/complex-rules/{complex_rule_id}";
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
            if (complexRuleId != null) localVarPathParams.Add("complex_rule_id", this.Configuration.ApiClient.ParameterToString(complexRuleId)); // path parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
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
                Exception exception = ExceptionFactory("DeleteComplexRuleById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Delete a Complex Rule Deletes a product *Complex Rule*.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="complexRuleId">The ID of the &#x60;ComplexRule&#x60;. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteComplexRuleByIdAsync (int? productId, int? complexRuleId, string contentType, string accept)
        {
             await DeleteComplexRuleByIdAsyncWithHttpInfo(productId, complexRuleId, contentType, accept);

        }

        /// <summary>
        /// Delete a Complex Rule Deletes a product *Complex Rule*.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="complexRuleId">The ID of the &#x60;ComplexRule&#x60;. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteComplexRuleByIdAsyncWithHttpInfo (int? productId, int? complexRuleId, string contentType, string accept)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductComplexRulesApi->DeleteComplexRuleById");
            // verify the required parameter 'complexRuleId' is set
            if (complexRuleId == null)
                throw new ApiException(400, "Missing required parameter 'complexRuleId' when calling ProductComplexRulesApi->DeleteComplexRuleById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductComplexRulesApi->DeleteComplexRuleById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductComplexRulesApi->DeleteComplexRuleById");

            var localVarPath = "/catalog/products/{product_id}/complex-rules/{complex_rule_id}";
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
            if (complexRuleId != null) localVarPathParams.Add("complex_rule_id", this.Configuration.ApiClient.ParameterToString(complexRuleId)); // path parameter
            if (contentType != null) localVarHeaderParams.Add("Content-Type", this.Configuration.ApiClient.ParameterToString(contentType)); // header parameter
            if (accept != null) localVarHeaderParams.Add("Accept", this.Configuration.ApiClient.ParameterToString(accept)); // header parameter
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
                Exception exception = ExceptionFactory("DeleteComplexRuleById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Get a Complex Rule Returns a single *Complex Rule*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="complexRuleId">The ID of the &#x60;ComplexRule&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>InlineResponse2005</returns>
        public InlineResponse2005 GetComplexRuleById (int? productId, int? complexRuleId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<InlineResponse2005> localVarResponse = GetComplexRuleByIdWithHttpInfo(productId, complexRuleId, accept, contentType, includeFields, excludeFields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Complex Rule Returns a single *Complex Rule*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="complexRuleId">The ID of the &#x60;ComplexRule&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2005</returns>
        public ApiResponse< InlineResponse2005 > GetComplexRuleByIdWithHttpInfo (int? productId, int? complexRuleId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductComplexRulesApi->GetComplexRuleById");
            // verify the required parameter 'complexRuleId' is set
            if (complexRuleId == null)
                throw new ApiException(400, "Missing required parameter 'complexRuleId' when calling ProductComplexRulesApi->GetComplexRuleById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductComplexRulesApi->GetComplexRuleById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductComplexRulesApi->GetComplexRuleById");

            var localVarPath = "/catalog/products/{product_id}/complex-rules/{complex_rule_id}";
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
            if (complexRuleId != null) localVarPathParams.Add("complex_rule_id", this.Configuration.ApiClient.ParameterToString(complexRuleId)); // path parameter
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
                Exception exception = ExceptionFactory("GetComplexRuleById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2005>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2005) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2005)));
        }

        /// <summary>
        /// Get a Complex Rule Returns a single *Complex Rule*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="complexRuleId">The ID of the &#x60;ComplexRule&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of InlineResponse2005</returns>
        public async System.Threading.Tasks.Task<InlineResponse2005> GetComplexRuleByIdAsync (int? productId, int? complexRuleId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<InlineResponse2005> localVarResponse = await GetComplexRuleByIdAsyncWithHttpInfo(productId, complexRuleId, accept, contentType, includeFields, excludeFields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Complex Rule Returns a single *Complex Rule*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="complexRuleId">The ID of the &#x60;ComplexRule&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2005)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2005>> GetComplexRuleByIdAsyncWithHttpInfo (int? productId, int? complexRuleId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductComplexRulesApi->GetComplexRuleById");
            // verify the required parameter 'complexRuleId' is set
            if (complexRuleId == null)
                throw new ApiException(400, "Missing required parameter 'complexRuleId' when calling ProductComplexRulesApi->GetComplexRuleById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductComplexRulesApi->GetComplexRuleById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductComplexRulesApi->GetComplexRuleById");

            var localVarPath = "/catalog/products/{product_id}/complex-rules/{complex_rule_id}";
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
            if (complexRuleId != null) localVarPathParams.Add("complex_rule_id", this.Configuration.ApiClient.ParameterToString(complexRuleId)); // path parameter
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
                Exception exception = ExceptionFactory("GetComplexRuleById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2005>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2005) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2005)));
        }

        /// <summary>
        /// Get Complex Rules Returns a list of all product *Complex Rules*. Optional parameters may be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ComplexRuleCollectionResponse</returns>
        public ComplexRuleCollectionResponse GetComplexRules (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<ComplexRuleCollectionResponse> localVarResponse = GetComplexRulesWithHttpInfo(productId, accept, contentType, includeFields, excludeFields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Complex Rules Returns a list of all product *Complex Rules*. Optional parameters may be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of ComplexRuleCollectionResponse</returns>
        public ApiResponse< ComplexRuleCollectionResponse > GetComplexRulesWithHttpInfo (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductComplexRulesApi->GetComplexRules");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductComplexRulesApi->GetComplexRules");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductComplexRulesApi->GetComplexRules");

            var localVarPath = "/catalog/products/{product_id}/complex-rules";
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
                Exception exception = ExceptionFactory("GetComplexRules", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ComplexRuleCollectionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ComplexRuleCollectionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ComplexRuleCollectionResponse)));
        }

        /// <summary>
        /// Get Complex Rules Returns a list of all product *Complex Rules*. Optional parameters may be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ComplexRuleCollectionResponse</returns>
        public async System.Threading.Tasks.Task<ComplexRuleCollectionResponse> GetComplexRulesAsync (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<ComplexRuleCollectionResponse> localVarResponse = await GetComplexRulesAsyncWithHttpInfo(productId, accept, contentType, includeFields, excludeFields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Complex Rules Returns a list of all product *Complex Rules*. Optional parameters may be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (ComplexRuleCollectionResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ComplexRuleCollectionResponse>> GetComplexRulesAsyncWithHttpInfo (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductComplexRulesApi->GetComplexRules");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductComplexRulesApi->GetComplexRules");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductComplexRulesApi->GetComplexRules");

            var localVarPath = "/catalog/products/{product_id}/complex-rules";
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
                Exception exception = ExceptionFactory("GetComplexRules", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ComplexRuleCollectionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ComplexRuleCollectionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ComplexRuleCollectionResponse)));
        }

        /// <summary>
        /// Update a Complex Rule Updates a *Complex Rule*.  **Required Fields**: - none  **Read-Only Fields**: - complex_rule_id - conditions_id - rule_id - combination_id - id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="complexRuleId">The ID of the &#x60;ComplexRule&#x60;. </param>
        /// <returns>InlineResponse2005</returns>
        public InlineResponse2005 UpdateComplexRule (ComplexRule1 body, int? productId, int? complexRuleId)
        {
             ApiResponse<InlineResponse2005> localVarResponse = UpdateComplexRuleWithHttpInfo(body, productId, complexRuleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a Complex Rule Updates a *Complex Rule*.  **Required Fields**: - none  **Read-Only Fields**: - complex_rule_id - conditions_id - rule_id - combination_id - id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="complexRuleId">The ID of the &#x60;ComplexRule&#x60;. </param>
        /// <returns>ApiResponse of InlineResponse2005</returns>
        public ApiResponse< InlineResponse2005 > UpdateComplexRuleWithHttpInfo (ComplexRule1 body, int? productId, int? complexRuleId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductComplexRulesApi->UpdateComplexRule");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductComplexRulesApi->UpdateComplexRule");
            // verify the required parameter 'complexRuleId' is set
            if (complexRuleId == null)
                throw new ApiException(400, "Missing required parameter 'complexRuleId' when calling ProductComplexRulesApi->UpdateComplexRule");

            var localVarPath = "/catalog/products/{product_id}/complex-rules/{complex_rule_id}";
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
            if (complexRuleId != null) localVarPathParams.Add("complex_rule_id", this.Configuration.ApiClient.ParameterToString(complexRuleId)); // path parameter
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
                Exception exception = ExceptionFactory("UpdateComplexRule", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2005>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2005) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2005)));
        }

        /// <summary>
        /// Update a Complex Rule Updates a *Complex Rule*.  **Required Fields**: - none  **Read-Only Fields**: - complex_rule_id - conditions_id - rule_id - combination_id - id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="complexRuleId">The ID of the &#x60;ComplexRule&#x60;. </param>
        /// <returns>Task of InlineResponse2005</returns>
        public async System.Threading.Tasks.Task<InlineResponse2005> UpdateComplexRuleAsync (ComplexRule1 body, int? productId, int? complexRuleId)
        {
             ApiResponse<InlineResponse2005> localVarResponse = await UpdateComplexRuleAsyncWithHttpInfo(body, productId, complexRuleId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a Complex Rule Updates a *Complex Rule*.  **Required Fields**: - none  **Read-Only Fields**: - complex_rule_id - conditions_id - rule_id - combination_id - id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="complexRuleId">The ID of the &#x60;ComplexRule&#x60;. </param>
        /// <returns>Task of ApiResponse (InlineResponse2005)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2005>> UpdateComplexRuleAsyncWithHttpInfo (ComplexRule1 body, int? productId, int? complexRuleId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductComplexRulesApi->UpdateComplexRule");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductComplexRulesApi->UpdateComplexRule");
            // verify the required parameter 'complexRuleId' is set
            if (complexRuleId == null)
                throw new ApiException(400, "Missing required parameter 'complexRuleId' when calling ProductComplexRulesApi->UpdateComplexRule");

            var localVarPath = "/catalog/products/{product_id}/complex-rules/{complex_rule_id}";
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
            if (complexRuleId != null) localVarPathParams.Add("complex_rule_id", this.Configuration.ApiClient.ParameterToString(complexRuleId)); // path parameter
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
                Exception exception = ExceptionFactory("UpdateComplexRule", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2005>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2005) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2005)));
        }

    }
}
