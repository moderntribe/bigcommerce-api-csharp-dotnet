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
    /// Common Price Record properties.
    /// </summary>
    [DataContract]
        public partial class PriceRecordBase :  IEquatable<PriceRecordBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PriceRecordBase" /> class.
        /// </summary>
        /// <param name="price">The list price for the variant mapped in a Price List. Overrides any existing or Catalog list price for the variant/product. .</param>
        /// <param name="salePrice">The sale price for the variant mapped in a Price List. Overrides any existing or Catalog sale price for the variant/product. If empty, the sale price will be treated as not being set on this variant. .</param>
        /// <param name="retailPrice">The retail price for the variant mapped in a Price List. Overrides any existing or Catalog retail price for the variant/product.  If empty, the retail price will be treated as not being set on this variant. .</param>
        /// <param name="mapPrice">The MAP (Manufacturer&#x27;s Advertised Price) for the variant mapped in a Price List. Overrides any existing or Catalog MAP price for the variant/product. If empty, the MAP price will be treated as not being set on this variant. .</param>
        /// <param name="bulkPricingTiers">bulkPricingTiers.</param>
        /// <param name="sku">The SKU code associated with this &#x60;Price Record&#x60; if requested and it exists. .</param>
        public PriceRecordBase(double? price = default(double?), double? salePrice = default(double?), double? retailPrice = default(double?), double? mapPrice = default(double?), List<BulkPricingTier> bulkPricingTiers = default(List<BulkPricingTier>), string sku = default(string))
        {
            this.Price = price;
            this.SalePrice = salePrice;
            this.RetailPrice = retailPrice;
            this.MapPrice = mapPrice;
            this.BulkPricingTiers = bulkPricingTiers;
            this.Sku = sku;
        }
        
        /// <summary>
        /// The list price for the variant mapped in a Price List. Overrides any existing or Catalog list price for the variant/product. 
        /// </summary>
        /// <value>The list price for the variant mapped in a Price List. Overrides any existing or Catalog list price for the variant/product. </value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public double? Price { get; set; }

        /// <summary>
        /// The sale price for the variant mapped in a Price List. Overrides any existing or Catalog sale price for the variant/product. If empty, the sale price will be treated as not being set on this variant. 
        /// </summary>
        /// <value>The sale price for the variant mapped in a Price List. Overrides any existing or Catalog sale price for the variant/product. If empty, the sale price will be treated as not being set on this variant. </value>
        [DataMember(Name="sale_price", EmitDefaultValue=false)]
        public double? SalePrice { get; set; }

        /// <summary>
        /// The retail price for the variant mapped in a Price List. Overrides any existing or Catalog retail price for the variant/product.  If empty, the retail price will be treated as not being set on this variant. 
        /// </summary>
        /// <value>The retail price for the variant mapped in a Price List. Overrides any existing or Catalog retail price for the variant/product.  If empty, the retail price will be treated as not being set on this variant. </value>
        [DataMember(Name="retail_price", EmitDefaultValue=false)]
        public double? RetailPrice { get; set; }

        /// <summary>
        /// The MAP (Manufacturer&#x27;s Advertised Price) for the variant mapped in a Price List. Overrides any existing or Catalog MAP price for the variant/product. If empty, the MAP price will be treated as not being set on this variant. 
        /// </summary>
        /// <value>The MAP (Manufacturer&#x27;s Advertised Price) for the variant mapped in a Price List. Overrides any existing or Catalog MAP price for the variant/product. If empty, the MAP price will be treated as not being set on this variant. </value>
        [DataMember(Name="map_price", EmitDefaultValue=false)]
        public double? MapPrice { get; set; }

        /// <summary>
        /// Gets or Sets BulkPricingTiers
        /// </summary>
        [DataMember(Name="bulk_pricing_tiers", EmitDefaultValue=false)]
        public List<BulkPricingTier> BulkPricingTiers { get; set; }

        /// <summary>
        /// The SKU code associated with this &#x60;Price Record&#x60; if requested and it exists. 
        /// </summary>
        /// <value>The SKU code associated with this &#x60;Price Record&#x60; if requested and it exists. </value>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PriceRecordBase {\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  SalePrice: ").Append(SalePrice).Append("\n");
            sb.Append("  RetailPrice: ").Append(RetailPrice).Append("\n");
            sb.Append("  MapPrice: ").Append(MapPrice).Append("\n");
            sb.Append("  BulkPricingTiers: ").Append(BulkPricingTiers).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
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
            return this.Equals(input as PriceRecordBase);
        }

        /// <summary>
        /// Returns true if PriceRecordBase instances are equal
        /// </summary>
        /// <param name="input">Instance of PriceRecordBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PriceRecordBase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.SalePrice == input.SalePrice ||
                    (this.SalePrice != null &&
                    this.SalePrice.Equals(input.SalePrice))
                ) && 
                (
                    this.RetailPrice == input.RetailPrice ||
                    (this.RetailPrice != null &&
                    this.RetailPrice.Equals(input.RetailPrice))
                ) && 
                (
                    this.MapPrice == input.MapPrice ||
                    (this.MapPrice != null &&
                    this.MapPrice.Equals(input.MapPrice))
                ) && 
                (
                    this.BulkPricingTiers == input.BulkPricingTiers ||
                    this.BulkPricingTiers != null &&
                    input.BulkPricingTiers != null &&
                    this.BulkPricingTiers.SequenceEqual(input.BulkPricingTiers)
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
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
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.SalePrice != null)
                    hashCode = hashCode * 59 + this.SalePrice.GetHashCode();
                if (this.RetailPrice != null)
                    hashCode = hashCode * 59 + this.RetailPrice.GetHashCode();
                if (this.MapPrice != null)
                    hashCode = hashCode * 59 + this.MapPrice.GetHashCode();
                if (this.BulkPricingTiers != null)
                    hashCode = hashCode * 59 + this.BulkPricingTiers.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
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
