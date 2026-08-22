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
    [GraphRoute("POST", "/security/alerts_v2/microsoft.graph.security.moveAlerts")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgSecurityAlertV2MoveAlerts", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.MergeResponse))]
    public class InvokeMgSecurityAlertV2MoveAlertsCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string[]? AlertIds { get; set; }

        [Parameter(Mandatory = false)]
        public string? IncidentId { get; set; }

        [Parameter(Mandatory = false)]
        public string? AlertComment { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.CorrelationReason? NewCorrelationReasons { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Security.Client.Security.Alerts_v2.MicrosoftGraphSecurityMoveAlerts.MoveAlertsPostRequestBody();

    if (this.IsParameterBound(nameof(AlertIds)))
        body.AlertIds = AlertIds!.ToList();

    if (this.IsParameterBound(nameof(IncidentId)))
        body.IncidentId = IncidentId;

    if (this.IsParameterBound(nameof(AlertComment)))
        body.AlertComment = AlertComment;
    if (this.IsParameterBound(nameof(NewCorrelationReasons)))
        body.NewCorrelationReasons = NewCorrelationReasons;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.MergeResponse? result;
            try
            {
                result = client.Security.Alerts_v2.MicrosoftGraphSecurityMoveAlerts.PostAsync(body, requestConfiguration =>
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
