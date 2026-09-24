#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Planner.Client;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Planner
{
    [GraphRoute("DELETE", "/users/{user-id}/planner/plans/{plannerPlan-id}/buckets/{plannerBucket-id}/tasks/{plannerTask-id}/messages/{plannerTaskChatMessage-id}")]
    [Cmdlet(VerbsCommon.Remove, "MgUserPlannerPlanBucketTaskMessage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    public class RemoveMgUserPlannerPlanBucketTaskMessageCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PlannerPlanId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string PlannerBucketId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string PlannerTaskId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 4)]
        public string PlannerTaskChatMessageId { get; set; } = string.Empty;


        [Parameter(Mandatory = false,
            HelpMessage = "Sets the 'If-Match' request header (for example an ETag for optimistic concurrency; some Graph APIs require it even where the spec marks it optional).")]
        public string? IfMatch { get; set; }




        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PlannerTaskChatMessageId, "Remove"))
                return;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            // DeleteAsync returns a plain Task: a standard delete response has no body.
            try
            {
                client.Users[UserId].Planner.Plans[PlannerPlanId].Buckets[PlannerBucketId].Tasks[PlannerTaskId].Messages[PlannerTaskChatMessageId].DeleteAsync(requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(IfMatch)))
                            requestConfiguration.Headers.Add("If-Match", IfMatch!);

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
