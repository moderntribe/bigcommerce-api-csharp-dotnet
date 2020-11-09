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
    /// Common ProductImage properties.
    /// </summary>
    [DataContract]
        public partial class ProductImageBase :  IEquatable<ProductImageBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductImageBase" /> class.
        /// </summary>
        /// <param name="description">The description for the image. .</param>
        /// <param name="imageFile">The local path to the original image file uploaded to BigCommerce. .</param>
        /// <param name="imageUrl">Must be a fully qualified URL path, including protocol. Limit of 8MB per file..</param>
        /// <param name="isThumbnail">Flag for identifying whether the image is used as the product&#x27;s thumbnail. .</param>
        /// <param name="sortOrder">The order in which the image will be displayed on the product page. Higher integers give the image a lower priority. When updating, if the image is given a lower priority, all images with a &#x60;sort_order&#x60; the same as or greater than the image&#x27;s new &#x60;sort_order&#x60; value will have their &#x60;sort_order&#x60;s reordered. .</param>
        public ProductImageBase(string description = default(string), string imageFile = default(string), string imageUrl = default(string), bool? isThumbnail = default(bool?), int? sortOrder = default(int?))
        {
            this.Description = description;
            this.ImageFile = imageFile;
            this.ImageUrl = imageUrl;
            this.IsThumbnail = isThumbnail;
            this.SortOrder = sortOrder;
        }
        
        /// <summary>
        /// The description for the image. 
        /// </summary>
        /// <value>The description for the image. </value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The local path to the original image file uploaded to BigCommerce. 
        /// </summary>
        /// <value>The local path to the original image file uploaded to BigCommerce. </value>
        [DataMember(Name="image_file", EmitDefaultValue=false)]
        public string ImageFile { get; set; }

        /// <summary>
        /// Must be a fully qualified URL path, including protocol. Limit of 8MB per file.
        /// </summary>
        /// <value>Must be a fully qualified URL path, including protocol. Limit of 8MB per file.</value>
        [DataMember(Name="image_url", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Flag for identifying whether the image is used as the product&#x27;s thumbnail. 
        /// </summary>
        /// <value>Flag for identifying whether the image is used as the product&#x27;s thumbnail. </value>
        [DataMember(Name="is_thumbnail", EmitDefaultValue=false)]
        public bool? IsThumbnail { get; set; }

        /// <summary>
        /// The order in which the image will be displayed on the product page. Higher integers give the image a lower priority. When updating, if the image is given a lower priority, all images with a &#x60;sort_order&#x60; the same as or greater than the image&#x27;s new &#x60;sort_order&#x60; value will have their &#x60;sort_order&#x60;s reordered. 
        /// </summary>
        /// <value>The order in which the image will be displayed on the product page. Higher integers give the image a lower priority. When updating, if the image is given a lower priority, all images with a &#x60;sort_order&#x60; the same as or greater than the image&#x27;s new &#x60;sort_order&#x60; value will have their &#x60;sort_order&#x60;s reordered. </value>
        [DataMember(Name="sort_order", EmitDefaultValue=false)]
        public int? SortOrder { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductImageBase {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ImageFile: ").Append(ImageFile).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  IsThumbnail: ").Append(IsThumbnail).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
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
            return this.Equals(input as ProductImageBase);
        }

        /// <summary>
        /// Returns true if ProductImageBase instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductImageBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductImageBase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ImageFile == input.ImageFile ||
                    (this.ImageFile != null &&
                    this.ImageFile.Equals(input.ImageFile))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.IsThumbnail == input.IsThumbnail ||
                    (this.IsThumbnail != null &&
                    this.IsThumbnail.Equals(input.IsThumbnail))
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    (this.SortOrder != null &&
                    this.SortOrder.Equals(input.SortOrder))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ImageFile != null)
                    hashCode = hashCode * 59 + this.ImageFile.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.IsThumbnail != null)
                    hashCode = hashCode * 59 + this.IsThumbnail.GetHashCode();
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
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
