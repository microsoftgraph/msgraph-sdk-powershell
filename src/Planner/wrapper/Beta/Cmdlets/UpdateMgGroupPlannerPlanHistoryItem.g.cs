#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Planner.Client;
using Microsoft.Graph.PowerShell.Planner.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Planner
{
    [GraphRoute("PATCH", "/groups/{group-id}/planner/plans/{plannerPlan-id}/historyItems/{plannerHistoryItem-id}")]
    [Cmdlet(VerbsData.Update, "MgGroupPlannerPlanHistoryItem", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerHistoryItem))]
    public class UpdateMgGroupPlannerPlanHistoryItemCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PlannerPlanId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string PlannerHistoryItemId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? EntityId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? OccurredDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? PlanId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.IdentitySet? Actor { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.HistoryEntityType? EntityType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.HistoryEventType? EventType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PlannerHistoryItemId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerHistoryItem();

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

            Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerHistoryItem? result;
            try
            {
                result = client.Groups[GroupId].Planner.Plans[PlannerPlanId].HistoryItems[PlannerHistoryItemId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PlannerHistoryItemId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Groups[GroupId].Planner.Plans[PlannerPlanId].HistoryItems[PlannerHistoryItemId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, PlannerHistoryItemId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
