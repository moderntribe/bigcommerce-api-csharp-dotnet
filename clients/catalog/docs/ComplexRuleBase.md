# Catalog.Model.ComplexRuleBase
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Conditions** | [**List&lt;ComplexRuleCondition&gt;**](ComplexRuleCondition.md) |  | [optional] 
**Enabled** | **bool?** | Flag for determining whether the rule is to be used when adjusting a product&#x27;s price, weight, image, or availabilty.  | [optional] 
**Id** | **int?** | The unique numeric ID of the rule; increments sequentially. Read-Only | [optional] 
**ImageUrl** | **string** | The URL for an image displayed on the storefront when the conditions are applied. Limit of 8MB per file.   | [optional] 
**PriceAdjuster** | [**Adjuster**](Adjuster.md) |  | [optional] 
**ProductId** | **int?** | The unique numeric ID of the product with which the rule is associated; increments sequentially.  | [optional] 
**PurchasingDisabled** | **bool?** | Flag for determining whether the rule should disable purchasing of a product when the conditions are applied.  | [optional] 
**PurchasingDisabledMessage** | **string** | Message displayed on the storefront when a rule disables the purchasing of a product.  | [optional] 
**PurchasingHidden** | **bool?** | Flag for determining whether the rule should hide purchasing of a product when the conditions are applied.  | [optional] 
**SortOrder** | **int?** | The priority to give this rule when making adjustments to the product properties.  | [optional] 
**Stop** | **bool?** | Flag for determining whether other rules should not be applied after this rule has been applied.  | [optional] 
**WeightAdjuster** | [**Adjuster**](Adjuster.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

