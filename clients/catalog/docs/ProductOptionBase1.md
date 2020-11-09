# Catalog.Model.ProductOptionBase1
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Config** | [**OptionConfig**](OptionConfig.md) |  | [optional] 
**DisplayName** | **string** | The name of the option shown on the storefront.  | [optional] 
**Id** | **int?** | The unique numerical ID of the option, increments sequentially.  | [optional] 
**OptionValues** | **AllOfproductOptionBase1OptionValues** | Product Option &#x60;option_value&#x60;. | [optional] 
**ProductId** | **int?** | The unique numerical ID of the product to which the option belongs.  | [optional] 
**SortOrder** | **int?** | Order in which the option is displayed on the storefront.  | [optional] 
**Type** | **string** | The type of option, which determines how it will display on the storefront. Acceptable values: &#x60;radio_buttons&#x60;, &#x60;rectangles&#x60;, &#x60;dropdown&#x60;, &#x60;product_list&#x60;, &#x60;product_list_with_images&#x60;, &#x60;swatch&#x60;. For reference, the former v2 API values are: RB &#x3D; radio_buttons, RT &#x3D; rectangles, S &#x3D; dropdown, P &#x3D; product_list, PI &#x3D; product_list_with_images, CS &#x3D; swatch.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

