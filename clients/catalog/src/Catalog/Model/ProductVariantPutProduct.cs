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
    /// The model for a PUT to update variants on a product. 
    /// </summary>
    [DataContract]
        public partial class ProductVariantPutProduct :  IEquatable<ProductVariantPutProduct>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductVariantPutProduct" /> class.
        /// </summary>
        /// <param name="binPickingNumber">Identifies where in a warehouse the variant is located..</param>
        /// <param name="costPrice">The cost price of the variant. Not affected by Price List prices..</param>
        /// <param name="depth">Depth of the variant, which can be used when calculating shipping costs. If this value is &#x60;null&#x60;, the product&#x27;s default depth (set in the Product resource&#x27;s &#x60;depth&#x60; field) will be used as the base depth. .</param>
        /// <param name="fixedCostShippingPrice">A fixed shipping cost for the variant. If defined, this value will be used during checkout instead of normal shipping-cost calculation. .</param>
        /// <param name="height">Height of the variant, which can be used when calculating shipping costs. If this value is &#x60;null&#x60;, the product&#x27;s default height (set in the Product resource&#x27;s &#x60;height&#x60; field) will be used as the base height. .</param>
        /// <param name="inventoryLevel">Inventory level for the variant, which is used when the product&#x27;s inventory_tracking is set to &#x60;variant&#x60;..</param>
        /// <param name="inventoryWarningLevel">When the variant hits this inventory level, it is considered low stock..</param>
        /// <param name="isFreeShipping">Flag used to indicate whether the variant has free shipping. If &#x60;true&#x60;, the shipping cost for the variant will be zero. .</param>
        /// <param name="price">This variant&#x27;s base price on the storefront. If a Price List ID is used, the Price List value will be used. If a Price List ID is not used, and this value is &#x60;null&#x60;, the product&#x27;s default price (set in the Product resource&#x27;s &#x60;price&#x60; field) will be used as the base price..</param>
        /// <param name="productId">productId.</param>
        /// <param name="purchasingDisabled">If &#x60;true&#x60;, this variant will not be purchasable on the storefront..</param>
        /// <param name="purchasingDisabledMessage">If &#x60;purchasing_disabled&#x60; is &#x60;true&#x60;, this message should show on the storefront when the variant is selected..</param>
        /// <param name="retailPrice">This variant&#x27;s retail price on the storefront. If a Price List ID is used, the Price List value will be used. If a Price List ID is not used, and this value is null, the product&#x27;s retail price (set in the Product resource&#x27;s &#x60;price&#x60; field) will be used as the retail price..</param>
        /// <param name="salePrice">This variant&#x27;s sale price on the storefront. If a Price List ID is used, the Price List value will be used. If a Price List ID is not used, and this value is null, the product&#x27;s sale price (set in the Product resource&#x27;s &#x60;price&#x60; field) will be used as the sale price..</param>
        /// <param name="sku">sku.</param>
        /// <param name="upc">The UPC code used in feeds for shopping comparison sites and external channel integrations..</param>
        /// <param name="weight">This variant&#x27;s base weight on the storefront. If this value is null, the product&#x27;s default weight (set in the Product resource&#x27;s weight field) will be used as the base weight..</param>
        /// <param name="width">Width of the variant, which can be used when calculating shipping costs. If this value is &#x60;null&#x60;, the product&#x27;s default width (set in the Product resource&#x27;s &#x60;width&#x60; field) will be used as the base width. .</param>
        public ProductVariantPutProduct(string binPickingNumber = default(string), double? costPrice = default(double?), double? depth = default(double?), double? fixedCostShippingPrice = default(double?), double? height = default(double?), int? inventoryLevel = default(int?), int? inventoryWarningLevel = default(int?), bool? isFreeShipping = default(bool?), double? price = default(double?), int? productId = default(int?), bool? purchasingDisabled = default(bool?), string purchasingDisabledMessage = default(string), double? retailPrice = default(double?), double? salePrice = default(double?), string sku = default(string), string upc = default(string), double? weight = default(double?), double? width = default(double?))
        {
            this.BinPickingNumber = binPickingNumber;
            this.CostPrice = costPrice;
            this.Depth = depth;
            this.FixedCostShippingPrice = fixedCostShippingPrice;
            this.Height = height;
            this.InventoryLevel = inventoryLevel;
            this.InventoryWarningLevel = inventoryWarningLevel;
            this.IsFreeShipping = isFreeShipping;
            this.Price = price;
            this.ProductId = productId;
            this.PurchasingDisabled = purchasingDisabled;
            this.PurchasingDisabledMessage = purchasingDisabledMessage;
            this.RetailPrice = retailPrice;
            this.SalePrice = salePrice;
            this.Sku = sku;
            this.Upc = upc;
            this.Weight = weight;
            this.Width = width;
        }
        
        /// <summary>
        /// Identifies where in a warehouse the variant is located.
        /// </summary>
        /// <value>Identifies where in a warehouse the variant is located.</value>
        [DataMember(Name="bin_picking_number", EmitDefaultValue=false)]
        public string BinPickingNumber { get; set; }

        /// <summary>
        /// The cost price of the variant. Not affected by Price List prices.
        /// </summary>
        /// <value>The cost price of the variant. Not affected by Price List prices.</value>
        [DataMember(Name="cost_price", EmitDefaultValue=false)]
        public double? CostPrice { get; set; }

        /// <summary>
        /// Depth of the variant, which can be used when calculating shipping costs. If this value is &#x60;null&#x60;, the product&#x27;s default depth (set in the Product resource&#x27;s &#x60;depth&#x60; field) will be used as the base depth. 
        /// </summary>
        /// <value>Depth of the variant, which can be used when calculating shipping costs. If this value is &#x60;null&#x60;, the product&#x27;s default depth (set in the Product resource&#x27;s &#x60;depth&#x60; field) will be used as the base depth. </value>
        [DataMember(Name="depth", EmitDefaultValue=false)]
        public double? Depth { get; set; }

        /// <summary>
        /// A fixed shipping cost for the variant. If defined, this value will be used during checkout instead of normal shipping-cost calculation. 
        /// </summary>
        /// <value>A fixed shipping cost for the variant. If defined, this value will be used during checkout instead of normal shipping-cost calculation. </value>
        [DataMember(Name="fixed_cost_shipping_price", EmitDefaultValue=false)]
        public double? FixedCostShippingPrice { get; set; }

        /// <summary>
        /// Height of the variant, which can be used when calculating shipping costs. If this value is &#x60;null&#x60;, the product&#x27;s default height (set in the Product resource&#x27;s &#x60;height&#x60; field) will be used as the base height. 
        /// </summary>
        /// <value>Height of the variant, which can be used when calculating shipping costs. If this value is &#x60;null&#x60;, the product&#x27;s default height (set in the Product resource&#x27;s &#x60;height&#x60; field) will be used as the base height. </value>
        [DataMember(Name="height", EmitDefaultValue=false)]
        public double? Height { get; set; }

        /// <summary>
        /// Inventory level for the variant, which is used when the product&#x27;s inventory_tracking is set to &#x60;variant&#x60;.
        /// </summary>
        /// <value>Inventory level for the variant, which is used when the product&#x27;s inventory_tracking is set to &#x60;variant&#x60;.</value>
        [DataMember(Name="inventory_level", EmitDefaultValue=false)]
        public int? InventoryLevel { get; set; }

        /// <summary>
        /// When the variant hits this inventory level, it is considered low stock.
        /// </summary>
        /// <value>When the variant hits this inventory level, it is considered low stock.</value>
        [DataMember(Name="inventory_warning_level", EmitDefaultValue=false)]
        public int? InventoryWarningLevel { get; set; }

        /// <summary>
        /// Flag used to indicate whether the variant has free shipping. If &#x60;true&#x60;, the shipping cost for the variant will be zero. 
        /// </summary>
        /// <value>Flag used to indicate whether the variant has free shipping. If &#x60;true&#x60;, the shipping cost for the variant will be zero. </value>
        [DataMember(Name="is_free_shipping", EmitDefaultValue=false)]
        public bool? IsFreeShipping { get; set; }

        /// <summary>
        /// This variant&#x27;s base price on the storefront. If a Price List ID is used, the Price List value will be used. If a Price List ID is not used, and this value is &#x60;null&#x60;, the product&#x27;s default price (set in the Product resource&#x27;s &#x60;price&#x60; field) will be used as the base price.
        /// </summary>
        /// <value>This variant&#x27;s base price on the storefront. If a Price List ID is used, the Price List value will be used. If a Price List ID is not used, and this value is &#x60;null&#x60;, the product&#x27;s default price (set in the Product resource&#x27;s &#x60;price&#x60; field) will be used as the base price.</value>
        [DataMember(Name="price", EmitDefaultValue=false)]
        public double? Price { get; set; }

        /// <summary>
        /// Gets or Sets ProductId
        /// </summary>
        [DataMember(Name="product_id", EmitDefaultValue=false)]
        public int? ProductId { get; set; }

        /// <summary>
        /// If &#x60;true&#x60;, this variant will not be purchasable on the storefront.
        /// </summary>
        /// <value>If &#x60;true&#x60;, this variant will not be purchasable on the storefront.</value>
        [DataMember(Name="purchasing_disabled", EmitDefaultValue=false)]
        public bool? PurchasingDisabled { get; set; }

        /// <summary>
        /// If &#x60;purchasing_disabled&#x60; is &#x60;true&#x60;, this message should show on the storefront when the variant is selected.
        /// </summary>
        /// <value>If &#x60;purchasing_disabled&#x60; is &#x60;true&#x60;, this message should show on the storefront when the variant is selected.</value>
        [DataMember(Name="purchasing_disabled_message", EmitDefaultValue=false)]
        public string PurchasingDisabledMessage { get; set; }

        /// <summary>
        /// This variant&#x27;s retail price on the storefront. If a Price List ID is used, the Price List value will be used. If a Price List ID is not used, and this value is null, the product&#x27;s retail price (set in the Product resource&#x27;s &#x60;price&#x60; field) will be used as the retail price.
        /// </summary>
        /// <value>This variant&#x27;s retail price on the storefront. If a Price List ID is used, the Price List value will be used. If a Price List ID is not used, and this value is null, the product&#x27;s retail price (set in the Product resource&#x27;s &#x60;price&#x60; field) will be used as the retail price.</value>
        [DataMember(Name="retail_price", EmitDefaultValue=false)]
        public double? RetailPrice { get; set; }

        /// <summary>
        /// This variant&#x27;s sale price on the storefront. If a Price List ID is used, the Price List value will be used. If a Price List ID is not used, and this value is null, the product&#x27;s sale price (set in the Product resource&#x27;s &#x60;price&#x60; field) will be used as the sale price.
        /// </summary>
        /// <value>This variant&#x27;s sale price on the storefront. If a Price List ID is used, the Price List value will be used. If a Price List ID is not used, and this value is null, the product&#x27;s sale price (set in the Product resource&#x27;s &#x60;price&#x60; field) will be used as the sale price.</value>
        [DataMember(Name="sale_price", EmitDefaultValue=false)]
        public double? SalePrice { get; set; }

        /// <summary>
        /// Gets or Sets Sku
        /// </summary>
        [DataMember(Name="sku", EmitDefaultValue=false)]
        public string Sku { get; set; }

        /// <summary>
        /// The UPC code used in feeds for shopping comparison sites and external channel integrations.
        /// </summary>
        /// <value>The UPC code used in feeds for shopping comparison sites and external channel integrations.</value>
        [DataMember(Name="upc", EmitDefaultValue=false)]
        public string Upc { get; set; }

        /// <summary>
        /// This variant&#x27;s base weight on the storefront. If this value is null, the product&#x27;s default weight (set in the Product resource&#x27;s weight field) will be used as the base weight.
        /// </summary>
        /// <value>This variant&#x27;s base weight on the storefront. If this value is null, the product&#x27;s default weight (set in the Product resource&#x27;s weight field) will be used as the base weight.</value>
        [DataMember(Name="weight", EmitDefaultValue=false)]
        public double? Weight { get; set; }

        /// <summary>
        /// Width of the variant, which can be used when calculating shipping costs. If this value is &#x60;null&#x60;, the product&#x27;s default width (set in the Product resource&#x27;s &#x60;width&#x60; field) will be used as the base width. 
        /// </summary>
        /// <value>Width of the variant, which can be used when calculating shipping costs. If this value is &#x60;null&#x60;, the product&#x27;s default width (set in the Product resource&#x27;s &#x60;width&#x60; field) will be used as the base width. </value>
        [DataMember(Name="width", EmitDefaultValue=false)]
        public double? Width { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductVariantPutProduct {\n");
            sb.Append("  BinPickingNumber: ").Append(BinPickingNumber).Append("\n");
            sb.Append("  CostPrice: ").Append(CostPrice).Append("\n");
            sb.Append("  Depth: ").Append(Depth).Append("\n");
            sb.Append("  FixedCostShippingPrice: ").Append(FixedCostShippingPrice).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  InventoryLevel: ").Append(InventoryLevel).Append("\n");
            sb.Append("  InventoryWarningLevel: ").Append(InventoryWarningLevel).Append("\n");
            sb.Append("  IsFreeShipping: ").Append(IsFreeShipping).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  PurchasingDisabled: ").Append(PurchasingDisabled).Append("\n");
            sb.Append("  PurchasingDisabledMessage: ").Append(PurchasingDisabledMessage).Append("\n");
            sb.Append("  RetailPrice: ").Append(RetailPrice).Append("\n");
            sb.Append("  SalePrice: ").Append(SalePrice).Append("\n");
            sb.Append("  Sku: ").Append(Sku).Append("\n");
            sb.Append("  Upc: ").Append(Upc).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
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
            return this.Equals(input as ProductVariantPutProduct);
        }

        /// <summary>
        /// Returns true if ProductVariantPutProduct instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductVariantPutProduct to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductVariantPutProduct input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BinPickingNumber == input.BinPickingNumber ||
                    (this.BinPickingNumber != null &&
                    this.BinPickingNumber.Equals(input.BinPickingNumber))
                ) && 
                (
                    this.CostPrice == input.CostPrice ||
                    (this.CostPrice != null &&
                    this.CostPrice.Equals(input.CostPrice))
                ) && 
                (
                    this.Depth == input.Depth ||
                    (this.Depth != null &&
                    this.Depth.Equals(input.Depth))
                ) && 
                (
                    this.FixedCostShippingPrice == input.FixedCostShippingPrice ||
                    (this.FixedCostShippingPrice != null &&
                    this.FixedCostShippingPrice.Equals(input.FixedCostShippingPrice))
                ) && 
                (
                    this.Height == input.Height ||
                    (this.Height != null &&
                    this.Height.Equals(input.Height))
                ) && 
                (
                    this.InventoryLevel == input.InventoryLevel ||
                    (this.InventoryLevel != null &&
                    this.InventoryLevel.Equals(input.InventoryLevel))
                ) && 
                (
                    this.InventoryWarningLevel == input.InventoryWarningLevel ||
                    (this.InventoryWarningLevel != null &&
                    this.InventoryWarningLevel.Equals(input.InventoryWarningLevel))
                ) && 
                (
                    this.IsFreeShipping == input.IsFreeShipping ||
                    (this.IsFreeShipping != null &&
                    this.IsFreeShipping.Equals(input.IsFreeShipping))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.PurchasingDisabled == input.PurchasingDisabled ||
                    (this.PurchasingDisabled != null &&
                    this.PurchasingDisabled.Equals(input.PurchasingDisabled))
                ) && 
                (
                    this.PurchasingDisabledMessage == input.PurchasingDisabledMessage ||
                    (this.PurchasingDisabledMessage != null &&
                    this.PurchasingDisabledMessage.Equals(input.PurchasingDisabledMessage))
                ) && 
                (
                    this.RetailPrice == input.RetailPrice ||
                    (this.RetailPrice != null &&
                    this.RetailPrice.Equals(input.RetailPrice))
                ) && 
                (
                    this.SalePrice == input.SalePrice ||
                    (this.SalePrice != null &&
                    this.SalePrice.Equals(input.SalePrice))
                ) && 
                (
                    this.Sku == input.Sku ||
                    (this.Sku != null &&
                    this.Sku.Equals(input.Sku))
                ) && 
                (
                    this.Upc == input.Upc ||
                    (this.Upc != null &&
                    this.Upc.Equals(input.Upc))
                ) && 
                (
                    this.Weight == input.Weight ||
                    (this.Weight != null &&
                    this.Weight.Equals(input.Weight))
                ) && 
                (
                    this.Width == input.Width ||
                    (this.Width != null &&
                    this.Width.Equals(input.Width))
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
                if (this.BinPickingNumber != null)
                    hashCode = hashCode * 59 + this.BinPickingNumber.GetHashCode();
                if (this.CostPrice != null)
                    hashCode = hashCode * 59 + this.CostPrice.GetHashCode();
                if (this.Depth != null)
                    hashCode = hashCode * 59 + this.Depth.GetHashCode();
                if (this.FixedCostShippingPrice != null)
                    hashCode = hashCode * 59 + this.FixedCostShippingPrice.GetHashCode();
                if (this.Height != null)
                    hashCode = hashCode * 59 + this.Height.GetHashCode();
                if (this.InventoryLevel != null)
                    hashCode = hashCode * 59 + this.InventoryLevel.GetHashCode();
                if (this.InventoryWarningLevel != null)
                    hashCode = hashCode * 59 + this.InventoryWarningLevel.GetHashCode();
                if (this.IsFreeShipping != null)
                    hashCode = hashCode * 59 + this.IsFreeShipping.GetHashCode();
                if (this.Price != null)
                    hashCode = hashCode * 59 + this.Price.GetHashCode();
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.PurchasingDisabled != null)
                    hashCode = hashCode * 59 + this.PurchasingDisabled.GetHashCode();
                if (this.PurchasingDisabledMessage != null)
                    hashCode = hashCode * 59 + this.PurchasingDisabledMessage.GetHashCode();
                if (this.RetailPrice != null)
                    hashCode = hashCode * 59 + this.RetailPrice.GetHashCode();
                if (this.SalePrice != null)
                    hashCode = hashCode * 59 + this.SalePrice.GetHashCode();
                if (this.Sku != null)
                    hashCode = hashCode * 59 + this.Sku.GetHashCode();
                if (this.Upc != null)
                    hashCode = hashCode * 59 + this.Upc.GetHashCode();
                if (this.Weight != null)
                    hashCode = hashCode * 59 + this.Weight.GetHashCode();
                if (this.Width != null)
                    hashCode = hashCode * 59 + this.Width.GetHashCode();
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
