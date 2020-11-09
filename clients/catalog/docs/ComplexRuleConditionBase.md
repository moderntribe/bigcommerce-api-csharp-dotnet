# Catalog.Model.ComplexRuleConditionBase
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CombinationId** | **int?** | (READ-ONLY:) The unique numeric ID of the SKU (v2 API), or Combination, with which the rule condition is associated. This is to maintain cross-compatibility between v2 and v3.  | [optional] 
**Id** | **int?** | The unique numeric ID of the rule condition; increments sequentially. Read-Only  | [optional] 
**ModifierId** | **int?** | The unique numeric ID of the modifier with which the rule condition is associated. Required in /POST. | 
**ModifierValueId** | **int?** | The unique numeric ID of the modifier value with which the rule condition is associated. Required in /POST. | 
**RuleId** | **int?** | The unique numeric ID of the rule with which the condition is associated. Read-Only | [optional] 
**VariantId** | **int?** | The unique numeric ID of the variant with which the rule condition is associated. Required in /POST. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

