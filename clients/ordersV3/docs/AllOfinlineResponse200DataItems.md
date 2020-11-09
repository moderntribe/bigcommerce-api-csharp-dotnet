# BigCommerce.Model.AllOfinlineResponse200DataItems
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int?** | Unique identifier for the transaction.  | [optional] 
**OrderId** | **string** | Identifier for the BigCommerce Order with which this transaction is associated.  | [optional] 
**DateCreated** | **DateTime?** | The datetime of the transaction.  | [optional] 
**PaymentInstrumentToken** | **string** | This field contains internal BigPay token for stored card that is then mapped to the actual third-party token. We currently do not offer a way to get third party tokens.These tokens are read-only and do not return any information about the payment. | [optional] 
**AvsResult** | **Object** | Address Verification Service (AVS) result from the payment gateway. | [optional] 
**CvvResult** | **Object** | Card Verification Value result from the payment gateway. | [optional] 
**CreditCard** | **Object** | A credit-card model. | [optional] 
**GiftCertificate** | **Object** | A gift-certificate model. | [optional] 
**StoreCredit** | **Object** | A store credit model.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

