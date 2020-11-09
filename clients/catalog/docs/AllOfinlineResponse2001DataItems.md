# Catalog.Model.AllOfinlineResponse2001DataItems
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BaseVariantId** | **int?** | The unique identifier of the base variant associated with a simple product. This value is &#x60;null&#x60; for complex products. | [optional] 
**CalculatedPrice** | **float?** | The price of the product as seen on the storefront. It will be equal to the &#x60;sale_price&#x60;, if set, and the &#x60;price&#x60; if there is not a &#x60;sale_price&#x60;. | [optional] 
**DateCreated** | **DateTime?** | The date on which the product was created.  | [optional] 
**DateModified** | **DateTime?** | The date on which the product was modified.  | [optional] 
**Id** | **int?** | ID of the product. Read Only. | [optional] 
**MapPrice** | [**decimal?**](BigDecimal.md) | Minimum Advertised Price. | [optional] 
**Modifiers** | **List&lt;Object&gt;** |  | [optional] 
**OptionSetDisplay** | **string** | Legacy template setting which controls if the option set shows up to the side of or below the product image and description. | [optional] 
**OptionSetId** | **int?** | Indicates that the product is in an Option Set (legacy V2 concept). | [optional] 
**Options** | **List&lt;Object&gt;** |  | [optional] 
**Variants** | **Object** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

