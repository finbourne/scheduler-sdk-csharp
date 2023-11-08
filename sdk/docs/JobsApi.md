# Finbourne.Scheduler.Sdk.Api.JobsApi

All URIs are relative to *https://fbn-ci.lusid.com/scheduler2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateJob**](JobsApi.md#createjob) | **POST** /api/jobs | [EXPERIMENTAL] CreateJob: Create a new job |
| [**DeleteJob**](JobsApi.md#deletejob) | **DELETE** /api/jobs/{scope}/{code} | [EXPERIMENTAL] DeleteJob: Delete a job |
| [**GetHistory**](JobsApi.md#gethistory) | **GET** /api/jobs/history | [EXPERIMENTAL] GetHistory: Get the history of job runs |
| [**GetJobConsoleOutput**](JobsApi.md#getjobconsoleoutput) | **GET** /api/jobs/history/{runId}/console | [EXPERIMENTAL] GetJobConsoleOutput: Gets the console output of a specific job run |
| [**GetRunHistory**](JobsApi.md#getrunhistory) | **GET** /api/jobs/history/{runId} | [EXPERIMENTAL] GetRunHistory: Get the history for a single job run |
| [**GetSchedulesForAJob**](JobsApi.md#getschedulesforajob) | **GET** /api/jobs/{scope}/{code}/schedules | [EXPERIMENTAL] GetSchedulesForAJob: Get all the schedules for a single job |
| [**ListJobs**](JobsApi.md#listjobs) | **GET** /api/jobs | [EXPERIMENTAL] ListJobs: List the available jobs |
| [**RunJob**](JobsApi.md#runjob) | **POST** /api/jobs/{scope}/{code}/$run | [EXPERIMENTAL] RunJob: Run a job immediately |
| [**UpdateJob**](JobsApi.md#updatejob) | **PUT** /api/jobs/{scope}/{code} | [EXPERIMENTAL] UpdateJob: Update a JobDefinition |

<a id="createjob"></a>
# **CreateJob**
> JobDefinition CreateJob (CreateJobRequest createJobRequest)

[EXPERIMENTAL] CreateJob: Create a new job

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Model;

namespace Example
{
    public class CreateJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-ci.lusid.com/scheduler2";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JobsApi(config);
            var createJobRequest = new CreateJobRequest(); // CreateJobRequest | The request to create a new job

            try
            {
                // [EXPERIMENTAL] CreateJob: Create a new job
                JobDefinition result = apiInstance.CreateJob(createJobRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApi.CreateJob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateJobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateJob: Create a new job
    ApiResponse<JobDefinition> response = apiInstance.CreateJobWithHttpInfo(createJobRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApi.CreateJobWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createJobRequest** | [**CreateJobRequest**](CreateJobRequest.md) | The request to create a new job |  |

### Return type

[**JobDefinition**](JobDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletejob"></a>
# **DeleteJob**
> ResourceListOfScheduleDefinition DeleteJob (string scope, string code)

[EXPERIMENTAL] DeleteJob: Delete a job

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Model;

namespace Example
{
    public class DeleteJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-ci.lusid.com/scheduler2";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JobsApi(config);
            var scope = "scope_example";  // string | The scope of the job
            var code = "code_example";  // string | The code of the job

            try
            {
                // [EXPERIMENTAL] DeleteJob: Delete a job
                ResourceListOfScheduleDefinition result = apiInstance.DeleteJob(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApi.DeleteJob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteJobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteJob: Delete a job
    ApiResponse<ResourceListOfScheduleDefinition> response = apiInstance.DeleteJobWithHttpInfo(scope, code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApi.DeleteJobWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the job |  |
| **code** | **string** | The code of the job |  |

### Return type

[**ResourceListOfScheduleDefinition**](ResourceListOfScheduleDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gethistory"></a>
# **GetHistory**
> ResourceListOfJobHistory GetHistory (string? page = null, List<string>? sortBy = null, int? start = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] GetHistory: Get the history of job runs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Model;

namespace Example
{
    public class GetHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-ci.lusid.com/scheduler2";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JobsApi(config);
            var page = "page_example";  // string? | The pagination token to use to continue listing instruments from a previous call to list instruments.              This value is returned from the previous call. If a pagination token is provided the sortBy and filter fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var sortBy = new List<string>?(); // List<string>? | Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName. (optional) 
            var start = 56;  // int? | This field is obsolete, the value of this field would not be considered. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 2000 if not specified. Maximum is 5000. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. (optional) 

            try
            {
                // [EXPERIMENTAL] GetHistory: Get the history of job runs
                ResourceListOfJobHistory result = apiInstance.GetHistory(page, sortBy, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApi.GetHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetHistory: Get the history of job runs
    ApiResponse<ResourceListOfJobHistory> response = apiInstance.GetHistoryWithHttpInfo(page, sortBy, start, limit, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApi.GetHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **string?** | The pagination token to use to continue listing instruments from a previous call to list instruments.              This value is returned from the previous call. If a pagination token is provided the sortBy and filter fields              must not have changed since the original request. Also, if set, a start value cannot be provided. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. | [optional]  |
| **start** | **int?** | This field is obsolete, the value of this field would not be considered. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. Defaults to 2000 if not specified. Maximum is 5000. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. | [optional]  |

### Return type

[**ResourceListOfJobHistory**](ResourceListOfJobHistory.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getjobconsoleoutput"></a>
# **GetJobConsoleOutput**
> string GetJobConsoleOutput (string runId)

[EXPERIMENTAL] GetJobConsoleOutput: Gets the console output of a specific job run

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Model;

namespace Example
{
    public class GetJobConsoleOutputExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-ci.lusid.com/scheduler2";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JobsApi(config);
            var runId = "runId_example";  // string | The RunId of the job run

            try
            {
                // [EXPERIMENTAL] GetJobConsoleOutput: Gets the console output of a specific job run
                string result = apiInstance.GetJobConsoleOutput(runId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApi.GetJobConsoleOutput: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetJobConsoleOutputWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetJobConsoleOutput: Gets the console output of a specific job run
    ApiResponse<string> response = apiInstance.GetJobConsoleOutputWithHttpInfo(runId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApi.GetJobConsoleOutputWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runId** | **string** | The RunId of the job run |  |

### Return type

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrunhistory"></a>
# **GetRunHistory**
> JobRunResult GetRunHistory (string runId)

[EXPERIMENTAL] GetRunHistory: Get the history for a single job run

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Model;

namespace Example
{
    public class GetRunHistoryExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-ci.lusid.com/scheduler2";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JobsApi(config);
            var runId = "runId_example";  // string | The unique ID of the run

            try
            {
                // [EXPERIMENTAL] GetRunHistory: Get the history for a single job run
                JobRunResult result = apiInstance.GetRunHistory(runId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApi.GetRunHistory: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRunHistoryWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetRunHistory: Get the history for a single job run
    ApiResponse<JobRunResult> response = apiInstance.GetRunHistoryWithHttpInfo(runId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApi.GetRunHistoryWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runId** | **string** | The unique ID of the run |  |

### Return type

[**JobRunResult**](JobRunResult.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getschedulesforajob"></a>
# **GetSchedulesForAJob**
> ResourceListOfScheduleDefinition GetSchedulesForAJob (string scope, string code)

[EXPERIMENTAL] GetSchedulesForAJob: Get all the schedules for a single job

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Model;

namespace Example
{
    public class GetSchedulesForAJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-ci.lusid.com/scheduler2";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JobsApi(config);
            var scope = "scope_example";  // string | The scope of the job
            var code = "code_example";  // string | The code of the job

            try
            {
                // [EXPERIMENTAL] GetSchedulesForAJob: Get all the schedules for a single job
                ResourceListOfScheduleDefinition result = apiInstance.GetSchedulesForAJob(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApi.GetSchedulesForAJob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSchedulesForAJobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetSchedulesForAJob: Get all the schedules for a single job
    ApiResponse<ResourceListOfScheduleDefinition> response = apiInstance.GetSchedulesForAJobWithHttpInfo(scope, code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApi.GetSchedulesForAJobWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the job |  |
| **code** | **string** | The code of the job |  |

### Return type

[**ResourceListOfScheduleDefinition**](ResourceListOfScheduleDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listjobs"></a>
# **ListJobs**
> ResourceListOfJobDefinition ListJobs (string? page = null, List<string>? sortBy = null, int? start = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] ListJobs: List the available jobs

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Model;

namespace Example
{
    public class ListJobsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-ci.lusid.com/scheduler2";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JobsApi(config);
            var page = "page_example";  // string? | The pagination token to use to continue listing instruments from a previous call to list instruments.              This value is returned from the previous call. If a pagination token is provided the sortBy and filter fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var sortBy = new List<string>?(); // List<string>? | Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName. (optional) 
            var start = 56;  // int? | When paginating, skip this number of results. (optional) 
            var limit = 2000;  // int? | When paginating, limit the number of returned results to this many. Defaults to 2000 if not specified. Maximum is 5000. (optional)  (default to 2000)
            var filter = "filter_example";  // string? | Expression to filter the result set. (optional) 

            try
            {
                // [EXPERIMENTAL] ListJobs: List the available jobs
                ResourceListOfJobDefinition result = apiInstance.ListJobs(page, sortBy, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApi.ListJobs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListJobsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListJobs: List the available jobs
    ApiResponse<ResourceListOfJobDefinition> response = apiInstance.ListJobsWithHttpInfo(page, sortBy, start, limit, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApi.ListJobsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **string?** | The pagination token to use to continue listing instruments from a previous call to list instruments.              This value is returned from the previous call. If a pagination token is provided the sortBy and filter fields              must not have changed since the original request. Also, if set, a start value cannot be provided. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. | [optional]  |
| **start** | **int?** | When paginating, skip this number of results. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. Defaults to 2000 if not specified. Maximum is 5000. | [optional] [default to 2000] |
| **filter** | **string?** | Expression to filter the result set. | [optional]  |

### Return type

[**ResourceListOfJobDefinition**](ResourceListOfJobDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="runjob"></a>
# **RunJob**
> StartJobResponse RunJob (string scope, string code, StartJobRequest startJobRequest)

[EXPERIMENTAL] RunJob: Run a job immediately

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Model;

namespace Example
{
    public class RunJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-ci.lusid.com/scheduler2";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JobsApi(config);
            var scope = "scope_example";  // string | The scope of the job
            var code = "code_example";  // string | The code of the job
            var startJobRequest = new StartJobRequest(); // StartJobRequest | The request for starting job

            try
            {
                // [EXPERIMENTAL] RunJob: Run a job immediately
                StartJobResponse result = apiInstance.RunJob(scope, code, startJobRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApi.RunJob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the RunJobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] RunJob: Run a job immediately
    ApiResponse<StartJobResponse> response = apiInstance.RunJobWithHttpInfo(scope, code, startJobRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApi.RunJobWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the job |  |
| **code** | **string** | The code of the job |  |
| **startJobRequest** | [**StartJobRequest**](StartJobRequest.md) | The request for starting job |  |

### Return type

[**StartJobResponse**](StartJobResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatejob"></a>
# **UpdateJob**
> JobDefinition UpdateJob (string scope, string code, UpdateJobRequest updateJobRequest)

[EXPERIMENTAL] UpdateJob: Update a JobDefinition

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Model;

namespace Example
{
    public class UpdateJobExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-ci.lusid.com/scheduler2";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new JobsApi(config);
            var scope = "scope_example";  // string | 
            var code = "code_example";  // string | 
            var updateJobRequest = new UpdateJobRequest(); // UpdateJobRequest | 

            try
            {
                // [EXPERIMENTAL] UpdateJob: Update a JobDefinition
                JobDefinition result = apiInstance.UpdateJob(scope, code, updateJobRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling JobsApi.UpdateJob: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateJobWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateJob: Update a JobDefinition
    ApiResponse<JobDefinition> response = apiInstance.UpdateJobWithHttpInfo(scope, code, updateJobRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling JobsApi.UpdateJobWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** |  |  |
| **code** | **string** |  |  |
| **updateJobRequest** | [**UpdateJobRequest**](UpdateJobRequest.md) |  |  |

### Return type

[**JobDefinition**](JobDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

