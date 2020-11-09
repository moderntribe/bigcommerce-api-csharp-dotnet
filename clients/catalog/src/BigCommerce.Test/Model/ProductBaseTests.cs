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
    ///  Class for testing ProductBase
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ProductBaseTests
    {
        // TODO uncomment below to declare an instance variable for ProductBase
        //private ProductBase instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of ProductBase
            //instance = new ProductBase();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ProductBase
        /// </summary>
        [Test]
        public void ProductBaseInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" ProductBase
            //Assert.IsInstanceOfType<ProductBase> (instance, "variable 'instance' is a ProductBase");
        }


        /// <summary>
        /// Test the property 'Availability'
        /// </summary>
        [Test]
        public void AvailabilityTest()
        {
            // TODO unit test for the property 'Availability'
        }
        /// <summary>
        /// Test the property 'AvailabilityDescription'
        /// </summary>
        [Test]
        public void AvailabilityDescriptionTest()
        {
            // TODO unit test for the property 'AvailabilityDescription'
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
        /// Test the property 'BrandId'
        /// </summary>
        [Test]
        public void BrandIdTest()
        {
            // TODO unit test for the property 'BrandId'
        }
        /// <summary>
        /// Test the property 'BrandNameOrBrandId'
        /// </summary>
        [Test]
        public void BrandNameOrBrandIdTest()
        {
            // TODO unit test for the property 'BrandNameOrBrandId'
        }
        /// <summary>
        /// Test the property 'BulkPricingRules'
        /// </summary>
        [Test]
        public void BulkPricingRulesTest()
        {
            // TODO unit test for the property 'BulkPricingRules'
        }
        /// <summary>
        /// Test the property 'Categories'
        /// </summary>
        [Test]
        public void CategoriesTest()
        {
            // TODO unit test for the property 'Categories'
        }
        /// <summary>
        /// Test the property 'Condition'
        /// </summary>
        [Test]
        public void ConditionTest()
        {
            // TODO unit test for the property 'Condition'
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
        /// Test the property 'CustomFields'
        /// </summary>
        [Test]
        public void CustomFieldsTest()
        {
            // TODO unit test for the property 'CustomFields'
        }
        /// <summary>
        /// Test the property 'CustomUrl'
        /// </summary>
        [Test]
        public void CustomUrlTest()
        {
            // TODO unit test for the property 'CustomUrl'
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
        /// Test the property 'Description'
        /// </summary>
        [Test]
        public void DescriptionTest()
        {
            // TODO unit test for the property 'Description'
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
        /// Test the property 'GiftWrappingOptionsList'
        /// </summary>
        [Test]
        public void GiftWrappingOptionsListTest()
        {
            // TODO unit test for the property 'GiftWrappingOptionsList'
        }
        /// <summary>
        /// Test the property 'GiftWrappingOptionsType'
        /// </summary>
        [Test]
        public void GiftWrappingOptionsTypeTest()
        {
            // TODO unit test for the property 'GiftWrappingOptionsType'
        }
        /// <summary>
        /// Test the property 'Gtin'
        /// </summary>
        [Test]
        public void GtinTest()
        {
            // TODO unit test for the property 'Gtin'
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
        /// Test the property 'Images'
        /// </summary>
        [Test]
        public void ImagesTest()
        {
            // TODO unit test for the property 'Images'
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
        /// Test the property 'InventoryTracking'
        /// </summary>
        [Test]
        public void InventoryTrackingTest()
        {
            // TODO unit test for the property 'InventoryTracking'
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
        /// Test the property 'IsConditionShown'
        /// </summary>
        [Test]
        public void IsConditionShownTest()
        {
            // TODO unit test for the property 'IsConditionShown'
        }
        /// <summary>
        /// Test the property 'IsFeatured'
        /// </summary>
        [Test]
        public void IsFeaturedTest()
        {
            // TODO unit test for the property 'IsFeatured'
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
        /// Test the property 'IsPreorderOnly'
        /// </summary>
        [Test]
        public void IsPreorderOnlyTest()
        {
            // TODO unit test for the property 'IsPreorderOnly'
        }
        /// <summary>
        /// Test the property 'IsPriceHidden'
        /// </summary>
        [Test]
        public void IsPriceHiddenTest()
        {
            // TODO unit test for the property 'IsPriceHidden'
        }
        /// <summary>
        /// Test the property 'IsVisible'
        /// </summary>
        [Test]
        public void IsVisibleTest()
        {
            // TODO unit test for the property 'IsVisible'
        }
        /// <summary>
        /// Test the property 'LayoutFile'
        /// </summary>
        [Test]
        public void LayoutFileTest()
        {
            // TODO unit test for the property 'LayoutFile'
        }
        /// <summary>
        /// Test the property 'MetaDescription'
        /// </summary>
        [Test]
        public void MetaDescriptionTest()
        {
            // TODO unit test for the property 'MetaDescription'
        }
        /// <summary>
        /// Test the property 'MetaKeywords'
        /// </summary>
        [Test]
        public void MetaKeywordsTest()
        {
            // TODO unit test for the property 'MetaKeywords'
        }
        /// <summary>
        /// Test the property 'Mpn'
        /// </summary>
        [Test]
        public void MpnTest()
        {
            // TODO unit test for the property 'Mpn'
        }
        /// <summary>
        /// Test the property 'Name'
        /// </summary>
        [Test]
        public void NameTest()
        {
            // TODO unit test for the property 'Name'
        }
        /// <summary>
        /// Test the property 'OpenGraphDescription'
        /// </summary>
        [Test]
        public void OpenGraphDescriptionTest()
        {
            // TODO unit test for the property 'OpenGraphDescription'
        }
        /// <summary>
        /// Test the property 'OpenGraphTitle'
        /// </summary>
        [Test]
        public void OpenGraphTitleTest()
        {
            // TODO unit test for the property 'OpenGraphTitle'
        }
        /// <summary>
        /// Test the property 'OpenGraphType'
        /// </summary>
        [Test]
        public void OpenGraphTypeTest()
        {
            // TODO unit test for the property 'OpenGraphType'
        }
        /// <summary>
        /// Test the property 'OpenGraphUseImage'
        /// </summary>
        [Test]
        public void OpenGraphUseImageTest()
        {
            // TODO unit test for the property 'OpenGraphUseImage'
        }
        /// <summary>
        /// Test the property 'OpenGraphUseMetaDescription'
        /// </summary>
        [Test]
        public void OpenGraphUseMetaDescriptionTest()
        {
            // TODO unit test for the property 'OpenGraphUseMetaDescription'
        }
        /// <summary>
        /// Test the property 'OpenGraphUseProductName'
        /// </summary>
        [Test]
        public void OpenGraphUseProductNameTest()
        {
            // TODO unit test for the property 'OpenGraphUseProductName'
        }
        /// <summary>
        /// Test the property 'OrderQuantityMaximum'
        /// </summary>
        [Test]
        public void OrderQuantityMaximumTest()
        {
            // TODO unit test for the property 'OrderQuantityMaximum'
        }
        /// <summary>
        /// Test the property 'OrderQuantityMinimum'
        /// </summary>
        [Test]
        public void OrderQuantityMinimumTest()
        {
            // TODO unit test for the property 'OrderQuantityMinimum'
        }
        /// <summary>
        /// Test the property 'PageTitle'
        /// </summary>
        [Test]
        public void PageTitleTest()
        {
            // TODO unit test for the property 'PageTitle'
        }
        /// <summary>
        /// Test the property 'PreorderMessage'
        /// </summary>
        [Test]
        public void PreorderMessageTest()
        {
            // TODO unit test for the property 'PreorderMessage'
        }
        /// <summary>
        /// Test the property 'PreorderReleaseDate'
        /// </summary>
        [Test]
        public void PreorderReleaseDateTest()
        {
            // TODO unit test for the property 'PreorderReleaseDate'
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
        /// Test the property 'PriceHiddenLabel'
        /// </summary>
        [Test]
        public void PriceHiddenLabelTest()
        {
            // TODO unit test for the property 'PriceHiddenLabel'
        }
        /// <summary>
        /// Test the property 'ProductTaxCode'
        /// </summary>
        [Test]
        public void ProductTaxCodeTest()
        {
            // TODO unit test for the property 'ProductTaxCode'
        }
        /// <summary>
        /// Test the property 'RelatedProducts'
        /// </summary>
        [Test]
        public void RelatedProductsTest()
        {
            // TODO unit test for the property 'RelatedProducts'
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
        /// Test the property 'ReviewsCount'
        /// </summary>
        [Test]
        public void ReviewsCountTest()
        {
            // TODO unit test for the property 'ReviewsCount'
        }
        /// <summary>
        /// Test the property 'ReviewsRatingSum'
        /// </summary>
        [Test]
        public void ReviewsRatingSumTest()
        {
            // TODO unit test for the property 'ReviewsRatingSum'
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
        /// Test the property 'SearchKeywords'
        /// </summary>
        [Test]
        public void SearchKeywordsTest()
        {
            // TODO unit test for the property 'SearchKeywords'
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
        /// Test the property 'SortOrder'
        /// </summary>
        [Test]
        public void SortOrderTest()
        {
            // TODO unit test for the property 'SortOrder'
        }
        /// <summary>
        /// Test the property 'TaxClassId'
        /// </summary>
        [Test]
        public void TaxClassIdTest()
        {
            // TODO unit test for the property 'TaxClassId'
        }
        /// <summary>
        /// Test the property 'TotalSold'
        /// </summary>
        [Test]
        public void TotalSoldTest()
        {
            // TODO unit test for the property 'TotalSold'
        }
        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Test]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
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
        /// Test the property 'Videos'
        /// </summary>
        [Test]
        public void VideosTest()
        {
            // TODO unit test for the property 'Videos'
        }
        /// <summary>
        /// Test the property 'ViewCount'
        /// </summary>
        [Test]
        public void ViewCountTest()
        {
            // TODO unit test for the property 'ViewCount'
        }
        /// <summary>
        /// Test the property 'Warranty'
        /// </summary>
        [Test]
        public void WarrantyTest()
        {
            // TODO unit test for the property 'Warranty'
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
