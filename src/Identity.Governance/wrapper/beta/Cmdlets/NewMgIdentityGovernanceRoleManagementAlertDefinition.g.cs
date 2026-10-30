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
    [GraphRoute("POST", "/identityGovernance/roleManagementAlerts/alertDefinitions")]
    [Cmdlet(VerbsCommon.New, "MgIdentityGovernanceRoleManagementAlertDefinition", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRoleManagementAlertDefinition))]
    public class NewMgIdentityGovernanceRoleManagementAlertDefinitionCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? HowToPrevent { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsConfigurable { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsRemediatable { get; set; }

        [Parameter(Mandatory = false)]
        public string? MitigationSteps { get; set; }

        [Parameter(Mandatory = false)]
        public string? ScopeId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ScopeType { get; set; }

        [Parameter(Mandatory = false)]
        public string? SecurityImpact { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AlertSeverity? SeverityLevel { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRoleManagementAlertDefinition();

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(HowToPrevent)))
        body.HowToPrevent = HowToPrevent;

    if (this.IsParameterBound(nameof(IsConfigurable)))
        body.IsConfigurable = IsConfigurable;

    if (this.IsParameterBound(nameof(IsRemediatable)))
        body.IsRemediatable = IsRemediatable;

    if (this.IsParameterBound(nameof(MitigationSteps)))
        body.MitigationSteps = MitigationSteps;

    if (this.IsParameterBound(nameof(ScopeId)))
        body.ScopeId = ScopeId;

    if (this.IsParameterBound(nameof(ScopeType)))
        body.ScopeType = ScopeType;

    if (this.IsParameterBound(nameof(SecurityImpact)))
        body.SecurityImpact = SecurityImpact;

    if (this.IsParameterBound(nameof(SeverityLevel)))
        body.SeverityLevel = SeverityLevel;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRoleManagementAlertDefinition? result;
            try
            {
                result = client.IdentityGovernance.RoleManagementAlerts.AlertDefinitions.PostAsync(body, requestConfiguration =>
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
