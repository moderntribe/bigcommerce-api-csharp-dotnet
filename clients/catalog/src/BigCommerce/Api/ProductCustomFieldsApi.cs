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
        public interface IProductCustomFieldsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a Custom Fields
        /// </summary>
        /// <remarks>
        /// Creates a *Custom Field*.  **Required Fields:** - name - value  **Read-Only:** - id
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>InlineResponse2007</returns>
        InlineResponse2007 CreateCustomField (CustomField body, string accept, string contentType, int? productId);

        /// <summary>
        /// Create a Custom Fields
        /// </summary>
        /// <remarks>
        /// Creates a *Custom Field*.  **Required Fields:** - name - value  **Read-Only:** - id
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>ApiResponse of InlineResponse2007</returns>
        ApiResponse<InlineResponse2007> CreateCustomFieldWithHttpInfo (CustomField body, string accept, string contentType, int? productId);
        /// <summary>
        /// Delete a Custom Field
        /// </summary>
        /// <remarks>
        /// Deletes a product *Custom Field*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="customFieldId">The ID of the &#x60;CustomField&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void DeleteCustomFieldById (int? productId, int? customFieldId, string accept, string contentType);

        /// <summary>
        /// Delete a Custom Field
        /// </summary>
        /// <remarks>
        /// Deletes a product *Custom Field*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="customFieldId">The ID of the &#x60;CustomField&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteCustomFieldByIdWithHttpInfo (int? productId, int? customFieldId, string accept, string contentType);
        /// <summary>
        /// Get a Custom Field
        /// </summary>
        /// <remarks>
        /// Returns a single *Custom Field*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="customFieldId">The ID of the &#x60;CustomField&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>InlineResponse2008</returns>
        InlineResponse2008 GetCustomFieldById (int? productId, int? customFieldId, string accept, string contentType, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get a Custom Field
        /// </summary>
        /// <remarks>
        /// Returns a single *Custom Field*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="customFieldId">The ID of the &#x60;CustomField&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2008</returns>
        ApiResponse<InlineResponse2008> GetCustomFieldByIdWithHttpInfo (int? productId, int? customFieldId, string accept, string contentType, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Get Custom Fields
        /// </summary>
        /// <remarks>
        /// Returns a list of product *Custom Fields*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>InlineResponse2006</returns>
        InlineResponse2006 GetCustomFields (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get Custom Fields
        /// </summary>
        /// <remarks>
        /// Returns a list of product *Custom Fields*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2006</returns>
        ApiResponse<InlineResponse2006> GetCustomFieldsWithHttpInfo (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null, int? page = null, int? limit = null);
        /// <summary>
        /// Update a Custom Field
        /// </summary>
        /// <remarks>
        /// Updates a *Custom Field*.   **Required Fields** - none  **Read-Only** - id
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="customFieldId">The ID of the &#x60;CustomField&#x60;. </param>
        /// <returns>InlineResponse2007</returns>
        InlineResponse2007 UpdateCustomField (CustomField1 body, string accept, string contentType, int? productId, int? customFieldId);

        /// <summary>
        /// Update a Custom Field
        /// </summary>
        /// <remarks>
        /// Updates a *Custom Field*.   **Required Fields** - none  **Read-Only** - id
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="customFieldId">The ID of the &#x60;CustomField&#x60;. </param>
        /// <returns>ApiResponse of InlineResponse2007</returns>
        ApiResponse<InlineResponse2007> UpdateCustomFieldWithHttpInfo (CustomField1 body, string accept, string contentType, int? productId, int? customFieldId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create a Custom Fields
        /// </summary>
        /// <remarks>
        /// Creates a *Custom Field*.  **Required Fields:** - name - value  **Read-Only:** - id
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>Task of InlineResponse2007</returns>
        System.Threading.Tasks.Task<InlineResponse2007> CreateCustomFieldAsync (CustomField body, string accept, string contentType, int? productId);

        /// <summary>
        /// Create a Custom Fields
        /// </summary>
        /// <remarks>
        /// Creates a *Custom Field*.  **Required Fields:** - name - value  **Read-Only:** - id
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>Task of ApiResponse (InlineResponse2007)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2007>> CreateCustomFieldAsyncWithHttpInfo (CustomField body, string accept, string contentType, int? productId);
        /// <summary>
        /// Delete a Custom Field
        /// </summary>
        /// <remarks>
        /// Deletes a product *Custom Field*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="customFieldId">The ID of the &#x60;CustomField&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteCustomFieldByIdAsync (int? productId, int? customFieldId, string accept, string contentType);

        /// <summary>
        /// Delete a Custom Field
        /// </summary>
        /// <remarks>
        /// Deletes a product *Custom Field*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="customFieldId">The ID of the &#x60;CustomField&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCustomFieldByIdAsyncWithHttpInfo (int? productId, int? customFieldId, string accept, string contentType);
        /// <summary>
        /// Get a Custom Field
        /// </summary>
        /// <remarks>
        /// Returns a single *Custom Field*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="customFieldId">The ID of the &#x60;CustomField&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of InlineResponse2008</returns>
        System.Threading.Tasks.Task<InlineResponse2008> GetCustomFieldByIdAsync (int? productId, int? customFieldId, string accept, string contentType, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get a Custom Field
        /// </summary>
        /// <remarks>
        /// Returns a single *Custom Field*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="customFieldId">The ID of the &#x60;CustomField&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2008)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2008>> GetCustomFieldByIdAsyncWithHttpInfo (int? productId, int? customFieldId, string accept, string contentType, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Get Custom Fields
        /// </summary>
        /// <remarks>
        /// Returns a list of product *Custom Fields*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>Task of InlineResponse2006</returns>
        System.Threading.Tasks.Task<InlineResponse2006> GetCustomFieldsAsync (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get Custom Fields
        /// </summary>
        /// <remarks>
        /// Returns a list of product *Custom Fields*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2006)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2006>> GetCustomFieldsAsyncWithHttpInfo (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null, int? page = null, int? limit = null);
        /// <summary>
        /// Update a Custom Field
        /// </summary>
        /// <remarks>
        /// Updates a *Custom Field*.   **Required Fields** - none  **Read-Only** - id
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="customFieldId">The ID of the &#x60;CustomField&#x60;. </param>
        /// <returns>Task of InlineResponse2007</returns>
        System.Threading.Tasks.Task<InlineResponse2007> UpdateCustomFieldAsync (CustomField1 body, string accept, string contentType, int? productId, int? customFieldId);

        /// <summary>
        /// Update a Custom Field
        /// </summary>
        /// <remarks>
        /// Updates a *Custom Field*.   **Required Fields** - none  **Read-Only** - id
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="customFieldId">The ID of the &#x60;CustomField&#x60;. </param>
        /// <returns>Task of ApiResponse (InlineResponse2007)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2007>> UpdateCustomFieldAsyncWithHttpInfo (CustomField1 body, string accept, string contentType, int? productId, int? customFieldId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class ProductCustomFieldsApi : IProductCustomFieldsApi
    {
        private BigCommerce.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCustomFieldsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductCustomFieldsApi(String basePath)
        {
            this.Configuration = new BigCommerce.Client.Configuration { BasePath = basePath };

            ExceptionFactory = BigCommerce.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCustomFieldsApi"/> class
        /// </summary>
        /// <returns></returns>
        public ProductCustomFieldsApi()
        {
            this.Configuration = BigCommerce.Client.Configuration.Default;

            ExceptionFactory = BigCommerce.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductCustomFieldsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProductCustomFieldsApi(BigCommerce.Client.Configuration configuration = null)
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
        /// Create a Custom Fields Creates a *Custom Field*.  **Required Fields:** - name - value  **Read-Only:** - id
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>InlineResponse2007</returns>
        public InlineResponse2007 CreateCustomField (CustomField body, string accept, string contentType, int? productId)
        {
             ApiResponse<InlineResponse2007> localVarResponse = CreateCustomFieldWithHttpInfo(body, accept, contentType, productId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Custom Fields Creates a *Custom Field*.  **Required Fields:** - name - value  **Read-Only:** - id
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>ApiResponse of InlineResponse2007</returns>
        public ApiResponse< InlineResponse2007 > CreateCustomFieldWithHttpInfo (CustomField body, string accept, string contentType, int? productId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductCustomFieldsApi->CreateCustomField");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductCustomFieldsApi->CreateCustomField");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductCustomFieldsApi->CreateCustomField");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductCustomFieldsApi->CreateCustomField");

            var localVarPath = "/catalog/products/{product_id}/custom-fields";
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
                Exception exception = ExceptionFactory("CreateCustomField", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2007>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2007) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2007)));
        }

        /// <summary>
        /// Create a Custom Fields Creates a *Custom Field*.  **Required Fields:** - name - value  **Read-Only:** - id
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>Task of InlineResponse2007</returns>
        public async System.Threading.Tasks.Task<InlineResponse2007> CreateCustomFieldAsync (CustomField body, string accept, string contentType, int? productId)
        {
             ApiResponse<InlineResponse2007> localVarResponse = await CreateCustomFieldAsyncWithHttpInfo(body, accept, contentType, productId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Custom Fields Creates a *Custom Field*.  **Required Fields:** - name - value  **Read-Only:** - id
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>Task of ApiResponse (InlineResponse2007)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2007>> CreateCustomFieldAsyncWithHttpInfo (CustomField body, string accept, string contentType, int? productId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductCustomFieldsApi->CreateCustomField");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductCustomFieldsApi->CreateCustomField");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductCustomFieldsApi->CreateCustomField");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductCustomFieldsApi->CreateCustomField");

            var localVarPath = "/catalog/products/{product_id}/custom-fields";
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
                Exception exception = ExceptionFactory("CreateCustomField", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2007>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2007) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2007)));
        }

        /// <summary>
        /// Delete a Custom Field Deletes a product *Custom Field*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="customFieldId">The ID of the &#x60;CustomField&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public void DeleteCustomFieldById (int? productId, int? customFieldId, string accept, string contentType)
        {
             DeleteCustomFieldByIdWithHttpInfo(productId, customFieldId, accept, contentType);
        }

        /// <summary>
        /// Delete a Custom Field Deletes a product *Custom Field*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="customFieldId">The ID of the &#x60;CustomField&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteCustomFieldByIdWithHttpInfo (int? productId, int? customFieldId, string accept, string contentType)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductCustomFieldsApi->DeleteCustomFieldById");
            // verify the required parameter 'customFieldId' is set
            if (customFieldId == null)
                throw new ApiException(400, "Missing required parameter 'customFieldId' when calling ProductCustomFieldsApi->DeleteCustomFieldById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductCustomFieldsApi->DeleteCustomFieldById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductCustomFieldsApi->DeleteCustomFieldById");

            var localVarPath = "/catalog/products/{product_id}/custom-fields/{custom_field_id}";
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
            if (customFieldId != null) localVarPathParams.Add("custom_field_id", this.Configuration.ApiClient.ParameterToString(customFieldId)); // path parameter
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
                Exception exception = ExceptionFactory("DeleteCustomFieldById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Delete a Custom Field Deletes a product *Custom Field*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="customFieldId">The ID of the &#x60;CustomField&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteCustomFieldByIdAsync (int? productId, int? customFieldId, string accept, string contentType)
        {
             await DeleteCustomFieldByIdAsyncWithHttpInfo(productId, customFieldId, accept, contentType);

        }

        /// <summary>
        /// Delete a Custom Field Deletes a product *Custom Field*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="customFieldId">The ID of the &#x60;CustomField&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteCustomFieldByIdAsyncWithHttpInfo (int? productId, int? customFieldId, string accept, string contentType)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductCustomFieldsApi->DeleteCustomFieldById");
            // verify the required parameter 'customFieldId' is set
            if (customFieldId == null)
                throw new ApiException(400, "Missing required parameter 'customFieldId' when calling ProductCustomFieldsApi->DeleteCustomFieldById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductCustomFieldsApi->DeleteCustomFieldById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductCustomFieldsApi->DeleteCustomFieldById");

            var localVarPath = "/catalog/products/{product_id}/custom-fields/{custom_field_id}";
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
            if (customFieldId != null) localVarPathParams.Add("custom_field_id", this.Configuration.ApiClient.ParameterToString(customFieldId)); // path parameter
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
                Exception exception = ExceptionFactory("DeleteCustomFieldById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Get a Custom Field Returns a single *Custom Field*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="customFieldId">The ID of the &#x60;CustomField&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>InlineResponse2008</returns>
        public InlineResponse2008 GetCustomFieldById (int? productId, int? customFieldId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<InlineResponse2008> localVarResponse = GetCustomFieldByIdWithHttpInfo(productId, customFieldId, accept, contentType, includeFields, excludeFields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Custom Field Returns a single *Custom Field*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="customFieldId">The ID of the &#x60;CustomField&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2008</returns>
        public ApiResponse< InlineResponse2008 > GetCustomFieldByIdWithHttpInfo (int? productId, int? customFieldId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductCustomFieldsApi->GetCustomFieldById");
            // verify the required parameter 'customFieldId' is set
            if (customFieldId == null)
                throw new ApiException(400, "Missing required parameter 'customFieldId' when calling ProductCustomFieldsApi->GetCustomFieldById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductCustomFieldsApi->GetCustomFieldById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductCustomFieldsApi->GetCustomFieldById");

            var localVarPath = "/catalog/products/{product_id}/custom-fields/{custom_field_id}";
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
            if (customFieldId != null) localVarPathParams.Add("custom_field_id", this.Configuration.ApiClient.ParameterToString(customFieldId)); // path parameter
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
                Exception exception = ExceptionFactory("GetCustomFieldById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2008>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2008) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2008)));
        }

        /// <summary>
        /// Get a Custom Field Returns a single *Custom Field*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="customFieldId">The ID of the &#x60;CustomField&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of InlineResponse2008</returns>
        public async System.Threading.Tasks.Task<InlineResponse2008> GetCustomFieldByIdAsync (int? productId, int? customFieldId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<InlineResponse2008> localVarResponse = await GetCustomFieldByIdAsyncWithHttpInfo(productId, customFieldId, accept, contentType, includeFields, excludeFields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Custom Field Returns a single *Custom Field*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="customFieldId">The ID of the &#x60;CustomField&#x60;. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2008)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2008>> GetCustomFieldByIdAsyncWithHttpInfo (int? productId, int? customFieldId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductCustomFieldsApi->GetCustomFieldById");
            // verify the required parameter 'customFieldId' is set
            if (customFieldId == null)
                throw new ApiException(400, "Missing required parameter 'customFieldId' when calling ProductCustomFieldsApi->GetCustomFieldById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductCustomFieldsApi->GetCustomFieldById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductCustomFieldsApi->GetCustomFieldById");

            var localVarPath = "/catalog/products/{product_id}/custom-fields/{custom_field_id}";
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
            if (customFieldId != null) localVarPathParams.Add("custom_field_id", this.Configuration.ApiClient.ParameterToString(customFieldId)); // path parameter
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
                Exception exception = ExceptionFactory("GetCustomFieldById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2008>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2008) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2008)));
        }

        /// <summary>
        /// Get Custom Fields Returns a list of product *Custom Fields*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>InlineResponse2006</returns>
        public InlineResponse2006 GetCustomFields (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null, int? page = null, int? limit = null)
        {
             ApiResponse<InlineResponse2006> localVarResponse = GetCustomFieldsWithHttpInfo(productId, accept, contentType, includeFields, excludeFields, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Custom Fields Returns a list of product *Custom Fields*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>ApiResponse of InlineResponse2006</returns>
        public ApiResponse< InlineResponse2006 > GetCustomFieldsWithHttpInfo (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductCustomFieldsApi->GetCustomFields");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductCustomFieldsApi->GetCustomFields");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductCustomFieldsApi->GetCustomFields");

            var localVarPath = "/catalog/products/{product_id}/custom-fields";
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
                Exception exception = ExceptionFactory("GetCustomFields", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2006>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2006) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2006)));
        }

        /// <summary>
        /// Get Custom Fields Returns a list of product *Custom Fields*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>Task of InlineResponse2006</returns>
        public async System.Threading.Tasks.Task<InlineResponse2006> GetCustomFieldsAsync (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null, int? page = null, int? limit = null)
        {
             ApiResponse<InlineResponse2006> localVarResponse = await GetCustomFieldsAsyncWithHttpInfo(productId, accept, contentType, includeFields, excludeFields, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Custom Fields Returns a list of product *Custom Fields*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse2006)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2006>> GetCustomFieldsAsyncWithHttpInfo (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductCustomFieldsApi->GetCustomFields");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductCustomFieldsApi->GetCustomFields");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductCustomFieldsApi->GetCustomFields");

            var localVarPath = "/catalog/products/{product_id}/custom-fields";
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
                Exception exception = ExceptionFactory("GetCustomFields", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2006>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2006) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2006)));
        }

        /// <summary>
        /// Update a Custom Field Updates a *Custom Field*.   **Required Fields** - none  **Read-Only** - id
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="customFieldId">The ID of the &#x60;CustomField&#x60;. </param>
        /// <returns>InlineResponse2007</returns>
        public InlineResponse2007 UpdateCustomField (CustomField1 body, string accept, string contentType, int? productId, int? customFieldId)
        {
             ApiResponse<InlineResponse2007> localVarResponse = UpdateCustomFieldWithHttpInfo(body, accept, contentType, productId, customFieldId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a Custom Field Updates a *Custom Field*.   **Required Fields** - none  **Read-Only** - id
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="customFieldId">The ID of the &#x60;CustomField&#x60;. </param>
        /// <returns>ApiResponse of InlineResponse2007</returns>
        public ApiResponse< InlineResponse2007 > UpdateCustomFieldWithHttpInfo (CustomField1 body, string accept, string contentType, int? productId, int? customFieldId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductCustomFieldsApi->UpdateCustomField");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductCustomFieldsApi->UpdateCustomField");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductCustomFieldsApi->UpdateCustomField");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductCustomFieldsApi->UpdateCustomField");
            // verify the required parameter 'customFieldId' is set
            if (customFieldId == null)
                throw new ApiException(400, "Missing required parameter 'customFieldId' when calling ProductCustomFieldsApi->UpdateCustomField");

            var localVarPath = "/catalog/products/{product_id}/custom-fields/{custom_field_id}";
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
            if (customFieldId != null) localVarPathParams.Add("custom_field_id", this.Configuration.ApiClient.ParameterToString(customFieldId)); // path parameter
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
                Exception exception = ExceptionFactory("UpdateCustomField", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2007>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2007) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2007)));
        }

        /// <summary>
        /// Update a Custom Field Updates a *Custom Field*.   **Required Fields** - none  **Read-Only** - id
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="customFieldId">The ID of the &#x60;CustomField&#x60;. </param>
        /// <returns>Task of InlineResponse2007</returns>
        public async System.Threading.Tasks.Task<InlineResponse2007> UpdateCustomFieldAsync (CustomField1 body, string accept, string contentType, int? productId, int? customFieldId)
        {
             ApiResponse<InlineResponse2007> localVarResponse = await UpdateCustomFieldAsyncWithHttpInfo(body, accept, contentType, productId, customFieldId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a Custom Field Updates a *Custom Field*.   **Required Fields** - none  **Read-Only** - id
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="customFieldId">The ID of the &#x60;CustomField&#x60;. </param>
        /// <returns>Task of ApiResponse (InlineResponse2007)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2007>> UpdateCustomFieldAsyncWithHttpInfo (CustomField1 body, string accept, string contentType, int? productId, int? customFieldId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductCustomFieldsApi->UpdateCustomField");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductCustomFieldsApi->UpdateCustomField");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductCustomFieldsApi->UpdateCustomField");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductCustomFieldsApi->UpdateCustomField");
            // verify the required parameter 'customFieldId' is set
            if (customFieldId == null)
                throw new ApiException(400, "Missing required parameter 'customFieldId' when calling ProductCustomFieldsApi->UpdateCustomField");

            var localVarPath = "/catalog/products/{product_id}/custom-fields/{custom_field_id}";
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
            if (customFieldId != null) localVarPathParams.Add("custom_field_id", this.Configuration.ApiClient.ParameterToString(customFieldId)); // path parameter
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
                Exception exception = ExceptionFactory("UpdateCustomField", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2007>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2007) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2007)));
        }

    }
}
