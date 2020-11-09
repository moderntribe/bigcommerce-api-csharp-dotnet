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
    /// AllOfProductResponseData
    /// </summary>
    [DataContract]
        public partial class AllOfProductResponseData :  IEquatable<AllOfProductResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllOfProductResponseData" /> class.
        /// </summary>
        /// <param name="baseVariantId">The unique identifier of the base variant associated with a simple product. This value is &#x60;null&#x60; for complex products..</param>
        /// <param name="calculatedPrice">The price of the product as seen on the storefront. It will be equal to the &#x60;sale_price&#x60;, if set, and the &#x60;price&#x60; if there is not a &#x60;sale_price&#x60;..</param>
        /// <param name="dateCreated">The date on which the product was created. .</param>
        /// <param name="dateModified">The date on which the product was modified. .</param>
        /// <param name="id">ID of the product. Read Only..</param>
        /// <param name="mapPrice">Minimum Advertised Price..</param>
        /// <param name="modifiers">modifiers.</param>
        /// <param name="optionSetDisplay">Legacy template setting which controls if the option set shows up to the side of or below the product image and description..</param>
        /// <param name="optionSetId">Indicates that the product is in an Option Set (legacy V2 concept)..</param>
        /// <param name="options">options.</param>
        /// <param name="variants">variants.</param>
        public AllOfProductResponseData(int? baseVariantId = default(int?), float? calculatedPrice = default(float?), DateTime? dateCreated = default(DateTime?), DateTime? dateModified = default(DateTime?), int? id = default(int?), decimal? mapPrice = default(decimal?), List<Object> modifiers = default(List<Object>), string optionSetDisplay = default(string), int? optionSetId = default(int?), List<Object> options = default(List<Object>), Object variants = default(Object))
        {
            this.BaseVariantId = baseVariantId;
            this.CalculatedPrice = calculatedPrice;
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.Id = id;
            this.MapPrice = mapPrice;
            this.Modifiers = modifiers;
            this.OptionSetDisplay = optionSetDisplay;
            this.OptionSetId = optionSetId;
            this.Options = options;
            this.Variants = variants;
        }
        
        /// <summary>
        /// The unique identifier of the base variant associated with a simple product. This value is &#x60;null&#x60; for complex products.
        /// </summary>
        /// <value>The unique identifier of the base variant associated with a simple product. This value is &#x60;null&#x60; for complex products.</value>
        [DataMember(Name="base_variant_id", EmitDefaultValue=false)]
        public int? BaseVariantId { get; set; }

        /// <summary>
        /// The price of the product as seen on the storefront. It will be equal to the &#x60;sale_price&#x60;, if set, and the &#x60;price&#x60; if there is not a &#x60;sale_price&#x60;.
        /// </summary>
        /// <value>The price of the product as seen on the storefront. It will be equal to the &#x60;sale_price&#x60;, if set, and the &#x60;price&#x60; if there is not a &#x60;sale_price&#x60;.</value>
        [DataMember(Name="calculated_price", EmitDefaultValue=false)]
        public float? CalculatedPrice { get; set; }

        /// <summary>
        /// The date on which the product was created. 
        /// </summary>
        /// <value>The date on which the product was created. </value>
        [DataMember(Name="date_created", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// The date on which the product was modified. 
        /// </summary>
        /// <value>The date on which the product was modified. </value>
        [DataMember(Name="date_modified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }

        /// <summary>
        /// ID of the product. Read Only.
        /// </summary>
        /// <value>ID of the product. Read Only.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Minimum Advertised Price.
        /// </summary>
        /// <value>Minimum Advertised Price.</value>
        [DataMember(Name="map_price", EmitDefaultValue=false)]
        public decimal? MapPrice { get; set; }

        /// <summary>
        /// Gets or Sets Modifiers
        /// </summary>
        [DataMember(Name="modifiers", EmitDefaultValue=false)]
        public List<Object> Modifiers { get; set; }

        /// <summary>
        /// Legacy template setting which controls if the option set shows up to the side of or below the product image and description.
        /// </summary>
        /// <value>Legacy template setting which controls if the option set shows up to the side of or below the product image and description.</value>
        [DataMember(Name="option_set_display", EmitDefaultValue=false)]
        public string OptionSetDisplay { get; set; }

        /// <summary>
        /// Indicates that the product is in an Option Set (legacy V2 concept).
        /// </summary>
        /// <value>Indicates that the product is in an Option Set (legacy V2 concept).</value>
        [DataMember(Name="option_set_id", EmitDefaultValue=false)]
        public int? OptionSetId { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name="options", EmitDefaultValue=false)]
        public List<Object> Options { get; set; }

        /// <summary>
        /// Gets or Sets Variants
        /// </summary>
        [DataMember(Name="variants", EmitDefaultValue=false)]
        public Object Variants { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllOfProductResponseData {\n");
            sb.Append("  BaseVariantId: ").Append(BaseVariantId).Append("\n");
            sb.Append("  CalculatedPrice: ").Append(CalculatedPrice).Append("\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  MapPrice: ").Append(MapPrice).Append("\n");
            sb.Append("  Modifiers: ").Append(Modifiers).Append("\n");
            sb.Append("  OptionSetDisplay: ").Append(OptionSetDisplay).Append("\n");
            sb.Append("  OptionSetId: ").Append(OptionSetId).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
            sb.Append("  Variants: ").Append(Variants).Append("\n");
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
            return this.Equals(input as AllOfProductResponseData);
        }

        /// <summary>
        /// Returns true if AllOfProductResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of AllOfProductResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllOfProductResponseData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BaseVariantId == input.BaseVariantId ||
                    (this.BaseVariantId != null &&
                    this.BaseVariantId.Equals(input.BaseVariantId))
                ) && 
                (
                    this.CalculatedPrice == input.CalculatedPrice ||
                    (this.CalculatedPrice != null &&
                    this.CalculatedPrice.Equals(input.CalculatedPrice))
                ) && 
                (
                    this.DateCreated == input.DateCreated ||
                    (this.DateCreated != null &&
                    this.DateCreated.Equals(input.DateCreated))
                ) && 
                (
                    this.DateModified == input.DateModified ||
                    (this.DateModified != null &&
                    this.DateModified.Equals(input.DateModified))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.MapPrice == input.MapPrice ||
                    (this.MapPrice != null &&
                    this.MapPrice.Equals(input.MapPrice))
                ) && 
                (
                    this.Modifiers == input.Modifiers ||
                    this.Modifiers != null &&
                    input.Modifiers != null &&
                    this.Modifiers.SequenceEqual(input.Modifiers)
                ) && 
                (
                    this.OptionSetDisplay == input.OptionSetDisplay ||
                    (this.OptionSetDisplay != null &&
                    this.OptionSetDisplay.Equals(input.OptionSetDisplay))
                ) && 
                (
                    this.OptionSetId == input.OptionSetId ||
                    (this.OptionSetId != null &&
                    this.OptionSetId.Equals(input.OptionSetId))
                ) && 
                (
                    this.Options == input.Options ||
                    this.Options != null &&
                    input.Options != null &&
                    this.Options.SequenceEqual(input.Options)
                ) && 
                (
                    this.Variants == input.Variants ||
                    (this.Variants != null &&
                    this.Variants.Equals(input.Variants))
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
                if (this.BaseVariantId != null)
                    hashCode = hashCode * 59 + this.BaseVariantId.GetHashCode();
                if (this.CalculatedPrice != null)
                    hashCode = hashCode * 59 + this.CalculatedPrice.GetHashCode();
                if (this.DateCreated != null)
                    hashCode = hashCode * 59 + this.DateCreated.GetHashCode();
                if (this.DateModified != null)
                    hashCode = hashCode * 59 + this.DateModified.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.MapPrice != null)
                    hashCode = hashCode * 59 + this.MapPrice.GetHashCode();
                if (this.Modifiers != null)
                    hashCode = hashCode * 59 + this.Modifiers.GetHashCode();
                if (this.OptionSetDisplay != null)
                    hashCode = hashCode * 59 + this.OptionSetDisplay.GetHashCode();
                if (this.OptionSetId != null)
                    hashCode = hashCode * 59 + this.OptionSetId.GetHashCode();
                if (this.Options != null)
                    hashCode = hashCode * 59 + this.Options.GetHashCode();
                if (this.Variants != null)
                    hashCode = hashCode * 59 + this.Variants.GetHashCode();
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
