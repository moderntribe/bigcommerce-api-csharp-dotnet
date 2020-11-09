/* 
 * Price Lists
 *
 * Populate different versions of catalog pricing and assign them to different [customer groups](/api-reference/customer-subscribers/customers-api) at the variant level.  - [Authentication](#authentication) - [Price Lists](#price-lists) - [Price list assignments](#price-list-assignments) - [Usage notes](#usage-notes) - [Additional information](#additional-information)  ## Authentication  Authenticate requests by including an [OAuth](https://developer.bigcommerce.com/api-docs/getting-started/authentication) `access_token` in the request headers.  ```http GET https://api.bigcommerce.com/stores/{{STORE_HASH}}/v3/{{ENDPOINT}} Content-Type: application/json X-Auth-Token: {{ACCESS_TOKEN}} ```  ### OAuth Scopes  | UI Name                                      | Permission | Parameter                                     | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | Products                                     | modify     | `store_v2_products`                           | | Products                                     | read-only  | `store_v2_products_read_only`                 |  ## Price Lists  The association of a Price List to a Customer Group can be done either via the Control Panel or using the [Customer Groups API.](/api-reference/customer-subscribers/customers-api)  Additionally, [Price List Assignments](https://developer.bigcommerce.com/api-reference/store-management/price-lists/price-lists-records/) can be created to assign Price Lists to a specific [Channel](https://developer.bigcommerce.com/api-reference/cart-checkout/channels-listings-api). Price lists assigned to a channel apply to all shoppers on that channel, unless there is a more specific assignment.  If an active Price List does not contain prices for a variant then the Catalog pricing will be used. The association of a Price List to a Customer Group can be done either via the Control Panel or using the [Customer Groups API.](/api-reference/customer-subscribers/customers-api)  Price Lists will provide overridden price values to the Stencil storefront. Final price display can be further customized within the Stencil template. See the [Price Object](https://stencil.bigcommerce.com/docs/price-object-properties) in Stencil for further documentation.  To learn more about Price Lists, see [here](/api-docs/price-lists/price-list-overview).  ## Price list assignments  ### Order of operations  The `Price List Assignment` Pricing Order of Operations is as follows:  **IF** `Price list` assigned to current `Customer Group` **AND** `Price List` assigned to current `Channel`: * Use this Price List - - any prices not found fall back to the catalog price (or in the case of multi-currency, auto-converted prices)  **ELSE IF**: `Price List` assigned to current `Channel`: * Use this price list - - any prices not found fall back to the catalog price (or in the case of multi-currency, auto-converted prices)  **ELSE IF** `Price List` assigned to current `Customer Group`: * Use this price list - - any prices not found fall back to the catalog price (or in the case of multi-currency, auto-converted prices)  **ELSE IF** `Customer Group Discounts`: * Use them - - any prices not found fall back to the catalog price (or in the case of multi-currency, auto-converted prices)  **ELSE IF** `channel` has a `default price list`: * Use this price list - - any prices not found fall back to the catalog price (or in the case of multi-currency, auto-converted prices)  **ELSE**: * Fall back to the catalog price (or in the case of multi-currency, auto-converted prices)  **Note:** Price Lists cannot be assigned to a customer group that has custom group discounts - - the customer group discounts must be deleted first.  ## Usage notes - Price Lists cannot be assigned to a customer group that has custom group discounts - - the customer group discounts must be deleted first. - Bulk pricing Tiers may additionally be associated with a price record to indicate different pricing as the quantity in cart increases. - If a variant has a `Price Record` any existing product-level bulk pricing will not apply in the cart. For variants without `Price Records`, any existing product bulk pricing will apply. - Price Lists Records accepts bulk upsert. Only one [Bulk upsert](https://developer.bigcommerce.com/api-reference/catalog/pricelists-api/price-lists-records/setpricelistrecordcollection) can done at a time. Running more than one in parallel on the **same store** will cause a 429 error and the request will fail. - There are no direct webhooks available for Price Lists. Since Price Lists directly relate to products, webhooks related to products will fire for corresponding changes such as pricing.  ## Additional information  ### Webhooks  * [Products](/api-docs/getting-started/webhooks/webhook-events#webhook-events_products) * [SKU](/api-docs/getting-started/webhooks/webhook-events#webhook-events_sku)  ### Related endpoints * [Get Price List Collection](/api-reference/catalog/pricelists-api/price-lists/getpricelistcollection)
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
using PriceLists.Client;
using PriceLists.Model;

namespace PriceLists.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IPriceListsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create a Price List
        /// </summary>
        /// <remarks>
        /// Creates a *Price List*.  **Required Fields** * name
        /// </remarks>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>PriceListResponse</returns>
        PriceListResponse CreatePriceList (PriceListPost body, string accept = null, string contentType = null);

        /// <summary>
        /// Create a Price List
        /// </summary>
        /// <remarks>
        /// Creates a *Price List*.  **Required Fields** * name
        /// </remarks>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>ApiResponse of PriceListResponse</returns>
        ApiResponse<PriceListResponse> CreatePriceListWithHttpInfo (PriceListPost body, string accept = null, string contentType = null);
        /// <summary>
        /// Delete a Price List
        /// </summary>
        /// <remarks>
        /// Deletes a *Price List*. All associated price records are also removed.
        /// </remarks>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <returns></returns>
        void DeletePriceList (int? priceListId);

        /// <summary>
        /// Delete a Price List
        /// </summary>
        /// <remarks>
        /// Deletes a *Price List*. All associated price records are also removed.
        /// </remarks>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeletePriceListWithHttpInfo (int? priceListId);
        /// <summary>
        /// Delete All Price Lists
        /// </summary>
        /// <remarks>
        /// Deletes a *Price List*. All associated price records are also removed. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns></returns>
        void DeletePriceListsByFilter (int? id = null, string name = null, string accept = null, string contentType = null);

        /// <summary>
        /// Delete All Price Lists
        /// </summary>
        /// <remarks>
        /// Deletes a *Price List*. All associated price records are also removed. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeletePriceListsByFilterWithHttpInfo (int? id = null, string name = null, string accept = null, string contentType = null);
        /// <summary>
        /// Get a Price List
        /// </summary>
        /// <remarks>
        ///  Returns a single *Price List*.
        /// </remarks>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="id">Filter items by id. (optional)</param>
        /// <param name="name">Filter items by name. (optional)</param>
        /// <param name="dateCreated">Filter items by date_created. (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>PriceListResponse1</returns>
        PriceListResponse1 GetPriceList (int? priceListId, int? id = null, string name = null, DateTime? dateCreated = null, DateTime? dateModified = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get a Price List
        /// </summary>
        /// <remarks>
        ///  Returns a single *Price List*.
        /// </remarks>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="id">Filter items by id. (optional)</param>
        /// <param name="name">Filter items by name. (optional)</param>
        /// <param name="dateCreated">Filter items by date_created. (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>ApiResponse of PriceListResponse1</returns>
        ApiResponse<PriceListResponse1> GetPriceListWithHttpInfo (int? priceListId, int? id = null, string name = null, DateTime? dateCreated = null, DateTime? dateModified = null, int? page = null, int? limit = null);
        /// <summary>
        /// Get All Price Lists
        /// </summary>
        /// <remarks>
        /// Returns a list of *Price Lists*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="dateCreated">Filter items by date_created.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <returns>PriceListCollectionResponse</returns>
        PriceListCollectionResponse GetPriceListCollection (int? id = null, string name = null, DateTime? dateCreated = null, DateTime? dateModified = null, int? page = null, int? limit = null, string contentType = null, string accept = null);

        /// <summary>
        /// Get All Price Lists
        /// </summary>
        /// <remarks>
        /// Returns a list of *Price Lists*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="dateCreated">Filter items by date_created.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <returns>ApiResponse of PriceListCollectionResponse</returns>
        ApiResponse<PriceListCollectionResponse> GetPriceListCollectionWithHttpInfo (int? id = null, string name = null, DateTime? dateCreated = null, DateTime? dateModified = null, int? page = null, int? limit = null, string contentType = null, string accept = null);
        /// <summary>
        /// Update a Price List
        /// </summary>
        /// <remarks>
        /// Updates a *Price List*.
        /// </remarks>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <returns>PriceListResponse</returns>
        PriceListResponse UpdatePriceList (PriceListPut body, int? priceListId);

        /// <summary>
        /// Update a Price List
        /// </summary>
        /// <remarks>
        /// Updates a *Price List*.
        /// </remarks>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <returns>ApiResponse of PriceListResponse</returns>
        ApiResponse<PriceListResponse> UpdatePriceListWithHttpInfo (PriceListPut body, int? priceListId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create a Price List
        /// </summary>
        /// <remarks>
        /// Creates a *Price List*.  **Required Fields** * name
        /// </remarks>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Task of PriceListResponse</returns>
        System.Threading.Tasks.Task<PriceListResponse> CreatePriceListAsync (PriceListPost body, string accept = null, string contentType = null);

        /// <summary>
        /// Create a Price List
        /// </summary>
        /// <remarks>
        /// Creates a *Price List*.  **Required Fields** * name
        /// </remarks>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Task of ApiResponse (PriceListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PriceListResponse>> CreatePriceListAsyncWithHttpInfo (PriceListPost body, string accept = null, string contentType = null);
        /// <summary>
        /// Delete a Price List
        /// </summary>
        /// <remarks>
        /// Deletes a *Price List*. All associated price records are also removed.
        /// </remarks>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeletePriceListAsync (int? priceListId);

        /// <summary>
        /// Delete a Price List
        /// </summary>
        /// <remarks>
        /// Deletes a *Price List*. All associated price records are also removed.
        /// </remarks>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeletePriceListAsyncWithHttpInfo (int? priceListId);
        /// <summary>
        /// Delete All Price Lists
        /// </summary>
        /// <remarks>
        /// Deletes a *Price List*. All associated price records are also removed. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeletePriceListsByFilterAsync (int? id = null, string name = null, string accept = null, string contentType = null);

        /// <summary>
        /// Delete All Price Lists
        /// </summary>
        /// <remarks>
        /// Deletes a *Price List*. All associated price records are also removed. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeletePriceListsByFilterAsyncWithHttpInfo (int? id = null, string name = null, string accept = null, string contentType = null);
        /// <summary>
        /// Get a Price List
        /// </summary>
        /// <remarks>
        ///  Returns a single *Price List*.
        /// </remarks>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="id">Filter items by id. (optional)</param>
        /// <param name="name">Filter items by name. (optional)</param>
        /// <param name="dateCreated">Filter items by date_created. (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>Task of PriceListResponse1</returns>
        System.Threading.Tasks.Task<PriceListResponse1> GetPriceListAsync (int? priceListId, int? id = null, string name = null, DateTime? dateCreated = null, DateTime? dateModified = null, int? page = null, int? limit = null);

        /// <summary>
        /// Get a Price List
        /// </summary>
        /// <remarks>
        ///  Returns a single *Price List*.
        /// </remarks>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="id">Filter items by id. (optional)</param>
        /// <param name="name">Filter items by name. (optional)</param>
        /// <param name="dateCreated">Filter items by date_created. (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>Task of ApiResponse (PriceListResponse1)</returns>
        System.Threading.Tasks.Task<ApiResponse<PriceListResponse1>> GetPriceListAsyncWithHttpInfo (int? priceListId, int? id = null, string name = null, DateTime? dateCreated = null, DateTime? dateModified = null, int? page = null, int? limit = null);
        /// <summary>
        /// Get All Price Lists
        /// </summary>
        /// <remarks>
        /// Returns a list of *Price Lists*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="dateCreated">Filter items by date_created.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <returns>Task of PriceListCollectionResponse</returns>
        System.Threading.Tasks.Task<PriceListCollectionResponse> GetPriceListCollectionAsync (int? id = null, string name = null, DateTime? dateCreated = null, DateTime? dateModified = null, int? page = null, int? limit = null, string contentType = null, string accept = null);

        /// <summary>
        /// Get All Price Lists
        /// </summary>
        /// <remarks>
        /// Returns a list of *Price Lists*. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="dateCreated">Filter items by date_created.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <returns>Task of ApiResponse (PriceListCollectionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PriceListCollectionResponse>> GetPriceListCollectionAsyncWithHttpInfo (int? id = null, string name = null, DateTime? dateCreated = null, DateTime? dateModified = null, int? page = null, int? limit = null, string contentType = null, string accept = null);
        /// <summary>
        /// Update a Price List
        /// </summary>
        /// <remarks>
        /// Updates a *Price List*.
        /// </remarks>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <returns>Task of PriceListResponse</returns>
        System.Threading.Tasks.Task<PriceListResponse> UpdatePriceListAsync (PriceListPut body, int? priceListId);

        /// <summary>
        /// Update a Price List
        /// </summary>
        /// <remarks>
        /// Updates a *Price List*.
        /// </remarks>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <returns>Task of ApiResponse (PriceListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PriceListResponse>> UpdatePriceListAsyncWithHttpInfo (PriceListPut body, int? priceListId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class PriceListsApi : IPriceListsApi
    {
        private PriceLists.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PriceListsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PriceListsApi(String basePath)
        {
            this.Configuration = new PriceLists.Client.Configuration { BasePath = basePath };

            ExceptionFactory = PriceLists.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PriceListsApi"/> class
        /// </summary>
        /// <returns></returns>
        public PriceListsApi()
        {
            this.Configuration = PriceLists.Client.Configuration.Default;

            ExceptionFactory = PriceLists.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PriceListsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PriceListsApi(PriceLists.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = PriceLists.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = PriceLists.Client.Configuration.DefaultExceptionFactory;
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
        public PriceLists.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public PriceLists.Client.ExceptionFactory ExceptionFactory
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
        /// Create a Price List Creates a *Price List*.  **Required Fields** * name
        /// </summary>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>PriceListResponse</returns>
        public PriceListResponse CreatePriceList (PriceListPost body, string accept = null, string contentType = null)
        {
             ApiResponse<PriceListResponse> localVarResponse = CreatePriceListWithHttpInfo(body, accept, contentType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a Price List Creates a *Price List*.  **Required Fields** * name
        /// </summary>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>ApiResponse of PriceListResponse</returns>
        public ApiResponse< PriceListResponse > CreatePriceListWithHttpInfo (PriceListPost body, string accept = null, string contentType = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PriceListsApi->CreatePriceList");

            var localVarPath = "/pricelists";
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
                Exception exception = ExceptionFactory("CreatePriceList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PriceListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PriceListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PriceListResponse)));
        }

        /// <summary>
        /// Create a Price List Creates a *Price List*.  **Required Fields** * name
        /// </summary>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Task of PriceListResponse</returns>
        public async System.Threading.Tasks.Task<PriceListResponse> CreatePriceListAsync (PriceListPost body, string accept = null, string contentType = null)
        {
             ApiResponse<PriceListResponse> localVarResponse = await CreatePriceListAsyncWithHttpInfo(body, accept, contentType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create a Price List Creates a *Price List*.  **Required Fields** * name
        /// </summary>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Task of ApiResponse (PriceListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PriceListResponse>> CreatePriceListAsyncWithHttpInfo (PriceListPost body, string accept = null, string contentType = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PriceListsApi->CreatePriceList");

            var localVarPath = "/pricelists";
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
                Exception exception = ExceptionFactory("CreatePriceList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PriceListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PriceListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PriceListResponse)));
        }

        /// <summary>
        /// Delete a Price List Deletes a *Price List*. All associated price records are also removed.
        /// </summary>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <returns></returns>
        public void DeletePriceList (int? priceListId)
        {
             DeletePriceListWithHttpInfo(priceListId);
        }

        /// <summary>
        /// Delete a Price List Deletes a *Price List*. All associated price records are also removed.
        /// </summary>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeletePriceListWithHttpInfo (int? priceListId)
        {
            // verify the required parameter 'priceListId' is set
            if (priceListId == null)
                throw new ApiException(400, "Missing required parameter 'priceListId' when calling PriceListsApi->DeletePriceList");

            var localVarPath = "/pricelists/{price_list_id}";
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

            if (priceListId != null) localVarPathParams.Add("price_list_id", this.Configuration.ApiClient.ParameterToString(priceListId)); // path parameter
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
                Exception exception = ExceptionFactory("DeletePriceList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Delete a Price List Deletes a *Price List*. All associated price records are also removed.
        /// </summary>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeletePriceListAsync (int? priceListId)
        {
             await DeletePriceListAsyncWithHttpInfo(priceListId);

        }

        /// <summary>
        /// Delete a Price List Deletes a *Price List*. All associated price records are also removed.
        /// </summary>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeletePriceListAsyncWithHttpInfo (int? priceListId)
        {
            // verify the required parameter 'priceListId' is set
            if (priceListId == null)
                throw new ApiException(400, "Missing required parameter 'priceListId' when calling PriceListsApi->DeletePriceList");

            var localVarPath = "/pricelists/{price_list_id}";
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

            if (priceListId != null) localVarPathParams.Add("price_list_id", this.Configuration.ApiClient.ParameterToString(priceListId)); // path parameter
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
                Exception exception = ExceptionFactory("DeletePriceList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Delete All Price Lists Deletes a *Price List*. All associated price records are also removed. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns></returns>
        public void DeletePriceListsByFilter (int? id = null, string name = null, string accept = null, string contentType = null)
        {
             DeletePriceListsByFilterWithHttpInfo(id, name, accept, contentType);
        }

        /// <summary>
        /// Delete All Price Lists Deletes a *Price List*. All associated price records are also removed. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeletePriceListsByFilterWithHttpInfo (int? id = null, string name = null, string accept = null, string contentType = null)
        {

            var localVarPath = "/pricelists";
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

            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter
            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "name", name)); // query parameter
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
                Exception exception = ExceptionFactory("DeletePriceListsByFilter", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Delete All Price Lists Deletes a *Price List*. All associated price records are also removed. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeletePriceListsByFilterAsync (int? id = null, string name = null, string accept = null, string contentType = null)
        {
             await DeletePriceListsByFilterAsyncWithHttpInfo(id, name, accept, contentType);

        }

        /// <summary>
        /// Delete All Price Lists Deletes a *Price List*. All associated price records are also removed. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeletePriceListsByFilterAsyncWithHttpInfo (int? id = null, string name = null, string accept = null, string contentType = null)
        {

            var localVarPath = "/pricelists";
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

            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter
            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "name", name)); // query parameter
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
                Exception exception = ExceptionFactory("DeletePriceListsByFilter", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Get a Price List  Returns a single *Price List*.
        /// </summary>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="id">Filter items by id. (optional)</param>
        /// <param name="name">Filter items by name. (optional)</param>
        /// <param name="dateCreated">Filter items by date_created. (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>PriceListResponse1</returns>
        public PriceListResponse1 GetPriceList (int? priceListId, int? id = null, string name = null, DateTime? dateCreated = null, DateTime? dateModified = null, int? page = null, int? limit = null)
        {
             ApiResponse<PriceListResponse1> localVarResponse = GetPriceListWithHttpInfo(priceListId, id, name, dateCreated, dateModified, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Price List  Returns a single *Price List*.
        /// </summary>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="id">Filter items by id. (optional)</param>
        /// <param name="name">Filter items by name. (optional)</param>
        /// <param name="dateCreated">Filter items by date_created. (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>ApiResponse of PriceListResponse1</returns>
        public ApiResponse< PriceListResponse1 > GetPriceListWithHttpInfo (int? priceListId, int? id = null, string name = null, DateTime? dateCreated = null, DateTime? dateModified = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'priceListId' is set
            if (priceListId == null)
                throw new ApiException(400, "Missing required parameter 'priceListId' when calling PriceListsApi->GetPriceList");

            var localVarPath = "/pricelists/{price_list_id}";
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

            if (priceListId != null) localVarPathParams.Add("price_list_id", this.Configuration.ApiClient.ParameterToString(priceListId)); // path parameter
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter
            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "name", name)); // query parameter
            if (dateCreated != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date_created", dateCreated)); // query parameter
            if (dateModified != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date_modified", dateModified)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
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
                Exception exception = ExceptionFactory("GetPriceList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PriceListResponse1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PriceListResponse1) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PriceListResponse1)));
        }

        /// <summary>
        /// Get a Price List  Returns a single *Price List*.
        /// </summary>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="id">Filter items by id. (optional)</param>
        /// <param name="name">Filter items by name. (optional)</param>
        /// <param name="dateCreated">Filter items by date_created. (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>Task of PriceListResponse1</returns>
        public async System.Threading.Tasks.Task<PriceListResponse1> GetPriceListAsync (int? priceListId, int? id = null, string name = null, DateTime? dateCreated = null, DateTime? dateModified = null, int? page = null, int? limit = null)
        {
             ApiResponse<PriceListResponse1> localVarResponse = await GetPriceListAsyncWithHttpInfo(priceListId, id, name, dateCreated, dateModified, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Price List  Returns a single *Price List*.
        /// </summary>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="id">Filter items by id. (optional)</param>
        /// <param name="name">Filter items by name. (optional)</param>
        /// <param name="dateCreated">Filter items by date_created. (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <returns>Task of ApiResponse (PriceListResponse1)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PriceListResponse1>> GetPriceListAsyncWithHttpInfo (int? priceListId, int? id = null, string name = null, DateTime? dateCreated = null, DateTime? dateModified = null, int? page = null, int? limit = null)
        {
            // verify the required parameter 'priceListId' is set
            if (priceListId == null)
                throw new ApiException(400, "Missing required parameter 'priceListId' when calling PriceListsApi->GetPriceList");

            var localVarPath = "/pricelists/{price_list_id}";
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

            if (priceListId != null) localVarPathParams.Add("price_list_id", this.Configuration.ApiClient.ParameterToString(priceListId)); // path parameter
            if (id != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "id", id)); // query parameter
            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "name", name)); // query parameter
            if (dateCreated != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date_created", dateCreated)); // query parameter
            if (dateModified != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date_modified", dateModified)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
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
                Exception exception = ExceptionFactory("GetPriceList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PriceListResponse1>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PriceListResponse1) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PriceListResponse1)));
        }

        /// <summary>
        /// Get All Price Lists Returns a list of *Price Lists*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="dateCreated">Filter items by date_created.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <returns>PriceListCollectionResponse</returns>
        public PriceListCollectionResponse GetPriceListCollection (int? id = null, string name = null, DateTime? dateCreated = null, DateTime? dateModified = null, int? page = null, int? limit = null, string contentType = null, string accept = null)
        {
             ApiResponse<PriceListCollectionResponse> localVarResponse = GetPriceListCollectionWithHttpInfo(id, name, dateCreated, dateModified, page, limit, contentType, accept);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get All Price Lists Returns a list of *Price Lists*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="dateCreated">Filter items by date_created.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <returns>ApiResponse of PriceListCollectionResponse</returns>
        public ApiResponse< PriceListCollectionResponse > GetPriceListCollectionWithHttpInfo (int? id = null, string name = null, DateTime? dateCreated = null, DateTime? dateModified = null, int? page = null, int? limit = null, string contentType = null, string accept = null)
        {

            var localVarPath = "/pricelists";
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
            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "name", name)); // query parameter
            if (dateCreated != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date_created", dateCreated)); // query parameter
            if (dateModified != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date_modified", dateModified)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
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
                Exception exception = ExceptionFactory("GetPriceListCollection", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PriceListCollectionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PriceListCollectionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PriceListCollectionResponse)));
        }

        /// <summary>
        /// Get All Price Lists Returns a list of *Price Lists*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="dateCreated">Filter items by date_created.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <returns>Task of PriceListCollectionResponse</returns>
        public async System.Threading.Tasks.Task<PriceListCollectionResponse> GetPriceListCollectionAsync (int? id = null, string name = null, DateTime? dateCreated = null, DateTime? dateModified = null, int? page = null, int? limit = null, string contentType = null, string accept = null)
        {
             ApiResponse<PriceListCollectionResponse> localVarResponse = await GetPriceListCollectionAsyncWithHttpInfo(id, name, dateCreated, dateModified, page, limit, contentType, accept);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get All Price Lists Returns a list of *Price Lists*. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Filter items by id.  (optional)</param>
        /// <param name="name">Filter items by name.  (optional)</param>
        /// <param name="dateCreated">Filter items by date_created.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <returns>Task of ApiResponse (PriceListCollectionResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PriceListCollectionResponse>> GetPriceListCollectionAsyncWithHttpInfo (int? id = null, string name = null, DateTime? dateCreated = null, DateTime? dateModified = null, int? page = null, int? limit = null, string contentType = null, string accept = null)
        {

            var localVarPath = "/pricelists";
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
            if (name != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "name", name)); // query parameter
            if (dateCreated != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date_created", dateCreated)); // query parameter
            if (dateModified != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date_modified", dateModified)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
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
                Exception exception = ExceptionFactory("GetPriceListCollection", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PriceListCollectionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PriceListCollectionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PriceListCollectionResponse)));
        }

        /// <summary>
        /// Update a Price List Updates a *Price List*.
        /// </summary>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <returns>PriceListResponse</returns>
        public PriceListResponse UpdatePriceList (PriceListPut body, int? priceListId)
        {
             ApiResponse<PriceListResponse> localVarResponse = UpdatePriceListWithHttpInfo(body, priceListId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Update a Price List Updates a *Price List*.
        /// </summary>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <returns>ApiResponse of PriceListResponse</returns>
        public ApiResponse< PriceListResponse > UpdatePriceListWithHttpInfo (PriceListPut body, int? priceListId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PriceListsApi->UpdatePriceList");
            // verify the required parameter 'priceListId' is set
            if (priceListId == null)
                throw new ApiException(400, "Missing required parameter 'priceListId' when calling PriceListsApi->UpdatePriceList");

            var localVarPath = "/pricelists/{price_list_id}";
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

            if (priceListId != null) localVarPathParams.Add("price_list_id", this.Configuration.ApiClient.ParameterToString(priceListId)); // path parameter
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
                Exception exception = ExceptionFactory("UpdatePriceList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PriceListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PriceListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PriceListResponse)));
        }

        /// <summary>
        /// Update a Price List Updates a *Price List*.
        /// </summary>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <returns>Task of PriceListResponse</returns>
        public async System.Threading.Tasks.Task<PriceListResponse> UpdatePriceListAsync (PriceListPut body, int? priceListId)
        {
             ApiResponse<PriceListResponse> localVarResponse = await UpdatePriceListAsyncWithHttpInfo(body, priceListId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Update a Price List Updates a *Price List*.
        /// </summary>
        /// <exception cref="PriceLists.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <returns>Task of ApiResponse (PriceListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PriceListResponse>> UpdatePriceListAsyncWithHttpInfo (PriceListPut body, int? priceListId)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PriceListsApi->UpdatePriceList");
            // verify the required parameter 'priceListId' is set
            if (priceListId == null)
                throw new ApiException(400, "Missing required parameter 'priceListId' when calling PriceListsApi->UpdatePriceList");

            var localVarPath = "/pricelists/{price_list_id}";
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

            if (priceListId != null) localVarPathParams.Add("price_list_id", this.Configuration.ApiClient.ParameterToString(priceListId)); // path parameter
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
                Exception exception = ExceptionFactory("UpdatePriceList", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PriceListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PriceListResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PriceListResponse)));
        }

    }
}
