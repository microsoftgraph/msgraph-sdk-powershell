#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("POST", "/security/microsoft.graph.security.runHuntingQuery")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgSecurityRunHuntingQuery", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.HuntingQueryResults))]
    public class InvokeMgSecurityRunHuntingQueryCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? Query { get; set; }

        [Parameter(Mandatory = false)]
        public string? Timespan { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Security.Client.Security.MicrosoftGraphSecurityRunHuntingQuery.RunHuntingQueryPostRequestBody();

    if (this.IsParameterBound(nameof(Query)))
        body.Query = Query;

    if (this.IsParameterBound(nameof(Timespan)))
        body.Timespan = Timespan;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.HuntingQueryResults? result;
            try
            {
                result = client.Security.MicrosoftGraphSecurityRunHuntingQuery.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
