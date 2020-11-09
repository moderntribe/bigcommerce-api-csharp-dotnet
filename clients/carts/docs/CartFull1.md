# BigCommerce.Model.CartFull1
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Cart ID, provided after creating a cart with a POST. | [optional] 
**ParentId** | **string** | Bundled items will have their parent&#x27;s item Id. | [optional] 
**CustomerId** | **int?** | ID of the customer to which the cart belongs. | [optional] 
**Email** | **string** | The cart&#x27;s email. This is the same email that is used in the billing address | [optional] 
**Currency** | [**Currency1**](Currency1.md) |  | [optional] 
**TaxIncluded** | **bool?** |  | [optional] 
**BaseAmount** | [**decimal?**](BigDecimal.md) | Cost of cart&#x27;s contents, before applying discounts. | [optional] 
**DiscountAmount** | [**decimal?**](BigDecimal.md) | Discounted amount. | [optional] 
**CartAmount** | [**decimal?**](BigDecimal.md) | Sum of line-items amounts, minus cart-level discounts and coupons. This amount includes taxes (where applicable). | [optional] 
**Coupons** | [**List&lt;AppliedCoupon&gt;**](AppliedCoupon.md) |  | [optional] 
**Discounts** | [**List&lt;AppliedDiscount&gt;**](AppliedDiscount.md) |  | [optional] 
**LineItems** | [**List&lt;LineItem&gt;**](LineItem.md) |  | [optional] 
**CreatedTime** | **string** | Time when the cart was created. | [optional] 
**UpdatedTime** | **string** | Time when the cart was last updated. | [optional] 
**ChannelId** | **int?** | If no channel is specified, defaults to 1.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

