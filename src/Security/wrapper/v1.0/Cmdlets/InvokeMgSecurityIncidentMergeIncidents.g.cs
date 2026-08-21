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
    [GraphRoute("POST", "/security/incidents/microsoft.graph.security.mergeIncidents")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgSecurityIncidentMergeIncidents", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.MergeResponse))]
    public class InvokeMgSecurityIncidentMergeIncidentsCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string[]? IncidentIds { get; set; }

        [Parameter(Mandatory = false)]
        public string? IncidentComment { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.CorrelationReason? MergeReasons { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Security.Client.Security.Incidents.MicrosoftGraphSecurityMergeIncidents.MergeIncidentsPostRequestBody();

    if (this.IsParameterBound(nameof(IncidentIds)))
        body.IncidentIds = IncidentIds!.ToList();

    if (this.IsParameterBound(nameof(IncidentComment)))
        body.IncidentComment = IncidentComment;
    if (this.IsParameterBound(nameof(MergeReasons)))
        body.MergeReasons = MergeReasons;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.MergeResponse? result;
            try
            {
                result = client.Security.Incidents.MicrosoftGraphSecurityMergeIncidents.PostAsync(body, requestConfiguration =>
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
