# Finbourne.Scheduler.Sdk.Model.StartJobRequest
Job start definition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Arguments** | **Dictionary&lt;string, string&gt;** | All arguments needed for the Job to run | [optional] 
**Notifications** | [**List&lt;Notification&gt;**](Notification.md) | Notifications for this Job | [optional] 
**UseAsAuth** | **string** | Id of user associated with schedule. All calls to FINBOURNE services  as part of execution of this schedule will be authenticated as this   user. Can be null, in which case we&#39;ll default to that of the user   making this request | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

