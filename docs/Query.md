# Org.OpenAPITools.Model.Query
search parameters for querying the message database

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The status of the messages you would like returned (either &#39;SENT&#39;, &#39;DELIVERED&#39;, &#39;EXPIRED&#39;, &#39;UNDELIVERABLE&#39;, &#39;REJECTED&#39; or &#39;INCOMING&#39;) | [optional] 
**Credits** | **decimal** | The number of credits used on the message. Floating point number. | [optional] 
**Destination** | **string** | The phone number of the recipient. Start UK numbers with 44 and drop the leading 0. | [optional] 
**Sender** | **string** | The sender of the message (this can be the configured sender name for an outbound message or the senders phone number for an inbound message). | [optional] 
**Keyword** | **string** | The keyword used in the inbound message | [optional] 
**From** | **string** | The date-time from which you would like matching messages | [optional] 
**To** | **string** | The date-time to which you would like matching messages | [optional] 
**Limit** | **decimal** | The maximum number of messages that you would like returned in this call. The default is 1000. | [optional] 
**Skip** | **decimal** | The number of results you would like to ignore before returning messages. In combination with the &#39;limit&#39; parameter his can be used to page results, so that you can deal with a limited number in your logic at each time. | [optional] 
**Unread** | **bool** | In queries for incoming messages (&#39;status&#39; is &#39;INCOMING&#39;), specify whether you explicitly want unread messages (true) or read messages (false). Omit this parameter in other circumstances. | [optional] 
**Metadata** | [**QueryMetadata**](QueryMetadata.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

