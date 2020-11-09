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
using Catalog.Api;
using Catalog.Model;
using Catalog.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace Catalog.Test
{
    /// <summary>
    ///  Class for testing OptionConfig
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class OptionConfigTests
    {
        // TODO uncomment below to declare an instance variable for OptionConfig
        //private OptionConfig instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of OptionConfig
            //instance = new OptionConfig();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of OptionConfig
        /// </summary>
        [Test]
        public void OptionConfigInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" OptionConfig
            //Assert.IsInstanceOfType<OptionConfig> (instance, "variable 'instance' is a OptionConfig");
        }


        /// <summary>
        /// Test the property 'CheckboxLabel'
        /// </summary>
        [Test]
        public void CheckboxLabelTest()
        {
            // TODO unit test for the property 'CheckboxLabel'
        }
        /// <summary>
        /// Test the property 'CheckedByDefault'
        /// </summary>
        [Test]
        public void CheckedByDefaultTest()
        {
            // TODO unit test for the property 'CheckedByDefault'
        }
        /// <summary>
        /// Test the property 'DateEarliestValue'
        /// </summary>
        [Test]
        public void DateEarliestValueTest()
        {
            // TODO unit test for the property 'DateEarliestValue'
        }
        /// <summary>
        /// Test the property 'DateLatestValue'
        /// </summary>
        [Test]
        public void DateLatestValueTest()
        {
            // TODO unit test for the property 'DateLatestValue'
        }
        /// <summary>
        /// Test the property 'DateLimitMode'
        /// </summary>
        [Test]
        public void DateLimitModeTest()
        {
            // TODO unit test for the property 'DateLimitMode'
        }
        /// <summary>
        /// Test the property 'DateLimited'
        /// </summary>
        [Test]
        public void DateLimitedTest()
        {
            // TODO unit test for the property 'DateLimited'
        }
        /// <summary>
        /// Test the property 'DefaultValue'
        /// </summary>
        [Test]
        public void DefaultValueTest()
        {
            // TODO unit test for the property 'DefaultValue'
        }
        /// <summary>
        /// Test the property 'FileMaxSize'
        /// </summary>
        [Test]
        public void FileMaxSizeTest()
        {
            // TODO unit test for the property 'FileMaxSize'
        }
        /// <summary>
        /// Test the property 'FileTypesMode'
        /// </summary>
        [Test]
        public void FileTypesModeTest()
        {
            // TODO unit test for the property 'FileTypesMode'
        }
        /// <summary>
        /// Test the property 'FileTypesOther'
        /// </summary>
        [Test]
        public void FileTypesOtherTest()
        {
            // TODO unit test for the property 'FileTypesOther'
        }
        /// <summary>
        /// Test the property 'FileTypesSupported'
        /// </summary>
        [Test]
        public void FileTypesSupportedTest()
        {
            // TODO unit test for the property 'FileTypesSupported'
        }
        /// <summary>
        /// Test the property 'NumberHighestValue'
        /// </summary>
        [Test]
        public void NumberHighestValueTest()
        {
            // TODO unit test for the property 'NumberHighestValue'
        }
        /// <summary>
        /// Test the property 'NumberIntegersOnly'
        /// </summary>
        [Test]
        public void NumberIntegersOnlyTest()
        {
            // TODO unit test for the property 'NumberIntegersOnly'
        }
        /// <summary>
        /// Test the property 'NumberLimitMode'
        /// </summary>
        [Test]
        public void NumberLimitModeTest()
        {
            // TODO unit test for the property 'NumberLimitMode'
        }
        /// <summary>
        /// Test the property 'NumberLimited'
        /// </summary>
        [Test]
        public void NumberLimitedTest()
        {
            // TODO unit test for the property 'NumberLimited'
        }
        /// <summary>
        /// Test the property 'NumberLowestValue'
        /// </summary>
        [Test]
        public void NumberLowestValueTest()
        {
            // TODO unit test for the property 'NumberLowestValue'
        }
        /// <summary>
        /// Test the property 'ProductListAdjustsInventory'
        /// </summary>
        [Test]
        public void ProductListAdjustsInventoryTest()
        {
            // TODO unit test for the property 'ProductListAdjustsInventory'
        }
        /// <summary>
        /// Test the property 'ProductListAdjustsPricing'
        /// </summary>
        [Test]
        public void ProductListAdjustsPricingTest()
        {
            // TODO unit test for the property 'ProductListAdjustsPricing'
        }
        /// <summary>
        /// Test the property 'ProductListShippingCalc'
        /// </summary>
        [Test]
        public void ProductListShippingCalcTest()
        {
            // TODO unit test for the property 'ProductListShippingCalc'
        }
        /// <summary>
        /// Test the property 'TextCharactersLimited'
        /// </summary>
        [Test]
        public void TextCharactersLimitedTest()
        {
            // TODO unit test for the property 'TextCharactersLimited'
        }
        /// <summary>
        /// Test the property 'TextLinesLimited'
        /// </summary>
        [Test]
        public void TextLinesLimitedTest()
        {
            // TODO unit test for the property 'TextLinesLimited'
        }
        /// <summary>
        /// Test the property 'TextMaxLength'
        /// </summary>
        [Test]
        public void TextMaxLengthTest()
        {
            // TODO unit test for the property 'TextMaxLength'
        }
        /// <summary>
        /// Test the property 'TextMaxLines'
        /// </summary>
        [Test]
        public void TextMaxLinesTest()
        {
            // TODO unit test for the property 'TextMaxLines'
        }
        /// <summary>
        /// Test the property 'TextMinLength'
        /// </summary>
        [Test]
        public void TextMinLengthTest()
        {
            // TODO unit test for the property 'TextMinLength'
        }

    }

}
