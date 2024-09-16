# SMSWorks.Api.Api.CreditsApi

All URIs are relative to *https://api.thesmsworks.co.uk/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreditsBalanceGet**](CreditsApi.md#creditsbalanceget) | **GET** /credits/balance |  |
| [**CreditsCountrycodeGet**](CreditsApi.md#creditscountrycodeget) | **GET** /credits/{countrycode} |  |

<a id="creditsbalanceget"></a>
# **CreditsBalanceGet**
> CreditsResponse CreditsBalanceGet ()



The credit balance on your SMS Works account

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SMSWorks.Api.Api;
using SMSWorks.Api.Client;
using SMSWorks.Api.Model;

namespace Example
{
    public class CreditsBalanceGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CreditsApi(config);

            try
            {
                CreditsResponse result = apiInstance.CreditsBalanceGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreditsApi.CreditsBalanceGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreditsBalanceGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CreditsResponse> response = apiInstance.CreditsBalanceGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreditsApi.CreditsBalanceGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**CreditsResponse**](CreditsResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="creditscountrycodeget"></a>
# **CreditsCountrycodeGet**
> CountryResponse CreditsCountrycodeGet (string countrycode)



The credit cost for each SMS sent to the country code provided

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SMSWorks.Api.Api;
using SMSWorks.Api.Client;
using SMSWorks.Api.Model;

namespace Example
{
    public class CreditsCountrycodeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CreditsApi(config);
            var countrycode = "countrycode_example";  // string | The 2-letter ISO country code of the country you want to retrieve the credit cost for.

            try
            {
                CountryResponse result = apiInstance.CreditsCountrycodeGet(countrycode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreditsApi.CreditsCountrycodeGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreditsCountrycodeGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CountryResponse> response = apiInstance.CreditsCountrycodeGetWithHttpInfo(countrycode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling CreditsApi.CreditsCountrycodeGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **countrycode** | **string** | The 2-letter ISO country code of the country you want to retrieve the credit cost for. |  |

### Return type

[**CountryResponse**](CountryResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

