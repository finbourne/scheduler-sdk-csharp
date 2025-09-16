# Finbourne.Scheduler.Sdk.Model.CreateJobRequest
Definition of a job

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**JobId** | [**ResourceId**](ResourceId.md) |  | 
**Name** | **string** | Name of the job | 
**Author** | **string** | Author of the job | [optional] 
**DateCreated** | **DateTimeOffset** | Date when job was created. Defaults to now. | [optional] 
**Description** | **string** | Description of this job | 
**ImageName** | **string** | The name of the Docker image that contains this job | 
**ImageTag** | **string** | The tag of the Docker image that contains this job | 
**Ttl** | **int** | Time To Live of the job run in seconds Defaults to 5 minutes(300) | [optional] 
**MinCpu** | **string** | Specifies  minimum number of CPUs to be allocated for the job Default to 2 | [optional] 
**MaxCpu** | **string** | Specifies  maximum number of CPUs to be allocated for the job | [optional] 
**MinMemory** | **string** | Specifies the minimum amount of memory  to be allocated for the job | [optional] 
**MaxMemory** | **string** | Specifies the maximum amount of memory to be allocated for the job | [optional] 
**ArgumentDefinitions** | [**Dictionary&lt;string, ArgumentDefinition&gt;**](ArgumentDefinition.md) | All arguments for this job to run | 
**CommandLineArgumentSeparator** | **string** | Value to separate command line arguments e.g : If a job has a command line argument named &#39;folder&#39; and the runtime value is &#39;s3://path&#39; then this would be supplied to the command as &#39;folder{separatorValue}s3://path&#39; Default to a space | [optional] 
**RequiredResources** | [**RequiredResources**](RequiredResources.md) |  | [optional] 

```csharp
using Finbourne.Scheduler.Sdk.Model;
using System;

ResourceId jobId = new ResourceId();
string name = "name";
string author = "example author";
string description = "description";
string imageName = "imageName";
string imageTag = "imageTag";
string minCpu = "example minCpu";
string maxCpu = "example maxCpu";
string minMemory = "example minMemory";
string maxMemory = "example maxMemory";
Dictionary<string, ArgumentDefinition> argumentDefinitions = new Dictionary<string, ArgumentDefinition>();
string commandLineArgumentSeparator = "example commandLineArgumentSeparator";
RequiredResources? requiredResources = new RequiredResources();


CreateJobRequest createJobRequestInstance = new CreateJobRequest(
    jobId: jobId,
    name: name,
    author: author,
    dateCreated: dateCreated,
    description: description,
    imageName: imageName,
    imageTag: imageTag,
    ttl: ttl,
    minCpu: minCpu,
    maxCpu: maxCpu,
    minMemory: minMemory,
    maxMemory: maxMemory,
    argumentDefinitions: argumentDefinitions,
    commandLineArgumentSeparator: commandLineArgumentSeparator,
    requiredResources: requiredResources);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
