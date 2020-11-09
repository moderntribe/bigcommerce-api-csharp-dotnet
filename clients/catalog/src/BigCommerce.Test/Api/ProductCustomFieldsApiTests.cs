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

using BigCommerce.Client;
using BigCommerce.Api;
using BigCommerce.Model;

namespace BigCommerce.Test
{
    /// <summary>
    ///  Class for testing ProductCustomFieldsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ProductCustomFieldsApiTests
    {
        private ProductCustomFieldsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ProductCustomFieldsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProductCustomFieldsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ProductCustomFieldsApi
            //Assert.IsInstanceOfType(typeof(ProductCustomFieldsApi), instance, "instance is a ProductCustomFieldsApi");
        }

        /// <summary>
        /// Test CreateCustomField
        /// </summary>
        [Test]
        public void CreateCustomFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CustomField body = null;
            //string accept = null;
            //string contentType = null;
            //int? productId = null;
            //var response = instance.CreateCustomField(body, accept, contentType, productId);
            //Assert.IsInstanceOf<InlineResponse2007> (response, "response is InlineResponse2007");
        }
        /// <summary>
        /// Test DeleteCustomFieldById
        /// </summary>
        [Test]
        public void DeleteCustomFieldByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productId = null;
            //int? customFieldId = null;
            //string accept = null;
            //string contentType = null;
            //instance.DeleteCustomFieldById(productId, customFieldId, accept, contentType);
            
        }
        /// <summary>
        /// Test GetCustomFieldById
        /// </summary>
        [Test]
        public void GetCustomFieldByIdTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productId = null;
            //int? customFieldId = null;
            //string accept = null;
            //string contentType = null;
            //string includeFields = null;
            //string excludeFields = null;
            //var response = instance.GetCustomFieldById(productId, customFieldId, accept, contentType, includeFields, excludeFields);
            //Assert.IsInstanceOf<InlineResponse2008> (response, "response is InlineResponse2008");
        }
        /// <summary>
        /// Test GetCustomFields
        /// </summary>
        [Test]
        public void GetCustomFieldsTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //int? productId = null;
            //string accept = null;
            //string contentType = null;
            //string includeFields = null;
            //string excludeFields = null;
            //int? page = null;
            //int? limit = null;
            //var response = instance.GetCustomFields(productId, accept, contentType, includeFields, excludeFields, page, limit);
            //Assert.IsInstanceOf<InlineResponse2006> (response, "response is InlineResponse2006");
        }
        /// <summary>
        /// Test UpdateCustomField
        /// </summary>
        [Test]
        public void UpdateCustomFieldTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //CustomField1 body = null;
            //string accept = null;
            //string contentType = null;
            //int? productId = null;
            //int? customFieldId = null;
            //var response = instance.UpdateCustomField(body, accept, contentType, productId, customFieldId);
            //Assert.IsInstanceOf<InlineResponse2007> (response, "response is InlineResponse2007");
        }
    }

}
