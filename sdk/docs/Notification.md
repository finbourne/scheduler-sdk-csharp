# Finbourne.Scheduler.Sdk.Model.Notification
Notification type

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FireOn** | **string** | Condition for the notification | [optional] [readonly] 
**Transport** | **string** | The type of the notification | [optional] 
**Destination** | **List&lt;string&gt;** | Where the notification should be sent | [optional] 

```csharp
using Finbourne.Scheduler.Sdk.Model;
using System;

string fireOn = "example fireOn";
string transport = "example transport";
List<string> destination = new List<string>();

Notification notificationInstance = new Notification(
    fireOn: fireOn,
    transport: transport,
    destination: destination);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
