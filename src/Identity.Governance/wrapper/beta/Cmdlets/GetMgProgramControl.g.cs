#nullable enable

using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using Microsoft.Graph.Wrapper.Runtime;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("GET", "/programControls", ParameterSetName = "StandaloneList")]
    [GraphRoute("GET", "/programControls/{programControl-id}", ParameterSetName = "StandaloneGet")]
    [GraphRoute("GET", "/programs/{program-id}/controls", ParameterSetName = "ProgramList")]
    [GraphRoute("GET", "/programs/{program-id}/controls/{programControl-id}", ParameterSetName = "ProgramGet")]
    [Cmdlet(VerbsCommon.Get, "MgProgramControl", DefaultParameterSetName = "StandaloneList")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.ProgramControl), ParameterSetName = new[] { "StandaloneList" })]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.ProgramControl), ParameterSetName = new[] { "StandaloneGet" })]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.ProgramControl), ParameterSetName = new[] { "ProgramList" })]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.ProgramControl), ParameterSetName = new[] { "ProgramGet" })]
    public class GetMgProgramControlCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = false, ParameterSetName = "StandaloneList")]
        [Parameter(Mandatory = false, ParameterSetName = "ProgramList")]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "StandaloneList")]
        [Parameter(Mandatory = false, ParameterSetName = "StandaloneGet")]
        [Parameter(Mandatory = false, ParameterSetName = "ProgramList")]
        [Parameter(Mandatory = false, ParameterSetName = "ProgramGet")]
        [Alias("Select")]
        public string[]? Property { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "StandaloneList")]
        [Parameter(Mandatory = false, ParameterSetName = "StandaloneGet")]
        [Parameter(Mandatory = false, ParameterSetName = "ProgramList")]
        [Parameter(Mandatory = false, ParameterSetName = "ProgramGet")]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "StandaloneList")]
        [Parameter(Mandatory = false, ParameterSetName = "ProgramList")]
        [Alias("OrderBy")]
        public string[]? Sort { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "StandaloneList")]
        [Parameter(Mandatory = false, ParameterSetName = "ProgramList")]
        public string? Search { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "StandaloneList")]
        [Parameter(Mandatory = false, ParameterSetName = "ProgramList")]
        public int Top { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "StandaloneList")]
        [Parameter(Mandatory = false, ParameterSetName = "ProgramList")]
        public int Skip { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "StandaloneList")]
        [Parameter(Mandatory = false, ParameterSetName = "ProgramList")]
        public SwitchParameter Count { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "StandaloneList")]
        [Parameter(Mandatory = false, ParameterSetName = "ProgramList")]
        public SwitchParameter All { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = "StandaloneGet", Position = 0)]
        [Parameter(Mandatory = true, ParameterSetName = "ProgramGet", Position = 1)]
        public string ProgramControlId { get; set; } = string.Empty;

        [Parameter(Mandatory = true, ParameterSetName = "ProgramList", Position = 0)]
        [Parameter(Mandatory = true, ParameterSetName = "ProgramGet", Position = 0)]
        public string ProgramId { get; set; } = string.Empty;

        protected override void ProcessRecord()
        {
            var internalCmdletName = ParameterSetName switch
            {
                "StandaloneList" => "Get-MgProgramControl_Route0",
                "StandaloneGet" => "Get-MgProgramControl_Route1",
                "ProgramList" => "Get-MgProgramControl_Route2",
                "ProgramGet" => "Get-MgProgramControl_Route3",
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
