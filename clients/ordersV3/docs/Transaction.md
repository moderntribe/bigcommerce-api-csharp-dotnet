# OrdersV3.Model.Transaction
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Unique identifier for the transaction.  | [optional] 
**OrderId** | **string** | Identifier for the BigCommerce Order with which this transaction is associated.  | [optional] 
**DateCreated** | **DateTime?** | The datetime of the transaction.  | [optional] 
**PaymentInstrumentToken** | **string** | This field contains internal BigPay token for stored card that is then mapped to the actual third-party token. We currently do not offer a way to get third party tokens.These tokens are read-only and do not return any information about the payment. | [optional] 
**AvsResult** | [**AVSResults**](AVSResults.md) |  | [optional] 
**CvvResult** | [**CVVResult**](CVVResult.md) |  | [optional] 
**CreditCard** | [**CreditCard**](CreditCard.md) |  | [optional] 
**GiftCertificate** | [**GiftCertificate**](GiftCertificate.md) |  | [optional] 
**StoreCredit** | [**TransactionStoreCredit**](TransactionStoreCredit.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

