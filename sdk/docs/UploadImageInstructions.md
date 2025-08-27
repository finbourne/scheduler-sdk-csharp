# Finbourne.Scheduler.Sdk.Model.UploadImageInstructions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DockerLoginCommand** | **string** |  | 
**BuildVersionedDockerImageCommand** | **string** |  | 
**TagVersionedDockerImageCommand** | **string** |  | 
**PushVersionedDockerImageCommand** | **string** |  | 
**TagLatestDockerImageCommand** | **string** |  | [optional] 
**PushLatestDockerImageCommand** | **string** |  | [optional] 
**ExpiryTime** | **DateTimeOffset?** |  | [optional] 

```csharp
using Finbourne.Scheduler.Sdk.Model;
using System;

string dockerLoginCommand = "dockerLoginCommand";
string buildVersionedDockerImageCommand = "buildVersionedDockerImageCommand";
string tagVersionedDockerImageCommand = "tagVersionedDockerImageCommand";
string pushVersionedDockerImageCommand = "pushVersionedDockerImageCommand";
string tagLatestDockerImageCommand = "example tagLatestDockerImageCommand";
string pushLatestDockerImageCommand = "example pushLatestDockerImageCommand";

UploadImageInstructions uploadImageInstructionsInstance = new UploadImageInstructions(
    dockerLoginCommand: dockerLoginCommand,
    buildVersionedDockerImageCommand: buildVersionedDockerImageCommand,
    tagVersionedDockerImageCommand: tagVersionedDockerImageCommand,
    pushVersionedDockerImageCommand: pushVersionedDockerImageCommand,
    tagLatestDockerImageCommand: tagLatestDockerImageCommand,
    pushLatestDockerImageCommand: pushLatestDockerImageCommand,
    expiryTime: expiryTime);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
