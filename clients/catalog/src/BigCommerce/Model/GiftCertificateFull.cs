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
    /// A gift-certificate model.
    /// </summary>
    [DataContract]
        public partial class GiftCertificateFull :  IEquatable<GiftCertificateFull>, IValidatableObject
    {
        /// <summary>
        /// The status of a gift certificate: &#x60;active&#x60; - gift certificate is active; &#x60;pending&#x60; - gift certificate purchase is pending; &#x60;disabled&#x60; - gift certificate is disabled; &#x60;expired&#x60; - gift certificate is expired. 
        /// </summary>
        /// <value>The status of a gift certificate: &#x60;active&#x60; - gift certificate is active; &#x60;pending&#x60; - gift certificate purchase is pending; &#x60;disabled&#x60; - gift certificate is disabled; &#x60;expired&#x60; - gift certificate is expired. </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum StatusEnum
        {
            /// <summary>
            /// Enum Active for value: active
            /// </summary>
            [EnumMember(Value = "active")]
            Active = 1,
            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending = 2,
            /// <summary>
            /// Enum Disabled for value: disabled
            /// </summary>
            [EnumMember(Value = "disabled")]
            Disabled = 3,
            /// <summary>
            /// Enum Expired for value: expired
            /// </summary>
            [EnumMember(Value = "expired")]
            Expired = 4        }
        /// <summary>
        /// The status of a gift certificate: &#x60;active&#x60; - gift certificate is active; &#x60;pending&#x60; - gift certificate purchase is pending; &#x60;disabled&#x60; - gift certificate is disabled; &#x60;expired&#x60; - gift certificate is expired. 
        /// </summary>
        /// <value>The status of a gift certificate: &#x60;active&#x60; - gift certificate is active; &#x60;pending&#x60; - gift certificate purchase is pending; &#x60;disabled&#x60; - gift certificate is disabled; &#x60;expired&#x60; - gift certificate is expired. </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GiftCertificateFull" /> class.
        /// </summary>
        /// <param name="code">The gift-certificate code. .</param>
        /// <param name="originalBalance">The balance on a gift certificate when it was purchased. .</param>
        /// <param name="remainingBalance">The remaining balance on a gift certificate. .</param>
        /// <param name="startingBalance">The balance on a gift certificate at the time of this purchase. .</param>
        /// <param name="status">The status of a gift certificate: &#x60;active&#x60; - gift certificate is active; &#x60;pending&#x60; - gift certificate purchase is pending; &#x60;disabled&#x60; - gift certificate is disabled; &#x60;expired&#x60; - gift certificate is expired. .</param>
        public GiftCertificateFull(string code = default(string), float? originalBalance = default(float?), float? remainingBalance = default(float?), float? startingBalance = default(float?), StatusEnum? status = default(StatusEnum?))
        {
            this.Code = code;
            this.OriginalBalance = originalBalance;
            this.RemainingBalance = remainingBalance;
            this.StartingBalance = startingBalance;
            this.Status = status;
        }
        
        /// <summary>
        /// The gift-certificate code. 
        /// </summary>
        /// <value>The gift-certificate code. </value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// The balance on a gift certificate when it was purchased. 
        /// </summary>
        /// <value>The balance on a gift certificate when it was purchased. </value>
        [DataMember(Name="original_balance", EmitDefaultValue=false)]
        public float? OriginalBalance { get; set; }

        /// <summary>
        /// The remaining balance on a gift certificate. 
        /// </summary>
        /// <value>The remaining balance on a gift certificate. </value>
        [DataMember(Name="remaining_balance", EmitDefaultValue=false)]
        public float? RemainingBalance { get; set; }

        /// <summary>
        /// The balance on a gift certificate at the time of this purchase. 
        /// </summary>
        /// <value>The balance on a gift certificate at the time of this purchase. </value>
        [DataMember(Name="starting_balance", EmitDefaultValue=false)]
        public float? StartingBalance { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GiftCertificateFull {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  OriginalBalance: ").Append(OriginalBalance).Append("\n");
            sb.Append("  RemainingBalance: ").Append(RemainingBalance).Append("\n");
            sb.Append("  StartingBalance: ").Append(StartingBalance).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as GiftCertificateFull);
        }

        /// <summary>
        /// Returns true if GiftCertificateFull instances are equal
        /// </summary>
        /// <param name="input">Instance of GiftCertificateFull to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GiftCertificateFull input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.OriginalBalance == input.OriginalBalance ||
                    (this.OriginalBalance != null &&
                    this.OriginalBalance.Equals(input.OriginalBalance))
                ) && 
                (
                    this.RemainingBalance == input.RemainingBalance ||
                    (this.RemainingBalance != null &&
                    this.RemainingBalance.Equals(input.RemainingBalance))
                ) && 
                (
                    this.StartingBalance == input.StartingBalance ||
                    (this.StartingBalance != null &&
                    this.StartingBalance.Equals(input.StartingBalance))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.OriginalBalance != null)
                    hashCode = hashCode * 59 + this.OriginalBalance.GetHashCode();
                if (this.RemainingBalance != null)
                    hashCode = hashCode * 59 + this.RemainingBalance.GetHashCode();
                if (this.StartingBalance != null)
                    hashCode = hashCode * 59 + this.StartingBalance.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
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
