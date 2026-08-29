#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Reports.Client;
using Microsoft.Graph.PowerShell.Reports.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Reports
{
    [GraphRoute("POST", "/auditLogs/signIns/confirmCompromised")]
    [Cmdlet(VerbsLifecycle.Confirm, "MgAuditLogSignInCompromised", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class ConfirmMgAuditLogSignInCompromisedCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string[]? RequestIds { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Confirm"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Reports.Client.AuditLogs.SignIns.ConfirmCompromised.ConfirmCompromisedPostRequestBody();

    if (this.IsParameterBound(nameof(RequestIds)))
        body.RequestIds = RequestIds!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.AuditLogs.SignIns.ConfirmCompromised.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

        }
    }
}
