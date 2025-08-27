# Finbourne.Scheduler.Sdk.Model.ResourceId
Resource Id

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** | Scope of the resource | 
**Code** | **string** | Code of the resource | 

```csharp
using Finbourne.Scheduler.Sdk.Model;
using System;

string scope = "scope";
string code = "code";

ResourceId resourceIdInstance = new ResourceId(
    scope: scope,
    code: code);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
