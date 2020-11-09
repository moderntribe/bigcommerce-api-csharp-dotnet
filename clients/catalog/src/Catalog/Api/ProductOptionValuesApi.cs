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
        public interface IProductOptionValuesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create Product Option Values
        /// </summary>
        /// <remarks>
        /// Creates a *Variant Option Value*.  **Required Fields** * label * sort_order  **Read-Only Fields** * id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <returns>OptionValueResponse</returns>
        OptionValueResponse CreateOptionValue (OptionValuePost body, string accept, string contentType, int? productId, int? optionId);

        /// <summary>
        /// Create Product Option Values
        /// </summary>
        /// <remarks>
        /// Creates a *Variant Option Value*.  **Required Fields** * label * sort_order  **Read-Only Fields** * id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <returns>ApiResponse of OptionValueResponse</returns>
        ApiResponse<OptionValueResponse> CreateOptionValueWithHttpInfo (OptionValuePost body, string accept, string contentType, int? productId, int? optionId);
        /// <summary>
        /// Delete a Product Option Value
        /// </summary>
        /// <remarks>
        /// Deletea a *Variant Option Value*.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void DeleteOptionValueById (int? productId, int? optionId, int? valueId, string accept, string contentType);

        /// <summary>
        /// Delete a Product Option Value
        /// </summary>
        /// <remarks>
        /// Deletea a *Variant Option Value*.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteOptionValueByIdWithHttpInfo (int? productId, int? optionId, int? valueId, string accept, string contentType);
        /// <summary>
        /// Get a Product Option Value
        /// </summary>
        /// <remarks>
        /// Returns a single *Variant Option Value*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>OptionValueResponse</returns>
        OptionValueResponse GetOptionValueById (int? productId, int? optionId, int? valueId, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get a Product Option Value
        /// </summary>
        /// <remarks>
        /// Returns a single *Variant Option Value*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of OptionValueResponse</returns>
        ApiResponse<OptionValueResponse> GetOptionValueByIdWithHttpInfo (int? productId, int? optionId, int? valueId, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Get all Product Option Values
        /// </summary>
        /// <remarks>
        /// Returns a list of all *Variant Option Values*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>OptionValueCollectionResponse</returns>
        OptionValueCollectionResponse GetOptionValues (int? productId, int? optionId, string accept, string contentType, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get all Product Option Values
        /// </summary>
        /// <remarks>
        /// Returns a list of all *Variant Option Values*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of OptionValueCollectionResponse</returns>
        ApiResponse<OptionValueCollectionResponse> GetOptionValuesWithHttpInfo (int? productId, int? optionId, string accept, string contentType, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Update a Product Option Value
        /// </summary>
        /// <remarks>
        /// Updates a *Variant Option Value*.  **Read-Only Fields** * id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A BigCommerce &#x60;OptionValue&#x60; object.
</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <returns>OptionValueResponse</returns>
        OptionValueResponse UpdateOptionValue (OptionValuePut body, string accept, string contentType, int? productId, int? optionId, int? valueId);

        /// <summary>
        /// Update a Product Option Value
        /// </summary>
        /// <remarks>
        /// Updates a *Variant Option Value*.  **Read-Only Fields** * id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A BigCommerce &#x60;OptionValue&#x60; object.
</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <returns>ApiResponse of OptionValueResponse</returns>
        ApiResponse<OptionValueResponse> UpdateOptionValueWithHttpInfo (OptionValuePut body, string accept, string contentType, int? productId, int? optionId, int? valueId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create Product Option Values
        /// </summary>
        /// <remarks>
        /// Creates a *Variant Option Value*.  **Required Fields** * label * sort_order  **Read-Only Fields** * id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <returns>Task of OptionValueResponse</returns>
        System.Threading.Tasks.Task<OptionValueResponse> CreateOptionValueAsync (OptionValuePost body, string accept, string contentType, int? productId, int? optionId);

        /// <summary>
        /// Create Product Option Values
        /// </summary>
        /// <remarks>
        /// Creates a *Variant Option Value*.  **Required Fields** * label * sort_order  **Read-Only Fields** * id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <returns>Task of ApiResponse (OptionValueResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OptionValueResponse>> CreateOptionValueAsyncWithHttpInfo (OptionValuePost body, string accept, string contentType, int? productId, int? optionId);
        /// <summary>
        /// Delete a Product Option Value
        /// </summary>
        /// <remarks>
        /// Deletea a *Variant Option Value*.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteOptionValueByIdAsync (int? productId, int? optionId, int? valueId, string accept, string contentType);

        /// <summary>
        /// Delete a Product Option Value
        /// </summary>
        /// <remarks>
        /// Deletea a *Variant Option Value*.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOptionValueByIdAsyncWithHttpInfo (int? productId, int? optionId, int? valueId, string accept, string contentType);
        /// <summary>
        /// Get a Product Option Value
        /// </summary>
        /// <remarks>
        /// Returns a single *Variant Option Value*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of OptionValueResponse</returns>
        System.Threading.Tasks.Task<OptionValueResponse> GetOptionValueByIdAsync (int? productId, int? optionId, int? valueId, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get a Product Option Value
        /// </summary>
        /// <remarks>
        /// Returns a single *Variant Option Value*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (OptionValueResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OptionValueResponse>> GetOptionValueByIdAsyncWithHttpInfo (int? productId, int? optionId, int? valueId, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Get all Product Option Values
        /// </summary>
        /// <remarks>
        /// Returns a list of all *Variant Option Values*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of OptionValueCollectionResponse</returns>
        System.Threading.Tasks.Task<OptionValueCollectionResponse> GetOptionValuesAsync (int? productId, int? optionId, string accept, string contentType, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get all Product Option Values
        /// </summary>
        /// <remarks>
        /// Returns a list of all *Variant Option Values*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (OptionValueCollectionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OptionValueCollectionResponse>> GetOptionValuesAsyncWithHttpInfo (int? productId, int? optionId, string accept, string contentType, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Update a Product Option Value
        /// </summary>
        /// <remarks>
        /// Updates a *Variant Option Value*.  **Read-Only Fields** * id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A BigCommerce &#x60;OptionValue&#x60; object.
</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <returns>Task of OptionValueResponse</returns>
        System.Threading.Tasks.Task<OptionValueResponse> UpdateOptionValueAsync (OptionValuePut body, string accept, string contentType, int? productId, int? optionId, int? valueId);

        /// <summary>
        /// Update a Product Option Value
        /// </summary>
        /// <remarks>
        /// Updates a *Variant Option Value*.  **Read-Only Fields** * id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A BigCommerce &#x60;OptionValue&#x60; object.
</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <returns>Task of ApiResponse (OptionValueResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<OptionValueResponse>> UpdateOptionValueAsyncWithHttpInfo (OptionValuePut body, string accept, string contentType, int? productId, int? optionId, int? valueId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class ProductOptionValuesApi : IProductOptionValuesApi
    {
        private Catalog.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductOptionValuesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductOptionValuesApi(String basePath)
        {
            this.Configuration = new Catalog.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Catalog.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductOptionValuesApi"/> class
        /// </summary>
        /// <returns></returns>
        public ProductOptionValuesApi()
        {
            this.Configuration = Catalog.Client.Configuration.Default;

            ExceptionFactory = Catalog.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductOptionValuesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProductOptionValuesApi(Catalog.Client.Configuration configuration = null)
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
        /// Create Product Option Values Creates a *Variant Option Value*.  **Required Fields** * label * sort_order  **Read-Only Fields** * id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <returns>OptionValueResponse</returns>
        public OptionValueResponse CreateOptionValue (OptionValuePost body, string accept, string contentType, int? productId, int? optionId)
        {
             ApiResponse<OptionValueResponse> localVarResponse = CreateOptionValueWithHttpInfo(body, accept, contentType, productId, optionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Product Option Values Creates a *Variant Option Value*.  **Required Fields** * label * sort_order  **Read-Only Fields** * id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <returns>ApiResponse of OptionValueResponse</returns>
        public ApiResponse< OptionValueResponse > CreateOptionValueWithHttpInfo (OptionValuePost body, string accept, string contentType, int? productId, int? optionId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductOptionValuesApi->CreateOptionValue");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductOptionValuesApi->CreateOptionValue");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductOptionValuesApi->CreateOptionValue");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductOptionValuesApi->CreateOptionValue");
            // verify the required parameter 'optionId' is set
            if (optionId == null)
                throw new ApiException(400, "Missing required parameter 'optionId' when calling ProductOptionValuesApi->CreateOptionValue");

            var localVarPath = "/catalog/products/{product_id}/options/{option_id}/values";
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
            if (optionId != null) localVarPathParams.Add("option_id", this.Configuration.ApiClient.ParameterToString(optionId)); // path parameter
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
                Exception exception = ExceptionFactory("CreateOptionValue", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OptionValueResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (OptionValueResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptionValueResponse)));
        }

        /// <summary>
        /// Create Product Option Values Creates a *Variant Option Value*.  **Required Fields** * label * sort_order  **Read-Only Fields** * id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <returns>Task of OptionValueResponse</returns>
        public async System.Threading.Tasks.Task<OptionValueResponse> CreateOptionValueAsync (OptionValuePost body, string accept, string contentType, int? productId, int? optionId)
        {
             ApiResponse<OptionValueResponse> localVarResponse = await CreateOptionValueAsyncWithHttpInfo(body, accept, contentType, productId, optionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Product Option Values Creates a *Variant Option Value*.  **Required Fields** * label * sort_order  **Read-Only Fields** * id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <returns>Task of ApiResponse (OptionValueResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OptionValueResponse>> CreateOptionValueAsyncWithHttpInfo (OptionValuePost body, string accept, string contentType, int? productId, int? optionId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductOptionValuesApi->CreateOptionValue");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductOptionValuesApi->CreateOptionValue");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductOptionValuesApi->CreateOptionValue");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductOptionValuesApi->CreateOptionValue");
            // verify the required parameter 'optionId' is set
            if (optionId == null)
                throw new ApiException(400, "Missing required parameter 'optionId' when calling ProductOptionValuesApi->CreateOptionValue");

            var localVarPath = "/catalog/products/{product_id}/options/{option_id}/values";
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
            if (optionId != null) localVarPathParams.Add("option_id", this.Configuration.ApiClient.ParameterToString(optionId)); // path parameter
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
                Exception exception = ExceptionFactory("CreateOptionValue", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OptionValueResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (OptionValueResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptionValueResponse)));
        }

        /// <summary>
        /// Delete a Product Option Value Deletea a *Variant Option Value*.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public void DeleteOptionValueById (int? productId, int? optionId, int? valueId, string accept, string contentType)
        {
             DeleteOptionValueByIdWithHttpInfo(productId, optionId, valueId, accept, contentType);
        }

        /// <summary>
        /// Delete a Product Option Value Deletea a *Variant Option Value*.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteOptionValueByIdWithHttpInfo (int? productId, int? optionId, int? valueId, string accept, string contentType)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductOptionValuesApi->DeleteOptionValueById");
            // verify the required parameter 'optionId' is set
            if (optionId == null)
                throw new ApiException(400, "Missing required parameter 'optionId' when calling ProductOptionValuesApi->DeleteOptionValueById");
            // verify the required parameter 'valueId' is set
            if (valueId == null)
                throw new ApiException(400, "Missing required parameter 'valueId' when calling ProductOptionValuesApi->DeleteOptionValueById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductOptionValuesApi->DeleteOptionValueById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductOptionValuesApi->DeleteOptionValueById");

            var localVarPath = "/catalog/products/{product_id}/options/{option_id}/values/{value_id}";
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
            if (optionId != null) localVarPathParams.Add("option_id", this.Configuration.ApiClient.ParameterToString(optionId)); // path parameter
            if (valueId != null) localVarPathParams.Add("value_id", this.Configuration.ApiClient.ParameterToString(valueId)); // path parameter
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
                Exception exception = ExceptionFactory("DeleteOptionValueById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Delete a Product Option Value Deletea a *Variant Option Value*.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteOptionValueByIdAsync (int? productId, int? optionId, int? valueId, string accept, string contentType)
        {
             await DeleteOptionValueByIdAsyncWithHttpInfo(productId, optionId, valueId, accept, contentType);

        }

        /// <summary>
        /// Delete a Product Option Value Deletea a *Variant Option Value*.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteOptionValueByIdAsyncWithHttpInfo (int? productId, int? optionId, int? valueId, string accept, string contentType)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductOptionValuesApi->DeleteOptionValueById");
            // verify the required parameter 'optionId' is set
            if (optionId == null)
                throw new ApiException(400, "Missing required parameter 'optionId' when calling ProductOptionValuesApi->DeleteOptionValueById");
            // verify the required parameter 'valueId' is set
            if (valueId == null)
                throw new ApiException(400, "Missing required parameter 'valueId' when calling ProductOptionValuesApi->DeleteOptionValueById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductOptionValuesApi->DeleteOptionValueById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductOptionValuesApi->DeleteOptionValueById");

            var localVarPath = "/catalog/products/{product_id}/options/{option_id}/values/{value_id}";
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
            if (optionId != null) localVarPathParams.Add("option_id", this.Configuration.ApiClient.ParameterToString(optionId)); // path parameter
            if (valueId != null) localVarPathParams.Add("value_id", this.Configuration.ApiClient.ParameterToString(valueId)); // path parameter
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
                Exception exception = ExceptionFactory("DeleteOptionValueById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Get a Product Option Value Returns a single *Variant Option Value*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>OptionValueResponse</returns>
        public OptionValueResponse GetOptionValueById (int? productId, int? optionId, int? valueId, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<OptionValueResponse> localVarResponse = GetOptionValueByIdWithHttpInfo(productId, optionId, valueId, includeFields, excludeFields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Product Option Value Returns a single *Variant Option Value*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of OptionValueResponse</returns>
        public ApiResponse< OptionValueResponse > GetOptionValueByIdWithHttpInfo (int? productId, int? optionId, int? valueId, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductOptionValuesApi->GetOptionValueById");
            // verify the required parameter 'optionId' is set
            if (optionId == null)
                throw new ApiException(400, "Missing required parameter 'optionId' when calling ProductOptionValuesApi->GetOptionValueById");
            // verify the required parameter 'valueId' is set
            if (valueId == null)
                throw new ApiException(400, "Missing required parameter 'valueId' when calling ProductOptionValuesApi->GetOptionValueById");

            var localVarPath = "/catalog/products/{product_id}/options/{option_id}/values/{value_id}";
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
            if (optionId != null) localVarPathParams.Add("option_id", this.Configuration.ApiClient.ParameterToString(optionId)); // path parameter
            if (valueId != null) localVarPathParams.Add("value_id", this.Configuration.ApiClient.ParameterToString(valueId)); // path parameter
            if (includeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_fields", includeFields)); // query parameter
            if (excludeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "exclude_fields", excludeFields)); // query parameter
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
                Exception exception = ExceptionFactory("GetOptionValueById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OptionValueResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (OptionValueResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptionValueResponse)));
        }

        /// <summary>
        /// Get a Product Option Value Returns a single *Variant Option Value*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of OptionValueResponse</returns>
        public async System.Threading.Tasks.Task<OptionValueResponse> GetOptionValueByIdAsync (int? productId, int? optionId, int? valueId, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<OptionValueResponse> localVarResponse = await GetOptionValueByIdAsyncWithHttpInfo(productId, optionId, valueId, includeFields, excludeFields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Product Option Value Returns a single *Variant Option Value*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (OptionValueResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OptionValueResponse>> GetOptionValueByIdAsyncWithHttpInfo (int? productId, int? optionId, int? valueId, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductOptionValuesApi->GetOptionValueById");
            // verify the required parameter 'optionId' is set
            if (optionId == null)
                throw new ApiException(400, "Missing required parameter 'optionId' when calling ProductOptionValuesApi->GetOptionValueById");
            // verify the required parameter 'valueId' is set
            if (valueId == null)
                throw new ApiException(400, "Missing required parameter 'valueId' when calling ProductOptionValuesApi->GetOptionValueById");

            var localVarPath = "/catalog/products/{product_id}/options/{option_id}/values/{value_id}";
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
            if (optionId != null) localVarPathParams.Add("option_id", this.Configuration.ApiClient.ParameterToString(optionId)); // path parameter
            if (valueId != null) localVarPathParams.Add("value_id", this.Configuration.ApiClient.ParameterToString(valueId)); // path parameter
            if (includeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include_fields", includeFields)); // query parameter
            if (excludeFields != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "exclude_fields", excludeFields)); // query parameter
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
                Exception exception = ExceptionFactory("GetOptionValueById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OptionValueResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (OptionValueResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptionValueResponse)));
        }

        /// <summary>
        /// Get all Product Option Values Returns a list of all *Variant Option Values*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>OptionValueCollectionResponse</returns>
        public OptionValueCollectionResponse GetOptionValues (int? productId, int? optionId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<OptionValueCollectionResponse> localVarResponse = GetOptionValuesWithHttpInfo(productId, optionId, accept, contentType, includeFields, excludeFields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get all Product Option Values Returns a list of all *Variant Option Values*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of OptionValueCollectionResponse</returns>
        public ApiResponse< OptionValueCollectionResponse > GetOptionValuesWithHttpInfo (int? productId, int? optionId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductOptionValuesApi->GetOptionValues");
            // verify the required parameter 'optionId' is set
            if (optionId == null)
                throw new ApiException(400, "Missing required parameter 'optionId' when calling ProductOptionValuesApi->GetOptionValues");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductOptionValuesApi->GetOptionValues");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductOptionValuesApi->GetOptionValues");

            var localVarPath = "/catalog/products/{product_id}/options/{option_id}/values";
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
            if (optionId != null) localVarPathParams.Add("option_id", this.Configuration.ApiClient.ParameterToString(optionId)); // path parameter
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
                Exception exception = ExceptionFactory("GetOptionValues", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OptionValueCollectionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (OptionValueCollectionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptionValueCollectionResponse)));
        }

        /// <summary>
        /// Get all Product Option Values Returns a list of all *Variant Option Values*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of OptionValueCollectionResponse</returns>
        public async System.Threading.Tasks.Task<OptionValueCollectionResponse> GetOptionValuesAsync (int? productId, int? optionId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<OptionValueCollectionResponse> localVarResponse = await GetOptionValuesAsyncWithHttpInfo(productId, optionId, accept, contentType, includeFields, excludeFields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get all Product Option Values Returns a list of all *Variant Option Values*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (OptionValueCollectionResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OptionValueCollectionResponse>> GetOptionValuesAsyncWithHttpInfo (int? productId, int? optionId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductOptionValuesApi->GetOptionValues");
            // verify the required parameter 'optionId' is set
            if (optionId == null)
                throw new ApiException(400, "Missing required parameter 'optionId' when calling ProductOptionValuesApi->GetOptionValues");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductOptionValuesApi->GetOptionValues");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductOptionValuesApi->GetOptionValues");

            var localVarPath = "/catalog/products/{product_id}/options/{option_id}/values";
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
            if (optionId != null) localVarPathParams.Add("option_id", this.Configuration.ApiClient.ParameterToString(optionId)); // path parameter
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
                Exception exception = ExceptionFactory("GetOptionValues", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OptionValueCollectionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (OptionValueCollectionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptionValueCollectionResponse)));
        }

        /// <summary>
        /// Update a Product Option Value Updates a *Variant Option Value*.  **Read-Only Fields** * id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A BigCommerce &#x60;OptionValue&#x60; object.
</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <returns>OptionValueResponse</returns>
        public OptionValueResponse UpdateOptionValue (OptionValuePut body, string accept, string contentType, int? productId, int? optionId, int? valueId)
        {
             ApiResponse<OptionValueResponse> localVarResponse = UpdateOptionValueWithHttpInfo(body, accept, contentType, productId, optionId, valueId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a Product Option Value Updates a *Variant Option Value*.  **Read-Only Fields** * id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A BigCommerce &#x60;OptionValue&#x60; object.
</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <returns>ApiResponse of OptionValueResponse</returns>
        public ApiResponse< OptionValueResponse > UpdateOptionValueWithHttpInfo (OptionValuePut body, string accept, string contentType, int? productId, int? optionId, int? valueId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductOptionValuesApi->UpdateOptionValue");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductOptionValuesApi->UpdateOptionValue");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductOptionValuesApi->UpdateOptionValue");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductOptionValuesApi->UpdateOptionValue");
            // verify the required parameter 'optionId' is set
            if (optionId == null)
                throw new ApiException(400, "Missing required parameter 'optionId' when calling ProductOptionValuesApi->UpdateOptionValue");
            // verify the required parameter 'valueId' is set
            if (valueId == null)
                throw new ApiException(400, "Missing required parameter 'valueId' when calling ProductOptionValuesApi->UpdateOptionValue");

            var localVarPath = "/catalog/products/{product_id}/options/{option_id}/values/{value_id}";
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
            if (optionId != null) localVarPathParams.Add("option_id", this.Configuration.ApiClient.ParameterToString(optionId)); // path parameter
            if (valueId != null) localVarPathParams.Add("value_id", this.Configuration.ApiClient.ParameterToString(valueId)); // path parameter
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
                Exception exception = ExceptionFactory("UpdateOptionValue", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OptionValueResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (OptionValueResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptionValueResponse)));
        }

        /// <summary>
        /// Update a Product Option Value Updates a *Variant Option Value*.  **Read-Only Fields** * id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A BigCommerce &#x60;OptionValue&#x60; object.
</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <returns>Task of OptionValueResponse</returns>
        public async System.Threading.Tasks.Task<OptionValueResponse> UpdateOptionValueAsync (OptionValuePut body, string accept, string contentType, int? productId, int? optionId, int? valueId)
        {
             ApiResponse<OptionValueResponse> localVarResponse = await UpdateOptionValueAsyncWithHttpInfo(body, accept, contentType, productId, optionId, valueId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a Product Option Value Updates a *Variant Option Value*.  **Read-Only Fields** * id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A BigCommerce &#x60;OptionValue&#x60; object.
</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="optionId">The ID of the &#x60;Option&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <returns>Task of ApiResponse (OptionValueResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<OptionValueResponse>> UpdateOptionValueAsyncWithHttpInfo (OptionValuePut body, string accept, string contentType, int? productId, int? optionId, int? valueId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductOptionValuesApi->UpdateOptionValue");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductOptionValuesApi->UpdateOptionValue");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductOptionValuesApi->UpdateOptionValue");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductOptionValuesApi->UpdateOptionValue");
            // verify the required parameter 'optionId' is set
            if (optionId == null)
                throw new ApiException(400, "Missing required parameter 'optionId' when calling ProductOptionValuesApi->UpdateOptionValue");
            // verify the required parameter 'valueId' is set
            if (valueId == null)
                throw new ApiException(400, "Missing required parameter 'valueId' when calling ProductOptionValuesApi->UpdateOptionValue");

            var localVarPath = "/catalog/products/{product_id}/options/{option_id}/values/{value_id}";
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
            if (optionId != null) localVarPathParams.Add("option_id", this.Configuration.ApiClient.ParameterToString(optionId)); // path parameter
            if (valueId != null) localVarPathParams.Add("value_id", this.Configuration.ApiClient.ParameterToString(valueId)); // path parameter
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
                Exception exception = ExceptionFactory("UpdateOptionValue", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<OptionValueResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (OptionValueResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(OptionValueResponse)));
        }

    }
}
