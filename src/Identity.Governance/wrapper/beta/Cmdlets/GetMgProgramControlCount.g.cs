#nullable enable

using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using Microsoft.Graph.Wrapper.Runtime;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("GET", "/programControls/$count", ParameterSetName = "StandaloneScalar")]
    [GraphRoute("GET", "/programs/{program-id}/controls/$count", ParameterSetName = "ProgramScalar")]
    [Cmdlet(VerbsCommon.Get, "MgProgramControlCount", DefaultParameterSetName = "StandaloneScalar")]
    [OutputType(typeof(int), ParameterSetName = new[] { "StandaloneScalar" })]
    [OutputType(typeof(int), ParameterSetName = new[] { "ProgramScalar" })]
    public class GetMgProgramControlCountCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = false, ParameterSetName = "StandaloneScalar")]
        [Parameter(Mandatory = false, ParameterSetName = "ProgramScalar")]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "StandaloneScalar")]
        [Parameter(Mandatory = false, ParameterSetName = "ProgramScalar")]
        public string? Search { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = "ProgramScalar", Position = 0)]
        public string ProgramId { get; set; } = string.Empty;

        protected override void ProcessRecord()
        {
            var internalCmdletName = ParameterSetName switch
            {
                "StandaloneScalar" => "Get-MgProgramControlCount_Route0",
                "ProgramScalar" => "Get-MgProgramControlCount_Route1",
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
