#nullable enable

using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using Microsoft.Graph.Wrapper.Runtime;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("GET", "/privilegedRoleAssignments/$count", ParameterSetName = "StandaloneScalar")]
    [GraphRoute("GET", "/privilegedRoles/{privilegedRole-id}/assignments/$count", ParameterSetName = "RoleScalar")]
    [Cmdlet(VerbsCommon.Get, "MgPrivilegedRoleAssignmentCount", DefaultParameterSetName = "StandaloneScalar")]
    [OutputType(typeof(int), ParameterSetName = new[] { "StandaloneScalar" })]
    [OutputType(typeof(int), ParameterSetName = new[] { "RoleScalar" })]
    public class GetMgPrivilegedRoleAssignmentCountCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = false, ParameterSetName = "StandaloneScalar")]
        [Parameter(Mandatory = false, ParameterSetName = "RoleScalar")]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "StandaloneScalar")]
        [Parameter(Mandatory = false, ParameterSetName = "RoleScalar")]
        public string? Search { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = "RoleScalar", Position = 0)]
        public string PrivilegedRoleId { get; set; } = string.Empty;

        protected override void ProcessRecord()
        {
            var internalCmdletName = ParameterSetName switch
            {
                "StandaloneScalar" => "Get-MgPrivilegedRoleAssignmentCount_Route0",
                "RoleScalar" => "Get-MgPrivilegedRoleAssignmentCount_Route1",
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
