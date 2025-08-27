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

```csharp
using Finbourne.Scheduler.Sdk.Model;
using System;

string name = "example name";
string digest = "example digest";
List<Tag> tags = new List<Tag>();
string scanStatus = "example scanStatus";
ScanSummary? scanSummary = new ScanSummary();

Link? link = new Link();


ImageSummary imageSummaryInstance = new ImageSummary(
    name: name,
    pushTime: pushTime,
    pullTime: pullTime,
    digest: digest,
    size: size,
    tags: tags,
    scanStatus: scanStatus,
    scanSummary: scanSummary,
    link: link);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
