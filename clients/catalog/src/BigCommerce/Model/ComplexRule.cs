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
    /// Common ComplexRule properties.
    /// </summary>
    [DataContract]
        public partial class ComplexRule :  IEquatable<ComplexRule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexRule" /> class.
        /// </summary>
        /// <param name="conditions">conditions.</param>
        /// <param name="enabled">Flag for determining whether the rule is to be used when adjusting a product&#x27;s price, weight, image, or availabilty. .</param>
        /// <param name="id">The unique numeric ID of the rule; increments sequentially. Read-Only.</param>
        /// <param name="imageUrl">The URL for an image displayed on the storefront when the conditions are applied. Limit of 8MB per file.  .</param>
        /// <param name="priceAdjuster">priceAdjuster.</param>
        /// <param name="productId">The unique numeric ID of the product with which the rule is associated; increments sequentially. .</param>
        /// <param name="purchasingDisabled">Flag for determining whether the rule should disable purchasing of a product when the conditions are applied. .</param>
        /// <param name="purchasingDisabledMessage">Message displayed on the storefront when a rule disables the purchasing of a product. .</param>
        /// <param name="purchasingHidden">Flag for determining whether the rule should hide purchasing of a product when the conditions are applied. .</param>
        /// <param name="sortOrder">The priority to give this rule when making adjustments to the product properties. .</param>
        /// <param name="stop">Flag for determining whether other rules should not be applied after this rule has been applied. .</param>
        /// <param name="weightAdjuster">weightAdjuster.</param>
        public ComplexRule(List<ComplexRuleCondition> conditions = default(List<ComplexRuleCondition>), bool? enabled = default(bool?), int? id = default(int?), string imageUrl = default(string), Adjuster priceAdjuster = default(Adjuster), int? productId = default(int?), bool? purchasingDisabled = default(bool?), string purchasingDisabledMessage = default(string), bool? purchasingHidden = default(bool?), int? sortOrder = default(int?), bool? stop = default(bool?), Adjuster weightAdjuster = default(Adjuster))
        {
            this.Conditions = conditions;
            this.Enabled = enabled;
            this.Id = id;
            this.ImageUrl = imageUrl;
            this.PriceAdjuster = priceAdjuster;
            this.ProductId = productId;
            this.PurchasingDisabled = purchasingDisabled;
            this.PurchasingDisabledMessage = purchasingDisabledMessage;
            this.PurchasingHidden = purchasingHidden;
            this.SortOrder = sortOrder;
            this.Stop = stop;
            this.WeightAdjuster = weightAdjuster;
        }
        
        /// <summary>
        /// Gets or Sets Conditions
        /// </summary>
        [DataMember(Name="conditions", EmitDefaultValue=false)]
        public List<ComplexRuleCondition> Conditions { get; set; }

        /// <summary>
        /// Flag for determining whether the rule is to be used when adjusting a product&#x27;s price, weight, image, or availabilty. 
        /// </summary>
        /// <value>Flag for determining whether the rule is to be used when adjusting a product&#x27;s price, weight, image, or availabilty. </value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The unique numeric ID of the rule; increments sequentially. Read-Only
        /// </summary>
        /// <value>The unique numeric ID of the rule; increments sequentially. Read-Only</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The URL for an image displayed on the storefront when the conditions are applied. Limit of 8MB per file.  
        /// </summary>
        /// <value>The URL for an image displayed on the storefront when the conditions are applied. Limit of 8MB per file.  </value>
        [DataMember(Name="image_url", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Gets or Sets PriceAdjuster
        /// </summary>
        [DataMember(Name="price_adjuster", EmitDefaultValue=false)]
        public Adjuster PriceAdjuster { get; set; }

        /// <summary>
        /// The unique numeric ID of the product with which the rule is associated; increments sequentially. 
        /// </summary>
        /// <value>The unique numeric ID of the product with which the rule is associated; increments sequentially. </value>
        [DataMember(Name="product_id", EmitDefaultValue=false)]
        public int? ProductId { get; set; }

        /// <summary>
        /// Flag for determining whether the rule should disable purchasing of a product when the conditions are applied. 
        /// </summary>
        /// <value>Flag for determining whether the rule should disable purchasing of a product when the conditions are applied. </value>
        [DataMember(Name="purchasing_disabled", EmitDefaultValue=false)]
        public bool? PurchasingDisabled { get; set; }

        /// <summary>
        /// Message displayed on the storefront when a rule disables the purchasing of a product. 
        /// </summary>
        /// <value>Message displayed on the storefront when a rule disables the purchasing of a product. </value>
        [DataMember(Name="purchasing_disabled_message", EmitDefaultValue=false)]
        public string PurchasingDisabledMessage { get; set; }

        /// <summary>
        /// Flag for determining whether the rule should hide purchasing of a product when the conditions are applied. 
        /// </summary>
        /// <value>Flag for determining whether the rule should hide purchasing of a product when the conditions are applied. </value>
        [DataMember(Name="purchasing_hidden", EmitDefaultValue=false)]
        public bool? PurchasingHidden { get; set; }

        /// <summary>
        /// The priority to give this rule when making adjustments to the product properties. 
        /// </summary>
        /// <value>The priority to give this rule when making adjustments to the product properties. </value>
        [DataMember(Name="sort_order", EmitDefaultValue=false)]
        public int? SortOrder { get; set; }

        /// <summary>
        /// Flag for determining whether other rules should not be applied after this rule has been applied. 
        /// </summary>
        /// <value>Flag for determining whether other rules should not be applied after this rule has been applied. </value>
        [DataMember(Name="stop", EmitDefaultValue=false)]
        public bool? Stop { get; set; }

        /// <summary>
        /// Gets or Sets WeightAdjuster
        /// </summary>
        [DataMember(Name="weight_adjuster", EmitDefaultValue=false)]
        public Adjuster WeightAdjuster { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComplexRule {\n");
            sb.Append("  Conditions: ").Append(Conditions).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  PriceAdjuster: ").Append(PriceAdjuster).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  PurchasingDisabled: ").Append(PurchasingDisabled).Append("\n");
            sb.Append("  PurchasingDisabledMessage: ").Append(PurchasingDisabledMessage).Append("\n");
            sb.Append("  PurchasingHidden: ").Append(PurchasingHidden).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  Stop: ").Append(Stop).Append("\n");
            sb.Append("  WeightAdjuster: ").Append(WeightAdjuster).Append("\n");
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
            return this.Equals(input as ComplexRule);
        }

        /// <summary>
        /// Returns true if ComplexRule instances are equal
        /// </summary>
        /// <param name="input">Instance of ComplexRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ComplexRule input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Conditions == input.Conditions ||
                    this.Conditions != null &&
                    input.Conditions != null &&
                    this.Conditions.SequenceEqual(input.Conditions)
                ) && 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.PriceAdjuster == input.PriceAdjuster ||
                    (this.PriceAdjuster != null &&
                    this.PriceAdjuster.Equals(input.PriceAdjuster))
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.PurchasingDisabled == input.PurchasingDisabled ||
                    (this.PurchasingDisabled != null &&
                    this.PurchasingDisabled.Equals(input.PurchasingDisabled))
                ) && 
                (
                    this.PurchasingDisabledMessage == input.PurchasingDisabledMessage ||
                    (this.PurchasingDisabledMessage != null &&
                    this.PurchasingDisabledMessage.Equals(input.PurchasingDisabledMessage))
                ) && 
                (
                    this.PurchasingHidden == input.PurchasingHidden ||
                    (this.PurchasingHidden != null &&
                    this.PurchasingHidden.Equals(input.PurchasingHidden))
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    (this.SortOrder != null &&
                    this.SortOrder.Equals(input.SortOrder))
                ) && 
                (
                    this.Stop == input.Stop ||
                    (this.Stop != null &&
                    this.Stop.Equals(input.Stop))
                ) && 
                (
                    this.WeightAdjuster == input.WeightAdjuster ||
                    (this.WeightAdjuster != null &&
                    this.WeightAdjuster.Equals(input.WeightAdjuster))
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
                if (this.Conditions != null)
                    hashCode = hashCode * 59 + this.Conditions.GetHashCode();
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.PriceAdjuster != null)
                    hashCode = hashCode * 59 + this.PriceAdjuster.GetHashCode();
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.PurchasingDisabled != null)
                    hashCode = hashCode * 59 + this.PurchasingDisabled.GetHashCode();
                if (this.PurchasingDisabledMessage != null)
                    hashCode = hashCode * 59 + this.PurchasingDisabledMessage.GetHashCode();
                if (this.PurchasingHidden != null)
                    hashCode = hashCode * 59 + this.PurchasingHidden.GetHashCode();
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                if (this.Stop != null)
                    hashCode = hashCode * 59 + this.Stop.GetHashCode();
                if (this.WeightAdjuster != null)
                    hashCode = hashCode * 59 + this.WeightAdjuster.GetHashCode();
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
