#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Teams.Client;
using Microsoft.Graph.PowerShell.Teams.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Teams
{
    [GraphRoute("POST", "/groups/{group-id}/team/primaryChannel/planner/plans/{plannerPlan-id}/moveToContainer")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgGroupTeamPrimaryChannelPlannerPlanMoveToContainer", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerPlan))]
    public class InvokeMgGroupTeamPrimaryChannelPlannerPlanMoveToContainerCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PlannerPlanId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerPlanContainer? Container { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PlannerPlanId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Teams.Client.Groups.Item.Team.PrimaryChannel.Planner.Plans.Item.MoveToContainer.MoveToContainerPostRequestBody();

    if (this.IsParameterBound(nameof(Container)))
        body.Container = Container;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerPlan? result;
            try
            {
                result = client.Groups[GroupId].Team.PrimaryChannel.Planner.Plans[PlannerPlanId].MoveToContainer.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PlannerPlanId);
                return;
            }

            WriteObject(result);
        }
    }
}
