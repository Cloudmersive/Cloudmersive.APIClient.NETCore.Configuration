/* 
 * configapi
 *
 * Config API lets you easily manage configuration at scale.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Cloudmersive.APIClient.NETCore.ConfigurationAPI.Client;
using Cloudmersive.APIClient.NETCore.ConfigurationAPI.Model;

namespace Cloudmersive.APIClient.NETCore.ConfigurationAPI.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IOrchestratorApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Orchestrate multiple HTTP API calls with a single API call in the order specified.  Call other Cloudmersive APIs or third party APIs.  For Cloudmersive APIs, the API Key will automatically propogate to the child calls without needing to be set explicitly.  Name each task and reference the output of a previous task in the inputs to a given task.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.ConfigurationAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <returns>HttpOrchestrationResponse</returns>
        HttpOrchestrationResponse OrchestratorHttpSimple (HttpOrchestrationRequest request);

        /// <summary>
        /// Orchestrate multiple HTTP API calls with a single API call in the order specified.  Call other Cloudmersive APIs or third party APIs.  For Cloudmersive APIs, the API Key will automatically propogate to the child calls without needing to be set explicitly.  Name each task and reference the output of a previous task in the inputs to a given task.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.ConfigurationAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <returns>ApiResponse of HttpOrchestrationResponse</returns>
        ApiResponse<HttpOrchestrationResponse> OrchestratorHttpSimpleWithHttpInfo (HttpOrchestrationRequest request);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Orchestrate multiple HTTP API calls with a single API call in the order specified.  Call other Cloudmersive APIs or third party APIs.  For Cloudmersive APIs, the API Key will automatically propogate to the child calls without needing to be set explicitly.  Name each task and reference the output of a previous task in the inputs to a given task.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.ConfigurationAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <returns>Task of HttpOrchestrationResponse</returns>
        System.Threading.Tasks.Task<HttpOrchestrationResponse> OrchestratorHttpSimpleAsync (HttpOrchestrationRequest request);

        /// <summary>
        /// Orchestrate multiple HTTP API calls with a single API call in the order specified.  Call other Cloudmersive APIs or third party APIs.  For Cloudmersive APIs, the API Key will automatically propogate to the child calls without needing to be set explicitly.  Name each task and reference the output of a previous task in the inputs to a given task.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Cloudmersive.APIClient.NETCore.ConfigurationAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <returns>Task of ApiResponse (HttpOrchestrationResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<HttpOrchestrationResponse>> OrchestratorHttpSimpleAsyncWithHttpInfo (HttpOrchestrationRequest request);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class OrchestratorApi : IOrchestratorApi
    {
        private Cloudmersive.APIClient.NETCore.ConfigurationAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="OrchestratorApi"/> class.
        /// </summary>
        /// <returns></returns>
        public OrchestratorApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Cloudmersive.APIClient.NETCore.ConfigurationAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrchestratorApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public OrchestratorApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Cloudmersive.APIClient.NETCore.ConfigurationAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Cloudmersive.APIClient.NETCore.ConfigurationAPI.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Orchestrate multiple HTTP API calls with a single API call in the order specified.  Call other Cloudmersive APIs or third party APIs.  For Cloudmersive APIs, the API Key will automatically propogate to the child calls without needing to be set explicitly.  Name each task and reference the output of a previous task in the inputs to a given task. 
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.ConfigurationAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <returns>HttpOrchestrationResponse</returns>
        public HttpOrchestrationResponse OrchestratorHttpSimple (HttpOrchestrationRequest request)
        {
             ApiResponse<HttpOrchestrationResponse> localVarResponse = OrchestratorHttpSimpleWithHttpInfo(request);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Orchestrate multiple HTTP API calls with a single API call in the order specified.  Call other Cloudmersive APIs or third party APIs.  For Cloudmersive APIs, the API Key will automatically propogate to the child calls without needing to be set explicitly.  Name each task and reference the output of a previous task in the inputs to a given task. 
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.ConfigurationAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <returns>ApiResponse of HttpOrchestrationResponse</returns>
        public ApiResponse< HttpOrchestrationResponse > OrchestratorHttpSimpleWithHttpInfo (HttpOrchestrationRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling OrchestratorApi->OrchestratorHttpSimple");

            var localVarPath = "/config/orchestrator/http/simple";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OrchestratorHttpSimple", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<HttpOrchestrationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HttpOrchestrationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(HttpOrchestrationResponse)));
        }

        /// <summary>
        /// Orchestrate multiple HTTP API calls with a single API call in the order specified.  Call other Cloudmersive APIs or third party APIs.  For Cloudmersive APIs, the API Key will automatically propogate to the child calls without needing to be set explicitly.  Name each task and reference the output of a previous task in the inputs to a given task. 
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.ConfigurationAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <returns>Task of HttpOrchestrationResponse</returns>
        public async System.Threading.Tasks.Task<HttpOrchestrationResponse> OrchestratorHttpSimpleAsync (HttpOrchestrationRequest request)
        {
             ApiResponse<HttpOrchestrationResponse> localVarResponse = await OrchestratorHttpSimpleAsyncWithHttpInfo(request);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Orchestrate multiple HTTP API calls with a single API call in the order specified.  Call other Cloudmersive APIs or third party APIs.  For Cloudmersive APIs, the API Key will automatically propogate to the child calls without needing to be set explicitly.  Name each task and reference the output of a previous task in the inputs to a given task. 
        /// </summary>
        /// <exception cref="Cloudmersive.APIClient.NETCore.ConfigurationAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="request"></param>
        /// <returns>Task of ApiResponse (HttpOrchestrationResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<HttpOrchestrationResponse>> OrchestratorHttpSimpleAsyncWithHttpInfo (HttpOrchestrationRequest request)
        {
            // verify the required parameter 'request' is set
            if (request == null)
                throw new ApiException(400, "Missing required parameter 'request' when calling OrchestratorApi->OrchestratorHttpSimple");

            var localVarPath = "/config/orchestrator/http/simple";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (request != null && request.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(request); // http body (model) parameter
            }
            else
            {
                localVarPostBody = request; // byte array
            }

            // authentication (Apikey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("Apikey")))
            {
                localVarHeaderParams["Apikey"] = Configuration.GetApiKeyWithPrefix("Apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("OrchestratorHttpSimple", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<HttpOrchestrationResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (HttpOrchestrationResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(HttpOrchestrationResponse)));
        }

    }
}
