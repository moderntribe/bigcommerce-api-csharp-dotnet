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
    /// The model for a POST to create a video on a product. 
    /// </summary>
    [DataContract]
        public partial class ProductVideoBase :  IEquatable<ProductVideoBase>, IValidatableObject
    {
        /// <summary>
        /// The video type (a short name of a host site). 
        /// </summary>
        /// <value>The video type (a short name of a host site). </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum TypeEnum
        {
            /// <summary>
            /// Enum Youtube for value: youtube
            /// </summary>
            [EnumMember(Value = "youtube")]
            Youtube = 1        }
        /// <summary>
        /// The video type (a short name of a host site). 
        /// </summary>
        /// <value>The video type (a short name of a host site). </value>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductVideoBase" /> class.
        /// </summary>
        /// <param name="description">The description for the video. If left blank, this will be filled in according to data on a host site. .</param>
        /// <param name="sortOrder">The order in which the video will be displayed on the product page. Higher integers give the video a lower priority. When updating, if the video is given a lower priority, all videos with a &#x60;sort_order&#x60; the same as or greater than the video&#x27;s new &#x60;sort_order&#x60; value will have their &#x60;sort_order&#x60;s reordered. .</param>
        /// <param name="title">The title for the video. If left blank, this will be filled in according to data on a host site. .</param>
        /// <param name="type">The video type (a short name of a host site). .</param>
        /// <param name="videoId">The ID of the video on a host site..</param>
        public ProductVideoBase(string description = default(string), int? sortOrder = default(int?), string title = default(string), TypeEnum? type = default(TypeEnum?), string videoId = default(string))
        {
            this.Description = description;
            this.SortOrder = sortOrder;
            this.Title = title;
            this.Type = type;
            this.VideoId = videoId;
        }
        
        /// <summary>
        /// The description for the video. If left blank, this will be filled in according to data on a host site. 
        /// </summary>
        /// <value>The description for the video. If left blank, this will be filled in according to data on a host site. </value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The order in which the video will be displayed on the product page. Higher integers give the video a lower priority. When updating, if the video is given a lower priority, all videos with a &#x60;sort_order&#x60; the same as or greater than the video&#x27;s new &#x60;sort_order&#x60; value will have their &#x60;sort_order&#x60;s reordered. 
        /// </summary>
        /// <value>The order in which the video will be displayed on the product page. Higher integers give the video a lower priority. When updating, if the video is given a lower priority, all videos with a &#x60;sort_order&#x60; the same as or greater than the video&#x27;s new &#x60;sort_order&#x60; value will have their &#x60;sort_order&#x60;s reordered. </value>
        [DataMember(Name="sort_order", EmitDefaultValue=false)]
        public int? SortOrder { get; set; }

        /// <summary>
        /// The title for the video. If left blank, this will be filled in according to data on a host site. 
        /// </summary>
        /// <value>The title for the video. If left blank, this will be filled in according to data on a host site. </value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }


        /// <summary>
        /// The ID of the video on a host site.
        /// </summary>
        /// <value>The ID of the video on a host site.</value>
        [DataMember(Name="video_id", EmitDefaultValue=false)]
        public string VideoId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductVideoBase {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  VideoId: ").Append(VideoId).Append("\n");
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
            return this.Equals(input as ProductVideoBase);
        }

        /// <summary>
        /// Returns true if ProductVideoBase instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductVideoBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductVideoBase input)
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
                    this.SortOrder == input.SortOrder ||
                    (this.SortOrder != null &&
                    this.SortOrder.Equals(input.SortOrder))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.VideoId == input.VideoId ||
                    (this.VideoId != null &&
                    this.VideoId.Equals(input.VideoId))
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
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.VideoId != null)
                    hashCode = hashCode * 59 + this.VideoId.GetHashCode();
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
