# Finbourne.Scheduler.Sdk.Model.StartScheduleResponse
Response from a manual run of a schedule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScheduleId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**JobId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**RunId** | **string** | Unique RunId of the started schedule | [optional] 
**Status** | **string** | Status of the started schedule | [optional] 
**Result** | **string** | Link to the result of the job run when completed | [optional] 

```csharp
using Finbourne.Scheduler.Sdk.Model;
using System;

ResourceId? scheduleId = new ResourceId();

ResourceId? jobId = new ResourceId();

string runId = "example runId";
string status = "example status";
string result = "example result";

StartScheduleResponse startScheduleResponseInstance = new StartScheduleResponse(
    scheduleId: scheduleId,
    jobId: jobId,
    runId: runId,
    status: status,
    result: result);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
