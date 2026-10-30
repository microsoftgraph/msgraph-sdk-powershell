#nullable enable

using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using Microsoft.Graph.Wrapper.Runtime;

namespace Microsoft.Graph.PowerShell.Applications
{
    [GraphRoute("GET", "/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/agentGroups", ParameterSetName = "RootList")]
    [GraphRoute("GET", "/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/agentGroups/{onPremisesAgentGroup-id}", ParameterSetName = "RootGet")]
    [GraphRoute("GET", "/onPremisesPublishingProfiles/{onPremisesPublishingProfile-id}/agents/{onPremisesAgent-id}/agentGroups", ParameterSetName = "AgentList")]
    [Cmdlet(VerbsCommon.Get, "MgOnPremisePublishingProfileAgentGroup", DefaultParameterSetName = "RootList")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.OnPremisesAgentGroup), ParameterSetName = new[] { "RootList" })]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.OnPremisesAgentGroup), ParameterSetName = new[] { "RootGet" })]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.OnPremisesAgentGroup), ParameterSetName = new[] { "AgentList" })]
    public class GetMgOnPremisePublishingProfileAgentGroupCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, ParameterSetName = "RootList", Position = 0)]
        [Parameter(Mandatory = true, ParameterSetName = "RootGet", Position = 0)]
        [Parameter(Mandatory = true, ParameterSetName = "AgentList", Position = 0)]
        public string OnPremisesPublishingProfileId { get; set; } = string.Empty;

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "AgentList")]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "RootGet")]
        [Parameter(Mandatory = false, ParameterSetName = "AgentList")]
        [Alias("Select")]
        public string[]? Property { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "RootGet")]
        [Parameter(Mandatory = false, ParameterSetName = "AgentList")]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "AgentList")]
        [Alias("OrderBy")]
        public string[]? Sort { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "AgentList")]
        public string? Search { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "AgentList")]
        public int Top { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "AgentList")]
        public int Skip { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "AgentList")]
        public SwitchParameter Count { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = "RootList")]
        [Parameter(Mandatory = false, ParameterSetName = "AgentList")]
        public SwitchParameter All { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = "RootGet", Position = 1)]
        public string OnPremisesAgentGroupId { get; set; } = string.Empty;

        [Parameter(Mandatory = true, ParameterSetName = "AgentList", Position = 1)]
        public string OnPremisesAgentId { get; set; } = string.Empty;

        protected override void ProcessRecord()
        {
            var internalCmdletName = ParameterSetName switch
            {
                "RootList" => "Get-MgOnPremisePublishingProfileAgentGroup_Route0",
                "RootGet" => "Get-MgOnPremisePublishingProfileAgentGroup_Route1",
                "AgentList" => "Get-MgOnPremisePublishingProfileAgentGroup_Route2",
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
