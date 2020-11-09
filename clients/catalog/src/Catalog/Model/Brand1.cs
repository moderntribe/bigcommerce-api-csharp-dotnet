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
    /// Common Brand properties.
    /// </summary>
    [DataContract]
        public partial class Brand1 :  IEquatable<Brand1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Brand1" /> class.
        /// </summary>
        /// <param name="customUrl">customUrl.</param>
        /// <param name="id">Unique ID of the *Brand*. Read-Only..</param>
        /// <param name="imageUrl">Image URL used for this category on the storefront. Images can be uploaded via form file post to &#x60;/brands/{brandId}/image&#x60;, or by providing a publicly accessible URL in this field. .</param>
        /// <param name="metaDescription">A meta description to include. .</param>
        /// <param name="metaKeywords">Comma-separated list of meta keywords to include in the HTML. .</param>
        /// <param name="name">The name of the brand. Must be unique. Required in POST. (required).</param>
        /// <param name="pageTitle">The title shown in the browser while viewing the brand. .</param>
        /// <param name="searchKeywords">A comma-separated list of keywords that can be used to locate this brand. .</param>
        public Brand1(CustomUrlBrand customUrl = default(CustomUrlBrand), int? id = default(int?), string imageUrl = default(string), string metaDescription = default(string), List<string> metaKeywords = default(List<string>), string name = default(string), string pageTitle = default(string), string searchKeywords = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for Brand1 and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            this.CustomUrl = customUrl;
            this.Id = id;
            this.ImageUrl = imageUrl;
            this.MetaDescription = metaDescription;
            this.MetaKeywords = metaKeywords;
            this.PageTitle = pageTitle;
            this.SearchKeywords = searchKeywords;
        }
        
        /// <summary>
        /// Gets or Sets CustomUrl
        /// </summary>
        [DataMember(Name="custom_url", EmitDefaultValue=false)]
        public CustomUrlBrand CustomUrl { get; set; }

        /// <summary>
        /// Unique ID of the *Brand*. Read-Only.
        /// </summary>
        /// <value>Unique ID of the *Brand*. Read-Only.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Image URL used for this category on the storefront. Images can be uploaded via form file post to &#x60;/brands/{brandId}/image&#x60;, or by providing a publicly accessible URL in this field. 
        /// </summary>
        /// <value>Image URL used for this category on the storefront. Images can be uploaded via form file post to &#x60;/brands/{brandId}/image&#x60;, or by providing a publicly accessible URL in this field. </value>
        [DataMember(Name="image_url", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// A meta description to include. 
        /// </summary>
        /// <value>A meta description to include. </value>
        [DataMember(Name="meta_description", EmitDefaultValue=false)]
        public string MetaDescription { get; set; }

        /// <summary>
        /// Comma-separated list of meta keywords to include in the HTML. 
        /// </summary>
        /// <value>Comma-separated list of meta keywords to include in the HTML. </value>
        [DataMember(Name="meta_keywords", EmitDefaultValue=false)]
        public List<string> MetaKeywords { get; set; }

        /// <summary>
        /// The name of the brand. Must be unique. Required in POST.
        /// </summary>
        /// <value>The name of the brand. Must be unique. Required in POST.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The title shown in the browser while viewing the brand. 
        /// </summary>
        /// <value>The title shown in the browser while viewing the brand. </value>
        [DataMember(Name="page_title", EmitDefaultValue=false)]
        public string PageTitle { get; set; }

        /// <summary>
        /// A comma-separated list of keywords that can be used to locate this brand. 
        /// </summary>
        /// <value>A comma-separated list of keywords that can be used to locate this brand. </value>
        [DataMember(Name="search_keywords", EmitDefaultValue=false)]
        public string SearchKeywords { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Brand1 {\n");
            sb.Append("  CustomUrl: ").Append(CustomUrl).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  MetaDescription: ").Append(MetaDescription).Append("\n");
            sb.Append("  MetaKeywords: ").Append(MetaKeywords).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PageTitle: ").Append(PageTitle).Append("\n");
            sb.Append("  SearchKeywords: ").Append(SearchKeywords).Append("\n");
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
            return this.Equals(input as Brand1);
        }

        /// <summary>
        /// Returns true if Brand1 instances are equal
        /// </summary>
        /// <param name="input">Instance of Brand1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Brand1 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CustomUrl == input.CustomUrl ||
                    (this.CustomUrl != null &&
                    this.CustomUrl.Equals(input.CustomUrl))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ImageUrl == input.ImageUrl ||
                    (this.ImageUrl != null &&
                    this.ImageUrl.Equals(input.ImageUrl))
                ) && 
                (
                    this.MetaDescription == input.MetaDescription ||
                    (this.MetaDescription != null &&
                    this.MetaDescription.Equals(input.MetaDescription))
                ) && 
                (
                    this.MetaKeywords == input.MetaKeywords ||
                    this.MetaKeywords != null &&
                    input.MetaKeywords != null &&
                    this.MetaKeywords.SequenceEqual(input.MetaKeywords)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PageTitle == input.PageTitle ||
                    (this.PageTitle != null &&
                    this.PageTitle.Equals(input.PageTitle))
                ) && 
                (
                    this.SearchKeywords == input.SearchKeywords ||
                    (this.SearchKeywords != null &&
                    this.SearchKeywords.Equals(input.SearchKeywords))
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
                if (this.CustomUrl != null)
                    hashCode = hashCode * 59 + this.CustomUrl.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.MetaDescription != null)
                    hashCode = hashCode * 59 + this.MetaDescription.GetHashCode();
                if (this.MetaKeywords != null)
                    hashCode = hashCode * 59 + this.MetaKeywords.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PageTitle != null)
                    hashCode = hashCode * 59 + this.PageTitle.GetHashCode();
                if (this.SearchKeywords != null)
                    hashCode = hashCode * 59 + this.SearchKeywords.GetHashCode();
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
