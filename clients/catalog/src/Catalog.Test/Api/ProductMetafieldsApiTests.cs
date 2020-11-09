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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using Catalog.Client;
using Catalog.Api;
using Catalog.Model;

namespace Catalog.Test
{
    /// <summary>
    ///  Class for testing ProductMetafieldsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ProductMetafieldsApiTests
    {
        private ProductMetafieldsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProductMetafieldsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProductMetafieldsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ProductMetafieldsApi
            //Assert.IsInstanceOfType(typeof(ProductMetafieldsApi), instance, "instance is a ProductMetafieldsApi");
        }

        /// <summary>
        /// Test CreateProductMetafield
        /// </summary>
        [Test]
        public void CreateProductMetafieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MetafieldPost3 body = null;
            //string accept = null;
            //string contentType = null;
            //int? productId = null;
            //var response = instance.CreateProductMetafield(body, accept, contentType, productId);
            //Assert.IsInstanceOf<MetafieldResponse1> (response, "response is MetafieldResponse1");
        }
        /// <summary>
        /// Test DeleteProductMetafieldById
        /// </summary>
        [Test]
        public void DeleteProductMetafieldByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? metafieldId = null;
            //int? productId = null;
            //string accept = null;
            //string contentType = null;
            //instance.DeleteProductMetafieldById(metafieldId, productId, accept, contentType);
            
        }
        /// <summary>
        /// Test GetProductMetafieldByProductId
        /// </summary>
        [Test]
        public void GetProductMetafieldByProductIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? metafieldId = null;
            //int? productId = null;
            //string accept = null;
            //string contentType = null;
            //string includeFields = null;
            //string excludeFields = null;
            //var response = instance.GetProductMetafieldByProductId(metafieldId, productId, accept, contentType, includeFields, excludeFields);
            //Assert.IsInstanceOf<MetafieldResponse1> (response, "response is MetafieldResponse1");
        }
        /// <summary>
        /// Test GetProductMetafieldsByProductId
        /// </summary>
        [Test]
        public void GetProductMetafieldsByProductIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productId = null;
            //string accept = null;
            //string contentType = null;
            //int? page = null;
            //int? limit = null;
            //string key = null;
            //string _namespace = null;
            //string includeFields = null;
            //string excludeFields = null;
            //var response = instance.GetProductMetafieldsByProductId(productId, accept, contentType, page, limit, key, _namespace, includeFields, excludeFields);
            //Assert.IsInstanceOf<MetaFieldCollectionResponse> (response, "response is MetaFieldCollectionResponse");
        }
        /// <summary>
        /// Test UpdateProductMetafield
        /// </summary>
        [Test]
        public void UpdateProductMetafieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //MetafieldPut3 body = null;
            //string accept = null;
            //string contentType = null;
            //int? metafieldId = null;
            //int? productId = null;
            //var response = instance.UpdateProductMetafield(body, accept, contentType, metafieldId, productId);
            //Assert.IsInstanceOf<MetafieldResponse2> (response, "response is MetafieldResponse2");
        }
    }

}
