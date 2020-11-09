/* 
 * Price Lists
 *
 * Populate different versions of catalog pricing and assign them to different [customer groups](/api-reference/customer-subscribers/customers-api) at the variant level.  - [Authentication](#authentication) - [Price Lists](#price-lists) - [Price list assignments](#price-list-assignments) - [Usage notes](#usage-notes) - [Additional information](#additional-information)  ## Authentication  Authenticate requests by including an [OAuth](https://developer.bigcommerce.com/api-docs/getting-started/authentication) `access_token` in the request headers.  ```http GET https://api.bigcommerce.com/stores/{{STORE_HASH}}/v3/{{ENDPOINT}} Content-Type: application/json X-Auth-Token: {{ACCESS_TOKEN}} ```  ### OAuth Scopes  | UI Name                                      | Permission | Parameter                                     | |- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- --| | Products                                     | modify     | `store_v2_products`                           | | Products                                     | read-only  | `store_v2_products_read_only`                 |  ## Price Lists  The association of a Price List to a Customer Group can be done either via the Control Panel or using the [Customer Groups API.](/api-reference/customer-subscribers/customers-api)  Additionally, [Price List Assignments](https://developer.bigcommerce.com/api-reference/store-management/price-lists/price-lists-records/) can be created to assign Price Lists to a specific [Channel](https://developer.bigcommerce.com/api-reference/cart-checkout/channels-listings-api). Price lists assigned to a channel apply to all shoppers on that channel, unless there is a more specific assignment.  If an active Price List does not contain prices for a variant then the Catalog pricing will be used. The association of a Price List to a Customer Group can be done either via the Control Panel or using the [Customer Groups API.](/api-reference/customer-subscribers/customers-api)  Price Lists will provide overridden price values to the Stencil storefront. Final price display can be further customized within the Stencil template. See the [Price Object](https://stencil.bigcommerce.com/docs/price-object-properties) in Stencil for further documentation.  To learn more about Price Lists, see [here](/api-docs/price-lists/price-list-overview).  ## Price list assignments  ### Order of operations  The `Price List Assignment` Pricing Order of Operations is as follows:  **IF** `Price list` assigned to current `Customer Group` **AND** `Price List` assigned to current `Channel`: * Use this Price List - - any prices not found fall back to the catalog price (or in the case of multi-currency, auto-converted prices)  **ELSE IF**: `Price List` assigned to current `Channel`: * Use this price list - - any prices not found fall back to the catalog price (or in the case of multi-currency, auto-converted prices)  **ELSE IF** `Price List` assigned to current `Customer Group`: * Use this price list - - any prices not found fall back to the catalog price (or in the case of multi-currency, auto-converted prices)  **ELSE IF** `Customer Group Discounts`: * Use them - - any prices not found fall back to the catalog price (or in the case of multi-currency, auto-converted prices)  **ELSE IF** `channel` has a `default price list`: * Use this price list - - any prices not found fall back to the catalog price (or in the case of multi-currency, auto-converted prices)  **ELSE**: * Fall back to the catalog price (or in the case of multi-currency, auto-converted prices)  **Note:** Price Lists cannot be assigned to a customer group that has custom group discounts - - the customer group discounts must be deleted first.  ## Usage notes - Price Lists cannot be assigned to a customer group that has custom group discounts - - the customer group discounts must be deleted first. - Bulk pricing Tiers may additionally be associated with a price record to indicate different pricing as the quantity in cart increases. - If a variant has a `Price Record` any existing product-level bulk pricing will not apply in the cart. For variants without `Price Records`, any existing product bulk pricing will apply. - Price Lists Records accepts bulk upsert. Only one [Bulk upsert](https://developer.bigcommerce.com/api-reference/catalog/pricelists-api/price-lists-records/setpricelistrecordcollection) can done at a time. Running more than one in parallel on the **same store** will cause a 429 error and the request will fail. - There are no direct webhooks available for Price Lists. Since Price Lists directly relate to products, webhooks related to products will fire for corresponding changes such as pricing.  ## Additional information  ### Webhooks  * [Products](/api-docs/getting-started/webhooks/webhook-events#webhook-events_products) * [SKU](/api-docs/getting-started/webhooks/webhook-events#webhook-events_sku)  ### Related endpoints * [Get Price List Collection](/api-reference/catalog/pricelists-api/price-lists/getpricelistcollection)
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
using SwaggerDateConverter = PriceLists.Client.SwaggerDateConverter;

namespace PriceLists.Model
{
    /// <summary>
    /// BulkPricingTier
    /// </summary>
    [DataContract]
        public partial class BulkPricingTier :  IEquatable<BulkPricingTier>, IValidatableObject
    {
        /// <summary>
        /// The type of adjustment that is made. Acceptable values: price – the adjustment amount per product; percent – the adjustment as a percentage of the original price; fixed – the adjusted absolute price of the product. 
        /// </summary>
        /// <value>The type of adjustment that is made. Acceptable values: price – the adjustment amount per product; percent – the adjustment as a percentage of the original price; fixed – the adjusted absolute price of the product. </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Fixed for value: fixed
            /// </summary>
            [EnumMember(Value = "fixed")]
            Fixed = 1,
            /// <summary>
            /// Enum Price for value: price
            /// </summary>
            [EnumMember(Value = "price")]
            Price = 2,
            /// <summary>
            /// Enum Percent for value: percent
            /// </summary>
            [EnumMember(Value = "percent")]
            Percent = 3        }
        /// <summary>
        /// The type of adjustment that is made. Acceptable values: price – the adjustment amount per product; percent – the adjustment as a percentage of the original price; fixed – the adjusted absolute price of the product. 
        /// </summary>
        /// <value>The type of adjustment that is made. Acceptable values: price – the adjustment amount per product; percent – the adjustment as a percentage of the original price; fixed – the adjusted absolute price of the product. </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BulkPricingTier" /> class.
        /// </summary>
        /// <param name="quantityMin">The minimum quantity of associated variant in the cart needed to qualify for this tiers pricing. .</param>
        /// <param name="quantityMax">The maximum allowed quantity of associated variant in the cart to qualify for this tiers pricing. .</param>
        /// <param name="type">The type of adjustment that is made. Acceptable values: price – the adjustment amount per product; percent – the adjustment as a percentage of the original price; fixed – the adjusted absolute price of the product. .</param>
        /// <param name="amount">The price adjustment amount. This value along with the type will decide the price per variant for the pricing tier. .</param>
        public BulkPricingTier(int? quantityMin = default(int?), int? quantityMax = default(int?), TypeEnum? type = default(TypeEnum?), double? amount = default(double?))
        {
            this.QuantityMin = quantityMin;
            this.QuantityMax = quantityMax;
            this.Type = type;
            this.Amount = amount;
        }
        
        /// <summary>
        /// The minimum quantity of associated variant in the cart needed to qualify for this tiers pricing. 
        /// </summary>
        /// <value>The minimum quantity of associated variant in the cart needed to qualify for this tiers pricing. </value>
        [DataMember(Name="quantity_min", EmitDefaultValue=false)]
        public int? QuantityMin { get; set; }

        /// <summary>
        /// The maximum allowed quantity of associated variant in the cart to qualify for this tiers pricing. 
        /// </summary>
        /// <value>The maximum allowed quantity of associated variant in the cart to qualify for this tiers pricing. </value>
        [DataMember(Name="quantity_max", EmitDefaultValue=false)]
        public int? QuantityMax { get; set; }


        /// <summary>
        /// The price adjustment amount. This value along with the type will decide the price per variant for the pricing tier. 
        /// </summary>
        /// <value>The price adjustment amount. This value along with the type will decide the price per variant for the pricing tier. </value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public double? Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BulkPricingTier {\n");
            sb.Append("  QuantityMin: ").Append(QuantityMin).Append("\n");
            sb.Append("  QuantityMax: ").Append(QuantityMax).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(input as BulkPricingTier);
        }

        /// <summary>
        /// Returns true if BulkPricingTier instances are equal
        /// </summary>
        /// <param name="input">Instance of BulkPricingTier to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BulkPricingTier input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.QuantityMin == input.QuantityMin ||
                    (this.QuantityMin != null &&
                    this.QuantityMin.Equals(input.QuantityMin))
                ) && 
                (
                    this.QuantityMax == input.QuantityMax ||
                    (this.QuantityMax != null &&
                    this.QuantityMax.Equals(input.QuantityMax))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
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
                if (this.QuantityMin != null)
                    hashCode = hashCode * 59 + this.QuantityMin.GetHashCode();
                if (this.QuantityMax != null)
                    hashCode = hashCode * 59 + this.QuantityMax.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Amount != null)
                    hashCode = hashCode * 59 + this.Amount.GetHashCode();
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
