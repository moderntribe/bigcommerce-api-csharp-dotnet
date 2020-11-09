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
    /// Data about the response, including pagination and collection totals.
    /// </summary>
    [DataContract]
        public partial class Pagination1 :  IEquatable<Pagination1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Pagination1" /> class.
        /// </summary>
        /// <param name="total">Total number of items in the result set. .</param>
        /// <param name="count">Total number of items in the collection response. .</param>
        /// <param name="perPage">The amount of items returned in the collection per page, controlled by the limit parameter. .</param>
        /// <param name="currentPage">The page you are currently on within the collection. .</param>
        /// <param name="totalPages">The total number of pages in the collection. .</param>
        /// <param name="links">links.</param>
        public Pagination1(int? total = default(int?), int? count = default(int?), int? perPage = default(int?), int? currentPage = default(int?), int? totalPages = default(int?), Pagination1Links links = default(Pagination1Links))
        {
            this.Total = total;
            this.Count = count;
            this.PerPage = perPage;
            this.CurrentPage = currentPage;
            this.TotalPages = totalPages;
            this.Links = links;
        }
        
        /// <summary>
        /// Total number of items in the result set. 
        /// </summary>
        /// <value>Total number of items in the result set. </value>
        [DataMember(Name="total", EmitDefaultValue=false)]
        public int? Total { get; set; }

        /// <summary>
        /// Total number of items in the collection response. 
        /// </summary>
        /// <value>Total number of items in the collection response. </value>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }

        /// <summary>
        /// The amount of items returned in the collection per page, controlled by the limit parameter. 
        /// </summary>
        /// <value>The amount of items returned in the collection per page, controlled by the limit parameter. </value>
        [DataMember(Name="per_page", EmitDefaultValue=false)]
        public int? PerPage { get; set; }

        /// <summary>
        /// The page you are currently on within the collection. 
        /// </summary>
        /// <value>The page you are currently on within the collection. </value>
        [DataMember(Name="current_page", EmitDefaultValue=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The total number of pages in the collection. 
        /// </summary>
        /// <value>The total number of pages in the collection. </value>
        [DataMember(Name="total_pages", EmitDefaultValue=false)]
        public int? TotalPages { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name="links", EmitDefaultValue=false)]
        public Pagination1Links Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Pagination1 {\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  PerPage: ").Append(PerPage).Append("\n");
            sb.Append("  CurrentPage: ").Append(CurrentPage).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as Pagination1);
        }

        /// <summary>
        /// Returns true if Pagination1 instances are equal
        /// </summary>
        /// <param name="input">Instance of Pagination1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Pagination1 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.PerPage == input.PerPage ||
                    (this.PerPage != null &&
                    this.PerPage.Equals(input.PerPage))
                ) && 
                (
                    this.CurrentPage == input.CurrentPage ||
                    (this.CurrentPage != null &&
                    this.CurrentPage.Equals(input.CurrentPage))
                ) && 
                (
                    this.TotalPages == input.TotalPages ||
                    (this.TotalPages != null &&
                    this.TotalPages.Equals(input.TotalPages))
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.PerPage != null)
                    hashCode = hashCode * 59 + this.PerPage.GetHashCode();
                if (this.CurrentPage != null)
                    hashCode = hashCode * 59 + this.CurrentPage.GetHashCode();
                if (this.TotalPages != null)
                    hashCode = hashCode * 59 + this.TotalPages.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
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
