# Finbourne.Scheduler.Sdk.Model.Image
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
**ScanReport** | [**ScanReport**](ScanReport.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

