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
    /// Complex rules may return with conditions that apply to one or more variants, or with a single modifier value (if the rules were created using the v2 API or the control panel). Complex rules created or updated in the v3 API must have conditions that either reference multiple &#x60;modifier_value_id&#x60;&#x27;s, or else reference a &#x60;modifier_value_id&#x60; and a &#x60;variant_id&#x60;.
    /// </summary>
    [DataContract]
        public partial class ComplexRuleConditionBase :  IEquatable<ComplexRuleConditionBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ComplexRuleConditionBase" /> class.
        /// </summary>
        /// <param name="combinationId">(READ-ONLY:) The unique numeric ID of the SKU (v2 API), or Combination, with which the rule condition is associated. This is to maintain cross-compatibility between v2 and v3. .</param>
        /// <param name="id">The unique numeric ID of the rule condition; increments sequentially. Read-Only .</param>
        /// <param name="modifierId">The unique numeric ID of the modifier with which the rule condition is associated. Required in /POST. (required).</param>
        /// <param name="modifierValueId">The unique numeric ID of the modifier value with which the rule condition is associated. Required in /POST. (required).</param>
        /// <param name="ruleId">The unique numeric ID of the rule with which the condition is associated. Read-Only.</param>
        /// <param name="variantId">The unique numeric ID of the variant with which the rule condition is associated. Required in /POST. (required).</param>
        public ComplexRuleConditionBase(int? combinationId = default(int?), int? id = default(int?), int? modifierId = default(int?), int? modifierValueId = default(int?), int? ruleId = default(int?), int? variantId = default(int?))
        {
            // to ensure "modifierId" is required (not null)
            if (modifierId == null)
            {
                throw new InvalidDataException("modifierId is a required property for ComplexRuleConditionBase and cannot be null");
            }
            else
            {
                this.ModifierId = modifierId;
            }
            // to ensure "modifierValueId" is required (not null)
            if (modifierValueId == null)
            {
                throw new InvalidDataException("modifierValueId is a required property for ComplexRuleConditionBase and cannot be null");
            }
            else
            {
                this.ModifierValueId = modifierValueId;
            }
            // to ensure "variantId" is required (not null)
            if (variantId == null)
            {
                throw new InvalidDataException("variantId is a required property for ComplexRuleConditionBase and cannot be null");
            }
            else
            {
                this.VariantId = variantId;
            }
            this.CombinationId = combinationId;
            this.Id = id;
            this.RuleId = ruleId;
        }
        
        /// <summary>
        /// (READ-ONLY:) The unique numeric ID of the SKU (v2 API), or Combination, with which the rule condition is associated. This is to maintain cross-compatibility between v2 and v3. 
        /// </summary>
        /// <value>(READ-ONLY:) The unique numeric ID of the SKU (v2 API), or Combination, with which the rule condition is associated. This is to maintain cross-compatibility between v2 and v3. </value>
        [DataMember(Name="combination_id", EmitDefaultValue=false)]
        public int? CombinationId { get; set; }

        /// <summary>
        /// The unique numeric ID of the rule condition; increments sequentially. Read-Only 
        /// </summary>
        /// <value>The unique numeric ID of the rule condition; increments sequentially. Read-Only </value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The unique numeric ID of the modifier with which the rule condition is associated. Required in /POST.
        /// </summary>
        /// <value>The unique numeric ID of the modifier with which the rule condition is associated. Required in /POST.</value>
        [DataMember(Name="modifier_id", EmitDefaultValue=false)]
        public int? ModifierId { get; set; }

        /// <summary>
        /// The unique numeric ID of the modifier value with which the rule condition is associated. Required in /POST.
        /// </summary>
        /// <value>The unique numeric ID of the modifier value with which the rule condition is associated. Required in /POST.</value>
        [DataMember(Name="modifier_value_id", EmitDefaultValue=false)]
        public int? ModifierValueId { get; set; }

        /// <summary>
        /// The unique numeric ID of the rule with which the condition is associated. Read-Only
        /// </summary>
        /// <value>The unique numeric ID of the rule with which the condition is associated. Read-Only</value>
        [DataMember(Name="rule_id", EmitDefaultValue=false)]
        public int? RuleId { get; set; }

        /// <summary>
        /// The unique numeric ID of the variant with which the rule condition is associated. Required in /POST.
        /// </summary>
        /// <value>The unique numeric ID of the variant with which the rule condition is associated. Required in /POST.</value>
        [DataMember(Name="variant_id", EmitDefaultValue=false)]
        public int? VariantId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ComplexRuleConditionBase {\n");
            sb.Append("  CombinationId: ").Append(CombinationId).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ModifierId: ").Append(ModifierId).Append("\n");
            sb.Append("  ModifierValueId: ").Append(ModifierValueId).Append("\n");
            sb.Append("  RuleId: ").Append(RuleId).Append("\n");
            sb.Append("  VariantId: ").Append(VariantId).Append("\n");
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
            return this.Equals(input as ComplexRuleConditionBase);
        }

        /// <summary>
        /// Returns true if ComplexRuleConditionBase instances are equal
        /// </summary>
        /// <param name="input">Instance of ComplexRuleConditionBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ComplexRuleConditionBase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CombinationId == input.CombinationId ||
                    (this.CombinationId != null &&
                    this.CombinationId.Equals(input.CombinationId))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ModifierId == input.ModifierId ||
                    (this.ModifierId != null &&
                    this.ModifierId.Equals(input.ModifierId))
                ) && 
                (
                    this.ModifierValueId == input.ModifierValueId ||
                    (this.ModifierValueId != null &&
                    this.ModifierValueId.Equals(input.ModifierValueId))
                ) && 
                (
                    this.RuleId == input.RuleId ||
                    (this.RuleId != null &&
                    this.RuleId.Equals(input.RuleId))
                ) && 
                (
                    this.VariantId == input.VariantId ||
                    (this.VariantId != null &&
                    this.VariantId.Equals(input.VariantId))
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
                if (this.CombinationId != null)
                    hashCode = hashCode * 59 + this.CombinationId.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ModifierId != null)
                    hashCode = hashCode * 59 + this.ModifierId.GetHashCode();
                if (this.ModifierValueId != null)
                    hashCode = hashCode * 59 + this.ModifierValueId.GetHashCode();
                if (this.RuleId != null)
                    hashCode = hashCode * 59 + this.RuleId.GetHashCode();
                if (this.VariantId != null)
                    hashCode = hashCode * 59 + this.VariantId.GetHashCode();
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
