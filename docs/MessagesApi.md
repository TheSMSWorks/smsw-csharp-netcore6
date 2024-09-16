# SMSWorks.Api.Api.MessagesApi

All URIs are relative to *https://api.thesmsworks.co.uk/v1*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BinarySendPost**](MessagesApi.md#binarysendpost) | **POST** /binary/send | Send a binary SMS message |
| [**MessageFlashPost**](MessagesApi.md#messageflashpost) | **POST** /message/flash |  |
| [**MessageSchedulePost**](MessagesApi.md#messageschedulepost) | **POST** /message/schedule | Schedule an SMS message |
| [**MessageSendPost**](MessagesApi.md#messagesendpost) | **POST** /message/send |  |
| [**MessagesFailedPost**](MessagesApi.md#messagesfailedpost) | **POST** /messages/failed |  |
| [**MessagesInboxPost**](MessagesApi.md#messagesinboxpost) | **POST** /messages/inbox | Retrieve unread uncoming messages |
| [**MessagesMessageidDelete**](MessagesApi.md#messagesmessageiddelete) | **DELETE** /messages/{messageid} |  |
| [**MessagesMessageidGet**](MessagesApi.md#messagesmessageidget) | **GET** /messages/{messageid} | Get message by messageid |
| [**MessagesPost**](MessagesApi.md#messagespost) | **POST** /messages | Get messages matching your criteria |
| [**MessagesScheduleGet**](MessagesApi.md#messagesscheduleget) | **GET** /messages/schedule | Retrieve scheduled messages |
| [**MessagesScheduleMessageidDelete**](MessagesApi.md#messagesschedulemessageiddelete) | **DELETE** /messages/schedule/{messageid} | Cancel scheduled SMS message |
| [**MessagesVolumeGet**](MessagesApi.md#messagesvolumeget) | **GET** /messages/volume | Volume of messages sent since midnight |

<a id="binarysendpost"></a>
# **BinarySendPost**
> SendMessageResponse BinarySendPost (Message smsMessage)

Send a binary SMS message

Sends an SMS Message in Binary format. This can be used to send files and data to devices that process binary content. Especially useful for Internet of Things (IoT). Message content should be encoded in hex pairs (e.g. '65 54 74 73 6d 20 73 65 61 73 65 67 2e')

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SMSWorks.Api.Api;
using SMSWorks.Api.Client;
using SMSWorks.Api.Model;

namespace Example
{
    public class BinarySendPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessagesApi(config);
            var smsMessage = new Message(); // Message | Message properties

            try
            {
                // Send a binary SMS message
                SendMessageResponse result = apiInstance.BinarySendPost(smsMessage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesApi.BinarySendPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BinarySendPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Send a binary SMS message
    ApiResponse<SendMessageResponse> response = apiInstance.BinarySendPostWithHttpInfo(smsMessage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagesApi.BinarySendPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **smsMessage** | [**Message**](Message.md) | Message properties |  |

### Return type

[**SendMessageResponse**](SendMessageResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="messageflashpost"></a>
# **MessageFlashPost**
> SendMessageResponse MessageFlashPost (Message smsMessage)



Send an SMS flash message

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SMSWorks.Api.Api;
using SMSWorks.Api.Client;
using SMSWorks.Api.Model;

namespace Example
{
    public class MessageFlashPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessagesApi(config);
            var smsMessage = new Message(); // Message | Message properties

            try
            {
                SendMessageResponse result = apiInstance.MessageFlashPost(smsMessage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesApi.MessageFlashPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessageFlashPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SendMessageResponse> response = apiInstance.MessageFlashPostWithHttpInfo(smsMessage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagesApi.MessageFlashPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **smsMessage** | [**Message**](Message.md) | Message properties |  |

### Return type

[**SendMessageResponse**](SendMessageResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="messageschedulepost"></a>
# **MessageSchedulePost**
> List&lt;ScheduledMessageResponse&gt; MessageSchedulePost (Message smsMessage)

Schedule an SMS message

Schedules an SMS message to be sent at the date/time you specify

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SMSWorks.Api.Api;
using SMSWorks.Api.Client;
using SMSWorks.Api.Model;

namespace Example
{
    public class MessageSchedulePostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessagesApi(config);
            var smsMessage = new Message(); // Message | Message properties

            try
            {
                // Schedule an SMS message
                List<ScheduledMessageResponse> result = apiInstance.MessageSchedulePost(smsMessage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesApi.MessageSchedulePost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessageSchedulePostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Schedule an SMS message
    ApiResponse<List<ScheduledMessageResponse>> response = apiInstance.MessageSchedulePostWithHttpInfo(smsMessage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagesApi.MessageSchedulePostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **smsMessage** | [**Message**](Message.md) | Message properties |  |

### Return type

[**List&lt;ScheduledMessageResponse&gt;**](ScheduledMessageResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="messagesendpost"></a>
# **MessageSendPost**
> SendMessageResponse MessageSendPost (Message smsMessage)



Send an SMS Message

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SMSWorks.Api.Api;
using SMSWorks.Api.Client;
using SMSWorks.Api.Model;

namespace Example
{
    public class MessageSendPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessagesApi(config);
            var smsMessage = new Message(); // Message | Message properties

            try
            {
                SendMessageResponse result = apiInstance.MessageSendPost(smsMessage);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesApi.MessageSendPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessageSendPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<SendMessageResponse> response = apiInstance.MessageSendPostWithHttpInfo(smsMessage);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagesApi.MessageSendPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **smsMessage** | [**Message**](Message.md) | Message properties |  |

### Return type

[**SendMessageResponse**](SendMessageResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="messagesfailedpost"></a>
# **MessagesFailedPost**
> List&lt;MessageResponse&gt; MessagesFailedPost (Query query)



Retrieve failed messages matching your criteria

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SMSWorks.Api.Api;
using SMSWorks.Api.Client;
using SMSWorks.Api.Model;

namespace Example
{
    public class MessagesFailedPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessagesApi(config);
            var query = new Query(); // Query | 

            try
            {
                List<MessageResponse> result = apiInstance.MessagesFailedPost(query);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesApi.MessagesFailedPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessagesFailedPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<List<MessageResponse>> response = apiInstance.MessagesFailedPostWithHttpInfo(query);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagesApi.MessagesFailedPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | [**Query**](Query.md) |  |  |

### Return type

[**List&lt;MessageResponse&gt;**](MessageResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="messagesinboxpost"></a>
# **MessagesInboxPost**
> List&lt;MessageResponse&gt; MessagesInboxPost (Query query)

Retrieve unread uncoming messages

Retrieve unread uncoming messages matching your criteria

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SMSWorks.Api.Api;
using SMSWorks.Api.Client;
using SMSWorks.Api.Model;

namespace Example
{
    public class MessagesInboxPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessagesApi(config);
            var query = new Query(); // Query | 

            try
            {
                // Retrieve unread uncoming messages
                List<MessageResponse> result = apiInstance.MessagesInboxPost(query);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesApi.MessagesInboxPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessagesInboxPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve unread uncoming messages
    ApiResponse<List<MessageResponse>> response = apiInstance.MessagesInboxPostWithHttpInfo(query);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagesApi.MessagesInboxPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | [**Query**](Query.md) |  |  |

### Return type

[**List&lt;MessageResponse&gt;**](MessageResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="messagesmessageiddelete"></a>
# **MessagesMessageidDelete**
> DeletedMessageResponse MessagesMessageidDelete (string messageid)



Delete the message with the matching messageid

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SMSWorks.Api.Api;
using SMSWorks.Api.Client;
using SMSWorks.Api.Model;

namespace Example
{
    public class MessagesMessageidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessagesApi(config);
            var messageid = "messageid_example";  // string | The ID of the message you would like returned

            try
            {
                DeletedMessageResponse result = apiInstance.MessagesMessageidDelete(messageid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesApi.MessagesMessageidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessagesMessageidDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    ApiResponse<DeletedMessageResponse> response = apiInstance.MessagesMessageidDeleteWithHttpInfo(messageid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagesApi.MessagesMessageidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageid** | **string** | The ID of the message you would like returned |  |

### Return type

[**DeletedMessageResponse**](DeletedMessageResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | Error |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="messagesmessageidget"></a>
# **MessagesMessageidGet**
> MessageResponse MessagesMessageidGet (string messageid)

Get message by messageid

Retrieve a delivery report by the message ID

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SMSWorks.Api.Api;
using SMSWorks.Api.Client;
using SMSWorks.Api.Model;

namespace Example
{
    public class MessagesMessageidGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessagesApi(config);
            var messageid = "messageid_example";  // string | The ID of the message you would like returned

            try
            {
                // Get message by messageid
                MessageResponse result = apiInstance.MessagesMessageidGet(messageid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesApi.MessagesMessageidGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessagesMessageidGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get message by messageid
    ApiResponse<MessageResponse> response = apiInstance.MessagesMessageidGetWithHttpInfo(messageid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagesApi.MessagesMessageidGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageid** | **string** | The ID of the message you would like returned |  |

### Return type

[**MessageResponse**](MessageResponse.md)

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

<a id="messagespost"></a>
# **MessagesPost**
> List&lt;MessageResponse&gt; MessagesPost (Query query)

Get messages matching your criteria

Retrieve up to 1000 messages matching criteria specified in the request

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SMSWorks.Api.Api;
using SMSWorks.Api.Client;
using SMSWorks.Api.Model;

namespace Example
{
    public class MessagesPostExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessagesApi(config);
            var query = new Query(); // Query | 

            try
            {
                // Get messages matching your criteria
                List<MessageResponse> result = apiInstance.MessagesPost(query);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesApi.MessagesPost: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessagesPostWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get messages matching your criteria
    ApiResponse<List<MessageResponse>> response = apiInstance.MessagesPostWithHttpInfo(query);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagesApi.MessagesPostWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **query** | [**Query**](Query.md) |  |  |

### Return type

[**List&lt;MessageResponse&gt;**](MessageResponse.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **0** | Error |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="messagesscheduleget"></a>
# **MessagesScheduleGet**
> ScheduledMessagesResponse MessagesScheduleGet ()

Retrieve scheduled messages

Return a list of messages scheduled from your account, comprising any messages scheduled in the last 3 months and any scheduled to send in the future

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SMSWorks.Api.Api;
using SMSWorks.Api.Client;
using SMSWorks.Api.Model;

namespace Example
{
    public class MessagesScheduleGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessagesApi(config);

            try
            {
                // Retrieve scheduled messages
                ScheduledMessagesResponse result = apiInstance.MessagesScheduleGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesApi.MessagesScheduleGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessagesScheduleGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Retrieve scheduled messages
    ApiResponse<ScheduledMessagesResponse> response = apiInstance.MessagesScheduleGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagesApi.MessagesScheduleGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**ScheduledMessagesResponse**](ScheduledMessagesResponse.md)

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

<a id="messagesschedulemessageiddelete"></a>
# **MessagesScheduleMessageidDelete**
> CancelledMessageResponse MessagesScheduleMessageidDelete (string messageid)

Cancel scheduled SMS message

Cancels a scheduled SMS message matching the provided messageid

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SMSWorks.Api.Api;
using SMSWorks.Api.Client;
using SMSWorks.Api.Model;

namespace Example
{
    public class MessagesScheduleMessageidDeleteExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessagesApi(config);
            var messageid = "messageid_example";  // string | The ID of the message you would like returned

            try
            {
                // Cancel scheduled SMS message
                CancelledMessageResponse result = apiInstance.MessagesScheduleMessageidDelete(messageid);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesApi.MessagesScheduleMessageidDelete: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessagesScheduleMessageidDeleteWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel scheduled SMS message
    ApiResponse<CancelledMessageResponse> response = apiInstance.MessagesScheduleMessageidDeleteWithHttpInfo(messageid);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagesApi.MessagesScheduleMessageidDeleteWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **messageid** | **string** | The ID of the message you would like returned |  |

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

<a id="messagesvolumeget"></a>
# **MessagesVolumeGet**
> MessageVolumeResponse MessagesVolumeGet ()

Volume of messages sent since midnight

Retrieve the number of messages sent since midnight last night

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using SMSWorks.Api.Api;
using SMSWorks.Api.Client;
using SMSWorks.Api.Model;

namespace Example
{
    public class MessagesVolumeGetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new MessagesApi(config);

            try
            {
                // Volume of messages sent since midnight
                MessageVolumeResponse result = apiInstance.MessagesVolumeGet();
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MessagesApi.MessagesVolumeGet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MessagesVolumeGetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Volume of messages sent since midnight
    ApiResponse<MessageVolumeResponse> response = apiInstance.MessagesVolumeGetWithHttpInfo();
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MessagesApi.MessagesVolumeGetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters
This endpoint does not need any parameter.
### Return type

[**MessageVolumeResponse**](MessageVolumeResponse.md)

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

