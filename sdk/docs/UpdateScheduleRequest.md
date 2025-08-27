# Finbourne.Scheduler.Sdk.Model.UpdateScheduleRequest
Create a schedule definition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**JobId** | [**ResourceId**](ResourceId.md) |  | 
**Name** | **string** | The updated name of the schedule | 
**Description** | **string** | The updated description of the schedule | 
**Author** | **string** | The updated author of the schedule | [optional] 
**Owner** | **string** | The update owner of the schedule | [optional] 
**Arguments** | **Dictionary&lt;string, string&gt;** | Updated arguments to be passed to the job  Note: The new arguments will completely replace old arguments | [optional] 
**Trigger** | [**Trigger**](Trigger.md) |  | [optional] 
**Notifications** | [**List&lt;Notification&gt;**](Notification.md) | Updated notifications for this schedule | [optional] 
**Enabled** | **bool** | Specify whether schedule is enabled or not  Defaults to true | [optional] 
**UseAsAuth** | **string** | Id of user associated with schedule. All calls to FINBOURNE services  as part of execution of this schedule will be authenticated as this   user. Can be null, in which case we&#39;ll default to that of the user   making this request | [optional] 

```csharp
using Finbourne.Scheduler.Sdk.Model;
using System;

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

UpdateScheduleRequest updateScheduleRequestInstance = new UpdateScheduleRequest(
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
