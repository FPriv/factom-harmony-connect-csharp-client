# harmony-connect-client.Api.IdentitiesApi

All URIs are relative to *https://ephemeral.api.factom.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetIdChainbyId**](IdentitiesApi.md#getidchainbyid) | **GET** /identities/{identity_chain_id} | Get Identity Chain Info
[**GetKeybyEntryHash**](IdentitiesApi.md#getkeybyentryhash) | **GET** /identities/{identity_chain_id}/keys/{key_string} | Get Key Info
[**GetKeysbyIdChainId**](IdentitiesApi.md#getkeysbyidchainid) | **GET** /identities/{identity_chain_id}/keys | Get Identity Chain&#39;s Keys
[**PostIdChain**](IdentitiesApi.md#postidchain) | **POST** /identities | Create Identity Chain
[**PostKeytoIdChainId**](IdentitiesApi.md#postkeytoidchainid) | **POST** /identities/{identity_chain_id}/keys | Replace Identity Key


<a name="getidchainbyid"></a>
# **GetIdChainbyId**
> IdentityChain GetIdChainbyId (string identityChainId)

Get Identity Chain Info

Retrieve the details about a particular Identity Chain.

### Example
```csharp
using System;
using System.Diagnostics;
using harmony-connect-client.Api;
using harmony-connect-client.Client;
using harmony-connect-client.Model;

namespace Example
{
    public class GetIdChainbyIdExample
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

            var apiInstance = new IdentitiesApi();
            var identityChainId = 72933895e24e77d8a46482731386a6f177d61777179a5b11dde582e692910eb0;  // string | The hex encoded string that points to the identity's chain

            try
            {
                // Get Identity Chain Info
                IdentityChain result = apiInstance.GetIdChainbyId(identityChainId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentitiesApi.GetIdChainbyId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identityChainId** | **string**| The hex encoded string that points to the identity&#39;s chain | 

### Return type

[**IdentityChain**](IdentityChain.md)

### Authorization

[AppId](../README.md#AppId), [AppKey](../README.md#AppKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getkeybyentryhash"></a>
# **GetKeybyEntryHash**
> IdentityKey GetKeybyEntryHash (string identityChainId, string keyString)

Get Key Info

Retreive information about a specific public key for a given Identity, including the heights at which the key was activated and retired if applicable.

### Example
```csharp
using System;
using System.Diagnostics;
using harmony-connect-client.Api;
using harmony-connect-client.Client;
using harmony-connect-client.Model;

namespace Example
{
    public class GetKeybyEntryHashExample
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

            var apiInstance = new IdentitiesApi();
            var identityChainId = 72933895e24e77d8a46482731386a6f177d61777179a5b11dde582e692910eb0;  // string | The hex encoded string that points to the identity's chain
            var keyString = db;  // string | The public key string. Must be in base58 idpub format.

            try
            {
                // Get Key Info
                IdentityKey result = apiInstance.GetKeybyEntryHash(identityChainId, keyString);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentitiesApi.GetKeybyEntryHash: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identityChainId** | **string**| The hex encoded string that points to the identity&#39;s chain | 
 **keyString** | **string**| The public key string. Must be in base58 idpub format. | 

### Return type

[**IdentityKey**](IdentityKey.md)

### Authorization

[AppId](../README.md#AppId), [AppKey](../README.md#AppKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getkeysbyidchainid"></a>
# **GetKeysbyIdChainId**
> KeyList GetKeysbyIdChainId (string identityChainId, int? limit = null, int? offset = null)

Get Identity Chain's Keys

Returns all of the keys, past and present, associated with a particular Identity. Results are paginated and ordered by activation height.

### Example
```csharp
using System;
using System.Diagnostics;
using harmony-connect-client.Api;
using harmony-connect-client.Client;
using harmony-connect-client.Model;

namespace Example
{
    public class GetKeysbyIdChainIdExample
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

            var apiInstance = new IdentitiesApi();
            var identityChainId = 72933895e24e77d8a46482731386a6f177d61777179a5b11dde582e692910eb0;  // string | The hex encoded string that points to the identity's chain
            var limit = 15;  // int? | The number of items you would like back in each page. (optional) 
            var offset = 2;  // int? | The offset parameter allows you to select which item you would like to start from when you get back a list from Connect. For example, if you've already seen the first 15 items and you'd like the next set, you would send an offset of 15. `offset=0` starts from the first item of the set and is the default position. (optional) 

            try
            {
                // Get Identity Chain's Keys
                KeyList result = apiInstance.GetKeysbyIdChainId(identityChainId, limit, offset);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentitiesApi.GetKeysbyIdChainId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identityChainId** | **string**| The hex encoded string that points to the identity&#39;s chain | 
 **limit** | **int?**| The number of items you would like back in each page. | [optional] 
 **offset** | **int?**| The offset parameter allows you to select which item you would like to start from when you get back a list from Connect. For example, if you&#39;ve already seen the first 15 items and you&#39;d like the next set, you would send an offset of 15. &#x60;offset&#x3D;0&#x60; starts from the first item of the set and is the default position. | [optional] 

### Return type

[**KeyList**](KeyList.md)

### Authorization

[AppId](../README.md#AppId), [AppKey](../README.md#AppKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postidchain"></a>
# **PostIdChain**
> ChainShort PostIdChain (IdentityCreate identityCreate)

Create Identity Chain

Creates a new identity chain. To create the chain, you'll need to include a unique name array and an array of public keys. If successful, returns information about the chain that was created.

### Example
```csharp
using System;
using System.Diagnostics;
using harmony-connect-client.Api;
using harmony-connect-client.Client;
using harmony-connect-client.Model;

namespace Example
{
    public class PostIdChainExample
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

            var apiInstance = new IdentitiesApi();
            var identityCreate = new IdentityCreate(); // IdentityCreate | 

            try
            {
                // Create Identity Chain
                ChainShort result = apiInstance.PostIdChain(identityCreate);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentitiesApi.PostIdChain: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identityCreate** | [**IdentityCreate**](IdentityCreate.md)|  | 

### Return type

[**ChainShort**](ChainShort.md)

### Authorization

[AppId](../README.md#AppId), [AppKey](../README.md#AppKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postkeytoidchainid"></a>
# **PostKeytoIdChainId**
> EntryShort PostKeytoIdChainId (string identityChainId, IdentityKeyReplace identityKeyReplace)

Replace Identity Key

Retires an existing key from an identity and replaces it with a new one. To do this, a user must send the key to be replaced (`old_key`), the `new_key`, the signing key that authorizes the replacement and a signed message from the signing key. The signing key must be either equal to or senior to the key that is being replaced.  *Note: You may not reuse a key. If the `new_key` has been used by this Identity at any level, the replacement will fail.*

### Example
```csharp
using System;
using System.Diagnostics;
using harmony-connect-client.Api;
using harmony-connect-client.Client;
using harmony-connect-client.Model;

namespace Example
{
    public class PostKeytoIdChainIdExample
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

            var apiInstance = new IdentitiesApi();
            var identityChainId = 72933895e24e77d8a46482731386a6f177d61777179a5b11dde582e692910eb0;  // string | The hex encoded string that points to the identity's chain
            var identityKeyReplace = new IdentityKeyReplace(); // IdentityKeyReplace | 

            try
            {
                // Replace Identity Key
                EntryShort result = apiInstance.PostKeytoIdChainId(identityChainId, identityKeyReplace);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling IdentitiesApi.PostKeytoIdChainId: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **identityChainId** | **string**| The hex encoded string that points to the identity&#39;s chain | 
 **identityKeyReplace** | [**IdentityKeyReplace**](IdentityKeyReplace.md)|  | 

### Return type

[**EntryShort**](EntryShort.md)

### Authorization

[AppId](../README.md#AppId), [AppKey](../README.md#AppKey)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

