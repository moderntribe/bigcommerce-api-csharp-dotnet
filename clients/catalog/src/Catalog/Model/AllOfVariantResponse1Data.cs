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
    /// AllOfVariantResponse1Data
    /// </summary>
    [DataContract]
        public partial class AllOfVariantResponse1Data :  IEquatable<AllOfVariantResponse1Data>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllOfVariantResponse1Data" /> class.
        /// </summary>
        /// <param name="">.</param>
        /// <param name="calculatedPrice">The price of the variant as seen on the storefront. This price takes into account &#x60;sale_price&#x60; and any price adjustment rules that are applicable to this variant. .</param>
        /// <param name="id">id.</param>
        /// <param name="optionValues">Array of option and option values IDs that make up this variant. Will be empty if the variant is the product&#x27;s base variant..</param>
        /// <param name="productId">productId.</param>
        /// <param name="sku">sku.</param>
        /// <param name="skuId">Read-only reference to v2 API&#x27;s SKU ID. Null if it is a base variant..</param>
        public AllOfVariantResponse1Data(string  = default(string), double? calculatedPrice = default(double?), int? id = default(int?), List<Object> optionValues = default(List<Object>), int? productId = default(int?), string sku = default(string), int? skuId = default(int?))
        {
            this. = ;
            this.CalculatedPrice = calculatedPrice;
            this.Id = id;
            this.OptionValues = optionValues;
            this.ProductId = productId;
            this.Sku = sku;
            this.SkuId = skuId;
        }
        
        /// <summary>
        /// Gets or Sets 
        /// </summary>
        [DataMember(Name="", EmitDefaultValue=false)]
        public string  { get; set; }

        /// <summary>
        /// The price of the variant as seen on the storefront. This price takes into account &#x60;sale_price&#x60; and any price adjustment rules that are applicable to this variant. 
        /// </summary>
        /// <value>The price of the variant as seen on the storefront. This price takes into account &#x60;sale_price&#x60; and any price adjustment rules that are applicable to this variant. </value>
        [DataMember(Name="calculated_price", EmitDefaultValue=false)]
        public double? CalculatedPrice { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Array of option and option values IDs that make up this variant. Will be empty if the variant is the product&#x27;s base variant.
        /// </summary>
        /// <value>Array of option and option values IDs that make up this variant. Will be empty if the variant is the product&#x27;s base variant.</value>
        [DataMember(Name="option_values", EmitDefaultValue=false)]
        public List<Object> OptionValues { get; set; }

        /// <summary>
        /// Gets or Sets ProductId
        /// </summary>
        [DataMember(Name="product_id", EmitDefaultValue=false)]
        public int? ProductId { get; set; }

        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// Read-only reference to v2 API&#x27;s SKU ID. Null if it is a base variant.
        /// </summary>
        /// <value>Read-only reference to v2 API&#x27;s SKU ID. Null if it is a base variant.</value>
        [DataMember(Name="sku_id", EmitDefaultValue=false)]
        public int? SkuId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllOfVariantResponse1Data {\n");
            sb.Append("  : ").Append().Append("\n");
            sb.Append("  CalculatedPrice: ").Append(CalculatedPrice).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OptionValues: ").Append(OptionValues).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  SkuId: ").Append(SkuId).Append("\n");
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
            return this.Equals(input as AllOfVariantResponse1Data);
        }

        /// <summary>
        /// Returns true if AllOfVariantResponse1Data instances are equal
        /// </summary>
        /// <param name="input">Instance of AllOfVariantResponse1Data to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllOfVariantResponse1Data input)
        {
            if (input == null)
                return false;

            return 
                (
                    this. == input. ||
                    (this. != null &&
                    this..Equals(input.))
                ) && 
                (
                    this.CalculatedPrice == input.CalculatedPrice ||
                    (this.CalculatedPrice != null &&
                    this.CalculatedPrice.Equals(input.CalculatedPrice))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.OptionValues == input.OptionValues ||
                    this.OptionValues != null &&
                    input.OptionValues != null &&
                    this.OptionValues.SequenceEqual(input.OptionValues)
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.SkuId == input.SkuId ||
                    (this.SkuId != null &&
                    this.SkuId.Equals(input.SkuId))
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
                if (this. != null)
                    hashCode = hashCode * 59 + this..GetHashCode();
                if (this.CalculatedPrice != null)
                    hashCode = hashCode * 59 + this.CalculatedPrice.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.OptionValues != null)
                    hashCode = hashCode * 59 + this.OptionValues.GetHashCode();
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.SkuId != null)
                    hashCode = hashCode * 59 + this.SkuId.GetHashCode();
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
