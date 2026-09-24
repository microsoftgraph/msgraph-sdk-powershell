#nullable enable

using System;
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
    [GraphRoute("GET", "/groups/{group-id}/team/primaryChannel/planner/plans/{plannerPlan-id}/buckets/{plannerBucket-id}/tasks/{plannerTask-id}/assignedToTaskBoardFormat")]
    [Cmdlet(VerbsCommon.Get, "MgGroupTeamPrimaryChannelPlannerPlanBucketTaskAssignedToTaskBoardFormat")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerAssignedToTaskBoardTaskFormat))]
    public class GetMgGroupTeamPrimaryChannelPlannerPlanBucketTaskAssignedToTaskBoardFormatCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PlannerPlanId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string PlannerBucketId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string PlannerTaskId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerAssignedToTaskBoardTaskFormat? result;
            try
            {
                result = client.Groups[GroupId].Team.PrimaryChannel.Planner.Plans[PlannerPlanId].Buckets[PlannerBucketId].Tasks[PlannerTaskId].AssignedToTaskBoardFormat.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PlannerTaskId);
                return;
            }

            WriteObject(result);
        }
    }
}
