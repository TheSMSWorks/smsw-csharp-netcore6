# Org.OpenAPITools.Model.OTP
Parameters for the generation and sending of One-Time Passwords

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Sender** | **string** | The sender of the message. Should be no longer than 11 characters for alphanumeric or 15 characters for numeric sender ID&#39;s. No spaces or special characters. | [optional] 
**Destination** | **string** | The phone number of the recipient. | [optional] 
**Template** | **string** | A template to use as the content for the message. You must include the &#39;{{passcode}}&#39; placeholder, which will be replaced by the generated passcode when the message is sent. Optional. | [optional] 
**Validity** | **decimal** | The length of time in seconds for which the generated passcode should be valid. Optional. | [optional] 
**Passcode** | **string** | A passcode you supply for use in the message template. This will be stored on the OTP record in our system for later verification. Optional. | [optional] 
**Metadata** | **Object** | A JSON object of no longer than 1024 bytes, containing as many parameters as you wish, to store data for use in your application. This will be returned when you verify the passcode. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

