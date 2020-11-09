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
        public interface IBrandsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a Brand
        /// </summary>
        /// <remarks>
        /// Creates a *Brand*.  **Required Fields** - name  **Read-Only Fields** - id
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>BrandResponse</returns>
        BrandResponse CreateBrand (Brand body, string accept, string contentType);

        /// <summary>
        /// Create a Brand
        /// </summary>
        /// <remarks>
        /// Creates a *Brand*.  **Required Fields** - name  **Read-Only Fields** - id
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of BrandResponse</returns>
        ApiResponse<BrandResponse> CreateBrandWithHttpInfo (Brand body, string accept, string contentType);
        /// <summary>
        /// Delete a Brand
        /// </summary>
        /// <remarks>
        /// Deletes a *Brand*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        void DeleteBrandById (int? brandId, string accept, string contentType);

        /// <summary>
        /// Delete a Brand
        /// </summary>
        /// <remarks>
        /// Deletes a *Brand*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteBrandByIdWithHttpInfo (int? brandId, string accept, string contentType);
        /// <summary>
        /// Delete Brands
        /// </summary>
        /// <remarks>
        /// By default, it deletes all *Brand* objects. A filter should be added to avoid deleting all *Brand* objects in a store.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <returns></returns>
        void DeleteBrands (string accept, string contentType, string name = null, string pageTitle = null);

        /// <summary>
        /// Delete Brands
        /// </summary>
        /// <remarks>
        /// By default, it deletes all *Brand* objects. A filter should be added to avoid deleting all *Brand* objects in a store.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteBrandsWithHttpInfo (string accept, string contentType, string name = null, string pageTitle = null);
        /// <summary>
        /// Get a Brand
        /// </summary>
        /// <remarks>
        /// Returns a single *Brand*. Optional filter parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>BrandResponse1</returns>
        BrandResponse1 GetBrandById (int? brandId, string contentType, string accept, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get a Brand
        /// </summary>
        /// <remarks>
        /// Returns a single *Brand*. Optional filter parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of BrandResponse1</returns>
        ApiResponse<BrandResponse1> GetBrandByIdWithHttpInfo (int? brandId, string contentType, string accept, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Get All Brands
        /// </summary>
        /// <remarks>
        /// Returns a list of *Brands*. Optional filter parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>BrandCollectionResponse</returns>
        BrandCollectionResponse GetBrands (string accept, string contentType, int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, string name = null, string pageTitle = null, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get All Brands
        /// </summary>
        /// <remarks>
        /// Returns a list of *Brands*. Optional filter parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of BrandCollectionResponse</returns>
        ApiResponse<BrandCollectionResponse> GetBrandsWithHttpInfo (string accept, string contentType, int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, string name = null, string pageTitle = null, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Update a Brand
        /// </summary>
        /// <remarks>
        /// Updates a *Brand*.  **Required Fields** - None  **Read-Only Fields** - id  To update a *Brand Image*, send a request with an &#x60;image_url&#x60;.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <returns>BrandResponse</returns>
        BrandResponse UpdateBrand (Brand1 body, string contentType, string accept, int? brandId);

        /// <summary>
        /// Update a Brand
        /// </summary>
        /// <remarks>
        /// Updates a *Brand*.  **Required Fields** - None  **Read-Only Fields** - id  To update a *Brand Image*, send a request with an &#x60;image_url&#x60;.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <returns>ApiResponse of BrandResponse</returns>
        ApiResponse<BrandResponse> UpdateBrandWithHttpInfo (Brand1 body, string contentType, string accept, int? brandId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create a Brand
        /// </summary>
        /// <remarks>
        /// Creates a *Brand*.  **Required Fields** - name  **Read-Only Fields** - id
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of BrandResponse</returns>
        System.Threading.Tasks.Task<BrandResponse> CreateBrandAsync (Brand body, string accept, string contentType);

        /// <summary>
        /// Create a Brand
        /// </summary>
        /// <remarks>
        /// Creates a *Brand*.  **Required Fields** - name  **Read-Only Fields** - id
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse (BrandResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BrandResponse>> CreateBrandAsyncWithHttpInfo (Brand body, string accept, string contentType);
        /// <summary>
        /// Delete a Brand
        /// </summary>
        /// <remarks>
        /// Deletes a *Brand*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteBrandByIdAsync (int? brandId, string accept, string contentType);

        /// <summary>
        /// Delete a Brand
        /// </summary>
        /// <remarks>
        /// Deletes a *Brand*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBrandByIdAsyncWithHttpInfo (int? brandId, string accept, string contentType);
        /// <summary>
        /// Delete Brands
        /// </summary>
        /// <remarks>
        /// By default, it deletes all *Brand* objects. A filter should be added to avoid deleting all *Brand* objects in a store.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteBrandsAsync (string accept, string contentType, string name = null, string pageTitle = null);

        /// <summary>
        /// Delete Brands
        /// </summary>
        /// <remarks>
        /// By default, it deletes all *Brand* objects. A filter should be added to avoid deleting all *Brand* objects in a store.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBrandsAsyncWithHttpInfo (string accept, string contentType, string name = null, string pageTitle = null);
        /// <summary>
        /// Get a Brand
        /// </summary>
        /// <remarks>
        /// Returns a single *Brand*. Optional filter parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of BrandResponse1</returns>
        System.Threading.Tasks.Task<BrandResponse1> GetBrandByIdAsync (int? brandId, string contentType, string accept, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get a Brand
        /// </summary>
        /// <remarks>
        /// Returns a single *Brand*. Optional filter parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (BrandResponse1)</returns>
        System.Threading.Tasks.Task<ApiResponse<BrandResponse1>> GetBrandByIdAsyncWithHttpInfo (int? brandId, string contentType, string accept, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Get All Brands
        /// </summary>
        /// <remarks>
        /// Returns a list of *Brands*. Optional filter parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of BrandCollectionResponse</returns>
        System.Threading.Tasks.Task<BrandCollectionResponse> GetBrandsAsync (string accept, string contentType, int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, string name = null, string pageTitle = null, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null);

        /// <summary>
        /// Get All Brands
        /// </summary>
        /// <remarks>
        /// Returns a list of *Brands*. Optional filter parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (BrandCollectionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BrandCollectionResponse>> GetBrandsAsyncWithHttpInfo (string accept, string contentType, int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, string name = null, string pageTitle = null, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null);
        /// <summary>
        /// Update a Brand
        /// </summary>
        /// <remarks>
        /// Updates a *Brand*.  **Required Fields** - None  **Read-Only Fields** - id  To update a *Brand Image*, send a request with an &#x60;image_url&#x60;.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <returns>Task of BrandResponse</returns>
        System.Threading.Tasks.Task<BrandResponse> UpdateBrandAsync (Brand1 body, string contentType, string accept, int? brandId);

        /// <summary>
        /// Update a Brand
        /// </summary>
        /// <remarks>
        /// Updates a *Brand*.  **Required Fields** - None  **Read-Only Fields** - id  To update a *Brand Image*, send a request with an &#x60;image_url&#x60;.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <returns>Task of ApiResponse (BrandResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<BrandResponse>> UpdateBrandAsyncWithHttpInfo (Brand1 body, string contentType, string accept, int? brandId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class BrandsApi : IBrandsApi
    {
        private BigCommerce.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BrandsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BrandsApi(String basePath)
        {
            this.Configuration = new BigCommerce.Client.Configuration { BasePath = basePath };

            ExceptionFactory = BigCommerce.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrandsApi"/> class
        /// </summary>
        /// <returns></returns>
        public BrandsApi()
        {
            this.Configuration = BigCommerce.Client.Configuration.Default;

            ExceptionFactory = BigCommerce.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BrandsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BrandsApi(BigCommerce.Client.Configuration configuration = null)
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
        /// Create a Brand Creates a *Brand*.  **Required Fields** - name  **Read-Only Fields** - id
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>BrandResponse</returns>
        public BrandResponse CreateBrand (Brand body, string accept, string contentType)
        {
             ApiResponse<BrandResponse> localVarResponse = CreateBrandWithHttpInfo(body, accept, contentType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Brand Creates a *Brand*.  **Required Fields** - name  **Read-Only Fields** - id
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of BrandResponse</returns>
        public ApiResponse< BrandResponse > CreateBrandWithHttpInfo (Brand body, string accept, string contentType)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling BrandsApi->CreateBrand");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling BrandsApi->CreateBrand");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling BrandsApi->CreateBrand");

            var localVarPath = "/catalog/brands";
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
                Exception exception = ExceptionFactory("CreateBrand", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BrandResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (BrandResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BrandResponse)));
        }

        /// <summary>
        /// Create a Brand Creates a *Brand*.  **Required Fields** - name  **Read-Only Fields** - id
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of BrandResponse</returns>
        public async System.Threading.Tasks.Task<BrandResponse> CreateBrandAsync (Brand body, string accept, string contentType)
        {
             ApiResponse<BrandResponse> localVarResponse = await CreateBrandAsyncWithHttpInfo(body, accept, contentType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Brand Creates a *Brand*.  **Required Fields** - name  **Read-Only Fields** - id
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse (BrandResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BrandResponse>> CreateBrandAsyncWithHttpInfo (Brand body, string accept, string contentType)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling BrandsApi->CreateBrand");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling BrandsApi->CreateBrand");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling BrandsApi->CreateBrand");

            var localVarPath = "/catalog/brands";
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
                Exception exception = ExceptionFactory("CreateBrand", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BrandResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (BrandResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BrandResponse)));
        }

        /// <summary>
        /// Delete a Brand Deletes a *Brand*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns></returns>
        public void DeleteBrandById (int? brandId, string accept, string contentType)
        {
             DeleteBrandByIdWithHttpInfo(brandId, accept, contentType);
        }

        /// <summary>
        /// Delete a Brand Deletes a *Brand*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteBrandByIdWithHttpInfo (int? brandId, string accept, string contentType)
        {
            // verify the required parameter 'brandId' is set
            if (brandId == null)
                throw new ApiException(400, "Missing required parameter 'brandId' when calling BrandsApi->DeleteBrandById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling BrandsApi->DeleteBrandById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling BrandsApi->DeleteBrandById");

            var localVarPath = "/catalog/brands/{brand_id}";
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
                Exception exception = ExceptionFactory("DeleteBrandById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Delete a Brand Deletes a *Brand*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteBrandByIdAsync (int? brandId, string accept, string contentType)
        {
             await DeleteBrandByIdAsyncWithHttpInfo(brandId, accept, contentType);

        }

        /// <summary>
        /// Delete a Brand Deletes a *Brand*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBrandByIdAsyncWithHttpInfo (int? brandId, string accept, string contentType)
        {
            // verify the required parameter 'brandId' is set
            if (brandId == null)
                throw new ApiException(400, "Missing required parameter 'brandId' when calling BrandsApi->DeleteBrandById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling BrandsApi->DeleteBrandById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling BrandsApi->DeleteBrandById");

            var localVarPath = "/catalog/brands/{brand_id}";
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
                Exception exception = ExceptionFactory("DeleteBrandById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Delete Brands By default, it deletes all *Brand* objects. A filter should be added to avoid deleting all *Brand* objects in a store.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <returns></returns>
        public void DeleteBrands (string accept, string contentType, string name = null, string pageTitle = null)
        {
             DeleteBrandsWithHttpInfo(accept, contentType, name, pageTitle);
        }

        /// <summary>
        /// Delete Brands By default, it deletes all *Brand* objects. A filter should be added to avoid deleting all *Brand* objects in a store.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteBrandsWithHttpInfo (string accept, string contentType, string name = null, string pageTitle = null)
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling BrandsApi->DeleteBrands");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling BrandsApi->DeleteBrands");

            var localVarPath = "/catalog/brands";
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

            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "name", name)); // query parameter
            if (pageTitle != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page_title", pageTitle)); // query parameter
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
                Exception exception = ExceptionFactory("DeleteBrands", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Delete Brands By default, it deletes all *Brand* objects. A filter should be added to avoid deleting all *Brand* objects in a store.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteBrandsAsync (string accept, string contentType, string name = null, string pageTitle = null)
        {
             await DeleteBrandsAsyncWithHttpInfo(accept, contentType, name, pageTitle);

        }

        /// <summary>
        /// Delete Brands By default, it deletes all *Brand* objects. A filter should be added to avoid deleting all *Brand* objects in a store.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteBrandsAsyncWithHttpInfo (string accept, string contentType, string name = null, string pageTitle = null)
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling BrandsApi->DeleteBrands");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling BrandsApi->DeleteBrands");

            var localVarPath = "/catalog/brands";
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

            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "name", name)); // query parameter
            if (pageTitle != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page_title", pageTitle)); // query parameter
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
                Exception exception = ExceptionFactory("DeleteBrands", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Get a Brand Returns a single *Brand*. Optional filter parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>BrandResponse1</returns>
        public BrandResponse1 GetBrandById (int? brandId, string contentType, string accept, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<BrandResponse1> localVarResponse = GetBrandByIdWithHttpInfo(brandId, contentType, accept, includeFields, excludeFields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Brand Returns a single *Brand*. Optional filter parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of BrandResponse1</returns>
        public ApiResponse< BrandResponse1 > GetBrandByIdWithHttpInfo (int? brandId, string contentType, string accept, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'brandId' is set
            if (brandId == null)
                throw new ApiException(400, "Missing required parameter 'brandId' when calling BrandsApi->GetBrandById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling BrandsApi->GetBrandById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling BrandsApi->GetBrandById");

            var localVarPath = "/catalog/brands/{brand_id}";
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
                Exception exception = ExceptionFactory("GetBrandById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BrandResponse1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (BrandResponse1) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BrandResponse1)));
        }

        /// <summary>
        /// Get a Brand Returns a single *Brand*. Optional filter parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of BrandResponse1</returns>
        public async System.Threading.Tasks.Task<BrandResponse1> GetBrandByIdAsync (int? brandId, string contentType, string accept, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<BrandResponse1> localVarResponse = await GetBrandByIdAsyncWithHttpInfo(brandId, contentType, accept, includeFields, excludeFields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Brand Returns a single *Brand*. Optional filter parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (BrandResponse1)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BrandResponse1>> GetBrandByIdAsyncWithHttpInfo (int? brandId, string contentType, string accept, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'brandId' is set
            if (brandId == null)
                throw new ApiException(400, "Missing required parameter 'brandId' when calling BrandsApi->GetBrandById");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling BrandsApi->GetBrandById");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling BrandsApi->GetBrandById");

            var localVarPath = "/catalog/brands/{brand_id}";
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
                Exception exception = ExceptionFactory("GetBrandById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BrandResponse1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (BrandResponse1) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BrandResponse1)));
        }

        /// <summary>
        /// Get All Brands Returns a list of *Brands*. Optional filter parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>BrandCollectionResponse</returns>
        public BrandCollectionResponse GetBrands (string accept, string contentType, int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, string name = null, string pageTitle = null, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<BrandCollectionResponse> localVarResponse = GetBrandsWithHttpInfo(accept, contentType, id, idin, idnotIn, idmin, idmax, idgreater, idless, name, pageTitle, page, limit, includeFields, excludeFields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get All Brands Returns a list of *Brands*. Optional filter parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>ApiResponse of BrandCollectionResponse</returns>
        public ApiResponse< BrandCollectionResponse > GetBrandsWithHttpInfo (string accept, string contentType, int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, string name = null, string pageTitle = null, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling BrandsApi->GetBrands");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling BrandsApi->GetBrands");

            var localVarPath = "/catalog/brands";
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

            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter
            if (idin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:in", idin)); // query parameter
            if (idnotIn != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:not_in", idnotIn)); // query parameter
            if (idmin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:min", idmin)); // query parameter
            if (idmax != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:max", idmax)); // query parameter
            if (idgreater != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:greater", idgreater)); // query parameter
            if (idless != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:less", idless)); // query parameter
            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "name", name)); // query parameter
            if (pageTitle != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page_title", pageTitle)); // query parameter
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
                Exception exception = ExceptionFactory("GetBrands", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BrandCollectionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (BrandCollectionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BrandCollectionResponse)));
        }

        /// <summary>
        /// Get All Brands Returns a list of *Brands*. Optional filter parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of BrandCollectionResponse</returns>
        public async System.Threading.Tasks.Task<BrandCollectionResponse> GetBrandsAsync (string accept, string contentType, int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, string name = null, string pageTitle = null, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null)
        {
             ApiResponse<BrandCollectionResponse> localVarResponse = await GetBrandsAsyncWithHttpInfo(accept, contentType, id, idin, idnotIn, idmin, idmax, idgreater, idless, name, pageTitle, page, limit, includeFields, excludeFields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get All Brands Returns a list of *Brands*. Optional filter parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="idin"> (optional)</param>
        /// <param name="idnotIn"> (optional)</param>
        /// <param name="idmin"> (optional)</param>
        /// <param name="idmax"> (optional)</param>
        /// <param name="idgreater"> (optional)</param>
        /// <param name="idless"> (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="pageTitle">Filter items by page_title.  (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="includeFields">Fields to include, in a comma-separated list. The ID and the specified fields will be returned. (optional)</param>
        /// <param name="excludeFields">Fields to exclude, in a comma-separated list. The specified fields will be excluded from a response. The ID cannot be excluded. (optional)</param>
        /// <returns>Task of ApiResponse (BrandCollectionResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BrandCollectionResponse>> GetBrandsAsyncWithHttpInfo (string accept, string contentType, int? id = null, List<int?> idin = null, List<int?> idnotIn = null, List<int?> idmin = null, List<int?> idmax = null, List<int?> idgreater = null, List<int?> idless = null, string name = null, string pageTitle = null, int? page = null, int? limit = null, string includeFields = null, string excludeFields = null)
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling BrandsApi->GetBrands");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling BrandsApi->GetBrands");

            var localVarPath = "/catalog/brands";
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

            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter
            if (idin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:in", idin)); // query parameter
            if (idnotIn != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:not_in", idnotIn)); // query parameter
            if (idmin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:min", idmin)); // query parameter
            if (idmax != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:max", idmax)); // query parameter
            if (idgreater != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:greater", idgreater)); // query parameter
            if (idless != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("csv", "id:less", idless)); // query parameter
            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "name", name)); // query parameter
            if (pageTitle != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page_title", pageTitle)); // query parameter
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
                Exception exception = ExceptionFactory("GetBrands", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BrandCollectionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (BrandCollectionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BrandCollectionResponse)));
        }

        /// <summary>
        /// Update a Brand Updates a *Brand*.  **Required Fields** - None  **Read-Only Fields** - id  To update a *Brand Image*, send a request with an &#x60;image_url&#x60;.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <returns>BrandResponse</returns>
        public BrandResponse UpdateBrand (Brand1 body, string contentType, string accept, int? brandId)
        {
             ApiResponse<BrandResponse> localVarResponse = UpdateBrandWithHttpInfo(body, contentType, accept, brandId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a Brand Updates a *Brand*.  **Required Fields** - None  **Read-Only Fields** - id  To update a *Brand Image*, send a request with an &#x60;image_url&#x60;.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <returns>ApiResponse of BrandResponse</returns>
        public ApiResponse< BrandResponse > UpdateBrandWithHttpInfo (Brand1 body, string contentType, string accept, int? brandId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling BrandsApi->UpdateBrand");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling BrandsApi->UpdateBrand");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling BrandsApi->UpdateBrand");
            // verify the required parameter 'brandId' is set
            if (brandId == null)
                throw new ApiException(400, "Missing required parameter 'brandId' when calling BrandsApi->UpdateBrand");

            var localVarPath = "/catalog/brands/{brand_id}";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateBrand", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BrandResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (BrandResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BrandResponse)));
        }

        /// <summary>
        /// Update a Brand Updates a *Brand*.  **Required Fields** - None  **Read-Only Fields** - id  To update a *Brand Image*, send a request with an &#x60;image_url&#x60;.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <returns>Task of BrandResponse</returns>
        public async System.Threading.Tasks.Task<BrandResponse> UpdateBrandAsync (Brand1 body, string contentType, string accept, int? brandId)
        {
             ApiResponse<BrandResponse> localVarResponse = await UpdateBrandAsyncWithHttpInfo(body, contentType, accept, brandId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a Brand Updates a *Brand*.  **Required Fields** - None  **Read-Only Fields** - id  To update a *Brand Image*, send a request with an &#x60;image_url&#x60;.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="contentType"></param>
        /// <param name="accept"></param>
        /// <param name="brandId">The ID of the &#x60;Brand&#x60; to which the resource belongs. </param>
        /// <returns>Task of ApiResponse (BrandResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<BrandResponse>> UpdateBrandAsyncWithHttpInfo (Brand1 body, string contentType, string accept, int? brandId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling BrandsApi->UpdateBrand");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling BrandsApi->UpdateBrand");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling BrandsApi->UpdateBrand");
            // verify the required parameter 'brandId' is set
            if (brandId == null)
                throw new ApiException(400, "Missing required parameter 'brandId' when calling BrandsApi->UpdateBrand");

            var localVarPath = "/catalog/brands/{brand_id}";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateBrand", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<BrandResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (BrandResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(BrandResponse)));
        }

    }
}
