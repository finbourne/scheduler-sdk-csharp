![LUSID_by_Finbourne](./resources/Finbourne_Logo_Teal.svg)

# LUSID<sup>®</sup> Scheduler SDK C#

This is the C# SDK for the Scheduler application, part of the [LUSID by FINBOURNE](https://www.finbourne.com/lusid-technology) platform. To use it you'll need a LUSID account. [Sign up for free at lusid.com](https://www.lusid.com/app/signup).

The Scheduler application provides automated job scheduling functionality.

For more details on other applications in the LUSID platform, see [Understanding all the applications in the LUSID platform](https://support.lusid.com/knowledgebase/article/KA-01787/en-us).

[C# SDK Extensions](https://github.com/finbourne/scheduler-sdk-extensions-csharp) to accompany this SDK are available. These provides the user with additional extensions to make it easy to configure and use the API endpoints.

## Installation

The NuGet package for the FINBOURNE Scheduler service SDK can installed from https://www.nuget.org/packages/Finbourne.Scheduler.Sdk using the following:

```
$ dotnet add package Finbourne.Scheduler.Sdk
```

This C# SDK supports `Production`, `Early Access`, `Beta` and `Experimental` API endpoints. For more details on API endpoint categories, see [Documentation - Release Lifecycle](https://www.lusid.com/app/resources/documentation/lifecycle). To find out which category an API endpoint falls into, see [FINBOURNE Scheduler API Documentation](https://www.lusid.com/scheduler2/swagger/index.html).

## Build Status 

| branch | status |
| --- | --- |
| `main` |  ![Nuget](https://img.shields.io/nuget/v/Finbourne.Scheduler.Sdk?color=blue) [![Build](https://github.com/finbourne/scheduler-sdk-csharp/actions/workflows/build.yaml/badge.svg?branch=main)](https://github.com/finbourne/scheduler-sdk-csharp/actions/workflows/build.yaml) |
