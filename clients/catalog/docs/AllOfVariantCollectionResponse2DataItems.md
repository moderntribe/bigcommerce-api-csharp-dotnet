# Catalog.Model.AllOfVariantCollectionResponse2DataItems
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CalculatedPrice** | **double?** | The price of the variant as seen on the storefront. This price takes into account &#x60;sale_price&#x60; and any price adjustment rules that are applicable to this variant.  | [optional] 
**Id** | **int?** |  | [optional] 
**OptionValues** | **List&lt;Object&gt;** | Array of option and option values IDs that make up this variant. Will be empty if the variant is the product&#x27;s base variant. | [optional] 
**ProductId** | **int?** |  | [optional] 
**Sku** | **string** |  | [optional] 
**SkuId** | **int?** | Read-only reference to v2 API&#x27;s SKU ID. Null if it is a base variant. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

