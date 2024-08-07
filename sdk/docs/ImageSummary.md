# Finbourne.Scheduler.Sdk.Model.ImageSummary
Represents the metadata of an image

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the image | [optional] 
**PushTime** | **DateTimeOffset?** | The push time of the image | [optional] 
**PullTime** | **DateTimeOffset?** | The latest pull time of the image | [optional] 
**Digest** | **string** | The digest of the image | [optional] 
**Size** | **long?** | The size of the image (in bytes) | [optional] 
**Tags** | [**List&lt;Tag&gt;**](Tag.md) | The tags of the image | [optional] 
**ScanStatus** | **string** | The Scan Status of the stated image | [optional] 
**ScanSummary** | [**ScanSummary**](ScanSummary.md) |  | [optional] 
**Link** | [**Link**](Link.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

