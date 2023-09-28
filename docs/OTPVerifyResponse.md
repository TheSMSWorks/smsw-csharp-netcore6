# Org.OpenAPITools.Model.OTPVerifyResponse
Response schema for the /otp/verify method

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Destination** | **string** | The mobile number that the OTP was sent to | [optional] 
**Status** | **string** | The status of the OTP. If the passcode is used within the validity period then this will be &#39;VERIFIED&#39;, otherwise it will be &#39;EXPIRED&#39; | [optional] 
**Passcode** | **decimal** | The passcode used. | [optional] 
**Validity** | **decimal** | The length of time in seconds for which the generated passcode is valid. | [optional] 
**Metadata** | **Object** | A JSON object storing data supplied when this passcode was generated, for use in your application. | [optional] 
**Created** | **string** | The ISO 8601 date/time at which this OTP was created | [optional] 
**Expires** | **string** | The ISO 8601 date/time at which this OTP expires | [optional] 
**Modified** | **string** | The ISO 8601 date/time at which this OTP was modified (typically when it was verified) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

