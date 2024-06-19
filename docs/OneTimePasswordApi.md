# Org.OpenAPITools.Api.OneTimePasswordApi

All URIs are relative to *https://api.thesmsworks.co.uk/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**OtpMessageidGet**](OneTimePasswordApi.md#otpmessageidget) | **GET** /otp/{messageid} | 
[**OtpSendPost**](OneTimePasswordApi.md#otpsendpost) | **POST** /otp/send | 
[**OtpVerifyPost**](OneTimePasswordApi.md#otpverifypost) | **POST** /otp/verify | 



## OtpMessageidGet

> OTPVerifyResponse OtpMessageidGet (string messageid)



Retrieve an OTP by it's message ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OtpMessageidGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OneTimePasswordApi(Configuration.Default);
            var messageid = "messageid_example";  // string | The ID of the OTP you would like returned

            try
            {
                OTPVerifyResponse result = apiInstance.OtpMessageidGet(messageid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OneTimePasswordApi.OtpMessageidGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **messageid** | **string**| The ID of the OTP you would like returned | 

### Return type

[**OTPVerifyResponse**](OTPVerifyResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OtpSendPost

> OTPResponse OtpSendPost (OTP otp)



Generate and send a One-Time Password

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OtpSendPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OneTimePasswordApi(Configuration.Default);
            var otp = new OTP(); // OTP | OTP properties

            try
            {
                OTPResponse result = apiInstance.OtpSendPost(otp);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OneTimePasswordApi.OtpSendPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **otp** | [**OTP**](OTP.md)| OTP properties | 

### Return type

[**OTPResponse**](OTPResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Success |  -  |
| **0** | Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## OtpVerifyPost

> OTPVerifyResponse OtpVerifyPost (OTPVerify passcode)



Verify a One-Time Password

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class OtpVerifyPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new OneTimePasswordApi(Configuration.Default);
            var passcode = new OTPVerify(); // OTPVerify | One-Time Password

            try
            {
                OTPVerifyResponse result = apiInstance.OtpVerifyPost(passcode);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling OneTimePasswordApi.OtpVerifyPost: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **passcode** | [**OTPVerify**](OTPVerify.md)| One-Time Password | 

### Return type

[**OTPVerifyResponse**](OTPVerifyResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **404** | Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

