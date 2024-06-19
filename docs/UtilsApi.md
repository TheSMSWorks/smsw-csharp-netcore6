# Org.OpenAPITools.Api.UtilsApi

All URIs are relative to *https://api.thesmsworks.co.uk/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UtilsErrorsErrorcodeGet**](UtilsApi.md#utilserrorserrorcodeget) | **GET** /utils/errors/{errorcode} | Get error by code
[**UtilsTestGet**](UtilsApi.md#utilstestget) | **GET** /utils/test | Return the customer ID to the caller



## UtilsErrorsErrorcodeGet

> ExtendedErrorModel UtilsErrorsErrorcodeGet (string errorcode)

Get error by code

Returns a sample error object for the given error code. Useful for designing code to react to errors when they occur for real.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UtilsErrorsErrorcodeGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UtilsApi(Configuration.Default);
            var errorcode = "errorcode_example";  // string | The code of the error you would like returned

            try
            {
                // Get error by code
                ExtendedErrorModel result = apiInstance.UtilsErrorsErrorcodeGet(errorcode);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UtilsApi.UtilsErrorsErrorcodeGet: " + e.Message );
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
 **errorcode** | **string**| The code of the error you would like returned | 

### Return type

[**ExtendedErrorModel**](ExtendedErrorModel.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **0** | Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UtilsTestGet

> TestResponse UtilsTestGet ()

Return the customer ID to the caller

A generic test method which can be used to verify that the API is up and that your calls are authenticated successfully

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class UtilsTestGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new UtilsApi(Configuration.Default);

            try
            {
                // Return the customer ID to the caller
                TestResponse result = apiInstance.UtilsTestGet();
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling UtilsApi.UtilsTestGet: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**TestResponse**](TestResponse.md)

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

