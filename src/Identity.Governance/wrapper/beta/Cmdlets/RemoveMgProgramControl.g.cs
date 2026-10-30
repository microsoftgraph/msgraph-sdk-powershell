#nullable enable

using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using Microsoft.Graph.Wrapper.Runtime;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("DELETE", "/programControls/{programControl-id}", ParameterSetName = "StandaloneRemove")]
    [GraphRoute("DELETE", "/programs/{program-id}/controls/{programControl-id}", ParameterSetName = "ProgramRemove")]
    [Cmdlet(VerbsCommon.Remove, "MgProgramControl", DefaultParameterSetName = "StandaloneRemove", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]

    public class RemoveMgProgramControlCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, ParameterSetName = "StandaloneRemove", Position = 0)]
        [Parameter(Mandatory = true, ParameterSetName = "ProgramRemove", Position = 1)]
        public string ProgramControlId { get; set; } = string.Empty;

        [Parameter(Mandatory = false, ParameterSetName = "StandaloneRemove")]
        [Parameter(Mandatory = false, ParameterSetName = "ProgramRemove")]
        public string? IfMatch { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = "ProgramRemove", Position = 0)]
        public string ProgramId { get; set; } = string.Empty;

        protected override void ProcessRecord()
        {
            var internalCmdletName = ParameterSetName switch
            {
                "StandaloneRemove" => "Remove-MgProgramControl_Route0",
                "ProgramRemove" => "Remove-MgProgramControl_Route1",
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
