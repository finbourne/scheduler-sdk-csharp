# Finbourne.Scheduler.Sdk.Model.Tag
Represents data of an image's tag

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the tag | [optional] 
**PullTime** | **DateTimeOffset** | The latest pull time | [optional] 
**PushTime** | **DateTimeOffset** | The date of the tag&#39;s push | [optional] 
**Signed** | **bool** | Indicates whether the tag is signed | [optional] 
**Immutable** | **bool** | Indicates whether the tag is immutable | [optional] 

```csharp
using Finbourne.Scheduler.Sdk.Model;
using System;

string name = "example name";
bool signed = //"True";
bool immutable = //"True";

Tag tagInstance = new Tag(
    name: name,
    pullTime: pullTime,
    pushTime: pushTime,
    signed: signed,
    immutable: immutable);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
