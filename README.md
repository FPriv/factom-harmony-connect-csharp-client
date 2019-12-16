# harmony-connect-client - the C# library for the Harmony Connect

An easy to use API that helps you access the Factom blockchain.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0.19
- SDK version: 1.0.7
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://docs.harmony.factom.com](https://docs.harmony.factom.com)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

<a name="dependencies"></a>
## Dependencies
- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using harmony-connect-client.Api;
using harmony-connect-client.Client;
using harmony-connect-client.Model;
```
<a name="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out harmony-connect-client.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using harmony-connect-client.Api;
using harmony-connect-client.Client;
using harmony-connect-client.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: AppId
            Configuration.Default.ApiKey.Add("app_id", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("app_id", "Bearer");
            // Configure API key authorization: AppKey
            Configuration.Default.ApiKey.Add("app_key", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("app_key", "Bearer");

            var apiInstance = new ChainsApi();
            var chainId = 285904;  // string | Chain identifier

            try
            {
                // Get Chain Info
                Chain result = apiInstance.GetChainByID(chainId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChainsApi.GetChainByID: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://ephemeral.api.factom.com/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ChainsApi* | [**GetChainByID**](docs/ChainsApi.md#getchainbyid) | **GET** /chains/{chain_id} | Get Chain Info
*ChainsApi* | [**GetChains**](docs/ChainsApi.md#getchains) | **GET** /chains | Get All Chains
*ChainsApi* | [**PostChain**](docs/ChainsApi.md#postchain) | **POST** /chains | Create a Chain
*ChainsApi* | [**PostChainSearch**](docs/ChainsApi.md#postchainsearch) | **POST** /chains/search | Search Chains
*EntriesApi* | [**GetEntriesByChainID**](docs/EntriesApi.md#getentriesbychainid) | **GET** /chains/{chain_id}/entries | Get Chain's Entries
*EntriesApi* | [**GetEntryByHash**](docs/EntriesApi.md#getentrybyhash) | **GET** /chains/{chain_id}/entries/{entry_hash} | Get Entry Info
*EntriesApi* | [**GetFirstEntry**](docs/EntriesApi.md#getfirstentry) | **GET** /chains/{chain_id}/entries/first | Get Chain's First Entry
*EntriesApi* | [**GetLastEntry**](docs/EntriesApi.md#getlastentry) | **GET** /chains/{chain_id}/entries/last | Get Chain's Last Entry
*EntriesApi* | [**PostEntriesSearch**](docs/EntriesApi.md#postentriessearch) | **POST** /chains/{chain_id}/entries/search | Search Chain's Entries
*EntriesApi* | [**PostEntryToChainID**](docs/EntriesApi.md#postentrytochainid) | **POST** /chains/{chain_id}/entries | Create an Entry
*IdentitiesApi* | [**GetIdChainbyId**](docs/IdentitiesApi.md#getidchainbyid) | **GET** /identities/{identity_chain_id} | Get Identity Chain Info
*IdentitiesApi* | [**GetKeybyEntryHash**](docs/IdentitiesApi.md#getkeybyentryhash) | **GET** /identities/{identity_chain_id}/keys/{key_string} | Get Key Info
*IdentitiesApi* | [**GetKeysbyIdChainId**](docs/IdentitiesApi.md#getkeysbyidchainid) | **GET** /identities/{identity_chain_id}/keys | Get Identity Chain's Keys
*IdentitiesApi* | [**PostIdChain**](docs/IdentitiesApi.md#postidchain) | **POST** /identities | Create Identity Chain
*IdentitiesApi* | [**PostKeytoIdChainId**](docs/IdentitiesApi.md#postkeytoidchainid) | **POST** /identities/{identity_chain_id}/keys | Replace Identity Key
*InfoApi* | [**GetApiInfo**](docs/InfoApi.md#getapiinfo) | **GET** / | API Info
*ProofsApi* | [**GetAnchorbySearch**](docs/ProofsApi.md#getanchorbysearch) | **GET** /anchors/{object_id} | Get Object's Anchors
*ProofsApi* | [**GetReceiptsbyEntry**](docs/ProofsApi.md#getreceiptsbyentry) | **GET** /receipts/{entry_hash} | Get Entry's Receipts
*ProofsApi* | [**GetSearch**](docs/ProofsApi.md#getsearch) | **GET** /search | Search


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.ABlockEntry](docs/ABlockEntry.md)
 - [Model.ABlockEntryData](docs/ABlockEntryData.md)
 - [Model.ABlockEntryLink](docs/ABlockEntryLink.md)
 - [Model.ABlockEntryList](docs/ABlockEntryList.md)
 - [Model.ABlockList](docs/ABlockList.md)
 - [Model.ABlockLong](docs/ABlockLong.md)
 - [Model.ABlockLongDblock](docs/ABlockLongDblock.md)
 - [Model.ABlockLongNext](docs/ABlockLongNext.md)
 - [Model.ABlockLongPrev](docs/ABlockLongPrev.md)
 - [Model.ABlockShort](docs/ABlockShort.md)
 - [Model.ABlockShortDblock](docs/ABlockShortDblock.md)
 - [Model.Address](docs/Address.md)
 - [Model.AddressLink](docs/AddressLink.md)
 - [Model.AddressList](docs/AddressList.md)
 - [Model.AllInfo](docs/AllInfo.md)
 - [Model.AllInfoLinks](docs/AllInfoLinks.md)
 - [Model.AnchorLong](docs/AnchorLong.md)
 - [Model.AnchorLongData](docs/AnchorLongData.md)
 - [Model.BitcoinAnchor](docs/BitcoinAnchor.md)
 - [Model.Chain](docs/Chain.md)
 - [Model.ChainCreate](docs/ChainCreate.md)
 - [Model.ChainData](docs/ChainData.md)
 - [Model.ChainDataDblock](docs/ChainDataDblock.md)
 - [Model.ChainDataEblock](docs/ChainDataEblock.md)
 - [Model.ChainDataEntries](docs/ChainDataEntries.md)
 - [Model.ChainLink](docs/ChainLink.md)
 - [Model.ChainList](docs/ChainList.md)
 - [Model.ChainListData](docs/ChainListData.md)
 - [Model.ChainShort](docs/ChainShort.md)
 - [Model.CommitLink](docs/CommitLink.md)
 - [Model.CommitLong](docs/CommitLong.md)
 - [Model.DBlockLink](docs/DBlockLink.md)
 - [Model.DBlockList](docs/DBlockList.md)
 - [Model.DBlockLong](docs/DBlockLong.md)
 - [Model.DBlockLongAblock](docs/DBlockLongAblock.md)
 - [Model.DBlockLongBtcAnchorEntry](docs/DBlockLongBtcAnchorEntry.md)
 - [Model.DBlockLongBtcAnchorEntryChain](docs/DBlockLongBtcAnchorEntryChain.md)
 - [Model.DBlockLongEblocks](docs/DBlockLongEblocks.md)
 - [Model.DBlockLongEcblock](docs/DBlockLongEcblock.md)
 - [Model.DBlockLongFblock](docs/DBlockLongFblock.md)
 - [Model.DBlockLongNext](docs/DBlockLongNext.md)
 - [Model.DBlockLongPrev](docs/DBlockLongPrev.md)
 - [Model.DBlockShort](docs/DBlockShort.md)
 - [Model.EBlockLink](docs/EBlockLink.md)
 - [Model.EBlockLinkChain](docs/EBlockLinkChain.md)
 - [Model.EBlockList](docs/EBlockList.md)
 - [Model.EBlockLong](docs/EBlockLong.md)
 - [Model.EBlockLongNext](docs/EBlockLongNext.md)
 - [Model.EBlockLongPrev](docs/EBlockLongPrev.md)
 - [Model.EBlockShort](docs/EBlockShort.md)
 - [Model.EBlockShortChain](docs/EBlockShortChain.md)
 - [Model.EBlockShortDblock](docs/EBlockShortDblock.md)
 - [Model.ECBlockEntryList](docs/ECBlockEntryList.md)
 - [Model.ECBlockList](docs/ECBlockList.md)
 - [Model.ECBlockLong](docs/ECBlockLong.md)
 - [Model.ECBlockLongDblock](docs/ECBlockLongDblock.md)
 - [Model.ECBlockShort](docs/ECBlockShort.md)
 - [Model.Entry](docs/Entry.md)
 - [Model.EntryCreate](docs/EntryCreate.md)
 - [Model.EntryData](docs/EntryData.md)
 - [Model.EntryDataDblock](docs/EntryDataDblock.md)
 - [Model.EntryDataEblock](docs/EntryDataEblock.md)
 - [Model.EntryList](docs/EntryList.md)
 - [Model.EntryListChain](docs/EntryListChain.md)
 - [Model.EntryListData](docs/EntryListData.md)
 - [Model.EntrySearchResponse](docs/EntrySearchResponse.md)
 - [Model.EntrySearchResponseData](docs/EntrySearchResponseData.md)
 - [Model.EntryShort](docs/EntryShort.md)
 - [Model.ErrorMessage](docs/ErrorMessage.md)
 - [Model.ErrorMessageErrors](docs/ErrorMessageErrors.md)
 - [Model.EthereumAnchor](docs/EthereumAnchor.md)
 - [Model.FBlockList](docs/FBlockList.md)
 - [Model.FBlockLong](docs/FBlockLong.md)
 - [Model.FBlockLongNext](docs/FBlockLongNext.md)
 - [Model.FBlockLongPrev](docs/FBlockLongPrev.md)
 - [Model.FBlockShort](docs/FBlockShort.md)
 - [Model.FactomAnchor](docs/FactomAnchor.md)
 - [Model.IdentityChain](docs/IdentityChain.md)
 - [Model.IdentityCreate](docs/IdentityCreate.md)
 - [Model.IdentityKey](docs/IdentityKey.md)
 - [Model.IdentityKeyData](docs/IdentityKeyData.md)
 - [Model.IdentityKeyReplace](docs/IdentityKeyReplace.md)
 - [Model.IdentityKeyShort](docs/IdentityKeyShort.md)
 - [Model.IdentityKeyShortData](docs/IdentityKeyShortData.md)
 - [Model.InlineResponse200](docs/InlineResponse200.md)
 - [Model.InlineResponse200Data](docs/InlineResponse200Data.md)
 - [Model.KeyList](docs/KeyList.md)
 - [Model.MerkleNode](docs/MerkleNode.md)
 - [Model.ReceiptLong](docs/ReceiptLong.md)
 - [Model.ReceiptLongData](docs/ReceiptLongData.md)
 - [Model.SearchBody](docs/SearchBody.md)
 - [Model.SingleAnchor](docs/SingleAnchor.md)
 - [Model.Transaction](docs/Transaction.md)
 - [Model.TransactionLink](docs/TransactionLink.md)
 - [Model.TransactionLinkShort](docs/TransactionLinkShort.md)
 - [Model.TransactionList](docs/TransactionList.md)
 - [Model.TransactionShort](docs/TransactionShort.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="AppId"></a>
### AppId

- **Type**: API key
- **API key parameter name**: app_id
- **Location**: HTTP header

<a name="AppKey"></a>
### AppKey

- **Type**: API key
- **API key parameter name**: app_key
- **Location**: HTTP header

