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
    /// Used to reflect parent &lt;&gt; child category relationships. Used by Category Tree.
    /// </summary>
    [DataContract]
        public partial class CategoriesTreeNodeFull :  IEquatable<CategoriesTreeNodeFull>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoriesTreeNodeFull" /> class.
        /// </summary>
        /// <param name="children">The list of children of the category. .</param>
        /// <param name="id">The unique numeric ID of the category; increments sequentially. .</param>
        /// <param name="isVisible">Flag to determine whether the product should be displayed to customers browsing the store. If &#x60;true&#x60;, the category will be displayed. If &#x60;false&#x60;, the category will be hidden from view. .</param>
        /// <param name="name">The name displayed for the category. Name is unique with respect to the category&#x27;s siblings. .</param>
        /// <param name="parentId">The unique numeric ID of the category&#x27;s parent. This field controls where the category sits in the tree of categories that organize the catalog. .</param>
        /// <param name="url">The custom URL for the category on the storefront. .</param>
        public CategoriesTreeNodeFull(List<Object> children = default(List<Object>), int? id = default(int?), bool? isVisible = default(bool?), string name = default(string), int? parentId = default(int?), string url = default(string))
        {
            this.Children = children;
            this.Id = id;
            this.IsVisible = isVisible;
            this.Name = name;
            this.ParentId = parentId;
            this.Url = url;
        }
        
        /// <summary>
        /// The list of children of the category. 
        /// </summary>
        /// <value>The list of children of the category. </value>
        [DataMember(Name="children", EmitDefaultValue=false)]
        public List<Object> Children { get; set; }

        /// <summary>
        /// The unique numeric ID of the category; increments sequentially. 
        /// </summary>
        /// <value>The unique numeric ID of the category; increments sequentially. </value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Flag to determine whether the product should be displayed to customers browsing the store. If &#x60;true&#x60;, the category will be displayed. If &#x60;false&#x60;, the category will be hidden from view. 
        /// </summary>
        /// <value>Flag to determine whether the product should be displayed to customers browsing the store. If &#x60;true&#x60;, the category will be displayed. If &#x60;false&#x60;, the category will be hidden from view. </value>
        [DataMember(Name="is_visible", EmitDefaultValue=false)]
        public bool? IsVisible { get; set; }

        /// <summary>
        /// The name displayed for the category. Name is unique with respect to the category&#x27;s siblings. 
        /// </summary>
        /// <value>The name displayed for the category. Name is unique with respect to the category&#x27;s siblings. </value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The unique numeric ID of the category&#x27;s parent. This field controls where the category sits in the tree of categories that organize the catalog. 
        /// </summary>
        /// <value>The unique numeric ID of the category&#x27;s parent. This field controls where the category sits in the tree of categories that organize the catalog. </value>
        [DataMember(Name="parent_id", EmitDefaultValue=false)]
        public int? ParentId { get; set; }

        /// <summary>
        /// The custom URL for the category on the storefront. 
        /// </summary>
        /// <value>The custom URL for the category on the storefront. </value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CategoriesTreeNodeFull {\n");
            sb.Append("  Children: ").Append(Children).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsVisible: ").Append(IsVisible).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(input as CategoriesTreeNodeFull);
        }

        /// <summary>
        /// Returns true if CategoriesTreeNodeFull instances are equal
        /// </summary>
        /// <param name="input">Instance of CategoriesTreeNodeFull to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CategoriesTreeNodeFull input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Children == input.Children ||
                    this.Children != null &&
                    input.Children != null &&
                    this.Children.SequenceEqual(input.Children)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.IsVisible == input.IsVisible ||
                    (this.IsVisible != null &&
                    this.IsVisible.Equals(input.IsVisible))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
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
                if (this.Children != null)
                    hashCode = hashCode * 59 + this.Children.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.IsVisible != null)
                    hashCode = hashCode * 59 + this.IsVisible.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
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
