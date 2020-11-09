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
    ///  Class for testing BrandsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class BrandsApiTests
    {
        private BrandsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new BrandsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of BrandsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' BrandsApi
            //Assert.IsInstanceOfType(typeof(BrandsApi), instance, "instance is a BrandsApi");
        }

        /// <summary>
        /// Test CreateBrand
        /// </summary>
        [Test]
        public void CreateBrandTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Brand body = null;
            //string accept = null;
            //string contentType = null;
            //var response = instance.CreateBrand(body, accept, contentType);
            //Assert.IsInstanceOf<BrandResponse> (response, "response is BrandResponse");
        }
        /// <summary>
        /// Test DeleteBrandById
        /// </summary>
        [Test]
        public void DeleteBrandByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? brandId = null;
            //string accept = null;
            //string contentType = null;
            //instance.DeleteBrandById(brandId, accept, contentType);
            
        }
        /// <summary>
        /// Test DeleteBrands
        /// </summary>
        [Test]
        public void DeleteBrandsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //string name = null;
            //string pageTitle = null;
            //instance.DeleteBrands(accept, contentType, name, pageTitle);
            
        }
        /// <summary>
        /// Test GetBrandById
        /// </summary>
        [Test]
        public void GetBrandByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? brandId = null;
            //string contentType = null;
            //string accept = null;
            //string includeFields = null;
            //string excludeFields = null;
            //var response = instance.GetBrandById(brandId, contentType, accept, includeFields, excludeFields);
            //Assert.IsInstanceOf<BrandResponse1> (response, "response is BrandResponse1");
        }
        /// <summary>
        /// Test GetBrands
        /// </summary>
        [Test]
        public void GetBrandsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string accept = null;
            //string contentType = null;
            //int? id = null;
            //List<int?> idin = null;
            //List<int?> idnotIn = null;
            //List<int?> idmin = null;
            //List<int?> idmax = null;
            //List<int?> idgreater = null;
            //List<int?> idless = null;
            //string name = null;
            //string pageTitle = null;
            //int? page = null;
            //int? limit = null;
            //string includeFields = null;
            //string excludeFields = null;
            //var response = instance.GetBrands(accept, contentType, id, idin, idnotIn, idmin, idmax, idgreater, idless, name, pageTitle, page, limit, includeFields, excludeFields);
            //Assert.IsInstanceOf<BrandCollectionResponse> (response, "response is BrandCollectionResponse");
        }
        /// <summary>
        /// Test UpdateBrand
        /// </summary>
        [Test]
        public void UpdateBrandTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //Brand1 body = null;
            //string contentType = null;
            //string accept = null;
            //int? brandId = null;
            //var response = instance.UpdateBrand(body, contentType, accept, brandId);
            //Assert.IsInstanceOf<BrandResponse> (response, "response is BrandResponse");
        }
    }

}
