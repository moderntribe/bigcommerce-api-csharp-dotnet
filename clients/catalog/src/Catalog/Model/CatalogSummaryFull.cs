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
    /// Catalog Summary object describes a lightweight summary of the catalog.
    /// </summary>
    [DataContract]
        public partial class CatalogSummaryFull :  IEquatable<CatalogSummaryFull>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CatalogSummaryFull" /> class.
        /// </summary>
        /// <param name="averageVariantPrice">Average price of all variants.</param>
        /// <param name="highestVariantPrice">Highest priced variant.</param>
        /// <param name="inventoryCount">A count of all inventory items in the catalog. .</param>
        /// <param name="inventoryValue">Total value of store&#x27;s inventory. .</param>
        /// <param name="lowestVariantPrice">Lowest priced variant in the store.</param>
        /// <param name="newestVariantDate">newestVariantDate.</param>
        /// <param name="oldestVariantDate">oldestVariantDate.</param>
        /// <param name="primaryCategoryId">ID of the category containing the most products. .</param>
        /// <param name="primaryCategoryName">Name of the category containing the most products. .</param>
        /// <param name="variantCount">Total number of variants.</param>
        public CatalogSummaryFull(double? averageVariantPrice = default(double?), double? highestVariantPrice = default(double?), int? inventoryCount = default(int?), double? inventoryValue = default(double?), string lowestVariantPrice = default(string), string newestVariantDate = default(string), string oldestVariantDate = default(string), int? primaryCategoryId = default(int?), string primaryCategoryName = default(string), int? variantCount = default(int?))
        {
            this.AverageVariantPrice = averageVariantPrice;
            this.HighestVariantPrice = highestVariantPrice;
            this.InventoryCount = inventoryCount;
            this.InventoryValue = inventoryValue;
            this.LowestVariantPrice = lowestVariantPrice;
            this.NewestVariantDate = newestVariantDate;
            this.OldestVariantDate = oldestVariantDate;
            this.PrimaryCategoryId = primaryCategoryId;
            this.PrimaryCategoryName = primaryCategoryName;
            this.VariantCount = variantCount;
        }
        
        /// <summary>
        /// Average price of all variants
        /// </summary>
        /// <value>Average price of all variants</value>
        [DataMember(Name="average_variant_price", EmitDefaultValue=false)]
        public double? AverageVariantPrice { get; set; }

        /// <summary>
        /// Highest priced variant
        /// </summary>
        /// <value>Highest priced variant</value>
        [DataMember(Name="highest_variant_price", EmitDefaultValue=false)]
        public double? HighestVariantPrice { get; set; }

        /// <summary>
        /// A count of all inventory items in the catalog. 
        /// </summary>
        /// <value>A count of all inventory items in the catalog. </value>
        [DataMember(Name="inventory_count", EmitDefaultValue=false)]
        public int? InventoryCount { get; set; }

        /// <summary>
        /// Total value of store&#x27;s inventory. 
        /// </summary>
        /// <value>Total value of store&#x27;s inventory. </value>
        [DataMember(Name="inventory_value", EmitDefaultValue=false)]
        public double? InventoryValue { get; set; }

        /// <summary>
        /// Lowest priced variant in the store
        /// </summary>
        /// <value>Lowest priced variant in the store</value>
        [DataMember(Name="lowest_variant_price", EmitDefaultValue=false)]
        public string LowestVariantPrice { get; set; }

        /// <summary>
        /// Gets or Sets NewestVariantDate
        /// </summary>
        [DataMember(Name="newest_variant_date", EmitDefaultValue=false)]
        public string NewestVariantDate { get; set; }

        /// <summary>
        /// Gets or Sets OldestVariantDate
        /// </summary>
        [DataMember(Name="oldest_variant_date", EmitDefaultValue=false)]
        public string OldestVariantDate { get; set; }

        /// <summary>
        /// ID of the category containing the most products. 
        /// </summary>
        /// <value>ID of the category containing the most products. </value>
        [DataMember(Name="primary_category_id", EmitDefaultValue=false)]
        public int? PrimaryCategoryId { get; set; }

        /// <summary>
        /// Name of the category containing the most products. 
        /// </summary>
        /// <value>Name of the category containing the most products. </value>
        [DataMember(Name="primary_category_name", EmitDefaultValue=false)]
        public string PrimaryCategoryName { get; set; }

        /// <summary>
        /// Total number of variants
        /// </summary>
        /// <value>Total number of variants</value>
        [DataMember(Name="variant_count", EmitDefaultValue=false)]
        public int? VariantCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CatalogSummaryFull {\n");
            sb.Append("  AverageVariantPrice: ").Append(AverageVariantPrice).Append("\n");
            sb.Append("  HighestVariantPrice: ").Append(HighestVariantPrice).Append("\n");
            sb.Append("  InventoryCount: ").Append(InventoryCount).Append("\n");
            sb.Append("  InventoryValue: ").Append(InventoryValue).Append("\n");
            sb.Append("  LowestVariantPrice: ").Append(LowestVariantPrice).Append("\n");
            sb.Append("  NewestVariantDate: ").Append(NewestVariantDate).Append("\n");
            sb.Append("  OldestVariantDate: ").Append(OldestVariantDate).Append("\n");
            sb.Append("  PrimaryCategoryId: ").Append(PrimaryCategoryId).Append("\n");
            sb.Append("  PrimaryCategoryName: ").Append(PrimaryCategoryName).Append("\n");
            sb.Append("  VariantCount: ").Append(VariantCount).Append("\n");
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
            return this.Equals(input as CatalogSummaryFull);
        }

        /// <summary>
        /// Returns true if CatalogSummaryFull instances are equal
        /// </summary>
        /// <param name="input">Instance of CatalogSummaryFull to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CatalogSummaryFull input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AverageVariantPrice == input.AverageVariantPrice ||
                    (this.AverageVariantPrice != null &&
                    this.AverageVariantPrice.Equals(input.AverageVariantPrice))
                ) && 
                (
                    this.HighestVariantPrice == input.HighestVariantPrice ||
                    (this.HighestVariantPrice != null &&
                    this.HighestVariantPrice.Equals(input.HighestVariantPrice))
                ) && 
                (
                    this.InventoryCount == input.InventoryCount ||
                    (this.InventoryCount != null &&
                    this.InventoryCount.Equals(input.InventoryCount))
                ) && 
                (
                    this.InventoryValue == input.InventoryValue ||
                    (this.InventoryValue != null &&
                    this.InventoryValue.Equals(input.InventoryValue))
                ) && 
                (
                    this.LowestVariantPrice == input.LowestVariantPrice ||
                    (this.LowestVariantPrice != null &&
                    this.LowestVariantPrice.Equals(input.LowestVariantPrice))
                ) && 
                (
                    this.NewestVariantDate == input.NewestVariantDate ||
                    (this.NewestVariantDate != null &&
                    this.NewestVariantDate.Equals(input.NewestVariantDate))
                ) && 
                (
                    this.OldestVariantDate == input.OldestVariantDate ||
                    (this.OldestVariantDate != null &&
                    this.OldestVariantDate.Equals(input.OldestVariantDate))
                ) && 
                (
                    this.PrimaryCategoryId == input.PrimaryCategoryId ||
                    (this.PrimaryCategoryId != null &&
                    this.PrimaryCategoryId.Equals(input.PrimaryCategoryId))
                ) && 
                (
                    this.PrimaryCategoryName == input.PrimaryCategoryName ||
                    (this.PrimaryCategoryName != null &&
                    this.PrimaryCategoryName.Equals(input.PrimaryCategoryName))
                ) && 
                (
                    this.VariantCount == input.VariantCount ||
                    (this.VariantCount != null &&
                    this.VariantCount.Equals(input.VariantCount))
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
                if (this.AverageVariantPrice != null)
                    hashCode = hashCode * 59 + this.AverageVariantPrice.GetHashCode();
                if (this.HighestVariantPrice != null)
                    hashCode = hashCode * 59 + this.HighestVariantPrice.GetHashCode();
                if (this.InventoryCount != null)
                    hashCode = hashCode * 59 + this.InventoryCount.GetHashCode();
                if (this.InventoryValue != null)
                    hashCode = hashCode * 59 + this.InventoryValue.GetHashCode();
                if (this.LowestVariantPrice != null)
                    hashCode = hashCode * 59 + this.LowestVariantPrice.GetHashCode();
                if (this.NewestVariantDate != null)
                    hashCode = hashCode * 59 + this.NewestVariantDate.GetHashCode();
                if (this.OldestVariantDate != null)
                    hashCode = hashCode * 59 + this.OldestVariantDate.GetHashCode();
                if (this.PrimaryCategoryId != null)
                    hashCode = hashCode * 59 + this.PrimaryCategoryId.GetHashCode();
                if (this.PrimaryCategoryName != null)
                    hashCode = hashCode * 59 + this.PrimaryCategoryName.GetHashCode();
                if (this.VariantCount != null)
                    hashCode = hashCode * 59 + this.VariantCount.GetHashCode();
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
