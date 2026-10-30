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
    [GraphRoute("PATCH", "/identityGovernance/roleManagementAlerts/alerts/{unifiedRoleManagementAlert-id}")]
    [Cmdlet(VerbsData.Update, "MgIdentityGovernanceRoleManagementAlert", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRoleManagementAlert))]
    public class UpdateMgIdentityGovernanceRoleManagementAlertCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UnifiedRoleManagementAlertId { get; set; } = string.Empty;

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
            if (!ShouldProcess(UnifiedRoleManagementAlertId, "Update"))
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
                result = client.IdentityGovernance.RoleManagementAlerts.Alerts[UnifiedRoleManagementAlertId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UnifiedRoleManagementAlertId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityGovernance.RoleManagementAlerts.Alerts[UnifiedRoleManagementAlertId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, UnifiedRoleManagementAlertId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
