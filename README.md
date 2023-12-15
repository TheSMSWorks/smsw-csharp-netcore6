# Org.OpenAPITools - the C# library for the The SMS Works API

The SMS Works provides a low-cost, reliable SMS API for developers. Pay only for delivered texts, all failed UK messages are refunded.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.9.0
- SDK version: 1.0.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
- Nuget package: https://www.nuget.org/packages/TheSMSWorks.API.1.9.0/
    For more information, please visit [https://thesmsworks.co.uk/contact](https://thesmsworks.co.uk/contact)

<a id="frameworks-supported"></a>
## Frameworks supported

<a id="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.13.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 13.0.2 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a id="installation"></a>
## Installation
Run the following command to generate the DLL
- [Mac/Linux] `/bin/sh build.sh`
- [Windows] `build.bat`

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;
```
<a id="packaging"></a>
## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Org.OpenAPITools.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.

<a id="usage"></a>
## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`
```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a id="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Org.OpenAPITools.Api;
using Org.OpenAPITools.Client;
using Org.OpenAPITools.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            config.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new BatchMessagesApi(config);
            var messages = null;  // Object | An array of messages

            try
            {
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

<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.thesmsworks.co.uk/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*BatchMessagesApi* | [**BatchAnyPost**](docs/BatchMessagesApi.md#batchanypost) | **POST** /batch/any |
*BatchMessagesApi* | [**BatchBatchidGet**](docs/BatchMessagesApi.md#batchbatchidget) | **GET** /batch/{batchid} |
*BatchMessagesApi* | [**BatchSchedulePost**](docs/BatchMessagesApi.md#batchschedulepost) | **POST** /batch/schedule |
*BatchMessagesApi* | [**BatchSendPost**](docs/BatchMessagesApi.md#batchsendpost) | **POST** /batch/send |
*BatchMessagesApi* | [**BatchesScheduleBatchidDelete**](docs/BatchMessagesApi.md#batchesschedulebatchiddelete) | **DELETE** /batches/schedule/{batchid} |
*CreditsApi* | [**CreditsBalanceGet**](docs/CreditsApi.md#creditsbalanceget) | **GET** /credits/balance |
*MessagesApi* | [**MessageSchedulePost**](docs/MessagesApi.md#messageschedulepost) | **POST** /message/schedule |
*MessagesApi* | [**MessageSendPost**](docs/MessagesApi.md#messagesendpost) | **POST** /message/send |
*MessagesApi* | [**MessagesFailedPost**](docs/MessagesApi.md#messagesfailedpost) | **POST** /messages/failed |
*MessagesApi* | [**MessagesInboxPost**](docs/MessagesApi.md#messagesinboxpost) | **POST** /messages/inbox |
*MessagesApi* | [**MessagesMessageidDelete**](docs/MessagesApi.md#messagesmessageiddelete) | **DELETE** /messages/{messageid} |
*MessagesApi* | [**MessagesMessageidGet**](docs/MessagesApi.md#messagesmessageidget) | **GET** /messages/{messageid} |
*MessagesApi* | [**MessagesPost**](docs/MessagesApi.md#messagespost) | **POST** /messages |
*MessagesApi* | [**MessagesScheduleGet**](docs/MessagesApi.md#messagesscheduleget) | **GET** /messages/schedule |
*MessagesApi* | [**MessagesScheduleMessageidDelete**](docs/MessagesApi.md#messagesschedulemessageiddelete) | **DELETE** /messages/schedule/{messageid} |
*MessagesApi* | [**SendFlashMessage**](docs/MessagesApi.md#sendflashmessage) | **POST** /message/flash |
*OneTimePasswordApi* | [**OtpMessageidGet**](docs/OneTimePasswordApi.md#otpmessageidget) | **GET** /otp/{messageid} |
*OneTimePasswordApi* | [**OtpSendPost**](docs/OneTimePasswordApi.md#otpsendpost) | **POST** /otp/send |
*OneTimePasswordApi* | [**OtpVerifyPost**](docs/OneTimePasswordApi.md#otpverifypost) | **POST** /otp/verify |
*UtilsApi* | [**UtilsErrorsErrorcodeGet**](docs/UtilsApi.md#utilserrorserrorcodeget) | **GET** /utils/errors/{errorcode} |
*UtilsApi* | [**UtilsTestGet**](docs/UtilsApi.md#utilstestget) | **GET** /utils/test |


<a id="documentation-for-models"></a>
## Documentation for Models

 - [Model.BatchMessage](docs/BatchMessage.md)
 - [Model.BatchMessageResponse](docs/BatchMessageResponse.md)
 - [Model.CancelledMessageResponse](docs/CancelledMessageResponse.md)
 - [Model.CreditsResponse](docs/CreditsResponse.md)
 - [Model.DeletedMessageResponse](docs/DeletedMessageResponse.md)
 - [Model.ErrorModel](docs/ErrorModel.md)
 - [Model.ExtendedErrorModel](docs/ExtendedErrorModel.md)
 - [Model.Message](docs/Message.md)
 - [Model.MessageMetadata](docs/MessageMetadata.md)
 - [Model.MessageResponse](docs/MessageResponse.md)
 - [Model.MessageResponseFailurereason](docs/MessageResponseFailurereason.md)
 - [Model.MetaData](docs/MetaData.md)
 - [Model.OTP](docs/OTP.md)
 - [Model.OTPResponse](docs/OTPResponse.md)
 - [Model.OTPVerify](docs/OTPVerify.md)
 - [Model.OTPVerifyResponse](docs/OTPVerifyResponse.md)
 - [Model.Query](docs/Query.md)
 - [Model.QueryMetadata](docs/QueryMetadata.md)
 - [Model.ScheduledBatchResponse](docs/ScheduledBatchResponse.md)
 - [Model.ScheduledMessage](docs/ScheduledMessage.md)
 - [Model.ScheduledMessageResponse](docs/ScheduledMessageResponse.md)
 - [Model.ScheduledMessagesResponse](docs/ScheduledMessagesResponse.md)
 - [Model.ScheduledMessagesResponseMessage](docs/ScheduledMessagesResponseMessage.md)
 - [Model.SendMessageResponse](docs/SendMessageResponse.md)
 - [Model.TestResponse](docs/TestResponse.md)


<a id="documentation-for-authorization"></a>
## Documentation for Authorization


Authentication schemes defined for the API:
<a id="JWT"></a>
### JWT

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header
