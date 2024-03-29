# harmony-connect-client.Model.SingleAnchor
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Network** | **string** | Indicates the blockchain network that contains this anchor. | 
**Status** | **string** | The confirmation status of the anchor. Either pending or confirmed. | 
**TxId** | **string** | Only returned for confirmed bitcoin or ethereum anchors. The bitcoin or ethereum transaction ID for the transaction that includes the anchor message. | [optional] 
**BlockHash** | **string** | Only returned for confirmed bitcoin or ethereum anchors. The hash of the bitcoin or ethereum block that contains the anchor message. | [optional] 
**CreatedAt** | **string** | Only returned for confirmed factom anchors. The time at which this entry was created. Sent in [ISO 8601 Format](https://en.wikipedia.org/wiki/ISO_8601). For example: &#x60;YYYY-MM-DDThh:mm:ss.ssssssZ&#x60; This will be null if the chain is not at least at the &#x60;factom&#x60; immutability stage. | [optional] 
**EntrySerialized** | **string** | Only returned for confirmed factom anchors. The raw data that makes up the entry. | [optional] 
**EntryHash** | **string** | Only returned for confirmed factom anchors. The unique identitfier of the entry. | [optional] 
**Dblock** | [**DBlockLink**](DBlockLink.md) |  | [optional] 
**MerkleBranch** | [**List&lt;MerkleNode&gt;**](MerkleNode.md) | Only returned for confirmed factom or ethereum anchors. The branch of the merkle tree that represents this anchor. Presented as an array of Merkle nodes. | [optional] 
**WindowStartHeight** | **int?** | Only returned for confirmed ethereum anchors. The height of the first ethereum block that contains an anchor for this directory block. Valid anchors for the Directory block in question may also be contained in subsequent ethereum blocks. | [optional] 
**WindowMr** | **string** | Only returned for confirmed ethereum anchors. Window Merkle Root. This is the Merkle root that was published in the ethereum transaction that anchors this directory block. The root represents every one of the 1000 Directory blocks that&#39;s included in this anchor. | [optional] 
**ContractAddress** | **string** | Only returned for confirmed ethereum anchors. The address of the contract that initiated the anchor transaction. | [optional] 
**TxIndex** | **int?** | Only returned for confirmed ethereum anchors. The index of the transaction within the block. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

