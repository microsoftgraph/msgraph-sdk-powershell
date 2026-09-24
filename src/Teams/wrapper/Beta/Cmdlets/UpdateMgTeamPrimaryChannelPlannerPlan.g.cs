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
    [GraphRoute("PATCH", "/teams/{team-id}/primaryChannel/planner/plans/{plannerPlan-id}")]
    [Cmdlet(VerbsData.Update, "MgTeamPrimaryChannelPlannerPlan", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerPlan))]
    public class UpdateMgTeamPrimaryChannelPlannerPlanCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TeamId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PlannerPlanId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsArchived { get; set; }

        [Parameter(Mandatory = false)]
        public string? Owner { get; set; }

        [Parameter(Mandatory = false)]
        public string? Title { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerArchivalInfo? ArchivalInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerPlanContainer? Container { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.ContentSensitivityLabelAssignment? ContentSensitivityLabelAssignment { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerPlanContextCollection? Contexts { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.IdentitySet? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerPlanCreation? CreationSource { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerSharedWithContainer[]? SharedWithContainers { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PlannerPlanId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerPlan();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(IsArchived)))
        body.IsArchived = IsArchived;

    if (this.IsParameterBound(nameof(Owner)))
        body.Owner = Owner;

    if (this.IsParameterBound(nameof(Title)))
        body.Title = Title;

    if (this.IsParameterBound(nameof(ArchivalInfo)))
        body.ArchivalInfo = ArchivalInfo;

    if (this.IsParameterBound(nameof(Container)))
        body.Container = Container;

    if (this.IsParameterBound(nameof(ContentSensitivityLabelAssignment)))
        body.ContentSensitivityLabelAssignment = ContentSensitivityLabelAssignment;

    if (this.IsParameterBound(nameof(Contexts)))
        body.Contexts = Contexts;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(CreationSource)))
        body.CreationSource = CreationSource;

    if (this.IsParameterBound(nameof(SharedWithContainers)))
        body.SharedWithContainers = SharedWithContainers!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerPlan? result;
            try
            {
                result = client.Teams[TeamId].PrimaryChannel.Planner.Plans[PlannerPlanId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PlannerPlanId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Teams[TeamId].PrimaryChannel.Planner.Plans[PlannerPlanId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, PlannerPlanId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
