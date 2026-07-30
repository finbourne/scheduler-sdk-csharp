# Finbourne.Scheduler.Sdk.Model.StartJobRequest
Job start definition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Arguments** | **Dictionary&lt;string, string&gt;** | All arguments needed for the Job to run | [optional] 
**Notifications** | [**List&lt;Notification&gt;**](Notification.md) | Notifications for this Job | [optional] 
**UseAsAuth** | **string** | Id of user associated with schedule. All calls to FINBOURNE services as part of execution of this schedule will be authenticated as this user. Can be null, in which case we&#39;ll default to that of the user making this request | [optional] 
**RunId** | **string** | Optional pre-generated RunId (Guid format) for this job run. When provided, this is used as the RunId instead of generating a new one, allowing the caller to pre-generate and track the run before it starts. | [optional] 

```csharp
using Finbourne.Scheduler.Sdk.Model;
using System;

Dictionary<string, string> arguments = new Dictionary<string, string>();
List<Notification> notifications = new List<Notification>();
string useAsAuth = "example useAsAuth";
string runId = "example runId";

StartJobRequest startJobRequestInstance = new StartJobRequest(
    arguments: arguments,
    notifications: notifications,
    useAsAuth: useAsAuth,
    runId: runId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
