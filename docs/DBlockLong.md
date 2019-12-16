# harmony-connect-client.Model.DBlockLong
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Height** | **string** | The height of a directory block indicates how many blocks were created before this block. This is used to identify blocks in the blockchain. | [optional] 
**StartedAt** | **string** | The timestamp for when this block was built. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ssZ&#x60; | [optional] 
**Keymr** | **List&lt;string&gt;** | The Key Merkle Root for this block. | [optional] 
**BtcAnchorEntry** | [**DBlockLongBtcAnchorEntry**](DBlockLongBtcAnchorEntry.md) |  | [optional] 
**BtcBlockHash** | **string** | The bitcoin block hash for the bitcoin anchor that matches this directory block. | [optional] 
**BtcTransaction** | **string** | The bitcoin transaction ID for the transaction that includes the anchor message. | [optional] 
**Prev** | [**DBlockLongPrev**](DBlockLongPrev.md) |  | [optional] 
**Next** | [**DBlockLongNext**](DBlockLongNext.md) |  | [optional] 
**Ablock** | [**DBlockLongAblock**](DBlockLongAblock.md) |  | [optional] 
**Ecblock** | [**DBlockLongEcblock**](DBlockLongEcblock.md) |  | [optional] 
**Fblock** | [**DBlockLongFblock**](DBlockLongFblock.md) |  | [optional] 
**Eblocks** | [**List&lt;DBlockLongEblocks&gt;**](DBlockLongEblocks.md) | The entry blocks contained in this directory block. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

