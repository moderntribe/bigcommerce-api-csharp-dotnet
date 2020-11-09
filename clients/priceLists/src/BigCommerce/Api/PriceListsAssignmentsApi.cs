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
using BigCommerce.Client;
using BigCommerce.Model;

namespace BigCommerce.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public interface IPriceListsAssignmentsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Create Price List Assignments
        /// </summary>
        /// <remarks>
        /// Creates a batch of &#x60;Price List Assignments&#x60;.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A BigCommerce &#x60;Price List Assignments&#x60; request.</param>
        /// <returns>Object</returns>
        Object CreatePriceListAssignments (List<Body> body);

        /// <summary>
        /// Create Price List Assignments
        /// </summary>
        /// <remarks>
        /// Creates a batch of &#x60;Price List Assignments&#x60;.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A BigCommerce &#x60;Price List Assignments&#x60; request.</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> CreatePriceListAssignmentsWithHttpInfo (List<Body> body);
        /// <summary>
        /// Delete Price List Assignments
        /// </summary>
        /// <remarks>
        /// Deletes one or more &#x60;Price List Assignments&#x60; objects from BigCommerce using a filter.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the &#x60;Price List Assignment&#x60;. (optional)</param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60;. (optional)</param>
        /// <param name="customerGroupId">The ID of the &#x60;Customer Group&#x60;. (optional)</param>
        /// <param name="channelId">The ID of the &#x60;Channel&#x60;. (optional)</param>
        /// <returns>InlineResponse204</returns>
        InlineResponse204 DeletePriceListAssignmentsByFilter (int? id = null, int? priceListId = null, int? customerGroupId = null, int? channelId = null);

        /// <summary>
        /// Delete Price List Assignments
        /// </summary>
        /// <remarks>
        /// Deletes one or more &#x60;Price List Assignments&#x60; objects from BigCommerce using a filter.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the &#x60;Price List Assignment&#x60;. (optional)</param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60;. (optional)</param>
        /// <param name="customerGroupId">The ID of the &#x60;Customer Group&#x60;. (optional)</param>
        /// <param name="channelId">The ID of the &#x60;Channel&#x60;. (optional)</param>
        /// <returns>ApiResponse of InlineResponse204</returns>
        ApiResponse<InlineResponse204> DeletePriceListAssignmentsByFilterWithHttpInfo (int? id = null, int? priceListId = null, int? customerGroupId = null, int? channelId = null);
        /// <summary>
        /// Get Price List Assignments
        /// </summary>
        /// <remarks>
        /// Fetches an array of &#x60;Price List Assignments&#x60; matching a particular Customer Group and Price List and Channel.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the &#x60;Price List Assignment&#x60;. (optional)</param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60;. (optional)</param>
        /// <param name="customerGroupId">The ID of the &#x60;Customer Group&#x60;. (optional)</param>
        /// <param name="channelId">The ID of the &#x60;Channel&#x60;. (optional)</param>
        /// <returns>InlineResponse200</returns>
        InlineResponse200 GetListOfPriceListAssignments (int? id = null, int? priceListId = null, int? customerGroupId = null, int? channelId = null);

        /// <summary>
        /// Get Price List Assignments
        /// </summary>
        /// <remarks>
        /// Fetches an array of &#x60;Price List Assignments&#x60; matching a particular Customer Group and Price List and Channel.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the &#x60;Price List Assignment&#x60;. (optional)</param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60;. (optional)</param>
        /// <param name="customerGroupId">The ID of the &#x60;Customer Group&#x60;. (optional)</param>
        /// <param name="channelId">The ID of the &#x60;Channel&#x60;. (optional)</param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        ApiResponse<InlineResponse200> GetListOfPriceListAssignmentsWithHttpInfo (int? id = null, int? priceListId = null, int? customerGroupId = null, int? channelId = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Create Price List Assignments
        /// </summary>
        /// <remarks>
        /// Creates a batch of &#x60;Price List Assignments&#x60;.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A BigCommerce &#x60;Price List Assignments&#x60; request.</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> CreatePriceListAssignmentsAsync (List<Body> body);

        /// <summary>
        /// Create Price List Assignments
        /// </summary>
        /// <remarks>
        /// Creates a batch of &#x60;Price List Assignments&#x60;.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A BigCommerce &#x60;Price List Assignments&#x60; request.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> CreatePriceListAssignmentsAsyncWithHttpInfo (List<Body> body);
        /// <summary>
        /// Delete Price List Assignments
        /// </summary>
        /// <remarks>
        /// Deletes one or more &#x60;Price List Assignments&#x60; objects from BigCommerce using a filter.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the &#x60;Price List Assignment&#x60;. (optional)</param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60;. (optional)</param>
        /// <param name="customerGroupId">The ID of the &#x60;Customer Group&#x60;. (optional)</param>
        /// <param name="channelId">The ID of the &#x60;Channel&#x60;. (optional)</param>
        /// <returns>Task of InlineResponse204</returns>
        System.Threading.Tasks.Task<InlineResponse204> DeletePriceListAssignmentsByFilterAsync (int? id = null, int? priceListId = null, int? customerGroupId = null, int? channelId = null);

        /// <summary>
        /// Delete Price List Assignments
        /// </summary>
        /// <remarks>
        /// Deletes one or more &#x60;Price List Assignments&#x60; objects from BigCommerce using a filter.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the &#x60;Price List Assignment&#x60;. (optional)</param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60;. (optional)</param>
        /// <param name="customerGroupId">The ID of the &#x60;Customer Group&#x60;. (optional)</param>
        /// <param name="channelId">The ID of the &#x60;Channel&#x60;. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse204)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse204>> DeletePriceListAssignmentsByFilterAsyncWithHttpInfo (int? id = null, int? priceListId = null, int? customerGroupId = null, int? channelId = null);
        /// <summary>
        /// Get Price List Assignments
        /// </summary>
        /// <remarks>
        /// Fetches an array of &#x60;Price List Assignments&#x60; matching a particular Customer Group and Price List and Channel.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the &#x60;Price List Assignment&#x60;. (optional)</param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60;. (optional)</param>
        /// <param name="customerGroupId">The ID of the &#x60;Customer Group&#x60;. (optional)</param>
        /// <param name="channelId">The ID of the &#x60;Channel&#x60;. (optional)</param>
        /// <returns>Task of InlineResponse200</returns>
        System.Threading.Tasks.Task<InlineResponse200> GetListOfPriceListAssignmentsAsync (int? id = null, int? priceListId = null, int? customerGroupId = null, int? channelId = null);

        /// <summary>
        /// Get Price List Assignments
        /// </summary>
        /// <remarks>
        /// Fetches an array of &#x60;Price List Assignments&#x60; matching a particular Customer Group and Price List and Channel.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the &#x60;Price List Assignment&#x60;. (optional)</param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60;. (optional)</param>
        /// <param name="customerGroupId">The ID of the &#x60;Customer Group&#x60;. (optional)</param>
        /// <param name="channelId">The ID of the &#x60;Channel&#x60;. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> GetListOfPriceListAssignmentsAsyncWithHttpInfo (int? id = null, int? priceListId = null, int? customerGroupId = null, int? channelId = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class PriceListsAssignmentsApi : IPriceListsAssignmentsApi
    {
        private BigCommerce.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PriceListsAssignmentsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PriceListsAssignmentsApi(String basePath)
        {
            this.Configuration = new BigCommerce.Client.Configuration { BasePath = basePath };

            ExceptionFactory = BigCommerce.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PriceListsAssignmentsApi"/> class
        /// </summary>
        /// <returns></returns>
        public PriceListsAssignmentsApi()
        {
            this.Configuration = BigCommerce.Client.Configuration.Default;

            ExceptionFactory = BigCommerce.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PriceListsAssignmentsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PriceListsAssignmentsApi(BigCommerce.Client.Configuration configuration = null)
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
        /// Create Price List Assignments Creates a batch of &#x60;Price List Assignments&#x60;.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A BigCommerce &#x60;Price List Assignments&#x60; request.</param>
        /// <returns>Object</returns>
        public Object CreatePriceListAssignments (List<Body> body)
        {
             ApiResponse<Object> localVarResponse = CreatePriceListAssignmentsWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create Price List Assignments Creates a batch of &#x60;Price List Assignments&#x60;.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A BigCommerce &#x60;Price List Assignments&#x60; request.</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > CreatePriceListAssignmentsWithHttpInfo (List<Body> body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PriceListsAssignmentsApi->CreatePriceListAssignments");

            var localVarPath = "/pricelists/assignments";
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
                Exception exception = ExceptionFactory("CreatePriceListAssignments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// Create Price List Assignments Creates a batch of &#x60;Price List Assignments&#x60;.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A BigCommerce &#x60;Price List Assignments&#x60; request.</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> CreatePriceListAssignmentsAsync (List<Body> body)
        {
             ApiResponse<Object> localVarResponse = await CreatePriceListAssignmentsAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Create Price List Assignments Creates a batch of &#x60;Price List Assignments&#x60;.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body">A BigCommerce &#x60;Price List Assignments&#x60; request.</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> CreatePriceListAssignmentsAsyncWithHttpInfo (List<Body> body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PriceListsAssignmentsApi->CreatePriceListAssignments");

            var localVarPath = "/pricelists/assignments";
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
                Exception exception = ExceptionFactory("CreatePriceListAssignments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// Delete Price List Assignments Deletes one or more &#x60;Price List Assignments&#x60; objects from BigCommerce using a filter.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the &#x60;Price List Assignment&#x60;. (optional)</param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60;. (optional)</param>
        /// <param name="customerGroupId">The ID of the &#x60;Customer Group&#x60;. (optional)</param>
        /// <param name="channelId">The ID of the &#x60;Channel&#x60;. (optional)</param>
        /// <returns>InlineResponse204</returns>
        public InlineResponse204 DeletePriceListAssignmentsByFilter (int? id = null, int? priceListId = null, int? customerGroupId = null, int? channelId = null)
        {
             ApiResponse<InlineResponse204> localVarResponse = DeletePriceListAssignmentsByFilterWithHttpInfo(id, priceListId, customerGroupId, channelId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete Price List Assignments Deletes one or more &#x60;Price List Assignments&#x60; objects from BigCommerce using a filter.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the &#x60;Price List Assignment&#x60;. (optional)</param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60;. (optional)</param>
        /// <param name="customerGroupId">The ID of the &#x60;Customer Group&#x60;. (optional)</param>
        /// <param name="channelId">The ID of the &#x60;Channel&#x60;. (optional)</param>
        /// <returns>ApiResponse of InlineResponse204</returns>
        public ApiResponse< InlineResponse204 > DeletePriceListAssignmentsByFilterWithHttpInfo (int? id = null, int? priceListId = null, int? customerGroupId = null, int? channelId = null)
        {

            var localVarPath = "/pricelists/assignments";
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
            if (priceListId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "price_list_id", priceListId)); // query parameter
            if (customerGroupId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "customer_group_id", customerGroupId)); // query parameter
            if (channelId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "channel_id", channelId)); // query parameter
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
                Exception exception = ExceptionFactory("DeletePriceListAssignmentsByFilter", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse204>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse204) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse204)));
        }

        /// <summary>
        /// Delete Price List Assignments Deletes one or more &#x60;Price List Assignments&#x60; objects from BigCommerce using a filter.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the &#x60;Price List Assignment&#x60;. (optional)</param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60;. (optional)</param>
        /// <param name="customerGroupId">The ID of the &#x60;Customer Group&#x60;. (optional)</param>
        /// <param name="channelId">The ID of the &#x60;Channel&#x60;. (optional)</param>
        /// <returns>Task of InlineResponse204</returns>
        public async System.Threading.Tasks.Task<InlineResponse204> DeletePriceListAssignmentsByFilterAsync (int? id = null, int? priceListId = null, int? customerGroupId = null, int? channelId = null)
        {
             ApiResponse<InlineResponse204> localVarResponse = await DeletePriceListAssignmentsByFilterAsyncWithHttpInfo(id, priceListId, customerGroupId, channelId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete Price List Assignments Deletes one or more &#x60;Price List Assignments&#x60; objects from BigCommerce using a filter.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the &#x60;Price List Assignment&#x60;. (optional)</param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60;. (optional)</param>
        /// <param name="customerGroupId">The ID of the &#x60;Customer Group&#x60;. (optional)</param>
        /// <param name="channelId">The ID of the &#x60;Channel&#x60;. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse204)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse204>> DeletePriceListAssignmentsByFilterAsyncWithHttpInfo (int? id = null, int? priceListId = null, int? customerGroupId = null, int? channelId = null)
        {

            var localVarPath = "/pricelists/assignments";
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
            if (priceListId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "price_list_id", priceListId)); // query parameter
            if (customerGroupId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "customer_group_id", customerGroupId)); // query parameter
            if (channelId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "channel_id", channelId)); // query parameter
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
                Exception exception = ExceptionFactory("DeletePriceListAssignmentsByFilter", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse204>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse204) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse204)));
        }

        /// <summary>
        /// Get Price List Assignments Fetches an array of &#x60;Price List Assignments&#x60; matching a particular Customer Group and Price List and Channel.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the &#x60;Price List Assignment&#x60;. (optional)</param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60;. (optional)</param>
        /// <param name="customerGroupId">The ID of the &#x60;Customer Group&#x60;. (optional)</param>
        /// <param name="channelId">The ID of the &#x60;Channel&#x60;. (optional)</param>
        /// <returns>InlineResponse200</returns>
        public InlineResponse200 GetListOfPriceListAssignments (int? id = null, int? priceListId = null, int? customerGroupId = null, int? channelId = null)
        {
             ApiResponse<InlineResponse200> localVarResponse = GetListOfPriceListAssignmentsWithHttpInfo(id, priceListId, customerGroupId, channelId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Price List Assignments Fetches an array of &#x60;Price List Assignments&#x60; matching a particular Customer Group and Price List and Channel.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the &#x60;Price List Assignment&#x60;. (optional)</param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60;. (optional)</param>
        /// <param name="customerGroupId">The ID of the &#x60;Customer Group&#x60;. (optional)</param>
        /// <param name="channelId">The ID of the &#x60;Channel&#x60;. (optional)</param>
        /// <returns>ApiResponse of InlineResponse200</returns>
        public ApiResponse< InlineResponse200 > GetListOfPriceListAssignmentsWithHttpInfo (int? id = null, int? priceListId = null, int? customerGroupId = null, int? channelId = null)
        {

            var localVarPath = "/pricelists/assignments";
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
            if (priceListId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "price_list_id", priceListId)); // query parameter
            if (customerGroupId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "customer_group_id", customerGroupId)); // query parameter
            if (channelId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "channel_id", channelId)); // query parameter
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
                Exception exception = ExceptionFactory("GetListOfPriceListAssignments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse200>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse200) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse200)));
        }

        /// <summary>
        /// Get Price List Assignments Fetches an array of &#x60;Price List Assignments&#x60; matching a particular Customer Group and Price List and Channel.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the &#x60;Price List Assignment&#x60;. (optional)</param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60;. (optional)</param>
        /// <param name="customerGroupId">The ID of the &#x60;Customer Group&#x60;. (optional)</param>
        /// <param name="channelId">The ID of the &#x60;Channel&#x60;. (optional)</param>
        /// <returns>Task of InlineResponse200</returns>
        public async System.Threading.Tasks.Task<InlineResponse200> GetListOfPriceListAssignmentsAsync (int? id = null, int? priceListId = null, int? customerGroupId = null, int? channelId = null)
        {
             ApiResponse<InlineResponse200> localVarResponse = await GetListOfPriceListAssignmentsAsyncWithHttpInfo(id, priceListId, customerGroupId, channelId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Price List Assignments Fetches an array of &#x60;Price List Assignments&#x60; matching a particular Customer Group and Price List and Channel.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">The ID of the &#x60;Price List Assignment&#x60;. (optional)</param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60;. (optional)</param>
        /// <param name="customerGroupId">The ID of the &#x60;Customer Group&#x60;. (optional)</param>
        /// <param name="channelId">The ID of the &#x60;Channel&#x60;. (optional)</param>
        /// <returns>Task of ApiResponse (InlineResponse200)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse200>> GetListOfPriceListAssignmentsAsyncWithHttpInfo (int? id = null, int? priceListId = null, int? customerGroupId = null, int? channelId = null)
        {

            var localVarPath = "/pricelists/assignments";
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
            if (priceListId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "price_list_id", priceListId)); // query parameter
            if (customerGroupId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "customer_group_id", customerGroupId)); // query parameter
            if (channelId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "channel_id", channelId)); // query parameter
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
                Exception exception = ExceptionFactory("GetListOfPriceListAssignments", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse200>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse200) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse200)));
        }

    }
}
