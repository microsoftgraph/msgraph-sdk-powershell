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
    [GraphRoute("POST", "/teamwork/deletedTeams/{deletedTeam-id}/channels/{channel-id}/planner/plans/{plannerPlan-id}/tasks/{plannerTask-id}/messages/{plannerTaskChatMessage-id}/setReaction")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgTeamworkDeletedTeamChannelPlannerPlanTaskMessageSetReaction", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgTeamworkDeletedTeamChannelPlannerPlanTaskMessageSetReactionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeletedTeamId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ChannelId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string PlannerPlanId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string PlannerTaskId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 4)]
        public string PlannerTaskChatMessageId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ReactionType { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PlannerTaskChatMessageId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Teams.Client.Teamwork.DeletedTeams.Item.Channels.Item.Planner.Plans.Item.Tasks.Item.Messages.Item.SetReaction.SetReactionPostRequestBody();

    if (this.IsParameterBound(nameof(ReactionType)))
        body.ReactionType = ReactionType;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Teamwork.DeletedTeams[DeletedTeamId].Channels[ChannelId].Planner.Plans[PlannerPlanId].Tasks[PlannerTaskId].Messages[PlannerTaskChatMessageId].SetReaction.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PlannerTaskChatMessageId);
                return;
            }

        }
    }
}
