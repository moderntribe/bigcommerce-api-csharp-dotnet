# PriceLists.Model.BulkPricingTier
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QuantityMin** | **int?** | The minimum quantity of associated variant in the cart needed to qualify for this tiers pricing.  | [optional] 
**QuantityMax** | **int?** | The maximum allowed quantity of associated variant in the cart to qualify for this tiers pricing.  | [optional] 
**Type** | **string** | The type of adjustment that is made. Acceptable values: price – the adjustment amount per product; percent – the adjustment as a percentage of the original price; fixed – the adjusted absolute price of the product.  | [optional] 
**Amount** | **double?** | The price adjustment amount. This value along with the type will decide the price per variant for the pricing tier.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

