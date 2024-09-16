# Finbourne.Scheduler.Sdk.Api.JobsApi

All URIs are relative to *https://fbn-prd.lusid.com/scheduler2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateJob**](JobsApi.md#createjob) | **POST** /api/jobs | [EXPERIMENTAL] CreateJob: Create a new job |
| [**DeleteJob**](JobsApi.md#deletejob) | **DELETE** /api/jobs/{scope}/{code} | [EXPERIMENTAL] DeleteJob: Delete a job |
| [**GetHistory**](JobsApi.md#gethistory) | **GET** /api/jobs/history | [EXPERIMENTAL] GetHistory: Get the history of job runs |
| [**GetJobConsoleOutput**](JobsApi.md#getjobconsoleoutput) | **GET** /api/jobs/history/{runId}/console | [EXPERIMENTAL] GetJobConsoleOutput: Gets the console output of a specific job run |
| [**GetRunHistory**](JobsApi.md#getrunhistory) | **GET** /api/jobs/history/{runId} | [EXPERIMENTAL] GetRunHistory: Get the history for a single job run |
| [**GetSchedulesForAJob**](JobsApi.md#getschedulesforajob) | **GET** /api/jobs/{scope}/{code}/schedules | [EXPERIMENTAL] GetSchedulesForAJob: Get all the schedules for a single job |
| [**ListJobs**](JobsApi.md#listjobs) | **GET** /api/jobs | [EXPERIMENTAL] ListJobs: List the available jobs |
| [**RunJob**](JobsApi.md#runjob) | **POST** /api/jobs/{scope}/{code}/$run | RunJob: Run a job immediately |
| [**UpdateJob**](JobsApi.md#updatejob) | **PUT** /api/jobs/{scope}/{code} | [EXPERIMENTAL] UpdateJob: Update a JobDefinition |

<a id="createjob"></a>
# **CreateJob**
> JobDefinition CreateJob (CreateJobRequest createJobRequest)

[EXPERIMENTAL] CreateJob: Create a new job

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Extensions;
using Finbourne.Scheduler.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""schedulerUrl"": ""https://<your-domain>.lusid.com/scheduler2"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<JobsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<JobsApi>();
            var createJobRequest = new CreateJobRequest(); // CreateJobRequest | The request to create a new job

            try
            {
                // uncomment the below to set overrides at the request level
                // JobDefinition result = apiInstance.CreateJob(createJobRequest, opts: opts);

                // [EXPERIMENTAL] CreateJob: Create a new job
                JobDefinition result = apiInstance.CreateJob(createJobRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling JobsApi.CreateJob: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling JobsApi.CreateJobWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createJobRequest** | [**CreateJobRequest**](CreateJobRequest.md) | The request to create a new job |  |

### Return type

[**JobDefinition**](JobDefinition.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deletejob"></a>
# **DeleteJob**
> ResourceListOfScheduleDefinition DeleteJob (string scope, string code)

[EXPERIMENTAL] DeleteJob: Delete a job

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Extensions;
using Finbourne.Scheduler.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""schedulerUrl"": ""https://<your-domain>.lusid.com/scheduler2"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<JobsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<JobsApi>();
            var scope = "scope_example";  // string | The scope of the job
            var code = "code_example";  // string | The code of the job

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfScheduleDefinition result = apiInstance.DeleteJob(scope, code, opts: opts);

                // [EXPERIMENTAL] DeleteJob: Delete a job
                ResourceListOfScheduleDefinition result = apiInstance.DeleteJob(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling JobsApi.DeleteJob: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling JobsApi.DeleteJobWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the job |  |
| **code** | **string** | The code of the job |  |

### Return type

[**ResourceListOfScheduleDefinition**](ResourceListOfScheduleDefinition.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="gethistory"></a>
# **GetHistory**
> ResourceListOfJobHistory GetHistory (string? page = null, List<string>? sortBy = null, int? start = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] GetHistory: Get the history of job runs

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Extensions;
using Finbourne.Scheduler.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""schedulerUrl"": ""https://<your-domain>.lusid.com/scheduler2"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<JobsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<JobsApi>();
            var page = "page_example";  // string? | The pagination token to use to continue listing instruments from a previous call to list instruments.              This value is returned from the previous call. If a pagination token is provided the sortBy and filter fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var sortBy = new List<string>?(); // List<string>? | Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName. (optional) 
            var start = 56;  // int? | This field is obsolete, the value of this field would not be considered. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 2000 if not specified. Maximum is 5000. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfJobHistory result = apiInstance.GetHistory(page, sortBy, start, limit, filter, opts: opts);

                // [EXPERIMENTAL] GetHistory: Get the history of job runs
                ResourceListOfJobHistory result = apiInstance.GetHistory(page, sortBy, start, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling JobsApi.GetHistory: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling JobsApi.GetHistoryWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
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

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getjobconsoleoutput"></a>
# **GetJobConsoleOutput**
> string GetJobConsoleOutput (string runId)

[EXPERIMENTAL] GetJobConsoleOutput: Gets the console output of a specific job run

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Extensions;
using Finbourne.Scheduler.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""schedulerUrl"": ""https://<your-domain>.lusid.com/scheduler2"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<JobsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<JobsApi>();
            var runId = "runId_example";  // string | The RunId of the job run

            try
            {
                // uncomment the below to set overrides at the request level
                // string result = apiInstance.GetJobConsoleOutput(runId, opts: opts);

                // [EXPERIMENTAL] GetJobConsoleOutput: Gets the console output of a specific job run
                string result = apiInstance.GetJobConsoleOutput(runId);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling JobsApi.GetJobConsoleOutput: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling JobsApi.GetJobConsoleOutputWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runId** | **string** | The RunId of the job run |  |

### Return type

**string**

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getrunhistory"></a>
# **GetRunHistory**
> JobRunResult GetRunHistory (string runId)

[EXPERIMENTAL] GetRunHistory: Get the history for a single job run

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Extensions;
using Finbourne.Scheduler.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""schedulerUrl"": ""https://<your-domain>.lusid.com/scheduler2"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<JobsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<JobsApi>();
            var runId = "runId_example";  // string | The unique ID of the run

            try
            {
                // uncomment the below to set overrides at the request level
                // JobRunResult result = apiInstance.GetRunHistory(runId, opts: opts);

                // [EXPERIMENTAL] GetRunHistory: Get the history for a single job run
                JobRunResult result = apiInstance.GetRunHistory(runId);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling JobsApi.GetRunHistory: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling JobsApi.GetRunHistoryWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **runId** | **string** | The unique ID of the run |  |

### Return type

[**JobRunResult**](JobRunResult.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getschedulesforajob"></a>
# **GetSchedulesForAJob**
> ResourceListOfScheduleDefinition GetSchedulesForAJob (string scope, string code)

[EXPERIMENTAL] GetSchedulesForAJob: Get all the schedules for a single job

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Extensions;
using Finbourne.Scheduler.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""schedulerUrl"": ""https://<your-domain>.lusid.com/scheduler2"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<JobsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<JobsApi>();
            var scope = "scope_example";  // string | The scope of the job
            var code = "code_example";  // string | The code of the job

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfScheduleDefinition result = apiInstance.GetSchedulesForAJob(scope, code, opts: opts);

                // [EXPERIMENTAL] GetSchedulesForAJob: Get all the schedules for a single job
                ResourceListOfScheduleDefinition result = apiInstance.GetSchedulesForAJob(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling JobsApi.GetSchedulesForAJob: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling JobsApi.GetSchedulesForAJobWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the job |  |
| **code** | **string** | The code of the job |  |

### Return type

[**ResourceListOfScheduleDefinition**](ResourceListOfScheduleDefinition.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listjobs"></a>
# **ListJobs**
> ResourceListOfJobDefinition ListJobs (string? page = null, List<string>? sortBy = null, int? start = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] ListJobs: List the available jobs

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Extensions;
using Finbourne.Scheduler.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""schedulerUrl"": ""https://<your-domain>.lusid.com/scheduler2"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<JobsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<JobsApi>();
            var page = "page_example";  // string? | The pagination token to use to continue listing instruments from a previous call to list instruments.              This value is returned from the previous call. If a pagination token is provided the sortBy and filter fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var sortBy = new List<string>?(); // List<string>? | Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName. (optional) 
            var start = 56;  // int? | When paginating, skip this number of results. (optional) 
            var limit = 2000;  // int? | When paginating, limit the number of returned results to this many. Defaults to 2000 if not specified. Maximum is 5000. (optional)  (default to 2000)
            var filter = "filter_example";  // string? | Expression to filter the result set. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfJobDefinition result = apiInstance.ListJobs(page, sortBy, start, limit, filter, opts: opts);

                // [EXPERIMENTAL] ListJobs: List the available jobs
                ResourceListOfJobDefinition result = apiInstance.ListJobs(page, sortBy, start, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling JobsApi.ListJobs: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling JobsApi.ListJobsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
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

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="runjob"></a>
# **RunJob**
> StartJobResponse RunJob (string scope, string code, StartJobRequest startJobRequest)

RunJob: Run a job immediately

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Extensions;
using Finbourne.Scheduler.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""schedulerUrl"": ""https://<your-domain>.lusid.com/scheduler2"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<JobsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<JobsApi>();
            var scope = "scope_example";  // string | The scope of the job
            var code = "code_example";  // string | The code of the job
            var startJobRequest = new StartJobRequest(); // StartJobRequest | The request for starting job

            try
            {
                // uncomment the below to set overrides at the request level
                // StartJobResponse result = apiInstance.RunJob(scope, code, startJobRequest, opts: opts);

                // RunJob: Run a job immediately
                StartJobResponse result = apiInstance.RunJob(scope, code, startJobRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling JobsApi.RunJob: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    // RunJob: Run a job immediately
    ApiResponse<StartJobResponse> response = apiInstance.RunJobWithHttpInfo(scope, code, startJobRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling JobsApi.RunJobWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
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

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updatejob"></a>
# **UpdateJob**
> JobDefinition UpdateJob (string scope, string code, UpdateJobRequest updateJobRequest)

[EXPERIMENTAL] UpdateJob: Update a JobDefinition

### Example
```csharp
using System.Collections.Generic;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Extensions;
using Finbourne.Scheduler.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""schedulerUrl"": ""https://<your-domain>.lusid.com/scheduler2"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<JobsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<JobsApi>();
            var scope = "scope_example";  // string | 
            var code = "code_example";  // string | 
            var updateJobRequest = new UpdateJobRequest(); // UpdateJobRequest | 

            try
            {
                // uncomment the below to set overrides at the request level
                // JobDefinition result = apiInstance.UpdateJob(scope, code, updateJobRequest, opts: opts);

                // [EXPERIMENTAL] UpdateJob: Update a JobDefinition
                JobDefinition result = apiInstance.UpdateJob(scope, code, updateJobRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling JobsApi.UpdateJob: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
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
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling JobsApi.UpdateJobWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
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

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

