# Org.OpenAPITools - the C# library for the The SMS Works API

The SMS Works provides a low-cost, reliable SMS API for developers. Pay only for delivered texts, all failed UK messages are refunded.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.11.0
- SDK version: 1.0.0
- Nuget package: https://www.nuget.org/packages/TheSMSWorks.API.1.11.0/
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
    For more information, please visit [https://thesmsworks.co.uk/contact](https://thesmsworks.co.uk/contact)

## Frameworks supported


- .NET 4.0 or later
- Windows Phone 7.1 (Mango)

## Dependencies


- [RestSharp](https://www.nuget.org/packages/RestSharp) - 105.1.0 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 7.0.0 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.2.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

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


## Packaging

A `.nuspec` is included with the project. You can follow the Nuget quickstart to [create](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#create-the-package) and [publish](https://docs.microsoft.com/en-us/nuget/quickstart/create-and-publish-a-package#publish-the-package) packages.

This `.nuspec` uses placeholders from the `.csproj`, so build the `.csproj` directly:

```
nuget pack -Build -OutputDirectory out Org.OpenAPITools.csproj
```

Then, publish to a [local feed](https://docs.microsoft.com/en-us/nuget/hosting-packages/local-feeds) or [other host](https://docs.microsoft.com/en-us/nuget/hosting-packages/overview) and consume the new package via Nuget as usual.


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

            Configuration.Default.BasePath = "https://api.thesmsworks.co.uk/v1";
            // Configure API key authorization: JWT
            Configuration.Default.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Authorization", "Bearer");

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

## Documentation for API Endpoints

All URIs are relative to *https://api.thesmsworks.co.uk/v1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*BatchMessagesApi* | [**BatchAnyPost**](docs/BatchMessagesApi.md#batchanypost) | **POST** /batch/any | Send a collection of unique SMS messages
*BatchMessagesApi* | [**BatchBatchidGet**](docs/BatchMessagesApi.md#batchbatchidget) | **GET** /batch/{batchid} |
*BatchMessagesApi* | [**BatchSchedulePost**](docs/BatchMessagesApi.md#batchschedulepost) | **POST** /batch/schedule | Schedule a batch of SMS messages
*BatchMessagesApi* | [**BatchSendPost**](docs/BatchMessagesApi.md#batchsendpost) | **POST** /batch/send | Send an SMS message to multiple recipients
*BatchMessagesApi* | [**BatchesScheduleBatchidDelete**](docs/BatchMessagesApi.md#batchesschedulebatchiddelete) | **DELETE** /batches/schedule/{batchid} | Cancel a scheduled batch
*CreditsApi* | [**CreditsBalanceGet**](docs/CreditsApi.md#creditsbalanceget) | **GET** /credits/balance |
*CreditsApi* | [**CreditsCountrycodeGet**](docs/CreditsApi.md#creditscountrycodeget) | **GET** /credits/{countrycode} |
*MessagesApi* | [**BinarySendPost**](docs/MessagesApi.md#binarysendpost) | **POST** /binary/send | Send a binary SMS message
*MessagesApi* | [**MessageFlashPost**](docs/MessagesApi.md#messageflashpost) | **POST** /message/flash |
*MessagesApi* | [**MessageSchedulePost**](docs/MessagesApi.md#messageschedulepost) | **POST** /message/schedule | Schedule an SMS message
*MessagesApi* | [**MessageSendPost**](docs/MessagesApi.md#messagesendpost) | **POST** /message/send |
*MessagesApi* | [**MessagesFailedPost**](docs/MessagesApi.md#messagesfailedpost) | **POST** /messages/failed |
*MessagesApi* | [**MessagesInboxPost**](docs/MessagesApi.md#messagesinboxpost) | **POST** /messages/inbox | Retrieve unread uncoming messages
*MessagesApi* | [**MessagesMessageidDelete**](docs/MessagesApi.md#messagesmessageiddelete) | **DELETE** /messages/{messageid} |
*MessagesApi* | [**MessagesMessageidGet**](docs/MessagesApi.md#messagesmessageidget) | **GET** /messages/{messageid} | Get message by messageid
*MessagesApi* | [**MessagesPost**](docs/MessagesApi.md#messagespost) | **POST** /messages | Get messages matching your criteria
*MessagesApi* | [**MessagesScheduleGet**](docs/MessagesApi.md#messagesscheduleget) | **GET** /messages/schedule | Retrieve scheduled messages
*MessagesApi* | [**MessagesScheduleMessageidDelete**](docs/MessagesApi.md#messagesschedulemessageiddelete) | **DELETE** /messages/schedule/{messageid} | Cancel scheduled SMS message
*MessagesApi* | [**MessagesVolumeGet**](docs/MessagesApi.md#messagesvolumeget) | **GET** /messages/volume | Volume of messages sent since midnight
*OneTimePasswordApi* | [**OtpMessageidGet**](docs/OneTimePasswordApi.md#otpmessageidget) | **GET** /otp/{messageid} |
*OneTimePasswordApi* | [**OtpSendPost**](docs/OneTimePasswordApi.md#otpsendpost) | **POST** /otp/send |
*OneTimePasswordApi* | [**OtpVerifyPost**](docs/OneTimePasswordApi.md#otpverifypost) | **POST** /otp/verify |
*UtilsApi* | [**UtilsErrorsErrorcodeGet**](docs/UtilsApi.md#utilserrorserrorcodeget) | **GET** /utils/errors/{errorcode} | Get error by code
*UtilsApi* | [**UtilsTestGet**](docs/UtilsApi.md#utilstestget) | **GET** /utils/test | Return the customer ID to the caller


## Documentation for Models

 - [Model.BatchMessage](docs/BatchMessage.md)
 - [Model.BatchMessageResponse](docs/BatchMessageResponse.md)
 - [Model.CancelledMessageResponse](docs/CancelledMessageResponse.md)
 - [Model.CountryResponse](docs/CountryResponse.md)
 - [Model.CreditsResponse](docs/CreditsResponse.md)
 - [Model.DeletedMessageResponse](docs/DeletedMessageResponse.md)
 - [Model.ErrorModel](docs/ErrorModel.md)
 - [Model.ExtendedErrorModel](docs/ExtendedErrorModel.md)
 - [Model.ExtendedErrorModelAllOf](docs/ExtendedErrorModelAllOf.md)
 - [Model.Message](docs/Message.md)
 - [Model.MessageMetadata](docs/MessageMetadata.md)
 - [Model.MessageResponse](docs/MessageResponse.md)
 - [Model.MessageResponseFailurereason](docs/MessageResponseFailurereason.md)
 - [Model.MessageVolumeResponse](docs/MessageVolumeResponse.md)
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


## Documentation for Authorization


### JWT

- **Type**: API key

- **API key parameter name**: Authorization
- **Location**: HTTP header
