#nullable enable

using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using Microsoft.Graph.Wrapper.Runtime;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("GET", "/privilegedRoleAssignments", ParameterSetName = "StandaloneList")]
    [GraphRoute("GET", "/privilegedRoleAssignments/{privilegedRoleAssignment-id}", ParameterSetName = "StandaloneGet")]
    [GraphRoute("GET", "/privilegedRoles/{privilegedRole-id}/assignments", ParameterSetName = "RoleList")]
    [GraphRoute("GET", "/privilegedRoles/{privilegedRole-id}/assignments/{privilegedRoleAssignment-id}", ParameterSetName = "RoleGet")]
    [Cmdlet(VerbsCommon.Get, "MgPrivilegedRoleRoleAssignment", DefaultParameterSetName = "StandaloneList")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PrivilegedRoleAssignment), ParameterSetName = new[] { "StandaloneList" })]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PrivilegedRoleAssignment), ParameterSetName = new[] { "StandaloneGet" })]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PrivilegedRoleAssignment), ParameterSetName = new[] { "RoleList" })]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PrivilegedRoleAssignment), ParameterSetName = new[] { "RoleGet" })]
    public class GetMgPrivilegedRoleRoleAssignmentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = false, ParameterSetName = "StandaloneList")]
        [Parameter(Mandatory = false, ParameterSetName = "RoleList")]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "StandaloneList")]
        [Parameter(Mandatory = false, ParameterSetName = "StandaloneGet")]
        [Parameter(Mandatory = false, ParameterSetName = "RoleList")]
        [Parameter(Mandatory = false, ParameterSetName = "RoleGet")]
        [Alias("Select")]
        public string[]? Property { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "StandaloneList")]
        [Parameter(Mandatory = false, ParameterSetName = "StandaloneGet")]
        [Parameter(Mandatory = false, ParameterSetName = "RoleList")]
        [Parameter(Mandatory = false, ParameterSetName = "RoleGet")]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "StandaloneList")]
        [Parameter(Mandatory = false, ParameterSetName = "RoleList")]
        [Alias("OrderBy")]
        public string[]? Sort { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "StandaloneList")]
        [Parameter(Mandatory = false, ParameterSetName = "RoleList")]
        public string? Search { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "StandaloneList")]
        [Parameter(Mandatory = false, ParameterSetName = "RoleList")]
        public int Top { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "StandaloneList")]
        [Parameter(Mandatory = false, ParameterSetName = "RoleList")]
        public int Skip { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "StandaloneList")]
        [Parameter(Mandatory = false, ParameterSetName = "RoleList")]
        public SwitchParameter Count { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "StandaloneList")]
        [Parameter(Mandatory = false, ParameterSetName = "RoleList")]
        public SwitchParameter All { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = "StandaloneGet", Position = 0)]
        [Parameter(Mandatory = true, ParameterSetName = "RoleGet", Position = 1)]
        public string PrivilegedRoleAssignmentId { get; set; } = string.Empty;

        [Parameter(Mandatory = true, ParameterSetName = "RoleList", Position = 0)]
        [Parameter(Mandatory = true, ParameterSetName = "RoleGet", Position = 0)]
        public string PrivilegedRoleId { get; set; } = string.Empty;

        protected override void ProcessRecord()
        {
            var internalCmdletName = ParameterSetName switch
            {
                "StandaloneList" => "Get-MgPrivilegedRoleRoleAssignment_Route0",
                "StandaloneGet" => "Get-MgPrivilegedRoleRoleAssignment_Route1",
                "RoleList" => "Get-MgPrivilegedRoleRoleAssignment_Route2",
                "RoleGet" => "Get-MgPrivilegedRoleRoleAssignment_Route3",
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
