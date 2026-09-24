#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Teams.Client;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Teams
{
    [GraphRoute("GET", "/teamwork/teamTemplates/{teamTemplate-id}/definitions/{teamTemplateDefinition-id}/teamDefinition/primaryChannel/planner/plans/{plannerPlan-id}/buckets/{plannerBucket-id}/tasks/{plannerTask-id}/messages/$count")]
    [Cmdlet(VerbsCommon.Get, "MgTeamworkTeamTemplateDefinitionTeamDefinitionPrimaryChannelPlannerPlanBucketTaskMessageCount")]
    [OutputType(typeof(int))]
    public class GetMgTeamworkTeamTemplateDefinitionTeamDefinitionPrimaryChannelPlannerPlanBucketTaskMessageCountCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TeamTemplateId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string TeamTemplateDefinitionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string PlannerPlanId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string PlannerBucketId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 4)]
        public string PlannerTaskId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false)]
        public string? Search { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            int? result;
            try
            {
                result = client.Teamwork.TeamTemplates[TeamTemplateId].Definitions[TeamTemplateDefinitionId].TeamDefinition.PrimaryChannel.Planner.Plans[PlannerPlanId].Buckets[PlannerBucketId].Tasks[PlannerTaskId].Messages.Count.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Filter)))
                        requestConfiguration.QueryParameters.Filter = Filter;

                    if (this.IsParameterBound(nameof(Search)))
                        requestConfiguration.QueryParameters.Search = Search;

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PlannerTaskId);
                return;
            }

            if (result is not null)
                WriteObject(result);
        }
    }
}
