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
        public interface IPriceListsRecordsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Delete a Price Record by Currency Code
        /// </summary>
        /// <remarks>
        /// Deletes a *Price List Record* using the currency code. 
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="currencyCode">The currency code associated with the price record being acted upon. </param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <returns></returns>
        void DeletePriceListRecord (int? priceListId, int? variantId, string currencyCode, string contentType = null, string accept = null);

        /// <summary>
        /// Delete a Price Record by Currency Code
        /// </summary>
        /// <remarks>
        /// Deletes a *Price List Record* using the currency code. 
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="currencyCode">The currency code associated with the price record being acted upon. </param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeletePriceListRecordWithHttpInfo (int? priceListId, int? variantId, string currencyCode, string contentType = null, string accept = null);
        /// <summary>
        /// Delete a Price List Record
        /// </summary>
        /// <remarks>
        /// Deletes a *Price List Record*. Deleting the records does not delete the Price List. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantIdin">The ID of the &#x60;Variant&#x60; whose prices were requested. (optional)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>NoContent</returns>
        NoContent DeletePriceListRecordsByFilter (int? priceListId, int? variantIdin = null, string accept = null, string contentType = null);

        /// <summary>
        /// Delete a Price List Record
        /// </summary>
        /// <remarks>
        /// Deletes a *Price List Record*. Deleting the records does not delete the Price List. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantIdin">The ID of the &#x60;Variant&#x60; whose prices were requested. (optional)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>ApiResponse of NoContent</returns>
        ApiResponse<NoContent> DeletePriceListRecordsByFilterWithHttpInfo (int? priceListId, int? variantIdin = null, string accept = null, string contentType = null);
        /// <summary>
        /// Get a Price Record by Currency Code
        /// </summary>
        /// <remarks>
        /// Returns a *Price List Record* using the currency code. Optional parameters can be used.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="currencyCode">The currency code associated with the price record being acted upon. </param>
        /// <param name="include">Sub-resources to include on a price record, in a comma-separated list. Valid expansions currently include &#x60;bulk_pricing_tiers&#x60; and &#x60;sku&#x60;.  Other valies will be ignored.  (optional)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>PriceRecordResponse</returns>
        PriceRecordResponse GetPriceListRecord (int? priceListId, int? variantId, string currencyCode, string include = null, string accept = null, string contentType = null);

        /// <summary>
        /// Get a Price Record by Currency Code
        /// </summary>
        /// <remarks>
        /// Returns a *Price List Record* using the currency code. Optional parameters can be used.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="currencyCode">The currency code associated with the price record being acted upon. </param>
        /// <param name="include">Sub-resources to include on a price record, in a comma-separated list. Valid expansions currently include &#x60;bulk_pricing_tiers&#x60; and &#x60;sku&#x60;.  Other valies will be ignored.  (optional)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>ApiResponse of PriceRecordResponse</returns>
        ApiResponse<PriceRecordResponse> GetPriceListRecordWithHttpInfo (int? priceListId, int? variantId, string currencyCode, string include = null, string accept = null, string contentType = null);
        /// <summary>
        /// Get All Price List Records
        /// </summary>
        /// <remarks>
        /// Returns a list of *Price List Records* associated with a *Price List*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantIdin">The ID of the &#x60;Variant&#x60; whose prices were requested. (optional)</param>
        /// <param name="productIdin">A comma-separated list of ids of &#x60;Product&#x60;s whose prices were requested.  (optional)</param>
        /// <param name="currency">Filter items by currency.  (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="include">Sub-resources to include on a price record, in a comma-separated list. Valid expansions currently include &#x60;bulk_pricing_tiers&#x60; and &#x60;sku&#x60;.  Other valies will be ignored.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="salePrice">Filter items by sale_price.  (optional)</param>
        /// <param name="retailPrice">Filter items by retail_price.  (optional)</param>
        /// <param name="mapPrice">Filter items by map_price.  (optional)</param>
        /// <param name="calculatedPrice">Filter items by calculated_price.  (optional)</param>
        /// <param name="dateCreated">Filter items by date_created.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <returns>PriceRecordCollectionResponse</returns>
        PriceRecordCollectionResponse GetPriceListRecordCollection (int? priceListId, int? variantIdin = null, string productIdin = null, string currency = null, int? page = null, int? limit = null, string include = null, decimal? price = null, decimal? salePrice = null, decimal? retailPrice = null, decimal? mapPrice = null, decimal? calculatedPrice = null, DateTime? dateCreated = null, DateTime? dateModified = null, string sku = null, string contentType = null, string accept = null);

        /// <summary>
        /// Get All Price List Records
        /// </summary>
        /// <remarks>
        /// Returns a list of *Price List Records* associated with a *Price List*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantIdin">The ID of the &#x60;Variant&#x60; whose prices were requested. (optional)</param>
        /// <param name="productIdin">A comma-separated list of ids of &#x60;Product&#x60;s whose prices were requested.  (optional)</param>
        /// <param name="currency">Filter items by currency.  (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="include">Sub-resources to include on a price record, in a comma-separated list. Valid expansions currently include &#x60;bulk_pricing_tiers&#x60; and &#x60;sku&#x60;.  Other valies will be ignored.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="salePrice">Filter items by sale_price.  (optional)</param>
        /// <param name="retailPrice">Filter items by retail_price.  (optional)</param>
        /// <param name="mapPrice">Filter items by map_price.  (optional)</param>
        /// <param name="calculatedPrice">Filter items by calculated_price.  (optional)</param>
        /// <param name="dateCreated">Filter items by date_created.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <returns>ApiResponse of PriceRecordCollectionResponse</returns>
        ApiResponse<PriceRecordCollectionResponse> GetPriceListRecordCollectionWithHttpInfo (int? priceListId, int? variantIdin = null, string productIdin = null, string currency = null, int? page = null, int? limit = null, string include = null, decimal? price = null, decimal? salePrice = null, decimal? retailPrice = null, decimal? mapPrice = null, decimal? calculatedPrice = null, DateTime? dateCreated = null, DateTime? dateModified = null, string sku = null, string contentType = null, string accept = null);
        /// <summary>
        /// Get Price Records by Variant
        /// </summary>
        /// <remarks>
        /// Returns *Price List Records* using the variant ID. Will also contain currency records.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>PriceRecordCollectionResponse</returns>
        PriceRecordCollectionResponse GetPriceListRecordsByVariantId (int? priceListId, int? variantId, string accept = null, string contentType = null);

        /// <summary>
        /// Get Price Records by Variant
        /// </summary>
        /// <remarks>
        /// Returns *Price List Records* using the variant ID. Will also contain currency records.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>ApiResponse of PriceRecordCollectionResponse</returns>
        ApiResponse<PriceRecordCollectionResponse> GetPriceListRecordsByVariantIdWithHttpInfo (int? priceListId, int? variantId, string accept = null, string contentType = null);
        /// <summary>
        /// Set Price List Record by Currency Code
        /// </summary>
        /// <remarks>
        /// Creates or updates a*Price List Record* using the currency code.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="currencyCode">The currency code associated with the price record being acted upon. </param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>PriceRecordResponse</returns>
        PriceRecordResponse SetPriceListRecord (PriceRecordPut body, int? priceListId, int? variantId, string currencyCode, string accept = null, string contentType = null);

        /// <summary>
        /// Set Price List Record by Currency Code
        /// </summary>
        /// <remarks>
        /// Creates or updates a*Price List Record* using the currency code.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="currencyCode">The currency code associated with the price record being acted upon. </param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>ApiResponse of PriceRecordResponse</returns>
        ApiResponse<PriceRecordResponse> SetPriceListRecordWithHttpInfo (PriceRecordPut body, int? priceListId, int? variantId, string currencyCode, string accept = null, string contentType = null);
        /// <summary>
        /// Upsert Price List Records
        /// </summary>
        /// <remarks>
        /// Creates or updates *Price List Records*.   **Required Fields** * currency  **Notes**  * Batch updates are supported by this endpoint, meaning that several price objects can be updated in one request. This allows you to do the same work as many individual requests to singleton endpoints * Batch requests support up to 1,000 items per request. * Up to 2 concurrent batch upsert requests are supported with this API. Running more than the allowed concurrent requests in parallel on the **same store** will cause a 429 error and your additional requests will fail. You are encouraged to run requests sequentially with as many records per request as possible, in order to maximize performance.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="xStrictMode">Header that determines whether the Batch API operates in strict mode or not.  Strict mode will reject the entire request if any item in the batch has an error.  (optional, default to 0)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Object</returns>
        Object SetPriceListRecordCollection (List<Object> body, int? priceListId, int? xStrictMode = null, string accept = null, string contentType = null);

        /// <summary>
        /// Upsert Price List Records
        /// </summary>
        /// <remarks>
        /// Creates or updates *Price List Records*.   **Required Fields** * currency  **Notes**  * Batch updates are supported by this endpoint, meaning that several price objects can be updated in one request. This allows you to do the same work as many individual requests to singleton endpoints * Batch requests support up to 1,000 items per request. * Up to 2 concurrent batch upsert requests are supported with this API. Running more than the allowed concurrent requests in parallel on the **same store** will cause a 429 error and your additional requests will fail. You are encouraged to run requests sequentially with as many records per request as possible, in order to maximize performance.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="xStrictMode">Header that determines whether the Batch API operates in strict mode or not.  Strict mode will reject the entire request if any item in the batch has an error.  (optional, default to 0)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>ApiResponse of Object</returns>
        ApiResponse<Object> SetPriceListRecordCollectionWithHttpInfo (List<Object> body, int? priceListId, int? xStrictMode = null, string accept = null, string contentType = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Delete a Price Record by Currency Code
        /// </summary>
        /// <remarks>
        /// Deletes a *Price List Record* using the currency code. 
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="currencyCode">The currency code associated with the price record being acted upon. </param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeletePriceListRecordAsync (int? priceListId, int? variantId, string currencyCode, string contentType = null, string accept = null);

        /// <summary>
        /// Delete a Price Record by Currency Code
        /// </summary>
        /// <remarks>
        /// Deletes a *Price List Record* using the currency code. 
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="currencyCode">The currency code associated with the price record being acted upon. </param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeletePriceListRecordAsyncWithHttpInfo (int? priceListId, int? variantId, string currencyCode, string contentType = null, string accept = null);
        /// <summary>
        /// Delete a Price List Record
        /// </summary>
        /// <remarks>
        /// Deletes a *Price List Record*. Deleting the records does not delete the Price List. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantIdin">The ID of the &#x60;Variant&#x60; whose prices were requested. (optional)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Task of NoContent</returns>
        System.Threading.Tasks.Task<NoContent> DeletePriceListRecordsByFilterAsync (int? priceListId, int? variantIdin = null, string accept = null, string contentType = null);

        /// <summary>
        /// Delete a Price List Record
        /// </summary>
        /// <remarks>
        /// Deletes a *Price List Record*. Deleting the records does not delete the Price List. Optional parameters can be passed in.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantIdin">The ID of the &#x60;Variant&#x60; whose prices were requested. (optional)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Task of ApiResponse (NoContent)</returns>
        System.Threading.Tasks.Task<ApiResponse<NoContent>> DeletePriceListRecordsByFilterAsyncWithHttpInfo (int? priceListId, int? variantIdin = null, string accept = null, string contentType = null);
        /// <summary>
        /// Get a Price Record by Currency Code
        /// </summary>
        /// <remarks>
        /// Returns a *Price List Record* using the currency code. Optional parameters can be used.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="currencyCode">The currency code associated with the price record being acted upon. </param>
        /// <param name="include">Sub-resources to include on a price record, in a comma-separated list. Valid expansions currently include &#x60;bulk_pricing_tiers&#x60; and &#x60;sku&#x60;.  Other valies will be ignored.  (optional)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Task of PriceRecordResponse</returns>
        System.Threading.Tasks.Task<PriceRecordResponse> GetPriceListRecordAsync (int? priceListId, int? variantId, string currencyCode, string include = null, string accept = null, string contentType = null);

        /// <summary>
        /// Get a Price Record by Currency Code
        /// </summary>
        /// <remarks>
        /// Returns a *Price List Record* using the currency code. Optional parameters can be used.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="currencyCode">The currency code associated with the price record being acted upon. </param>
        /// <param name="include">Sub-resources to include on a price record, in a comma-separated list. Valid expansions currently include &#x60;bulk_pricing_tiers&#x60; and &#x60;sku&#x60;.  Other valies will be ignored.  (optional)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Task of ApiResponse (PriceRecordResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PriceRecordResponse>> GetPriceListRecordAsyncWithHttpInfo (int? priceListId, int? variantId, string currencyCode, string include = null, string accept = null, string contentType = null);
        /// <summary>
        /// Get All Price List Records
        /// </summary>
        /// <remarks>
        /// Returns a list of *Price List Records* associated with a *Price List*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantIdin">The ID of the &#x60;Variant&#x60; whose prices were requested. (optional)</param>
        /// <param name="productIdin">A comma-separated list of ids of &#x60;Product&#x60;s whose prices were requested.  (optional)</param>
        /// <param name="currency">Filter items by currency.  (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="include">Sub-resources to include on a price record, in a comma-separated list. Valid expansions currently include &#x60;bulk_pricing_tiers&#x60; and &#x60;sku&#x60;.  Other valies will be ignored.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="salePrice">Filter items by sale_price.  (optional)</param>
        /// <param name="retailPrice">Filter items by retail_price.  (optional)</param>
        /// <param name="mapPrice">Filter items by map_price.  (optional)</param>
        /// <param name="calculatedPrice">Filter items by calculated_price.  (optional)</param>
        /// <param name="dateCreated">Filter items by date_created.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <returns>Task of PriceRecordCollectionResponse</returns>
        System.Threading.Tasks.Task<PriceRecordCollectionResponse> GetPriceListRecordCollectionAsync (int? priceListId, int? variantIdin = null, string productIdin = null, string currency = null, int? page = null, int? limit = null, string include = null, decimal? price = null, decimal? salePrice = null, decimal? retailPrice = null, decimal? mapPrice = null, decimal? calculatedPrice = null, DateTime? dateCreated = null, DateTime? dateModified = null, string sku = null, string contentType = null, string accept = null);

        /// <summary>
        /// Get All Price List Records
        /// </summary>
        /// <remarks>
        /// Returns a list of *Price List Records* associated with a *Price List*.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantIdin">The ID of the &#x60;Variant&#x60; whose prices were requested. (optional)</param>
        /// <param name="productIdin">A comma-separated list of ids of &#x60;Product&#x60;s whose prices were requested.  (optional)</param>
        /// <param name="currency">Filter items by currency.  (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="include">Sub-resources to include on a price record, in a comma-separated list. Valid expansions currently include &#x60;bulk_pricing_tiers&#x60; and &#x60;sku&#x60;.  Other valies will be ignored.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="salePrice">Filter items by sale_price.  (optional)</param>
        /// <param name="retailPrice">Filter items by retail_price.  (optional)</param>
        /// <param name="mapPrice">Filter items by map_price.  (optional)</param>
        /// <param name="calculatedPrice">Filter items by calculated_price.  (optional)</param>
        /// <param name="dateCreated">Filter items by date_created.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <returns>Task of ApiResponse (PriceRecordCollectionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PriceRecordCollectionResponse>> GetPriceListRecordCollectionAsyncWithHttpInfo (int? priceListId, int? variantIdin = null, string productIdin = null, string currency = null, int? page = null, int? limit = null, string include = null, decimal? price = null, decimal? salePrice = null, decimal? retailPrice = null, decimal? mapPrice = null, decimal? calculatedPrice = null, DateTime? dateCreated = null, DateTime? dateModified = null, string sku = null, string contentType = null, string accept = null);
        /// <summary>
        /// Get Price Records by Variant
        /// </summary>
        /// <remarks>
        /// Returns *Price List Records* using the variant ID. Will also contain currency records.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Task of PriceRecordCollectionResponse</returns>
        System.Threading.Tasks.Task<PriceRecordCollectionResponse> GetPriceListRecordsByVariantIdAsync (int? priceListId, int? variantId, string accept = null, string contentType = null);

        /// <summary>
        /// Get Price Records by Variant
        /// </summary>
        /// <remarks>
        /// Returns *Price List Records* using the variant ID. Will also contain currency records.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Task of ApiResponse (PriceRecordCollectionResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PriceRecordCollectionResponse>> GetPriceListRecordsByVariantIdAsyncWithHttpInfo (int? priceListId, int? variantId, string accept = null, string contentType = null);
        /// <summary>
        /// Set Price List Record by Currency Code
        /// </summary>
        /// <remarks>
        /// Creates or updates a*Price List Record* using the currency code.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="currencyCode">The currency code associated with the price record being acted upon. </param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Task of PriceRecordResponse</returns>
        System.Threading.Tasks.Task<PriceRecordResponse> SetPriceListRecordAsync (PriceRecordPut body, int? priceListId, int? variantId, string currencyCode, string accept = null, string contentType = null);

        /// <summary>
        /// Set Price List Record by Currency Code
        /// </summary>
        /// <remarks>
        /// Creates or updates a*Price List Record* using the currency code.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="currencyCode">The currency code associated with the price record being acted upon. </param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Task of ApiResponse (PriceRecordResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<PriceRecordResponse>> SetPriceListRecordAsyncWithHttpInfo (PriceRecordPut body, int? priceListId, int? variantId, string currencyCode, string accept = null, string contentType = null);
        /// <summary>
        /// Upsert Price List Records
        /// </summary>
        /// <remarks>
        /// Creates or updates *Price List Records*.   **Required Fields** * currency  **Notes**  * Batch updates are supported by this endpoint, meaning that several price objects can be updated in one request. This allows you to do the same work as many individual requests to singleton endpoints * Batch requests support up to 1,000 items per request. * Up to 2 concurrent batch upsert requests are supported with this API. Running more than the allowed concurrent requests in parallel on the **same store** will cause a 429 error and your additional requests will fail. You are encouraged to run requests sequentially with as many records per request as possible, in order to maximize performance.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="xStrictMode">Header that determines whether the Batch API operates in strict mode or not.  Strict mode will reject the entire request if any item in the batch has an error.  (optional, default to 0)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Task of Object</returns>
        System.Threading.Tasks.Task<Object> SetPriceListRecordCollectionAsync (List<Object> body, int? priceListId, int? xStrictMode = null, string accept = null, string contentType = null);

        /// <summary>
        /// Upsert Price List Records
        /// </summary>
        /// <remarks>
        /// Creates or updates *Price List Records*.   **Required Fields** * currency  **Notes**  * Batch updates are supported by this endpoint, meaning that several price objects can be updated in one request. This allows you to do the same work as many individual requests to singleton endpoints * Batch requests support up to 1,000 items per request. * Up to 2 concurrent batch upsert requests are supported with this API. Running more than the allowed concurrent requests in parallel on the **same store** will cause a 429 error and your additional requests will fail. You are encouraged to run requests sequentially with as many records per request as possible, in order to maximize performance.
        /// </remarks>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="xStrictMode">Header that determines whether the Batch API operates in strict mode or not.  Strict mode will reject the entire request if any item in the batch has an error.  (optional, default to 0)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> SetPriceListRecordCollectionAsyncWithHttpInfo (List<Object> body, int? priceListId, int? xStrictMode = null, string accept = null, string contentType = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        public partial class PriceListsRecordsApi : IPriceListsRecordsApi
    {
        private BigCommerce.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PriceListsRecordsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public PriceListsRecordsApi(String basePath)
        {
            this.Configuration = new BigCommerce.Client.Configuration { BasePath = basePath };

            ExceptionFactory = BigCommerce.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PriceListsRecordsApi"/> class
        /// </summary>
        /// <returns></returns>
        public PriceListsRecordsApi()
        {
            this.Configuration = BigCommerce.Client.Configuration.Default;

            ExceptionFactory = BigCommerce.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PriceListsRecordsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PriceListsRecordsApi(BigCommerce.Client.Configuration configuration = null)
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
        /// Delete a Price Record by Currency Code Deletes a *Price List Record* using the currency code. 
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="currencyCode">The currency code associated with the price record being acted upon. </param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <returns></returns>
        public void DeletePriceListRecord (int? priceListId, int? variantId, string currencyCode, string contentType = null, string accept = null)
        {
             DeletePriceListRecordWithHttpInfo(priceListId, variantId, currencyCode, contentType, accept);
        }

        /// <summary>
        /// Delete a Price Record by Currency Code Deletes a *Price List Record* using the currency code. 
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="currencyCode">The currency code associated with the price record being acted upon. </param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeletePriceListRecordWithHttpInfo (int? priceListId, int? variantId, string currencyCode, string contentType = null, string accept = null)
        {
            // verify the required parameter 'priceListId' is set
            if (priceListId == null)
                throw new ApiException(400, "Missing required parameter 'priceListId' when calling PriceListsRecordsApi->DeletePriceListRecord");
            // verify the required parameter 'variantId' is set
            if (variantId == null)
                throw new ApiException(400, "Missing required parameter 'variantId' when calling PriceListsRecordsApi->DeletePriceListRecord");
            // verify the required parameter 'currencyCode' is set
            if (currencyCode == null)
                throw new ApiException(400, "Missing required parameter 'currencyCode' when calling PriceListsRecordsApi->DeletePriceListRecord");

            var localVarPath = "/pricelists/{price_list_id}/records/{variant_id}/{currency_code}";
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
            if (variantId != null) localVarPathParams.Add("variant_id", this.Configuration.ApiClient.ParameterToString(variantId)); // path parameter
            if (currencyCode != null) localVarPathParams.Add("currency_code", this.Configuration.ApiClient.ParameterToString(currencyCode)); // path parameter
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
                Exception exception = ExceptionFactory("DeletePriceListRecord", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Delete a Price Record by Currency Code Deletes a *Price List Record* using the currency code. 
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="currencyCode">The currency code associated with the price record being acted upon. </param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeletePriceListRecordAsync (int? priceListId, int? variantId, string currencyCode, string contentType = null, string accept = null)
        {
             await DeletePriceListRecordAsyncWithHttpInfo(priceListId, variantId, currencyCode, contentType, accept);

        }

        /// <summary>
        /// Delete a Price Record by Currency Code Deletes a *Price List Record* using the currency code. 
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="currencyCode">The currency code associated with the price record being acted upon. </param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeletePriceListRecordAsyncWithHttpInfo (int? priceListId, int? variantId, string currencyCode, string contentType = null, string accept = null)
        {
            // verify the required parameter 'priceListId' is set
            if (priceListId == null)
                throw new ApiException(400, "Missing required parameter 'priceListId' when calling PriceListsRecordsApi->DeletePriceListRecord");
            // verify the required parameter 'variantId' is set
            if (variantId == null)
                throw new ApiException(400, "Missing required parameter 'variantId' when calling PriceListsRecordsApi->DeletePriceListRecord");
            // verify the required parameter 'currencyCode' is set
            if (currencyCode == null)
                throw new ApiException(400, "Missing required parameter 'currencyCode' when calling PriceListsRecordsApi->DeletePriceListRecord");

            var localVarPath = "/pricelists/{price_list_id}/records/{variant_id}/{currency_code}";
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
            if (variantId != null) localVarPathParams.Add("variant_id", this.Configuration.ApiClient.ParameterToString(variantId)); // path parameter
            if (currencyCode != null) localVarPathParams.Add("currency_code", this.Configuration.ApiClient.ParameterToString(currencyCode)); // path parameter
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
                Exception exception = ExceptionFactory("DeletePriceListRecord", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                null);
        }

        /// <summary>
        /// Delete a Price List Record Deletes a *Price List Record*. Deleting the records does not delete the Price List. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantIdin">The ID of the &#x60;Variant&#x60; whose prices were requested. (optional)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>NoContent</returns>
        public NoContent DeletePriceListRecordsByFilter (int? priceListId, int? variantIdin = null, string accept = null, string contentType = null)
        {
             ApiResponse<NoContent> localVarResponse = DeletePriceListRecordsByFilterWithHttpInfo(priceListId, variantIdin, accept, contentType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a Price List Record Deletes a *Price List Record*. Deleting the records does not delete the Price List. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantIdin">The ID of the &#x60;Variant&#x60; whose prices were requested. (optional)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>ApiResponse of NoContent</returns>
        public ApiResponse< NoContent > DeletePriceListRecordsByFilterWithHttpInfo (int? priceListId, int? variantIdin = null, string accept = null, string contentType = null)
        {
            // verify the required parameter 'priceListId' is set
            if (priceListId == null)
                throw new ApiException(400, "Missing required parameter 'priceListId' when calling PriceListsRecordsApi->DeletePriceListRecordsByFilter");

            var localVarPath = "/pricelists/{price_list_id}/records";
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
            if (variantIdin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "variant_id:in", variantIdin)); // query parameter
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
                Exception exception = ExceptionFactory("DeletePriceListRecordsByFilter", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<NoContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (NoContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NoContent)));
        }

        /// <summary>
        /// Delete a Price List Record Deletes a *Price List Record*. Deleting the records does not delete the Price List. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantIdin">The ID of the &#x60;Variant&#x60; whose prices were requested. (optional)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Task of NoContent</returns>
        public async System.Threading.Tasks.Task<NoContent> DeletePriceListRecordsByFilterAsync (int? priceListId, int? variantIdin = null, string accept = null, string contentType = null)
        {
             ApiResponse<NoContent> localVarResponse = await DeletePriceListRecordsByFilterAsyncWithHttpInfo(priceListId, variantIdin, accept, contentType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Delete a Price List Record Deletes a *Price List Record*. Deleting the records does not delete the Price List. Optional parameters can be passed in.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantIdin">The ID of the &#x60;Variant&#x60; whose prices were requested. (optional)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Task of ApiResponse (NoContent)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NoContent>> DeletePriceListRecordsByFilterAsyncWithHttpInfo (int? priceListId, int? variantIdin = null, string accept = null, string contentType = null)
        {
            // verify the required parameter 'priceListId' is set
            if (priceListId == null)
                throw new ApiException(400, "Missing required parameter 'priceListId' when calling PriceListsRecordsApi->DeletePriceListRecordsByFilter");

            var localVarPath = "/pricelists/{price_list_id}/records";
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
            if (variantIdin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "variant_id:in", variantIdin)); // query parameter
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
                Exception exception = ExceptionFactory("DeletePriceListRecordsByFilter", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<NoContent>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (NoContent) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NoContent)));
        }

        /// <summary>
        /// Get a Price Record by Currency Code Returns a *Price List Record* using the currency code. Optional parameters can be used.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="currencyCode">The currency code associated with the price record being acted upon. </param>
        /// <param name="include">Sub-resources to include on a price record, in a comma-separated list. Valid expansions currently include &#x60;bulk_pricing_tiers&#x60; and &#x60;sku&#x60;.  Other valies will be ignored.  (optional)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>PriceRecordResponse</returns>
        public PriceRecordResponse GetPriceListRecord (int? priceListId, int? variantId, string currencyCode, string include = null, string accept = null, string contentType = null)
        {
             ApiResponse<PriceRecordResponse> localVarResponse = GetPriceListRecordWithHttpInfo(priceListId, variantId, currencyCode, include, accept, contentType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a Price Record by Currency Code Returns a *Price List Record* using the currency code. Optional parameters can be used.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="currencyCode">The currency code associated with the price record being acted upon. </param>
        /// <param name="include">Sub-resources to include on a price record, in a comma-separated list. Valid expansions currently include &#x60;bulk_pricing_tiers&#x60; and &#x60;sku&#x60;.  Other valies will be ignored.  (optional)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>ApiResponse of PriceRecordResponse</returns>
        public ApiResponse< PriceRecordResponse > GetPriceListRecordWithHttpInfo (int? priceListId, int? variantId, string currencyCode, string include = null, string accept = null, string contentType = null)
        {
            // verify the required parameter 'priceListId' is set
            if (priceListId == null)
                throw new ApiException(400, "Missing required parameter 'priceListId' when calling PriceListsRecordsApi->GetPriceListRecord");
            // verify the required parameter 'variantId' is set
            if (variantId == null)
                throw new ApiException(400, "Missing required parameter 'variantId' when calling PriceListsRecordsApi->GetPriceListRecord");
            // verify the required parameter 'currencyCode' is set
            if (currencyCode == null)
                throw new ApiException(400, "Missing required parameter 'currencyCode' when calling PriceListsRecordsApi->GetPriceListRecord");

            var localVarPath = "/pricelists/{price_list_id}/records/{variant_id}/{currency_code}";
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
            if (variantId != null) localVarPathParams.Add("variant_id", this.Configuration.ApiClient.ParameterToString(variantId)); // path parameter
            if (currencyCode != null) localVarPathParams.Add("currency_code", this.Configuration.ApiClient.ParameterToString(currencyCode)); // path parameter
            if (include != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include", include)); // query parameter
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
                Exception exception = ExceptionFactory("GetPriceListRecord", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PriceRecordResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PriceRecordResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PriceRecordResponse)));
        }

        /// <summary>
        /// Get a Price Record by Currency Code Returns a *Price List Record* using the currency code. Optional parameters can be used.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="currencyCode">The currency code associated with the price record being acted upon. </param>
        /// <param name="include">Sub-resources to include on a price record, in a comma-separated list. Valid expansions currently include &#x60;bulk_pricing_tiers&#x60; and &#x60;sku&#x60;.  Other valies will be ignored.  (optional)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Task of PriceRecordResponse</returns>
        public async System.Threading.Tasks.Task<PriceRecordResponse> GetPriceListRecordAsync (int? priceListId, int? variantId, string currencyCode, string include = null, string accept = null, string contentType = null)
        {
             ApiResponse<PriceRecordResponse> localVarResponse = await GetPriceListRecordAsyncWithHttpInfo(priceListId, variantId, currencyCode, include, accept, contentType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a Price Record by Currency Code Returns a *Price List Record* using the currency code. Optional parameters can be used.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="currencyCode">The currency code associated with the price record being acted upon. </param>
        /// <param name="include">Sub-resources to include on a price record, in a comma-separated list. Valid expansions currently include &#x60;bulk_pricing_tiers&#x60; and &#x60;sku&#x60;.  Other valies will be ignored.  (optional)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Task of ApiResponse (PriceRecordResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PriceRecordResponse>> GetPriceListRecordAsyncWithHttpInfo (int? priceListId, int? variantId, string currencyCode, string include = null, string accept = null, string contentType = null)
        {
            // verify the required parameter 'priceListId' is set
            if (priceListId == null)
                throw new ApiException(400, "Missing required parameter 'priceListId' when calling PriceListsRecordsApi->GetPriceListRecord");
            // verify the required parameter 'variantId' is set
            if (variantId == null)
                throw new ApiException(400, "Missing required parameter 'variantId' when calling PriceListsRecordsApi->GetPriceListRecord");
            // verify the required parameter 'currencyCode' is set
            if (currencyCode == null)
                throw new ApiException(400, "Missing required parameter 'currencyCode' when calling PriceListsRecordsApi->GetPriceListRecord");

            var localVarPath = "/pricelists/{price_list_id}/records/{variant_id}/{currency_code}";
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
            if (variantId != null) localVarPathParams.Add("variant_id", this.Configuration.ApiClient.ParameterToString(variantId)); // path parameter
            if (currencyCode != null) localVarPathParams.Add("currency_code", this.Configuration.ApiClient.ParameterToString(currencyCode)); // path parameter
            if (include != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include", include)); // query parameter
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
                Exception exception = ExceptionFactory("GetPriceListRecord", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PriceRecordResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PriceRecordResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PriceRecordResponse)));
        }

        /// <summary>
        /// Get All Price List Records Returns a list of *Price List Records* associated with a *Price List*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantIdin">The ID of the &#x60;Variant&#x60; whose prices were requested. (optional)</param>
        /// <param name="productIdin">A comma-separated list of ids of &#x60;Product&#x60;s whose prices were requested.  (optional)</param>
        /// <param name="currency">Filter items by currency.  (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="include">Sub-resources to include on a price record, in a comma-separated list. Valid expansions currently include &#x60;bulk_pricing_tiers&#x60; and &#x60;sku&#x60;.  Other valies will be ignored.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="salePrice">Filter items by sale_price.  (optional)</param>
        /// <param name="retailPrice">Filter items by retail_price.  (optional)</param>
        /// <param name="mapPrice">Filter items by map_price.  (optional)</param>
        /// <param name="calculatedPrice">Filter items by calculated_price.  (optional)</param>
        /// <param name="dateCreated">Filter items by date_created.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <returns>PriceRecordCollectionResponse</returns>
        public PriceRecordCollectionResponse GetPriceListRecordCollection (int? priceListId, int? variantIdin = null, string productIdin = null, string currency = null, int? page = null, int? limit = null, string include = null, decimal? price = null, decimal? salePrice = null, decimal? retailPrice = null, decimal? mapPrice = null, decimal? calculatedPrice = null, DateTime? dateCreated = null, DateTime? dateModified = null, string sku = null, string contentType = null, string accept = null)
        {
             ApiResponse<PriceRecordCollectionResponse> localVarResponse = GetPriceListRecordCollectionWithHttpInfo(priceListId, variantIdin, productIdin, currency, page, limit, include, price, salePrice, retailPrice, mapPrice, calculatedPrice, dateCreated, dateModified, sku, contentType, accept);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get All Price List Records Returns a list of *Price List Records* associated with a *Price List*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantIdin">The ID of the &#x60;Variant&#x60; whose prices were requested. (optional)</param>
        /// <param name="productIdin">A comma-separated list of ids of &#x60;Product&#x60;s whose prices were requested.  (optional)</param>
        /// <param name="currency">Filter items by currency.  (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="include">Sub-resources to include on a price record, in a comma-separated list. Valid expansions currently include &#x60;bulk_pricing_tiers&#x60; and &#x60;sku&#x60;.  Other valies will be ignored.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="salePrice">Filter items by sale_price.  (optional)</param>
        /// <param name="retailPrice">Filter items by retail_price.  (optional)</param>
        /// <param name="mapPrice">Filter items by map_price.  (optional)</param>
        /// <param name="calculatedPrice">Filter items by calculated_price.  (optional)</param>
        /// <param name="dateCreated">Filter items by date_created.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <returns>ApiResponse of PriceRecordCollectionResponse</returns>
        public ApiResponse< PriceRecordCollectionResponse > GetPriceListRecordCollectionWithHttpInfo (int? priceListId, int? variantIdin = null, string productIdin = null, string currency = null, int? page = null, int? limit = null, string include = null, decimal? price = null, decimal? salePrice = null, decimal? retailPrice = null, decimal? mapPrice = null, decimal? calculatedPrice = null, DateTime? dateCreated = null, DateTime? dateModified = null, string sku = null, string contentType = null, string accept = null)
        {
            // verify the required parameter 'priceListId' is set
            if (priceListId == null)
                throw new ApiException(400, "Missing required parameter 'priceListId' when calling PriceListsRecordsApi->GetPriceListRecordCollection");

            var localVarPath = "/pricelists/{price_list_id}/records";
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
            if (variantIdin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "variant_id:in", variantIdin)); // query parameter
            if (productIdin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "product_id:in", productIdin)); // query parameter
            if (currency != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "currency", currency)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (include != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include", include)); // query parameter
            if (price != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "price", price)); // query parameter
            if (salePrice != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sale_price", salePrice)); // query parameter
            if (retailPrice != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "retail_price", retailPrice)); // query parameter
            if (mapPrice != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "map_price", mapPrice)); // query parameter
            if (calculatedPrice != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "calculated_price", calculatedPrice)); // query parameter
            if (dateCreated != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date_created", dateCreated)); // query parameter
            if (dateModified != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date_modified", dateModified)); // query parameter
            if (sku != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sku", sku)); // query parameter
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
                Exception exception = ExceptionFactory("GetPriceListRecordCollection", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PriceRecordCollectionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PriceRecordCollectionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PriceRecordCollectionResponse)));
        }

        /// <summary>
        /// Get All Price List Records Returns a list of *Price List Records* associated with a *Price List*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantIdin">The ID of the &#x60;Variant&#x60; whose prices were requested. (optional)</param>
        /// <param name="productIdin">A comma-separated list of ids of &#x60;Product&#x60;s whose prices were requested.  (optional)</param>
        /// <param name="currency">Filter items by currency.  (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="include">Sub-resources to include on a price record, in a comma-separated list. Valid expansions currently include &#x60;bulk_pricing_tiers&#x60; and &#x60;sku&#x60;.  Other valies will be ignored.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="salePrice">Filter items by sale_price.  (optional)</param>
        /// <param name="retailPrice">Filter items by retail_price.  (optional)</param>
        /// <param name="mapPrice">Filter items by map_price.  (optional)</param>
        /// <param name="calculatedPrice">Filter items by calculated_price.  (optional)</param>
        /// <param name="dateCreated">Filter items by date_created.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <returns>Task of PriceRecordCollectionResponse</returns>
        public async System.Threading.Tasks.Task<PriceRecordCollectionResponse> GetPriceListRecordCollectionAsync (int? priceListId, int? variantIdin = null, string productIdin = null, string currency = null, int? page = null, int? limit = null, string include = null, decimal? price = null, decimal? salePrice = null, decimal? retailPrice = null, decimal? mapPrice = null, decimal? calculatedPrice = null, DateTime? dateCreated = null, DateTime? dateModified = null, string sku = null, string contentType = null, string accept = null)
        {
             ApiResponse<PriceRecordCollectionResponse> localVarResponse = await GetPriceListRecordCollectionAsyncWithHttpInfo(priceListId, variantIdin, productIdin, currency, page, limit, include, price, salePrice, retailPrice, mapPrice, calculatedPrice, dateCreated, dateModified, sku, contentType, accept);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get All Price List Records Returns a list of *Price List Records* associated with a *Price List*.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantIdin">The ID of the &#x60;Variant&#x60; whose prices were requested. (optional)</param>
        /// <param name="productIdin">A comma-separated list of ids of &#x60;Product&#x60;s whose prices were requested.  (optional)</param>
        /// <param name="currency">Filter items by currency.  (optional)</param>
        /// <param name="page">Specifies the page number in a limited (paginated) list of products. (optional)</param>
        /// <param name="limit">Controls the number of items per page in a limited (paginated) list of products. (optional)</param>
        /// <param name="include">Sub-resources to include on a price record, in a comma-separated list. Valid expansions currently include &#x60;bulk_pricing_tiers&#x60; and &#x60;sku&#x60;.  Other valies will be ignored.  (optional)</param>
        /// <param name="price">Filter items by price.  (optional)</param>
        /// <param name="salePrice">Filter items by sale_price.  (optional)</param>
        /// <param name="retailPrice">Filter items by retail_price.  (optional)</param>
        /// <param name="mapPrice">Filter items by map_price.  (optional)</param>
        /// <param name="calculatedPrice">Filter items by calculated_price.  (optional)</param>
        /// <param name="dateCreated">Filter items by date_created.  (optional)</param>
        /// <param name="dateModified">Filter items by date_modified. For example &#x60;v3/catalog/products?date_last_imported:min&#x3D;2018-06-15&#x60; (optional)</param>
        /// <param name="sku">Filter items by sku.  (optional)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <returns>Task of ApiResponse (PriceRecordCollectionResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PriceRecordCollectionResponse>> GetPriceListRecordCollectionAsyncWithHttpInfo (int? priceListId, int? variantIdin = null, string productIdin = null, string currency = null, int? page = null, int? limit = null, string include = null, decimal? price = null, decimal? salePrice = null, decimal? retailPrice = null, decimal? mapPrice = null, decimal? calculatedPrice = null, DateTime? dateCreated = null, DateTime? dateModified = null, string sku = null, string contentType = null, string accept = null)
        {
            // verify the required parameter 'priceListId' is set
            if (priceListId == null)
                throw new ApiException(400, "Missing required parameter 'priceListId' when calling PriceListsRecordsApi->GetPriceListRecordCollection");

            var localVarPath = "/pricelists/{price_list_id}/records";
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
            if (variantIdin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "variant_id:in", variantIdin)); // query parameter
            if (productIdin != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "product_id:in", productIdin)); // query parameter
            if (currency != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "currency", currency)); // query parameter
            if (page != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter
            if (include != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "include", include)); // query parameter
            if (price != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "price", price)); // query parameter
            if (salePrice != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sale_price", salePrice)); // query parameter
            if (retailPrice != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "retail_price", retailPrice)); // query parameter
            if (mapPrice != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "map_price", mapPrice)); // query parameter
            if (calculatedPrice != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "calculated_price", calculatedPrice)); // query parameter
            if (dateCreated != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date_created", dateCreated)); // query parameter
            if (dateModified != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "date_modified", dateModified)); // query parameter
            if (sku != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "sku", sku)); // query parameter
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
                Exception exception = ExceptionFactory("GetPriceListRecordCollection", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PriceRecordCollectionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PriceRecordCollectionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PriceRecordCollectionResponse)));
        }

        /// <summary>
        /// Get Price Records by Variant Returns *Price List Records* using the variant ID. Will also contain currency records.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>PriceRecordCollectionResponse</returns>
        public PriceRecordCollectionResponse GetPriceListRecordsByVariantId (int? priceListId, int? variantId, string accept = null, string contentType = null)
        {
             ApiResponse<PriceRecordCollectionResponse> localVarResponse = GetPriceListRecordsByVariantIdWithHttpInfo(priceListId, variantId, accept, contentType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Price Records by Variant Returns *Price List Records* using the variant ID. Will also contain currency records.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>ApiResponse of PriceRecordCollectionResponse</returns>
        public ApiResponse< PriceRecordCollectionResponse > GetPriceListRecordsByVariantIdWithHttpInfo (int? priceListId, int? variantId, string accept = null, string contentType = null)
        {
            // verify the required parameter 'priceListId' is set
            if (priceListId == null)
                throw new ApiException(400, "Missing required parameter 'priceListId' when calling PriceListsRecordsApi->GetPriceListRecordsByVariantId");
            // verify the required parameter 'variantId' is set
            if (variantId == null)
                throw new ApiException(400, "Missing required parameter 'variantId' when calling PriceListsRecordsApi->GetPriceListRecordsByVariantId");

            var localVarPath = "/pricelists/{price_list_id}/records/{variant_id}";
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
            if (variantId != null) localVarPathParams.Add("variant_id", this.Configuration.ApiClient.ParameterToString(variantId)); // path parameter
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
                Exception exception = ExceptionFactory("GetPriceListRecordsByVariantId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PriceRecordCollectionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PriceRecordCollectionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PriceRecordCollectionResponse)));
        }

        /// <summary>
        /// Get Price Records by Variant Returns *Price List Records* using the variant ID. Will also contain currency records.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Task of PriceRecordCollectionResponse</returns>
        public async System.Threading.Tasks.Task<PriceRecordCollectionResponse> GetPriceListRecordsByVariantIdAsync (int? priceListId, int? variantId, string accept = null, string contentType = null)
        {
             ApiResponse<PriceRecordCollectionResponse> localVarResponse = await GetPriceListRecordsByVariantIdAsyncWithHttpInfo(priceListId, variantId, accept, contentType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Price Records by Variant Returns *Price List Records* using the variant ID. Will also contain currency records.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Task of ApiResponse (PriceRecordCollectionResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PriceRecordCollectionResponse>> GetPriceListRecordsByVariantIdAsyncWithHttpInfo (int? priceListId, int? variantId, string accept = null, string contentType = null)
        {
            // verify the required parameter 'priceListId' is set
            if (priceListId == null)
                throw new ApiException(400, "Missing required parameter 'priceListId' when calling PriceListsRecordsApi->GetPriceListRecordsByVariantId");
            // verify the required parameter 'variantId' is set
            if (variantId == null)
                throw new ApiException(400, "Missing required parameter 'variantId' when calling PriceListsRecordsApi->GetPriceListRecordsByVariantId");

            var localVarPath = "/pricelists/{price_list_id}/records/{variant_id}";
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
            if (variantId != null) localVarPathParams.Add("variant_id", this.Configuration.ApiClient.ParameterToString(variantId)); // path parameter
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
                Exception exception = ExceptionFactory("GetPriceListRecordsByVariantId", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PriceRecordCollectionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PriceRecordCollectionResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PriceRecordCollectionResponse)));
        }

        /// <summary>
        /// Set Price List Record by Currency Code Creates or updates a*Price List Record* using the currency code.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="currencyCode">The currency code associated with the price record being acted upon. </param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>PriceRecordResponse</returns>
        public PriceRecordResponse SetPriceListRecord (PriceRecordPut body, int? priceListId, int? variantId, string currencyCode, string accept = null, string contentType = null)
        {
             ApiResponse<PriceRecordResponse> localVarResponse = SetPriceListRecordWithHttpInfo(body, priceListId, variantId, currencyCode, accept, contentType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Set Price List Record by Currency Code Creates or updates a*Price List Record* using the currency code.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="currencyCode">The currency code associated with the price record being acted upon. </param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>ApiResponse of PriceRecordResponse</returns>
        public ApiResponse< PriceRecordResponse > SetPriceListRecordWithHttpInfo (PriceRecordPut body, int? priceListId, int? variantId, string currencyCode, string accept = null, string contentType = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PriceListsRecordsApi->SetPriceListRecord");
            // verify the required parameter 'priceListId' is set
            if (priceListId == null)
                throw new ApiException(400, "Missing required parameter 'priceListId' when calling PriceListsRecordsApi->SetPriceListRecord");
            // verify the required parameter 'variantId' is set
            if (variantId == null)
                throw new ApiException(400, "Missing required parameter 'variantId' when calling PriceListsRecordsApi->SetPriceListRecord");
            // verify the required parameter 'currencyCode' is set
            if (currencyCode == null)
                throw new ApiException(400, "Missing required parameter 'currencyCode' when calling PriceListsRecordsApi->SetPriceListRecord");

            var localVarPath = "/pricelists/{price_list_id}/records/{variant_id}/{currency_code}";
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
            if (variantId != null) localVarPathParams.Add("variant_id", this.Configuration.ApiClient.ParameterToString(variantId)); // path parameter
            if (currencyCode != null) localVarPathParams.Add("currency_code", this.Configuration.ApiClient.ParameterToString(currencyCode)); // path parameter
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
                Exception exception = ExceptionFactory("SetPriceListRecord", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PriceRecordResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PriceRecordResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PriceRecordResponse)));
        }

        /// <summary>
        /// Set Price List Record by Currency Code Creates or updates a*Price List Record* using the currency code.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="currencyCode">The currency code associated with the price record being acted upon. </param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Task of PriceRecordResponse</returns>
        public async System.Threading.Tasks.Task<PriceRecordResponse> SetPriceListRecordAsync (PriceRecordPut body, int? priceListId, int? variantId, string currencyCode, string accept = null, string contentType = null)
        {
             ApiResponse<PriceRecordResponse> localVarResponse = await SetPriceListRecordAsyncWithHttpInfo(body, priceListId, variantId, currencyCode, accept, contentType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Set Price List Record by Currency Code Creates or updates a*Price List Record* using the currency code.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="variantId">ID of the variant on a product, or on an associated Price List Record. </param>
        /// <param name="currencyCode">The currency code associated with the price record being acted upon. </param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Task of ApiResponse (PriceRecordResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PriceRecordResponse>> SetPriceListRecordAsyncWithHttpInfo (PriceRecordPut body, int? priceListId, int? variantId, string currencyCode, string accept = null, string contentType = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PriceListsRecordsApi->SetPriceListRecord");
            // verify the required parameter 'priceListId' is set
            if (priceListId == null)
                throw new ApiException(400, "Missing required parameter 'priceListId' when calling PriceListsRecordsApi->SetPriceListRecord");
            // verify the required parameter 'variantId' is set
            if (variantId == null)
                throw new ApiException(400, "Missing required parameter 'variantId' when calling PriceListsRecordsApi->SetPriceListRecord");
            // verify the required parameter 'currencyCode' is set
            if (currencyCode == null)
                throw new ApiException(400, "Missing required parameter 'currencyCode' when calling PriceListsRecordsApi->SetPriceListRecord");

            var localVarPath = "/pricelists/{price_list_id}/records/{variant_id}/{currency_code}";
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
            if (variantId != null) localVarPathParams.Add("variant_id", this.Configuration.ApiClient.ParameterToString(variantId)); // path parameter
            if (currencyCode != null) localVarPathParams.Add("currency_code", this.Configuration.ApiClient.ParameterToString(currencyCode)); // path parameter
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
                Exception exception = ExceptionFactory("SetPriceListRecord", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PriceRecordResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (PriceRecordResponse) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(PriceRecordResponse)));
        }

        /// <summary>
        /// Upsert Price List Records Creates or updates *Price List Records*.   **Required Fields** * currency  **Notes**  * Batch updates are supported by this endpoint, meaning that several price objects can be updated in one request. This allows you to do the same work as many individual requests to singleton endpoints * Batch requests support up to 1,000 items per request. * Up to 2 concurrent batch upsert requests are supported with this API. Running more than the allowed concurrent requests in parallel on the **same store** will cause a 429 error and your additional requests will fail. You are encouraged to run requests sequentially with as many records per request as possible, in order to maximize performance.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="xStrictMode">Header that determines whether the Batch API operates in strict mode or not.  Strict mode will reject the entire request if any item in the batch has an error.  (optional, default to 0)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Object</returns>
        public Object SetPriceListRecordCollection (List<Object> body, int? priceListId, int? xStrictMode = null, string accept = null, string contentType = null)
        {
             ApiResponse<Object> localVarResponse = SetPriceListRecordCollectionWithHttpInfo(body, priceListId, xStrictMode, accept, contentType);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Upsert Price List Records Creates or updates *Price List Records*.   **Required Fields** * currency  **Notes**  * Batch updates are supported by this endpoint, meaning that several price objects can be updated in one request. This allows you to do the same work as many individual requests to singleton endpoints * Batch requests support up to 1,000 items per request. * Up to 2 concurrent batch upsert requests are supported with this API. Running more than the allowed concurrent requests in parallel on the **same store** will cause a 429 error and your additional requests will fail. You are encouraged to run requests sequentially with as many records per request as possible, in order to maximize performance.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="xStrictMode">Header that determines whether the Batch API operates in strict mode or not.  Strict mode will reject the entire request if any item in the batch has an error.  (optional, default to 0)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>ApiResponse of Object</returns>
        public ApiResponse< Object > SetPriceListRecordCollectionWithHttpInfo (List<Object> body, int? priceListId, int? xStrictMode = null, string accept = null, string contentType = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PriceListsRecordsApi->SetPriceListRecordCollection");
            // verify the required parameter 'priceListId' is set
            if (priceListId == null)
                throw new ApiException(400, "Missing required parameter 'priceListId' when calling PriceListsRecordsApi->SetPriceListRecordCollection");

            var localVarPath = "/pricelists/{price_list_id}/records";
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
            if (xStrictMode != null) localVarHeaderParams.Add("X-Strict-Mode", this.Configuration.ApiClient.ParameterToString(xStrictMode)); // header parameter
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
                Exception exception = ExceptionFactory("SetPriceListRecordCollection", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

        /// <summary>
        /// Upsert Price List Records Creates or updates *Price List Records*.   **Required Fields** * currency  **Notes**  * Batch updates are supported by this endpoint, meaning that several price objects can be updated in one request. This allows you to do the same work as many individual requests to singleton endpoints * Batch requests support up to 1,000 items per request. * Up to 2 concurrent batch upsert requests are supported with this API. Running more than the allowed concurrent requests in parallel on the **same store** will cause a 429 error and your additional requests will fail. You are encouraged to run requests sequentially with as many records per request as possible, in order to maximize performance.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="xStrictMode">Header that determines whether the Batch API operates in strict mode or not.  Strict mode will reject the entire request if any item in the batch has an error.  (optional, default to 0)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Task of Object</returns>
        public async System.Threading.Tasks.Task<Object> SetPriceListRecordCollectionAsync (List<Object> body, int? priceListId, int? xStrictMode = null, string accept = null, string contentType = null)
        {
             ApiResponse<Object> localVarResponse = await SetPriceListRecordCollectionAsyncWithHttpInfo(body, priceListId, xStrictMode, accept, contentType);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Upsert Price List Records Creates or updates *Price List Records*.   **Required Fields** * currency  **Notes**  * Batch updates are supported by this endpoint, meaning that several price objects can be updated in one request. This allows you to do the same work as many individual requests to singleton endpoints * Batch requests support up to 1,000 items per request. * Up to 2 concurrent batch upsert requests are supported with this API. Running more than the allowed concurrent requests in parallel on the **same store** will cause a 429 error and your additional requests will fail. You are encouraged to run requests sequentially with as many records per request as possible, in order to maximize performance.
        /// </summary>
        /// <exception cref="BigCommerce.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <param name="priceListId">The ID of the &#x60;Price List&#x60; requested. </param>
        /// <param name="xStrictMode">Header that determines whether the Batch API operates in strict mode or not.  Strict mode will reject the entire request if any item in the batch has an error.  (optional, default to 0)</param>
        /// <param name="accept"> (optional, default to application/json)</param>
        /// <param name="contentType"> (optional, default to application/json)</param>
        /// <returns>Task of ApiResponse (Object)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> SetPriceListRecordCollectionAsyncWithHttpInfo (List<Object> body, int? priceListId, int? xStrictMode = null, string accept = null, string contentType = null)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling PriceListsRecordsApi->SetPriceListRecordCollection");
            // verify the required parameter 'priceListId' is set
            if (priceListId == null)
                throw new ApiException(400, "Missing required parameter 'priceListId' when calling PriceListsRecordsApi->SetPriceListRecordCollection");

            var localVarPath = "/pricelists/{price_list_id}/records";
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
            if (xStrictMode != null) localVarHeaderParams.Add("X-Strict-Mode", this.Configuration.ApiClient.ParameterToString(xStrictMode)); // header parameter
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
                Exception exception = ExceptionFactory("SetPriceListRecordCollection", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (Object) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(Object)));
        }

    }
}
