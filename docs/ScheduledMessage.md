
# Org.OpenAPITools.Model.ScheduledMessage

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Sender** | **string** | The sender of the message. Should be no longer than 11 characters for alphanumeric or 15 characters for numeric sender ID&#39;s. No spaces or special characters. | [optional] 
**Content** | **string** | Message to be sent to the recipient | [optional] 
**Destination** | **string** | For single scheduled messages, the mobile number of the recipient | [optional] 
**Destinations** | **List&lt;string&gt;** | For batch messages, the mobile numbers of each of the recipients | [optional] 
**Schedule** | **string** | date/time at which to send the batch. This is only used by the batch/schedule service. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

