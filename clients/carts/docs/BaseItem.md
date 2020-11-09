# BigCommerce.Model.BaseItem
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The line-item ID. | [optional] 
**VariantId** | [**decimal?**](BigDecimal.md) | The id of the variant. Required in the /PUT or /POST if the product has variants. | 
**ProductId** | [**decimal?**](BigDecimal.md) | The id of the product. Required in a /POST | 
**Sku** | **string** | SKU of the variant. | [optional] 
**Name** | **string** | The item&#x27;s product name. | [optional] 
**Url** | **string** | The product URL. | [optional] 
**Quantity** | [**decimal?**](BigDecimal.md) | Quantity of this item in the cart. | 
**IsTaxable** | **bool?** | Whether the item is taxable. | [optional] 
**ImageUrl** | **string** | Image of the product or variant. | [optional] 
**Discounts** | [**List&lt;AppliedDiscount1&gt;**](AppliedDiscount1.md) |  | [optional] 
**Coupons** | [**List&lt;AppliedCoupon1&gt;**](AppliedCoupon1.md) |  | [optional] 
**DiscountAmount** | [**decimal?**](BigDecimal.md) | The total value of all discounts applied to this item. This includes coupons and cart level discounts | [optional] 
**CouponAmount** | [**decimal?**](BigDecimal.md) | The total value of all coupons applied to this item. | [optional] 
**ListPrice** | [**decimal?**](BigDecimal.md) | Item&#x27;s list price, as quoted by the manufacturer/distributor. | [optional] 
**SalePrice** | [**decimal?**](BigDecimal.md) | Item&#x27;s price after all discounts are applied. (The final price before tax calculation.) | [optional] 
**ExtendedListPrice** | [**decimal?**](BigDecimal.md) | Item&#x27;s list price multiplied by the quantity. | [optional] 
**ExtendedSalePrice** | [**decimal?**](BigDecimal.md) | Item&#x27;s sale price multiplied by the quantity. | [optional] 
**Options** | [**List&lt;ProductOption&gt;**](ProductOption.md) | The list of selected options for this product. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

