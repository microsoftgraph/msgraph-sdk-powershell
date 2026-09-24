#nullable enable

using System;
using System.Collections.Generic;
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
    [GraphRoute("GET", "/groups/{group-id}/team/primaryChannel/planner/plans/{plannerPlan-id}/getUsageRights()")]
    [Cmdlet(VerbsCommon.Get, "MgGroupTeamPrimaryChannelPlannerPlanGetUsageRights")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.PlanUsageRight))]
    public class GetMgGroupTeamPrimaryChannelPlannerPlanGetUsageRightsCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PlannerPlanId { get; set; } = string.Empty;









        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            Microsoft.Graph.PowerShell.Teams.Client.Models.PlanUsageRight? result;
            try
            {
                result = client.Groups[GroupId].Team.PrimaryChannel.Planner.Plans[PlannerPlanId].GetUsageRights.GetAsync(requestConfiguration =>
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
