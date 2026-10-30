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
    [GraphRoute("PATCH", "/planner/plans_v2/{plan-id}")]
    [Cmdlet(VerbsData.Update, "MgPlannerPlanV2", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Planner.Client.Models.Plan))]
    public class UpdateMgPlannerPlanV2Command : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PlanId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public int? Duration { get; set; }

        [Parameter(Mandatory = false)]
        public bool? HasChat { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerArchivalInfo? ArchivalInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.PlanCalendar? Calendar { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.PlanContainer? Container { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.ContentSensitivityLabelAssignment? ContentSensitivityLabelAssignment { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.ExtensionFieldCollection? Extensions { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.IdentitySet? LastModifiedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.PlanView? PlanView { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerSharedWithContainer[]? SharedWithContainers { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PlanId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Planner.Client.Models.Plan();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(Duration)))
        body.Duration = Duration;

    if (this.IsParameterBound(nameof(HasChat)))
        body.HasChat = HasChat;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(ArchivalInfo)))
        body.ArchivalInfo = ArchivalInfo;

    if (this.IsParameterBound(nameof(Calendar)))
        body.Calendar = Calendar;

    if (this.IsParameterBound(nameof(Container)))
        body.Container = Container;

    if (this.IsParameterBound(nameof(ContentSensitivityLabelAssignment)))
        body.ContentSensitivityLabelAssignment = ContentSensitivityLabelAssignment;

    if (this.IsParameterBound(nameof(Extensions)))
        body.Extensions = Extensions;

    if (this.IsParameterBound(nameof(LastModifiedBy)))
        body.LastModifiedBy = LastModifiedBy;

    if (this.IsParameterBound(nameof(PlanView)))
        body.PlanView = PlanView;

    if (this.IsParameterBound(nameof(SharedWithContainers)))
        body.SharedWithContainers = SharedWithContainers!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Planner.Client.Models.Plan? result;
            try
            {
                result = client.Planner.Plans_v2[PlanId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PlanId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Planner.Plans_v2[PlanId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, PlanId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
