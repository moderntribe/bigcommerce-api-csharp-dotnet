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
    /// Metafield for products, categories, variants, and brands. The max number of metafields allowed on each product, category, variant, or brand is fifty. For more information, see [Platform Limits](https://support.bigcommerce.com/s/article/Platform-Limits) in the Help Center.
    /// </summary>
    [DataContract]
        public partial class MetafieldBase :  IEquatable<MetafieldBase>, IValidatableObject
    {
        /// <summary>
        /// Determines the visibility and writeability of the field by other API consumers.  |Value|Description |-|-| |&#x60;app_only&#x60;|Private to the app that owns the field| |&#x60;read&#x60;|Visible to other API consumers| |&#x60;write&#x60;|Open for reading and writing by other API consumers| |&#x60;read_and_sf_access&#x60;|Visible to other API consumers, including on storefront| |&#x60;write_and_sf_access&#x60;|Open for reading and writing by other API consumers, including on storefront|
        /// </summary>
        /// <value>Determines the visibility and writeability of the field by other API consumers.  |Value|Description |-|-| |&#x60;app_only&#x60;|Private to the app that owns the field| |&#x60;read&#x60;|Visible to other API consumers| |&#x60;write&#x60;|Open for reading and writing by other API consumers| |&#x60;read_and_sf_access&#x60;|Visible to other API consumers, including on storefront| |&#x60;write_and_sf_access&#x60;|Open for reading and writing by other API consumers, including on storefront|</value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum PermissionSetEnum
        {
            /// <summary>
            /// Enum Apponly for value: app_only
            /// </summary>
            [EnumMember(Value = "app_only")]
            Apponly = 1,
            /// <summary>
            /// Enum Read for value: read
            /// </summary>
            [EnumMember(Value = "read")]
            Read = 2,
            /// <summary>
            /// Enum Write for value: write
            /// </summary>
            [EnumMember(Value = "write")]
            Write = 3,
            /// <summary>
            /// Enum Readandsfaccess for value: read_and_sf_access
            /// </summary>
            [EnumMember(Value = "read_and_sf_access")]
            Readandsfaccess = 4,
            /// <summary>
            /// Enum Writeandsfaccess for value: write_and_sf_access
            /// </summary>
            [EnumMember(Value = "write_and_sf_access")]
            Writeandsfaccess = 5        }
        /// <summary>
        /// Determines the visibility and writeability of the field by other API consumers.  |Value|Description |-|-| |&#x60;app_only&#x60;|Private to the app that owns the field| |&#x60;read&#x60;|Visible to other API consumers| |&#x60;write&#x60;|Open for reading and writing by other API consumers| |&#x60;read_and_sf_access&#x60;|Visible to other API consumers, including on storefront| |&#x60;write_and_sf_access&#x60;|Open for reading and writing by other API consumers, including on storefront|
        /// </summary>
        /// <value>Determines the visibility and writeability of the field by other API consumers.  |Value|Description |-|-| |&#x60;app_only&#x60;|Private to the app that owns the field| |&#x60;read&#x60;|Visible to other API consumers| |&#x60;write&#x60;|Open for reading and writing by other API consumers| |&#x60;read_and_sf_access&#x60;|Visible to other API consumers, including on storefront| |&#x60;write_and_sf_access&#x60;|Open for reading and writing by other API consumers, including on storefront|</value>
        [DataMember(Name="permission_set", EmitDefaultValue=false)]
        public PermissionSetEnum PermissionSet { get; set; }
        /// <summary>
        /// The type of resource with which the metafield is associated. 
        /// </summary>
        /// <value>The type of resource with which the metafield is associated. </value>
        [JsonConverter(typeof(StringEnumConverter))]
                public enum ResourceTypeEnum
        {
            /// <summary>
            /// Enum Category for value: category
            /// </summary>
            [EnumMember(Value = "category")]
            Category = 1,
            /// <summary>
            /// Enum Brand for value: brand
            /// </summary>
            [EnumMember(Value = "brand")]
            Brand = 2,
            /// <summary>
            /// Enum Product for value: product
            /// </summary>
            [EnumMember(Value = "product")]
            Product = 3,
            /// <summary>
            /// Enum Variant for value: variant
            /// </summary>
            [EnumMember(Value = "variant")]
            Variant = 4        }
        /// <summary>
        /// The type of resource with which the metafield is associated. 
        /// </summary>
        /// <value>The type of resource with which the metafield is associated. </value>
        [DataMember(Name="resource_type", EmitDefaultValue=false)]
        public ResourceTypeEnum? ResourceType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MetafieldBase" /> class.
        /// </summary>
        /// <param name="dateCreated">Date and time of the metafield&#x27;s creation. Read-Only. .</param>
        /// <param name="dateModified">Date and time when the metafield was last updated. Read-Only. .</param>
        /// <param name="description">Description for the metafields. .</param>
        /// <param name="id">Unique ID of the *Metafield*. Read-Only..</param>
        /// <param name="key">The name of the field, for example: &#x60;location_id&#x60;, &#x60;color&#x60;. Required for POST.  (required).</param>
        /// <param name="_namespace">Namespace for the metafield, for organizational purposes. This is set set by the developer. Required for POST.  (required).</param>
        /// <param name="permissionSet">Determines the visibility and writeability of the field by other API consumers.  |Value|Description |-|-| |&#x60;app_only&#x60;|Private to the app that owns the field| |&#x60;read&#x60;|Visible to other API consumers| |&#x60;write&#x60;|Open for reading and writing by other API consumers| |&#x60;read_and_sf_access&#x60;|Visible to other API consumers, including on storefront| |&#x60;write_and_sf_access&#x60;|Open for reading and writing by other API consumers, including on storefront| (required).</param>
        /// <param name="resourceId">The ID for the resource with which the metafield is associated. .</param>
        /// <param name="resourceType">The type of resource with which the metafield is associated. .</param>
        /// <param name="value">The value of the field, for example: &#x60;1&#x60;, &#x60;blue&#x60;. Required for POST.  (required).</param>
        public MetafieldBase(DateTime? dateCreated = default(DateTime?), DateTime? dateModified = default(DateTime?), string description = default(string), int? id = default(int?), string key = default(string), string _namespace = default(string), PermissionSetEnum permissionSet = default(PermissionSetEnum), int? resourceId = default(int?), ResourceTypeEnum? resourceType = default(ResourceTypeEnum?), string value = default(string))
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new InvalidDataException("key is a required property for MetafieldBase and cannot be null");
            }
            else
            {
                this.Key = key;
            }
            // to ensure "_namespace" is required (not null)
            if (_namespace == null)
            {
                throw new InvalidDataException("_namespace is a required property for MetafieldBase and cannot be null");
            }
            else
            {
                this.Namespace = _namespace;
            }
            // to ensure "permissionSet" is required (not null)
            if (permissionSet == null)
            {
                throw new InvalidDataException("permissionSet is a required property for MetafieldBase and cannot be null");
            }
            else
            {
                this.PermissionSet = permissionSet;
            }
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new InvalidDataException("value is a required property for MetafieldBase and cannot be null");
            }
            else
            {
                this.Value = value;
            }
            this.DateCreated = dateCreated;
            this.DateModified = dateModified;
            this.Description = description;
            this.Id = id;
            this.ResourceId = resourceId;
            this.ResourceType = resourceType;
        }
        
        /// <summary>
        /// Date and time of the metafield&#x27;s creation. Read-Only. 
        /// </summary>
        /// <value>Date and time of the metafield&#x27;s creation. Read-Only. </value>
        [DataMember(Name="date_created", EmitDefaultValue=false)]
        public DateTime? DateCreated { get; set; }

        /// <summary>
        /// Date and time when the metafield was last updated. Read-Only. 
        /// </summary>
        /// <value>Date and time when the metafield was last updated. Read-Only. </value>
        [DataMember(Name="date_modified", EmitDefaultValue=false)]
        public DateTime? DateModified { get; set; }

        /// <summary>
        /// Description for the metafields. 
        /// </summary>
        /// <value>Description for the metafields. </value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Unique ID of the *Metafield*. Read-Only.
        /// </summary>
        /// <value>Unique ID of the *Metafield*. Read-Only.</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public int? Id { get; set; }

        /// <summary>
        /// The name of the field, for example: &#x60;location_id&#x60;, &#x60;color&#x60;. Required for POST. 
        /// </summary>
        /// <value>The name of the field, for example: &#x60;location_id&#x60;, &#x60;color&#x60;. Required for POST. </value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Namespace for the metafield, for organizational purposes. This is set set by the developer. Required for POST. 
        /// </summary>
        /// <value>Namespace for the metafield, for organizational purposes. This is set set by the developer. Required for POST. </value>
        [DataMember(Name="namespace", EmitDefaultValue=false)]
        public string Namespace { get; set; }


        /// <summary>
        /// The ID for the resource with which the metafield is associated. 
        /// </summary>
        /// <value>The ID for the resource with which the metafield is associated. </value>
        [DataMember(Name="resource_id", EmitDefaultValue=false)]
        public int? ResourceId { get; set; }


        /// <summary>
        /// The value of the field, for example: &#x60;1&#x60;, &#x60;blue&#x60;. Required for POST. 
        /// </summary>
        /// <value>The value of the field, for example: &#x60;1&#x60;, &#x60;blue&#x60;. Required for POST. </value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MetafieldBase {\n");
            sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
            sb.Append("  DateModified: ").Append(DateModified).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Namespace: ").Append(Namespace).Append("\n");
            sb.Append("  PermissionSet: ").Append(PermissionSet).Append("\n");
            sb.Append("  ResourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as MetafieldBase);
        }

        /// <summary>
        /// Returns true if MetafieldBase instances are equal
        /// </summary>
        /// <param name="input">Instance of MetafieldBase to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MetafieldBase input)
        {
            if (input == null)
                return false;

            return 
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
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
                ) && 
                (
                    this.Namespace == input.Namespace ||
                    (this.Namespace != null &&
                    this.Namespace.Equals(input.Namespace))
                ) && 
                (
                    this.PermissionSet == input.PermissionSet ||
                    (this.PermissionSet != null &&
                    this.PermissionSet.Equals(input.PermissionSet))
                ) && 
                (
                    this.ResourceId == input.ResourceId ||
                    (this.ResourceId != null &&
                    this.ResourceId.Equals(input.ResourceId))
                ) && 
                (
                    this.ResourceType == input.ResourceType ||
                    (this.ResourceType != null &&
                    this.ResourceType.Equals(input.ResourceType))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.DateCreated != null)
                    hashCode = hashCode * 59 + this.DateCreated.GetHashCode();
                if (this.DateModified != null)
                    hashCode = hashCode * 59 + this.DateModified.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Namespace != null)
                    hashCode = hashCode * 59 + this.Namespace.GetHashCode();
                if (this.PermissionSet != null)
                    hashCode = hashCode * 59 + this.PermissionSet.GetHashCode();
                if (this.ResourceId != null)
                    hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceType != null)
                    hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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
