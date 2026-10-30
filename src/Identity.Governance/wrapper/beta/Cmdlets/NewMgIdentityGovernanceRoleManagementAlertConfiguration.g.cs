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
    [GraphRoute("POST", "/identityGovernance/roleManagementAlerts/alertConfigurations")]
    [Cmdlet(VerbsCommon.New, "MgIdentityGovernanceRoleManagementAlertConfiguration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRoleManagementAlertConfiguration))]
    public class NewMgIdentityGovernanceRoleManagementAlertConfigurationCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? AlertDefinitionId { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public string? ScopeId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ScopeType { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRoleManagementAlertConfiguration();

    if (this.IsParameterBound(nameof(AlertDefinitionId)))
        body.AlertDefinitionId = AlertDefinitionId;

    if (this.IsParameterBound(nameof(IsEnabled)))
        body.IsEnabled = IsEnabled;

    if (this.IsParameterBound(nameof(ScopeId)))
        body.ScopeId = ScopeId;

    if (this.IsParameterBound(nameof(ScopeType)))
        body.ScopeType = ScopeType;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRoleManagementAlertConfiguration? result;
            try
            {
                result = client.IdentityGovernance.RoleManagementAlerts.AlertConfigurations.PostAsync(body, requestConfiguration =>
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
