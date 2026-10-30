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
    [GraphRoute("POST", "/identityGovernance/roleManagementAlerts/alerts/refresh")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgIdentityGovernanceRoleManagementAlertRefreshByScope", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgIdentityGovernanceRoleManagementAlertRefreshByScopeCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? ScopeType { get; set; }

        [Parameter(Mandatory = false)]
        public string? ScopeId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.Governance.Client.IdentityGovernance.RoleManagementAlerts.Alerts.Refresh.RefreshPostRequestBody();

    if (this.IsParameterBound(nameof(ScopeType)))
        body.ScopeType = ScopeType;

    if (this.IsParameterBound(nameof(ScopeId)))
        body.ScopeId = ScopeId;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.IdentityGovernance.RoleManagementAlerts.Alerts.Refresh.PostAsync(body, requestConfiguration =>
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
