# OrdersV3.Model.MetafieldBase
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PermissionSet** | **string** | Determines whether the field is completely private to the app that owns the field (&#x60;app_only&#x60;), or visible to other API consumers (&#x60;read&#x60;), or completely open for reading and writing to other apps (&#x60;write&#x60;). Can additionally grant storefront visibility to the field using (&#x60;read_and_sf_access&#x60;) or (&#x60;write_and_sf_access&#x60;).  | [optional] 
**Namespace** | **string** | Namespace for the metafield, for organizational purposes.  | [optional] 
**Key** | **string** | The name of the field, for example: &#x60;location_id&#x60;, &#x60;color&#x60;.  | [optional] 
**Value** | **string** | The value of the field, for example: &#x60;1&#x60;, &#x60;blue&#x60;.  | [optional] 
**Description** | **string** | Description for the metafields.  | [optional] 
**ResourceType** | **string** | The type of resource with which the metafield is associated.  | [optional] 
**ResourceId** | **int?** | The unique identifier for the resource with which the metafield is associated.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

