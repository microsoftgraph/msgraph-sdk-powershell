#nullable enable

using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using Microsoft.Graph.Wrapper.Runtime;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("GET", "/programControls/{programControl-id}/program", ParameterSetName = "StandaloneGet")]
    [GraphRoute("GET", "/programs/{program-id}/controls/{programControl-id}/program", ParameterSetName = "ProgramGet")]
    [Cmdlet(VerbsCommon.Get, "MgProgramControlProgram", DefaultParameterSetName = "StandaloneGet")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.Program), ParameterSetName = new[] { "StandaloneGet" })]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.Program), ParameterSetName = new[] { "ProgramGet" })]
    public class GetMgProgramControlProgramCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, ParameterSetName = "StandaloneGet", Position = 0)]
        [Parameter(Mandatory = true, ParameterSetName = "ProgramGet", Position = 1)]
        public string ProgramControlId { get; set; } = string.Empty;

        [Parameter(Mandatory = false, ParameterSetName = "StandaloneGet")]
        [Parameter(Mandatory = false, ParameterSetName = "ProgramGet")]
        [Alias("Select")]
        public string[]? Property { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "StandaloneGet")]
        [Parameter(Mandatory = false, ParameterSetName = "ProgramGet")]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = "ProgramGet", Position = 0)]
        public string ProgramId { get; set; } = string.Empty;

        protected override void ProcessRecord()
        {
            var internalCmdletName = ParameterSetName switch
            {
                "StandaloneGet" => "Get-MgProgramControlProgram_Route0",
                "ProgramGet" => "Get-MgProgramControlProgram_Route1",
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
