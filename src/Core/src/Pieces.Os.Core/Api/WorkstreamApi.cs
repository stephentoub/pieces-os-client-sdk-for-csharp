/*
 * Pieces Isomorphic OpenAPI
 *
 * Endpoints for Assets, Formats, Users, Asset, Format, User.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: tsavo@pieces.app
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Pieces.Os.Core.Client;
using Pieces.Os.Core.Client.Auth;
using Pieces.Os.Core.SdkModel;

namespace Pieces.Os.Core.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWorkstreamApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// /workstream/suggestions/refresh [POST]
        /// </summary>
        /// <remarks>
        /// This will trigger a refresh(recalculation) of the suggestions items.
        /// </remarks>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="seededWorkstreamSuggestionsRefresh"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>WorkstreamSuggestionsRefresh</returns>
        WorkstreamSuggestionsRefresh WorkstreamSuggestionsRefresh(SeededWorkstreamSuggestionsRefresh seededWorkstreamSuggestionsRefresh = default(SeededWorkstreamSuggestionsRefresh), int operationIndex = 0);

        /// <summary>
        /// /workstream/suggestions/refresh [POST]
        /// </summary>
        /// <remarks>
        /// This will trigger a refresh(recalculation) of the suggestions items.
        /// </remarks>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="seededWorkstreamSuggestionsRefresh"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of WorkstreamSuggestionsRefresh</returns>
        ApiResponse<WorkstreamSuggestionsRefresh> WorkstreamSuggestionsRefreshWithHttpInfo(SeededWorkstreamSuggestionsRefresh seededWorkstreamSuggestionsRefresh = default(SeededWorkstreamSuggestionsRefresh), int operationIndex = 0);
        /// <summary>
        /// /workstream/suggestions/stream [WS]
        /// </summary>
        /// <remarks>
        /// Provides a WebSocket connection that emits changes to your workstream suggestions.
        /// </remarks>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>WorkstreamSuggestions</returns>
        WorkstreamSuggestions WorkstreamSuggestionsStream(int operationIndex = 0);

        /// <summary>
        /// /workstream/suggestions/stream [WS]
        /// </summary>
        /// <remarks>
        /// Provides a WebSocket connection that emits changes to your workstream suggestions.
        /// </remarks>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of WorkstreamSuggestions</returns>
        ApiResponse<WorkstreamSuggestions> WorkstreamSuggestionsStreamWithHttpInfo(int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWorkstreamApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// /workstream/suggestions/refresh [POST]
        /// </summary>
        /// <remarks>
        /// This will trigger a refresh(recalculation) of the suggestions items.
        /// </remarks>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="seededWorkstreamSuggestionsRefresh"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of WorkstreamSuggestionsRefresh</returns>
        System.Threading.Tasks.Task<WorkstreamSuggestionsRefresh> WorkstreamSuggestionsRefreshAsync(SeededWorkstreamSuggestionsRefresh seededWorkstreamSuggestionsRefresh = default(SeededWorkstreamSuggestionsRefresh), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// /workstream/suggestions/refresh [POST]
        /// </summary>
        /// <remarks>
        /// This will trigger a refresh(recalculation) of the suggestions items.
        /// </remarks>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="seededWorkstreamSuggestionsRefresh"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (WorkstreamSuggestionsRefresh)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkstreamSuggestionsRefresh>> WorkstreamSuggestionsRefreshWithHttpInfoAsync(SeededWorkstreamSuggestionsRefresh seededWorkstreamSuggestionsRefresh = default(SeededWorkstreamSuggestionsRefresh), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        /// <summary>
        /// /workstream/suggestions/stream [WS]
        /// </summary>
        /// <remarks>
        /// Provides a WebSocket connection that emits changes to your workstream suggestions.
        /// </remarks>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of WorkstreamSuggestions</returns>
        System.Threading.Tasks.Task<WorkstreamSuggestions> WorkstreamSuggestionsStreamAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));

        /// <summary>
        /// /workstream/suggestions/stream [WS]
        /// </summary>
        /// <remarks>
        /// Provides a WebSocket connection that emits changes to your workstream suggestions.
        /// </remarks>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (WorkstreamSuggestions)</returns>
        System.Threading.Tasks.Task<ApiResponse<WorkstreamSuggestions>> WorkstreamSuggestionsStreamWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWorkstreamApi : IWorkstreamApiSync, IWorkstreamApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class WorkstreamApi : IWorkstreamApi
    {
        private Pieces.Os.Core.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkstreamApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WorkstreamApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkstreamApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WorkstreamApi(string basePath)
        {
            this.Configuration = Pieces.Os.Core.Client.Configuration.MergeConfigurations(
                Pieces.Os.Core.Client.GlobalConfiguration.Instance,
                new Pieces.Os.Core.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Pieces.Os.Core.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Pieces.Os.Core.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Pieces.Os.Core.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkstreamApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WorkstreamApi(Pieces.Os.Core.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Pieces.Os.Core.Client.Configuration.MergeConfigurations(
                Pieces.Os.Core.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Pieces.Os.Core.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Pieces.Os.Core.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Pieces.Os.Core.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkstreamApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public WorkstreamApi(Pieces.Os.Core.Client.ISynchronousClient client, Pieces.Os.Core.Client.IAsynchronousClient asyncClient, Pieces.Os.Core.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Pieces.Os.Core.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Pieces.Os.Core.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Pieces.Os.Core.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Pieces.Os.Core.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Pieces.Os.Core.Client.ExceptionFactory ExceptionFactory
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
        /// /workstream/suggestions/refresh [POST] This will trigger a refresh(recalculation) of the suggestions items.
        /// </summary>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="seededWorkstreamSuggestionsRefresh"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>WorkstreamSuggestionsRefresh</returns>
        public WorkstreamSuggestionsRefresh WorkstreamSuggestionsRefresh(SeededWorkstreamSuggestionsRefresh seededWorkstreamSuggestionsRefresh = default(SeededWorkstreamSuggestionsRefresh), int operationIndex = 0)
        {
            Pieces.Os.Core.Client.ApiResponse<WorkstreamSuggestionsRefresh> localVarResponse = WorkstreamSuggestionsRefreshWithHttpInfo(seededWorkstreamSuggestionsRefresh);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /workstream/suggestions/refresh [POST] This will trigger a refresh(recalculation) of the suggestions items.
        /// </summary>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="seededWorkstreamSuggestionsRefresh"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of WorkstreamSuggestionsRefresh</returns>
        public Pieces.Os.Core.Client.ApiResponse<WorkstreamSuggestionsRefresh> WorkstreamSuggestionsRefreshWithHttpInfo(SeededWorkstreamSuggestionsRefresh seededWorkstreamSuggestionsRefresh = default(SeededWorkstreamSuggestionsRefresh), int operationIndex = 0)
        {
            Pieces.Os.Core.Client.RequestOptions localVarRequestOptions = new Pieces.Os.Core.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/plain"
            };

            var localVarContentType = Pieces.Os.Core.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Pieces.Os.Core.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = seededWorkstreamSuggestionsRefresh;

            localVarRequestOptions.Operation = "WorkstreamApi.WorkstreamSuggestionsRefresh";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (application) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Application-ID")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Application-ID", this.Configuration.GetApiKeyWithPrefix("X-Application-ID"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<WorkstreamSuggestionsRefresh>("/workstream/suggestions/refresh", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("WorkstreamSuggestionsRefresh", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /workstream/suggestions/refresh [POST] This will trigger a refresh(recalculation) of the suggestions items.
        /// </summary>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="seededWorkstreamSuggestionsRefresh"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of WorkstreamSuggestionsRefresh</returns>
        public async System.Threading.Tasks.Task<WorkstreamSuggestionsRefresh> WorkstreamSuggestionsRefreshAsync(SeededWorkstreamSuggestionsRefresh seededWorkstreamSuggestionsRefresh = default(SeededWorkstreamSuggestionsRefresh), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            Pieces.Os.Core.Client.ApiResponse<WorkstreamSuggestionsRefresh> localVarResponse = await WorkstreamSuggestionsRefreshWithHttpInfoAsync(seededWorkstreamSuggestionsRefresh, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /workstream/suggestions/refresh [POST] This will trigger a refresh(recalculation) of the suggestions items.
        /// </summary>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="seededWorkstreamSuggestionsRefresh"> (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (WorkstreamSuggestionsRefresh)</returns>
        public async System.Threading.Tasks.Task<Pieces.Os.Core.Client.ApiResponse<WorkstreamSuggestionsRefresh>> WorkstreamSuggestionsRefreshWithHttpInfoAsync(SeededWorkstreamSuggestionsRefresh seededWorkstreamSuggestionsRefresh = default(SeededWorkstreamSuggestionsRefresh), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {

            Pieces.Os.Core.Client.RequestOptions localVarRequestOptions = new Pieces.Os.Core.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/plain"
            };

            var localVarContentType = Pieces.Os.Core.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Pieces.Os.Core.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = seededWorkstreamSuggestionsRefresh;

            localVarRequestOptions.Operation = "WorkstreamApi.WorkstreamSuggestionsRefresh";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (application) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Application-ID")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Application-ID", this.Configuration.GetApiKeyWithPrefix("X-Application-ID"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<WorkstreamSuggestionsRefresh>("/workstream/suggestions/refresh", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("WorkstreamSuggestionsRefresh", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /workstream/suggestions/stream [WS] Provides a WebSocket connection that emits changes to your workstream suggestions.
        /// </summary>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>WorkstreamSuggestions</returns>
        public WorkstreamSuggestions WorkstreamSuggestionsStream(int operationIndex = 0)
        {
            Pieces.Os.Core.Client.ApiResponse<WorkstreamSuggestions> localVarResponse = WorkstreamSuggestionsStreamWithHttpInfo();
            return localVarResponse.Data;
        }

        /// <summary>
        /// /workstream/suggestions/stream [WS] Provides a WebSocket connection that emits changes to your workstream suggestions.
        /// </summary>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of WorkstreamSuggestions</returns>
        public Pieces.Os.Core.Client.ApiResponse<WorkstreamSuggestions> WorkstreamSuggestionsStreamWithHttpInfo(int operationIndex = 0)
        {
            Pieces.Os.Core.Client.RequestOptions localVarRequestOptions = new Pieces.Os.Core.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/plain"
            };

            var localVarContentType = Pieces.Os.Core.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Pieces.Os.Core.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "WorkstreamApi.WorkstreamSuggestionsStream";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (application) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Application-ID")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Application-ID", this.Configuration.GetApiKeyWithPrefix("X-Application-ID"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<WorkstreamSuggestions>("/workstream/suggestions/stream", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("WorkstreamSuggestionsStream", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// /workstream/suggestions/stream [WS] Provides a WebSocket connection that emits changes to your workstream suggestions.
        /// </summary>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of WorkstreamSuggestions</returns>
        public async System.Threading.Tasks.Task<WorkstreamSuggestions> WorkstreamSuggestionsStreamAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {
            Pieces.Os.Core.Client.ApiResponse<WorkstreamSuggestions> localVarResponse = await WorkstreamSuggestionsStreamWithHttpInfoAsync(operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// /workstream/suggestions/stream [WS] Provides a WebSocket connection that emits changes to your workstream suggestions.
        /// </summary>
        /// <exception cref="Pieces.Os.Core.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (WorkstreamSuggestions)</returns>
        public async System.Threading.Tasks.Task<Pieces.Os.Core.Client.ApiResponse<WorkstreamSuggestions>> WorkstreamSuggestionsStreamWithHttpInfoAsync(int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
        {

            Pieces.Os.Core.Client.RequestOptions localVarRequestOptions = new Pieces.Os.Core.Client.RequestOptions();

            string[] _contentTypes = new string[] {
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json",
                "text/plain"
            };

            var localVarContentType = Pieces.Os.Core.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = Pieces.Os.Core.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }


            localVarRequestOptions.Operation = "WorkstreamApi.WorkstreamSuggestionsStream";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (application) required
            if (!string.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("X-Application-ID")))
            {
                localVarRequestOptions.HeaderParameters.Add("X-Application-ID", this.Configuration.GetApiKeyWithPrefix("X-Application-ID"));
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.GetAsync<WorkstreamSuggestions>("/workstream/suggestions/stream", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("WorkstreamSuggestionsStream", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
