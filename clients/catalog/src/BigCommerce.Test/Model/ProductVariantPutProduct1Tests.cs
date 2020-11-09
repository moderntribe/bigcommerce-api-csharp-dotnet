/* 
 * Catalog
 *
 * Manage products, brands and categories. To learn more about catalog resources see [Catalog Overview](https://developer.bigcommerce.com/api-docs/catalog/products-overview).  - [Authentication](#authentication) - [Differentiating Variants & Modifiers](#variants-and-modifiers) - [Available Endpoints](#available-endpoints) - [Resources](#resources)  ## Authentication Requests can be authenticated by sending an `access_token` via `X-Auth-Token` HTTP header:  ```http GET /stores/{$$.env.store_hash}/v3/catalog/summary host: api.bigcommerce.com Accept: application/json X-Auth-Token: {access_token} ```  |Header|Parameter|Description| |-|-|-| |`X-Auth-Token`|`access_token `|Obtained by creating an API account or installing an app in a BigCommerce control panel.|  ### OAuth Scopes | UI Name  | Permission | Parameter                     | |- -- -- -- -- -|- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | Products | modify     | `store_v2_products`           | | Products | read-only  | `store_v2_products_read_only` |  For more information on OAuth Scopes, see: [Authentication](https://developer.bigcommerce.com/api-docs/getting-started/authentication).  For more information on Authenticating BigCommerce APIs, see: [Authentication](https://developer.bigcommerce.com/api-docs/getting-started/authentication).  ## Differentiating Variants and Modifiers [Variants](https://support.bigcommerce.com/s/article/Product-Options-v3#variations) represent a physical product made up of [Product Option](https://support.bigcommerce.com/s/article/Product-Options-v3) choices, i.e. a large blue t-shirt. Each variant can have a unique SKU.  Modifiers represent a choice a customer makes about a product that doesn't represent a physical item, i.e. text to be printed on a t-shirt. Assigning a SKU to a modifier will turn it into a variant.  See [Variant Options](https://developer.bigcommerce.com/api-docs/catalog/products-overview#variant-options) and [Modifier Options](https://developer.bigcommerce.com/api-docs/catalog/products-overview#modifier-options) for more information.  ## Available Endpoints | Resource / Endpoint                     | Description                                                             | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | Brand Images                            | Create and manage brand images                                          | | Brand Metafields                        | Create and manage brand metafields                                      | | Brands                                  | Create and manage brands                                                | | Catalog                                 | Create and manage store categories, products, and brands                | | Categories                              | Create and manage categorties                                           | | Category Images                         | Create and manage category images                                       | | Category Metafields                     | Create and manage category metafields                                   | | Product Bulk Pricing Rules              | Create and manage product bulk pricing rules                            | | Product Complex Rules                   | Create and manage product complex rules                                 | | Product Custom Fields                   | Create and manage product custom fields                                 | | Product Images                          | Create and manage product images                                        | | Product Metafields                      | Create and manage product meta fields                                   | | Product Modifier Images                 | Create and manage product modifer images                                | | Product Modifier Values                 | Create and manage product modifier values                               | | Product Modifiers                       | Create and manage product midifiers                                     | | Product Reviews                         | Create and manage product reviews                                       | | Product Variant Option Values           | Create and manage product variant option values                         | | Product Variant Options                 | Create and manage product variant options                               | | Product Variants                        | Create and manage product variants                                      | | Product Videos                          | Create and manage product videos                                        | | Products                                | Create and manage products                                              | | ProductVariant Metafields               | Create and manage product meta flields                                  | | Variants                                | Get and update all variants                                             |  ## Resources  ### Webhooks * [Products](/api-docs/getting-started/webhooks/webhook-events#webhook-events_products) * [Categories](/api-docs/getting-started/webhooks/webhook-events#webhook-events_category) * [SKU](/api-docs/getting-started/webhooks/webhook-events#webhook-events_sku)  ### Related Endpoints * [Catalog API](/api-reference/catalog/catalog-api)
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using BigCommerce.Api;
using BigCommerce.Model;
using BigCommerce.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace BigCommerce.Test
{
    /// <summary>
    ///  Class for testing ProductVariantPutProduct1
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ProductVariantPutProduct1Tests
    {
        // TODO uncomment below to declare an instance variable for ProductVariantPutProduct1
        //private ProductVariantPutProduct1 instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ProductVariantPutProduct1
            //instance = new ProductVariantPutProduct1();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProductVariantPutProduct1
        /// </summary>
        [Test]
        public void ProductVariantPutProduct1InstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ProductVariantPutProduct1
            //Assert.IsInstanceOfType<ProductVariantPutProduct1> (instance, "variable 'instance' is a ProductVariantPutProduct1");
        }


        /// <summary>
        /// Test the property 'BinPickingNumber'
        /// </summary>
        [Test]
        public void BinPickingNumberTest()
        {
            // TODO unit test for the property 'BinPickingNumber'
        }
        /// <summary>
        /// Test the property 'CostPrice'
        /// </summary>
        [Test]
        public void CostPriceTest()
        {
            // TODO unit test for the property 'CostPrice'
        }
        /// <summary>
        /// Test the property 'Depth'
        /// </summary>
        [Test]
        public void DepthTest()
        {
            // TODO unit test for the property 'Depth'
        }
        /// <summary>
        /// Test the property 'FixedCostShippingPrice'
        /// </summary>
        [Test]
        public void FixedCostShippingPriceTest()
        {
            // TODO unit test for the property 'FixedCostShippingPrice'
        }
        /// <summary>
        /// Test the property 'Height'
        /// </summary>
        [Test]
        public void HeightTest()
        {
            // TODO unit test for the property 'Height'
        }
        /// <summary>
        /// Test the property 'InventoryLevel'
        /// </summary>
        [Test]
        public void InventoryLevelTest()
        {
            // TODO unit test for the property 'InventoryLevel'
        }
        /// <summary>
        /// Test the property 'InventoryWarningLevel'
        /// </summary>
        [Test]
        public void InventoryWarningLevelTest()
        {
            // TODO unit test for the property 'InventoryWarningLevel'
        }
        /// <summary>
        /// Test the property 'IsFreeShipping'
        /// </summary>
        [Test]
        public void IsFreeShippingTest()
        {
            // TODO unit test for the property 'IsFreeShipping'
        }
        /// <summary>
        /// Test the property 'Price'
        /// </summary>
        [Test]
        public void PriceTest()
        {
            // TODO unit test for the property 'Price'
        }
        /// <summary>
        /// Test the property 'ProductId'
        /// </summary>
        [Test]
        public void ProductIdTest()
        {
            // TODO unit test for the property 'ProductId'
        }
        /// <summary>
        /// Test the property 'PurchasingDisabled'
        /// </summary>
        [Test]
        public void PurchasingDisabledTest()
        {
            // TODO unit test for the property 'PurchasingDisabled'
        }
        /// <summary>
        /// Test the property 'PurchasingDisabledMessage'
        /// </summary>
        [Test]
        public void PurchasingDisabledMessageTest()
        {
            // TODO unit test for the property 'PurchasingDisabledMessage'
        }
        /// <summary>
        /// Test the property 'RetailPrice'
        /// </summary>
        [Test]
        public void RetailPriceTest()
        {
            // TODO unit test for the property 'RetailPrice'
        }
        /// <summary>
        /// Test the property 'SalePrice'
        /// </summary>
        [Test]
        public void SalePriceTest()
        {
            // TODO unit test for the property 'SalePrice'
        }
        /// <summary>
        /// Test the property 'Sku'
        /// </summary>
        [Test]
        public void SkuTest()
        {
            // TODO unit test for the property 'Sku'
        }
        /// <summary>
        /// Test the property 'Upc'
        /// </summary>
        [Test]
        public void UpcTest()
        {
            // TODO unit test for the property 'Upc'
        }
        /// <summary>
        /// Test the property 'Weight'
        /// </summary>
        [Test]
        public void WeightTest()
        {
            // TODO unit test for the property 'Weight'
        }
        /// <summary>
        /// Test the property 'Width'
        /// </summary>
        [Test]
        public void WidthTest()
        {
            // TODO unit test for the property 'Width'
        }

    }

}
