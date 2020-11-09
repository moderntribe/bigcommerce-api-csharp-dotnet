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
using SwaggerDateConverter = BigCommerce.Client.SwaggerDateConverter;

namespace BigCommerce.Model
{
    /// <summary>
    /// The values for option config can vary based on the Modifier created.
    /// </summary>
    [DataContract]
        public partial class ProductOptionConfigFull :  IEquatable<ProductOptionConfigFull>, IValidatableObject
    {
        /// <summary>
        /// (date) The type of limit that is allowed to be entered on a date option. 
        /// </summary>
        /// <value>(date) The type of limit that is allowed to be entered on a date option. </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum DateLimitModeEnum
        {
            /// <summary>
            /// Enum Earliest for value: earliest
            /// </summary>
            [EnumMember(Value = "earliest")]
            Earliest = 1,
            /// <summary>
            /// Enum Range for value: range
            /// </summary>
            [EnumMember(Value = "range")]
            Range = 2,
            /// <summary>
            /// Enum Latest for value: latest
            /// </summary>
            [EnumMember(Value = "latest")]
            Latest = 3        }
        /// <summary>
        /// (date) The type of limit that is allowed to be entered on a date option. 
        /// </summary>
        /// <value>(date) The type of limit that is allowed to be entered on a date option. </value>
        [DataMember(Name="date_limit_mode", EmitDefaultValue=false)]
        public DateLimitModeEnum? DateLimitMode { get; set; }
        /// <summary>
        /// (file) The kind of restriction on the file types that can be uploaded with a file upload option. Values: &#x60;specific&#x60; - restricts uploads to particular file types; &#x60;all&#x60; - allows all file types. 
        /// </summary>
        /// <value>(file) The kind of restriction on the file types that can be uploaded with a file upload option. Values: &#x60;specific&#x60; - restricts uploads to particular file types; &#x60;all&#x60; - allows all file types. </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum FileTypesModeEnum
        {
            /// <summary>
            /// Enum Specific for value: specific
            /// </summary>
            [EnumMember(Value = "specific")]
            Specific = 1,
            /// <summary>
            /// Enum All for value: all
            /// </summary>
            [EnumMember(Value = "all")]
            All = 2        }
        /// <summary>
        /// (file) The kind of restriction on the file types that can be uploaded with a file upload option. Values: &#x60;specific&#x60; - restricts uploads to particular file types; &#x60;all&#x60; - allows all file types. 
        /// </summary>
        /// <value>(file) The kind of restriction on the file types that can be uploaded with a file upload option. Values: &#x60;specific&#x60; - restricts uploads to particular file types; &#x60;all&#x60; - allows all file types. </value>
        [DataMember(Name="file_types_mode", EmitDefaultValue=false)]
        public FileTypesModeEnum? FileTypesMode { get; set; }
        /// <summary>
        /// (numbers_only_text) The type of limit on values entered for a number option. 
        /// </summary>
        /// <value>(numbers_only_text) The type of limit on values entered for a number option. </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum NumberLimitModeEnum
        {
            /// <summary>
            /// Enum Lowest for value: lowest
            /// </summary>
            [EnumMember(Value = "lowest")]
            Lowest = 1,
            /// <summary>
            /// Enum Highest for value: highest
            /// </summary>
            [EnumMember(Value = "highest")]
            Highest = 2,
            /// <summary>
            /// Enum Range for value: range
            /// </summary>
            [EnumMember(Value = "range")]
            Range = 3        }
        /// <summary>
        /// (numbers_only_text) The type of limit on values entered for a number option. 
        /// </summary>
        /// <value>(numbers_only_text) The type of limit on values entered for a number option. </value>
        [DataMember(Name="number_limit_mode", EmitDefaultValue=false)]
        public NumberLimitModeEnum? NumberLimitMode { get; set; }
        /// <summary>
        /// (product_list, product_list_with_images) How to factor the optional product&#x27;s weight and package dimensions into the shipping quote. Values: &#x60;none&#x60; - don&#x27;t adjust; &#x60;weight&#x60; - use shipping weight only; &#x60;package&#x60; - use weight and dimensions. 
        /// </summary>
        /// <value>(product_list, product_list_with_images) How to factor the optional product&#x27;s weight and package dimensions into the shipping quote. Values: &#x60;none&#x60; - don&#x27;t adjust; &#x60;weight&#x60; - use shipping weight only; &#x60;package&#x60; - use weight and dimensions. </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ProductListShippingCalcEnum
        {
            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 1,
            /// <summary>
            /// Enum Weight for value: weight
            /// </summary>
            [EnumMember(Value = "weight")]
            Weight = 2,
            /// <summary>
            /// Enum Package for value: package
            /// </summary>
            [EnumMember(Value = "package")]
            Package = 3        }
        /// <summary>
        /// (product_list, product_list_with_images) How to factor the optional product&#x27;s weight and package dimensions into the shipping quote. Values: &#x60;none&#x60; - don&#x27;t adjust; &#x60;weight&#x60; - use shipping weight only; &#x60;package&#x60; - use weight and dimensions. 
        /// </summary>
        /// <value>(product_list, product_list_with_images) How to factor the optional product&#x27;s weight and package dimensions into the shipping quote. Values: &#x60;none&#x60; - don&#x27;t adjust; &#x60;weight&#x60; - use shipping weight only; &#x60;package&#x60; - use weight and dimensions. </value>
        [DataMember(Name="product_list_shipping_calc", EmitDefaultValue=false)]
        public ProductListShippingCalcEnum? ProductListShippingCalc { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductOptionConfigFull" /> class.
        /// </summary>
        /// <param name="checkboxLabel">(checkbox) Label displayed for the checkbox option. .</param>
        /// <param name="checkedByDefault">(checkbox) Flag for setting the checkbox to be checked by default. .</param>
        /// <param name="dateEarliestValue">(date) The earliest date allowed to be entered on the date option, as an ISO-8601 formatted string. .</param>
        /// <param name="dateLatestValue">(date) The latest date allowed to be entered on the date option, as an ISO-8601 formatted string. .</param>
        /// <param name="dateLimitMode">(date) The type of limit that is allowed to be entered on a date option. .</param>
        /// <param name="dateLimited">(date) Flag to limit the dates allowed to be entered on a date option. .</param>
        /// <param name="defaultValue">(date, text, multi_line_text, numbers_only_text) The default value. Shown on a date option as an ISO-8601–formatted string, or on a text option as a string. .</param>
        /// <param name="fileMaxSize">(file) The maximum size for a file that can be used with the file upload option. This will still be limited by the server. .</param>
        /// <param name="fileTypesMode">(file) The kind of restriction on the file types that can be uploaded with a file upload option. Values: &#x60;specific&#x60; - restricts uploads to particular file types; &#x60;all&#x60; - allows all file types. .</param>
        /// <param name="fileTypesOther">(file) A list of other file types allowed with the file upload option. .</param>
        /// <param name="fileTypesSupported">(file) The type of files allowed to be uploaded if the &#x60;file_type_option&#x60; is set to &#x60;specific&#x60;. Values:   &#x60;images&#x60; - Allows upload of image MIME types (&#x60;bmp&#x60;, &#x60;gif&#x60;, &#x60;jpg&#x60;, &#x60;jpeg&#x60;, &#x60;jpe&#x60;, &#x60;jif&#x60;, &#x60;jfif&#x60;, &#x60;jfi&#x60;, &#x60;png&#x60;, &#x60;wbmp&#x60;, &#x60;xbm&#x60;, &#x60;tiff&#x60;). &#x60;documents&#x60; - Allows upload of document MIME types (&#x60;txt&#x60;, &#x60;pdf&#x60;, &#x60;rtf&#x60;, &#x60;doc&#x60;, &#x60;docx&#x60;, &#x60;xls&#x60;, &#x60;xlsx&#x60;, &#x60;accdb&#x60;, &#x60;mdb&#x60;, &#x60;one&#x60;, &#x60;pps&#x60;, &#x60;ppsx&#x60;, &#x60;ppt&#x60;, &#x60;pptx&#x60;, &#x60;pub&#x60;, &#x60;odt&#x60;, &#x60;ods&#x60;, &#x60;odp&#x60;, &#x60;odg&#x60;, &#x60;odf&#x60;).   &#x60;other&#x60; - Allows file types defined in the &#x60;file_types_other&#x60; array. .</param>
        /// <param name="numberHighestValue">(numbers_only_text) The highest allowed value for a number option if &#x60;number_limited&#x60; is true. .</param>
        /// <param name="numberIntegersOnly">(numbers_only_text) Flag to limit the input on a number option to whole numbers only. .</param>
        /// <param name="numberLimitMode">(numbers_only_text) The type of limit on values entered for a number option. .</param>
        /// <param name="numberLimited">(numbers_only_text) Flag to limit the value of a number option. .</param>
        /// <param name="numberLowestValue">(numbers_only_text) The lowest allowed value for a number option if &#x60;number_limited&#x60; is true. .</param>
        /// <param name="productListAdjustsInventory">(product_list, product_list_with_images) Flag for automatically adjusting inventory on a product included in the list. .</param>
        /// <param name="productListAdjustsPricing">(product_list, product_list_with_images) Flag to add the optional product&#x27;s price to the main product&#x27;s price. .</param>
        /// <param name="productListShippingCalc">(product_list, product_list_with_images) How to factor the optional product&#x27;s weight and package dimensions into the shipping quote. Values: &#x60;none&#x60; - don&#x27;t adjust; &#x60;weight&#x60; - use shipping weight only; &#x60;package&#x60; - use weight and dimensions. .</param>
        /// <param name="textCharactersLimited">(text, multi_line_text) Flag to validate the length of a text or multi-line text input. .</param>
        /// <param name="textLinesLimited">(multi_line_text) Flag to validate the maximum number of lines allowed on a multi-line text input. .</param>
        /// <param name="textMaxLength">(text, multi_line_text) The maximum length allowed for a text or multi line text option. .</param>
        /// <param name="textMaxLines">(multi_line_text) The maximum number of lines allowed on a multi-line text input. .</param>
        /// <param name="textMinLength">(text, multi_line_text) The minimum length allowed for a text or multi-line text option. .</param>
        public ProductOptionConfigFull(string checkboxLabel = default(string), bool? checkedByDefault = default(bool?), DateTime? dateEarliestValue = default(DateTime?), DateTime? dateLatestValue = default(DateTime?), DateLimitModeEnum? dateLimitMode = default(DateLimitModeEnum?), bool? dateLimited = default(bool?), string defaultValue = default(string), int? fileMaxSize = default(int?), FileTypesModeEnum? fileTypesMode = default(FileTypesModeEnum?), List<string> fileTypesOther = default(List<string>), List<string> fileTypesSupported = default(List<string>), decimal? numberHighestValue = default(decimal?), bool? numberIntegersOnly = default(bool?), NumberLimitModeEnum? numberLimitMode = default(NumberLimitModeEnum?), bool? numberLimited = default(bool?), decimal? numberLowestValue = default(decimal?), bool? productListAdjustsInventory = default(bool?), bool? productListAdjustsPricing = default(bool?), ProductListShippingCalcEnum? productListShippingCalc = default(ProductListShippingCalcEnum?), bool? textCharactersLimited = default(bool?), bool? textLinesLimited = default(bool?), int? textMaxLength = default(int?), int? textMaxLines = default(int?), int? textMinLength = default(int?))
        {
            this.CheckboxLabel = checkboxLabel;
            this.CheckedByDefault = checkedByDefault;
            this.DateEarliestValue = dateEarliestValue;
            this.DateLatestValue = dateLatestValue;
            this.DateLimitMode = dateLimitMode;
            this.DateLimited = dateLimited;
            this.DefaultValue = defaultValue;
            this.FileMaxSize = fileMaxSize;
            this.FileTypesMode = fileTypesMode;
            this.FileTypesOther = fileTypesOther;
            this.FileTypesSupported = fileTypesSupported;
            this.NumberHighestValue = numberHighestValue;
            this.NumberIntegersOnly = numberIntegersOnly;
            this.NumberLimitMode = numberLimitMode;
            this.NumberLimited = numberLimited;
            this.NumberLowestValue = numberLowestValue;
            this.ProductListAdjustsInventory = productListAdjustsInventory;
            this.ProductListAdjustsPricing = productListAdjustsPricing;
            this.ProductListShippingCalc = productListShippingCalc;
            this.TextCharactersLimited = textCharactersLimited;
            this.TextLinesLimited = textLinesLimited;
            this.TextMaxLength = textMaxLength;
            this.TextMaxLines = textMaxLines;
            this.TextMinLength = textMinLength;
        }
        
        /// <summary>
        /// (checkbox) Label displayed for the checkbox option. 
        /// </summary>
        /// <value>(checkbox) Label displayed for the checkbox option. </value>
        [DataMember(Name="checkbox_label", EmitDefaultValue=false)]
        public string CheckboxLabel { get; set; }

        /// <summary>
        /// (checkbox) Flag for setting the checkbox to be checked by default. 
        /// </summary>
        /// <value>(checkbox) Flag for setting the checkbox to be checked by default. </value>
        [DataMember(Name="checked_by_default", EmitDefaultValue=false)]
        public bool? CheckedByDefault { get; set; }

        /// <summary>
        /// (date) The earliest date allowed to be entered on the date option, as an ISO-8601 formatted string. 
        /// </summary>
        /// <value>(date) The earliest date allowed to be entered on the date option, as an ISO-8601 formatted string. </value>
        [DataMember(Name="date_earliest_value", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DateEarliestValue { get; set; }

        /// <summary>
        /// (date) The latest date allowed to be entered on the date option, as an ISO-8601 formatted string. 
        /// </summary>
        /// <value>(date) The latest date allowed to be entered on the date option, as an ISO-8601 formatted string. </value>
        [DataMember(Name="date_latest_value", EmitDefaultValue=false)]
        [JsonConverter(typeof(SwaggerDateConverter))]
        public DateTime? DateLatestValue { get; set; }


        /// <summary>
        /// (date) Flag to limit the dates allowed to be entered on a date option. 
        /// </summary>
        /// <value>(date) Flag to limit the dates allowed to be entered on a date option. </value>
        [DataMember(Name="date_limited", EmitDefaultValue=false)]
        public bool? DateLimited { get; set; }

        /// <summary>
        /// (date, text, multi_line_text, numbers_only_text) The default value. Shown on a date option as an ISO-8601–formatted string, or on a text option as a string. 
        /// </summary>
        /// <value>(date, text, multi_line_text, numbers_only_text) The default value. Shown on a date option as an ISO-8601–formatted string, or on a text option as a string. </value>
        [DataMember(Name="default_value", EmitDefaultValue=false)]
        public string DefaultValue { get; set; }

        /// <summary>
        /// (file) The maximum size for a file that can be used with the file upload option. This will still be limited by the server. 
        /// </summary>
        /// <value>(file) The maximum size for a file that can be used with the file upload option. This will still be limited by the server. </value>
        [DataMember(Name="file_max_size", EmitDefaultValue=false)]
        public int? FileMaxSize { get; set; }


        /// <summary>
        /// (file) A list of other file types allowed with the file upload option. 
        /// </summary>
        /// <value>(file) A list of other file types allowed with the file upload option. </value>
        [DataMember(Name="file_types_other", EmitDefaultValue=false)]
        public List<string> FileTypesOther { get; set; }

        /// <summary>
        /// (file) The type of files allowed to be uploaded if the &#x60;file_type_option&#x60; is set to &#x60;specific&#x60;. Values:   &#x60;images&#x60; - Allows upload of image MIME types (&#x60;bmp&#x60;, &#x60;gif&#x60;, &#x60;jpg&#x60;, &#x60;jpeg&#x60;, &#x60;jpe&#x60;, &#x60;jif&#x60;, &#x60;jfif&#x60;, &#x60;jfi&#x60;, &#x60;png&#x60;, &#x60;wbmp&#x60;, &#x60;xbm&#x60;, &#x60;tiff&#x60;). &#x60;documents&#x60; - Allows upload of document MIME types (&#x60;txt&#x60;, &#x60;pdf&#x60;, &#x60;rtf&#x60;, &#x60;doc&#x60;, &#x60;docx&#x60;, &#x60;xls&#x60;, &#x60;xlsx&#x60;, &#x60;accdb&#x60;, &#x60;mdb&#x60;, &#x60;one&#x60;, &#x60;pps&#x60;, &#x60;ppsx&#x60;, &#x60;ppt&#x60;, &#x60;pptx&#x60;, &#x60;pub&#x60;, &#x60;odt&#x60;, &#x60;ods&#x60;, &#x60;odp&#x60;, &#x60;odg&#x60;, &#x60;odf&#x60;).   &#x60;other&#x60; - Allows file types defined in the &#x60;file_types_other&#x60; array. 
        /// </summary>
        /// <value>(file) The type of files allowed to be uploaded if the &#x60;file_type_option&#x60; is set to &#x60;specific&#x60;. Values:   &#x60;images&#x60; - Allows upload of image MIME types (&#x60;bmp&#x60;, &#x60;gif&#x60;, &#x60;jpg&#x60;, &#x60;jpeg&#x60;, &#x60;jpe&#x60;, &#x60;jif&#x60;, &#x60;jfif&#x60;, &#x60;jfi&#x60;, &#x60;png&#x60;, &#x60;wbmp&#x60;, &#x60;xbm&#x60;, &#x60;tiff&#x60;). &#x60;documents&#x60; - Allows upload of document MIME types (&#x60;txt&#x60;, &#x60;pdf&#x60;, &#x60;rtf&#x60;, &#x60;doc&#x60;, &#x60;docx&#x60;, &#x60;xls&#x60;, &#x60;xlsx&#x60;, &#x60;accdb&#x60;, &#x60;mdb&#x60;, &#x60;one&#x60;, &#x60;pps&#x60;, &#x60;ppsx&#x60;, &#x60;ppt&#x60;, &#x60;pptx&#x60;, &#x60;pub&#x60;, &#x60;odt&#x60;, &#x60;ods&#x60;, &#x60;odp&#x60;, &#x60;odg&#x60;, &#x60;odf&#x60;).   &#x60;other&#x60; - Allows file types defined in the &#x60;file_types_other&#x60; array. </value>
        [DataMember(Name="file_types_supported", EmitDefaultValue=false)]
        public List<string> FileTypesSupported { get; set; }

        /// <summary>
        /// (numbers_only_text) The highest allowed value for a number option if &#x60;number_limited&#x60; is true. 
        /// </summary>
        /// <value>(numbers_only_text) The highest allowed value for a number option if &#x60;number_limited&#x60; is true. </value>
        [DataMember(Name="number_highest_value", EmitDefaultValue=false)]
        public decimal? NumberHighestValue { get; set; }

        /// <summary>
        /// (numbers_only_text) Flag to limit the input on a number option to whole numbers only. 
        /// </summary>
        /// <value>(numbers_only_text) Flag to limit the input on a number option to whole numbers only. </value>
        [DataMember(Name="number_integers_only", EmitDefaultValue=false)]
        public bool? NumberIntegersOnly { get; set; }


        /// <summary>
        /// (numbers_only_text) Flag to limit the value of a number option. 
        /// </summary>
        /// <value>(numbers_only_text) Flag to limit the value of a number option. </value>
        [DataMember(Name="number_limited", EmitDefaultValue=false)]
        public bool? NumberLimited { get; set; }

        /// <summary>
        /// (numbers_only_text) The lowest allowed value for a number option if &#x60;number_limited&#x60; is true. 
        /// </summary>
        /// <value>(numbers_only_text) The lowest allowed value for a number option if &#x60;number_limited&#x60; is true. </value>
        [DataMember(Name="number_lowest_value", EmitDefaultValue=false)]
        public decimal? NumberLowestValue { get; set; }

        /// <summary>
        /// (product_list, product_list_with_images) Flag for automatically adjusting inventory on a product included in the list. 
        /// </summary>
        /// <value>(product_list, product_list_with_images) Flag for automatically adjusting inventory on a product included in the list. </value>
        [DataMember(Name="product_list_adjusts_inventory", EmitDefaultValue=false)]
        public bool? ProductListAdjustsInventory { get; set; }

        /// <summary>
        /// (product_list, product_list_with_images) Flag to add the optional product&#x27;s price to the main product&#x27;s price. 
        /// </summary>
        /// <value>(product_list, product_list_with_images) Flag to add the optional product&#x27;s price to the main product&#x27;s price. </value>
        [DataMember(Name="product_list_adjusts_pricing", EmitDefaultValue=false)]
        public bool? ProductListAdjustsPricing { get; set; }


        /// <summary>
        /// (text, multi_line_text) Flag to validate the length of a text or multi-line text input. 
        /// </summary>
        /// <value>(text, multi_line_text) Flag to validate the length of a text or multi-line text input. </value>
        [DataMember(Name="text_characters_limited", EmitDefaultValue=false)]
        public bool? TextCharactersLimited { get; set; }

        /// <summary>
        /// (multi_line_text) Flag to validate the maximum number of lines allowed on a multi-line text input. 
        /// </summary>
        /// <value>(multi_line_text) Flag to validate the maximum number of lines allowed on a multi-line text input. </value>
        [DataMember(Name="text_lines_limited", EmitDefaultValue=false)]
        public bool? TextLinesLimited { get; set; }

        /// <summary>
        /// (text, multi_line_text) The maximum length allowed for a text or multi line text option. 
        /// </summary>
        /// <value>(text, multi_line_text) The maximum length allowed for a text or multi line text option. </value>
        [DataMember(Name="text_max_length", EmitDefaultValue=false)]
        public int? TextMaxLength { get; set; }

        /// <summary>
        /// (multi_line_text) The maximum number of lines allowed on a multi-line text input. 
        /// </summary>
        /// <value>(multi_line_text) The maximum number of lines allowed on a multi-line text input. </value>
        [DataMember(Name="text_max_lines", EmitDefaultValue=false)]
        public int? TextMaxLines { get; set; }

        /// <summary>
        /// (text, multi_line_text) The minimum length allowed for a text or multi-line text option. 
        /// </summary>
        /// <value>(text, multi_line_text) The minimum length allowed for a text or multi-line text option. </value>
        [DataMember(Name="text_min_length", EmitDefaultValue=false)]
        public int? TextMinLength { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductOptionConfigFull {\n");
            sb.Append("  CheckboxLabel: ").Append(CheckboxLabel).Append("\n");
            sb.Append("  CheckedByDefault: ").Append(CheckedByDefault).Append("\n");
            sb.Append("  DateEarliestValue: ").Append(DateEarliestValue).Append("\n");
            sb.Append("  DateLatestValue: ").Append(DateLatestValue).Append("\n");
            sb.Append("  DateLimitMode: ").Append(DateLimitMode).Append("\n");
            sb.Append("  DateLimited: ").Append(DateLimited).Append("\n");
            sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
            sb.Append("  FileMaxSize: ").Append(FileMaxSize).Append("\n");
            sb.Append("  FileTypesMode: ").Append(FileTypesMode).Append("\n");
            sb.Append("  FileTypesOther: ").Append(FileTypesOther).Append("\n");
            sb.Append("  FileTypesSupported: ").Append(FileTypesSupported).Append("\n");
            sb.Append("  NumberHighestValue: ").Append(NumberHighestValue).Append("\n");
            sb.Append("  NumberIntegersOnly: ").Append(NumberIntegersOnly).Append("\n");
            sb.Append("  NumberLimitMode: ").Append(NumberLimitMode).Append("\n");
            sb.Append("  NumberLimited: ").Append(NumberLimited).Append("\n");
            sb.Append("  NumberLowestValue: ").Append(NumberLowestValue).Append("\n");
            sb.Append("  ProductListAdjustsInventory: ").Append(ProductListAdjustsInventory).Append("\n");
            sb.Append("  ProductListAdjustsPricing: ").Append(ProductListAdjustsPricing).Append("\n");
            sb.Append("  ProductListShippingCalc: ").Append(ProductListShippingCalc).Append("\n");
            sb.Append("  TextCharactersLimited: ").Append(TextCharactersLimited).Append("\n");
            sb.Append("  TextLinesLimited: ").Append(TextLinesLimited).Append("\n");
            sb.Append("  TextMaxLength: ").Append(TextMaxLength).Append("\n");
            sb.Append("  TextMaxLines: ").Append(TextMaxLines).Append("\n");
            sb.Append("  TextMinLength: ").Append(TextMinLength).Append("\n");
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
            return this.Equals(input as ProductOptionConfigFull);
        }

        /// <summary>
        /// Returns true if ProductOptionConfigFull instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductOptionConfigFull to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductOptionConfigFull input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CheckboxLabel == input.CheckboxLabel ||
                    (this.CheckboxLabel != null &&
                    this.CheckboxLabel.Equals(input.CheckboxLabel))
                ) && 
                (
                    this.CheckedByDefault == input.CheckedByDefault ||
                    (this.CheckedByDefault != null &&
                    this.CheckedByDefault.Equals(input.CheckedByDefault))
                ) && 
                (
                    this.DateEarliestValue == input.DateEarliestValue ||
                    (this.DateEarliestValue != null &&
                    this.DateEarliestValue.Equals(input.DateEarliestValue))
                ) && 
                (
                    this.DateLatestValue == input.DateLatestValue ||
                    (this.DateLatestValue != null &&
                    this.DateLatestValue.Equals(input.DateLatestValue))
                ) && 
                (
                    this.DateLimitMode == input.DateLimitMode ||
                    (this.DateLimitMode != null &&
                    this.DateLimitMode.Equals(input.DateLimitMode))
                ) && 
                (
                    this.DateLimited == input.DateLimited ||
                    (this.DateLimited != null &&
                    this.DateLimited.Equals(input.DateLimited))
                ) && 
                (
                    this.DefaultValue == input.DefaultValue ||
                    (this.DefaultValue != null &&
                    this.DefaultValue.Equals(input.DefaultValue))
                ) && 
                (
                    this.FileMaxSize == input.FileMaxSize ||
                    (this.FileMaxSize != null &&
                    this.FileMaxSize.Equals(input.FileMaxSize))
                ) && 
                (
                    this.FileTypesMode == input.FileTypesMode ||
                    (this.FileTypesMode != null &&
                    this.FileTypesMode.Equals(input.FileTypesMode))
                ) && 
                (
                    this.FileTypesOther == input.FileTypesOther ||
                    this.FileTypesOther != null &&
                    input.FileTypesOther != null &&
                    this.FileTypesOther.SequenceEqual(input.FileTypesOther)
                ) && 
                (
                    this.FileTypesSupported == input.FileTypesSupported ||
                    this.FileTypesSupported != null &&
                    input.FileTypesSupported != null &&
                    this.FileTypesSupported.SequenceEqual(input.FileTypesSupported)
                ) && 
                (
                    this.NumberHighestValue == input.NumberHighestValue ||
                    (this.NumberHighestValue != null &&
                    this.NumberHighestValue.Equals(input.NumberHighestValue))
                ) && 
                (
                    this.NumberIntegersOnly == input.NumberIntegersOnly ||
                    (this.NumberIntegersOnly != null &&
                    this.NumberIntegersOnly.Equals(input.NumberIntegersOnly))
                ) && 
                (
                    this.NumberLimitMode == input.NumberLimitMode ||
                    (this.NumberLimitMode != null &&
                    this.NumberLimitMode.Equals(input.NumberLimitMode))
                ) && 
                (
                    this.NumberLimited == input.NumberLimited ||
                    (this.NumberLimited != null &&
                    this.NumberLimited.Equals(input.NumberLimited))
                ) && 
                (
                    this.NumberLowestValue == input.NumberLowestValue ||
                    (this.NumberLowestValue != null &&
                    this.NumberLowestValue.Equals(input.NumberLowestValue))
                ) && 
                (
                    this.ProductListAdjustsInventory == input.ProductListAdjustsInventory ||
                    (this.ProductListAdjustsInventory != null &&
                    this.ProductListAdjustsInventory.Equals(input.ProductListAdjustsInventory))
                ) && 
                (
                    this.ProductListAdjustsPricing == input.ProductListAdjustsPricing ||
                    (this.ProductListAdjustsPricing != null &&
                    this.ProductListAdjustsPricing.Equals(input.ProductListAdjustsPricing))
                ) && 
                (
                    this.ProductListShippingCalc == input.ProductListShippingCalc ||
                    (this.ProductListShippingCalc != null &&
                    this.ProductListShippingCalc.Equals(input.ProductListShippingCalc))
                ) && 
                (
                    this.TextCharactersLimited == input.TextCharactersLimited ||
                    (this.TextCharactersLimited != null &&
                    this.TextCharactersLimited.Equals(input.TextCharactersLimited))
                ) && 
                (
                    this.TextLinesLimited == input.TextLinesLimited ||
                    (this.TextLinesLimited != null &&
                    this.TextLinesLimited.Equals(input.TextLinesLimited))
                ) && 
                (
                    this.TextMaxLength == input.TextMaxLength ||
                    (this.TextMaxLength != null &&
                    this.TextMaxLength.Equals(input.TextMaxLength))
                ) && 
                (
                    this.TextMaxLines == input.TextMaxLines ||
                    (this.TextMaxLines != null &&
                    this.TextMaxLines.Equals(input.TextMaxLines))
                ) && 
                (
                    this.TextMinLength == input.TextMinLength ||
                    (this.TextMinLength != null &&
                    this.TextMinLength.Equals(input.TextMinLength))
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
                if (this.CheckboxLabel != null)
                    hashCode = hashCode * 59 + this.CheckboxLabel.GetHashCode();
                if (this.CheckedByDefault != null)
                    hashCode = hashCode * 59 + this.CheckedByDefault.GetHashCode();
                if (this.DateEarliestValue != null)
                    hashCode = hashCode * 59 + this.DateEarliestValue.GetHashCode();
                if (this.DateLatestValue != null)
                    hashCode = hashCode * 59 + this.DateLatestValue.GetHashCode();
                if (this.DateLimitMode != null)
                    hashCode = hashCode * 59 + this.DateLimitMode.GetHashCode();
                if (this.DateLimited != null)
                    hashCode = hashCode * 59 + this.DateLimited.GetHashCode();
                if (this.DefaultValue != null)
                    hashCode = hashCode * 59 + this.DefaultValue.GetHashCode();
                if (this.FileMaxSize != null)
                    hashCode = hashCode * 59 + this.FileMaxSize.GetHashCode();
                if (this.FileTypesMode != null)
                    hashCode = hashCode * 59 + this.FileTypesMode.GetHashCode();
                if (this.FileTypesOther != null)
                    hashCode = hashCode * 59 + this.FileTypesOther.GetHashCode();
                if (this.FileTypesSupported != null)
                    hashCode = hashCode * 59 + this.FileTypesSupported.GetHashCode();
                if (this.NumberHighestValue != null)
                    hashCode = hashCode * 59 + this.NumberHighestValue.GetHashCode();
                if (this.NumberIntegersOnly != null)
                    hashCode = hashCode * 59 + this.NumberIntegersOnly.GetHashCode();
                if (this.NumberLimitMode != null)
                    hashCode = hashCode * 59 + this.NumberLimitMode.GetHashCode();
                if (this.NumberLimited != null)
                    hashCode = hashCode * 59 + this.NumberLimited.GetHashCode();
                if (this.NumberLowestValue != null)
                    hashCode = hashCode * 59 + this.NumberLowestValue.GetHashCode();
                if (this.ProductListAdjustsInventory != null)
                    hashCode = hashCode * 59 + this.ProductListAdjustsInventory.GetHashCode();
                if (this.ProductListAdjustsPricing != null)
                    hashCode = hashCode * 59 + this.ProductListAdjustsPricing.GetHashCode();
                if (this.ProductListShippingCalc != null)
                    hashCode = hashCode * 59 + this.ProductListShippingCalc.GetHashCode();
                if (this.TextCharactersLimited != null)
                    hashCode = hashCode * 59 + this.TextCharactersLimited.GetHashCode();
                if (this.TextLinesLimited != null)
                    hashCode = hashCode * 59 + this.TextLinesLimited.GetHashCode();
                if (this.TextMaxLength != null)
                    hashCode = hashCode * 59 + this.TextMaxLength.GetHashCode();
                if (this.TextMaxLines != null)
                    hashCode = hashCode * 59 + this.TextMaxLines.GetHashCode();
                if (this.TextMinLength != null)
                    hashCode = hashCode * 59 + this.TextMinLength.GetHashCode();
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
