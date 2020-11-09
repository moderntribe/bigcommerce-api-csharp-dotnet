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
    ///  Class for testing ProductsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ProductsApiTests
    {
        private ProductsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProductsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProductsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ProductsApi
            //Assert.IsInstanceOfType(typeof(ProductsApi), instance, "instance is a ProductsApi");
        }

        /// <summary>
        /// Test CreateProduct
        /// </summary>
        [Test]
        public void CreateProductTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductPost1 body = null;
            //string contentType = null;
            //string accept = null;
            //string includeFields = null;
            //var response = instance.CreateProduct(body, contentType, accept, includeFields);
            //Assert.IsInstanceOf<ProductResponse> (response, "response is ProductResponse");
        }
        /// <summary>
        /// Test DeleteProductById
        /// </summary>
        [Test]
        public void DeleteProductByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productId = null;
            //string accept = null;
            //string contentType = null;
            //instance.DeleteProductById(productId, accept, contentType);
            
        }
        /// <summary>
        /// Test DeleteProducts
        /// </summary>
        [Test]
        public void DeleteProductsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string name = null;
            //string sku = null;
            //decimal? price = null;
            //decimal? weight = null;
            //string condition = null;
            //int? brandId = null;
            //DateTime? dateModified = null;
            //DateTime? dateLastImported = null;
            //bool? isVisible = null;
            //int? isFeatured = null;
            //int? inventoryLevel = null;
            //int? totalSold = null;
            //string type = null;
            //int? categories = null;
            //string keyword = null;
            //instance.DeleteProducts(accept, contentType, name, sku, price, weight, condition, brandId, dateModified, dateLastImported, isVisible, isFeatured, inventoryLevel, totalSold, type, categories, keyword);
            
        }
        /// <summary>
        /// Test GetProductById
        /// </summary>
        [Test]
        public void GetProductByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productId = null;
            //string accept = null;
            //string contentType = null;
            //string include = null;
            //string includeFields = null;
            //string excludeFields = null;
            //var response = instance.GetProductById(productId, accept, contentType, include, includeFields, excludeFields);
            //Assert.IsInstanceOf<ProductResponse> (response, "response is ProductResponse");
        }
        /// <summary>
        /// Test GetProducts
        /// </summary>
        [Test]
        public void GetProductsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? id = null;
            //List<int?> idin = null;
            //List<int?> idnotIn = null;
            //List<int?> idmin = null;
            //List<int?> idmax = null;
            //List<int?> idgreater = null;
            //List<int?> idless = null;
            //string name = null;
            //string sku = null;
            //string upc = null;
            //decimal? price = null;
            //decimal? weight = null;
            //string condition = null;
            //int? brandId = null;
            //DateTime? dateModified = null;
            //DateTime? dateLastImported = null;
            //bool? isVisible = null;
            //int? isFeatured = null;
            //int? isFreeShipping = null;
            //int? inventoryLevel = null;
            //int? inventoryLow = null;
            //int? outOfStock = null;
            //int? totalSold = null;
            //string type = null;
            //int? categories = null;
            //string keyword = null;
            //string keywordContext = null;
            //int? status = null;
            //string include = null;
            //string includeFields = null;
            //string excludeFields = null;
            //string availability = null;
            //int? priceListId = null;
            //int? page = null;
            //int? limit = null;
            //string direction = null;
            //string sort = null;
            //var response = instance.GetProducts(id, idin, idnotIn, idmin, idmax, idgreater, idless, name, sku, upc, price, weight, condition, brandId, dateModified, dateLastImported, isVisible, isFeatured, isFreeShipping, inventoryLevel, inventoryLow, outOfStock, totalSold, type, categories, keyword, keywordContext, status, include, includeFields, excludeFields, availability, priceListId, page, limit, direction, sort);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
        /// <summary>
        /// Test UpdateProduct
        /// </summary>
        [Test]
        public void UpdateProductTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //ProductPut1 body = null;
            //string accept = null;
            //string contentType = null;
            //int? productId = null;
            //string includeFields = null;
            //var response = instance.UpdateProduct(body, accept, contentType, productId, includeFields);
            //Assert.IsInstanceOf<ProductResponse> (response, "response is ProductResponse");
        }
        /// <summary>
        /// Test UpdateProducts
        /// </summary>
        [Test]
        public void UpdateProductsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //List<Object> body = null;
            //string includeFields = null;
            //var response = instance.UpdateProducts(accept, contentType, body, includeFields);
            //Assert.IsInstanceOf<InlineResponse2001> (response, "response is InlineResponse2001");
        }
    }

}
