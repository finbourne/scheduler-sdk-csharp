# Finbourne.Scheduler.Sdk.Model.Repository
An object representation of a repository

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The identifier of the repository | [optional] 
**CreationTime** | **DateTimeOffset** | Date of  repository creation | [optional] 
**LastUpdate** | **DateTimeOffset** | The last update of the repository | [optional] 
**Description** | **string** | Description of the repository | [optional] 
**PullCount** | **long** | Number of times images were pulled from this repository | [optional] 
**ImageCount** | **long** | The number of versions of this image | [optional] 
**Images** | [**Link**](Link.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Finbourne.Scheduler.Sdk.Model;
using System;

string name = "example name";
string description = "example description";
Link? images = new Link();

List<Link> links = new List<Link>();

Repository repositoryInstance = new Repository(
    name: name,
    creationTime: creationTime,
    lastUpdate: lastUpdate,
    description: description,
    pullCount: pullCount,
    imageCount: imageCount,
    images: images,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
