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
    /// Common Modifier properties.
    /// </summary>
    [DataContract]
        public partial class ProductModifierBase :  IEquatable<ProductModifierBase>, IValidatableObject
    {
        /// <summary>
        /// BigCommerce API, which determines how it will display on the storefront. Acceptable values: &#x60;date&#x60;, &#x60;checkbox&#x60;, &#x60;file&#x60;, &#x60;text&#x60;, &#x60;multi_line_text&#x60;, &#x60;numbers_only_text&#x60;, &#x60;radio_buttons&#x60;, &#x60;rectangles&#x60;, &#x60;dropdown&#x60;, &#x60;product_list&#x60;, &#x60;product_list_with_images&#x60;, &#x60;swatch&#x60;. Required in a /POST. 
        /// </summary>
        /// <value>BigCommerce API, which determines how it will display on the storefront. Acceptable values: &#x60;date&#x60;, &#x60;checkbox&#x60;, &#x60;file&#x60;, &#x60;text&#x60;, &#x60;multi_line_text&#x60;, &#x60;numbers_only_text&#x60;, &#x60;radio_buttons&#x60;, &#x60;rectangles&#x60;, &#x60;dropdown&#x60;, &#x60;product_list&#x60;, &#x60;product_list_with_images&#x60;, &#x60;swatch&#x60;. Required in a /POST. </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Date for value: date
            /// </summary>
            [EnumMember(Value = "date")]
            Date = 1,
            /// <summary>
            /// Enum Checkbox for value: checkbox
            /// </summary>
            [EnumMember(Value = "checkbox")]
            Checkbox = 2,
            /// <summary>
            /// Enum File for value: file
            /// </summary>
            [EnumMember(Value = "file")]
            File = 3,
            /// <summary>
            /// Enum Text for value: text
            /// </summary>
            [EnumMember(Value = "text")]
            Text = 4,
            /// <summary>
            /// Enum Multilinetext for value: multi_line_text
            /// </summary>
            [EnumMember(Value = "multi_line_text")]
            Multilinetext = 5,
            /// <summary>
            /// Enum Numbersonlytext for value: numbers_only_text
            /// </summary>
            [EnumMember(Value = "numbers_only_text")]
            Numbersonlytext = 6,
            /// <summary>
            /// Enum Radiobuttons for value: radio_buttons
            /// </summary>
            [EnumMember(Value = "radio_buttons")]
            Radiobuttons = 7,
            /// <summary>
            /// Enum Rectangles for value: rectangles
            /// </summary>
            [EnumMember(Value = "rectangles")]
            Rectangles = 8,
            /// <summary>
            /// Enum Dropdown for value: dropdown
            /// </summary>
            [EnumMember(Value = "dropdown")]
            Dropdown = 9,
            /// <summary>
            /// Enum Productlist for value: product_list
            /// </summary>
            [EnumMember(Value = "product_list")]
            Productlist = 10,
            /// <summary>
            /// Enum Productlistwithimages for value: product_list_with_images
            /// </summary>
            [EnumMember(Value = "product_list_with_images")]
            Productlistwithimages = 11,
            /// <summary>
            /// Enum Swatch for value: swatch
            /// </summary>
            [EnumMember(Value = "swatch")]
            Swatch = 12        }
        /// <summary>
        /// BigCommerce API, which determines how it will display on the storefront. Acceptable values: &#x60;date&#x60;, &#x60;checkbox&#x60;, &#x60;file&#x60;, &#x60;text&#x60;, &#x60;multi_line_text&#x60;, &#x60;numbers_only_text&#x60;, &#x60;radio_buttons&#x60;, &#x60;rectangles&#x60;, &#x60;dropdown&#x60;, &#x60;product_list&#x60;, &#x60;product_list_with_images&#x60;, &#x60;swatch&#x60;. Required in a /POST. 
        /// </summary>
        /// <value>BigCommerce API, which determines how it will display on the storefront. Acceptable values: &#x60;date&#x60;, &#x60;checkbox&#x60;, &#x60;file&#x60;, &#x60;text&#x60;, &#x60;multi_line_text&#x60;, &#x60;numbers_only_text&#x60;, &#x60;radio_buttons&#x60;, &#x60;rectangles&#x60;, &#x60;dropdown&#x60;, &#x60;product_list&#x60;, &#x60;product_list_with_images&#x60;, &#x60;swatch&#x60;. Required in a /POST. </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductModifierBase" /> class.
        /// </summary>
        /// <param name="config">config.</param>
        /// <param name="displayName">The name of the option shown on the storefront..</param>
        /// <param name="required">Whether or not this modifer is required or not at checkout. Required in a /POST.  (required).</param>
        /// <param name="sortOrder">The order the modifiers display on the product detail page..</param>
        /// <param name="type">BigCommerce API, which determines how it will display on the storefront. Acceptable values: &#x60;date&#x60;, &#x60;checkbox&#x60;, &#x60;file&#x60;, &#x60;text&#x60;, &#x60;multi_line_text&#x60;, &#x60;numbers_only_text&#x60;, &#x60;radio_buttons&#x60;, &#x60;rectangles&#x60;, &#x60;dropdown&#x60;, &#x60;product_list&#x60;, &#x60;product_list_with_images&#x60;, &#x60;swatch&#x60;. Required in a /POST.  (required).</param>
        public ProductModifierBase(OptionConfig config = default(OptionConfig), string displayName = default(string), bool? required = default(bool?), int? sortOrder = default(int?), TypeEnum type = default(TypeEnum))
        {
            // to ensure "required" is required (not null)
            if (required == null)
            {
                throw new InvalidDataException("required is a required property for ProductModifierBase and cannot be null");
            }
            else
            {
                this.Required = required;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for ProductModifierBase and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.Config = config;
            this.DisplayName = displayName;
            this.SortOrder = sortOrder;
        }
        
        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name="config", EmitDefaultValue=false)]
        public OptionConfig Config { get; set; }

        /// <summary>
        /// The name of the option shown on the storefront.
        /// </summary>
        /// <value>The name of the option shown on the storefront.</value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Whether or not this modifer is required or not at checkout. Required in a /POST. 
        /// </summary>
        /// <value>Whether or not this modifer is required or not at checkout. Required in a /POST. </value>
        [DataMember(Name="required", EmitDefaultValue=false)]
        public bool? Required { get; set; }

        /// <summary>
        /// The order the modifiers display on the product detail page.
        /// </summary>
        /// <value>The order the modifiers display on the product detail page.</value>
        [DataMember(Name="sort_order", EmitDefaultValue=false)]
        public int? SortOrder { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductModifierBase {\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as ProductModifierBase);
        }

        /// <summary>
        /// Returns true if ProductModifierBase instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductModifierBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductModifierBase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Config == input.Config ||
                    (this.Config != null &&
                    this.Config.Equals(input.Config))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Required == input.Required ||
                    (this.Required != null &&
                    this.Required.Equals(input.Required))
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    (this.SortOrder != null &&
                    this.SortOrder.Equals(input.SortOrder))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Config != null)
                    hashCode = hashCode * 59 + this.Config.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Required != null)
                    hashCode = hashCode * 59 + this.Required.GetHashCode();
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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
