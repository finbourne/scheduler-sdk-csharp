# Finbourne.Scheduler.Sdk.Model.ScanSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Fixable** | **int?** | The number of vulnerabilities that have a known fix | [optional] 
**Total** | **int?** | The total number of vulnerabilities | [optional] 
**Critical** | **int?** | The number of Critical severity vulnerabilities | [optional] 
**High** | **int?** | The number of High severity vulnerabilities | [optional] 
**Medium** | **int?** | The number of Medium severity vulnerabilities | [optional] 
**Low** | **int?** | The number of Low severity vulnerabilities | [optional] 
**Negligible** | **int?** | The number of Negligible severity vulnerabilities | [optional] 
**Unknown** | **int?** | The number of Unknown severity vulnerabilities | [optional] 

```csharp
using Finbourne.Scheduler.Sdk.Model;
using System;


ScanSummary scanSummaryInstance = new ScanSummary(
    fixable: fixable,
    total: total,
    critical: critical,
    high: high,
    medium: medium,
    low: low,
    negligible: negligible,
    unknown: unknown);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
