# PriceLists.Model.PriceRecord
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Price** | **double?** | The list price for the variant mapped in a Price List. Overrides any existing or Catalog list price for the variant/product.  | [optional] 
**SalePrice** | **double?** | The sale price for the variant mapped in a Price List. Overrides any existing or Catalog sale price for the variant/product. If empty, the sale price will be treated as not being set on this variant.  | [optional] 
**RetailPrice** | **double?** | The retail price for the variant mapped in a Price List. Overrides any existing or Catalog retail price for the variant/product.  If empty, the retail price will be treated as not being set on this variant.  | [optional] 
**MapPrice** | **double?** | The MAP (Manufacturer&#x27;s Advertised Price) for the variant mapped in a Price List. Overrides any existing or Catalog MAP price for the variant/product. If empty, the MAP price will be treated as not being set on this variant.  | [optional] 
**BulkPricingTiers** | [**List&lt;BulkPricingTier&gt;**](BulkPricingTier.md) |  | [optional] 
**Sku** | **string** | The SKU code associated with this &#x60;Price Record&#x60; if requested and it exists.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

