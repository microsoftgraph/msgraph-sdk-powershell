// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------
namespace Microsoft.Graph.PowerShell.Authentication.Cmdlets
{

    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Management.Automation;
    using Newtonsoft.Json;
    using Microsoft.Graph.PowerShell.Authentication.Helpers;
    
    [Cmdlet(VerbsLifecycle.Invoke, "GraphRequest", DefaultParameterSetName = Constants.UserParameterSet)]
    [OutputType(typeof(IAuthContext))]
    public class InvokeGraphRequest : PSCmdlet
    {
        [Parameter(ParameterSetName = Constants.UserParameterSet, Position = 1)]
        public object Body { get; set; }

        [Parameter(ParameterSetName = Constants.UserParameterSet, Position = 2)]
        public HttpMethod Method { get; set; }

        [Parameter(ParameterSetName = Constants.UserParameterSet, Position = 3)]
        public Uri Uri { get; set; }

        protected override void BeginProcessing()
        {
            base.BeginProcessing();
        }
        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            IAuthContext authConfig = GraphSession.Instance.AuthContext;
            HttpClient client = HttpHelpers.GetGraphHttpClient(authConfig);
            var requestMessage = new HttpRequestMessage(this.Method, this.Uri)
            {
                Content = new global::System.Net.Http.StringContent(
                    null != Body ? JsonConvert.SerializeObject(Body) : @"{}", global::System.Text.Encoding.UTF8)
            };
            requestMessage.Content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
            var responseMessage = client.SendAsync(requestMessage, HttpCompletionOption.ResponseContentRead).GetAwaiter().GetResult();
            var responseString = responseMessage.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            WriteObject(responseMessage);
        }

        protected override void EndProcessing()
        {
            base.EndProcessing();
        }

        protected override void StopProcessing()
        {
            base.StopProcessing();
        }
    }
}
