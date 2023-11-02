# Finbourne.Scheduler.Sdk.Model.ScheduleDefinition
Schedule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScheduleIdentifier** | [**ResourceId**](ResourceId.md) |  | 
**JobId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Name** | **string** | A display name for this Schedule | [optional] 
**Description** | **string** | A description of the Schedule | [optional] 
**Author** | **string** | Name of the author of this schedule | [optional] 
**Owner** | **string** | Name of owner of this schedule | [optional] 
**UseAsAuth** | **string** | User to runs schedule when automatically run and authenticates   requests in the schedule | [optional] 
**Arguments** | **Dictionary&lt;string, string&gt;** | All arguments specified by this Schedule that will be passed in to the Job | [optional] 
**Trigger** | [**Trigger**](Trigger.md) |  | [optional] 
**Notifications** | [**List&lt;Notification&gt;**](Notification.md) | Notifications for this Schedule | [optional] 
**Enabled** | **bool** | The status of this schedule | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

