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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using BigCommerce.Client;
using BigCommerce.Api;
using BigCommerce.Model;

namespace BigCommerce.Test
{
    /// <summary>
    ///  Class for testing PriceListsRecordsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class PriceListsRecordsApiTests
    {
        private PriceListsRecordsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new PriceListsRecordsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of PriceListsRecordsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' PriceListsRecordsApi
            //Assert.IsInstanceOfType(typeof(PriceListsRecordsApi), instance, "instance is a PriceListsRecordsApi");
        }

        /// <summary>
        /// Test DeletePriceListRecord
        /// </summary>
        [Test]
        public void DeletePriceListRecordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? priceListId = null;
            //int? variantId = null;
            //string currencyCode = null;
            //string contentType = null;
            //string accept = null;
            //instance.DeletePriceListRecord(priceListId, variantId, currencyCode, contentType, accept);
            
        }
        /// <summary>
        /// Test DeletePriceListRecordsByFilter
        /// </summary>
        [Test]
        public void DeletePriceListRecordsByFilterTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? priceListId = null;
            //int? variantIdin = null;
            //string accept = null;
            //string contentType = null;
            //var response = instance.DeletePriceListRecordsByFilter(priceListId, variantIdin, accept, contentType);
            //Assert.IsInstanceOf<NoContent> (response, "response is NoContent");
        }
        /// <summary>
        /// Test GetPriceListRecord
        /// </summary>
        [Test]
        public void GetPriceListRecordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? priceListId = null;
            //int? variantId = null;
            //string currencyCode = null;
            //string include = null;
            //string accept = null;
            //string contentType = null;
            //var response = instance.GetPriceListRecord(priceListId, variantId, currencyCode, include, accept, contentType);
            //Assert.IsInstanceOf<PriceRecordResponse> (response, "response is PriceRecordResponse");
        }
        /// <summary>
        /// Test GetPriceListRecordCollection
        /// </summary>
        [Test]
        public void GetPriceListRecordCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? priceListId = null;
            //int? variantIdin = null;
            //string productIdin = null;
            //string currency = null;
            //int? page = null;
            //int? limit = null;
            //string include = null;
            //decimal? price = null;
            //decimal? salePrice = null;
            //decimal? retailPrice = null;
            //decimal? mapPrice = null;
            //decimal? calculatedPrice = null;
            //DateTime? dateCreated = null;
            //DateTime? dateModified = null;
            //string sku = null;
            //string contentType = null;
            //string accept = null;
            //var response = instance.GetPriceListRecordCollection(priceListId, variantIdin, productIdin, currency, page, limit, include, price, salePrice, retailPrice, mapPrice, calculatedPrice, dateCreated, dateModified, sku, contentType, accept);
            //Assert.IsInstanceOf<PriceRecordCollectionResponse> (response, "response is PriceRecordCollectionResponse");
        }
        /// <summary>
        /// Test GetPriceListRecordsByVariantId
        /// </summary>
        [Test]
        public void GetPriceListRecordsByVariantIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? priceListId = null;
            //int? variantId = null;
            //string accept = null;
            //string contentType = null;
            //var response = instance.GetPriceListRecordsByVariantId(priceListId, variantId, accept, contentType);
            //Assert.IsInstanceOf<PriceRecordCollectionResponse> (response, "response is PriceRecordCollectionResponse");
        }
        /// <summary>
        /// Test SetPriceListRecord
        /// </summary>
        [Test]
        public void SetPriceListRecordTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //PriceRecordPut body = null;
            //int? priceListId = null;
            //int? variantId = null;
            //string currencyCode = null;
            //string accept = null;
            //string contentType = null;
            //var response = instance.SetPriceListRecord(body, priceListId, variantId, currencyCode, accept, contentType);
            //Assert.IsInstanceOf<PriceRecordResponse> (response, "response is PriceRecordResponse");
        }
        /// <summary>
        /// Test SetPriceListRecordCollection
        /// </summary>
        [Test]
        public void SetPriceListRecordCollectionTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<Object> body = null;
            //int? priceListId = null;
            //int? xStrictMode = null;
            //string accept = null;
            //string contentType = null;
            //var response = instance.SetPriceListRecordCollection(body, priceListId, xStrictMode, accept, contentType);
            //Assert.IsInstanceOf<Object> (response, "response is Object");
        }
    }

}
