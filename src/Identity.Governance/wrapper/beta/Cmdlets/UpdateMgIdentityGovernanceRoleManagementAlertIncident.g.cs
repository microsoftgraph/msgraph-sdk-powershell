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
    [GraphRoute("PATCH", "/identityGovernance/roleManagementAlerts/alerts/{unifiedRoleManagementAlert-id}/alertIncidents/{unifiedRoleManagementAlertIncident-id}")]
    [Cmdlet(VerbsData.Update, "MgIdentityGovernanceRoleManagementAlertIncident", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRoleManagementAlertIncident))]
    public class UpdateMgIdentityGovernanceRoleManagementAlertIncidentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UnifiedRoleManagementAlertId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string UnifiedRoleManagementAlertIncidentId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UnifiedRoleManagementAlertIncidentId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRoleManagementAlertIncident();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRoleManagementAlertIncident? result;
            try
            {
                result = client.IdentityGovernance.RoleManagementAlerts.Alerts[UnifiedRoleManagementAlertId].AlertIncidents[UnifiedRoleManagementAlertIncidentId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UnifiedRoleManagementAlertIncidentId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityGovernance.RoleManagementAlerts.Alerts[UnifiedRoleManagementAlertId].AlertIncidents[UnifiedRoleManagementAlertIncidentId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, UnifiedRoleManagementAlertIncidentId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
