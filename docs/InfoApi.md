# harmony-connect-client.Api.InfoApi

All URIs are relative to *https://ephemeral.api.factom.com/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetApiInfo**](InfoApi.md#getapiinfo) | **GET** / | API Info


<a name="getapiinfo"></a>
# **GetApiInfo**
> AllInfo GetApiInfo ()

API Info

Request general information about the Connect API such as the version and available endpoints.

### Example
```csharp
using System;
using System.Diagnostics;
using harmony-connect-client.Api;
using harmony-connect-client.Client;
using harmony-connect-client.Model;

namespace Example
{
    public class GetApiInfoExample
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

            var apiInstance = new InfoApi();

            try
            {
                // API Info
                AllInfo result = apiInstance.GetApiInfo();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling InfoApi.GetApiInfo: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**AllInfo**](AllInfo.md)

### Authorization

[AppId](../README.md#AppId), [AppKey](../README.md#AppKey)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

