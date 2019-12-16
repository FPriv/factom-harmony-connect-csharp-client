# harmony-connect-client.Model.ChainData
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChainId** | **string** | This is the unique identifier created for each chain. | 
**Content** | **string** | This is the data that was stored in the first entry of this chain. | 
**ExternalIds** | **List&lt;string&gt;** | Tags that have been used to identify this entry. | 
**Stage** | **string** | The immutability stage that this chain has reached. | 
**Entries** | [**ChainDataEntries**](ChainDataEntries.md) |  | 
**Eblock** | [**ChainDataEblock**](ChainDataEblock.md) |  | [optional] 
**Dblock** | [**ChainDataDblock**](ChainDataDblock.md) |  | [optional] 
**CreatedAt** | **string** | The time at which this chain was created. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ss.ssssssZ&#x60; This will be null if the chain is not at least at the &#x60;factom&#x60; immutability stage. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

