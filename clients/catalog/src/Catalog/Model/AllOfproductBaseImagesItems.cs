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
    /// Common ProductImage properties.
    /// </summary>
    [DataContract]
        public partial class AllOfproductBaseImagesItems :  IEquatable<AllOfproductBaseImagesItems>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AllOfproductBaseImagesItems" /> class.
        /// </summary>
        /// <param name="dateModified">The date on which the product image was modified. .</param>
        /// <param name="id">The unique numeric ID of the image; increments sequentially. .</param>
        /// <param name="productId">The unique numeric identifier for the product with which the image is associated. .</param>
        /// <param name="urlStandard">The standard URL for this image. By default, this is used for product-page images. .</param>
        /// <param name="urlThumbnail">The thumbnail URL for this image. By default, this is the image size used on the category page and in side panels. .</param>
        /// <param name="urlTiny">The tiny URL for this image. By default, this is the image size used for thumbnails beneath the product image on a product page. .</param>
        /// <param name="urlZoom">The zoom URL for this image. By default, this is used as the zoom image on product pages when zoom images are enabled. .</param>
        public AllOfproductBaseImagesItems(DateTime? dateModified = default(DateTime?), int? id = default(int?), int? productId = default(int?), string urlStandard = default(string), string urlThumbnail = default(string), string urlTiny = default(string), string urlZoom = default(string))
        {
            this.DateModified = dateModified;
            this.Id = id;
            this.ProductId = productId;
            this.UrlStandard = urlStandard;
            this.UrlThumbnail = urlThumbnail;
            this.UrlTiny = urlTiny;
            this.UrlZoom = urlZoom;
        }
        
        /// <summary>
        /// The date on which the product image was modified. 
        /// </summary>
        /// <value>The date on which the product image was modified. </value>
        [DataMember(Name="date_modified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }

        /// <summary>
        /// The unique numeric ID of the image; increments sequentially. 
        /// </summary>
        /// <value>The unique numeric ID of the image; increments sequentially. </value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The unique numeric identifier for the product with which the image is associated. 
        /// </summary>
        /// <value>The unique numeric identifier for the product with which the image is associated. </value>
        [DataMember(Name="product_id", EmitDefaultValue=false)]
        public int? ProductId { get; set; }

        /// <summary>
        /// The standard URL for this image. By default, this is used for product-page images. 
        /// </summary>
        /// <value>The standard URL for this image. By default, this is used for product-page images. </value>
        [DataMember(Name="url_standard", EmitDefaultValue=false)]
        public string UrlStandard { get; set; }

        /// <summary>
        /// The thumbnail URL for this image. By default, this is the image size used on the category page and in side panels. 
        /// </summary>
        /// <value>The thumbnail URL for this image. By default, this is the image size used on the category page and in side panels. </value>
        [DataMember(Name="url_thumbnail", EmitDefaultValue=false)]
        public string UrlThumbnail { get; set; }

        /// <summary>
        /// The tiny URL for this image. By default, this is the image size used for thumbnails beneath the product image on a product page. 
        /// </summary>
        /// <value>The tiny URL for this image. By default, this is the image size used for thumbnails beneath the product image on a product page. </value>
        [DataMember(Name="url_tiny", EmitDefaultValue=false)]
        public string UrlTiny { get; set; }

        /// <summary>
        /// The zoom URL for this image. By default, this is used as the zoom image on product pages when zoom images are enabled. 
        /// </summary>
        /// <value>The zoom URL for this image. By default, this is used as the zoom image on product pages when zoom images are enabled. </value>
        [DataMember(Name="url_zoom", EmitDefaultValue=false)]
        public string UrlZoom { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AllOfproductBaseImagesItems {\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  UrlStandard: ").Append(UrlStandard).Append("\n");
            sb.Append("  UrlThumbnail: ").Append(UrlThumbnail).Append("\n");
            sb.Append("  UrlTiny: ").Append(UrlTiny).Append("\n");
            sb.Append("  UrlZoom: ").Append(UrlZoom).Append("\n");
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
            return this.Equals(input as AllOfproductBaseImagesItems);
        }

        /// <summary>
        /// Returns true if AllOfproductBaseImagesItems instances are equal
        /// </summary>
        /// <param name="input">Instance of AllOfproductBaseImagesItems to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AllOfproductBaseImagesItems input)
        {
            if (input == null)
                return false;

            return 
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
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.UrlStandard == input.UrlStandard ||
                    (this.UrlStandard != null &&
                    this.UrlStandard.Equals(input.UrlStandard))
                ) && 
                (
                    this.UrlThumbnail == input.UrlThumbnail ||
                    (this.UrlThumbnail != null &&
                    this.UrlThumbnail.Equals(input.UrlThumbnail))
                ) && 
                (
                    this.UrlTiny == input.UrlTiny ||
                    (this.UrlTiny != null &&
                    this.UrlTiny.Equals(input.UrlTiny))
                ) && 
                (
                    this.UrlZoom == input.UrlZoom ||
                    (this.UrlZoom != null &&
                    this.UrlZoom.Equals(input.UrlZoom))
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
                if (this.DateModified != null)
                    hashCode = hashCode * 59 + this.DateModified.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.UrlStandard != null)
                    hashCode = hashCode * 59 + this.UrlStandard.GetHashCode();
                if (this.UrlThumbnail != null)
                    hashCode = hashCode * 59 + this.UrlThumbnail.GetHashCode();
                if (this.UrlTiny != null)
                    hashCode = hashCode * 59 + this.UrlTiny.GetHashCode();
                if (this.UrlZoom != null)
                    hashCode = hashCode * 59 + this.UrlZoom.GetHashCode();
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
