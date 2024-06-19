# Org.OpenAPITools.Api.BatchMessagesApi

All URIs are relative to *https://api.thesmsworks.co.uk/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BatchAnyPost**](BatchMessagesApi.md#batchanypost) | **POST** /batch/any | Send a collection of unique SMS messages
[**BatchBatchidGet**](BatchMessagesApi.md#batchbatchidget) | **GET** /batch/{batchid} | 
[**BatchSchedulePost**](BatchMessagesApi.md#batchschedulepost) | **POST** /batch/schedule | Schedule a batch of SMS messages
[**BatchSendPost**](BatchMessagesApi.md#batchsendpost) | **POST** /batch/send | Send an SMS message to multiple recipients
[**BatchesScheduleBatchidDelete**](BatchMessagesApi.md#batchesschedulebatchiddelete) | **DELETE** /batches/schedule/{batchid} | Cancel a scheduled batch



## BatchAnyPost

> BatchMessageResponse BatchAnyPost (Object messages)

Send a collection of unique SMS messages

Batches may contain up to 5000 messages at a time.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BatchAnyPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BatchMessagesApi(Configuration.Default);
            var messages = null;  // Object | An array of messages

            try
            {
                // Send a collection of unique SMS messages
                BatchMessageResponse result = apiInstance.BatchAnyPost(messages);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BatchMessagesApi.BatchAnyPost: " + e.Message );
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
 **messages** | **Object**| An array of messages | 

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
| **402** | Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## BatchBatchidGet

> List&lt;MessageResponse&gt; BatchBatchidGet (string batchid)



Retrieve all messages with the given batch ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BatchBatchidGetExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BatchMessagesApi(Configuration.Default);
            var batchid = "batchid_example";  // string | The ID of the batch you would like returned

            try
            {
                List<MessageResponse> result = apiInstance.BatchBatchidGet(batchid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BatchMessagesApi.BatchBatchidGet: " + e.Message );
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
 **batchid** | **string**| The ID of the batch you would like returned | 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## BatchSchedulePost

> ScheduledBatchResponse BatchSchedulePost (BatchMessage smsMessage)

Schedule a batch of SMS messages

Schedules a batch of SMS messages to be sent at the date/time you specify

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BatchSchedulePostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BatchMessagesApi(Configuration.Default);
            var smsMessage = new BatchMessage(); // BatchMessage | Message properties

            try
            {
                // Schedule a batch of SMS messages
                ScheduledBatchResponse result = apiInstance.BatchSchedulePost(smsMessage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BatchMessagesApi.BatchSchedulePost: " + e.Message );
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
 **smsMessage** | [**BatchMessage**](BatchMessage.md)| Message properties | 

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
| **402** | Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## BatchSendPost

> BatchMessageResponse BatchSendPost (BatchMessage smsMessage)

Send an SMS message to multiple recipients

Batches may contain up to 5000 messages at a time

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BatchSendPostExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BatchMessagesApi(Configuration.Default);
            var smsMessage = new BatchMessage(); // BatchMessage | Message properties

            try
            {
                // Send an SMS message to multiple recipients
                BatchMessageResponse result = apiInstance.BatchSendPost(smsMessage);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BatchMessagesApi.BatchSendPost: " + e.Message );
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
 **smsMessage** | [**BatchMessage**](BatchMessage.md)| Message properties | 

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
| **402** | Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## BatchesScheduleBatchidDelete

> CancelledMessageResponse BatchesScheduleBatchidDelete (string batchid)

Cancel a scheduled batch

Cancels a batch of scheduled messages using the supplied batch ID

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class BatchesScheduleBatchidDeleteExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            Configuration.Default.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new BatchMessagesApi(Configuration.Default);
            var batchid = "batchid_example";  // string | The ID of the batch you would like returned

            try
            {
                // Cancel a scheduled batch
                CancelledMessageResponse result = apiInstance.BatchesScheduleBatchidDelete(batchid);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling BatchMessagesApi.BatchesScheduleBatchidDelete: " + e.Message );
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
 **batchid** | **string**| The ID of the batch you would like returned | 

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

