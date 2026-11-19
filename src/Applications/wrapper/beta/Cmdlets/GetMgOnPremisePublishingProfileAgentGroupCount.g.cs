#nullable enable

using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using Microsoft.Graph.Wrapper.Runtime;

namespace Microsoft.Graph.PowerShell.Applications
{
    [GraphRoute("GET", "/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/agentGroups/$count", ParameterSetName = "RootScalar")]
    [GraphRoute("GET", "/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/agents/{onPremisesAgent-id}/agentGroups/$count", ParameterSetName = "AgentScalar")]
    [Cmdlet(VerbsCommon.Get, "MgOnPremisePublishingProfileAgentGroupCount", DefaultParameterSetName = "RootScalar")]
    [OutputType(typeof(int), ParameterSetName = new[] { "RootScalar" })]
    [OutputType(typeof(int), ParameterSetName = new[] { "AgentScalar" })]
    public class GetMgOnPremisePublishingProfileAgentGroupCountCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, ParameterSetName = "RootScalar", Position = 0)]
        [Parameter(Mandatory = true, ParameterSetName = "AgentScalar", Position = 0)]
        public string OnPremisesPublishingProfileId { get; set; } = string.Empty;

        [Parameter(Mandatory = false, ParameterSetName = "RootScalar")]
        [Parameter(Mandatory = false, ParameterSetName = "AgentScalar")]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootScalar")]
        [Parameter(Mandatory = false, ParameterSetName = "AgentScalar")]
        public string? Search { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = "AgentScalar", Position = 1)]
        public string OnPremisesAgentId { get; set; } = string.Empty;

        protected override void ProcessRecord()
        {
            var internalCmdletName = ParameterSetName switch
            {
                "RootScalar" => "Get-MgOnPremisePublishingProfileAgentGroupCount_Route0",
                "AgentScalar" => "Get-MgOnPremisePublishingProfileAgentGroupCount_Route1",
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
