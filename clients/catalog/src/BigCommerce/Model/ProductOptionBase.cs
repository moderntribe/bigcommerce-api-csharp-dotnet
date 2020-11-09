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
    /// Common Option properties.
    /// </summary>
    [DataContract]
        public partial class ProductOptionBase :  IEquatable<ProductOptionBase>, IValidatableObject
    {
        /// <summary>
        /// The type of option, which determines how it will display on the storefront. Acceptable values: &#x60;radio_buttons&#x60;, &#x60;rectangles&#x60;, &#x60;dropdown&#x60;, &#x60;product_list&#x60;, &#x60;product_list_with_images&#x60;, &#x60;swatch&#x60;. For reference, the former v2 API values are: RB &#x3D; radio_buttons, RT &#x3D; rectangles, S &#x3D; dropdown, P &#x3D; product_list, PI &#x3D; product_list_with_images, CS &#x3D; swatch. 
        /// </summary>
        /// <value>The type of option, which determines how it will display on the storefront. Acceptable values: &#x60;radio_buttons&#x60;, &#x60;rectangles&#x60;, &#x60;dropdown&#x60;, &#x60;product_list&#x60;, &#x60;product_list_with_images&#x60;, &#x60;swatch&#x60;. For reference, the former v2 API values are: RB &#x3D; radio_buttons, RT &#x3D; rectangles, S &#x3D; dropdown, P &#x3D; product_list, PI &#x3D; product_list_with_images, CS &#x3D; swatch. </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Radiobuttons for value: radio_buttons
            /// </summary>
            [EnumMember(Value = "radio_buttons")]
            Radiobuttons = 1,
            /// <summary>
            /// Enum Rectangles for value: rectangles
            /// </summary>
            [EnumMember(Value = "rectangles")]
            Rectangles = 2,
            /// <summary>
            /// Enum Dropdown for value: dropdown
            /// </summary>
            [EnumMember(Value = "dropdown")]
            Dropdown = 3,
            /// <summary>
            /// Enum Productlist for value: product_list
            /// </summary>
            [EnumMember(Value = "product_list")]
            Productlist = 4,
            /// <summary>
            /// Enum Productlistwithimages for value: product_list_with_images
            /// </summary>
            [EnumMember(Value = "product_list_with_images")]
            Productlistwithimages = 5,
            /// <summary>
            /// Enum Swatch for value: swatch
            /// </summary>
            [EnumMember(Value = "swatch")]
            Swatch = 6        }
        /// <summary>
        /// The type of option, which determines how it will display on the storefront. Acceptable values: &#x60;radio_buttons&#x60;, &#x60;rectangles&#x60;, &#x60;dropdown&#x60;, &#x60;product_list&#x60;, &#x60;product_list_with_images&#x60;, &#x60;swatch&#x60;. For reference, the former v2 API values are: RB &#x3D; radio_buttons, RT &#x3D; rectangles, S &#x3D; dropdown, P &#x3D; product_list, PI &#x3D; product_list_with_images, CS &#x3D; swatch. 
        /// </summary>
        /// <value>The type of option, which determines how it will display on the storefront. Acceptable values: &#x60;radio_buttons&#x60;, &#x60;rectangles&#x60;, &#x60;dropdown&#x60;, &#x60;product_list&#x60;, &#x60;product_list_with_images&#x60;, &#x60;swatch&#x60;. For reference, the former v2 API values are: RB &#x3D; radio_buttons, RT &#x3D; rectangles, S &#x3D; dropdown, P &#x3D; product_list, PI &#x3D; product_list_with_images, CS &#x3D; swatch. </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductOptionBase" /> class.
        /// </summary>
        /// <param name="config">config.</param>
        /// <param name="displayName">The name of the option shown on the storefront. .</param>
        /// <param name="id">The unique numerical ID of the option, increments sequentially. .</param>
        /// <param name="optionValues">Product Option &#x60;option_value&#x60;..</param>
        /// <param name="productId">The unique numerical ID of the product to which the option belongs. .</param>
        /// <param name="sortOrder">Order in which the option is displayed on the storefront. .</param>
        /// <param name="type">The type of option, which determines how it will display on the storefront. Acceptable values: &#x60;radio_buttons&#x60;, &#x60;rectangles&#x60;, &#x60;dropdown&#x60;, &#x60;product_list&#x60;, &#x60;product_list_with_images&#x60;, &#x60;swatch&#x60;. For reference, the former v2 API values are: RB &#x3D; radio_buttons, RT &#x3D; rectangles, S &#x3D; dropdown, P &#x3D; product_list, PI &#x3D; product_list_with_images, CS &#x3D; swatch. .</param>
        public ProductOptionBase(OptionConfig config = default(OptionConfig), string displayName = default(string), int? id = default(int?), AllOfproductOptionBaseOptionValues optionValues = default(AllOfproductOptionBaseOptionValues), int? productId = default(int?), int? sortOrder = default(int?), TypeEnum? type = default(TypeEnum?))
        {
            this.Config = config;
            this.DisplayName = displayName;
            this.Id = id;
            this.OptionValues = optionValues;
            this.ProductId = productId;
            this.SortOrder = sortOrder;
            this.Type = type;
        }
        
        /// <summary>
        /// Gets or Sets Config
        /// </summary>
        [DataMember(Name="config", EmitDefaultValue=false)]
        public OptionConfig Config { get; set; }

        /// <summary>
        /// The name of the option shown on the storefront. 
        /// </summary>
        /// <value>The name of the option shown on the storefront. </value>
        [DataMember(Name="display_name", EmitDefaultValue=false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The unique numerical ID of the option, increments sequentially. 
        /// </summary>
        /// <value>The unique numerical ID of the option, increments sequentially. </value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Product Option &#x60;option_value&#x60;.
        /// </summary>
        /// <value>Product Option &#x60;option_value&#x60;.</value>
        [DataMember(Name="option_values", EmitDefaultValue=false)]
        public AllOfproductOptionBaseOptionValues OptionValues { get; set; }

        /// <summary>
        /// The unique numerical ID of the product to which the option belongs. 
        /// </summary>
        /// <value>The unique numerical ID of the product to which the option belongs. </value>
        [DataMember(Name="product_id", EmitDefaultValue=false)]
        public int? ProductId { get; set; }

        /// <summary>
        /// Order in which the option is displayed on the storefront. 
        /// </summary>
        /// <value>Order in which the option is displayed on the storefront. </value>
        [DataMember(Name="sort_order", EmitDefaultValue=false)]
        public int? SortOrder { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductOptionBase {\n");
            sb.Append("  Config: ").Append(Config).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OptionValues: ").Append(OptionValues).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
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
            return this.Equals(input as ProductOptionBase);
        }

        /// <summary>
        /// Returns true if ProductOptionBase instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductOptionBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductOptionBase input)
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
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.OptionValues == input.OptionValues ||
                    (this.OptionValues != null &&
                    this.OptionValues.Equals(input.OptionValues))
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.OptionValues != null)
                    hashCode = hashCode * 59 + this.OptionValues.GetHashCode();
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
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
