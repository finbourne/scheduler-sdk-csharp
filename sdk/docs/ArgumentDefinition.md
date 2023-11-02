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
**PassedAs** | **string** | Specifies how this argument should be passed in  Allowed values are: CommandLine or EnvironmentVariable    Defaults to: CommandLine | 
**DefaultValue** | **string** | Specify a default value for this argument if no value is provided  The value needs to be convertible to the associated data type | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

