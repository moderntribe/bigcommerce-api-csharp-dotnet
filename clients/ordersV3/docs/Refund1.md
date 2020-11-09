# BigCommerce.Model.Refund1
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Refund resource ID | [optional] 
**OrderId** | **int?** | Reference to order id | [optional] 
**UserId** | **int?** | Reference to the user&#x27;s id who create this refund. This is automatically populated by BigCommerce. | [optional] 
**Created** | **DateTime?** | Timestamp of when this refund was created | [optional] 
**Reason** | **string** | Reason for refund | [optional] 
**TotalAmount** | **float?** | A non-negative 2 decimal place rounded value that represents that amount that can be charged/refunded via payment providers | [optional] 
**TotalTax** | [**decimal?**](BigDecimal.md) | Total tax amount refunded back to shopper. Note: order_level_amount does not affect tax liability. This can be negative amount indicating we have collected tax by virtue of refunding less to the customer | [optional] 
**Items** | [**List&lt;RefundItem&gt;**](RefundItem.md) | Array of items refunded | [optional] 
**Payments** | [**List&lt;RefundPayment&gt;**](RefundPayment.md) | An array of refund payments made to payment providers | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

