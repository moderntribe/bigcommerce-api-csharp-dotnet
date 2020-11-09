# Catalog.Model.MetafieldBase
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DateCreated** | **DateTime?** | Date and time of the metafield&#x27;s creation. Read-Only.  | [optional] 
**DateModified** | **DateTime?** | Date and time when the metafield was last updated. Read-Only.  | [optional] 
**Description** | **string** | Description for the metafields.  | [optional] 
**Id** | **int?** | Unique ID of the *Metafield*. Read-Only. | [optional] 
**Key** | **string** | The name of the field, for example: &#x60;location_id&#x60;, &#x60;color&#x60;. Required for POST.  | 
**Namespace** | **string** | Namespace for the metafield, for organizational purposes. This is set set by the developer. Required for POST.  | 
**PermissionSet** | **string** | Determines the visibility and writeability of the field by other API consumers.  |Value|Description |-|-| |&#x60;app_only&#x60;|Private to the app that owns the field| |&#x60;read&#x60;|Visible to other API consumers| |&#x60;write&#x60;|Open for reading and writing by other API consumers| |&#x60;read_and_sf_access&#x60;|Visible to other API consumers, including on storefront| |&#x60;write_and_sf_access&#x60;|Open for reading and writing by other API consumers, including on storefront| | 
**ResourceId** | **int?** | The ID for the resource with which the metafield is associated.  | [optional] 
**ResourceType** | **string** | The type of resource with which the metafield is associated.  | [optional] 
**Value** | **string** | The value of the field, for example: &#x60;1&#x60;, &#x60;blue&#x60;. Required for POST.  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

