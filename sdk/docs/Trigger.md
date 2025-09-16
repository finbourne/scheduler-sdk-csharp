# Finbourne.Scheduler.Sdk.Model.Trigger
Holds different kinds of triggers A schedule may only have one type of trigger

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TimeTrigger** | [**TimeTrigger**](TimeTrigger.md) |  | [optional] 

```csharp
using Finbourne.Scheduler.Sdk.Model;
using System;

TimeTrigger? timeTrigger = new TimeTrigger();


Trigger triggerInstance = new Trigger(
    timeTrigger: timeTrigger);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
