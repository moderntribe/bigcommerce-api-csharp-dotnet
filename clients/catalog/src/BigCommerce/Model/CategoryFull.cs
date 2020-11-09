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
    /// Common Category object properties.
    /// </summary>
    [DataContract]
        public partial class CategoryFull :  IEquatable<CategoryFull>, IValidatableObject
    {
        /// <summary>
        /// Determines how the products are sorted on category page load. 
        /// </summary>
        /// <value>Determines how the products are sorted on category page load. </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum DefaultProductSortEnum
        {
            /// <summary>
            /// Enum Usestoresettings for value: use_store_settings
            /// </summary>
            [EnumMember(Value = "use_store_settings")]
            Usestoresettings = 1,
            /// <summary>
            /// Enum Featured for value: featured
            /// </summary>
            [EnumMember(Value = "featured")]
            Featured = 2,
            /// <summary>
            /// Enum Newest for value: newest
            /// </summary>
            [EnumMember(Value = "newest")]
            Newest = 3,
            /// <summary>
            /// Enum Bestselling for value: best_selling
            /// </summary>
            [EnumMember(Value = "best_selling")]
            Bestselling = 4,
            /// <summary>
            /// Enum Alphaasc for value: alpha_asc
            /// </summary>
            [EnumMember(Value = "alpha_asc")]
            Alphaasc = 5,
            /// <summary>
            /// Enum Alphadesc for value: alpha_desc
            /// </summary>
            [EnumMember(Value = "alpha_desc")]
            Alphadesc = 6,
            /// <summary>
            /// Enum Avgcustomerreview for value: avg_customer_review
            /// </summary>
            [EnumMember(Value = "avg_customer_review")]
            Avgcustomerreview = 7,
            /// <summary>
            /// Enum Priceasc for value: price_asc
            /// </summary>
            [EnumMember(Value = "price_asc")]
            Priceasc = 8,
            /// <summary>
            /// Enum Pricedesc for value: price_desc
            /// </summary>
            [EnumMember(Value = "price_desc")]
            Pricedesc = 9        }
        /// <summary>
        /// Determines how the products are sorted on category page load. 
        /// </summary>
        /// <value>Determines how the products are sorted on category page load. </value>
        [DataMember(Name="default_product_sort", EmitDefaultValue=false)]
        public DefaultProductSortEnum? DefaultProductSort { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryFull" /> class.
        /// </summary>
        /// <param name="customUrl">customUrl.</param>
        /// <param name="defaultProductSort">Determines how the products are sorted on category page load. .</param>
        /// <param name="description">The product description, which can include HTML formatting. .</param>
        /// <param name="id">Unique ID of the *Category*. Increments sequentially. Read-Only. .</param>
        /// <param name="imageUrl">Image URL used for this category on the storefront. Images can be uploaded via form file post to &#x60;/categories/{categoryId}/image&#x60;, or by providing a publicly accessible URL in this field. .</param>
        /// <param name="isVisible">Flag to determine whether the product should be displayed to customers browsing the store. If &#x60;true&#x60;, the category will be displayed. If &#x60;false&#x60;, the category will be hidden from view. .</param>
        /// <param name="layoutFile">A valid layout file. (Please refer to [this article](https://support.bigcommerce.com/articles/Public/Creating-Custom-Template-Files/) on creating category files.) This field is writable only for stores with a Blueprint theme applied. .</param>
        /// <param name="metaDescription">Custom meta description for the category page. If not defined, the store&#x27;s default meta description will be used. .</param>
        /// <param name="metaKeywords">Custom meta keywords for the category page. If not defined, the store&#x27;s default keywords will be used. Must post as an array like: [\&quot;awesome\&quot;,\&quot;sauce\&quot;]. .</param>
        /// <param name="name">The name displayed for the category. Name is unique with respect to the category&#x27;s siblings. Required in a POST. (required).</param>
        /// <param name="pageTitle">Custom title for the category page. If not defined, the category name will be used as the meta title. .</param>
        /// <param name="parentId">The unique numeric ID of the category&#x27;s parent. This field controls where the category sits in the tree of categories that organize the catalog. Required in a POST if creating a child category. (required).</param>
        /// <param name="searchKeywords">A comma-separated list of keywords that can be used to locate the category when searching the store. .</param>
        /// <param name="sortOrder">Priority this category will be given when included in the menu and category pages. The lower the number, the closer to the top of the results the category will be. .</param>
        /// <param name="views">Number of views the category has on the storefront. .</param>
        public CategoryFull(CustomUrlCategory customUrl = default(CustomUrlCategory), DefaultProductSortEnum? defaultProductSort = default(DefaultProductSortEnum?), string description = default(string), int? id = default(int?), string imageUrl = default(string), bool? isVisible = default(bool?), string layoutFile = default(string), string metaDescription = default(string), List<string> metaKeywords = default(List<string>), string name = default(string), string pageTitle = default(string), int? parentId = default(int?), string searchKeywords = default(string), int? sortOrder = default(int?), int? views = default(int?))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for CategoryFull and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            // to ensure "parentId" is required (not null)
            if (parentId == null)
            {
                throw new InvalidDataException("parentId is a required property for CategoryFull and cannot be null");
            }
            else
            {
                this.ParentId = parentId;
            }
            this.CustomUrl = customUrl;
            this.DefaultProductSort = defaultProductSort;
            this.Description = description;
            this.Id = id;
            this.ImageUrl = imageUrl;
            this.IsVisible = isVisible;
            this.LayoutFile = layoutFile;
            this.MetaDescription = metaDescription;
            this.MetaKeywords = metaKeywords;
            this.PageTitle = pageTitle;
            this.SearchKeywords = searchKeywords;
            this.SortOrder = sortOrder;
            this.Views = views;
        }
        
        /// <summary>
        /// Gets or Sets CustomUrl
        /// </summary>
        [DataMember(Name="custom_url", EmitDefaultValue=false)]
        public CustomUrlCategory CustomUrl { get; set; }


        /// <summary>
        /// The product description, which can include HTML formatting. 
        /// </summary>
        /// <value>The product description, which can include HTML formatting. </value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Unique ID of the *Category*. Increments sequentially. Read-Only. 
        /// </summary>
        /// <value>Unique ID of the *Category*. Increments sequentially. Read-Only. </value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// Image URL used for this category on the storefront. Images can be uploaded via form file post to &#x60;/categories/{categoryId}/image&#x60;, or by providing a publicly accessible URL in this field. 
        /// </summary>
        /// <value>Image URL used for this category on the storefront. Images can be uploaded via form file post to &#x60;/categories/{categoryId}/image&#x60;, or by providing a publicly accessible URL in this field. </value>
        [DataMember(Name="image_url", EmitDefaultValue=false)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// Flag to determine whether the product should be displayed to customers browsing the store. If &#x60;true&#x60;, the category will be displayed. If &#x60;false&#x60;, the category will be hidden from view. 
        /// </summary>
        /// <value>Flag to determine whether the product should be displayed to customers browsing the store. If &#x60;true&#x60;, the category will be displayed. If &#x60;false&#x60;, the category will be hidden from view. </value>
        [DataMember(Name="is_visible", EmitDefaultValue=false)]
        public bool? IsVisible { get; set; }

        /// <summary>
        /// A valid layout file. (Please refer to [this article](https://support.bigcommerce.com/articles/Public/Creating-Custom-Template-Files/) on creating category files.) This field is writable only for stores with a Blueprint theme applied. 
        /// </summary>
        /// <value>A valid layout file. (Please refer to [this article](https://support.bigcommerce.com/articles/Public/Creating-Custom-Template-Files/) on creating category files.) This field is writable only for stores with a Blueprint theme applied. </value>
        [DataMember(Name="layout_file", EmitDefaultValue=false)]
        public string LayoutFile { get; set; }

        /// <summary>
        /// Custom meta description for the category page. If not defined, the store&#x27;s default meta description will be used. 
        /// </summary>
        /// <value>Custom meta description for the category page. If not defined, the store&#x27;s default meta description will be used. </value>
        [DataMember(Name="meta_description", EmitDefaultValue=false)]
        public string MetaDescription { get; set; }

        /// <summary>
        /// Custom meta keywords for the category page. If not defined, the store&#x27;s default keywords will be used. Must post as an array like: [\&quot;awesome\&quot;,\&quot;sauce\&quot;]. 
        /// </summary>
        /// <value>Custom meta keywords for the category page. If not defined, the store&#x27;s default keywords will be used. Must post as an array like: [\&quot;awesome\&quot;,\&quot;sauce\&quot;]. </value>
        [DataMember(Name="meta_keywords", EmitDefaultValue=false)]
        public List<string> MetaKeywords { get; set; }

        /// <summary>
        /// The name displayed for the category. Name is unique with respect to the category&#x27;s siblings. Required in a POST.
        /// </summary>
        /// <value>The name displayed for the category. Name is unique with respect to the category&#x27;s siblings. Required in a POST.</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Custom title for the category page. If not defined, the category name will be used as the meta title. 
        /// </summary>
        /// <value>Custom title for the category page. If not defined, the category name will be used as the meta title. </value>
        [DataMember(Name="page_title", EmitDefaultValue=false)]
        public string PageTitle { get; set; }

        /// <summary>
        /// The unique numeric ID of the category&#x27;s parent. This field controls where the category sits in the tree of categories that organize the catalog. Required in a POST if creating a child category.
        /// </summary>
        /// <value>The unique numeric ID of the category&#x27;s parent. This field controls where the category sits in the tree of categories that organize the catalog. Required in a POST if creating a child category.</value>
        [DataMember(Name="parent_id", EmitDefaultValue=false)]
        public int? ParentId { get; set; }

        /// <summary>
        /// A comma-separated list of keywords that can be used to locate the category when searching the store. 
        /// </summary>
        /// <value>A comma-separated list of keywords that can be used to locate the category when searching the store. </value>
        [DataMember(Name="search_keywords", EmitDefaultValue=false)]
        public string SearchKeywords { get; set; }

        /// <summary>
        /// Priority this category will be given when included in the menu and category pages. The lower the number, the closer to the top of the results the category will be. 
        /// </summary>
        /// <value>Priority this category will be given when included in the menu and category pages. The lower the number, the closer to the top of the results the category will be. </value>
        [DataMember(Name="sort_order", EmitDefaultValue=false)]
        public int? SortOrder { get; set; }

        /// <summary>
        /// Number of views the category has on the storefront. 
        /// </summary>
        /// <value>Number of views the category has on the storefront. </value>
        [DataMember(Name="views", EmitDefaultValue=false)]
        public int? Views { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CategoryFull {\n");
            sb.Append("  CustomUrl: ").Append(CustomUrl).Append("\n");
            sb.Append("  DefaultProductSort: ").Append(DefaultProductSort).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  IsVisible: ").Append(IsVisible).Append("\n");
            sb.Append("  LayoutFile: ").Append(LayoutFile).Append("\n");
            sb.Append("  MetaDescription: ").Append(MetaDescription).Append("\n");
            sb.Append("  MetaKeywords: ").Append(MetaKeywords).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PageTitle: ").Append(PageTitle).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  SearchKeywords: ").Append(SearchKeywords).Append("\n");
            sb.Append("  SortOrder: ").Append(SortOrder).Append("\n");
            sb.Append("  Views: ").Append(Views).Append("\n");
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
            return this.Equals(input as CategoryFull);
        }

        /// <summary>
        /// Returns true if CategoryFull instances are equal
        /// </summary>
        /// <param name="input">Instance of CategoryFull to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CategoryFull input)
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
                    this.DefaultProductSort == input.DefaultProductSort ||
                    (this.DefaultProductSort != null &&
                    this.DefaultProductSort.Equals(input.DefaultProductSort))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                    this.IsVisible == input.IsVisible ||
                    (this.IsVisible != null &&
                    this.IsVisible.Equals(input.IsVisible))
                ) && 
                (
                    this.LayoutFile == input.LayoutFile ||
                    (this.LayoutFile != null &&
                    this.LayoutFile.Equals(input.LayoutFile))
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
                    this.ParentId == input.ParentId ||
                    (this.ParentId != null &&
                    this.ParentId.Equals(input.ParentId))
                ) && 
                (
                    this.SearchKeywords == input.SearchKeywords ||
                    (this.SearchKeywords != null &&
                    this.SearchKeywords.Equals(input.SearchKeywords))
                ) && 
                (
                    this.SortOrder == input.SortOrder ||
                    (this.SortOrder != null &&
                    this.SortOrder.Equals(input.SortOrder))
                ) && 
                (
                    this.Views == input.Views ||
                    (this.Views != null &&
                    this.Views.Equals(input.Views))
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
                if (this.DefaultProductSort != null)
                    hashCode = hashCode * 59 + this.DefaultProductSort.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ImageUrl != null)
                    hashCode = hashCode * 59 + this.ImageUrl.GetHashCode();
                if (this.IsVisible != null)
                    hashCode = hashCode * 59 + this.IsVisible.GetHashCode();
                if (this.LayoutFile != null)
                    hashCode = hashCode * 59 + this.LayoutFile.GetHashCode();
                if (this.MetaDescription != null)
                    hashCode = hashCode * 59 + this.MetaDescription.GetHashCode();
                if (this.MetaKeywords != null)
                    hashCode = hashCode * 59 + this.MetaKeywords.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.PageTitle != null)
                    hashCode = hashCode * 59 + this.PageTitle.GetHashCode();
                if (this.ParentId != null)
                    hashCode = hashCode * 59 + this.ParentId.GetHashCode();
                if (this.SearchKeywords != null)
                    hashCode = hashCode * 59 + this.SearchKeywords.GetHashCode();
                if (this.SortOrder != null)
                    hashCode = hashCode * 59 + this.SortOrder.GetHashCode();
                if (this.Views != null)
                    hashCode = hashCode * 59 + this.Views.GetHashCode();
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
