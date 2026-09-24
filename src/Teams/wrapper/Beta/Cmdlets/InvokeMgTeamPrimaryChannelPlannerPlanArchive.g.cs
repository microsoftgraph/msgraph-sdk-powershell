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
    [GraphRoute("POST", "/teams/{team-id}/primaryChannel/planner/plans/{plannerPlan-id}/archive")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgTeamPrimaryChannelPlannerPlanArchive", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgTeamPrimaryChannelPlannerPlanArchiveCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TeamId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PlannerPlanId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Justification { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PlannerPlanId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Teams.Client.Teams.Item.PrimaryChannel.Planner.Plans.Item.Archive.ArchivePostRequestBody();

    if (this.IsParameterBound(nameof(Justification)))
        body.Justification = Justification;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Teams[TeamId].PrimaryChannel.Planner.Plans[PlannerPlanId].Archive.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PlannerPlanId);
                return;
            }

        }
    }
}
