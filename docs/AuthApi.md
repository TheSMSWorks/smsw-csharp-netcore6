# Org.OpenAPITools.Api.AuthApi

All URIs are relative to *https://api.thesmsworks.co.uk/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**KeySecret**](AuthApi.md#keysecret) | **GET** /auth/getApiKey |  |
| [**Login**](AuthApi.md#login) | **POST** /auth/token |  |

<a name="keysecret"></a>
# **KeySecret**
> ApiKeyResponse KeySecret (string customerid)



Utility method. Please generate your API key by following the instructions on your account page at https://thesmsworks.co.uk/user/login

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class KeySecretExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.thesmsworks.co.uk/v1";
            var apiInstance = new AuthApi(config);
            var customerid = "customerid_example";  // string | Utility method. Please generate your API key by following the instructions on your account page at https://thesmsworks.co.uk/user/login

            try
            {
                ApiKeyResponse result = apiInstance.KeySecret(customerid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.KeySecret: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the KeySecretWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ApiKeyResponse> response = apiInstance.KeySecretWithHttpInfo(customerid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.KeySecretWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customerid** | **string** | Utility method. Please generate your API key by following the instructions on your account page at https://thesmsworks.co.uk/user/login |  |

### Return type

[**ApiKeyResponse**](ApiKeyResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Success |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="login"></a>
# **Login**
> TokenResponse Login (Login credentials)



Generates a JSON Web Token for including in the Authorization header of all your calls to the API. This only needs to be done once. Generate the customer ID, API Key & Secret required for this call from the API Key tab your account page.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class LoginExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.thesmsworks.co.uk/v1";
            var apiInstance = new AuthApi(config);
            var credentials = new Login(); // Login | API Key & Secret

            try
            {
                TokenResponse result = apiInstance.Login(credentials);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AuthApi.Login: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the LoginWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<TokenResponse> response = apiInstance.LoginWithHttpInfo(credentials);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AuthApi.LoginWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **credentials** | [**Login**](Login.md) | API Key &amp; Secret |  |

### Return type

[**TokenResponse**](TokenResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

