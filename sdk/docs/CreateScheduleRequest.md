# Finbourne.Scheduler.Sdk.Model.CreateScheduleRequest
Create a schedule definition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScheduleId** | [**ResourceId**](ResourceId.md) |  | 
**JobId** | [**ResourceId**](ResourceId.md) |  | 
**Name** | **string** | A display name for this Schedule | 
**Description** | **string** | A description of the Schedule | 
**Author** | **string** | Name of the author of this schedule | [optional] 
**Owner** | **string** | Name of owner of this schedule | [optional] 
**Arguments** | **Dictionary&lt;string, string&gt;** | All arguments specified by this Schedule that will be passed in to the Job | [optional] 
**Trigger** | [**Trigger**](Trigger.md) |  | [optional] 
**Notifications** | [**List&lt;Notification&gt;**](Notification.md) | Notifications for this Schedule | [optional] 
**Enabled** | **bool** | Specify whether schedule is enabled or not  Defaults to true | [optional] 
**UseAsAuth** | **string** | Id of user associated with schedule. All calls to FINBOURNE services  as part of execution of this schedule will be authenticated as this   user. Can be null, in which case we&#39;ll default to that of the user   making this request | [optional] 

```csharp
using Finbourne.Scheduler.Sdk.Model;
using System;

ResourceId scheduleId = new ResourceId();
ResourceId jobId = new ResourceId();
string name = "name";
string description = "description";
string author = "example author";
string owner = "example owner";
Dictionary<string, string> arguments = new Dictionary<string, string>();
Trigger? trigger = new Trigger();

List<Notification> notifications = new List<Notification>();
bool enabled = //"True";
string useAsAuth = "example useAsAuth";

CreateScheduleRequest createScheduleRequestInstance = new CreateScheduleRequest(
    scheduleId: scheduleId,
    jobId: jobId,
    name: name,
    description: description,
    author: author,
    owner: owner,
    arguments: arguments,
    trigger: trigger,
    notifications: notifications,
    enabled: enabled,
    useAsAuth: useAsAuth);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
