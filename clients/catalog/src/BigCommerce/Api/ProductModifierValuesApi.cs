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
        public interface IProductModifierValuesApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create Modifier Value
        /// </summary>
        /// <remarks>
        /// Creates a *Modifier Value*.  **Required Fields** * label * sort_order  **Read-Only Fields** * id
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <returns>ModifierValueResponse</returns>
        ModifierValueResponse CreateModifierValue (ModifierValuePost body, string accept, string contentType, int? productId, int? modifierId);

        /// <summary>
        /// Create Modifier Value
        /// </summary>
        /// <remarks>
        /// Creates a *Modifier Value*.  **Required Fields** * label * sort_order  **Read-Only Fields** * id
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <returns>ApiResponse of ModifierValueResponse</returns>
        ApiResponse<ModifierValueResponse> CreateModifierValueWithHttpInfo (ModifierValuePost body, string accept, string contentType, int? productId, int? modifierId);
        /// <summary>
        /// Delete Modifier Value
        /// </summary>
        /// <remarks>
        /// Deletes a *Modifier Value*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void DeleteModifierValueById (int? productId, int? modifierId, int? valueId, string accept, string contentType);

        /// <summary>
        /// Delete Modifier Value
        /// </summary>
        /// <remarks>
        /// Deletes a *Modifier Value*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteModifierValueByIdWithHttpInfo (int? productId, int? modifierId, int? valueId, string accept, string contentType);
        /// <summary>
        /// Get a Modifier Value
        /// </summary>
        /// <remarks>
        /// Returns a single *Modifier Value*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ModifierValueResponse1</returns>
        ModifierValueResponse1 GetModifierValueById (int? productId, int? modifierId, int? valueId, string accept, string contentType, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get a Modifier Value
        /// </summary>
        /// <remarks>
        /// Returns a single *Modifier Value*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of ModifierValueResponse1</returns>
        ApiResponse<ModifierValueResponse1> GetModifierValueByIdWithHttpInfo (int? productId, int? modifierId, int? valueId, string accept, string contentType, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Get All Modifier Values
        /// </summary>
        /// <remarks>
        /// Returns a list of all product *Modifier Values*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ModifierValueCollectionResponse</returns>
        ModifierValueCollectionResponse GetModifierValues (int? productId, int? modifierId, string accept, string contentType, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get All Modifier Values
        /// </summary>
        /// <remarks>
        /// Returns a list of all product *Modifier Values*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of ModifierValueCollectionResponse</returns>
        ApiResponse<ModifierValueCollectionResponse> GetModifierValuesWithHttpInfo (int? productId, int? modifierId, string accept, string contentType, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Update a Modifier Value
        /// </summary>
        /// <remarks>
        /// Updates a *Modifier Value*.  **Required Fields** * none  **Read-Only Fields** * id
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <returns>ModifierValueResponse</returns>
        ModifierValueResponse UpdateModifierValue (ModifierValuePut body, string accept, string contentType, int? productId, int? modifierId, int? valueId);

        /// <summary>
        /// Update a Modifier Value
        /// </summary>
        /// <remarks>
        /// Updates a *Modifier Value*.  **Required Fields** * none  **Read-Only Fields** * id
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <returns>ApiResponse of ModifierValueResponse</returns>
        ApiResponse<ModifierValueResponse> UpdateModifierValueWithHttpInfo (ModifierValuePut body, string accept, string contentType, int? productId, int? modifierId, int? valueId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create Modifier Value
        /// </summary>
        /// <remarks>
        /// Creates a *Modifier Value*.  **Required Fields** * label * sort_order  **Read-Only Fields** * id
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <returns>Task of ModifierValueResponse</returns>
        System.Threading.Tasks.Task<ModifierValueResponse> CreateModifierValueAsync (ModifierValuePost body, string accept, string contentType, int? productId, int? modifierId);

        /// <summary>
        /// Create Modifier Value
        /// </summary>
        /// <remarks>
        /// Creates a *Modifier Value*.  **Required Fields** * label * sort_order  **Read-Only Fields** * id
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <returns>Task of ApiResponse (ModifierValueResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModifierValueResponse>> CreateModifierValueAsyncWithHttpInfo (ModifierValuePost body, string accept, string contentType, int? productId, int? modifierId);
        /// <summary>
        /// Delete Modifier Value
        /// </summary>
        /// <remarks>
        /// Deletes a *Modifier Value*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteModifierValueByIdAsync (int? productId, int? modifierId, int? valueId, string accept, string contentType);

        /// <summary>
        /// Delete Modifier Value
        /// </summary>
        /// <remarks>
        /// Deletes a *Modifier Value*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteModifierValueByIdAsyncWithHttpInfo (int? productId, int? modifierId, int? valueId, string accept, string contentType);
        /// <summary>
        /// Get a Modifier Value
        /// </summary>
        /// <remarks>
        /// Returns a single *Modifier Value*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ModifierValueResponse1</returns>
        System.Threading.Tasks.Task<ModifierValueResponse1> GetModifierValueByIdAsync (int? productId, int? modifierId, int? valueId, string accept, string contentType, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get a Modifier Value
        /// </summary>
        /// <remarks>
        /// Returns a single *Modifier Value*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (ModifierValueResponse1)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModifierValueResponse1>> GetModifierValueByIdAsyncWithHttpInfo (int? productId, int? modifierId, int? valueId, string accept, string contentType, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Get All Modifier Values
        /// </summary>
        /// <remarks>
        /// Returns a list of all product *Modifier Values*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ModifierValueCollectionResponse</returns>
        System.Threading.Tasks.Task<ModifierValueCollectionResponse> GetModifierValuesAsync (int? productId, int? modifierId, string accept, string contentType, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get All Modifier Values
        /// </summary>
        /// <remarks>
        /// Returns a list of all product *Modifier Values*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (ModifierValueCollectionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModifierValueCollectionResponse>> GetModifierValuesAsyncWithHttpInfo (int? productId, int? modifierId, string accept, string contentType, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Update a Modifier Value
        /// </summary>
        /// <remarks>
        /// Updates a *Modifier Value*.  **Required Fields** * none  **Read-Only Fields** * id
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <returns>Task of ModifierValueResponse</returns>
        System.Threading.Tasks.Task<ModifierValueResponse> UpdateModifierValueAsync (ModifierValuePut body, string accept, string contentType, int? productId, int? modifierId, int? valueId);

        /// <summary>
        /// Update a Modifier Value
        /// </summary>
        /// <remarks>
        /// Updates a *Modifier Value*.  **Required Fields** * none  **Read-Only Fields** * id
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <returns>Task of ApiResponse (ModifierValueResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModifierValueResponse>> UpdateModifierValueAsyncWithHttpInfo (ModifierValuePut body, string accept, string contentType, int? productId, int? modifierId, int? valueId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class ProductModifierValuesApi : IProductModifierValuesApi
    {
        private BigCommerce.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductModifierValuesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductModifierValuesApi(String basePath)
        {
            this.Configuration = new BigCommerce.Client.Configuration { BasePath = basePath };

            ExceptionFactory = BigCommerce.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductModifierValuesApi"/> class
        /// </summary>
        /// <returns></returns>
        public ProductModifierValuesApi()
        {
            this.Configuration = BigCommerce.Client.Configuration.Default;

            ExceptionFactory = BigCommerce.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductModifierValuesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProductModifierValuesApi(BigCommerce.Client.Configuration configuration = null)
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
        /// Create Modifier Value Creates a *Modifier Value*.  **Required Fields** * label * sort_order  **Read-Only Fields** * id
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <returns>ModifierValueResponse</returns>
        public ModifierValueResponse CreateModifierValue (ModifierValuePost body, string accept, string contentType, int? productId, int? modifierId)
        {
             ApiResponse<ModifierValueResponse> localVarResponse = CreateModifierValueWithHttpInfo(body, accept, contentType, productId, modifierId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Modifier Value Creates a *Modifier Value*.  **Required Fields** * label * sort_order  **Read-Only Fields** * id
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <returns>ApiResponse of ModifierValueResponse</returns>
        public ApiResponse< ModifierValueResponse > CreateModifierValueWithHttpInfo (ModifierValuePost body, string accept, string contentType, int? productId, int? modifierId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductModifierValuesApi->CreateModifierValue");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductModifierValuesApi->CreateModifierValue");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductModifierValuesApi->CreateModifierValue");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductModifierValuesApi->CreateModifierValue");
            // verify the required parameter 'modifierId' is set
            if (modifierId == null)
                throw new ApiException(400, "Missing required parameter 'modifierId' when calling ProductModifierValuesApi->CreateModifierValue");

            var localVarPath = "/catalog/products/{product_id}/modifiers/{modifier_id}/values";
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
            if (modifierId != null) localVarPathParams.Add("modifier_id", this.Configuration.ApiClient.ParameterToString(modifierId)); // path parameter
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
                Exception exception = ExceptionFactory("CreateModifierValue", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModifierValueResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModifierValueResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModifierValueResponse)));
        }

        /// <summary>
        /// Create Modifier Value Creates a *Modifier Value*.  **Required Fields** * label * sort_order  **Read-Only Fields** * id
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <returns>Task of ModifierValueResponse</returns>
        public async System.Threading.Tasks.Task<ModifierValueResponse> CreateModifierValueAsync (ModifierValuePost body, string accept, string contentType, int? productId, int? modifierId)
        {
             ApiResponse<ModifierValueResponse> localVarResponse = await CreateModifierValueAsyncWithHttpInfo(body, accept, contentType, productId, modifierId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Modifier Value Creates a *Modifier Value*.  **Required Fields** * label * sort_order  **Read-Only Fields** * id
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <returns>Task of ApiResponse (ModifierValueResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ModifierValueResponse>> CreateModifierValueAsyncWithHttpInfo (ModifierValuePost body, string accept, string contentType, int? productId, int? modifierId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductModifierValuesApi->CreateModifierValue");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductModifierValuesApi->CreateModifierValue");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductModifierValuesApi->CreateModifierValue");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductModifierValuesApi->CreateModifierValue");
            // verify the required parameter 'modifierId' is set
            if (modifierId == null)
                throw new ApiException(400, "Missing required parameter 'modifierId' when calling ProductModifierValuesApi->CreateModifierValue");

            var localVarPath = "/catalog/products/{product_id}/modifiers/{modifier_id}/values";
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
            if (modifierId != null) localVarPathParams.Add("modifier_id", this.Configuration.ApiClient.ParameterToString(modifierId)); // path parameter
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
                Exception exception = ExceptionFactory("CreateModifierValue", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModifierValueResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModifierValueResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModifierValueResponse)));
        }

        /// <summary>
        /// Delete Modifier Value Deletes a *Modifier Value*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public void DeleteModifierValueById (int? productId, int? modifierId, int? valueId, string accept, string contentType)
        {
             DeleteModifierValueByIdWithHttpInfo(productId, modifierId, valueId, accept, contentType);
        }

        /// <summary>
        /// Delete Modifier Value Deletes a *Modifier Value*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteModifierValueByIdWithHttpInfo (int? productId, int? modifierId, int? valueId, string accept, string contentType)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductModifierValuesApi->DeleteModifierValueById");
            // verify the required parameter 'modifierId' is set
            if (modifierId == null)
                throw new ApiException(400, "Missing required parameter 'modifierId' when calling ProductModifierValuesApi->DeleteModifierValueById");
            // verify the required parameter 'valueId' is set
            if (valueId == null)
                throw new ApiException(400, "Missing required parameter 'valueId' when calling ProductModifierValuesApi->DeleteModifierValueById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductModifierValuesApi->DeleteModifierValueById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductModifierValuesApi->DeleteModifierValueById");

            var localVarPath = "/catalog/products/{product_id}/modifiers/{modifier_id}/values/{value_id}";
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
            if (modifierId != null) localVarPathParams.Add("modifier_id", this.Configuration.ApiClient.ParameterToString(modifierId)); // path parameter
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
                Exception exception = ExceptionFactory("DeleteModifierValueById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Delete Modifier Value Deletes a *Modifier Value*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteModifierValueByIdAsync (int? productId, int? modifierId, int? valueId, string accept, string contentType)
        {
             await DeleteModifierValueByIdAsyncWithHttpInfo(productId, modifierId, valueId, accept, contentType);

        }

        /// <summary>
        /// Delete Modifier Value Deletes a *Modifier Value*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteModifierValueByIdAsyncWithHttpInfo (int? productId, int? modifierId, int? valueId, string accept, string contentType)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductModifierValuesApi->DeleteModifierValueById");
            // verify the required parameter 'modifierId' is set
            if (modifierId == null)
                throw new ApiException(400, "Missing required parameter 'modifierId' when calling ProductModifierValuesApi->DeleteModifierValueById");
            // verify the required parameter 'valueId' is set
            if (valueId == null)
                throw new ApiException(400, "Missing required parameter 'valueId' when calling ProductModifierValuesApi->DeleteModifierValueById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductModifierValuesApi->DeleteModifierValueById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductModifierValuesApi->DeleteModifierValueById");

            var localVarPath = "/catalog/products/{product_id}/modifiers/{modifier_id}/values/{value_id}";
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
            if (modifierId != null) localVarPathParams.Add("modifier_id", this.Configuration.ApiClient.ParameterToString(modifierId)); // path parameter
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
                Exception exception = ExceptionFactory("DeleteModifierValueById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Get a Modifier Value Returns a single *Modifier Value*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ModifierValueResponse1</returns>
        public ModifierValueResponse1 GetModifierValueById (int? productId, int? modifierId, int? valueId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<ModifierValueResponse1> localVarResponse = GetModifierValueByIdWithHttpInfo(productId, modifierId, valueId, accept, contentType, includeFields, excludeFields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Modifier Value Returns a single *Modifier Value*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of ModifierValueResponse1</returns>
        public ApiResponse< ModifierValueResponse1 > GetModifierValueByIdWithHttpInfo (int? productId, int? modifierId, int? valueId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductModifierValuesApi->GetModifierValueById");
            // verify the required parameter 'modifierId' is set
            if (modifierId == null)
                throw new ApiException(400, "Missing required parameter 'modifierId' when calling ProductModifierValuesApi->GetModifierValueById");
            // verify the required parameter 'valueId' is set
            if (valueId == null)
                throw new ApiException(400, "Missing required parameter 'valueId' when calling ProductModifierValuesApi->GetModifierValueById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductModifierValuesApi->GetModifierValueById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductModifierValuesApi->GetModifierValueById");

            var localVarPath = "/catalog/products/{product_id}/modifiers/{modifier_id}/values/{value_id}";
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
            if (modifierId != null) localVarPathParams.Add("modifier_id", this.Configuration.ApiClient.ParameterToString(modifierId)); // path parameter
            if (valueId != null) localVarPathParams.Add("value_id", this.Configuration.ApiClient.ParameterToString(valueId)); // path parameter
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
                Exception exception = ExceptionFactory("GetModifierValueById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModifierValueResponse1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModifierValueResponse1) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModifierValueResponse1)));
        }

        /// <summary>
        /// Get a Modifier Value Returns a single *Modifier Value*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ModifierValueResponse1</returns>
        public async System.Threading.Tasks.Task<ModifierValueResponse1> GetModifierValueByIdAsync (int? productId, int? modifierId, int? valueId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<ModifierValueResponse1> localVarResponse = await GetModifierValueByIdAsyncWithHttpInfo(productId, modifierId, valueId, accept, contentType, includeFields, excludeFields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Modifier Value Returns a single *Modifier Value*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (ModifierValueResponse1)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ModifierValueResponse1>> GetModifierValueByIdAsyncWithHttpInfo (int? productId, int? modifierId, int? valueId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductModifierValuesApi->GetModifierValueById");
            // verify the required parameter 'modifierId' is set
            if (modifierId == null)
                throw new ApiException(400, "Missing required parameter 'modifierId' when calling ProductModifierValuesApi->GetModifierValueById");
            // verify the required parameter 'valueId' is set
            if (valueId == null)
                throw new ApiException(400, "Missing required parameter 'valueId' when calling ProductModifierValuesApi->GetModifierValueById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductModifierValuesApi->GetModifierValueById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductModifierValuesApi->GetModifierValueById");

            var localVarPath = "/catalog/products/{product_id}/modifiers/{modifier_id}/values/{value_id}";
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
            if (modifierId != null) localVarPathParams.Add("modifier_id", this.Configuration.ApiClient.ParameterToString(modifierId)); // path parameter
            if (valueId != null) localVarPathParams.Add("value_id", this.Configuration.ApiClient.ParameterToString(valueId)); // path parameter
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
                Exception exception = ExceptionFactory("GetModifierValueById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModifierValueResponse1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModifierValueResponse1) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModifierValueResponse1)));
        }

        /// <summary>
        /// Get All Modifier Values Returns a list of all product *Modifier Values*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ModifierValueCollectionResponse</returns>
        public ModifierValueCollectionResponse GetModifierValues (int? productId, int? modifierId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<ModifierValueCollectionResponse> localVarResponse = GetModifierValuesWithHttpInfo(productId, modifierId, accept, contentType, includeFields, excludeFields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get All Modifier Values Returns a list of all product *Modifier Values*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of ModifierValueCollectionResponse</returns>
        public ApiResponse< ModifierValueCollectionResponse > GetModifierValuesWithHttpInfo (int? productId, int? modifierId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductModifierValuesApi->GetModifierValues");
            // verify the required parameter 'modifierId' is set
            if (modifierId == null)
                throw new ApiException(400, "Missing required parameter 'modifierId' when calling ProductModifierValuesApi->GetModifierValues");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductModifierValuesApi->GetModifierValues");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductModifierValuesApi->GetModifierValues");

            var localVarPath = "/catalog/products/{product_id}/modifiers/{modifier_id}/values";
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
            if (modifierId != null) localVarPathParams.Add("modifier_id", this.Configuration.ApiClient.ParameterToString(modifierId)); // path parameter
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
                Exception exception = ExceptionFactory("GetModifierValues", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModifierValueCollectionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModifierValueCollectionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModifierValueCollectionResponse)));
        }

        /// <summary>
        /// Get All Modifier Values Returns a list of all product *Modifier Values*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ModifierValueCollectionResponse</returns>
        public async System.Threading.Tasks.Task<ModifierValueCollectionResponse> GetModifierValuesAsync (int? productId, int? modifierId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<ModifierValueCollectionResponse> localVarResponse = await GetModifierValuesAsyncWithHttpInfo(productId, modifierId, accept, contentType, includeFields, excludeFields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get All Modifier Values Returns a list of all product *Modifier Values*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (ModifierValueCollectionResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ModifierValueCollectionResponse>> GetModifierValuesAsyncWithHttpInfo (int? productId, int? modifierId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductModifierValuesApi->GetModifierValues");
            // verify the required parameter 'modifierId' is set
            if (modifierId == null)
                throw new ApiException(400, "Missing required parameter 'modifierId' when calling ProductModifierValuesApi->GetModifierValues");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductModifierValuesApi->GetModifierValues");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductModifierValuesApi->GetModifierValues");

            var localVarPath = "/catalog/products/{product_id}/modifiers/{modifier_id}/values";
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
            if (modifierId != null) localVarPathParams.Add("modifier_id", this.Configuration.ApiClient.ParameterToString(modifierId)); // path parameter
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
                Exception exception = ExceptionFactory("GetModifierValues", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModifierValueCollectionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModifierValueCollectionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModifierValueCollectionResponse)));
        }

        /// <summary>
        /// Update a Modifier Value Updates a *Modifier Value*.  **Required Fields** * none  **Read-Only Fields** * id
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <returns>ModifierValueResponse</returns>
        public ModifierValueResponse UpdateModifierValue (ModifierValuePut body, string accept, string contentType, int? productId, int? modifierId, int? valueId)
        {
             ApiResponse<ModifierValueResponse> localVarResponse = UpdateModifierValueWithHttpInfo(body, accept, contentType, productId, modifierId, valueId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a Modifier Value Updates a *Modifier Value*.  **Required Fields** * none  **Read-Only Fields** * id
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <returns>ApiResponse of ModifierValueResponse</returns>
        public ApiResponse< ModifierValueResponse > UpdateModifierValueWithHttpInfo (ModifierValuePut body, string accept, string contentType, int? productId, int? modifierId, int? valueId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductModifierValuesApi->UpdateModifierValue");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductModifierValuesApi->UpdateModifierValue");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductModifierValuesApi->UpdateModifierValue");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductModifierValuesApi->UpdateModifierValue");
            // verify the required parameter 'modifierId' is set
            if (modifierId == null)
                throw new ApiException(400, "Missing required parameter 'modifierId' when calling ProductModifierValuesApi->UpdateModifierValue");
            // verify the required parameter 'valueId' is set
            if (valueId == null)
                throw new ApiException(400, "Missing required parameter 'valueId' when calling ProductModifierValuesApi->UpdateModifierValue");

            var localVarPath = "/catalog/products/{product_id}/modifiers/{modifier_id}/values/{value_id}";
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
            if (modifierId != null) localVarPathParams.Add("modifier_id", this.Configuration.ApiClient.ParameterToString(modifierId)); // path parameter
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
                Exception exception = ExceptionFactory("UpdateModifierValue", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModifierValueResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModifierValueResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModifierValueResponse)));
        }

        /// <summary>
        /// Update a Modifier Value Updates a *Modifier Value*.  **Required Fields** * none  **Read-Only Fields** * id
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <returns>Task of ModifierValueResponse</returns>
        public async System.Threading.Tasks.Task<ModifierValueResponse> UpdateModifierValueAsync (ModifierValuePut body, string accept, string contentType, int? productId, int? modifierId, int? valueId)
        {
             ApiResponse<ModifierValueResponse> localVarResponse = await UpdateModifierValueAsyncWithHttpInfo(body, accept, contentType, productId, modifierId, valueId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a Modifier Value Updates a *Modifier Value*.  **Required Fields** * none  **Read-Only Fields** * id
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="valueId">The ID of the &#x60;Modifier/Option Value&#x60;. </param>
        /// <returns>Task of ApiResponse (ModifierValueResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ModifierValueResponse>> UpdateModifierValueAsyncWithHttpInfo (ModifierValuePut body, string accept, string contentType, int? productId, int? modifierId, int? valueId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductModifierValuesApi->UpdateModifierValue");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductModifierValuesApi->UpdateModifierValue");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductModifierValuesApi->UpdateModifierValue");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductModifierValuesApi->UpdateModifierValue");
            // verify the required parameter 'modifierId' is set
            if (modifierId == null)
                throw new ApiException(400, "Missing required parameter 'modifierId' when calling ProductModifierValuesApi->UpdateModifierValue");
            // verify the required parameter 'valueId' is set
            if (valueId == null)
                throw new ApiException(400, "Missing required parameter 'valueId' when calling ProductModifierValuesApi->UpdateModifierValue");

            var localVarPath = "/catalog/products/{product_id}/modifiers/{modifier_id}/values/{value_id}";
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
            if (modifierId != null) localVarPathParams.Add("modifier_id", this.Configuration.ApiClient.ParameterToString(modifierId)); // path parameter
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
                Exception exception = ExceptionFactory("UpdateModifierValue", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModifierValueResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModifierValueResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModifierValueResponse)));
        }

    }
}
