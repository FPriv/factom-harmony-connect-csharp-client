# harmony-connect-client.Model.EntryCreate
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExternalIds** | **List&lt;string&gt;** | Tags that can be used to identify your entry. You can search for records that contain a particular &#x60;external_id&#x60; using Connect. External IDs should be sent in Base64. | 
**Content** | **string** | This is the data that will be stored directly on the blockchain. Please be sure that no private information is entered here. Content should be sent in Base64 format. | 
**CallbackUrl** | **string** | The address you&#39;d like the callback to be sent to. If this is not specified, callbacks will not activate. | [optional] 
**CallbackStages** | **List&lt;string&gt;** | The immutability stages you&#39;d like to be notified about. This list can include any or all of the three stages: &#x60;replicated&#x60;, &#x60;factom&#x60;, and &#x60;anchored&#x60;. If callbacks are activated and this field is not sent, it will default to &#x60;factom&#x60; and &#x60;anchored&#x60; | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

