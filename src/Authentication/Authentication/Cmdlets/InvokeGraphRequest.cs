// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{
    using System;
    using System.Text;
    using System.Threading;
    using System.Net.Http;
    using System.Collections;
    using System.Net.Http.Headers;
    using System.Collections.Generic;

    using System.Management.Automation;
    using System.Management.Automation.Language;
    using System.Management.Automation.Runspaces;

    using Newtonsoft.Json;
    using Microsoft.Graph.PowerShell.Authentication.Helpers;


    [Cmdlet(VerbsLifecycle.Invoke, "GraphRequest", DefaultParameterSetName = Constants.UserParameterSet)]
    [OutputType(typeof(Hashtable))]
    public class InvokeGraphRequest : PSCmdlet
    {
        /// <summary>
        /// Contains the values of HttpVerbs
        /// </summary>
        public enum HttpVerb
        {
            GET,
            POST,
            PUT,
            PATCH,
            DELETE
        }
        private readonly HttpClient _client;
        public InvokeGraphRequest()
        {
            this.Method = HttpVerb.GET;
            var authConfig = GraphSession.Instance.AuthContext;
            this._client = HttpHelpers.GetGraphHttpClient(authConfig);
        }

        /// <summary>
        /// Http Method
        /// </summary>
        [Parameter(ParameterSetName = Constants.UserParameterSet, Position = 1, Mandatory = true)]
        public HttpVerb Method { get; set; }

        /// <summary>
        /// Uri to call using the Graph HttpClient can be segments such as /beta/me
        /// or fully qualified url such as https://graph.microsoft.com/beta/me
        /// </summary>
        [Parameter(ParameterSetName = Constants.UserParameterSet, Position = 2, Mandatory = true)]
        public Uri Uri { get; set; }

        /// <summary>
        /// Optional Http Body
        /// </summary>
        [Parameter(ParameterSetName = Constants.UserParameterSet, Position = 3)]
        public object Body { get; set; }

        protected override void BeginProcessing()
        {
            ValidateParameters();
            base.BeginProcessing();
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            var authConfig = GraphSession.Instance.AuthContext;
            var client = HttpHelpers.GetGraphHttpClient(authConfig);
            try
            {
                var httpMethod = GetHttpMethod();
                var requestMessage = new HttpRequestMessage(httpMethod, this.Uri)
                {
                    Content = new StringContent(null != Body ? JsonConvert.SerializeObject(Body) : @"{}", Encoding.UTF8,
                        CoreConstants.MimeTypeNames.Application.Json)
                };
                var responseMessage = client.SendAsync(requestMessage).GetAwaiter().GetResult();
                var responseString = responseMessage.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                var result = JsonConvert.DeserializeObject<Hashtable>(responseString);
                if (responseMessage.IsSuccessStatusCode)
                {
                    WriteObject(result);
                }
                else
                {
                    WriteError(new ErrorRecord(new Exception(responseString), Guid.NewGuid().ToString(),
                        ErrorCategory.InvalidResult, null));
                }
            }
            catch (HttpRequestException httpRequestException)
            {
                WriteError(new ErrorRecord(httpRequestException, ErrorCategory.ConnectionError.ToString(),
                    ErrorCategory.InvalidResult, null));
                throw;
            }
            catch (Exception exception)
            {
                WriteError(new ErrorRecord(exception, ErrorCategory.ConnectionError.ToString(), ErrorCategory.InvalidOperation, null));
                throw;
            }
        }

        /// <summary>
        /// Maps from HttpVerb to System.Net.Http.HttpMethod
        /// </summary>
        /// <returns>System.Net.Http.HttpMethod</returns>
        private System.Net.Http.HttpMethod GetHttpMethod()
        {
            switch (Method)
            {
                case HttpVerb.GET:
                    return System.Net.Http.HttpMethod.Get;
                case HttpVerb.POST:
                    return System.Net.Http.HttpMethod.Post;
                case HttpVerb.PATCH:
                    // System.Net.Http.HttpMethod does not contain HttpMethod.Patch in netstandard2.0
                    // https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpmethod?view=netstandard-2.0
                    return new System.Net.Http.HttpMethod("PATCH");
                case HttpVerb.PUT:
                    return System.Net.Http.HttpMethod.Put;
                case HttpVerb.DELETE:
                    return System.Net.Http.HttpMethod.Delete;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();
        }

        protected override void StopProcessing()
        {
            base.StopProcessing();
        }

        private void ValidateParameters()
        {
            if (Uri == null)
            {
                ThrowTerminatingError(new ErrorRecord(new ArgumentNullException(nameof(Uri), $"Must specify {Uri}"), Guid.NewGuid().ToString(),
                    ErrorCategory.InvalidArgument, null));
            }

            if (Uri.IsAbsoluteUri && _client.BaseAddress.Host != Uri.Host)
            {
                ThrowTerminatingError(new ErrorRecord(new ArgumentNullException(nameof(Uri), $"Invalid Host {Uri.Host}"), Guid.NewGuid().ToString(),
                    ErrorCategory.InvalidArgument, null));
            }
        }
    }
}