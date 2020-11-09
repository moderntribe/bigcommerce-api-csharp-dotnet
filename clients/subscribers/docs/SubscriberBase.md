# Subscribers.Model.SubscriberBase
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **string** | The email of the subscriber. Must be unique.  | [optional] 
**FirstName** | **string** | The first name of the subscriber.  | [optional] 
**LastName** | **string** | The last name of the subscriber.  | [optional] 
**Source** | **string** | The source of the subscriber. Values are: &#x60;storefront&#x60;, &#x60;order&#x60;, or &#x60;custom&#x60;.  | [optional] 
**OrderId** | **int?** | The ID of the source order, if source was an order.  | [optional] 
**ChannelId** | **int?** | The channel ID where the subscriber was created. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

