#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Teams.Client;
using Microsoft.Graph.PowerShell.Teams.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Teams
{
    [GraphRoute("POST", "/teams/{team-id}/primaryChannel/planner/plans/{plannerPlan-id}/historyItems")]
    [Cmdlet(VerbsCommon.New, "MgTeamPrimaryChannelPlannerPlanHistoryItem", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerHistoryItem))]
    public class NewMgTeamPrimaryChannelPlannerPlanHistoryItemCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TeamId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PlannerPlanId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? EntityId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? OccurredDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? PlanId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.IdentitySet? Actor { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.HistoryEntityType? EntityType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.HistoryEventType? EventType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PlannerPlanId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerHistoryItem();

    if (this.IsParameterBound(nameof(EntityId)))
        body.EntityId = EntityId;

    if (this.IsParameterBound(nameof(OccurredDateTime)))
        body.OccurredDateTime = OccurredDateTime;

    if (this.IsParameterBound(nameof(PlanId)))
        body.PlanId = PlanId;

    if (this.IsParameterBound(nameof(Actor)))
        body.Actor = Actor;

    if (this.IsParameterBound(nameof(EntityType)))
        body.EntityType = EntityType;

    if (this.IsParameterBound(nameof(EventType)))
        body.EventType = EventType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerHistoryItem? result;
            try
            {
                result = client.Teams[TeamId].PrimaryChannel.Planner.Plans[PlannerPlanId].HistoryItems.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
