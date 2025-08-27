# Finbourne.Scheduler.Sdk.Model.StartJobResponse
Response from starting a job

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**JobId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**RunId** | **string** | Unique RunId of the started job run | [optional] 
**Status** | **string** | Link to the status of the started job | [optional] 
**Result** | **string** | Link to the result of the job run when completed | [optional] 

```csharp
using Finbourne.Scheduler.Sdk.Model;
using System;

ResourceId? jobId = new ResourceId();

string runId = "example runId";
string status = "example status";
string result = "example result";

StartJobResponse startJobResponseInstance = new StartJobResponse(
    jobId: jobId,
    runId: runId,
    status: status,
    result: result);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
