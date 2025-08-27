# Finbourne.Scheduler.Sdk.Model.RequiredResources
Information related to a jobs required access to resources

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LusidApis** | **List&lt;string&gt;** | List of LUSID APIs the job needs access to | [optional] 
**LusidFileSystem** | **List&lt;string&gt;** | List of S3 bucket or folder names that the job can access | [optional] 
**ExternalCalls** | **List&lt;string&gt;** | External URLs that the job can call | [optional] 

```csharp
using Finbourne.Scheduler.Sdk.Model;
using System;

List<string> lusidApis = new List<string>();
List<string> lusidFileSystem = new List<string>();
List<string> externalCalls = new List<string>();

RequiredResources requiredResourcesInstance = new RequiredResources(
    lusidApis: lusidApis,
    lusidFileSystem: lusidFileSystem,
    externalCalls: externalCalls);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
