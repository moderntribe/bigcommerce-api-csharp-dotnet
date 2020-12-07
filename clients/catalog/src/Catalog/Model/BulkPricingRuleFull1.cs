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
    /// Common Bulk Pricing Rule properties
    /// </summary>
    [DataContract]
        public partial class BulkPricingRuleFull1 :  IEquatable<BulkPricingRuleFull1>, IValidatableObject
    {
        /// <summary>
        /// The type of adjustment that is made. Values: &#x60;price&#x60; - the adjustment amount per product; &#x60;percent&#x60; - the adjustment as a percentage of the original price; &#x60;fixed&#x60; - the adjusted absolute price of the product. Required in /POST.
        /// </summary>
        /// <value>The type of adjustment that is made. Values: &#x60;price&#x60; - the adjustment amount per product; &#x60;percent&#x60; - the adjustment as a percentage of the original price; &#x60;fixed&#x60; - the adjusted absolute price of the product. Required in /POST.</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Price for value: price
            /// </summary>
            [EnumMember(Value = "price")]
            Price = 1,
            /// <summary>
            /// Enum Percent for value: percent
            /// </summary>
            [EnumMember(Value = "percent")]
            Percent = 2,
            /// <summary>
            /// Enum Fixed for value: fixed
            /// </summary>
            [EnumMember(Value = "fixed")]
            Fixed = 3        }
        /// <summary>
        /// The type of adjustment that is made. Values: &#x60;price&#x60; - the adjustment amount per product; &#x60;percent&#x60; - the adjustment as a percentage of the original price; &#x60;fixed&#x60; - the adjusted absolute price of the product. Required in /POST.
        /// </summary>
        /// <value>The type of adjustment that is made. Values: &#x60;price&#x60; - the adjustment amount per product; &#x60;percent&#x60; - the adjustment as a percentage of the original price; &#x60;fixed&#x60; - the adjusted absolute price of the product. Required in /POST.</value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkPricingRuleFull1" /> class.
        /// </summary>
        /// <param name="amount">The discount can be a fixed dollar amount or a percentage. For a fixed dollar amount enter it as an integer and the response will return as an integer. For percentage enter the amount as the percentage divided by 100 using string format. For example 10% percent would be “.10”. The response will return as an integer. Required in /POST. (required).</param>
        /// <param name="id">Unique ID of the *Bulk Pricing Rule*. Read-Only..</param>
        /// <param name="quantityMax">The maximum inclusive quantity of a product to satisfy this rule. Must be greater than the &#x60;quantity_min&#x60; value – unless this field has a value of 0 (zero), in which case there will be no maximum bound for this rule. Required in /POST. (required).</param>
        /// <param name="quantityMin">The minimum inclusive quantity of a product to satisfy this rule. Must be greater than or equal to zero. Required in /POST.  (required).</param>
        /// <param name="type">The type of adjustment that is made. Values: &#x60;price&#x60; - the adjustment amount per product; &#x60;percent&#x60; - the adjustment as a percentage of the original price; &#x60;fixed&#x60; - the adjusted absolute price of the product. Required in /POST. (required).</param>
        public BulkPricingRuleFull1(int? amount = default(int?), int? id = default(int?), int? quantityMax = default(int?), int? quantityMin = default(int?), TypeEnum type = default(TypeEnum))
        {
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for BulkPricingRuleFull1 and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }
            // to ensure "quantityMax" is required (not null)
            if (quantityMax == null)
            {
                throw new InvalidDataException("quantityMax is a required property for BulkPricingRuleFull1 and cannot be null");
            }
            else
            {
                this.QuantityMax = quantityMax;
            }
            // to ensure "quantityMin" is required (not null)
            if (quantityMin == null)
            {
                throw new InvalidDataException("quantityMin is a required property for BulkPricingRuleFull1 and cannot be null");
            }
            else
            {
                this.QuantityMin = quantityMin;
            }
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for BulkPricingRuleFull1 and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            this.Id = id;
        }
        
        /// <summary>
        /// The discount can be a fixed dollar amount or a percentage. For a fixed dollar amount enter it as an integer and the response will return as an integer. For percentage enter the amount as the percentage divided by 100 using string format. For example 10% percent would be “.10”. The response will return as an integer. Required in /POST.
        /// </summary>
        /// <value>The discount can be a fixed dollar amount or a percentage. For a fixed dollar amount enter it as an integer and the response will return as an integer. For percentage enter the amount as the percentage divided by 100 using string format. For example 10% percent would be “.10”. The response will return as an integer. Required in /POST.</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public int? Amount { get; set; }

        /// <summary>
        /// Unique ID of the *Bulk Pricing Rule*. Read-Only.
        /// </summary>
        /// <value>Unique ID of the *Bulk Pricing Rule*. Read-Only.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The maximum inclusive quantity of a product to satisfy this rule. Must be greater than the &#x60;quantity_min&#x60; value – unless this field has a value of 0 (zero), in which case there will be no maximum bound for this rule. Required in /POST.
        /// </summary>
        /// <value>The maximum inclusive quantity of a product to satisfy this rule. Must be greater than the &#x60;quantity_min&#x60; value – unless this field has a value of 0 (zero), in which case there will be no maximum bound for this rule. Required in /POST.</value>
        [DataMember(Name="quantity_max", EmitDefaultValue=false)]
        public int? QuantityMax { get; set; }

        /// <summary>
        /// The minimum inclusive quantity of a product to satisfy this rule. Must be greater than or equal to zero. Required in /POST. 
        /// </summary>
        /// <value>The minimum inclusive quantity of a product to satisfy this rule. Must be greater than or equal to zero. Required in /POST. </value>
        [DataMember(Name="quantity_min", EmitDefaultValue=false)]
        public int? QuantityMin { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkPricingRuleFull1 {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  QuantityMax: ").Append(QuantityMax).Append("\n");
            sb.Append("  QuantityMin: ").Append(QuantityMin).Append("\n");
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
            return this.Equals(input as BulkPricingRuleFull1);
        }

        /// <summary>
        /// Returns true if BulkPricingRuleFull1 instances are equal
        /// </summary>
        /// <param name="input">Instance of BulkPricingRuleFull1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkPricingRuleFull1 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.QuantityMax == input.QuantityMax ||
                    (this.QuantityMax != null &&
                    this.QuantityMax.Equals(input.QuantityMax))
                ) && 
                (
                    this.QuantityMin == input.QuantityMin ||
                    (this.QuantityMin != null &&
                    this.QuantityMin.Equals(input.QuantityMin))
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
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.QuantityMax != null)
                    hashCode = hashCode * 59 + this.QuantityMax.GetHashCode();
                if (this.QuantityMin != null)
                    hashCode = hashCode * 59 + this.QuantityMin.GetHashCode();
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
