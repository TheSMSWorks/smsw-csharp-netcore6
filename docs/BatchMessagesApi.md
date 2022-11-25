# Org.OpenAPITools.Api.BatchMessagesApi

All URIs are relative to *https://api.thesmsworks.co.uk/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelScheduledBatchJob**](BatchMessagesApi.md#cancelscheduledbatchjob) | **DELETE** /batches/schedule/{batchid} |  |
| [**GetBatchById**](BatchMessagesApi.md#getbatchbyid) | **GET** /batch/{batchid} |  |
| [**ScheduleBatch**](BatchMessagesApi.md#schedulebatch) | **POST** /batch/schedule |  |
| [**SendAny**](BatchMessagesApi.md#sendany) | **POST** /batch/any |  |
| [**SendBatch**](BatchMessagesApi.md#sendbatch) | **POST** /batch/send |  |

<a name="cancelscheduledbatchjob"></a>
# **CancelScheduledBatchJob**
> CancelledMessageResponse CancelScheduledBatchJob (string batchid)



Cancels a scheduled SMS message

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class CancelScheduledBatchJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BatchMessagesApi(config);
            var batchid = "batchid_example";  // string | The ID of the batch you would like returned

            try
            {
                CancelledMessageResponse result = apiInstance.CancelScheduledBatchJob(batchid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchMessagesApi.CancelScheduledBatchJob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelScheduledBatchJobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<CancelledMessageResponse> response = apiInstance.CancelScheduledBatchJobWithHttpInfo(batchid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchMessagesApi.CancelScheduledBatchJobWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchid** | **string** | The ID of the batch you would like returned |  |

### Return type

[**CancelledMessageResponse**](CancelledMessageResponse.md)

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

<a name="getbatchbyid"></a>
# **GetBatchById**
> List&lt;MessageResponse&gt; GetBatchById (string batchid)



Retrieve all messages in a batch with the given batch ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class GetBatchByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BatchMessagesApi(config);
            var batchid = "batchid_example";  // string | The ID of the batch you would like returned

            try
            {
                List<MessageResponse> result = apiInstance.GetBatchById(batchid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchMessagesApi.GetBatchById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBatchByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<MessageResponse>> response = apiInstance.GetBatchByIdWithHttpInfo(batchid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchMessagesApi.GetBatchByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchid** | **string** | The ID of the batch you would like returned |  |

### Return type

[**List&lt;MessageResponse&gt;**](MessageResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="schedulebatch"></a>
# **ScheduleBatch**
> ScheduledBatchResponse ScheduleBatch (BatchMessage smsMessage)



Schedules a batch of SMS messages to be sent at the date time you specify

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class ScheduleBatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BatchMessagesApi(config);
            var smsMessage = new BatchMessage(); // BatchMessage | Message properties

            try
            {
                ScheduledBatchResponse result = apiInstance.ScheduleBatch(smsMessage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchMessagesApi.ScheduleBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ScheduleBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<ScheduledBatchResponse> response = apiInstance.ScheduleBatchWithHttpInfo(smsMessage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchMessagesApi.ScheduleBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **smsMessage** | [**BatchMessage**](BatchMessage.md) | Message properties |  |

### Return type

[**ScheduledBatchResponse**](ScheduledBatchResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendany"></a>
# **SendAny**
> BatchMessageResponse SendAny (List<Message> messages)



Sends a collection of unique SMS messages. Batches may contain up to 5000 messages at a time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SendAnyExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BatchMessagesApi(config);
            var messages = new List<Message>(); // List<Message> | An array of messages

            try
            {
                BatchMessageResponse result = apiInstance.SendAny(messages);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchMessagesApi.SendAny: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendAnyWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BatchMessageResponse> response = apiInstance.SendAnyWithHttpInfo(messages);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchMessagesApi.SendAnyWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messages** | [**List&lt;Message&gt;**](Message.md) | An array of messages |  |

### Return type

[**BatchMessageResponse**](BatchMessageResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="sendbatch"></a>
# **SendBatch**
> BatchMessageResponse SendBatch (BatchMessage smsMessage)



Send a single SMS message to multiple recipients.  Batches may contain up to 5000 messages at a time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class SendBatchExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BatchMessagesApi(config);
            var smsMessage = new BatchMessage(); // BatchMessage | Message properties

            try
            {
                BatchMessageResponse result = apiInstance.SendBatch(smsMessage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchMessagesApi.SendBatch: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SendBatchWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<BatchMessageResponse> response = apiInstance.SendBatchWithHttpInfo(smsMessage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchMessagesApi.SendBatchWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **smsMessage** | [**BatchMessage**](BatchMessage.md) | Message properties |  |

### Return type

[**BatchMessageResponse**](BatchMessageResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

