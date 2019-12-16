# harmony-connect-client.Api.ProofsApi

All URIs are relative to *https://ephemeral.api.factom.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAnchorbySearch**](ProofsApi.md#getanchorbysearch) | **GET** /anchors/{object_id} | Get Object&#39;s Anchors
[**GetReceiptsbyEntry**](ProofsApi.md#getreceiptsbyentry) | **GET** /receipts/{entry_hash} | Get Entry&#39;s Receipts
[**GetSearch**](ProofsApi.md#getsearch) | **GET** /search | Search


<a name="getanchorbysearch"></a>
# **GetAnchorbySearch**
> AnchorLong GetAnchorbySearch (string objectId)

Get Object's Anchors

Retreive the blockchain anchors of an entry, chain, or block. Returns an array of anchors that may be of type ethereum, bitcoin, or factom. The valid identifiers for the objects that can be anchored are as follows:  * Entry - Entry Hash * Chain - Chain ID * Directory Block - Height or Key Merkle Root * Entry Block - Key Merkle Root * Factoid Block - Key Merkle Root

### Example
```csharp
using System;
using System.Diagnostics;
using harmony-connect-client.Api;
using harmony-connect-client.Client;
using harmony-connect-client.Model;

namespace Example
{
    public class GetAnchorbySearchExample
    {
        public void main()
        {
            // Configure API key authorization: AppId
            Configuration.Default.AddApiKey("app_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("app_id", "Bearer");
            // Configure API key authorization: AppKey
            Configuration.Default.AddApiKey("app_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("app_key", "Bearer");

            var apiInstance = new ProofsApi();
            var objectId = objectId_example;  // string | Object identifier.  Used to identify an entry, chain, or block that has been published on the Factom blockchain. These objects can be identified by their hash, ID, height, or key Merkle root.

            try
            {
                // Get Object's Anchors
                AnchorLong result = apiInstance.GetAnchorbySearch(objectId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProofsApi.GetAnchorbySearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **objectId** | **string**| Object identifier.  Used to identify an entry, chain, or block that has been published on the Factom blockchain. These objects can be identified by their hash, ID, height, or key Merkle root. | 

### Return type

[**AnchorLong**](AnchorLong.md)

### Authorization

[AppId](../README.md#AppId), [AppKey](../README.md#AppKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreceiptsbyentry"></a>
# **GetReceiptsbyEntry**
> ReceiptLong GetReceiptsbyEntry (string entryHash)

Get Entry's Receipts

Retrieve a receipt providing cryptographically verifiable proof that information was recorded in the Factom blockchain.

### Example
```csharp
using System;
using System.Diagnostics;
using harmony-connect-client.Api;
using harmony-connect-client.Client;
using harmony-connect-client.Model;

namespace Example
{
    public class GetReceiptsbyEntryExample
    {
        public void main()
        {
            // Configure API key authorization: AppId
            Configuration.Default.AddApiKey("app_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("app_id", "Bearer");
            // Configure API key authorization: AppKey
            Configuration.Default.AddApiKey("app_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("app_key", "Bearer");

            var apiInstance = new ProofsApi();
            var entryHash = db;  // string | The unique identitfier of the entry.

            try
            {
                // Get Entry's Receipts
                ReceiptLong result = apiInstance.GetReceiptsbyEntry(entryHash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProofsApi.GetReceiptsbyEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **entryHash** | **string**| The unique identitfier of the entry. | 

### Return type

[**ReceiptLong**](ReceiptLong.md)

### Authorization

[AppId](../README.md#AppId), [AppKey](../README.md#AppKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsearch"></a>
# **GetSearch**
> InlineResponse200 GetSearch (string term = null, string allowedStages = null)

Search

Search for something on the Factom blockchain. You may search for Directory Blocks (by height or key Merkle root), Entry Blocks (by key Merkle root), Factoid Blocks (by key Merkle root), Chains (by Chain ID), Entries (by Entry Hash), Addresses (by user address or address), and Transactions (by transaction ID).

### Example
```csharp
using System;
using System.Diagnostics;
using harmony-connect-client.Api;
using harmony-connect-client.Client;
using harmony-connect-client.Model;

namespace Example
{
    public class GetSearchExample
    {
        public void main()
        {
            // Configure API key authorization: AppId
            Configuration.Default.AddApiKey("app_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("app_id", "Bearer");
            // Configure API key authorization: AppKey
            Configuration.Default.AddApiKey("app_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("app_key", "Bearer");

            var apiInstance = new ProofsApi();
            var term = term_example;  // string | The term that you are searching for. You may search for Directory Blocks (by height or key Merkle root), Entry Blocks (by key Merkle root), Factoid Blocks (by key Merkle root), Chains (by Chain ID), Entries (by Entry Hash), Addresses (by user address or address), and Transactions (by transaction ID). (optional) 
            var allowedStages = allowedStages_example;  // string | When entered, filters chain and entry responses by immutability stage. Must be either `replicated`, `factom`, or `anchored`. (optional) 

            try
            {
                // Search
                InlineResponse200 result = apiInstance.GetSearch(term, allowedStages);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ProofsApi.GetSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **term** | **string**| The term that you are searching for. You may search for Directory Blocks (by height or key Merkle root), Entry Blocks (by key Merkle root), Factoid Blocks (by key Merkle root), Chains (by Chain ID), Entries (by Entry Hash), Addresses (by user address or address), and Transactions (by transaction ID). | [optional] 
 **allowedStages** | **string**| When entered, filters chain and entry responses by immutability stage. Must be either &#x60;replicated&#x60;, &#x60;factom&#x60;, or &#x60;anchored&#x60;. | [optional] 

### Return type

[**InlineResponse200**](InlineResponse200.md)

### Authorization

[AppId](../README.md#AppId), [AppKey](../README.md#AppKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

