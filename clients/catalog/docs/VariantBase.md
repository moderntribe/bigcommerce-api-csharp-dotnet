# BigCommerce.Model.VariantBase
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BinPickingNumber** | **string** | Identifies where in a warehouse the variant is located. | [optional] 
**CostPrice** | **double?** | The cost price of the variant. Not affected by Price List prices. | [optional] 
**Depth** | **double?** | Depth of the variant, which can be used when calculating shipping costs. If this value is &#x60;null&#x60;, the product&#x27;s default depth (set in the Product resource&#x27;s &#x60;depth&#x60; field) will be used as the base depth.  | [optional] 
**FixedCostShippingPrice** | **double?** | A fixed shipping cost for the variant. If defined, this value will be used during checkout instead of normal shipping-cost calculation.  | [optional] 
**Height** | **double?** | Height of the variant, which can be used when calculating shipping costs. If this value is &#x60;null&#x60;, the product&#x27;s default height (set in the Product resource&#x27;s &#x60;height&#x60; field) will be used as the base height.  | [optional] 
**InventoryLevel** | **int?** | Inventory level for the variant, which is used when the product&#x27;s inventory_tracking is set to &#x60;variant&#x60;. | [optional] 
**InventoryWarningLevel** | **int?** | When the variant hits this inventory level, it is considered low stock. | [optional] 
**IsFreeShipping** | **bool?** | Flag used to indicate whether the variant has free shipping. If &#x60;true&#x60;, the shipping cost for the variant will be zero.  | [optional] 
**Price** | **double?** | This variant&#x27;s base price on the storefront. If a Price List ID is used, the Price List value will be used. If a Price List ID is not used, and this value is &#x60;null&#x60;, the product&#x27;s default price (set in the Product resource&#x27;s &#x60;price&#x60; field) will be used as the base price. | [optional] 
**PurchasingDisabled** | **bool?** | If &#x60;true&#x60;, this variant will not be purchasable on the storefront. | [optional] 
**PurchasingDisabledMessage** | **string** | If &#x60;purchasing_disabled&#x60; is &#x60;true&#x60;, this message should show on the storefront when the variant is selected. | [optional] 
**RetailPrice** | **double?** | This variant&#x27;s retail price on the storefront. If a Price List ID is used, the Price List value will be used. If a Price List ID is not used, and this value is null, the product&#x27;s retail price (set in the Product resource&#x27;s &#x60;price&#x60; field) will be used as the retail price. | [optional] 
**SalePrice** | **double?** | This variant&#x27;s sale price on the storefront. If a Price List ID is used, the Price List value will be used. If a Price List ID is not used, and this value is null, the product&#x27;s sale price (set in the Product resource&#x27;s &#x60;price&#x60; field) will be used as the sale price. | [optional] 
**Upc** | **string** | The UPC code used in feeds for shopping comparison sites and external channel integrations. | [optional] 
**Weight** | **double?** | This variant&#x27;s base weight on the storefront. If this value is null, the product&#x27;s default weight (set in the Product resource&#x27;s weight field) will be used as the base weight. | [optional] 
**Width** | **double?** | Width of the variant, which can be used when calculating shipping costs. If this value is &#x60;null&#x60;, the product&#x27;s default width (set in the Product resource&#x27;s &#x60;width&#x60; field) will be used as the base width.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

