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
    /// ProductReviewBase
    /// </summary>
    [DataContract]
        public partial class ProductReviewBase :  IEquatable<ProductReviewBase>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductReviewBase" /> class.
        /// </summary>
        /// <param name="dateReviewed">Date the product was reviewed. Required in /POST.  (required).</param>
        /// <param name="email">The email of the reviewer. Must be a valid email, or an empty string..</param>
        /// <param name="name">The name of the reviewer..</param>
        /// <param name="rating">The rating of the product review. Must be one of 0, 1, 2, 3, 4, 5..</param>
        /// <param name="status">The status of the product review. Must be one of &#x60;approved&#x60;, &#x60;disapproved&#x60; or &#x60;pending&#x60;. .</param>
        /// <param name="text">The text for the product review. .</param>
        /// <param name="title">The title for the product review. Required in /POST. (required).</param>
        public ProductReviewBase(DateTime? dateReviewed = default(DateTime?), string email = default(string), string name = default(string), int? rating = default(int?), string status = default(string), string text = default(string), string title = default(string))
        {
            // to ensure "dateReviewed" is required (not null)
            if (dateReviewed == null)
            {
                throw new InvalidDataException("dateReviewed is a required property for ProductReviewBase and cannot be null");
            }
            else
            {
                this.DateReviewed = dateReviewed;
            }
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new InvalidDataException("title is a required property for ProductReviewBase and cannot be null");
            }
            else
            {
                this.Title = title;
            }
            this.Email = email;
            this.Name = name;
            this.Rating = rating;
            this.Status = status;
            this.Text = text;
        }
        
        /// <summary>
        /// Date the product was reviewed. Required in /POST. 
        /// </summary>
        /// <value>Date the product was reviewed. Required in /POST. </value>
        [DataMember(Name="date_reviewed", EmitDefaultValue=false)]
        public DateTime? DateReviewed { get; set; }

        /// <summary>
        /// The email of the reviewer. Must be a valid email, or an empty string.
        /// </summary>
        /// <value>The email of the reviewer. Must be a valid email, or an empty string.</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// The name of the reviewer.
        /// </summary>
        /// <value>The name of the reviewer.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The rating of the product review. Must be one of 0, 1, 2, 3, 4, 5.
        /// </summary>
        /// <value>The rating of the product review. Must be one of 0, 1, 2, 3, 4, 5.</value>
        [DataMember(Name="rating", EmitDefaultValue=false)]
        public int? Rating { get; set; }

        /// <summary>
        /// The status of the product review. Must be one of &#x60;approved&#x60;, &#x60;disapproved&#x60; or &#x60;pending&#x60;. 
        /// </summary>
        /// <value>The status of the product review. Must be one of &#x60;approved&#x60;, &#x60;disapproved&#x60; or &#x60;pending&#x60;. </value>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }

        /// <summary>
        /// The text for the product review. 
        /// </summary>
        /// <value>The text for the product review. </value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// The title for the product review. Required in /POST.
        /// </summary>
        /// <value>The title for the product review. Required in /POST.</value>
        [DataMember(Name="title", EmitDefaultValue=false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductReviewBase {\n");
            sb.Append("  DateReviewed: ").Append(DateReviewed).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Rating: ").Append(Rating).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as ProductReviewBase);
        }

        /// <summary>
        /// Returns true if ProductReviewBase instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductReviewBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductReviewBase input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DateReviewed == input.DateReviewed ||
                    (this.DateReviewed != null &&
                    this.DateReviewed.Equals(input.DateReviewed))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Rating == input.Rating ||
                    (this.Rating != null &&
                    this.Rating.Equals(input.Rating))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                if (this.DateReviewed != null)
                    hashCode = hashCode * 59 + this.DateReviewed.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Rating != null)
                    hashCode = hashCode * 59 + this.Rating.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Title != null)
                    hashCode = hashCode * 59 + this.Title.GetHashCode();
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
