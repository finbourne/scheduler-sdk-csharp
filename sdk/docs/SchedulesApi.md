# Finbourne.Scheduler.Sdk.Api.SchedulesApi

All URIs are relative to *https://fbn-prd.lusid.com/scheduler2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateSchedule**](SchedulesApi.md#createschedule) | **POST** /api/schedules | CreateSchedule: Create a Schedule for a job |
| [**DeleteSchedule**](SchedulesApi.md#deleteschedule) | **DELETE** /api/schedules/{scope}/{code} | DeleteSchedule: Delete a schedule |
| [**EnabledSchedule**](SchedulesApi.md#enabledschedule) | **PUT** /api/schedules/{scope}/{code}/enabled | EnabledSchedule: Enable/disable a schedule |
| [**GetSchedule**](SchedulesApi.md#getschedule) | **GET** /api/schedules/{scope}/{code} | GetSchedule: Get a single Schedule |
| [**ListSchedules**](SchedulesApi.md#listschedules) | **GET** /api/schedules | ListSchedules: List the available Schedules |
| [**RunSchedule**](SchedulesApi.md#runschedule) | **POST** /api/schedules/{scope}/{code}/$run | RunSchedule: Run a schedule immediately |
| [**UpdateSchedule**](SchedulesApi.md#updateschedule) | **PUT** /api/schedules/{scope}/{code} | UpdateSchedule: Update a schedule. |

<a id="createschedule"></a>
# **CreateSchedule**
> ScheduleDefinition CreateSchedule (CreateScheduleRequest createScheduleRequest)

CreateSchedule: Create a Schedule for a job

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SchedulesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SchedulesApi>();
            var createScheduleRequest = new CreateScheduleRequest(); // CreateScheduleRequest | 

            try
            {
                // uncomment the below to set overrides at the request level
                // ScheduleDefinition result = apiInstance.CreateSchedule(createScheduleRequest, opts: opts);

                // CreateSchedule: Create a Schedule for a job
                ScheduleDefinition result = apiInstance.CreateSchedule(createScheduleRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SchedulesApi.CreateSchedule: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateScheduleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CreateSchedule: Create a Schedule for a job
    ApiResponse<ScheduleDefinition> response = apiInstance.CreateScheduleWithHttpInfo(createScheduleRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SchedulesApi.CreateScheduleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createScheduleRequest** | [**CreateScheduleRequest**](CreateScheduleRequest.md) |  |  |

### Return type

[**ScheduleDefinition**](ScheduleDefinition.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created schedule |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="deleteschedule"></a>
# **DeleteSchedule**
> void DeleteSchedule (string scope, string code)

DeleteSchedule: Delete a schedule

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SchedulesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SchedulesApi>();
            var scope = "scope_example";  // string | Scope of the schedule to be deleted
            var code = "code_example";  // string | Code of the schedule to be deleted

            try
            {
                // uncomment the below to set overrides at the request level
                // apiInstance.DeleteSchedule(scope, code, opts: opts);

                // DeleteSchedule: Delete a schedule
                apiInstance.DeleteSchedule(scope, code);
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SchedulesApi.DeleteSchedule: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteScheduleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // DeleteSchedule: Delete a schedule
    apiInstance.DeleteScheduleWithHttpInfo(scope, code);
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SchedulesApi.DeleteScheduleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | Scope of the schedule to be deleted |  |
| **code** | **string** | Code of the schedule to be deleted |  |

### Return type

void (empty response body)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="enabledschedule"></a>
# **EnabledSchedule**
> ScheduleDefinition EnabledSchedule (string scope, string code, bool enable)

EnabledSchedule: Enable/disable a schedule

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SchedulesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SchedulesApi>();
            var scope = "scope_example";  // string | Scope of the schedule to be enabled/disabled
            var code = "code_example";  // string | Code of the schedule to be enabled/disabled
            var enable = true;  // bool | Specify whether to enable or disable the schedule

            try
            {
                // uncomment the below to set overrides at the request level
                // ScheduleDefinition result = apiInstance.EnabledSchedule(scope, code, enable, opts: opts);

                // EnabledSchedule: Enable/disable a schedule
                ScheduleDefinition result = apiInstance.EnabledSchedule(scope, code, enable);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SchedulesApi.EnabledSchedule: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the EnabledScheduleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // EnabledSchedule: Enable/disable a schedule
    ApiResponse<ScheduleDefinition> response = apiInstance.EnabledScheduleWithHttpInfo(scope, code, enable);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SchedulesApi.EnabledScheduleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | Scope of the schedule to be enabled/disabled |  |
| **code** | **string** | Code of the schedule to be enabled/disabled |  |
| **enable** | **bool** | Specify whether to enable or disable the schedule |  |

### Return type

[**ScheduleDefinition**](ScheduleDefinition.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getschedule"></a>
# **GetSchedule**
> ScheduleDefinition GetSchedule (string scope, string code)

GetSchedule: Get a single Schedule

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SchedulesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SchedulesApi>();
            var scope = "scope_example";  // string | The scope of Schedule
            var code = "code_example";  // string | The code of the Schedule

            try
            {
                // uncomment the below to set overrides at the request level
                // ScheduleDefinition result = apiInstance.GetSchedule(scope, code, opts: opts);

                // GetSchedule: Get a single Schedule
                ScheduleDefinition result = apiInstance.GetSchedule(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SchedulesApi.GetSchedule: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetScheduleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetSchedule: Get a single Schedule
    ApiResponse<ScheduleDefinition> response = apiInstance.GetScheduleWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SchedulesApi.GetScheduleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of Schedule |  |
| **code** | **string** | The code of the Schedule |  |

### Return type

[**ScheduleDefinition**](ScheduleDefinition.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listschedules"></a>
# **ListSchedules**
> ResourceListOfScheduleDefinition ListSchedules (string? page = null, List<string>? sortBy = null, int? start = null, int? limit = null, string? filter = null)

ListSchedules: List the available Schedules

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SchedulesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SchedulesApi>();
            var page = "page_example";  // string? | The pagination token to use to continue listing instruments from a previous call to list instruments.              This value is returned from the previous call. If a pagination token is provided the sortBy and filter fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var sortBy = new List<string>?(); // List<string>? | Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName. (optional) 
            var start = 56;  // int? | When paginating, skip this number of results. (optional) 
            var limit = 2000;  // int? | When paginating, limit the number of returned results to this many. Defaults to 2000 if not specified. Maximum is 5000. (optional)  (default to 2000)
            var filter = "filter_example";  // string? | Expression to filter the result set. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // ResourceListOfScheduleDefinition result = apiInstance.ListSchedules(page, sortBy, start, limit, filter, opts: opts);

                // ListSchedules: List the available Schedules
                ResourceListOfScheduleDefinition result = apiInstance.ListSchedules(page, sortBy, start, limit, filter);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SchedulesApi.ListSchedules: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSchedulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // ListSchedules: List the available Schedules
    ApiResponse<ResourceListOfScheduleDefinition> response = apiInstance.ListSchedulesWithHttpInfo(page, sortBy, start, limit, filter);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SchedulesApi.ListSchedulesWithHttpInfo: " + e.Message);
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

[**ResourceListOfScheduleDefinition**](ResourceListOfScheduleDefinition.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="runschedule"></a>
# **RunSchedule**
> StartScheduleResponse RunSchedule (string scope, string code)

RunSchedule: Run a schedule immediately

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SchedulesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SchedulesApi>();
            var scope = "scope_example";  // string | The schedule scope
            var code = "code_example";  // string | The schedule cde

            try
            {
                // uncomment the below to set overrides at the request level
                // StartScheduleResponse result = apiInstance.RunSchedule(scope, code, opts: opts);

                // RunSchedule: Run a schedule immediately
                StartScheduleResponse result = apiInstance.RunSchedule(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SchedulesApi.RunSchedule: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the RunScheduleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // RunSchedule: Run a schedule immediately
    ApiResponse<StartScheduleResponse> response = apiInstance.RunScheduleWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SchedulesApi.RunScheduleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The schedule scope |  |
| **code** | **string** | The schedule cde |  |

### Return type

[**StartScheduleResponse**](StartScheduleResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="updateschedule"></a>
# **UpdateSchedule**
> ScheduleDefinition UpdateSchedule (string scope, string code, UpdateScheduleRequest updateScheduleRequest)

UpdateSchedule: Update a schedule.

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
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SchedulesApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SchedulesApi>();
            var scope = "scope_example";  // string | Scope of the schedule to be updated
            var code = "code_example";  // string | Code of the schedule to be updated
            var updateScheduleRequest = new UpdateScheduleRequest(); // UpdateScheduleRequest | The updated schedule

            try
            {
                // uncomment the below to set overrides at the request level
                // ScheduleDefinition result = apiInstance.UpdateSchedule(scope, code, updateScheduleRequest, opts: opts);

                // UpdateSchedule: Update a schedule.
                ScheduleDefinition result = apiInstance.UpdateSchedule(scope, code, updateScheduleRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SchedulesApi.UpdateSchedule: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateScheduleWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpdateSchedule: Update a schedule.
    ApiResponse<ScheduleDefinition> response = apiInstance.UpdateScheduleWithHttpInfo(scope, code, updateScheduleRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SchedulesApi.UpdateScheduleWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | Scope of the schedule to be updated |  |
| **code** | **string** | Code of the schedule to be updated |  |
| **updateScheduleRequest** | [**UpdateScheduleRequest**](UpdateScheduleRequest.md) | The updated schedule |  |

### Return type

[**ScheduleDefinition**](ScheduleDefinition.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

