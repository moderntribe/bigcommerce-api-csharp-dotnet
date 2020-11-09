# BigCommerce.Model.TransactionPost
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Event** | **string** | Store event that created the transaction.  | 
**Method** | **string** | The payment method: &#x60;credit_card&#x60; - a credit-card transaction; &#x60;electronic_wallet&#x60; - an online wallet; &#x60;store_credit&#x60; - a transaction using store credit; &#x60;gift_certificate&#x60; - a transaction using a gift certificate; &#x60;custom&#x60; - manual payment methods; &#x60;token&#x60; - payment token; &#x60;nonce&#x60; - temporary payment token; &#x60;offsite&#x60; - online payment off the site (e.g., PayPal); &#x60;offline&#x60; - payment method that takes place offline.  | 
**Amount** | **float?** | Amount of money in the transaction.  | 
**Currency** | **string** | Currency used for the transaction.  | 
**Gateway** | **string** | The payment gateway, where applicable.  | 
**GatewayTransactionId** | **string** | The transaction ID returned by the payment gateway for this transaction item.  | [optional] 
**DateCreated** | **DateTime?** | The datetime of the transaction.  | [optional] 
**Test** | **bool?** | True if the transaction performed was a test, or if the gateway is in test mode.  | [optional] 
**Status** | **string** | Status of the transaction.  | [optional] 
**FraudReview** | **bool?** | Result of gateway fraud review, if any. Default is &#x60;false&#x60;.  | [optional] 
**ReferenceTransactionId** | **int?** | Identifier for an existing transaction upon which this transaction acts.  | [optional] 
**Offline** | [**Offline1**](Offline1.md) |  | [optional] 
**Custom** | [**Custom1**](Custom1.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

