#nullable enable

using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using Microsoft.Graph.Wrapper.Runtime;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("PATCH", "/programControls/{programControl-id}/program", ParameterSetName = "StandaloneUpdate")]
    [GraphRoute("PATCH", "/programs/{program-id}/controls/{programControl-id}/program", ParameterSetName = "ProgramUpdate")]
    [Cmdlet(VerbsData.Update, "MgProgramControlProgram", DefaultParameterSetName = "StandaloneUpdate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.Program), ParameterSetName = new[] { "StandaloneUpdate" })]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.Program), ParameterSetName = new[] { "ProgramUpdate" })]
    public class UpdateMgProgramControlProgramCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, ParameterSetName = "StandaloneUpdate", Position = 0)]
        [Parameter(Mandatory = true, ParameterSetName = "ProgramUpdate", Position = 1)]
        public string ProgramControlId { get; set; } = string.Empty;

        [Parameter(Mandatory = false, ParameterSetName = "StandaloneUpdate")]
        [Parameter(Mandatory = false, ParameterSetName = "ProgramUpdate")]
        public string? Description { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "StandaloneUpdate")]
        [Parameter(Mandatory = false, ParameterSetName = "ProgramUpdate")]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = "ProgramUpdate", Position = 0)]
        public string ProgramId { get; set; } = string.Empty;

        protected override void ProcessRecord()
        {
            var internalCmdletName = ParameterSetName switch
            {
                "StandaloneUpdate" => "Update-MgProgramControlProgram_Route0",
                "ProgramUpdate" => "Update-MgProgramControlProgram_Route1",
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
