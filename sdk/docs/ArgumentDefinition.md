# Finbourne.Scheduler.Sdk.Model.ArgumentDefinition
Job argument definition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataType** | **string** | Data type of the argument | 
**Required** | **bool** | Optionality of the argument | [optional] 
**Description** | **string** | Argument description | 
**Order** | **int** | The order of the argument | 
**Constraints** | **string** | Constrains of the argument value | [optional] 
**PassedAs** | **string** | Specifies how this argument should be passed in Allowed values are: CommandLine or EnvironmentVariable  Defaults to: CommandLine | 
**DefaultValue** | **string** | Specify a default value for this argument if no value is provided The value needs to be convertible to the associated data type | [optional] 

```csharp
using Finbourne.Scheduler.Sdk.Model;
using System;

string dataType = "dataType";
bool required = //"True";
string description = "description";
string constraints = "example constraints";
string passedAs = "passedAs";
string defaultValue = "example defaultValue";

ArgumentDefinition argumentDefinitionInstance = new ArgumentDefinition(
    dataType: dataType,
    required: required,
    description: description,
    order: order,
    constraints: constraints,
    passedAs: passedAs,
    defaultValue: defaultValue);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
