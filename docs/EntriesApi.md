# harmony-connect-client.Api.EntriesApi

All URIs are relative to *https://ephemeral.api.factom.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetEntriesByChainID**](EntriesApi.md#getentriesbychainid) | **GET** /chains/{chain_id}/entries | Get Chain&#39;s Entries
[**GetEntryByHash**](EntriesApi.md#getentrybyhash) | **GET** /chains/{chain_id}/entries/{entry_hash} | Get Entry Info
[**GetFirstEntry**](EntriesApi.md#getfirstentry) | **GET** /chains/{chain_id}/entries/first | Get Chain&#39;s First Entry
[**GetLastEntry**](EntriesApi.md#getlastentry) | **GET** /chains/{chain_id}/entries/last | Get Chain&#39;s Last Entry
[**PostEntriesSearch**](EntriesApi.md#postentriessearch) | **POST** /chains/{chain_id}/entries/search | Search Chain&#39;s Entries
[**PostEntryToChainID**](EntriesApi.md#postentrytochainid) | **POST** /chains/{chain_id}/entries | Create an Entry


<a name="getentriesbychainid"></a>
# **GetEntriesByChainID**
> EntryList GetEntriesByChainID (string chainId, int? limit = null, int? offset = null, string stages = null)

Get Chain's Entries

List all entries contained on the specified chain.

### Example
```csharp
using System;
using System.Diagnostics;
using harmony-connect-client.Api;
using harmony-connect-client.Client;
using harmony-connect-client.Model;

namespace Example
{
    public class GetEntriesByChainIDExample
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

            var apiInstance = new EntriesApi();
            var chainId = 285904;  // string | Chain identifier
            var limit = 15;  // int? | The number of items you would like back in each page. (optional) 
            var offset = 2;  // int? | The offset parameter allows you to select which item you would like to start from when you get back a list from Connect. For example, if you've already seen the first 15 items and you'd like the next set, you would send an offset of 15. `offset=0` starts from the first item of the set and is the default position. (optional) 
            var stages = stages_example;  // string | The immutability stages you want to restrict results to. You can choose any from `replicated`, `factom`, and `anchored`. If you would like to search among multiple stages, send them in a comma separated string. For example: `'replicated,factom'`. (optional) 

            try
            {
                // Get Chain's Entries
                EntryList result = apiInstance.GetEntriesByChainID(chainId, limit, offset, stages);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntriesApi.GetEntriesByChainID: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chainId** | **string**| Chain identifier | 
 **limit** | **int?**| The number of items you would like back in each page. | [optional] 
 **offset** | **int?**| The offset parameter allows you to select which item you would like to start from when you get back a list from Connect. For example, if you&#39;ve already seen the first 15 items and you&#39;d like the next set, you would send an offset of 15. &#x60;offset&#x3D;0&#x60; starts from the first item of the set and is the default position. | [optional] 
 **stages** | **string**| The immutability stages you want to restrict results to. You can choose any from &#x60;replicated&#x60;, &#x60;factom&#x60;, and &#x60;anchored&#x60;. If you would like to search among multiple stages, send them in a comma separated string. For example: &#x60;&#39;replicated,factom&#39;&#x60;. | [optional] 

### Return type

[**EntryList**](EntryList.md)

### Authorization

[AppId](../README.md#AppId), [AppKey](../README.md#AppKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getentrybyhash"></a>
# **GetEntryByHash**
> Entry GetEntryByHash (string chainId, string entryHash)

Get Entry Info

Returns information about a specific entry on Connect. The requested entry must be specified using the Chain ID and Entry Hash.

### Example
```csharp
using System;
using System.Diagnostics;
using harmony-connect-client.Api;
using harmony-connect-client.Client;
using harmony-connect-client.Model;

namespace Example
{
    public class GetEntryByHashExample
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

            var apiInstance = new EntriesApi();
            var chainId = 285904;  // string | Chain identifier
            var entryHash = db;  // string | The unique identitfier of the entry.

            try
            {
                // Get Entry Info
                Entry result = apiInstance.GetEntryByHash(chainId, entryHash);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntriesApi.GetEntryByHash: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chainId** | **string**| Chain identifier | 
 **entryHash** | **string**| The unique identitfier of the entry. | 

### Return type

[**Entry**](Entry.md)

### Authorization

[AppId](../README.md#AppId), [AppKey](../README.md#AppKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfirstentry"></a>
# **GetFirstEntry**
> Entry GetFirstEntry (string chainId)

Get Chain's First Entry

Retrieve the first entry that has been saved to this chain.

### Example
```csharp
using System;
using System.Diagnostics;
using harmony-connect-client.Api;
using harmony-connect-client.Client;
using harmony-connect-client.Model;

namespace Example
{
    public class GetFirstEntryExample
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

            var apiInstance = new EntriesApi();
            var chainId = 285904;  // string | Chain identifier

            try
            {
                // Get Chain's First Entry
                Entry result = apiInstance.GetFirstEntry(chainId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntriesApi.GetFirstEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chainId** | **string**| Chain identifier | 

### Return type

[**Entry**](Entry.md)

### Authorization

[AppId](../README.md#AppId), [AppKey](../README.md#AppKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlastentry"></a>
# **GetLastEntry**
> Entry GetLastEntry (string chainId)

Get Chain's Last Entry

Retrieve the last entry that has been saved to this chain.

### Example
```csharp
using System;
using System.Diagnostics;
using harmony-connect-client.Api;
using harmony-connect-client.Client;
using harmony-connect-client.Model;

namespace Example
{
    public class GetLastEntryExample
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

            var apiInstance = new EntriesApi();
            var chainId = 285904;  // string | Chain identifier

            try
            {
                // Get Chain's Last Entry
                Entry result = apiInstance.GetLastEntry(chainId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntriesApi.GetLastEntry: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chainId** | **string**| Chain identifier | 

### Return type

[**Entry**](Entry.md)

### Authorization

[AppId](../README.md#AppId), [AppKey](../README.md#AppKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postentriessearch"></a>
# **PostEntriesSearch**
> EntrySearchResponse PostEntriesSearch (string chainId, SearchBody searchBody, int? limit = null, int? offset = null)

Search Chain's Entries

Find all of the entries within the specified chain that have the requested `external_ids`.

### Example
```csharp
using System;
using System.Diagnostics;
using harmony-connect-client.Api;
using harmony-connect-client.Client;
using harmony-connect-client.Model;

namespace Example
{
    public class PostEntriesSearchExample
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

            var apiInstance = new EntriesApi();
            var chainId = 285904;  // string | Chain identifier
            var searchBody = new SearchBody(); // SearchBody | 
            var limit = 15;  // int? | The number of items you would like back in each page. (optional) 
            var offset = 2;  // int? | The offset parameter allows you to select which item you would like to start from when you get back a list from Connect. For example, if you've already seen the first 15 items and you'd like the next set, you would send an offset of 15. `offset=0` starts from the first item of the set and is the default position. (optional) 

            try
            {
                // Search Chain's Entries
                EntrySearchResponse result = apiInstance.PostEntriesSearch(chainId, searchBody, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntriesApi.PostEntriesSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chainId** | **string**| Chain identifier | 
 **searchBody** | [**SearchBody**](SearchBody.md)|  | 
 **limit** | **int?**| The number of items you would like back in each page. | [optional] 
 **offset** | **int?**| The offset parameter allows you to select which item you would like to start from when you get back a list from Connect. For example, if you&#39;ve already seen the first 15 items and you&#39;d like the next set, you would send an offset of 15. &#x60;offset&#x3D;0&#x60; starts from the first item of the set and is the default position. | [optional] 

### Return type

[**EntrySearchResponse**](EntrySearchResponse.md)

### Authorization

[AppId](../README.md#AppId), [AppKey](../README.md#AppKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postentrytochainid"></a>
# **PostEntryToChainID**
> EntryShort PostEntryToChainID (string chainId, EntryCreate entryCreate)

Create an Entry

Create a new entry for the selected chain. Content and external id must be uploaded in Base64 format.

### Example
```csharp
using System;
using System.Diagnostics;
using harmony-connect-client.Api;
using harmony-connect-client.Client;
using harmony-connect-client.Model;

namespace Example
{
    public class PostEntryToChainIDExample
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

            var apiInstance = new EntriesApi();
            var chainId = 285904;  // string | Chain identifier
            var entryCreate = new EntryCreate(); // EntryCreate | 

            try
            {
                // Create an Entry
                EntryShort result = apiInstance.PostEntryToChainID(chainId, entryCreate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EntriesApi.PostEntryToChainID: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chainId** | **string**| Chain identifier | 
 **entryCreate** | [**EntryCreate**](EntryCreate.md)|  | 

### Return type

[**EntryShort**](EntryShort.md)

### Authorization

[AppId](../README.md#AppId), [AppKey](../README.md#AppKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

