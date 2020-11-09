# Catalog.Model.Brand2
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomUrl** | [**CustomUrlBrand**](CustomUrlBrand.md) |  | [optional] 
**Id** | **int?** | Unique ID of the *Brand*. Read-Only. | [optional] 
**ImageUrl** | **string** | Image URL used for this category on the storefront. Images can be uploaded via form file post to &#x60;/brands/{brandId}/image&#x60;, or by providing a publicly accessible URL in this field.  | [optional] 
**MetaDescription** | **string** | A meta description to include.  | [optional] 
**MetaKeywords** | **List&lt;string&gt;** | Comma-separated list of meta keywords to include in the HTML.  | [optional] 
**Name** | **string** | The name of the brand. Must be unique. Required in POST. | 
**PageTitle** | **string** | The title shown in the browser while viewing the brand.  | [optional] 
**SearchKeywords** | **string** | A comma-separated list of keywords that can be used to locate this brand.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

