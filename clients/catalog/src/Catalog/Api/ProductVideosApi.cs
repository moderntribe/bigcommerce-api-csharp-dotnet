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
        public interface IProductVideosApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a Product Video
        /// </summary>
        /// <remarks>
        /// Creates a *Product Video*.  **Required Fields** * video_id - Example: https://www.youtube.com/watch?v&#x3D;&#x60;R12345677&#x60;  **Read-Only Fields** * id  Publicly accessible URLs are valid parameters. Videos must be loaded through YouTube at this time. 
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>ProductVideoResponse</returns>
        ProductVideoResponse CreateProductVideo (ProductVideoPost body, string accept, string contentType, int? productId);

        /// <summary>
        /// Create a Product Video
        /// </summary>
        /// <remarks>
        /// Creates a *Product Video*.  **Required Fields** * video_id - Example: https://www.youtube.com/watch?v&#x3D;&#x60;R12345677&#x60;  **Read-Only Fields** * id  Publicly accessible URLs are valid parameters. Videos must be loaded through YouTube at this time. 
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>ApiResponse of ProductVideoResponse</returns>
        ApiResponse<ProductVideoResponse> CreateProductVideoWithHttpInfo (ProductVideoPost body, string accept, string contentType, int? productId);
        /// <summary>
        /// Delete a Product Video
        /// </summary>
        /// <remarks>
        /// Deletes a *Product Video*.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="id">The BigCommerce ID of the &#x60;Video&#x60;</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void DeleteProductVideo (int? productId, int? id, string accept, string contentType);

        /// <summary>
        /// Delete a Product Video
        /// </summary>
        /// <remarks>
        /// Deletes a *Product Video*.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="id">The BigCommerce ID of the &#x60;Video&#x60;</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteProductVideoWithHttpInfo (int? productId, int? id, string accept, string contentType);
        /// <summary>
        /// Get a Product Video
        /// </summary>
        /// <remarks>
        /// Returns a single *Product Video*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="id">The BigCommerce ID of the &#x60;Video&#x60;</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ProductVideoResponse1</returns>
        ProductVideoResponse1 GetProductVideoById (int? productId, int? id, string accept, string contentType, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get a Product Video
        /// </summary>
        /// <remarks>
        /// Returns a single *Product Video*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="id">The BigCommerce ID of the &#x60;Video&#x60;</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of ProductVideoResponse1</returns>
        ApiResponse<ProductVideoResponse1> GetProductVideoByIdWithHttpInfo (int? productId, int? id, string accept, string contentType, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Get All Product Videos
        /// </summary>
        /// <remarks>
        /// Returns a list of *Product Videos*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ProductVideoCollectionResponse</returns>
        ProductVideoCollectionResponse GetProductVideos (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get All Product Videos
        /// </summary>
        /// <remarks>
        /// Returns a list of *Product Videos*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of ProductVideoCollectionResponse</returns>
        ApiResponse<ProductVideoCollectionResponse> GetProductVideosWithHttpInfo (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Update a Product Video
        /// </summary>
        /// <remarks>
        /// Updates a *Product Video.  **Required Fields** * none  **Read-Only Fields** * id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="id">The BigCommerce ID of the &#x60;Video&#x60;</param>
        /// <returns>ProductVideoResponse</returns>
        ProductVideoResponse UpdateProductVideo (ProductVideoPut body, string accept, string contentType, int? productId, int? id);

        /// <summary>
        /// Update a Product Video
        /// </summary>
        /// <remarks>
        /// Updates a *Product Video.  **Required Fields** * none  **Read-Only Fields** * id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="id">The BigCommerce ID of the &#x60;Video&#x60;</param>
        /// <returns>ApiResponse of ProductVideoResponse</returns>
        ApiResponse<ProductVideoResponse> UpdateProductVideoWithHttpInfo (ProductVideoPut body, string accept, string contentType, int? productId, int? id);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create a Product Video
        /// </summary>
        /// <remarks>
        /// Creates a *Product Video*.  **Required Fields** * video_id - Example: https://www.youtube.com/watch?v&#x3D;&#x60;R12345677&#x60;  **Read-Only Fields** * id  Publicly accessible URLs are valid parameters. Videos must be loaded through YouTube at this time. 
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>Task of ProductVideoResponse</returns>
        System.Threading.Tasks.Task<ProductVideoResponse> CreateProductVideoAsync (ProductVideoPost body, string accept, string contentType, int? productId);

        /// <summary>
        /// Create a Product Video
        /// </summary>
        /// <remarks>
        /// Creates a *Product Video*.  **Required Fields** * video_id - Example: https://www.youtube.com/watch?v&#x3D;&#x60;R12345677&#x60;  **Read-Only Fields** * id  Publicly accessible URLs are valid parameters. Videos must be loaded through YouTube at this time. 
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>Task of ApiResponse (ProductVideoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductVideoResponse>> CreateProductVideoAsyncWithHttpInfo (ProductVideoPost body, string accept, string contentType, int? productId);
        /// <summary>
        /// Delete a Product Video
        /// </summary>
        /// <remarks>
        /// Deletes a *Product Video*.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="id">The BigCommerce ID of the &#x60;Video&#x60;</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteProductVideoAsync (int? productId, int? id, string accept, string contentType);

        /// <summary>
        /// Delete a Product Video
        /// </summary>
        /// <remarks>
        /// Deletes a *Product Video*.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="id">The BigCommerce ID of the &#x60;Video&#x60;</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteProductVideoAsyncWithHttpInfo (int? productId, int? id, string accept, string contentType);
        /// <summary>
        /// Get a Product Video
        /// </summary>
        /// <remarks>
        /// Returns a single *Product Video*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="id">The BigCommerce ID of the &#x60;Video&#x60;</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ProductVideoResponse1</returns>
        System.Threading.Tasks.Task<ProductVideoResponse1> GetProductVideoByIdAsync (int? productId, int? id, string accept, string contentType, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get a Product Video
        /// </summary>
        /// <remarks>
        /// Returns a single *Product Video*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="id">The BigCommerce ID of the &#x60;Video&#x60;</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (ProductVideoResponse1)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductVideoResponse1>> GetProductVideoByIdAsyncWithHttpInfo (int? productId, int? id, string accept, string contentType, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Get All Product Videos
        /// </summary>
        /// <remarks>
        /// Returns a list of *Product Videos*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ProductVideoCollectionResponse</returns>
        System.Threading.Tasks.Task<ProductVideoCollectionResponse> GetProductVideosAsync (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get All Product Videos
        /// </summary>
        /// <remarks>
        /// Returns a list of *Product Videos*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (ProductVideoCollectionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductVideoCollectionResponse>> GetProductVideosAsyncWithHttpInfo (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Update a Product Video
        /// </summary>
        /// <remarks>
        /// Updates a *Product Video.  **Required Fields** * none  **Read-Only Fields** * id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="id">The BigCommerce ID of the &#x60;Video&#x60;</param>
        /// <returns>Task of ProductVideoResponse</returns>
        System.Threading.Tasks.Task<ProductVideoResponse> UpdateProductVideoAsync (ProductVideoPut body, string accept, string contentType, int? productId, int? id);

        /// <summary>
        /// Update a Product Video
        /// </summary>
        /// <remarks>
        /// Updates a *Product Video.  **Required Fields** * none  **Read-Only Fields** * id
        /// </remarks>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="id">The BigCommerce ID of the &#x60;Video&#x60;</param>
        /// <returns>Task of ApiResponse (ProductVideoResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<ProductVideoResponse>> UpdateProductVideoAsyncWithHttpInfo (ProductVideoPut body, string accept, string contentType, int? productId, int? id);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class ProductVideosApi : IProductVideosApi
    {
        private Catalog.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductVideosApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ProductVideosApi(String basePath)
        {
            this.Configuration = new Catalog.Client.Configuration { BasePath = basePath };

            ExceptionFactory = Catalog.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductVideosApi"/> class
        /// </summary>
        /// <returns></returns>
        public ProductVideosApi()
        {
            this.Configuration = Catalog.Client.Configuration.Default;

            ExceptionFactory = Catalog.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductVideosApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ProductVideosApi(Catalog.Client.Configuration configuration = null)
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
        /// Create a Product Video Creates a *Product Video*.  **Required Fields** * video_id - Example: https://www.youtube.com/watch?v&#x3D;&#x60;R12345677&#x60;  **Read-Only Fields** * id  Publicly accessible URLs are valid parameters. Videos must be loaded through YouTube at this time. 
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>ProductVideoResponse</returns>
        public ProductVideoResponse CreateProductVideo (ProductVideoPost body, string accept, string contentType, int? productId)
        {
             ApiResponse<ProductVideoResponse> localVarResponse = CreateProductVideoWithHttpInfo(body, accept, contentType, productId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Product Video Creates a *Product Video*.  **Required Fields** * video_id - Example: https://www.youtube.com/watch?v&#x3D;&#x60;R12345677&#x60;  **Read-Only Fields** * id  Publicly accessible URLs are valid parameters. Videos must be loaded through YouTube at this time. 
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>ApiResponse of ProductVideoResponse</returns>
        public ApiResponse< ProductVideoResponse > CreateProductVideoWithHttpInfo (ProductVideoPost body, string accept, string contentType, int? productId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductVideosApi->CreateProductVideo");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductVideosApi->CreateProductVideo");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductVideosApi->CreateProductVideo");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVideosApi->CreateProductVideo");

            var localVarPath = "/catalog/products/{product_id}/videos";
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
                Exception exception = ExceptionFactory("CreateProductVideo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProductVideoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ProductVideoResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductVideoResponse)));
        }

        /// <summary>
        /// Create a Product Video Creates a *Product Video*.  **Required Fields** * video_id - Example: https://www.youtube.com/watch?v&#x3D;&#x60;R12345677&#x60;  **Read-Only Fields** * id  Publicly accessible URLs are valid parameters. Videos must be loaded through YouTube at this time. 
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>Task of ProductVideoResponse</returns>
        public async System.Threading.Tasks.Task<ProductVideoResponse> CreateProductVideoAsync (ProductVideoPost body, string accept, string contentType, int? productId)
        {
             ApiResponse<ProductVideoResponse> localVarResponse = await CreateProductVideoAsyncWithHttpInfo(body, accept, contentType, productId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Product Video Creates a *Product Video*.  **Required Fields** * video_id - Example: https://www.youtube.com/watch?v&#x3D;&#x60;R12345677&#x60;  **Read-Only Fields** * id  Publicly accessible URLs are valid parameters. Videos must be loaded through YouTube at this time. 
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <returns>Task of ApiResponse (ProductVideoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductVideoResponse>> CreateProductVideoAsyncWithHttpInfo (ProductVideoPost body, string accept, string contentType, int? productId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductVideosApi->CreateProductVideo");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductVideosApi->CreateProductVideo");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductVideosApi->CreateProductVideo");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVideosApi->CreateProductVideo");

            var localVarPath = "/catalog/products/{product_id}/videos";
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
                Exception exception = ExceptionFactory("CreateProductVideo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProductVideoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ProductVideoResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductVideoResponse)));
        }

        /// <summary>
        /// Delete a Product Video Deletes a *Product Video*.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="id">The BigCommerce ID of the &#x60;Video&#x60;</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public void DeleteProductVideo (int? productId, int? id, string accept, string contentType)
        {
             DeleteProductVideoWithHttpInfo(productId, id, accept, contentType);
        }

        /// <summary>
        /// Delete a Product Video Deletes a *Product Video*.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="id">The BigCommerce ID of the &#x60;Video&#x60;</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteProductVideoWithHttpInfo (int? productId, int? id, string accept, string contentType)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVideosApi->DeleteProductVideo");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ProductVideosApi->DeleteProductVideo");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductVideosApi->DeleteProductVideo");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductVideosApi->DeleteProductVideo");

            var localVarPath = "/catalog/products/{product_id}/videos/{id}";
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
            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
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
                Exception exception = ExceptionFactory("DeleteProductVideo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Delete a Product Video Deletes a *Product Video*.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="id">The BigCommerce ID of the &#x60;Video&#x60;</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteProductVideoAsync (int? productId, int? id, string accept, string contentType)
        {
             await DeleteProductVideoAsyncWithHttpInfo(productId, id, accept, contentType);

        }

        /// <summary>
        /// Delete a Product Video Deletes a *Product Video*.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="id">The BigCommerce ID of the &#x60;Video&#x60;</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteProductVideoAsyncWithHttpInfo (int? productId, int? id, string accept, string contentType)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVideosApi->DeleteProductVideo");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ProductVideosApi->DeleteProductVideo");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductVideosApi->DeleteProductVideo");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductVideosApi->DeleteProductVideo");

            var localVarPath = "/catalog/products/{product_id}/videos/{id}";
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
            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
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
                Exception exception = ExceptionFactory("DeleteProductVideo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Get a Product Video Returns a single *Product Video*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="id">The BigCommerce ID of the &#x60;Video&#x60;</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ProductVideoResponse1</returns>
        public ProductVideoResponse1 GetProductVideoById (int? productId, int? id, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<ProductVideoResponse1> localVarResponse = GetProductVideoByIdWithHttpInfo(productId, id, accept, contentType, includeFields, excludeFields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Product Video Returns a single *Product Video*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="id">The BigCommerce ID of the &#x60;Video&#x60;</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of ProductVideoResponse1</returns>
        public ApiResponse< ProductVideoResponse1 > GetProductVideoByIdWithHttpInfo (int? productId, int? id, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVideosApi->GetProductVideoById");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ProductVideosApi->GetProductVideoById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductVideosApi->GetProductVideoById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductVideosApi->GetProductVideoById");

            var localVarPath = "/catalog/products/{product_id}/videos/{id}";
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
            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
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
                Exception exception = ExceptionFactory("GetProductVideoById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProductVideoResponse1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ProductVideoResponse1) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductVideoResponse1)));
        }

        /// <summary>
        /// Get a Product Video Returns a single *Product Video*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="id">The BigCommerce ID of the &#x60;Video&#x60;</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ProductVideoResponse1</returns>
        public async System.Threading.Tasks.Task<ProductVideoResponse1> GetProductVideoByIdAsync (int? productId, int? id, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<ProductVideoResponse1> localVarResponse = await GetProductVideoByIdAsyncWithHttpInfo(productId, id, accept, contentType, includeFields, excludeFields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Product Video Returns a single *Product Video*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="id">The BigCommerce ID of the &#x60;Video&#x60;</param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (ProductVideoResponse1)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductVideoResponse1>> GetProductVideoByIdAsyncWithHttpInfo (int? productId, int? id, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVideosApi->GetProductVideoById");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ProductVideosApi->GetProductVideoById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductVideosApi->GetProductVideoById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductVideosApi->GetProductVideoById");

            var localVarPath = "/catalog/products/{product_id}/videos/{id}";
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
            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
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
                Exception exception = ExceptionFactory("GetProductVideoById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProductVideoResponse1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ProductVideoResponse1) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductVideoResponse1)));
        }

        /// <summary>
        /// Get All Product Videos Returns a list of *Product Videos*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ProductVideoCollectionResponse</returns>
        public ProductVideoCollectionResponse GetProductVideos (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<ProductVideoCollectionResponse> localVarResponse = GetProductVideosWithHttpInfo(productId, accept, contentType, includeFields, excludeFields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get All Product Videos Returns a list of *Product Videos*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of ProductVideoCollectionResponse</returns>
        public ApiResponse< ProductVideoCollectionResponse > GetProductVideosWithHttpInfo (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVideosApi->GetProductVideos");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductVideosApi->GetProductVideos");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductVideosApi->GetProductVideos");

            var localVarPath = "/catalog/products/{product_id}/videos";
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
                Exception exception = ExceptionFactory("GetProductVideos", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProductVideoCollectionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ProductVideoCollectionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductVideoCollectionResponse)));
        }

        /// <summary>
        /// Get All Product Videos Returns a list of *Product Videos*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ProductVideoCollectionResponse</returns>
        public async System.Threading.Tasks.Task<ProductVideoCollectionResponse> GetProductVideosAsync (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<ProductVideoCollectionResponse> localVarResponse = await GetProductVideosAsyncWithHttpInfo(productId, accept, contentType, includeFields, excludeFields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get All Product Videos Returns a list of *Product Videos*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (ProductVideoCollectionResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductVideoCollectionResponse>> GetProductVideosAsyncWithHttpInfo (int? productId, string accept, string contentType, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVideosApi->GetProductVideos");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductVideosApi->GetProductVideos");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductVideosApi->GetProductVideos");

            var localVarPath = "/catalog/products/{product_id}/videos";
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
                Exception exception = ExceptionFactory("GetProductVideos", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProductVideoCollectionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ProductVideoCollectionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductVideoCollectionResponse)));
        }

        /// <summary>
        /// Update a Product Video Updates a *Product Video.  **Required Fields** * none  **Read-Only Fields** * id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="id">The BigCommerce ID of the &#x60;Video&#x60;</param>
        /// <returns>ProductVideoResponse</returns>
        public ProductVideoResponse UpdateProductVideo (ProductVideoPut body, string accept, string contentType, int? productId, int? id)
        {
             ApiResponse<ProductVideoResponse> localVarResponse = UpdateProductVideoWithHttpInfo(body, accept, contentType, productId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a Product Video Updates a *Product Video.  **Required Fields** * none  **Read-Only Fields** * id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="id">The BigCommerce ID of the &#x60;Video&#x60;</param>
        /// <returns>ApiResponse of ProductVideoResponse</returns>
        public ApiResponse< ProductVideoResponse > UpdateProductVideoWithHttpInfo (ProductVideoPut body, string accept, string contentType, int? productId, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductVideosApi->UpdateProductVideo");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductVideosApi->UpdateProductVideo");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductVideosApi->UpdateProductVideo");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVideosApi->UpdateProductVideo");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ProductVideosApi->UpdateProductVideo");

            var localVarPath = "/catalog/products/{product_id}/videos/{id}";
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
            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
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
                Exception exception = ExceptionFactory("UpdateProductVideo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProductVideoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ProductVideoResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductVideoResponse)));
        }

        /// <summary>
        /// Update a Product Video Updates a *Product Video.  **Required Fields** * none  **Read-Only Fields** * id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="id">The BigCommerce ID of the &#x60;Video&#x60;</param>
        /// <returns>Task of ProductVideoResponse</returns>
        public async System.Threading.Tasks.Task<ProductVideoResponse> UpdateProductVideoAsync (ProductVideoPut body, string accept, string contentType, int? productId, int? id)
        {
             ApiResponse<ProductVideoResponse> localVarResponse = await UpdateProductVideoAsyncWithHttpInfo(body, accept, contentType, productId, id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a Product Video Updates a *Product Video.  **Required Fields** * none  **Read-Only Fields** * id
        /// </summary>
        /// <exception cref="Catalog.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="productId">The ID of the &#x60;Product&#x60; to which the resource belongs. </param>
        /// <param name="id">The BigCommerce ID of the &#x60;Video&#x60;</param>
        /// <returns>Task of ApiResponse (ProductVideoResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<ProductVideoResponse>> UpdateProductVideoAsyncWithHttpInfo (ProductVideoPut body, string accept, string contentType, int? productId, int? id)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling ProductVideosApi->UpdateProductVideo");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling ProductVideosApi->UpdateProductVideo");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling ProductVideosApi->UpdateProductVideo");
            // verify the required parameter 'productId' is set
            if (productId == null)
                throw new ApiException(400, "Missing required parameter 'productId' when calling ProductVideosApi->UpdateProductVideo");
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling ProductVideosApi->UpdateProductVideo");

            var localVarPath = "/catalog/products/{product_id}/videos/{id}";
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
            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter
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
                Exception exception = ExceptionFactory("UpdateProductVideo", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<ProductVideoResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (ProductVideoResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(ProductVideoResponse)));
        }

    }
}
