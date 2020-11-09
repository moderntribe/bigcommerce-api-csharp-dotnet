# BigCommerce.Model.ItemGiftCertificate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** |  | [optional] 
**Name** | **string** | GiftCertificate-provided name that will appear in the control panel. | [optional] 
**Theme** | **string** | Currently supports &#x60;Birthday&#x60;, &#x60;Boy&#x60;, &#x60;Celebration&#x60;, &#x60;Christmas&#x60;, &#x60;General&#x60;, and &#x60;Girl&#x60;. | 
**Amount** | [**decimal?**](BigDecimal.md) | Value must be between 1.00 and 1,000.00 in the store&#x27;s default currency. | 
**IsTaxable** | **bool?** |  | [optional] 
**Sender** | [**ContactEntity**](ContactEntity.md) |  | 
**Recipient** | [**ContactEntity**](ContactEntity.md) |  | 
**Message** | **string** | Limited to 200 characters. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

