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
        public interface ICatalogApi : IApiAccessor
    {
        #region Synchronous Operations
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
        /// Delete Products
        /// </summary>
        /// <remarks>
        /// To delete *Product* objects, you must include a filter. This prevents inadvertently deleting all *Product* objects in a store.  **Example**: To delete products with the id&#x27;s of 1,2 and 3, use &#x60;DELETE /v3/catalog/products?id:in&#x3D;1,2,3&#x60;.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="weight">Filter items by weight.  (optional)</param>
        /// <param name="condition">Filter items by condition.  (optional)</param>
        /// <param name="brandId">Filter items by brand_id.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="dateLastImported">Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="isFeatured">Filter items by is_featured.  (optional)</param>
        /// <param name="inventoryLevel">Filter items by inventory_level.  (optional)</param>
        /// <param name="totalSold">Filter items by total_sold.  (optional)</param>
        /// <param name="type">Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;. (optional)</param>
        /// <param name="categories">Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;. (optional)</param>
        /// <param name="keyword">Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name.  (optional)</param>
        /// <returns></returns>
        void DeleteProducts (string accept, string contentType, string name = null, string sku = null, decimal? price = null, decimal? weight = null, string condition = null, int? brandId = null, DateTime? dateModified = null, DateTime? dateLastImported = null, bool? isVisible = null, int? isFeatured = null, int? inventoryLevel = null, int? totalSold = null, string type = null, int? categories = null, string keyword = null);

        /// <summary>
        /// Delete Products
        /// </summary>
        /// <remarks>
        /// To delete *Product* objects, you must include a filter. This prevents inadvertently deleting all *Product* objects in a store.  **Example**: To delete products with the id&#x27;s of 1,2 and 3, use &#x60;DELETE /v3/catalog/products?id:in&#x3D;1,2,3&#x60;.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="weight">Filter items by weight.  (optional)</param>
        /// <param name="condition">Filter items by condition.  (optional)</param>
        /// <param name="brandId">Filter items by brand_id.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="dateLastImported">Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="isFeatured">Filter items by is_featured.  (optional)</param>
        /// <param name="inventoryLevel">Filter items by inventory_level.  (optional)</param>
        /// <param name="totalSold">Filter items by total_sold.  (optional)</param>
        /// <param name="type">Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;. (optional)</param>
        /// <param name="categories">Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;. (optional)</param>
        /// <param name="keyword">Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name.  (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteProductsWithHttpInfo (string accept, string contentType, string name = null, string sku = null, decimal? price = null, decimal? weight = null, string condition = null, int? brandId = null, DateTime? dateModified = null, DateTime? dateLastImported = null, bool? isVisible = null, int? isFeatured = null, int? inventoryLevel = null, int? totalSold = null, string type = null, int? categories = null, string keyword = null);
        /// <summary>
        /// Update Variants (Batch)
        /// </summary>
        /// <remarks>
        /// Creates or updates a batch of &#x60;Variant&#x60; objects. At the time of writing, the current limit is &#x60;50&#x60; variants. This limit is subject to change.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>VariantCollectionResponse2</returns>
        VariantCollectionResponse2 UpdateVariantsBatch (List<Object> body, string accept, string contentType);

        /// <summary>
        /// Update Variants (Batch)
        /// </summary>
        /// <remarks>
        /// Creates or updates a batch of &#x60;Variant&#x60; objects. At the time of writing, the current limit is &#x60;50&#x60; variants. This limit is subject to change.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of VariantCollectionResponse2</returns>
        ApiResponse<VariantCollectionResponse2> UpdateVariantsBatchWithHttpInfo (List<Object> body, string accept, string contentType);
        #endregion Synchronous Operations
        #region Asynchronous Operations
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
        /// Delete Products
        /// </summary>
        /// <remarks>
        /// To delete *Product* objects, you must include a filter. This prevents inadvertently deleting all *Product* objects in a store.  **Example**: To delete products with the id&#x27;s of 1,2 and 3, use &#x60;DELETE /v3/catalog/products?id:in&#x3D;1,2,3&#x60;.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="weight">Filter items by weight.  (optional)</param>
        /// <param name="condition">Filter items by condition.  (optional)</param>
        /// <param name="brandId">Filter items by brand_id.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="dateLastImported">Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="isFeatured">Filter items by is_featured.  (optional)</param>
        /// <param name="inventoryLevel">Filter items by inventory_level.  (optional)</param>
        /// <param name="totalSold">Filter items by total_sold.  (optional)</param>
        /// <param name="type">Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;. (optional)</param>
        /// <param name="categories">Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;. (optional)</param>
        /// <param name="keyword">Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name.  (optional)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteProductsAsync (string accept, string contentType, string name = null, string sku = null, decimal? price = null, decimal? weight = null, string condition = null, int? brandId = null, DateTime? dateModified = null, DateTime? dateLastImported = null, bool? isVisible = null, int? isFeatured = null, int? inventoryLevel = null, int? totalSold = null, string type = null, int? categories = null, string keyword = null);

        /// <summary>
        /// Delete Products
        /// </summary>
        /// <remarks>
        /// To delete *Product* objects, you must include a filter. This prevents inadvertently deleting all *Product* objects in a store.  **Example**: To delete products with the id&#x27;s of 1,2 and 3, use &#x60;DELETE /v3/catalog/products?id:in&#x3D;1,2,3&#x60;.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="weight">Filter items by weight.  (optional)</param>
        /// <param name="condition">Filter items by condition.  (optional)</param>
        /// <param name="brandId">Filter items by brand_id.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="dateLastImported">Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="isFeatured">Filter items by is_featured.  (optional)</param>
        /// <param name="inventoryLevel">Filter items by inventory_level.  (optional)</param>
        /// <param name="totalSold">Filter items by total_sold.  (optional)</param>
        /// <param name="type">Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;. (optional)</param>
        /// <param name="categories">Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;. (optional)</param>
        /// <param name="keyword">Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name.  (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteProductsAsyncWithHttpInfo (string accept, string contentType, string name = null, string sku = null, decimal? price = null, decimal? weight = null, string condition = null, int? brandId = null, DateTime? dateModified = null, DateTime? dateLastImported = null, bool? isVisible = null, int? isFeatured = null, int? inventoryLevel = null, int? totalSold = null, string type = null, int? categories = null, string keyword = null);
        /// <summary>
        /// Update Variants (Batch)
        /// </summary>
        /// <remarks>
        /// Creates or updates a batch of &#x60;Variant&#x60; objects. At the time of writing, the current limit is &#x60;50&#x60; variants. This limit is subject to change.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of VariantCollectionResponse2</returns>
        System.Threading.Tasks.Task<VariantCollectionResponse2> UpdateVariantsBatchAsync (List<Object> body, string accept, string contentType);

        /// <summary>
        /// Update Variants (Batch)
        /// </summary>
        /// <remarks>
        /// Creates or updates a batch of &#x60;Variant&#x60; objects. At the time of writing, the current limit is &#x60;50&#x60; variants. This limit is subject to change.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse (VariantCollectionResponse2)</returns>
        System.Threading.Tasks.Task<ApiResponse<VariantCollectionResponse2>> UpdateVariantsBatchAsyncWithHttpInfo (List<Object> body, string accept, string contentType);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class CatalogApi : ICatalogApi
    {
        private BigCommerce.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CatalogApi(String basePath)
        {
            this.Configuration = new BigCommerce.Client.Configuration { BasePath = basePath };

            ExceptionFactory = BigCommerce.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogApi"/> class
        /// </summary>
        /// <returns></returns>
        public CatalogApi()
        {
            this.Configuration = BigCommerce.Client.Configuration.Default;

            ExceptionFactory = BigCommerce.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CatalogApi(BigCommerce.Client.Configuration configuration = null)
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
                throw new ApiException(400, "Missing required parameter 'accept' when calling CatalogApi->DeleteBrands");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling CatalogApi->DeleteBrands");

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
                throw new ApiException(400, "Missing required parameter 'accept' when calling CatalogApi->DeleteBrands");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling CatalogApi->DeleteBrands");

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
        /// Delete Products To delete *Product* objects, you must include a filter. This prevents inadvertently deleting all *Product* objects in a store.  **Example**: To delete products with the id&#x27;s of 1,2 and 3, use &#x60;DELETE /v3/catalog/products?id:in&#x3D;1,2,3&#x60;.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="weight">Filter items by weight.  (optional)</param>
        /// <param name="condition">Filter items by condition.  (optional)</param>
        /// <param name="brandId">Filter items by brand_id.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="dateLastImported">Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="isFeatured">Filter items by is_featured.  (optional)</param>
        /// <param name="inventoryLevel">Filter items by inventory_level.  (optional)</param>
        /// <param name="totalSold">Filter items by total_sold.  (optional)</param>
        /// <param name="type">Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;. (optional)</param>
        /// <param name="categories">Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;. (optional)</param>
        /// <param name="keyword">Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name.  (optional)</param>
        /// <returns></returns>
        public void DeleteProducts (string accept, string contentType, string name = null, string sku = null, decimal? price = null, decimal? weight = null, string condition = null, int? brandId = null, DateTime? dateModified = null, DateTime? dateLastImported = null, bool? isVisible = null, int? isFeatured = null, int? inventoryLevel = null, int? totalSold = null, string type = null, int? categories = null, string keyword = null)
        {
             DeleteProductsWithHttpInfo(accept, contentType, name, sku, price, weight, condition, brandId, dateModified, dateLastImported, isVisible, isFeatured, inventoryLevel, totalSold, type, categories, keyword);
        }

        /// <summary>
        /// Delete Products To delete *Product* objects, you must include a filter. This prevents inadvertently deleting all *Product* objects in a store.  **Example**: To delete products with the id&#x27;s of 1,2 and 3, use &#x60;DELETE /v3/catalog/products?id:in&#x3D;1,2,3&#x60;.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="weight">Filter items by weight.  (optional)</param>
        /// <param name="condition">Filter items by condition.  (optional)</param>
        /// <param name="brandId">Filter items by brand_id.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="dateLastImported">Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="isFeatured">Filter items by is_featured.  (optional)</param>
        /// <param name="inventoryLevel">Filter items by inventory_level.  (optional)</param>
        /// <param name="totalSold">Filter items by total_sold.  (optional)</param>
        /// <param name="type">Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;. (optional)</param>
        /// <param name="categories">Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;. (optional)</param>
        /// <param name="keyword">Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name.  (optional)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteProductsWithHttpInfo (string accept, string contentType, string name = null, string sku = null, decimal? price = null, decimal? weight = null, string condition = null, int? brandId = null, DateTime? dateModified = null, DateTime? dateLastImported = null, bool? isVisible = null, int? isFeatured = null, int? inventoryLevel = null, int? totalSold = null, string type = null, int? categories = null, string keyword = null)
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling CatalogApi->DeleteProducts");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling CatalogApi->DeleteProducts");

            var localVarPath = "/catalog/products";
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
            if (sku != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sku", sku)); // query parameter
            if (price != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "price", price)); // query parameter
            if (weight != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "weight", weight)); // query parameter
            if (condition != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "condition", condition)); // query parameter
            if (brandId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "brand_id", brandId)); // query parameter
            if (dateModified != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date_modified", dateModified)); // query parameter
            if (dateLastImported != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date_last_imported", dateLastImported)); // query parameter
            if (isVisible != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "is_visible", isVisible)); // query parameter
            if (isFeatured != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "is_featured", isFeatured)); // query parameter
            if (inventoryLevel != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "inventory_level", inventoryLevel)); // query parameter
            if (totalSold != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "total_sold", totalSold)); // query parameter
            if (type != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (categories != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "categories", categories)); // query parameter
            if (keyword != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "keyword", keyword)); // query parameter
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
                Exception exception = ExceptionFactory("DeleteProducts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Delete Products To delete *Product* objects, you must include a filter. This prevents inadvertently deleting all *Product* objects in a store.  **Example**: To delete products with the id&#x27;s of 1,2 and 3, use &#x60;DELETE /v3/catalog/products?id:in&#x3D;1,2,3&#x60;.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="weight">Filter items by weight.  (optional)</param>
        /// <param name="condition">Filter items by condition.  (optional)</param>
        /// <param name="brandId">Filter items by brand_id.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="dateLastImported">Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="isFeatured">Filter items by is_featured.  (optional)</param>
        /// <param name="inventoryLevel">Filter items by inventory_level.  (optional)</param>
        /// <param name="totalSold">Filter items by total_sold.  (optional)</param>
        /// <param name="type">Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;. (optional)</param>
        /// <param name="categories">Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;. (optional)</param>
        /// <param name="keyword">Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name.  (optional)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteProductsAsync (string accept, string contentType, string name = null, string sku = null, decimal? price = null, decimal? weight = null, string condition = null, int? brandId = null, DateTime? dateModified = null, DateTime? dateLastImported = null, bool? isVisible = null, int? isFeatured = null, int? inventoryLevel = null, int? totalSold = null, string type = null, int? categories = null, string keyword = null)
        {
             await DeleteProductsAsyncWithHttpInfo(accept, contentType, name, sku, price, weight, condition, brandId, dateModified, dateLastImported, isVisible, isFeatured, inventoryLevel, totalSold, type, categories, keyword);

        }

        /// <summary>
        /// Delete Products To delete *Product* objects, you must include a filter. This prevents inadvertently deleting all *Product* objects in a store.  **Example**: To delete products with the id&#x27;s of 1,2 and 3, use &#x60;DELETE /v3/catalog/products?id:in&#x3D;1,2,3&#x60;.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="weight">Filter items by weight.  (optional)</param>
        /// <param name="condition">Filter items by condition.  (optional)</param>
        /// <param name="brandId">Filter items by brand_id.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_modified:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="dateLastImported">Filter items by date_last_imported. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="isVisible">Filter items by if visible on the storefront.  (optional)</param>
        /// <param name="isFeatured">Filter items by is_featured.  (optional)</param>
        /// <param name="inventoryLevel">Filter items by inventory_level.  (optional)</param>
        /// <param name="totalSold">Filter items by total_sold.  (optional)</param>
        /// <param name="type">Filter items by type: &#x60;physical&#x60; or &#x60;digital&#x60;. (optional)</param>
        /// <param name="categories">Filter items by categories.  If a product is in more than one category, using this query will not return the product. Instead use &#x60;categories:in&#x3D;12&#x60;. (optional)</param>
        /// <param name="keyword">Filter items by keywords found in the &#x60;name&#x60;, &#x60;description&#x60;, or &#x60;sku&#x60; fields, or in the brand name.  (optional)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteProductsAsyncWithHttpInfo (string accept, string contentType, string name = null, string sku = null, decimal? price = null, decimal? weight = null, string condition = null, int? brandId = null, DateTime? dateModified = null, DateTime? dateLastImported = null, bool? isVisible = null, int? isFeatured = null, int? inventoryLevel = null, int? totalSold = null, string type = null, int? categories = null, string keyword = null)
        {
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling CatalogApi->DeleteProducts");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling CatalogApi->DeleteProducts");

            var localVarPath = "/catalog/products";
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
            if (sku != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sku", sku)); // query parameter
            if (price != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "price", price)); // query parameter
            if (weight != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "weight", weight)); // query parameter
            if (condition != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "condition", condition)); // query parameter
            if (brandId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "brand_id", brandId)); // query parameter
            if (dateModified != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date_modified", dateModified)); // query parameter
            if (dateLastImported != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date_last_imported", dateLastImported)); // query parameter
            if (isVisible != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "is_visible", isVisible)); // query parameter
            if (isFeatured != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "is_featured", isFeatured)); // query parameter
            if (inventoryLevel != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "inventory_level", inventoryLevel)); // query parameter
            if (totalSold != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "total_sold", totalSold)); // query parameter
            if (type != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "type", type)); // query parameter
            if (categories != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "categories", categories)); // query parameter
            if (keyword != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "keyword", keyword)); // query parameter
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
                Exception exception = ExceptionFactory("DeleteProducts", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Update Variants (Batch) Creates or updates a batch of &#x60;Variant&#x60; objects. At the time of writing, the current limit is &#x60;50&#x60; variants. This limit is subject to change.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>VariantCollectionResponse2</returns>
        public VariantCollectionResponse2 UpdateVariantsBatch (List<Object> body, string accept, string contentType)
        {
             ApiResponse<VariantCollectionResponse2> localVarResponse = UpdateVariantsBatchWithHttpInfo(body, accept, contentType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update Variants (Batch) Creates or updates a batch of &#x60;Variant&#x60; objects. At the time of writing, the current limit is &#x60;50&#x60; variants. This limit is subject to change.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>ApiResponse of VariantCollectionResponse2</returns>
        public ApiResponse< VariantCollectionResponse2 > UpdateVariantsBatchWithHttpInfo (List<Object> body, string accept, string contentType)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CatalogApi->UpdateVariantsBatch");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling CatalogApi->UpdateVariantsBatch");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling CatalogApi->UpdateVariantsBatch");

            var localVarPath = "/catalog/variants";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateVariantsBatch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VariantCollectionResponse2>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (VariantCollectionResponse2) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VariantCollectionResponse2)));
        }

        /// <summary>
        /// Update Variants (Batch) Creates or updates a batch of &#x60;Variant&#x60; objects. At the time of writing, the current limit is &#x60;50&#x60; variants. This limit is subject to change.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of VariantCollectionResponse2</returns>
        public async System.Threading.Tasks.Task<VariantCollectionResponse2> UpdateVariantsBatchAsync (List<Object> body, string accept, string contentType)
        {
             ApiResponse<VariantCollectionResponse2> localVarResponse = await UpdateVariantsBatchAsyncWithHttpInfo(body, accept, contentType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update Variants (Batch) Creates or updates a batch of &#x60;Variant&#x60; objects. At the time of writing, the current limit is &#x60;50&#x60; variants. This limit is subject to change.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"></param>
        /// <param name="contentType"></param>
        /// <returns>Task of ApiResponse (VariantCollectionResponse2)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VariantCollectionResponse2>> UpdateVariantsBatchAsyncWithHttpInfo (List<Object> body, string accept, string contentType)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CatalogApi->UpdateVariantsBatch");
            // verify the required parameter 'accept' is set
            if (accept == null)
                throw new ApiException(400, "Missing required parameter 'accept' when calling CatalogApi->UpdateVariantsBatch");
            // verify the required parameter 'contentType' is set
            if (contentType == null)
                throw new ApiException(400, "Missing required parameter 'contentType' when calling CatalogApi->UpdateVariantsBatch");

            var localVarPath = "/catalog/variants";
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateVariantsBatch", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VariantCollectionResponse2>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (VariantCollectionResponse2) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(VariantCollectionResponse2)));
        }

    }
}
