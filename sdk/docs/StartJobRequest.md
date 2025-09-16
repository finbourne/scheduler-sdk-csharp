# Finbourne.Scheduler.Sdk.Model.StartJobRequest
Job start definition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Arguments** | **Dictionary&lt;string, string&gt;** | All arguments needed for the Job to run | [optional] 
**Notifications** | [**List&lt;Notification&gt;**](Notification.md) | Notifications for this Job | [optional] 
**UseAsAuth** | **string** | Id of user associated with schedule. All calls to FINBOURNE services as part of execution of this schedule will be authenticated as this  user. Can be null, in which case we&#39;ll default to that of the user  making this request | [optional] 

```csharp
using Finbourne.Scheduler.Sdk.Model;
using System;

Dictionary<string, string> arguments = new Dictionary<string, string>();
List<Notification> notifications = new List<Notification>();
string useAsAuth = "example useAsAuth";

StartJobRequest startJobRequestInstance = new StartJobRequest(
    arguments: arguments,
    notifications: notifications,
    useAsAuth: useAsAuth);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
