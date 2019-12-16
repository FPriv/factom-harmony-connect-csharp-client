# harmony-connect-client.Api.ChainsApi

All URIs are relative to *https://ephemeral.api.factom.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetChainByID**](ChainsApi.md#getchainbyid) | **GET** /chains/{chain_id} | Get Chain Info
[**GetChains**](ChainsApi.md#getchains) | **GET** /chains | Get All Chains
[**PostChain**](ChainsApi.md#postchain) | **POST** /chains | Create a Chain
[**PostChainSearch**](ChainsApi.md#postchainsearch) | **POST** /chains/search | Search Chains


<a name="getchainbyid"></a>
# **GetChainByID**
> Chain GetChainByID (string chainId)

Get Chain Info

Get information about a specific chain on Connect

### Example
```csharp
using System;
using System.Diagnostics;
using harmony-connect-client.Api;
using harmony-connect-client.Client;
using harmony-connect-client.Model;

namespace Example
{
    public class GetChainByIDExample
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

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chainId** | **string**| Chain identifier | 

### Return type

[**Chain**](Chain.md)

### Authorization

[AppId](../README.md#AppId), [AppKey](../README.md#AppKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getchains"></a>
# **GetChains**
> ChainList GetChains (int? limit = null, int? offset = null, string stages = null)

Get All Chains

Returns all of the chains on factomd.

### Example
```csharp
using System;
using System.Diagnostics;
using harmony-connect-client.Api;
using harmony-connect-client.Client;
using harmony-connect-client.Model;

namespace Example
{
    public class GetChainsExample
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

            var apiInstance = new ChainsApi();
            var limit = 15;  // int? | The number of items you would like back in each page. (optional) 
            var offset = 2;  // int? | The offset parameter allows you to select which item you would like to start from when you get back a list from Connect. For example, if you've already seen the first 15 items and you'd like the next set, you would send an offset of 15. `offset=0` starts from the first item of the set and is the default position. (optional) 
            var stages = stages_example;  // string | The immutability stages you want to restrict results to. You can choose any from `replicated`, `factom`, and `anchored`. If you would like to search among multiple stages, send them in a comma separated string. For example: `'replicated,factom'`. (optional) 

            try
            {
                // Get All Chains
                ChainList result = apiInstance.GetChains(limit, offset, stages);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChainsApi.GetChains: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **limit** | **int?**| The number of items you would like back in each page. | [optional] 
 **offset** | **int?**| The offset parameter allows you to select which item you would like to start from when you get back a list from Connect. For example, if you&#39;ve already seen the first 15 items and you&#39;d like the next set, you would send an offset of 15. &#x60;offset&#x3D;0&#x60; starts from the first item of the set and is the default position. | [optional] 
 **stages** | **string**| The immutability stages you want to restrict results to. You can choose any from &#x60;replicated&#x60;, &#x60;factom&#x60;, and &#x60;anchored&#x60;. If you would like to search among multiple stages, send them in a comma separated string. For example: &#x60;&#39;replicated,factom&#39;&#x60;. | [optional] 

### Return type

[**ChainList**](ChainList.md)

### Authorization

[AppId](../README.md#AppId), [AppKey](../README.md#AppKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postchain"></a>
# **PostChain**
> ChainShort PostChain (ChainCreate chainCreate)

Create a Chain

Create a new chain. Each chain functions as a mini-blockchain such that all of the entries are linked. Every entry relies on data from previous entries in the chain. Any unauthorized alterations to any of these entries can be detected. Be aware that data entered into the `content` and `external_ids` fields must be in Base64 format. Sending this request will cause Connect to create the first entry of the chain. The data entered into the `content` and `external_id` fields will be applied to this entry.

### Example
```csharp
using System;
using System.Diagnostics;
using harmony-connect-client.Api;
using harmony-connect-client.Client;
using harmony-connect-client.Model;

namespace Example
{
    public class PostChainExample
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

            var apiInstance = new ChainsApi();
            var chainCreate = new ChainCreate(); // ChainCreate | 

            try
            {
                // Create a Chain
                ChainShort result = apiInstance.PostChain(chainCreate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChainsApi.PostChain: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **chainCreate** | [**ChainCreate**](ChainCreate.md)|  | 

### Return type

[**ChainShort**](ChainShort.md)

### Authorization

[AppId](../README.md#AppId), [AppKey](../README.md#AppKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postchainsearch"></a>
# **PostChainSearch**
> ChainList PostChainSearch (SearchBody searchBody, int? limit = null, int? offset = null)

Search Chains

Finds all of the chains with `external_ids` that match what you've entered. External IDs must be sent in Base64 format.

### Example
```csharp
using System;
using System.Diagnostics;
using harmony-connect-client.Api;
using harmony-connect-client.Client;
using harmony-connect-client.Model;

namespace Example
{
    public class PostChainSearchExample
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

            var apiInstance = new ChainsApi();
            var searchBody = new SearchBody(); // SearchBody | 
            var limit = 15;  // int? | The number of items you would like back in each page. (optional) 
            var offset = 2;  // int? | The offset parameter allows you to select which item you would like to start from when you get back a list from Connect. For example, if you've already seen the first 15 items and you'd like the next set, you would send an offset of 15. `offset=0` starts from the first item of the set and is the default position. (optional) 

            try
            {
                // Search Chains
                ChainList result = apiInstance.PostChainSearch(searchBody, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ChainsApi.PostChainSearch: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **searchBody** | [**SearchBody**](SearchBody.md)|  | 
 **limit** | **int?**| The number of items you would like back in each page. | [optional] 
 **offset** | **int?**| The offset parameter allows you to select which item you would like to start from when you get back a list from Connect. For example, if you&#39;ve already seen the first 15 items and you&#39;d like the next set, you would send an offset of 15. &#x60;offset&#x3D;0&#x60; starts from the first item of the set and is the default position. | [optional] 

### Return type

[**ChainList**](ChainList.md)

### Authorization

[AppId](../README.md#AppId), [AppKey](../README.md#AppKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

