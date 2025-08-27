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

```csharp
using Finbourne.Scheduler.Sdk.Model;
using System;

string name = "example name";
string digest = "example digest";
List<Tag> tags = new List<Tag>();
ScanReport? scanReport = new ScanReport();


Image imageInstance = new Image(
    name: name,
    pushTime: pushTime,
    pullTime: pullTime,
    digest: digest,
    size: size,
    tags: tags,
    scanReport: scanReport);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
