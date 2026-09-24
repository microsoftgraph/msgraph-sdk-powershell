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
    [GraphRoute("PATCH", "/teams/{team-id}/channels/{channel-id}/planner/plans/{plannerPlan-id}/buckets/{plannerBucket-id}/tasks/{plannerTask-id}/progressTaskBoardFormat")]
    [Cmdlet(VerbsData.Update, "MgTeamChannelPlannerPlanBucketTaskProgressTaskBoardFormat", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerProgressTaskBoardTaskFormat))]
    public class UpdateMgTeamChannelPlannerPlanBucketTaskProgressTaskBoardFormatCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TeamId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ChannelId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string PlannerPlanId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string PlannerBucketId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 4)]
        public string PlannerTaskId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? OrderHint { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Sets the 'If-Match' request header (for example an ETag for optimistic concurrency; some Graph APIs require it even where the spec marks it optional).")]
        public string? IfMatch { get; set; }




        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PlannerTaskId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerProgressTaskBoardTaskFormat();

    if (this.IsParameterBound(nameof(OrderHint)))
        body.OrderHint = OrderHint;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerProgressTaskBoardTaskFormat? result;
            try
            {
                result = client.Teams[TeamId].Channels[ChannelId].Planner.Plans[PlannerPlanId].Buckets[PlannerBucketId].Tasks[PlannerTaskId].ProgressTaskBoardFormat.PatchAsync(body, requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(IfMatch)))
                            requestConfiguration.Headers.Add("If-Match", IfMatch!);

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PlannerTaskId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Teams[TeamId].Channels[ChannelId].Planner.Plans[PlannerPlanId].Buckets[PlannerBucketId].Tasks[PlannerTaskId].ProgressTaskBoardFormat.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, PlannerTaskId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
