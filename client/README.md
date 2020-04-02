# Cloudmersive.APIClient.NETCore.ConfigurationAPI - the C# library for the configapi

Config API lets you easily manage configuration at scale.

This C# SDK is for the [Cloudmersive ConfigurationAPI API](https://www.cloudmersive.com/):

- API version: v1
- SDK version: 2.0.2
- Build package: io.swagger.codegen.languages.CSharpClientCodegen

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext
- UWP >=10.0

<a name="dependencies"></a>
## Dependencies
- FubarCoder.RestSharp.Portable.Core >=4.0.7
- FubarCoder.RestSharp.Portable.HttpClient >=4.0.7
- Newtonsoft.Json >=10.0.3

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Cloudmersive.APIClient.NETCore.ConfigurationAPI.Api;
using Cloudmersive.APIClient.NETCore.ConfigurationAPI.Client;
using Cloudmersive.APIClient.NETCore.ConfigurationAPI.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System;
using System.Diagnostics;
using Cloudmersive.APIClient.NETCore.ConfigurationAPI.Api;
using Cloudmersive.APIClient.NETCore.ConfigurationAPI.Client;
using Cloudmersive.APIClient.NETCore.ConfigurationAPI.Model;

namespace Example
{
    public class Example
    {
        public void main()
        {

            // Configure API key authorization: Apikey
            Configuration.Default.ApiKey.Add("Apikey", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // Configuration.Default.ApiKeyPrefix.Add("Apikey", "Bearer");

            var apiInstance = new OrchestratorApi();
            var request = new HttpOrchestrationRequest(); // HttpOrchestrationRequest | 

            try
            {
                // Orchestrate multiple HTTP API calls with a single API call in the order specified.  Call other Cloudmersive APIs or third party APIs.  For Cloudmersive APIs, the API Key will automatically propogate to the child calls without needing to be set explicitly.  Name each task and reference the output of a previous task in the inputs to a given task.
                HttpOrchestrationResponse result = apiInstance.OrchestratorHttpSimple(request);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling OrchestratorApi.OrchestratorHttpSimple: " + e.Message );
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.cloudmersive.com*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*OrchestratorApi* | [**OrchestratorHttpSimple**](docs/OrchestratorApi.md#orchestratorhttpsimple) | **POST** /config/orchestrator/http/simple | Orchestrate multiple HTTP API calls with a single API call in the order specified.  Call other Cloudmersive APIs or third party APIs.  For Cloudmersive APIs, the API Key will automatically propogate to the child calls without needing to be set explicitly.  Name each task and reference the output of a previous task in the inputs to a given task.
*SettingsApi* | [**SettingsCreateSetting**](docs/SettingsApi.md#settingscreatesetting) | **POST** /config/settings/create | Create a setting in the specified bucket
*SettingsApi* | [**SettingsListSettings**](docs/SettingsApi.md#settingslistsettings) | **POST** /config/settings/list | Enumerate the settings in a bucket
*SettingsApi* | [**SettingsUpdateSetting**](docs/SettingsApi.md#settingsupdatesetting) | **POST** /config/settings/update | Update a setting


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.CreateSettingRequest](docs/CreateSettingRequest.md)
 - [Model.CreateSettingResponse](docs/CreateSettingResponse.md)
 - [Model.HttpFormDataParameter](docs/HttpFormDataParameter.md)
 - [Model.HttpGetParameter](docs/HttpGetParameter.md)
 - [Model.HttpOrchestrationHeader](docs/HttpOrchestrationHeader.md)
 - [Model.HttpOrchestrationRequest](docs/HttpOrchestrationRequest.md)
 - [Model.HttpOrchestrationResponse](docs/HttpOrchestrationResponse.md)
 - [Model.HttpOrchestrationTask](docs/HttpOrchestrationTask.md)
 - [Model.HttpRawBinaryParameter](docs/HttpRawBinaryParameter.md)
 - [Model.HttpRawTextParameter](docs/HttpRawTextParameter.md)
 - [Model.HttpWwwFormUrlEncodedParameter](docs/HttpWwwFormUrlEncodedParameter.md)
 - [Model.ListSettingsRequest](docs/ListSettingsRequest.md)
 - [Model.ListSettingsResponse](docs/ListSettingsResponse.md)
 - [Model.SettingValue](docs/SettingValue.md)
 - [Model.TaskOutputReference](docs/TaskOutputReference.md)
 - [Model.UpdateSettingRequest](docs/UpdateSettingRequest.md)
 - [Model.UpdateSettingResponse](docs/UpdateSettingResponse.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="Apikey"></a>
### Apikey

- **Type**: API key
- **API key parameter name**: Apikey
- **Location**: HTTP header

