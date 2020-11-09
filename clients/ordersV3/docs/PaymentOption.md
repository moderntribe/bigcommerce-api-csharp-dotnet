# OrdersV3.Model.PaymentOption
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProviderId** | **string** | Name of the payment method | [optional] 
**ProviderDescription** | **string** | Description for payment provider | [optional] 
**Amount** | [**decimal?**](BigDecimal.md) | amount to be refunded via this payment provider | [optional] 
**Offline** | **bool?** | Indicates the payment must be done offline due to constraints of the payment provider, such as partial refunds not being supported, or it being offline only such as cash on delivery of bank deposit. | [optional] 
**OfflineProvider** | **bool?** | Indicates if the payment provider is a strictly offline provider, such as cash on delivery or bank deposit. | [optional] 
**OfflineReason** | **string** | Reason the payment option is offline only, if applicable. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

