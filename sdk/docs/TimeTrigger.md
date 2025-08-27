# Finbourne.Scheduler.Sdk.Model.TimeTrigger
Time-based trigger

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Expression** | **string** | Cron expression | [optional] 
**VarTimeZone** | **string** | Time zone of the Cron expression. If not provided, defaults to UTC | [optional] 

```csharp
using Finbourne.Scheduler.Sdk.Model;
using System;

string expression = "example expression";
string varTimeZone = "example varTimeZone";

TimeTrigger timeTriggerInstance = new TimeTrigger(
    expression: expression,
    varTimeZone: varTimeZone);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
