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
    /// Adjuster for Complex Rules.
    /// </summary>
    [DataContract]
        public partial class Adjuster :  IEquatable<Adjuster>, IValidatableObject
    {
        /// <summary>
        /// The type of adjuster for either the price or the weight of the variant, when the modifier value is selected on the storefront. 
        /// </summary>
        /// <value>The type of adjuster for either the price or the weight of the variant, when the modifier value is selected on the storefront. </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum AdjusterEnum
        {
            /// <summary>
            /// Enum Relative for value: relative
            /// </summary>
            [EnumMember(Value = "relative")]
            Relative = 1,
            /// <summary>
            /// Enum Percentage for value: percentage
            /// </summary>
            [EnumMember(Value = "percentage")]
            Percentage = 2        }
        /// <summary>
        /// The type of adjuster for either the price or the weight of the variant, when the modifier value is selected on the storefront. 
        /// </summary>
        /// <value>The type of adjuster for either the price or the weight of the variant, when the modifier value is selected on the storefront. </value>
        [DataMember(Name="adjuster", EmitDefaultValue=false)]
        public AdjusterEnum? _Adjuster { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Adjuster" /> class.
        /// </summary>
        /// <param name="adjuster">The type of adjuster for either the price or the weight of the variant, when the modifier value is selected on the storefront. .</param>
        /// <param name="adjusterValue">The numeric amount by which the adjuster will change either the price or the weight of the variant, when the modifier value is selected on the storefront. .</param>
        public Adjuster(AdjusterEnum? adjuster = default(AdjusterEnum?), decimal? adjusterValue = default(decimal?))
        {
            this._Adjuster = adjuster;
            this.AdjusterValue = adjusterValue;
        }
        

        /// <summary>
        /// The numeric amount by which the adjuster will change either the price or the weight of the variant, when the modifier value is selected on the storefront. 
        /// </summary>
        /// <value>The numeric amount by which the adjuster will change either the price or the weight of the variant, when the modifier value is selected on the storefront. </value>
        [DataMember(Name="adjuster_value", EmitDefaultValue=false)]
        public decimal? AdjusterValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Adjuster {\n");
            sb.Append("  _Adjuster: ").Append(_Adjuster).Append("\n");
            sb.Append("  AdjusterValue: ").Append(AdjusterValue).Append("\n");
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
            return this.Equals(input as Adjuster);
        }

        /// <summary>
        /// Returns true if Adjuster instances are equal
        /// </summary>
        /// <param name="input">Instance of Adjuster to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Adjuster input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._Adjuster == input._Adjuster ||
                    (this._Adjuster != null &&
                    this._Adjuster.Equals(input._Adjuster))
                ) && 
                (
                    this.AdjusterValue == input.AdjusterValue ||
                    (this.AdjusterValue != null &&
                    this.AdjusterValue.Equals(input.AdjusterValue))
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
                if (this._Adjuster != null)
                    hashCode = hashCode * 59 + this._Adjuster.GetHashCode();
                if (this.AdjusterValue != null)
                    hashCode = hashCode * 59 + this.AdjusterValue.GetHashCode();
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
