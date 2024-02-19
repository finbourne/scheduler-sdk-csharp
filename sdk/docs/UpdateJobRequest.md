# Finbourne.Scheduler.Sdk.Model.UpdateJobRequest
A request to update a job

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the job | 
**Author** | **string** | Author of the job | [optional] 
**Description** | **string** | Description of this job | 
**ImageName** | **string** | The name of the Docker image that contains this job | 
**ImageTag** | **string** | The tag of the Docker image that contains this job | 
**Ttl** | **int** | Time To Live of the job run in seconds  Defaults to 5 minutes(300) | [optional] 
**MinCpu** | **string** | Specifies  minimum number of CPUs to be allocated for the job  Default to 2 | [optional] 
**MaxCpu** | **string** | Specifies  maximum number of CPUs to be allocated for the job | [optional] 
**MinMemory** | **string** | Specifies the minimum amount of memory  to be allocated for the job | [optional] 
**MaxMemory** | **string** | Specifies the maximum amount of memory to be allocated for the job | [optional] 
**ArgumentDefinitions** | [**Dictionary&lt;string, ArgumentDefinition&gt;**](ArgumentDefinition.md) | All arguments for this job to run | 
**CommandLineArgumentSeparator** | **string** | Value to separate command line arguments  e.g : If a job has a command line argument named &#39;folder&#39; and the runtime value is &#39;s3://path&#39; then this  would be supplied to the command as &#39;folder{separatorValue}s3://path&#39;  Default to a space | [optional] 
**RequiredResources** | [**RequiredResources**](RequiredResources.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

