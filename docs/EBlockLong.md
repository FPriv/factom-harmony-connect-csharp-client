# harmony-connect-client.Model.EBlockLong
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Keymr** | **string** | The Key Merkle Root for this entry block. | 
**Sequence** | **int?** | Shows where this entry block falls within the list of entry blocks that are contained in the parent directory block. | 
**Prev** | [**EBlockLongPrev**](EBlockLongPrev.md) |  | [optional] 
**Next** | [**EBlockLongNext**](EBlockLongNext.md) |  | [optional] 
**Chain** | [**EBlockShortChain**](EBlockShortChain.md) |  | 
**Dblock** | [**EBlockShortDblock**](EBlockShortDblock.md) |  | 
**StartedAt** | [**Object**](.md) | The timestamp for when this block was built. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; | 
**Href** | **string** | An API link to retrieve all information about this entry block. | 
**Entries** | **string** | An API link to all of the entries in this entry block. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

