# Finbourne.Scheduler.Sdk.Model.UpdateScheduleRequest
Create a schedule definition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**JobId** | [**ResourceId**](ResourceId.md) |  | 
**Name** | **string** | The updated name of the schedule | 
**Description** | **string** | The updated description of the schedule | 
**Author** | **string** | The updated author of the schedule | [optional] 
**Owner** | **string** | The update owner of the schedule | [optional] 
**Arguments** | **Dictionary&lt;string, string&gt;** | Updated arguments to be passed to the job  Note: The new arguments will completely replace old arguments | [optional] 
**Trigger** | [**Trigger**](Trigger.md) |  | [optional] 
**Notifications** | [**List&lt;Notification&gt;**](Notification.md) | Updated notifications for this schedule | 
**Enabled** | **bool** | Specify whether schedule is enabled or not  Defaults to true | [optional] 
**UseAsAuth** | **string** | Id of user associated with schedule. All calls to FINBOURNE services  as part of execution of this schedule will be authenticated as this   user. Can be null, in which case we&#39;ll default to that of the user   making this request | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

