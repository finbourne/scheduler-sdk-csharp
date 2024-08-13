<a id="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://fbn-prd.lusid.com/scheduler2*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*ApplicationMetadataApi* | [**ListAccessControlledResources**](docs/ApplicationMetadataApi.md#listaccesscontrolledresources) | **GET** /api/metadata/access/resources | [EXPERIMENTAL] ListAccessControlledResources: Get resources available for access control
*ImagesApi* | [**DeleteImage**](docs/ImagesApi.md#deleteimage) | **DELETE** /api/images/{name} | [EXPERIMENTAL] DeleteImage: Delete a Docker Image
*ImagesApi* | [**DownloadImage**](docs/ImagesApi.md#downloadimage) | **GET** /api/images/{name}/contents | [EXPERIMENTAL] DownloadImage: Download Docker Image
*ImagesApi* | [**GetImage**](docs/ImagesApi.md#getimage) | **GET** /api/images/{name} | [EXPERIMENTAL] GetImage: Get metadata of a Docker Image
*ImagesApi* | [**ListImages**](docs/ImagesApi.md#listimages) | **GET** /api/images/repository/{name} | [EXPERIMENTAL] ListImages: List all images under same image repository
*ImagesApi* | [**ListRepositories**](docs/ImagesApi.md#listrepositories) | **GET** /api/images/repository | [EXPERIMENTAL] ListRepositories: List all Docker image repositories
*ImagesApi* | [**UploadImage**](docs/ImagesApi.md#uploadimage) | **POST** /api/images | [EXPERIMENTAL] UploadImage: Upload a Docker Image used for Scheduler jobs
*JobsApi* | [**CreateJob**](docs/JobsApi.md#createjob) | **POST** /api/jobs | [EXPERIMENTAL] CreateJob: Create a new job
*JobsApi* | [**DeleteJob**](docs/JobsApi.md#deletejob) | **DELETE** /api/jobs/{scope}/{code} | [EXPERIMENTAL] DeleteJob: Delete a job
*JobsApi* | [**GetHistory**](docs/JobsApi.md#gethistory) | **GET** /api/jobs/history | [EXPERIMENTAL] GetHistory: Get the history of job runs
*JobsApi* | [**GetJobConsoleOutput**](docs/JobsApi.md#getjobconsoleoutput) | **GET** /api/jobs/history/{runId}/console | [EXPERIMENTAL] GetJobConsoleOutput: Gets the console output of a specific job run
*JobsApi* | [**GetRunHistory**](docs/JobsApi.md#getrunhistory) | **GET** /api/jobs/history/{runId} | [EXPERIMENTAL] GetRunHistory: Get the history for a single job run
*JobsApi* | [**GetSchedulesForAJob**](docs/JobsApi.md#getschedulesforajob) | **GET** /api/jobs/{scope}/{code}/schedules | [EXPERIMENTAL] GetSchedulesForAJob: Get all the schedules for a single job
*JobsApi* | [**ListJobs**](docs/JobsApi.md#listjobs) | **GET** /api/jobs | [EXPERIMENTAL] ListJobs: List the available jobs
*JobsApi* | [**RunJob**](docs/JobsApi.md#runjob) | **POST** /api/jobs/{scope}/{code}/$run | RunJob: Run a job immediately
*JobsApi* | [**UpdateJob**](docs/JobsApi.md#updatejob) | **PUT** /api/jobs/{scope}/{code} | [EXPERIMENTAL] UpdateJob: Update a JobDefinition
*SchedulesApi* | [**CreateSchedule**](docs/SchedulesApi.md#createschedule) | **POST** /api/schedules | [EXPERIMENTAL] CreateSchedule: Create a Schedule for a job
*SchedulesApi* | [**DeleteSchedule**](docs/SchedulesApi.md#deleteschedule) | **DELETE** /api/schedules/{scope}/{code} | [EXPERIMENTAL] DeleteSchedule: Delete a schedule
*SchedulesApi* | [**EnabledSchedule**](docs/SchedulesApi.md#enabledschedule) | **PUT** /api/schedules/{scope}/{code}/enabled | [EXPERIMENTAL] EnabledSchedule: Enable/disable a schedule
*SchedulesApi* | [**GetSchedule**](docs/SchedulesApi.md#getschedule) | **GET** /api/schedules/{scope}/{code} | [EXPERIMENTAL] GetSchedule: Get a single Schedule
*SchedulesApi* | [**ListSchedules**](docs/SchedulesApi.md#listschedules) | **GET** /api/schedules | [EXPERIMENTAL] ListSchedules: List the available Schedules
*SchedulesApi* | [**RunSchedule**](docs/SchedulesApi.md#runschedule) | **POST** /api/schedules/{scope}/{code}/$run | [EXPERIMENTAL] RunSchedule: Run a schedule immediately
*SchedulesApi* | [**UpdateSchedule**](docs/SchedulesApi.md#updateschedule) | **PUT** /api/schedules/{scope}/{code} | [EXPERIMENTAL] UpdateSchedule: Update a schedule.


<a id="documentation-for-models"></a>
## Documentation for Models

 - [AccessControlledAction](docs/AccessControlledAction.md)
 - [AccessControlledResource](docs/AccessControlledResource.md)
 - [ActionId](docs/ActionId.md)
 - [ArgumentDefinition](docs/ArgumentDefinition.md)
 - [CreateJobRequest](docs/CreateJobRequest.md)
 - [CreateScheduleRequest](docs/CreateScheduleRequest.md)
 - [IdSelectorDefinition](docs/IdSelectorDefinition.md)
 - [IdentifierPartSchema](docs/IdentifierPartSchema.md)
 - [Image](docs/Image.md)
 - [ImageSummary](docs/ImageSummary.md)
 - [JobDefinition](docs/JobDefinition.md)
 - [JobHistory](docs/JobHistory.md)
 - [JobRunResult](docs/JobRunResult.md)
 - [Link](docs/Link.md)
 - [LusidProblemDetails](docs/LusidProblemDetails.md)
 - [LusidValidationProblemDetails](docs/LusidValidationProblemDetails.md)
 - [Notification](docs/Notification.md)
 - [Repository](docs/Repository.md)
 - [RequiredResources](docs/RequiredResources.md)
 - [ResourceId](docs/ResourceId.md)
 - [ResourceListOfAccessControlledResource](docs/ResourceListOfAccessControlledResource.md)
 - [ResourceListOfImageSummary](docs/ResourceListOfImageSummary.md)
 - [ResourceListOfJobDefinition](docs/ResourceListOfJobDefinition.md)
 - [ResourceListOfJobHistory](docs/ResourceListOfJobHistory.md)
 - [ResourceListOfRepository](docs/ResourceListOfRepository.md)
 - [ResourceListOfScheduleDefinition](docs/ResourceListOfScheduleDefinition.md)
 - [ScanReport](docs/ScanReport.md)
 - [ScanSummary](docs/ScanSummary.md)
 - [ScheduleDefinition](docs/ScheduleDefinition.md)
 - [StartJobRequest](docs/StartJobRequest.md)
 - [StartJobResponse](docs/StartJobResponse.md)
 - [StartScheduleResponse](docs/StartScheduleResponse.md)
 - [Tag](docs/Tag.md)
 - [TimeTrigger](docs/TimeTrigger.md)
 - [Trigger](docs/Trigger.md)
 - [UpdateJobRequest](docs/UpdateJobRequest.md)
 - [UpdateScheduleRequest](docs/UpdateScheduleRequest.md)
 - [UploadImageInstructions](docs/UploadImageInstructions.md)
 - [UploadImageRequest](docs/UploadImageRequest.md)
 - [Vulnerability](docs/Vulnerability.md)

