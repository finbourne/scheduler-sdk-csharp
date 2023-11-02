# Finbourne.Scheduler.Sdk.Api.ImagesApi

All URIs are relative to *https://fbn-ci.lusid.com/scheduler2*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteImage**](ImagesApi.md#deleteimage) | **DELETE** /api/images/{name} | [EXPERIMENTAL] DeleteImage: Delete a Docker Image |
| [**DownloadImage**](ImagesApi.md#downloadimage) | **GET** /api/images/{name}/contents | [EXPERIMENTAL] DownloadImage: Download Docker Image |
| [**GetImage**](ImagesApi.md#getimage) | **GET** /api/images/{name} | [EXPERIMENTAL] GetImage: Get metadata of a Docker Image |
| [**ListImages**](ImagesApi.md#listimages) | **GET** /api/images/repository/{name} | [EXPERIMENTAL] ListImages: List all images under same image repository |
| [**ListRepositories**](ImagesApi.md#listrepositories) | **GET** /api/images/repository | [EXPERIMENTAL] ListRepositories: List all Docker image repositories |
| [**UploadImage**](ImagesApi.md#uploadimage) | **POST** /api/images | [EXPERIMENTAL] UploadImage: Upload a Docker Image used for Scheduler jobs |

<a id="deleteimage"></a>
# **DeleteImage**
> string DeleteImage (string name)

[EXPERIMENTAL] DeleteImage: Delete a Docker Image

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Model;

namespace Example
{
    public class DeleteImageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-ci.lusid.com/scheduler2";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ImagesApi(config);
            var name = "name_example";  // string | The name and tag of the image. Format \"ExampleImageName:0.1\"

            try
            {
                // [EXPERIMENTAL] DeleteImage: Delete a Docker Image
                string result = apiInstance.DeleteImage(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ImagesApi.DeleteImage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteImageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteImage: Delete a Docker Image
    ApiResponse<string> response = apiInstance.DeleteImageWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ImagesApi.DeleteImageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The name and tag of the image. Format \&quot;ExampleImageName:0.1\&quot; |  |

### Return type

**string**

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
| **404** | No image with this name and tag exists |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="downloadimage"></a>
# **DownloadImage**
> System.IO.Stream DownloadImage (string name)

[EXPERIMENTAL] DownloadImage: Download Docker Image

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Model;

namespace Example
{
    public class DownloadImageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-ci.lusid.com/scheduler2";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ImagesApi(config);
            var name = "name_example";  // string | The name and tag of the image of the image. Format \"ExampleImageName:latest\"

            try
            {
                // [EXPERIMENTAL] DownloadImage: Download Docker Image
                System.IO.Stream result = apiInstance.DownloadImage(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ImagesApi.DownloadImage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DownloadImageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DownloadImage: Download Docker Image
    ApiResponse<System.IO.Stream> response = apiInstance.DownloadImageWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ImagesApi.DownloadImageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The name and tag of the image of the image. Format \&quot;ExampleImageName:latest\&quot; |  |

### Return type

**System.IO.Stream**

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

<a id="getimage"></a>
# **GetImage**
> Image GetImage (string name)

[EXPERIMENTAL] GetImage: Get metadata of a Docker Image

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Model;

namespace Example
{
    public class GetImageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-ci.lusid.com/scheduler2";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ImagesApi(config);
            var name = "name_example";  // string | The name and tag of a Docker image. Format \"ExampleImageName:latest\"

            try
            {
                // [EXPERIMENTAL] GetImage: Get metadata of a Docker Image
                Image result = apiInstance.GetImage(name);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ImagesApi.GetImage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetImageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetImage: Get metadata of a Docker Image
    ApiResponse<Image> response = apiInstance.GetImageWithHttpInfo(name);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ImagesApi.GetImageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The name and tag of a Docker image. Format \&quot;ExampleImageName:latest\&quot; |  |

### Return type

[**Image**](Image.md)

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

<a id="listimages"></a>
# **ListImages**
> ResourceListOfImageSummary ListImages (string name, string? page = null, List<string>? sortBy = null, int? start = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] ListImages: List all images under same image repository

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Model;

namespace Example
{
    public class ListImagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-ci.lusid.com/scheduler2";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ImagesApi(config);
            var name = "name_example";  // string | The name of the Repository
            var page = "page_example";  // string? | The pagination token to use to continue listing images from a previous call to list images.              This value is returned from the previous call. If a pagination token is provided the sortBy and filter fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var sortBy = new List<string>?(); // List<string>? | Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName. (optional) 
            var start = 56;  // int? | When paginating, skip this number of results. (optional) 
            var limit = 2000;  // int? | When paginating, limit the number of returned results to this many. Defaults to 2000 if not specified. Maximum is 5000. (optional)  (default to 2000)
            var filter = "filter_example";  // string? | Expression to filter the result set. (optional) 

            try
            {
                // [EXPERIMENTAL] ListImages: List all images under same image repository
                ResourceListOfImageSummary result = apiInstance.ListImages(name, page, sortBy, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ImagesApi.ListImages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListImagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListImages: List all images under same image repository
    ApiResponse<ResourceListOfImageSummary> response = apiInstance.ListImagesWithHttpInfo(name, page, sortBy, start, limit, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ImagesApi.ListImagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | The name of the Repository |  |
| **page** | **string?** | The pagination token to use to continue listing images from a previous call to list images.              This value is returned from the previous call. If a pagination token is provided the sortBy and filter fields              must not have changed since the original request. Also, if set, a start value cannot be provided. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. | [optional]  |
| **start** | **int?** | When paginating, skip this number of results. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. Defaults to 2000 if not specified. Maximum is 5000. | [optional] [default to 2000] |
| **filter** | **string?** | Expression to filter the result set. | [optional]  |

### Return type

[**ResourceListOfImageSummary**](ResourceListOfImageSummary.md)

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

<a id="listrepositories"></a>
# **ListRepositories**
> ResourceListOfRepository ListRepositories (string? page = null, List<string>? sortBy = null, int? start = null, int? limit = null, string? filter = null)

[EXPERIMENTAL] ListRepositories: List all Docker image repositories

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Model;

namespace Example
{
    public class ListRepositoriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-ci.lusid.com/scheduler2";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ImagesApi(config);
            var page = "page_example";  // string? | The pagination token to use to continue listing images from a previous call to list images.              This value is returned from the previous call. If a pagination token is provided the sortBy and filter fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var sortBy = new List<string>?(); // List<string>? | Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName. (optional) 
            var start = 56;  // int? | When paginating, skip this number of results. (optional) 
            var limit = 2000;  // int? | When paginating, limit the number of returned results to this many. Defaults to 2000 if not specified. Maximum is 5000. (optional)  (default to 2000)
            var filter = "filter_example";  // string? | Expression to filter the result set. (optional) 

            try
            {
                // [EXPERIMENTAL] ListRepositories: List all Docker image repositories
                ResourceListOfRepository result = apiInstance.ListRepositories(page, sortBy, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ImagesApi.ListRepositories: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListRepositoriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListRepositories: List all Docker image repositories
    ApiResponse<ResourceListOfRepository> response = apiInstance.ListRepositoriesWithHttpInfo(page, sortBy, start, limit, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ImagesApi.ListRepositoriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **page** | **string?** | The pagination token to use to continue listing images from a previous call to list images.              This value is returned from the previous call. If a pagination token is provided the sortBy and filter fields              must not have changed since the original request. Also, if set, a start value cannot be provided. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName. | [optional]  |
| **start** | **int?** | When paginating, skip this number of results. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. Defaults to 2000 if not specified. Maximum is 5000. | [optional] [default to 2000] |
| **filter** | **string?** | Expression to filter the result set. | [optional]  |

### Return type

[**ResourceListOfRepository**](ResourceListOfRepository.md)

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

<a id="uploadimage"></a>
# **UploadImage**
> UploadImageInstructions UploadImage (UploadImageRequest uploadImageRequest)

[EXPERIMENTAL] UploadImage: Upload a Docker Image used for Scheduler jobs

Every image must have at least one tag. Note: your image will not be available until the returned Docker commands are executed.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Scheduler.Sdk.Api;
using Finbourne.Scheduler.Sdk.Client;
using Finbourne.Scheduler.Sdk.Model;

namespace Example
{
    public class UploadImageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://fbn-ci.lusid.com/scheduler2";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ImagesApi(config);
            var uploadImageRequest = new UploadImageRequest(); // UploadImageRequest | Request to upload image

            try
            {
                // [EXPERIMENTAL] UploadImage: Upload a Docker Image used for Scheduler jobs
                UploadImageInstructions result = apiInstance.UploadImage(uploadImageRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ImagesApi.UploadImage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UploadImageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UploadImage: Upload a Docker Image used for Scheduler jobs
    ApiResponse<UploadImageInstructions> response = apiInstance.UploadImageWithHttpInfo(uploadImageRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ImagesApi.UploadImageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uploadImageRequest** | [**UploadImageRequest**](UploadImageRequest.md) | Request to upload image |  |

### Return type

[**UploadImageInstructions**](UploadImageInstructions.md)

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

