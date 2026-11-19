#nullable enable

using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using Microsoft.Graph.Wrapper.Runtime;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("GET", "/identityGovernance/roleManagementAlerts/alertConfigurations", ParameterSetName = "ConfigurationList")]
    [GraphRoute("GET", "/identityGovernance/roleManagementAlerts/alertConfigurations/{unifiedRoleManagementAlertConfiguration-id}", ParameterSetName = "ConfigurationGet")]
    [GraphRoute("GET", "/identityGovernance/roleManagementAlerts/alerts/{unifiedRoleManagementAlert-id}/alertConfiguration", ParameterSetName = "AlertGet")]
    [Cmdlet(VerbsCommon.Get, "MgIdentityGovernanceRoleManagementAlertConfiguration", DefaultParameterSetName = "ConfigurationList")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRoleManagementAlertConfiguration), ParameterSetName = new[] { "ConfigurationList" })]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRoleManagementAlertConfiguration), ParameterSetName = new[] { "ConfigurationGet" })]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRoleManagementAlertConfiguration), ParameterSetName = new[] { "AlertGet" })]
    public class GetMgIdentityGovernanceRoleManagementAlertConfigurationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = false, ParameterSetName = "ConfigurationList")]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "ConfigurationList")]
        [Parameter(Mandatory = false, ParameterSetName = "ConfigurationGet")]
        [Parameter(Mandatory = false, ParameterSetName = "AlertGet")]
        [Alias("Select")]
        public string[]? Property { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "ConfigurationList")]
        [Parameter(Mandatory = false, ParameterSetName = "ConfigurationGet")]
        [Parameter(Mandatory = false, ParameterSetName = "AlertGet")]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "ConfigurationList")]
        [Alias("OrderBy")]
        public string[]? Sort { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "ConfigurationList")]
        public string? Search { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "ConfigurationList")]
        public int Top { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "ConfigurationList")]
        public int Skip { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "ConfigurationList")]
        public SwitchParameter Count { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "ConfigurationList")]
        public SwitchParameter All { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = "ConfigurationGet", Position = 0)]
        public string UnifiedRoleManagementAlertConfigurationId { get; set; } = string.Empty;

        [Parameter(Mandatory = true, ParameterSetName = "AlertGet", Position = 0)]
        public string UnifiedRoleManagementAlertId { get; set; } = string.Empty;

        protected override void ProcessRecord()
        {
            var internalCmdletName = ParameterSetName switch
            {
                "ConfigurationList" => "Get-MgIdentityGovernanceRoleManagementAlertConfiguration_Route0",
                "ConfigurationGet" => "Get-MgIdentityGovernanceRoleManagementAlertConfiguration_Route1",
                "AlertGet" => "Get-MgIdentityGovernanceRoleManagementAlertConfiguration_Route2",
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
