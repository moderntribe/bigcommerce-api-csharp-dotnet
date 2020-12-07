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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Catalog.Client.SwaggerDateConverter;

namespace Catalog.Model
{
    /// <summary>
    /// The model for a PUT to update a product.
    /// </summary>
    [DataContract]
        public partial class ProductPut :  IEquatable<ProductPut>, IValidatableObject
    {
        /// <summary>
        /// Availability of the product. Availability options are: &#x60;available&#x60; - the product can be purchased on the storefront; &#x60;disabled&#x60; - the product is listed in the storefront, but cannot be purchased; &#x60;preorder&#x60; - the product is listed for pre-orders. 
        /// </summary>
        /// <value>Availability of the product. Availability options are: &#x60;available&#x60; - the product can be purchased on the storefront; &#x60;disabled&#x60; - the product is listed in the storefront, but cannot be purchased; &#x60;preorder&#x60; - the product is listed for pre-orders. </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum AvailabilityEnum
        {
            /// <summary>
            /// Enum Available for value: available
            /// </summary>
            [EnumMember(Value = "available")]
            Available = 1,
            /// <summary>
            /// Enum Disabled for value: disabled
            /// </summary>
            [EnumMember(Value = "disabled")]
            Disabled = 2,
            /// <summary>
            /// Enum Preorder for value: preorder
            /// </summary>
            [EnumMember(Value = "preorder")]
            Preorder = 3        }
        /// <summary>
        /// Availability of the product. Availability options are: &#x60;available&#x60; - the product can be purchased on the storefront; &#x60;disabled&#x60; - the product is listed in the storefront, but cannot be purchased; &#x60;preorder&#x60; - the product is listed for pre-orders. 
        /// </summary>
        /// <value>Availability of the product. Availability options are: &#x60;available&#x60; - the product can be purchased on the storefront; &#x60;disabled&#x60; - the product is listed in the storefront, but cannot be purchased; &#x60;preorder&#x60; - the product is listed for pre-orders. </value>
        [DataMember(Name="availability", EmitDefaultValue=false)]
        public AvailabilityEnum? Availability { get; set; }
        /// <summary>
        /// The product condition. Will be shown on the product page if the &#x60;is_condition_shown&#x60; field&#x27;s value is &#x60;true&#x60;. Possible values: &#x60;New&#x60;, &#x60;Used&#x60;, &#x60;Refurbished&#x60;. 
        /// </summary>
        /// <value>The product condition. Will be shown on the product page if the &#x60;is_condition_shown&#x60; field&#x27;s value is &#x60;true&#x60;. Possible values: &#x60;New&#x60;, &#x60;Used&#x60;, &#x60;Refurbished&#x60;. </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ConditionEnum
        {
            /// <summary>
            /// Enum New for value: New
            /// </summary>
            [EnumMember(Value = "New")]
            New = 1,
            /// <summary>
            /// Enum Used for value: Used
            /// </summary>
            [EnumMember(Value = "Used")]
            Used = 2,
            /// <summary>
            /// Enum Refurbished for value: Refurbished
            /// </summary>
            [EnumMember(Value = "Refurbished")]
            Refurbished = 3        }
        /// <summary>
        /// The product condition. Will be shown on the product page if the &#x60;is_condition_shown&#x60; field&#x27;s value is &#x60;true&#x60;. Possible values: &#x60;New&#x60;, &#x60;Used&#x60;, &#x60;Refurbished&#x60;. 
        /// </summary>
        /// <value>The product condition. Will be shown on the product page if the &#x60;is_condition_shown&#x60; field&#x27;s value is &#x60;true&#x60;. Possible values: &#x60;New&#x60;, &#x60;Used&#x60;, &#x60;Refurbished&#x60;. </value>
        [DataMember(Name="condition", EmitDefaultValue=false)]
        public ConditionEnum? Condition { get; set; }
        /// <summary>
        /// Type of gift-wrapping options. Values: &#x60;any&#x60; - allow any gift-wrapping options in the store; &#x60;none&#x60; - disallow gift-wrapping on the product; &#x60;list&#x60; – provide a list of IDs in the &#x60;gift_wrapping_options_list&#x60; field. 
        /// </summary>
        /// <value>Type of gift-wrapping options. Values: &#x60;any&#x60; - allow any gift-wrapping options in the store; &#x60;none&#x60; - disallow gift-wrapping on the product; &#x60;list&#x60; – provide a list of IDs in the &#x60;gift_wrapping_options_list&#x60; field. </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum GiftWrappingOptionsTypeEnum
        {
            /// <summary>
            /// Enum Any for value: any
            /// </summary>
            [EnumMember(Value = "any")]
            Any = 1,
            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 2,
            /// <summary>
            /// Enum List for value: list
            /// </summary>
            [EnumMember(Value = "list")]
            List = 3        }
        /// <summary>
        /// Type of gift-wrapping options. Values: &#x60;any&#x60; - allow any gift-wrapping options in the store; &#x60;none&#x60; - disallow gift-wrapping on the product; &#x60;list&#x60; – provide a list of IDs in the &#x60;gift_wrapping_options_list&#x60; field. 
        /// </summary>
        /// <value>Type of gift-wrapping options. Values: &#x60;any&#x60; - allow any gift-wrapping options in the store; &#x60;none&#x60; - disallow gift-wrapping on the product; &#x60;list&#x60; – provide a list of IDs in the &#x60;gift_wrapping_options_list&#x60; field. </value>
        [DataMember(Name="gift_wrapping_options_type", EmitDefaultValue=false)]
        public GiftWrappingOptionsTypeEnum? GiftWrappingOptionsType { get; set; }
        /// <summary>
        /// The type of inventory tracking for the product. Values are: &#x60;none&#x60; - inventory levels will not be tracked; &#x60;product&#x60; - inventory levels will be tracked using the &#x60;inventory_level&#x60; and &#x60;inventory_warning_level&#x60; fields; &#x60;variant&#x60; - inventory levels will be tracked based on variants, which maintain their own warning levels and inventory levels. 
        /// </summary>
        /// <value>The type of inventory tracking for the product. Values are: &#x60;none&#x60; - inventory levels will not be tracked; &#x60;product&#x60; - inventory levels will be tracked using the &#x60;inventory_level&#x60; and &#x60;inventory_warning_level&#x60; fields; &#x60;variant&#x60; - inventory levels will be tracked based on variants, which maintain their own warning levels and inventory levels. </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum InventoryTrackingEnum
        {
            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 1,
            /// <summary>
            /// Enum Product for value: product
            /// </summary>
            [EnumMember(Value = "product")]
            Product = 2,
            /// <summary>
            /// Enum Variant for value: variant
            /// </summary>
            [EnumMember(Value = "variant")]
            Variant = 3        }
        /// <summary>
        /// The type of inventory tracking for the product. Values are: &#x60;none&#x60; - inventory levels will not be tracked; &#x60;product&#x60; - inventory levels will be tracked using the &#x60;inventory_level&#x60; and &#x60;inventory_warning_level&#x60; fields; &#x60;variant&#x60; - inventory levels will be tracked based on variants, which maintain their own warning levels and inventory levels. 
        /// </summary>
        /// <value>The type of inventory tracking for the product. Values are: &#x60;none&#x60; - inventory levels will not be tracked; &#x60;product&#x60; - inventory levels will be tracked using the &#x60;inventory_level&#x60; and &#x60;inventory_warning_level&#x60; fields; &#x60;variant&#x60; - inventory levels will be tracked based on variants, which maintain their own warning levels and inventory levels. </value>
        [DataMember(Name="inventory_tracking", EmitDefaultValue=false)]
        public InventoryTrackingEnum? InventoryTracking { get; set; }
        /// <summary>
        /// Type of product, defaults to &#x60;product&#x60;. 
        /// </summary>
        /// <value>Type of product, defaults to &#x60;product&#x60;. </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum OpenGraphTypeEnum
        {
            /// <summary>
            /// Enum Product for value: product
            /// </summary>
            [EnumMember(Value = "product")]
            Product = 1,
            /// <summary>
            /// Enum Album for value: album
            /// </summary>
            [EnumMember(Value = "album")]
            Album = 2,
            /// <summary>
            /// Enum Book for value: book
            /// </summary>
            [EnumMember(Value = "book")]
            Book = 3,
            /// <summary>
            /// Enum Drink for value: drink
            /// </summary>
            [EnumMember(Value = "drink")]
            Drink = 4,
            /// <summary>
            /// Enum Food for value: food
            /// </summary>
            [EnumMember(Value = "food")]
            Food = 5,
            /// <summary>
            /// Enum Game for value: game
            /// </summary>
            [EnumMember(Value = "game")]
            Game = 6,
            /// <summary>
            /// Enum Movie for value: movie
            /// </summary>
            [EnumMember(Value = "movie")]
            Movie = 7,
            /// <summary>
            /// Enum Song for value: song
            /// </summary>
            [EnumMember(Value = "song")]
            Song = 8,
            /// <summary>
            /// Enum Tvshow for value: tv_show
            /// </summary>
            [EnumMember(Value = "tv_show")]
            Tvshow = 9        }
        /// <summary>
        /// Type of product, defaults to &#x60;product&#x60;. 
        /// </summary>
        /// <value>Type of product, defaults to &#x60;product&#x60;. </value>
        [DataMember(Name="open_graph_type", EmitDefaultValue=false)]
        public OpenGraphTypeEnum? OpenGraphType { get; set; }
        /// <summary>
        /// The product type. One of: &#x60;physical&#x60; - a physical stock unit, &#x60;digital&#x60; - a digital download. 
        /// </summary>
        /// <value>The product type. One of: &#x60;physical&#x60; - a physical stock unit, &#x60;digital&#x60; - a digital download. </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Physical for value: physical
            /// </summary>
            [EnumMember(Value = "physical")]
            Physical = 1,
            /// <summary>
            /// Enum Digital for value: digital
            /// </summary>
            [EnumMember(Value = "digital")]
            Digital = 2        }
        /// <summary>
        /// The product type. One of: &#x60;physical&#x60; - a physical stock unit, &#x60;digital&#x60; - a digital download. 
        /// </summary>
        /// <value>The product type. One of: &#x60;physical&#x60; - a physical stock unit, &#x60;digital&#x60; - a digital download. </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductPut" /> class.
        /// </summary>
        /// <param name="availability">Availability of the product. Availability options are: &#x60;available&#x60; - the product can be purchased on the storefront; &#x60;disabled&#x60; - the product is listed in the storefront, but cannot be purchased; &#x60;preorder&#x60; - the product is listed for pre-orders. .</param>
        /// <param name="availabilityDescription">Availability text displayed on the checkout page, under the product title. Tells the customer how long it will normally take to ship this product, such as: &#x27;Usually ships in 24 hours.&#x27; .</param>
        /// <param name="binPickingNumber">The BIN picking number for the product. .</param>
        /// <param name="brandId">A product can be added to an existing brand during a product /PUT or /POST. .</param>
        /// <param name="brandNameOrBrandId">The brand can be created during a product PUT or POST request. If the brand already exists then the product will be added. If not the brand will be created and the product added. If using &#x60;brand_name&#x60; it performs a fuzzy match and adds the brand. eg. \&quot;Common Good\&quot; and \&quot;Common good\&quot; are the same. Brand name does not return as part of a product response. Only the &#x60;brand_id&#x60;..</param>
        /// <param name="bulkPricingRules">bulkPricingRules.</param>
        /// <param name="categories">An array of IDs for the categories to which this product belongs. When updating a product, if an array of categories is supplied, all product categories will be overwritten. Does not accept more than 1,000 ID values. .</param>
        /// <param name="condition">The product condition. Will be shown on the product page if the &#x60;is_condition_shown&#x60; field&#x27;s value is &#x60;true&#x60;. Possible values: &#x60;New&#x60;, &#x60;Used&#x60;, &#x60;Refurbished&#x60;. .</param>
        /// <param name="costPrice">The cost price of the product. Stored for reference only; it is not used or displayed anywhere on the store. .</param>
        /// <param name="customFields">customFields.</param>
        /// <param name="customUrl">customUrl.</param>
        /// <param name="depth">Depth of the product, which can be used when calculating shipping costs. .</param>
        /// <param name="description">The product description, which can include HTML formatting. .</param>
        /// <param name="fixedCostShippingPrice">A fixed shipping cost for the product. If defined, this value will be used during checkout instead of normal shipping-cost calculation. .</param>
        /// <param name="giftWrappingOptionsList">A list of gift-wrapping option IDs. .</param>
        /// <param name="giftWrappingOptionsType">Type of gift-wrapping options. Values: &#x60;any&#x60; - allow any gift-wrapping options in the store; &#x60;none&#x60; - disallow gift-wrapping on the product; &#x60;list&#x60; – provide a list of IDs in the &#x60;gift_wrapping_options_list&#x60; field. .</param>
        /// <param name="gtin">Global Trade Item Number.</param>
        /// <param name="height">Height of the product, which can be used when calculating shipping costs. .</param>
        /// <param name="images">images.</param>
        /// <param name="inventoryLevel">Current inventory level of the product. Simple inventory tracking must be enabled (See the &#x60;inventory_tracking&#x60; field) for this to take any effect. .</param>
        /// <param name="inventoryTracking">The type of inventory tracking for the product. Values are: &#x60;none&#x60; - inventory levels will not be tracked; &#x60;product&#x60; - inventory levels will be tracked using the &#x60;inventory_level&#x60; and &#x60;inventory_warning_level&#x60; fields; &#x60;variant&#x60; - inventory levels will be tracked based on variants, which maintain their own warning levels and inventory levels. .</param>
        /// <param name="inventoryWarningLevel">Inventory warning level for the product. When the product&#x27;s inventory level drops below the warning level, the store owner will be informed. Simple inventory tracking must be enabled (see the &#x60;inventory_tracking&#x60; field) for this to take any effect. .</param>
        /// <param name="isConditionShown">Flag used to determine whether the product condition is shown to the customer on the product page. .</param>
        /// <param name="isFeatured">Flag to determine whether the product should be included in the &#x60;featured products&#x60; panel when viewing the store. .</param>
        /// <param name="isFreeShipping">Flag used to indicate whether the product has free shipping. If &#x60;true&#x60;, the shipping cost for the product will be zero. .</param>
        /// <param name="isPreorderOnly">If set to true then on the preorder release date the preorder status will automatically be removed. If set to false, then on the release date the preorder status **will not** be removed. It will need to be changed manually either in the control panel or using the API. Using the API set &#x60;availability&#x60; to &#x60;available&#x60;. .</param>
        /// <param name="isPriceHidden">False by default, indicating that this product&#x27;s price should be shown on the product page. If set to &#x60;true&#x60;, the price is hidden. (NOTE: To successfully set &#x60;is_price_hidden&#x60; to &#x60;true&#x60;, the &#x60;availability&#x60; value must be &#x60;disabled&#x60;.) .</param>
        /// <param name="isVisible">Flag to determine whether the product should be displayed to customers browsing the store. If &#x60;true&#x60;, the product will be displayed. If &#x60;false&#x60;, the product will be hidden from view. .</param>
        /// <param name="layoutFile">The layout template file used to render this product category. This field is writable only for stores with a Blueprint theme applied. .</param>
        /// <param name="metaDescription">Custom meta description for the product page. If not defined, the store&#x27;s default meta description will be used. .</param>
        /// <param name="metaKeywords">Custom meta keywords for the product page. If not defined, the store&#x27;s default keywords will be used. .</param>
        /// <param name="mpn">Manufacturer Part Number.</param>
        /// <param name="name">The product name.  (required).</param>
        /// <param name="openGraphDescription">Description to use for the product, if not specified then the meta_description will be used instead. .</param>
        /// <param name="openGraphTitle">Title of the product, if not specified the product name will be used instead. .</param>
        /// <param name="openGraphType">Type of product, defaults to &#x60;product&#x60;. .</param>
        /// <param name="openGraphUseImage">Flag to determine if product image or open graph image is used. .</param>
        /// <param name="openGraphUseMetaDescription">Flag to determine if product description or open graph description is used. .</param>
        /// <param name="openGraphUseProductName">Flag to determine if product name or open graph name is used. .</param>
        /// <param name="orderQuantityMaximum">The maximum quantity an order can contain when purchasing the product. .</param>
        /// <param name="orderQuantityMinimum">The minimum quantity an order must contain, to be eligible to purchase this product. .</param>
        /// <param name="pageTitle">Custom title for the product page. If not defined, the product name will be used as the meta title. .</param>
        /// <param name="preorderMessage">Custom expected-date message to display on the product page. If undefined, the message defaults to the storewide setting. Can contain the &#x60;%%DATE%%&#x60; placeholder, which will be substituted for the release date. .</param>
        /// <param name="preorderReleaseDate">Pre-order release date. See the &#x60;availability&#x60; field for details on setting a product&#x27;s availability to accept pre-orders. .</param>
        /// <param name="price">The price of the product. The price should include or exclude tax, based on the store settings.  (required).</param>
        /// <param name="priceHiddenLabel">By default, an empty string. If &#x60;is_price_hidden&#x60; is &#x60;true&#x60;, the value of &#x60;price_hidden_label&#x60; is displayed instead of the price. (NOTE: To successfully set a non-empty string value with &#x60;is_price_hidden&#x60; set to &#x60;true&#x60;, the &#x60;availability&#x60; value must be &#x60;disabled&#x60;.) .</param>
        /// <param name="productTaxCode">Accepts AvaTax System Tax Codes, which identify products and services that fall into special sales-tax categories. By using these codes, merchants who subscribe to BigCommerce&#x27;s Avalara Premium integration can calculate sales taxes more accurately. Stores without Avalara Premium will ignore the code when calculating sales tax. Do not pass more than one code. The codes are case-sensitive. For details, please see Avalara&#x27;s documentation. .</param>
        /// <param name="relatedProducts">An array of IDs for the related products. .</param>
        /// <param name="retailPrice">The retail cost of the product. If entered, the retail cost price will be shown on the product page. .</param>
        /// <param name="reviewsCount">The number of times the product has been rated. .</param>
        /// <param name="reviewsRatingSum">The total rating for the product. .</param>
        /// <param name="salePrice">If entered, the sale price will be used instead of value in the price field when calculating the product&#x27;s cost. .</param>
        /// <param name="searchKeywords">A comma-separated list of keywords that can be used to locate the product when searching the store. .</param>
        /// <param name="sku">User defined product code/stock keeping unit (SKU). .</param>
        /// <param name="sortOrder">Priority to give this product when included in product lists on category pages and in search results. Lower integers will place the product closer to the top of the results. .</param>
        /// <param name="taxClassId">The ID of the tax class applied to the product. (NOTE: Value ignored if automatic tax is enabled.) .</param>
        /// <param name="totalSold">The total quantity of this product sold. .</param>
        /// <param name="type">The product type. One of: &#x60;physical&#x60; - a physical stock unit, &#x60;digital&#x60; - a digital download.  (required).</param>
        /// <param name="upc">The product UPC code, which is used in feeds for shopping comparison sites and external channel integrations. .</param>
        /// <param name="videos">videos.</param>
        /// <param name="viewCount">The number of times the product has been viewed. .</param>
        /// <param name="warranty">Warranty information displayed on the product page. Can include HTML formatting. .</param>
        /// <param name="weight">Weight of the product, which can be used when calculating shipping costs. This is based on the unit set on the store  (required).</param>
        /// <param name="width">Width of the product, which can be used when calculating shipping costs. .</param>
        /// <param name="variants">variants.</param>
        public ProductPut(AvailabilityEnum? availability = default(AvailabilityEnum?), string availabilityDescription = default(string), string binPickingNumber = default(string), int? brandId = default(int?), string brandNameOrBrandId = default(string), List<BulkPricingRuleFull1> bulkPricingRules = default(List<BulkPricingRuleFull1>), List<int?> categories = default(List<int?>), ConditionEnum? condition = default(ConditionEnum?), float? costPrice = default(float?), List<Object> customFields = default(List<Object>), CustomUrlCategory customUrl = default(CustomUrlCategory), float? depth = default(float?), string description = default(string), float? fixedCostShippingPrice = default(float?), List<int?> giftWrappingOptionsList = default(List<int?>), GiftWrappingOptionsTypeEnum? giftWrappingOptionsType = default(GiftWrappingOptionsTypeEnum?), string gtin = default(string), float? height = default(float?), List<Object> images = default(List<Object>), int? inventoryLevel = default(int?), InventoryTrackingEnum? inventoryTracking = default(InventoryTrackingEnum?), int? inventoryWarningLevel = default(int?), bool? isConditionShown = default(bool?), bool? isFeatured = default(bool?), bool? isFreeShipping = default(bool?), bool? isPreorderOnly = default(bool?), bool? isPriceHidden = default(bool?), bool? isVisible = default(bool?), string layoutFile = default(string), string metaDescription = default(string), List<string> metaKeywords = default(List<string>), string mpn = default(string), string name = default(string), string openGraphDescription = default(string), string openGraphTitle = default(string), OpenGraphTypeEnum? openGraphType = default(OpenGraphTypeEnum?), bool? openGraphUseImage = default(bool?), bool? openGraphUseMetaDescription = default(bool?), bool? openGraphUseProductName = default(bool?), int? orderQuantityMaximum = default(int?), int? orderQuantityMinimum = default(int?), string pageTitle = default(string), string preorderMessage = default(string), DateTime? preorderReleaseDate = default(DateTime?), float? price = default(float?), string priceHiddenLabel = default(string), string productTaxCode = default(string), List<int?> relatedProducts = default(List<int?>), float? retailPrice = default(float?), int? reviewsCount = default(int?), int? reviewsRatingSum = default(int?), float? salePrice = default(float?), string searchKeywords = default(string), string sku = default(string), int? sortOrder = default(int?), int? taxClassId = default(int?), int? totalSold = default(int?), TypeEnum type = default(TypeEnum), string upc = default(string), List<Object> videos = default(List<Object>), int? viewCount = default(int?), string warranty = default(string), float? weight = default(float?), float? width = default(float?), ProductVariantPutProduct1 variants = default(ProductVariantPutProduct1))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for ProductPut and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "price" is required (not null)
            if (price == null)
            {
                throw new InvalidDataException("price is a required property for ProductPut and cannot be null");
            }
            else
            {
                this.Price = price;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for ProductPut and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            // to ensure "weight" is required (not null)
            if (weight == null)
            {
                throw new InvalidDataException("weight is a required property for ProductPut and cannot be null");
            }
            else
            {
                this.Weight = weight;
            }
            this.Availability = availability;
            this.AvailabilityDescription = availabilityDescription;
            this.BinPickingNumber = binPickingNumber;
            this.BrandId = brandId;
            this.BrandNameOrBrandId = brandNameOrBrandId;
            this.BulkPricingRules = bulkPricingRules;
            this.Categories = categories;
            this.Condition = condition;
            this.CostPrice = costPrice;
            this.CustomFields = customFields;
            this.CustomUrl = customUrl;
            this.Depth = depth;
            this.Description = description;
            this.FixedCostShippingPrice = fixedCostShippingPrice;
            this.GiftWrappingOptionsList = giftWrappingOptionsList;
            this.GiftWrappingOptionsType = giftWrappingOptionsType;
            this.Gtin = gtin;
            this.Height = height;
            this.Images = images;
            this.InventoryLevel = inventoryLevel;
            this.InventoryTracking = inventoryTracking;
            this.InventoryWarningLevel = inventoryWarningLevel;
            this.IsConditionShown = isConditionShown;
            this.IsFeatured = isFeatured;
            this.IsFreeShipping = isFreeShipping;
            this.IsPreorderOnly = isPreorderOnly;
            this.IsPriceHidden = isPriceHidden;
            this.IsVisible = isVisible;
            this.LayoutFile = layoutFile;
            this.MetaDescription = metaDescription;
            this.MetaKeywords = metaKeywords;
            this.Mpn = mpn;
            this.OpenGraphDescription = openGraphDescription;
            this.OpenGraphTitle = openGraphTitle;
            this.OpenGraphType = openGraphType;
            this.OpenGraphUseImage = openGraphUseImage;
            this.OpenGraphUseMetaDescription = openGraphUseMetaDescription;
            this.OpenGraphUseProductName = openGraphUseProductName;
            this.OrderQuantityMaximum = orderQuantityMaximum;
            this.OrderQuantityMinimum = orderQuantityMinimum;
            this.PageTitle = pageTitle;
            this.PreorderMessage = preorderMessage;
            this.PreorderReleaseDate = preorderReleaseDate;
            this.PriceHiddenLabel = priceHiddenLabel;
            this.ProductTaxCode = productTaxCode;
            this.RelatedProducts = relatedProducts;
            this.RetailPrice = retailPrice;
            this.ReviewsCount = reviewsCount;
            this.ReviewsRatingSum = reviewsRatingSum;
            this.SalePrice = salePrice;
            this.SearchKeywords = searchKeywords;
            this.Sku = sku;
            this.SortOrder = sortOrder;
            this.TaxClassId = taxClassId;
            this.TotalSold = totalSold;
            this.Upc = upc;
            this.Videos = videos;
            this.ViewCount = viewCount;
            this.Warranty = warranty;
            this.Width = width;
            this.Variants = variants;
        }
        

        /// <summary>
        /// Availability text displayed on the checkout page, under the product title. Tells the customer how long it will normally take to ship this product, such as: &#x27;Usually ships in 24 hours.&#x27; 
        /// </summary>
        /// <value>Availability text displayed on the checkout page, under the product title. Tells the customer how long it will normally take to ship this product, such as: &#x27;Usually ships in 24 hours.&#x27; </value>
        [DataMember(Name="availability_description", EmitDefaultValue=false)]
        public string AvailabilityDescription { get; set; }

        /// <summary>
        /// The BIN picking number for the product. 
        /// </summary>
        /// <value>The BIN picking number for the product. </value>
        [DataMember(Name="bin_picking_number", EmitDefaultValue=false)]
        public string BinPickingNumber { get; set; }

        /// <summary>
        /// A product can be added to an existing brand during a product /PUT or /POST. 
        /// </summary>
        /// <value>A product can be added to an existing brand during a product /PUT or /POST. </value>
        [DataMember(Name="brand_id", EmitDefaultValue=false)]
        public int? BrandId { get; set; }

        /// <summary>
        /// The brand can be created during a product PUT or POST request. If the brand already exists then the product will be added. If not the brand will be created and the product added. If using &#x60;brand_name&#x60; it performs a fuzzy match and adds the brand. eg. \&quot;Common Good\&quot; and \&quot;Common good\&quot; are the same. Brand name does not return as part of a product response. Only the &#x60;brand_id&#x60;.
        /// </summary>
        /// <value>The brand can be created during a product PUT or POST request. If the brand already exists then the product will be added. If not the brand will be created and the product added. If using &#x60;brand_name&#x60; it performs a fuzzy match and adds the brand. eg. \&quot;Common Good\&quot; and \&quot;Common good\&quot; are the same. Brand name does not return as part of a product response. Only the &#x60;brand_id&#x60;.</value>
        [DataMember(Name="brand_name or brand_id", EmitDefaultValue=false)]
        public string BrandNameOrBrandId { get; set; }

        /// <summary>
        /// Gets or Sets BulkPricingRules
        /// </summary>
        [DataMember(Name="bulk_pricing_rules", EmitDefaultValue=false)]
        public List<BulkPricingRuleFull1> BulkPricingRules { get; set; }

        /// <summary>
        /// An array of IDs for the categories to which this product belongs. When updating a product, if an array of categories is supplied, all product categories will be overwritten. Does not accept more than 1,000 ID values. 
        /// </summary>
        /// <value>An array of IDs for the categories to which this product belongs. When updating a product, if an array of categories is supplied, all product categories will be overwritten. Does not accept more than 1,000 ID values. </value>
        [DataMember(Name="categories", EmitDefaultValue=false)]
        public List<int?> Categories { get; set; }


        /// <summary>
        /// The cost price of the product. Stored for reference only; it is not used or displayed anywhere on the store. 
        /// </summary>
        /// <value>The cost price of the product. Stored for reference only; it is not used or displayed anywhere on the store. </value>
        [DataMember(Name="cost_price", EmitDefaultValue=false)]
        public float? CostPrice { get; set; }

        /// <summary>
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name="custom_fields", EmitDefaultValue=false)]
        public List<Object> CustomFields { get; set; }

        /// <summary>
        /// Gets or Sets CustomUrl
        /// </summary>
        [DataMember(Name="custom_url", EmitDefaultValue=false)]
        public CustomUrlCategory CustomUrl { get; set; }

        /// <summary>
        /// Depth of the product, which can be used when calculating shipping costs. 
        /// </summary>
        /// <value>Depth of the product, which can be used when calculating shipping costs. </value>
        [DataMember(Name="depth", EmitDefaultValue=false)]
        public float? Depth { get; set; }

        /// <summary>
        /// The product description, which can include HTML formatting. 
        /// </summary>
        /// <value>The product description, which can include HTML formatting. </value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// A fixed shipping cost for the product. If defined, this value will be used during checkout instead of normal shipping-cost calculation. 
        /// </summary>
        /// <value>A fixed shipping cost for the product. If defined, this value will be used during checkout instead of normal shipping-cost calculation. </value>
        [DataMember(Name="fixed_cost_shipping_price", EmitDefaultValue=false)]
        public float? FixedCostShippingPrice { get; set; }

        /// <summary>
        /// A list of gift-wrapping option IDs. 
        /// </summary>
        /// <value>A list of gift-wrapping option IDs. </value>
        [DataMember(Name="gift_wrapping_options_list", EmitDefaultValue=false)]
        public List<int?> GiftWrappingOptionsList { get; set; }


        /// <summary>
        /// Global Trade Item Number
        /// </summary>
        /// <value>Global Trade Item Number</value>
        [DataMember(Name="gtin", EmitDefaultValue=false)]
        public string Gtin { get; set; }

        /// <summary>
        /// Height of the product, which can be used when calculating shipping costs. 
        /// </summary>
        /// <value>Height of the product, which can be used when calculating shipping costs. </value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public float? Height { get; set; }

        /// <summary>
        /// Gets or Sets Images
        /// </summary>
        [DataMember(Name="images", EmitDefaultValue=false)]
        public List<Object> Images { get; set; }

        /// <summary>
        /// Current inventory level of the product. Simple inventory tracking must be enabled (See the &#x60;inventory_tracking&#x60; field) for this to take any effect. 
        /// </summary>
        /// <value>Current inventory level of the product. Simple inventory tracking must be enabled (See the &#x60;inventory_tracking&#x60; field) for this to take any effect. </value>
        [DataMember(Name="inventory_level", EmitDefaultValue=false)]
        public int? InventoryLevel { get; set; }


        /// <summary>
        /// Inventory warning level for the product. When the product&#x27;s inventory level drops below the warning level, the store owner will be informed. Simple inventory tracking must be enabled (see the &#x60;inventory_tracking&#x60; field) for this to take any effect. 
        /// </summary>
        /// <value>Inventory warning level for the product. When the product&#x27;s inventory level drops below the warning level, the store owner will be informed. Simple inventory tracking must be enabled (see the &#x60;inventory_tracking&#x60; field) for this to take any effect. </value>
        [DataMember(Name="inventory_warning_level", EmitDefaultValue=false)]
        public int? InventoryWarningLevel { get; set; }

        /// <summary>
        /// Flag used to determine whether the product condition is shown to the customer on the product page. 
        /// </summary>
        /// <value>Flag used to determine whether the product condition is shown to the customer on the product page. </value>
        [DataMember(Name="is_condition_shown", EmitDefaultValue=false)]
        public bool? IsConditionShown { get; set; }

        /// <summary>
        /// Flag to determine whether the product should be included in the &#x60;featured products&#x60; panel when viewing the store. 
        /// </summary>
        /// <value>Flag to determine whether the product should be included in the &#x60;featured products&#x60; panel when viewing the store. </value>
        [DataMember(Name="is_featured", EmitDefaultValue=false)]
        public bool? IsFeatured { get; set; }

        /// <summary>
        /// Flag used to indicate whether the product has free shipping. If &#x60;true&#x60;, the shipping cost for the product will be zero. 
        /// </summary>
        /// <value>Flag used to indicate whether the product has free shipping. If &#x60;true&#x60;, the shipping cost for the product will be zero. </value>
        [DataMember(Name="is_free_shipping", EmitDefaultValue=false)]
        public bool? IsFreeShipping { get; set; }

        /// <summary>
        /// If set to true then on the preorder release date the preorder status will automatically be removed. If set to false, then on the release date the preorder status **will not** be removed. It will need to be changed manually either in the control panel or using the API. Using the API set &#x60;availability&#x60; to &#x60;available&#x60;. 
        /// </summary>
        /// <value>If set to true then on the preorder release date the preorder status will automatically be removed. If set to false, then on the release date the preorder status **will not** be removed. It will need to be changed manually either in the control panel or using the API. Using the API set &#x60;availability&#x60; to &#x60;available&#x60;. </value>
        [DataMember(Name="is_preorder_only", EmitDefaultValue=false)]
        public bool? IsPreorderOnly { get; set; }

        /// <summary>
        /// False by default, indicating that this product&#x27;s price should be shown on the product page. If set to &#x60;true&#x60;, the price is hidden. (NOTE: To successfully set &#x60;is_price_hidden&#x60; to &#x60;true&#x60;, the &#x60;availability&#x60; value must be &#x60;disabled&#x60;.) 
        /// </summary>
        /// <value>False by default, indicating that this product&#x27;s price should be shown on the product page. If set to &#x60;true&#x60;, the price is hidden. (NOTE: To successfully set &#x60;is_price_hidden&#x60; to &#x60;true&#x60;, the &#x60;availability&#x60; value must be &#x60;disabled&#x60;.) </value>
        [DataMember(Name="is_price_hidden", EmitDefaultValue=false)]
        public bool? IsPriceHidden { get; set; }

        /// <summary>
        /// Flag to determine whether the product should be displayed to customers browsing the store. If &#x60;true&#x60;, the product will be displayed. If &#x60;false&#x60;, the product will be hidden from view. 
        /// </summary>
        /// <value>Flag to determine whether the product should be displayed to customers browsing the store. If &#x60;true&#x60;, the product will be displayed. If &#x60;false&#x60;, the product will be hidden from view. </value>
        [DataMember(Name="is_visible", EmitDefaultValue=false)]
        public bool? IsVisible { get; set; }

        /// <summary>
        /// The layout template file used to render this product category. This field is writable only for stores with a Blueprint theme applied. 
        /// </summary>
        /// <value>The layout template file used to render this product category. This field is writable only for stores with a Blueprint theme applied. </value>
        [DataMember(Name="layout_file", EmitDefaultValue=false)]
        public string LayoutFile { get; set; }

        /// <summary>
        /// Custom meta description for the product page. If not defined, the store&#x27;s default meta description will be used. 
        /// </summary>
        /// <value>Custom meta description for the product page. If not defined, the store&#x27;s default meta description will be used. </value>
        [DataMember(Name="meta_description", EmitDefaultValue=false)]
        public string MetaDescription { get; set; }

        /// <summary>
        /// Custom meta keywords for the product page. If not defined, the store&#x27;s default keywords will be used. 
        /// </summary>
        /// <value>Custom meta keywords for the product page. If not defined, the store&#x27;s default keywords will be used. </value>
        [DataMember(Name="meta_keywords", EmitDefaultValue=false)]
        public List<string> MetaKeywords { get; set; }

        /// <summary>
        /// Manufacturer Part Number
        /// </summary>
        /// <value>Manufacturer Part Number</value>
        [DataMember(Name="mpn", EmitDefaultValue=false)]
        public string Mpn { get; set; }

        /// <summary>
        /// The product name. 
        /// </summary>
        /// <value>The product name. </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Description to use for the product, if not specified then the meta_description will be used instead. 
        /// </summary>
        /// <value>Description to use for the product, if not specified then the meta_description will be used instead. </value>
        [DataMember(Name="open_graph_description", EmitDefaultValue=false)]
        public string OpenGraphDescription { get; set; }

        /// <summary>
        /// Title of the product, if not specified the product name will be used instead. 
        /// </summary>
        /// <value>Title of the product, if not specified the product name will be used instead. </value>
        [DataMember(Name="open_graph_title", EmitDefaultValue=false)]
        public string OpenGraphTitle { get; set; }


        /// <summary>
        /// Flag to determine if product image or open graph image is used. 
        /// </summary>
        /// <value>Flag to determine if product image or open graph image is used. </value>
        [DataMember(Name="open_graph_use_image", EmitDefaultValue=false)]
        public bool? OpenGraphUseImage { get; set; }

        /// <summary>
        /// Flag to determine if product description or open graph description is used. 
        /// </summary>
        /// <value>Flag to determine if product description or open graph description is used. </value>
        [DataMember(Name="open_graph_use_meta_description", EmitDefaultValue=false)]
        public bool? OpenGraphUseMetaDescription { get; set; }

        /// <summary>
        /// Flag to determine if product name or open graph name is used. 
        /// </summary>
        /// <value>Flag to determine if product name or open graph name is used. </value>
        [DataMember(Name="open_graph_use_product_name", EmitDefaultValue=false)]
        public bool? OpenGraphUseProductName { get; set; }

        /// <summary>
        /// The maximum quantity an order can contain when purchasing the product. 
        /// </summary>
        /// <value>The maximum quantity an order can contain when purchasing the product. </value>
        [DataMember(Name="order_quantity_maximum", EmitDefaultValue=false)]
        public int? OrderQuantityMaximum { get; set; }

        /// <summary>
        /// The minimum quantity an order must contain, to be eligible to purchase this product. 
        /// </summary>
        /// <value>The minimum quantity an order must contain, to be eligible to purchase this product. </value>
        [DataMember(Name="order_quantity_minimum", EmitDefaultValue=false)]
        public int? OrderQuantityMinimum { get; set; }

        /// <summary>
        /// Custom title for the product page. If not defined, the product name will be used as the meta title. 
        /// </summary>
        /// <value>Custom title for the product page. If not defined, the product name will be used as the meta title. </value>
        [DataMember(Name="page_title", EmitDefaultValue=false)]
        public string PageTitle { get; set; }

        /// <summary>
        /// Custom expected-date message to display on the product page. If undefined, the message defaults to the storewide setting. Can contain the &#x60;%%DATE%%&#x60; placeholder, which will be substituted for the release date. 
        /// </summary>
        /// <value>Custom expected-date message to display on the product page. If undefined, the message defaults to the storewide setting. Can contain the &#x60;%%DATE%%&#x60; placeholder, which will be substituted for the release date. </value>
        [DataMember(Name="preorder_message", EmitDefaultValue=false)]
        public string PreorderMessage { get; set; }

        /// <summary>
        /// Pre-order release date. See the &#x60;availability&#x60; field for details on setting a product&#x27;s availability to accept pre-orders. 
        /// </summary>
        /// <value>Pre-order release date. See the &#x60;availability&#x60; field for details on setting a product&#x27;s availability to accept pre-orders. </value>
        [DataMember(Name="preorder_release_date", EmitDefaultValue=false)]
        public DateTime? PreorderReleaseDate { get; set; }

        /// <summary>
        /// The price of the product. The price should include or exclude tax, based on the store settings. 
        /// </summary>
        /// <value>The price of the product. The price should include or exclude tax, based on the store settings. </value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public float? Price { get; set; }

        /// <summary>
        /// By default, an empty string. If &#x60;is_price_hidden&#x60; is &#x60;true&#x60;, the value of &#x60;price_hidden_label&#x60; is displayed instead of the price. (NOTE: To successfully set a non-empty string value with &#x60;is_price_hidden&#x60; set to &#x60;true&#x60;, the &#x60;availability&#x60; value must be &#x60;disabled&#x60;.) 
        /// </summary>
        /// <value>By default, an empty string. If &#x60;is_price_hidden&#x60; is &#x60;true&#x60;, the value of &#x60;price_hidden_label&#x60; is displayed instead of the price. (NOTE: To successfully set a non-empty string value with &#x60;is_price_hidden&#x60; set to &#x60;true&#x60;, the &#x60;availability&#x60; value must be &#x60;disabled&#x60;.) </value>
        [DataMember(Name="price_hidden_label", EmitDefaultValue=false)]
        public string PriceHiddenLabel { get; set; }

        /// <summary>
        /// Accepts AvaTax System Tax Codes, which identify products and services that fall into special sales-tax categories. By using these codes, merchants who subscribe to BigCommerce&#x27;s Avalara Premium integration can calculate sales taxes more accurately. Stores without Avalara Premium will ignore the code when calculating sales tax. Do not pass more than one code. The codes are case-sensitive. For details, please see Avalara&#x27;s documentation. 
        /// </summary>
        /// <value>Accepts AvaTax System Tax Codes, which identify products and services that fall into special sales-tax categories. By using these codes, merchants who subscribe to BigCommerce&#x27;s Avalara Premium integration can calculate sales taxes more accurately. Stores without Avalara Premium will ignore the code when calculating sales tax. Do not pass more than one code. The codes are case-sensitive. For details, please see Avalara&#x27;s documentation. </value>
        [DataMember(Name="product_tax_code", EmitDefaultValue=false)]
        public string ProductTaxCode { get; set; }

        /// <summary>
        /// An array of IDs for the related products. 
        /// </summary>
        /// <value>An array of IDs for the related products. </value>
        [DataMember(Name="related_products", EmitDefaultValue=false)]
        public List<int?> RelatedProducts { get; set; }

        /// <summary>
        /// The retail cost of the product. If entered, the retail cost price will be shown on the product page. 
        /// </summary>
        /// <value>The retail cost of the product. If entered, the retail cost price will be shown on the product page. </value>
        [DataMember(Name="retail_price", EmitDefaultValue=false)]
        public float? RetailPrice { get; set; }

        /// <summary>
        /// The number of times the product has been rated. 
        /// </summary>
        /// <value>The number of times the product has been rated. </value>
        [DataMember(Name="reviews_count", EmitDefaultValue=false)]
        public int? ReviewsCount { get; set; }

        /// <summary>
        /// The total rating for the product. 
        /// </summary>
        /// <value>The total rating for the product. </value>
        [DataMember(Name="reviews_rating_sum", EmitDefaultValue=false)]
        public int? ReviewsRatingSum { get; set; }

        /// <summary>
        /// If entered, the sale price will be used instead of value in the price field when calculating the product&#x27;s cost. 
        /// </summary>
        /// <value>If entered, the sale price will be used instead of value in the price field when calculating the product&#x27;s cost. </value>
        [DataMember(Name="sale_price", EmitDefaultValue=false)]
        public float? SalePrice { get; set; }

        /// <summary>
        /// A comma-separated list of keywords that can be used to locate the product when searching the store. 
        /// </summary>
        /// <value>A comma-separated list of keywords that can be used to locate the product when searching the store. </value>
        [DataMember(Name="search_keywords", EmitDefaultValue=false)]
        public string SearchKeywords { get; set; }

        /// <summary>
        /// User defined product code/stock keeping unit (SKU). 
        /// </summary>
        /// <value>User defined product code/stock keeping unit (SKU). </value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// Priority to give this product when included in product lists on category pages and in search results. Lower integers will place the product closer to the top of the results. 
        /// </summary>
        /// <value>Priority to give this product when included in product lists on category pages and in search results. Lower integers will place the product closer to the top of the results. </value>
        [DataMember(Name="sort_order", EmitDefaultValue=false)]
        public int? SortOrder { get; set; }

        /// <summary>
        /// The ID of the tax class applied to the product. (NOTE: Value ignored if automatic tax is enabled.) 
        /// </summary>
        /// <value>The ID of the tax class applied to the product. (NOTE: Value ignored if automatic tax is enabled.) </value>
        [DataMember(Name="tax_class_id", EmitDefaultValue=false)]
        public int? TaxClassId { get; set; }

        /// <summary>
        /// The total quantity of this product sold. 
        /// </summary>
        /// <value>The total quantity of this product sold. </value>
        [DataMember(Name="total_sold", EmitDefaultValue=false)]
        public int? TotalSold { get; set; }


        /// <summary>
        /// The product UPC code, which is used in feeds for shopping comparison sites and external channel integrations. 
        /// </summary>
        /// <value>The product UPC code, which is used in feeds for shopping comparison sites and external channel integrations. </value>
        [DataMember(Name="upc", EmitDefaultValue=false)]
        public string Upc { get; set; }

        /// <summary>
        /// Gets or Sets Videos
        /// </summary>
        [DataMember(Name="videos", EmitDefaultValue=false)]
        public List<Object> Videos { get; set; }

        /// <summary>
        /// The number of times the product has been viewed. 
        /// </summary>
        /// <value>The number of times the product has been viewed. </value>
        [DataMember(Name="view_count", EmitDefaultValue=false)]
        public int? ViewCount { get; set; }

        /// <summary>
        /// Warranty information displayed on the product page. Can include HTML formatting. 
        /// </summary>
        /// <value>Warranty information displayed on the product page. Can include HTML formatting. </value>
        [DataMember(Name="warranty", EmitDefaultValue=false)]
        public string Warranty { get; set; }

        /// <summary>
        /// Weight of the product, which can be used when calculating shipping costs. This is based on the unit set on the store 
        /// </summary>
        /// <value>Weight of the product, which can be used when calculating shipping costs. This is based on the unit set on the store </value>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public float? Weight { get; set; }

        /// <summary>
        /// Width of the product, which can be used when calculating shipping costs. 
        /// </summary>
        /// <value>Width of the product, which can be used when calculating shipping costs. </value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public float? Width { get; set; }

        /// <summary>
        /// Gets or Sets Variants
        /// </summary>
        [DataMember(Name="variants", EmitDefaultValue=false)]
        public ProductVariantPutProduct1 Variants { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductPut {\n");
            sb.Append("  Availability: ").Append(Availability).Append("\n");
            sb.Append("  AvailabilityDescription: ").Append(AvailabilityDescription).Append("\n");
            sb.Append("  BinPickingNumber: ").Append(BinPickingNumber).Append("\n");
            sb.Append("  BrandId: ").Append(BrandId).Append("\n");
            sb.Append("  BrandNameOrBrandId: ").Append(BrandNameOrBrandId).Append("\n");
            sb.Append("  BulkPricingRules: ").Append(BulkPricingRules).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Condition: ").Append(Condition).Append("\n");
            sb.Append("  CostPrice: ").Append(CostPrice).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
            sb.Append("  CustomUrl: ").Append(CustomUrl).Append("\n");
            sb.Append("  Depth: ").Append(Depth).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  FixedCostShippingPrice: ").Append(FixedCostShippingPrice).Append("\n");
            sb.Append("  GiftWrappingOptionsList: ").Append(GiftWrappingOptionsList).Append("\n");
            sb.Append("  GiftWrappingOptionsType: ").Append(GiftWrappingOptionsType).Append("\n");
            sb.Append("  Gtin: ").Append(Gtin).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Images: ").Append(Images).Append("\n");
            sb.Append("  InventoryLevel: ").Append(InventoryLevel).Append("\n");
            sb.Append("  InventoryTracking: ").Append(InventoryTracking).Append("\n");
            sb.Append("  InventoryWarningLevel: ").Append(InventoryWarningLevel).Append("\n");
            sb.Append("  IsConditionShown: ").Append(IsConditionShown).Append("\n");
            sb.Append("  IsFeatured: ").Append(IsFeatured).Append("\n");
            sb.Append("  IsFreeShipping: ").Append(IsFreeShipping).Append("\n");
            sb.Append("  IsPreorderOnly: ").Append(IsPreorderOnly).Append("\n");
            sb.Append("  IsPriceHidden: ").Append(IsPriceHidden).Append("\n");
            sb.Append("  IsVisible: ").Append(IsVisible).Append("\n");
            sb.Append("  LayoutFile: ").Append(LayoutFile).Append("\n");
            sb.Append("  MetaDescription: ").Append(MetaDescription).Append("\n");
            sb.Append("  MetaKeywords: ").Append(MetaKeywords).Append("\n");
            sb.Append("  Mpn: ").Append(Mpn).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OpenGraphDescription: ").Append(OpenGraphDescription).Append("\n");
            sb.Append("  OpenGraphTitle: ").Append(OpenGraphTitle).Append("\n");
            sb.Append("  OpenGraphType: ").Append(OpenGraphType).Append("\n");
            sb.Append("  OpenGraphUseImage: ").Append(OpenGraphUseImage).Append("\n");
            sb.Append("  OpenGraphUseMetaDescription: ").Append(OpenGraphUseMetaDescription).Append("\n");
            sb.Append("  OpenGraphUseProductName: ").Append(OpenGraphUseProductName).Append("\n");
            sb.Append("  OrderQuantityMaximum: ").Append(OrderQuantityMaximum).Append("\n");
            sb.Append("  OrderQuantityMinimum: ").Append(OrderQuantityMinimum).Append("\n");
            sb.Append("  PageTitle: ").Append(PageTitle).Append("\n");
            sb.Append("  PreorderMessage: ").Append(PreorderMessage).Append("\n");
            sb.Append("  PreorderReleaseDate: ").Append(PreorderReleaseDate).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  PriceHiddenLabel: ").Append(PriceHiddenLabel).Append("\n");
            sb.Append("  ProductTaxCode: ").Append(ProductTaxCode).Append("\n");
            sb.Append("  RelatedProducts: ").Append(RelatedProducts).Append("\n");
            sb.Append("  RetailPrice: ").Append(RetailPrice).Append("\n");
            sb.Append("  ReviewsCount: ").Append(ReviewsCount).Append("\n");
            sb.Append("  ReviewsRatingSum: ").Append(ReviewsRatingSum).Append("\n");
            sb.Append("  SalePrice: ").Append(SalePrice).Append("\n");
            sb.Append("  SearchKeywords: ").Append(SearchKeywords).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  TaxClassId: ").Append(TaxClassId).Append("\n");
            sb.Append("  TotalSold: ").Append(TotalSold).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Upc: ").Append(Upc).Append("\n");
            sb.Append("  Videos: ").Append(Videos).Append("\n");
            sb.Append("  ViewCount: ").Append(ViewCount).Append("\n");
            sb.Append("  Warranty: ").Append(Warranty).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Variants: ").Append(Variants).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProductPut);
        }

        /// <summary>
        /// Returns true if ProductPut instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductPut to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductPut input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Availability == input.Availability ||
                    (this.Availability != null &&
                    this.Availability.Equals(input.Availability))
                ) && 
                (
                    this.AvailabilityDescription == input.AvailabilityDescription ||
                    (this.AvailabilityDescription != null &&
                    this.AvailabilityDescription.Equals(input.AvailabilityDescription))
                ) && 
                (
                    this.BinPickingNumber == input.BinPickingNumber ||
                    (this.BinPickingNumber != null &&
                    this.BinPickingNumber.Equals(input.BinPickingNumber))
                ) && 
                (
                    this.BrandId == input.BrandId ||
                    (this.BrandId != null &&
                    this.BrandId.Equals(input.BrandId))
                ) && 
                (
                    this.BrandNameOrBrandId == input.BrandNameOrBrandId ||
                    (this.BrandNameOrBrandId != null &&
                    this.BrandNameOrBrandId.Equals(input.BrandNameOrBrandId))
                ) && 
                (
                    this.BulkPricingRules == input.BulkPricingRules ||
                    this.BulkPricingRules != null &&
                    input.BulkPricingRules != null &&
                    this.BulkPricingRules.SequenceEqual(input.BulkPricingRules)
                ) && 
                (
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.Condition == input.Condition ||
                    (this.Condition != null &&
                    this.Condition.Equals(input.Condition))
                ) && 
                (
                    this.CostPrice == input.CostPrice ||
                    (this.CostPrice != null &&
                    this.CostPrice.Equals(input.CostPrice))
                ) && 
                (
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    input.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
                ) && 
                (
                    this.CustomUrl == input.CustomUrl ||
                    (this.CustomUrl != null &&
                    this.CustomUrl.Equals(input.CustomUrl))
                ) && 
                (
                    this.Depth == input.Depth ||
                    (this.Depth != null &&
                    this.Depth.Equals(input.Depth))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.FixedCostShippingPrice == input.FixedCostShippingPrice ||
                    (this.FixedCostShippingPrice != null &&
                    this.FixedCostShippingPrice.Equals(input.FixedCostShippingPrice))
                ) && 
                (
                    this.GiftWrappingOptionsList == input.GiftWrappingOptionsList ||
                    this.GiftWrappingOptionsList != null &&
                    input.GiftWrappingOptionsList != null &&
                    this.GiftWrappingOptionsList.SequenceEqual(input.GiftWrappingOptionsList)
                ) && 
                (
                    this.GiftWrappingOptionsType == input.GiftWrappingOptionsType ||
                    (this.GiftWrappingOptionsType != null &&
                    this.GiftWrappingOptionsType.Equals(input.GiftWrappingOptionsType))
                ) && 
                (
                    this.Gtin == input.Gtin ||
                    (this.Gtin != null &&
                    this.Gtin.Equals(input.Gtin))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.Images == input.Images ||
                    this.Images != null &&
                    input.Images != null &&
                    this.Images.SequenceEqual(input.Images)
                ) && 
                (
                    this.InventoryLevel == input.InventoryLevel ||
                    (this.InventoryLevel != null &&
                    this.InventoryLevel.Equals(input.InventoryLevel))
                ) && 
                (
                    this.InventoryTracking == input.InventoryTracking ||
                    (this.InventoryTracking != null &&
                    this.InventoryTracking.Equals(input.InventoryTracking))
                ) && 
                (
                    this.InventoryWarningLevel == input.InventoryWarningLevel ||
                    (this.InventoryWarningLevel != null &&
                    this.InventoryWarningLevel.Equals(input.InventoryWarningLevel))
                ) && 
                (
                    this.IsConditionShown == input.IsConditionShown ||
                    (this.IsConditionShown != null &&
                    this.IsConditionShown.Equals(input.IsConditionShown))
                ) && 
                (
                    this.IsFeatured == input.IsFeatured ||
                    (this.IsFeatured != null &&
                    this.IsFeatured.Equals(input.IsFeatured))
                ) && 
                (
                    this.IsFreeShipping == input.IsFreeShipping ||
                    (this.IsFreeShipping != null &&
                    this.IsFreeShipping.Equals(input.IsFreeShipping))
                ) && 
                (
                    this.IsPreorderOnly == input.IsPreorderOnly ||
                    (this.IsPreorderOnly != null &&
                    this.IsPreorderOnly.Equals(input.IsPreorderOnly))
                ) && 
                (
                    this.IsPriceHidden == input.IsPriceHidden ||
                    (this.IsPriceHidden != null &&
                    this.IsPriceHidden.Equals(input.IsPriceHidden))
                ) && 
                (
                    this.IsVisible == input.IsVisible ||
                    (this.IsVisible != null &&
                    this.IsVisible.Equals(input.IsVisible))
                ) && 
                (
                    this.LayoutFile == input.LayoutFile ||
                    (this.LayoutFile != null &&
                    this.LayoutFile.Equals(input.LayoutFile))
                ) && 
                (
                    this.MetaDescription == input.MetaDescription ||
                    (this.MetaDescription != null &&
                    this.MetaDescription.Equals(input.MetaDescription))
                ) && 
                (
                    this.MetaKeywords == input.MetaKeywords ||
                    this.MetaKeywords != null &&
                    input.MetaKeywords != null &&
                    this.MetaKeywords.SequenceEqual(input.MetaKeywords)
                ) && 
                (
                    this.Mpn == input.Mpn ||
                    (this.Mpn != null &&
                    this.Mpn.Equals(input.Mpn))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OpenGraphDescription == input.OpenGraphDescription ||
                    (this.OpenGraphDescription != null &&
                    this.OpenGraphDescription.Equals(input.OpenGraphDescription))
                ) && 
                (
                    this.OpenGraphTitle == input.OpenGraphTitle ||
                    (this.OpenGraphTitle != null &&
                    this.OpenGraphTitle.Equals(input.OpenGraphTitle))
                ) && 
                (
                    this.OpenGraphType == input.OpenGraphType ||
                    (this.OpenGraphType != null &&
                    this.OpenGraphType.Equals(input.OpenGraphType))
                ) && 
                (
                    this.OpenGraphUseImage == input.OpenGraphUseImage ||
                    (this.OpenGraphUseImage != null &&
                    this.OpenGraphUseImage.Equals(input.OpenGraphUseImage))
                ) && 
                (
                    this.OpenGraphUseMetaDescription == input.OpenGraphUseMetaDescription ||
                    (this.OpenGraphUseMetaDescription != null &&
                    this.OpenGraphUseMetaDescription.Equals(input.OpenGraphUseMetaDescription))
                ) && 
                (
                    this.OpenGraphUseProductName == input.OpenGraphUseProductName ||
                    (this.OpenGraphUseProductName != null &&
                    this.OpenGraphUseProductName.Equals(input.OpenGraphUseProductName))
                ) && 
                (
                    this.OrderQuantityMaximum == input.OrderQuantityMaximum ||
                    (this.OrderQuantityMaximum != null &&
                    this.OrderQuantityMaximum.Equals(input.OrderQuantityMaximum))
                ) && 
                (
                    this.OrderQuantityMinimum == input.OrderQuantityMinimum ||
                    (this.OrderQuantityMinimum != null &&
                    this.OrderQuantityMinimum.Equals(input.OrderQuantityMinimum))
                ) && 
                (
                    this.PageTitle == input.PageTitle ||
                    (this.PageTitle != null &&
                    this.PageTitle.Equals(input.PageTitle))
                ) && 
                (
                    this.PreorderMessage == input.PreorderMessage ||
                    (this.PreorderMessage != null &&
                    this.PreorderMessage.Equals(input.PreorderMessage))
                ) && 
                (
                    this.PreorderReleaseDate == input.PreorderReleaseDate ||
                    (this.PreorderReleaseDate != null &&
                    this.PreorderReleaseDate.Equals(input.PreorderReleaseDate))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.PriceHiddenLabel == input.PriceHiddenLabel ||
                    (this.PriceHiddenLabel != null &&
                    this.PriceHiddenLabel.Equals(input.PriceHiddenLabel))
                ) && 
                (
                    this.ProductTaxCode == input.ProductTaxCode ||
                    (this.ProductTaxCode != null &&
                    this.ProductTaxCode.Equals(input.ProductTaxCode))
                ) && 
                (
                    this.RelatedProducts == input.RelatedProducts ||
                    this.RelatedProducts != null &&
                    input.RelatedProducts != null &&
                    this.RelatedProducts.SequenceEqual(input.RelatedProducts)
                ) && 
                (
                    this.RetailPrice == input.RetailPrice ||
                    (this.RetailPrice != null &&
                    this.RetailPrice.Equals(input.RetailPrice))
                ) && 
                (
                    this.ReviewsCount == input.ReviewsCount ||
                    (this.ReviewsCount != null &&
                    this.ReviewsCount.Equals(input.ReviewsCount))
                ) && 
                (
                    this.ReviewsRatingSum == input.ReviewsRatingSum ||
                    (this.ReviewsRatingSum != null &&
                    this.ReviewsRatingSum.Equals(input.ReviewsRatingSum))
                ) && 
                (
                    this.SalePrice == input.SalePrice ||
                    (this.SalePrice != null &&
                    this.SalePrice.Equals(input.SalePrice))
                ) && 
                (
                    this.SearchKeywords == input.SearchKeywords ||
                    (this.SearchKeywords != null &&
                    this.SearchKeywords.Equals(input.SearchKeywords))
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    (this.SortOrder != null &&
                    this.SortOrder.Equals(input.SortOrder))
                ) && 
                (
                    this.TaxClassId == input.TaxClassId ||
                    (this.TaxClassId != null &&
                    this.TaxClassId.Equals(input.TaxClassId))
                ) && 
                (
                    this.TotalSold == input.TotalSold ||
                    (this.TotalSold != null &&
                    this.TotalSold.Equals(input.TotalSold))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Upc == input.Upc ||
                    (this.Upc != null &&
                    this.Upc.Equals(input.Upc))
                ) && 
                (
                    this.Videos == input.Videos ||
                    this.Videos != null &&
                    input.Videos != null &&
                    this.Videos.SequenceEqual(input.Videos)
                ) && 
                (
                    this.ViewCount == input.ViewCount ||
                    (this.ViewCount != null &&
                    this.ViewCount.Equals(input.ViewCount))
                ) && 
                (
                    this.Warranty == input.Warranty ||
                    (this.Warranty != null &&
                    this.Warranty.Equals(input.Warranty))
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
                ) && 
                (
                    this.Variants == input.Variants ||
                    (this.Variants != null &&
                    this.Variants.Equals(input.Variants))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Availability != null)
                    hashCode = hashCode * 59 + this.Availability.GetHashCode();
                if (this.AvailabilityDescription != null)
                    hashCode = hashCode * 59 + this.AvailabilityDescription.GetHashCode();
                if (this.BinPickingNumber != null)
                    hashCode = hashCode * 59 + this.BinPickingNumber.GetHashCode();
                if (this.BrandId != null)
                    hashCode = hashCode * 59 + this.BrandId.GetHashCode();
                if (this.BrandNameOrBrandId != null)
                    hashCode = hashCode * 59 + this.BrandNameOrBrandId.GetHashCode();
                if (this.BulkPricingRules != null)
                    hashCode = hashCode * 59 + this.BulkPricingRules.GetHashCode();
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.Condition != null)
                    hashCode = hashCode * 59 + this.Condition.GetHashCode();
                if (this.CostPrice != null)
                    hashCode = hashCode * 59 + this.CostPrice.GetHashCode();
                if (this.CustomFields != null)
                    hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
                if (this.CustomUrl != null)
                    hashCode = hashCode * 59 + this.CustomUrl.GetHashCode();
                if (this.Depth != null)
                    hashCode = hashCode * 59 + this.Depth.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.FixedCostShippingPrice != null)
                    hashCode = hashCode * 59 + this.FixedCostShippingPrice.GetHashCode();
                if (this.GiftWrappingOptionsList != null)
                    hashCode = hashCode * 59 + this.GiftWrappingOptionsList.GetHashCode();
                if (this.GiftWrappingOptionsType != null)
                    hashCode = hashCode * 59 + this.GiftWrappingOptionsType.GetHashCode();
                if (this.Gtin != null)
                    hashCode = hashCode * 59 + this.Gtin.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.Images != null)
                    hashCode = hashCode * 59 + this.Images.GetHashCode();
                if (this.InventoryLevel != null)
                    hashCode = hashCode * 59 + this.InventoryLevel.GetHashCode();
                if (this.InventoryTracking != null)
                    hashCode = hashCode * 59 + this.InventoryTracking.GetHashCode();
                if (this.InventoryWarningLevel != null)
                    hashCode = hashCode * 59 + this.InventoryWarningLevel.GetHashCode();
                if (this.IsConditionShown != null)
                    hashCode = hashCode * 59 + this.IsConditionShown.GetHashCode();
                if (this.IsFeatured != null)
                    hashCode = hashCode * 59 + this.IsFeatured.GetHashCode();
                if (this.IsFreeShipping != null)
                    hashCode = hashCode * 59 + this.IsFreeShipping.GetHashCode();
                if (this.IsPreorderOnly != null)
                    hashCode = hashCode * 59 + this.IsPreorderOnly.GetHashCode();
                if (this.IsPriceHidden != null)
                    hashCode = hashCode * 59 + this.IsPriceHidden.GetHashCode();
                if (this.IsVisible != null)
                    hashCode = hashCode * 59 + this.IsVisible.GetHashCode();
                if (this.LayoutFile != null)
                    hashCode = hashCode * 59 + this.LayoutFile.GetHashCode();
                if (this.MetaDescription != null)
                    hashCode = hashCode * 59 + this.MetaDescription.GetHashCode();
                if (this.MetaKeywords != null)
                    hashCode = hashCode * 59 + this.MetaKeywords.GetHashCode();
                if (this.Mpn != null)
                    hashCode = hashCode * 59 + this.Mpn.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.OpenGraphDescription != null)
                    hashCode = hashCode * 59 + this.OpenGraphDescription.GetHashCode();
                if (this.OpenGraphTitle != null)
                    hashCode = hashCode * 59 + this.OpenGraphTitle.GetHashCode();
                if (this.OpenGraphType != null)
                    hashCode = hashCode * 59 + this.OpenGraphType.GetHashCode();
                if (this.OpenGraphUseImage != null)
                    hashCode = hashCode * 59 + this.OpenGraphUseImage.GetHashCode();
                if (this.OpenGraphUseMetaDescription != null)
                    hashCode = hashCode * 59 + this.OpenGraphUseMetaDescription.GetHashCode();
                if (this.OpenGraphUseProductName != null)
                    hashCode = hashCode * 59 + this.OpenGraphUseProductName.GetHashCode();
                if (this.OrderQuantityMaximum != null)
                    hashCode = hashCode * 59 + this.OrderQuantityMaximum.GetHashCode();
                if (this.OrderQuantityMinimum != null)
                    hashCode = hashCode * 59 + this.OrderQuantityMinimum.GetHashCode();
                if (this.PageTitle != null)
                    hashCode = hashCode * 59 + this.PageTitle.GetHashCode();
                if (this.PreorderMessage != null)
                    hashCode = hashCode * 59 + this.PreorderMessage.GetHashCode();
                if (this.PreorderReleaseDate != null)
                    hashCode = hashCode * 59 + this.PreorderReleaseDate.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.PriceHiddenLabel != null)
                    hashCode = hashCode * 59 + this.PriceHiddenLabel.GetHashCode();
                if (this.ProductTaxCode != null)
                    hashCode = hashCode * 59 + this.ProductTaxCode.GetHashCode();
                if (this.RelatedProducts != null)
                    hashCode = hashCode * 59 + this.RelatedProducts.GetHashCode();
                if (this.RetailPrice != null)
                    hashCode = hashCode * 59 + this.RetailPrice.GetHashCode();
                if (this.ReviewsCount != null)
                    hashCode = hashCode * 59 + this.ReviewsCount.GetHashCode();
                if (this.ReviewsRatingSum != null)
                    hashCode = hashCode * 59 + this.ReviewsRatingSum.GetHashCode();
                if (this.SalePrice != null)
                    hashCode = hashCode * 59 + this.SalePrice.GetHashCode();
                if (this.SearchKeywords != null)
                    hashCode = hashCode * 59 + this.SearchKeywords.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                if (this.TaxClassId != null)
                    hashCode = hashCode * 59 + this.TaxClassId.GetHashCode();
                if (this.TotalSold != null)
                    hashCode = hashCode * 59 + this.TotalSold.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Upc != null)
                    hashCode = hashCode * 59 + this.Upc.GetHashCode();
                if (this.Videos != null)
                    hashCode = hashCode * 59 + this.Videos.GetHashCode();
                if (this.ViewCount != null)
                    hashCode = hashCode * 59 + this.ViewCount.GetHashCode();
                if (this.Warranty != null)
                    hashCode = hashCode * 59 + this.Warranty.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
                if (this.Variants != null)
                    hashCode = hashCode * 59 + this.Variants.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
