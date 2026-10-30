#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Governance.Client;
using Microsoft.Graph.PowerShell.Identity.Governance.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("POST", "/privilegedAccess/{privilegedAccess-id}/resources/register")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgPrivilegedAccessResourceRegister", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgPrivilegedAccessResourceRegisterCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PrivilegedAccessId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ExternalId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PrivilegedAccessId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.Governance.Client.PrivilegedAccess.Item.Resources.Register.RegisterPostRequestBody();

    if (this.IsParameterBound(nameof(ExternalId)))
        body.ExternalId = ExternalId;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.PrivilegedAccess[PrivilegedAccessId].Resources.Register.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PrivilegedAccessId);
                return;
            }

        }
    }
}
