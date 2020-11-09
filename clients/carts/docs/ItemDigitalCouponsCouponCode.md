# Carts.Model.ItemDigitalCouponsCouponCode
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Coupon Id | [optional] 
**Code** | **string** | The coupon code. Required in a /POST request. | [optional] 
**Name** | **string** | Name given to the coupon in the Control Panel | [optional] 
**DiscountType** | **int?** | The discount type.  - type 0: per_item_discount - type 1: percentage_discount - type 2: per_total_discount - type 3: shipping_discount - type 4: free_shipping | [optional] 
**DiscountAmount** | **int?** | The amount of the discount based on the coupoon. For example 3 percent off will show a 3. | [optional] 
**ExpiresDate** | **int?** | Returns 0 if a expiration date is not set | [optional] 
**TotalDiscount** | [**decimal?**](BigDecimal.md) | Total discount amount off cart | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

