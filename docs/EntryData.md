# harmony-connect-client.Model.EntryData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntryHash** | **string** | The unique identitfier of the entry. | 
**Chain** | [**EntryListChain**](EntryListChain.md) |  | 
**CreatedAt** | **string** | The time when this entry was created. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ss.ssssssZ&#x60; | [optional] 
**ExternalIds** | **List&lt;string&gt;** | Tags that can be used to identify your entry. You can search for records that contain a particular &#x60;external_id&#x60; using Connect. External IDs are returned in Base64. | 
**Content** | **string** | This is the data that is stored by the entry. Content will be sent in Base64 format. | 
**Stage** | **string** | The level of immutability that this entry has reached. | 
**Dblock** | [**EntryDataDblock**](EntryDataDblock.md) |  | [optional] 
**Eblock** | [**EntryDataEblock**](EntryDataEblock.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

