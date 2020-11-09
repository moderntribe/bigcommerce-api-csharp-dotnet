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
        public interface IProductModifiersApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a Product Modifier
        /// </summary>
        /// <remarks>
        /// Creates a *Product Modifier*.  **Required Fields** * &#x60;required&#x60; * &#x60;display_name&#x60; * &#x60;type&#x60;  **Read-Only Fields** * &#x60;id&#x60;
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>ModifierResponse</returns>
        ModifierResponse CreateModifier (ModifierPost body, string accept, string contentType, int? productId);

        /// <summary>
        /// Create a Product Modifier
        /// </summary>
        /// <remarks>
        /// Creates a *Product Modifier*.  **Required Fields** * &#x60;required&#x60; * &#x60;display_name&#x60; * &#x60;type&#x60;  **Read-Only Fields** * &#x60;id&#x60;
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>ApiResponse of ModifierResponse</returns>
        ApiResponse<ModifierResponse> CreateModifierWithHttpInfo (ModifierPost body, string accept, string contentType, int? productId);
        /// <summary>
        /// Delete a Modifier
        /// </summary>
        /// <remarks>
        /// Deletes a *Product Modifier*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <returns></returns>
        void DeleteModifierById (int? productId, int? modifierId, string contentType, string accept);

        /// <summary>
        /// Delete a Modifier
        /// </summary>
        /// <remarks>
        /// Deletes a *Product Modifier*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteModifierByIdWithHttpInfo (int? productId, int? modifierId, string contentType, string accept);
        /// <summary>
        /// Get a Modifier
        /// </summary>
        /// <remarks>
        /// Returns a single *Product Modifier*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ModifierResponse1</returns>
        ModifierResponse1 GetModifierById (int? productId, int? modifierId, string accept, string contentType, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get a Modifier
        /// </summary>
        /// <remarks>
        /// Returns a single *Product Modifier*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of ModifierResponse1</returns>
        ApiResponse<ModifierResponse1> GetModifierByIdWithHttpInfo (int? productId, int? modifierId, string accept, string contentType, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Get All Product Modifiers
        /// </summary>
        /// <remarks>
        /// Returns a list of all *Product Modifiers*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ModifierCollectionResponse</returns>
        ModifierCollectionResponse GetModifiers (int? productId, string accept, string contentType, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get All Product Modifiers
        /// </summary>
        /// <remarks>
        /// Returns a list of all *Product Modifiers*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of ModifierCollectionResponse</returns>
        ApiResponse<ModifierCollectionResponse> GetModifiersWithHttpInfo (int? productId, string accept, string contentType, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Update a Modifier
        /// </summary>
        /// <remarks>
        /// Updates a *Product Modifier*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <returns>ModifierResponse</returns>
        ModifierResponse UpdateModifier (ModifierPut body, string accept, string contentType, int? productId, int? modifierId);

        /// <summary>
        /// Update a Modifier
        /// </summary>
        /// <remarks>
        /// Updates a *Product Modifier*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <returns>ApiResponse of ModifierResponse</returns>
        ApiResponse<ModifierResponse> UpdateModifierWithHttpInfo (ModifierPut body, string accept, string contentType, int? productId, int? modifierId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create a Product Modifier
        /// </summary>
        /// <remarks>
        /// Creates a *Product Modifier*.  **Required Fields** * &#x60;required&#x60; * &#x60;display_name&#x60; * &#x60;type&#x60;  **Read-Only Fields** * &#x60;id&#x60;
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>Task of ModifierResponse</returns>
        System.Threading.Tasks.Task<ModifierResponse> CreateModifierAsync (ModifierPost body, string accept, string contentType, int? productId);

        /// <summary>
        /// Create a Product Modifier
        /// </summary>
        /// <remarks>
        /// Creates a *Product Modifier*.  **Required Fields** * &#x60;required&#x60; * &#x60;display_name&#x60; * &#x60;type&#x60;  **Read-Only Fields** * &#x60;id&#x60;
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>Task of ApiResponse (ModifierResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModifierResponse>> CreateModifierAsyncWithHttpInfo (ModifierPost body, string accept, string contentType, int? productId);
        /// <summary>
        /// Delete a Modifier
        /// </summary>
        /// <remarks>
        /// Deletes a *Product Modifier*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteModifierByIdAsync (int? productId, int? modifierId, string contentType, string accept);

        /// <summary>
        /// Delete a Modifier
        /// </summary>
        /// <remarks>
        /// Deletes a *Product Modifier*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteModifierByIdAsyncWithHttpInfo (int? productId, int? modifierId, string contentType, string accept);
        /// <summary>
        /// Get a Modifier
        /// </summary>
        /// <remarks>
        /// Returns a single *Product Modifier*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ModifierResponse1</returns>
        System.Threading.Tasks.Task<ModifierResponse1> GetModifierByIdAsync (int? productId, int? modifierId, string accept, string contentType, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get a Modifier
        /// </summary>
        /// <remarks>
        /// Returns a single *Product Modifier*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (ModifierResponse1)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModifierResponse1>> GetModifierByIdAsyncWithHttpInfo (int? productId, int? modifierId, string accept, string contentType, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Get All Product Modifiers
        /// </summary>
        /// <remarks>
        /// Returns a list of all *Product Modifiers*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ModifierCollectionResponse</returns>
        System.Threading.Tasks.Task<ModifierCollectionResponse> GetModifiersAsync (int? productId, string accept, string contentType, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get All Product Modifiers
        /// </summary>
        /// <remarks>
        /// Returns a list of all *Product Modifiers*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (ModifierCollectionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModifierCollectionResponse>> GetModifiersAsyncWithHttpInfo (int? productId, string accept, string contentType, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Update a Modifier
        /// </summary>
        /// <remarks>
        /// Updates a *Product Modifier*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <returns>Task of ModifierResponse</returns>
        System.Threading.Tasks.Task<ModifierResponse> UpdateModifierAsync (ModifierPut body, string accept, string contentType, int? productId, int? modifierId);

        /// <summary>
        /// Update a Modifier
        /// </summary>
        /// <remarks>
        /// Updates a *Product Modifier*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <returns>Task of ApiResponse (ModifierResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ModifierResponse>> UpdateModifierAsyncWithHttpInfo (ModifierPut body, string accept, string contentType, int? productId, int? modifierId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class ProductModifiersApi : IProductModifiersApi
    {
        private BigCommerce.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductModifiersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductModifiersApi(String basePath)
        {
            this.Configuration = new BigCommerce.Client.Configuration { BasePath = basePath };

            ExceptionFactory = BigCommerce.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductModifiersApi"/> class
        /// </summary>
        /// <returns></returns>
        public ProductModifiersApi()
        {
            this.Configuration = BigCommerce.Client.Configuration.Default;

            ExceptionFactory = BigCommerce.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductModifiersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProductModifiersApi(BigCommerce.Client.Configuration configuration = null)
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
        /// Create a Product Modifier Creates a *Product Modifier*.  **Required Fields** * &#x60;required&#x60; * &#x60;display_name&#x60; * &#x60;type&#x60;  **Read-Only Fields** * &#x60;id&#x60;
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>ModifierResponse</returns>
        public ModifierResponse CreateModifier (ModifierPost body, string accept, string contentType, int? productId)
        {
             ApiResponse<ModifierResponse> localVarResponse = CreateModifierWithHttpInfo(body, accept, contentType, productId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Product Modifier Creates a *Product Modifier*.  **Required Fields** * &#x60;required&#x60; * &#x60;display_name&#x60; * &#x60;type&#x60;  **Read-Only Fields** * &#x60;id&#x60;
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>ApiResponse of ModifierResponse</returns>
        public ApiResponse< ModifierResponse > CreateModifierWithHttpInfo (ModifierPost body, string accept, string contentType, int? productId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductModifiersApi->CreateModifier");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductModifiersApi->CreateModifier");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductModifiersApi->CreateModifier");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductModifiersApi->CreateModifier");

            var localVarPath = "/catalog/products/{product_id}/modifiers";
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
                Exception exception = ExceptionFactory("CreateModifier", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModifierResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModifierResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModifierResponse)));
        }

        /// <summary>
        /// Create a Product Modifier Creates a *Product Modifier*.  **Required Fields** * &#x60;required&#x60; * &#x60;display_name&#x60; * &#x60;type&#x60;  **Read-Only Fields** * &#x60;id&#x60;
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>Task of ModifierResponse</returns>
        public async System.Threading.Tasks.Task<ModifierResponse> CreateModifierAsync (ModifierPost body, string accept, string contentType, int? productId)
        {
             ApiResponse<ModifierResponse> localVarResponse = await CreateModifierAsyncWithHttpInfo(body, accept, contentType, productId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Product Modifier Creates a *Product Modifier*.  **Required Fields** * &#x60;required&#x60; * &#x60;display_name&#x60; * &#x60;type&#x60;  **Read-Only Fields** * &#x60;id&#x60;
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>Task of ApiResponse (ModifierResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ModifierResponse>> CreateModifierAsyncWithHttpInfo (ModifierPost body, string accept, string contentType, int? productId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductModifiersApi->CreateModifier");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductModifiersApi->CreateModifier");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductModifiersApi->CreateModifier");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductModifiersApi->CreateModifier");

            var localVarPath = "/catalog/products/{product_id}/modifiers";
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
                Exception exception = ExceptionFactory("CreateModifier", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModifierResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModifierResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModifierResponse)));
        }

        /// <summary>
        /// Delete a Modifier Deletes a *Product Modifier*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <returns></returns>
        public void DeleteModifierById (int? productId, int? modifierId, string contentType, string accept)
        {
             DeleteModifierByIdWithHttpInfo(productId, modifierId, contentType, accept);
        }

        /// <summary>
        /// Delete a Modifier Deletes a *Product Modifier*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteModifierByIdWithHttpInfo (int? productId, int? modifierId, string contentType, string accept)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductModifiersApi->DeleteModifierById");
            // verify the required parameter 'modifierId' is set
            if (modifierId == null)
                throw new ApiException(400, "Missing required parameter 'modifierId' when calling ProductModifiersApi->DeleteModifierById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductModifiersApi->DeleteModifierById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductModifiersApi->DeleteModifierById");

            var localVarPath = "/catalog/products/{product_id}/modifiers/{modifier_id}";
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
                Exception exception = ExceptionFactory("DeleteModifierById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Delete a Modifier Deletes a *Product Modifier*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteModifierByIdAsync (int? productId, int? modifierId, string contentType, string accept)
        {
             await DeleteModifierByIdAsyncWithHttpInfo(productId, modifierId, contentType, accept);

        }

        /// <summary>
        /// Delete a Modifier Deletes a *Product Modifier*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteModifierByIdAsyncWithHttpInfo (int? productId, int? modifierId, string contentType, string accept)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductModifiersApi->DeleteModifierById");
            // verify the required parameter 'modifierId' is set
            if (modifierId == null)
                throw new ApiException(400, "Missing required parameter 'modifierId' when calling ProductModifiersApi->DeleteModifierById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductModifiersApi->DeleteModifierById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductModifiersApi->DeleteModifierById");

            var localVarPath = "/catalog/products/{product_id}/modifiers/{modifier_id}";
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
                Exception exception = ExceptionFactory("DeleteModifierById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Get a Modifier Returns a single *Product Modifier*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ModifierResponse1</returns>
        public ModifierResponse1 GetModifierById (int? productId, int? modifierId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<ModifierResponse1> localVarResponse = GetModifierByIdWithHttpInfo(productId, modifierId, accept, contentType, includeFields, excludeFields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Modifier Returns a single *Product Modifier*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of ModifierResponse1</returns>
        public ApiResponse< ModifierResponse1 > GetModifierByIdWithHttpInfo (int? productId, int? modifierId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductModifiersApi->GetModifierById");
            // verify the required parameter 'modifierId' is set
            if (modifierId == null)
                throw new ApiException(400, "Missing required parameter 'modifierId' when calling ProductModifiersApi->GetModifierById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductModifiersApi->GetModifierById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductModifiersApi->GetModifierById");

            var localVarPath = "/catalog/products/{product_id}/modifiers/{modifier_id}";
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
                Exception exception = ExceptionFactory("GetModifierById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModifierResponse1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModifierResponse1) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModifierResponse1)));
        }

        /// <summary>
        /// Get a Modifier Returns a single *Product Modifier*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ModifierResponse1</returns>
        public async System.Threading.Tasks.Task<ModifierResponse1> GetModifierByIdAsync (int? productId, int? modifierId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<ModifierResponse1> localVarResponse = await GetModifierByIdAsyncWithHttpInfo(productId, modifierId, accept, contentType, includeFields, excludeFields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Modifier Returns a single *Product Modifier*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (ModifierResponse1)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ModifierResponse1>> GetModifierByIdAsyncWithHttpInfo (int? productId, int? modifierId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductModifiersApi->GetModifierById");
            // verify the required parameter 'modifierId' is set
            if (modifierId == null)
                throw new ApiException(400, "Missing required parameter 'modifierId' when calling ProductModifiersApi->GetModifierById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductModifiersApi->GetModifierById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductModifiersApi->GetModifierById");

            var localVarPath = "/catalog/products/{product_id}/modifiers/{modifier_id}";
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
                Exception exception = ExceptionFactory("GetModifierById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModifierResponse1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModifierResponse1) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModifierResponse1)));
        }

        /// <summary>
        /// Get All Product Modifiers Returns a list of all *Product Modifiers*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ModifierCollectionResponse</returns>
        public ModifierCollectionResponse GetModifiers (int? productId, string accept, string contentType, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<ModifierCollectionResponse> localVarResponse = GetModifiersWithHttpInfo(productId, accept, contentType, page, limit, includeFields, excludeFields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get All Product Modifiers Returns a list of all *Product Modifiers*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of ModifierCollectionResponse</returns>
        public ApiResponse< ModifierCollectionResponse > GetModifiersWithHttpInfo (int? productId, string accept, string contentType, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductModifiersApi->GetModifiers");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductModifiersApi->GetModifiers");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductModifiersApi->GetModifiers");

            var localVarPath = "/catalog/products/{product_id}/modifiers";
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
                Exception exception = ExceptionFactory("GetModifiers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModifierCollectionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModifierCollectionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModifierCollectionResponse)));
        }

        /// <summary>
        /// Get All Product Modifiers Returns a list of all *Product Modifiers*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ModifierCollectionResponse</returns>
        public async System.Threading.Tasks.Task<ModifierCollectionResponse> GetModifiersAsync (int? productId, string accept, string contentType, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<ModifierCollectionResponse> localVarResponse = await GetModifiersAsyncWithHttpInfo(productId, accept, contentType, page, limit, includeFields, excludeFields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get All Product Modifiers Returns a list of all *Product Modifiers*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (ModifierCollectionResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ModifierCollectionResponse>> GetModifiersAsyncWithHttpInfo (int? productId, string accept, string contentType, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductModifiersApi->GetModifiers");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductModifiersApi->GetModifiers");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductModifiersApi->GetModifiers");

            var localVarPath = "/catalog/products/{product_id}/modifiers";
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
                Exception exception = ExceptionFactory("GetModifiers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModifierCollectionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModifierCollectionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModifierCollectionResponse)));
        }

        /// <summary>
        /// Update a Modifier Updates a *Product Modifier*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <returns>ModifierResponse</returns>
        public ModifierResponse UpdateModifier (ModifierPut body, string accept, string contentType, int? productId, int? modifierId)
        {
             ApiResponse<ModifierResponse> localVarResponse = UpdateModifierWithHttpInfo(body, accept, contentType, productId, modifierId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a Modifier Updates a *Product Modifier*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <returns>ApiResponse of ModifierResponse</returns>
        public ApiResponse< ModifierResponse > UpdateModifierWithHttpInfo (ModifierPut body, string accept, string contentType, int? productId, int? modifierId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductModifiersApi->UpdateModifier");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductModifiersApi->UpdateModifier");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductModifiersApi->UpdateModifier");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductModifiersApi->UpdateModifier");
            // verify the required parameter 'modifierId' is set
            if (modifierId == null)
                throw new ApiException(400, "Missing required parameter 'modifierId' when calling ProductModifiersApi->UpdateModifier");

            var localVarPath = "/catalog/products/{product_id}/modifiers/{modifier_id}";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateModifier", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModifierResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModifierResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModifierResponse)));
        }

        /// <summary>
        /// Update a Modifier Updates a *Product Modifier*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <returns>Task of ModifierResponse</returns>
        public async System.Threading.Tasks.Task<ModifierResponse> UpdateModifierAsync (ModifierPut body, string accept, string contentType, int? productId, int? modifierId)
        {
             ApiResponse<ModifierResponse> localVarResponse = await UpdateModifierAsyncWithHttpInfo(body, accept, contentType, productId, modifierId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a Modifier Updates a *Product Modifier*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="modifierId">The ID of the &#x60;Modifier&#x60;. </param>
        /// <returns>Task of ApiResponse (ModifierResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ModifierResponse>> UpdateModifierAsyncWithHttpInfo (ModifierPut body, string accept, string contentType, int? productId, int? modifierId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductModifiersApi->UpdateModifier");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductModifiersApi->UpdateModifier");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductModifiersApi->UpdateModifier");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductModifiersApi->UpdateModifier");
            // verify the required parameter 'modifierId' is set
            if (modifierId == null)
                throw new ApiException(400, "Missing required parameter 'modifierId' when calling ProductModifiersApi->UpdateModifier");

            var localVarPath = "/catalog/products/{product_id}/modifiers/{modifier_id}";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateModifier", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ModifierResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ModifierResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ModifierResponse)));
        }

    }
}
