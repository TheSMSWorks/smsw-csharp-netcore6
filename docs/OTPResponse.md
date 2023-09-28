# Org.OpenAPITools.Model.OTPResponse
Response schema for the /otp/send method

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Messageid** | **string** | The messageid of the SMS used to send the OTP. Save this in your application to use when verifying passcodes. | [optional] 
**Status** | **string** | The initial status of the OTP message. | [optional] 
**Credits** | **decimal** | The credit balance on your account | [optional] 
**CreditsUsed** | **decimal** | The number of credits used to send this message | [optional] 
**Messageparts** | **decimal** | The number of message parts used to send this message | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

