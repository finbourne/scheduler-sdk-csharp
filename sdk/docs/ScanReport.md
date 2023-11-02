# Finbourne.Scheduler.Sdk.Model.ScanReport
Represents the details of a security scan of an image

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Severity** | **string** | The overall severity. For example : \&quot;High\&quot; or \&quot;None\&quot; | [optional] 
**Status** | **string** | The status of the report | [optional] 
**StartTime** | **DateTimeOffset?** | The start time of the scanning process | [optional] 
**EndTime** | **DateTimeOffset?** | The end time of the scanning process | [optional] 
**ScanDuration** | **int?** | The duration of the scan in seconds | [optional] 
**Summary** | [**ScanSummary**](ScanSummary.md) |  | [optional] 
**Vulnerabilities** | [**List&lt;Vulnerability&gt;**](Vulnerability.md) | List of Finbourne.Scheduler.WebApi.Dtos.Images.Vulnerability | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

