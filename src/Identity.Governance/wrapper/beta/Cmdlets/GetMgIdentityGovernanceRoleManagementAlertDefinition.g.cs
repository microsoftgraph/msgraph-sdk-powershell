#nullable enable

using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using Microsoft.Graph.Wrapper.Runtime;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("GET", "/identityGovernance/roleManagementAlerts/alertDefinitions", ParameterSetName = "DefinitionList")]
    [GraphRoute("GET", "/identityGovernance/roleManagementAlerts/alertDefinitions/{unifiedRoleManagementAlertDefinition-id}", ParameterSetName = "DefinitionGet")]
    [GraphRoute("GET", "/identityGovernance/roleManagementAlerts/alerts/{unifiedRoleManagementAlert-id}/alertDefinition", ParameterSetName = "AlertGet")]
    [Cmdlet(VerbsCommon.Get, "MgIdentityGovernanceRoleManagementAlertDefinition", DefaultParameterSetName = "DefinitionList")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRoleManagementAlertDefinition), ParameterSetName = new[] { "DefinitionList" })]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRoleManagementAlertDefinition), ParameterSetName = new[] { "DefinitionGet" })]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRoleManagementAlertDefinition), ParameterSetName = new[] { "AlertGet" })]
    public class GetMgIdentityGovernanceRoleManagementAlertDefinitionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = false, ParameterSetName = "DefinitionList")]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "DefinitionList")]
        [Parameter(Mandatory = false, ParameterSetName = "DefinitionGet")]
        [Parameter(Mandatory = false, ParameterSetName = "AlertGet")]
        [Alias("Select")]
        public string[]? Property { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "DefinitionList")]
        [Parameter(Mandatory = false, ParameterSetName = "DefinitionGet")]
        [Parameter(Mandatory = false, ParameterSetName = "AlertGet")]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "DefinitionList")]
        [Alias("OrderBy")]
        public string[]? Sort { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "DefinitionList")]
        public string? Search { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "DefinitionList")]
        public int Top { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "DefinitionList")]
        public int Skip { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "DefinitionList")]
        public SwitchParameter Count { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "DefinitionList")]
        public SwitchParameter All { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = "DefinitionGet", Position = 0)]
        public string UnifiedRoleManagementAlertDefinitionId { get; set; } = string.Empty;

        [Parameter(Mandatory = true, ParameterSetName = "AlertGet", Position = 0)]
        public string UnifiedRoleManagementAlertId { get; set; } = string.Empty;

        protected override void ProcessRecord()
        {
            var internalCmdletName = ParameterSetName switch
            {
                "DefinitionList" => "Get-MgIdentityGovernanceRoleManagementAlertDefinition_Route0",
                "DefinitionGet" => "Get-MgIdentityGovernanceRoleManagementAlertDefinition_Route1",
                "AlertGet" => "Get-MgIdentityGovernanceRoleManagementAlertDefinition_Route2",
                _ => throw new InvalidOperationException("Unsupported operation parameter set."),
            };
            try
            {
                InvokeCommand.InvokeScript(
                    "param($BoundParameters, $CmdletName) & $CmdletName @BoundParameters",
                    false,
                    global::System.Management.Automation.Runspaces.PipelineResultTypes.Output | global::System.Management.Automation.Runspaces.PipelineResultTypes.Error,
                    null,
                    MyInvocation.BoundParameters, internalCmdletName);
            }
            catch (RuntimeException rex) when (rex is not PipelineStoppedException && rex.ErrorRecord is not null)
            {
                ThrowTerminatingError(rex.ErrorRecord);
                return;
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }
        }
    }
}
