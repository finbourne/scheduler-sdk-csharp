# Finbourne.Scheduler.Sdk.Api.SchedulesApi

All URIs are relative to *https://fbn-prd.lusid.com/scheduler2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateSchedule**](SchedulesApi.md#createschedule) | **POST** /api/schedules | [EXPERIMENTAL] CreateSchedule: Create a Schedule for a job |
| [**DeleteSchedule**](SchedulesApi.md#deleteschedule) | **DELETE** /api/schedules/{scope}/{code} | [EXPERIMENTAL] DeleteSchedule: Delete a schedule |
| [**EnabledSchedule**](SchedulesApi.md#enabledschedule) | **PUT** /api/schedules/{scope}/{code}/enabled | [EXPERIMENTAL] EnabledSchedule: Enable/disable a schedule |
| [**GetSchedule**](SchedulesApi.md#getschedule) | **GET** /api/schedules/{scope}/{code} | [EXPERIMENTAL] GetSchedule: Get a single Schedule |
| [**ListSchedules**](SchedulesApi.md#listschedules) | **GET** /api/schedules | [EXPERIMENTAL] ListSchedules: List the available Schedules |
| [**RunSchedule**](SchedulesApi.md#runschedule) | **POST** /api/schedules/{scope}/{code}/$run | [EXPERIMENTAL] RunSchedule: Run a schedule immediately |
| [**UpdateSchedule**](SchedulesApi.md#updateschedule) | **PUT** /api/schedules/{scope}/{code} | [EXPERIMENTAL] UpdateSchedule: Update a schedule. |

<a id="createschedule"></a>
# **CreateSchedule**
> ScheduleDefinition CreateSchedule (CreateScheduleRequest createScheduleRequest)

[EXPERIMENTAL] CreateSchedule: Create a Schedule for a job

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Model;

namespace Example
{
    public class CreateScheduleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/scheduler2";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchedulesApi(config);
            var createScheduleRequest = new CreateScheduleRequest(); // CreateScheduleRequest | 

            try
            {
                // [EXPERIMENTAL] CreateSchedule: Create a Schedule for a job
                ScheduleDefinition result = apiInstance.CreateSchedule(createScheduleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchedulesApi.CreateSchedule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EXPERIMENTAL] CreateSchedule: Create a Schedule for a job
    ApiResponse<ScheduleDefinition> response = apiInstance.CreateScheduleWithHttpInfo(createScheduleRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchedulesApi.CreateScheduleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createScheduleRequest** | [**CreateScheduleRequest**](CreateScheduleRequest.md) |  |  |

### Return type

[**ScheduleDefinition**](ScheduleDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created schedule |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteschedule"></a>
# **DeleteSchedule**
> void DeleteSchedule (string scope, string code)

[EXPERIMENTAL] DeleteSchedule: Delete a schedule

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Model;

namespace Example
{
    public class DeleteScheduleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/scheduler2";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchedulesApi(config);
            var scope = "scope_example";  // string | Scope of the schedule to be deleted
            var code = "code_example";  // string | Code of the schedule to be deleted

            try
            {
                // [EXPERIMENTAL] DeleteSchedule: Delete a schedule
                apiInstance.DeleteSchedule(scope, code);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchedulesApi.DeleteSchedule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EXPERIMENTAL] DeleteSchedule: Delete a schedule
    apiInstance.DeleteScheduleWithHttpInfo(scope, code);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchedulesApi.DeleteScheduleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | Scope of the schedule to be deleted |  |
| **code** | **string** | Code of the schedule to be deleted |  |

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | No Content |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="enabledschedule"></a>
# **EnabledSchedule**
> ScheduleDefinition EnabledSchedule (string scope, string code, bool enable)

[EXPERIMENTAL] EnabledSchedule: Enable/disable a schedule

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Model;

namespace Example
{
    public class EnabledScheduleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/scheduler2";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchedulesApi(config);
            var scope = "scope_example";  // string | Scope of the schedule to be enabled/disabled
            var code = "code_example";  // string | Code of the schedule to be enabled/disabled
            var enable = true;  // bool | Specify whether to enable or disable the schedule

            try
            {
                // [EXPERIMENTAL] EnabledSchedule: Enable/disable a schedule
                ScheduleDefinition result = apiInstance.EnabledSchedule(scope, code, enable);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchedulesApi.EnabledSchedule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EXPERIMENTAL] EnabledSchedule: Enable/disable a schedule
    ApiResponse<ScheduleDefinition> response = apiInstance.EnabledScheduleWithHttpInfo(scope, code, enable);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchedulesApi.EnabledScheduleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
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

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getschedule"></a>
# **GetSchedule**
> ScheduleDefinition GetSchedule (string scope, string code)

[EXPERIMENTAL] GetSchedule: Get a single Schedule

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Model;

namespace Example
{
    public class GetScheduleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/scheduler2";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchedulesApi(config);
            var scope = "scope_example";  // string | The scope of Schedule
            var code = "code_example";  // string | The code of the Schedule

            try
            {
                // [EXPERIMENTAL] GetSchedule: Get a single Schedule
                ScheduleDefinition result = apiInstance.GetSchedule(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchedulesApi.GetSchedule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EXPERIMENTAL] GetSchedule: Get a single Schedule
    ApiResponse<ScheduleDefinition> response = apiInstance.GetScheduleWithHttpInfo(scope, code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchedulesApi.GetScheduleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of Schedule |  |
| **code** | **string** | The code of the Schedule |  |

### Return type

[**ScheduleDefinition**](ScheduleDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listschedules"></a>
# **ListSchedules**
> ResourceListOfScheduleDefinition ListSchedules (string? page = null, List<string>? sortBy = null, int? start = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] ListSchedules: List the available Schedules

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Model;

namespace Example
{
    public class ListSchedulesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/scheduler2";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchedulesApi(config);
            var page = "page_example";  // string? | The pagination token to use to continue listing instruments from a previous call to list instruments.              This value is returned from the previous call. If a pagination token is provided the sortBy and filter fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var sortBy = new List<string>?(); // List<string>? | Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName. (optional) 
            var start = 56;  // int? | When paginating, skip this number of results. (optional) 
            var limit = 2000;  // int? | When paginating, limit the number of returned results to this many. Defaults to 2000 if not specified. Maximum is 5000. (optional)  (default to 2000)
            var filter = "filter_example";  // string? | Expression to filter the result set. (optional) 

            try
            {
                // [EXPERIMENTAL] ListSchedules: List the available Schedules
                ResourceListOfScheduleDefinition result = apiInstance.ListSchedules(page, sortBy, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchedulesApi.ListSchedules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EXPERIMENTAL] ListSchedules: List the available Schedules
    ApiResponse<ResourceListOfScheduleDefinition> response = apiInstance.ListSchedulesWithHttpInfo(page, sortBy, start, limit, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchedulesApi.ListSchedulesWithHttpInfo: " + e.Message);
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

[**ResourceListOfScheduleDefinition**](ResourceListOfScheduleDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="runschedule"></a>
# **RunSchedule**
> StartScheduleResponse RunSchedule (string scope, string code)

[EXPERIMENTAL] RunSchedule: Run a schedule immediately

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Model;

namespace Example
{
    public class RunScheduleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/scheduler2";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchedulesApi(config);
            var scope = "scope_example";  // string | The schedule scope
            var code = "code_example";  // string | The schedule cde

            try
            {
                // [EXPERIMENTAL] RunSchedule: Run a schedule immediately
                StartScheduleResponse result = apiInstance.RunSchedule(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchedulesApi.RunSchedule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EXPERIMENTAL] RunSchedule: Run a schedule immediately
    ApiResponse<StartScheduleResponse> response = apiInstance.RunScheduleWithHttpInfo(scope, code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchedulesApi.RunScheduleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The schedule scope |  |
| **code** | **string** | The schedule cde |  |

### Return type

[**StartScheduleResponse**](StartScheduleResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **202** | Accepted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateschedule"></a>
# **UpdateSchedule**
> ScheduleDefinition UpdateSchedule (string scope, string code, UpdateScheduleRequest updateScheduleRequest)

[EXPERIMENTAL] UpdateSchedule: Update a schedule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Model;

namespace Example
{
    public class UpdateScheduleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-prd.lusid.com/scheduler2";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SchedulesApi(config);
            var scope = "scope_example";  // string | Scope of the schedule to be updated
            var code = "code_example";  // string | Code of the schedule to be updated
            var updateScheduleRequest = new UpdateScheduleRequest(); // UpdateScheduleRequest | The updated schedule

            try
            {
                // [EXPERIMENTAL] UpdateSchedule: Update a schedule.
                ScheduleDefinition result = apiInstance.UpdateSchedule(scope, code, updateScheduleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SchedulesApi.UpdateSchedule: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
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
    // [EXPERIMENTAL] UpdateSchedule: Update a schedule.
    ApiResponse<ScheduleDefinition> response = apiInstance.UpdateScheduleWithHttpInfo(scope, code, updateScheduleRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SchedulesApi.UpdateScheduleWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
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

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

