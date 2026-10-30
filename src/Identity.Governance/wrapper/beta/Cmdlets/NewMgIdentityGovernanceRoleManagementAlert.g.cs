#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Governance.Client;
using Microsoft.Graph.PowerShell.Identity.Governance.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("POST", "/identityGovernance/roleManagementAlerts/alerts")]
    [Cmdlet(VerbsCommon.New, "MgIdentityGovernanceRoleManagementAlert", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRoleManagementAlert))]
    public class NewMgIdentityGovernanceRoleManagementAlertCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? AlertDefinitionId { get; set; }

        [Parameter(Mandatory = false)]
        public int? IncidentCount { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsActive { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastScannedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ScopeId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ScopeType { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRoleManagementAlert();

    if (this.IsParameterBound(nameof(AlertDefinitionId)))
        body.AlertDefinitionId = AlertDefinitionId;

    if (this.IsParameterBound(nameof(IncidentCount)))
        body.IncidentCount = IncidentCount;

    if (this.IsParameterBound(nameof(IsActive)))
        body.IsActive = IsActive;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(LastScannedDateTime)))
        body.LastScannedDateTime = LastScannedDateTime;

    if (this.IsParameterBound(nameof(ScopeId)))
        body.ScopeId = ScopeId;

    if (this.IsParameterBound(nameof(ScopeType)))
        body.ScopeType = ScopeType;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRoleManagementAlert? result;
            try
            {
                result = client.IdentityGovernance.RoleManagementAlerts.Alerts.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
