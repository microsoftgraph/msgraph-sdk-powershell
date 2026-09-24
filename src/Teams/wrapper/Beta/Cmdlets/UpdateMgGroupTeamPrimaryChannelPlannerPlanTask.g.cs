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
    [GraphRoute("PATCH", "/groups/{group-id}/team/primaryChannel/planner/plans/{plannerPlan-id}/tasks/{plannerTask-id}")]
    [Cmdlet(VerbsData.Update, "MgGroupTeamPrimaryChannelPlannerPlanTask", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerTask))]
    public class UpdateMgGroupTeamPrimaryChannelPlannerPlanTaskCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PlannerPlanId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string PlannerTaskId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? ActiveChecklistItemCount { get; set; }

        [Parameter(Mandatory = false)]
        public string? AssigneePriority { get; set; }

        [Parameter(Mandatory = false)]
        public string? BucketId { get; set; }

        [Parameter(Mandatory = false)]
        public int? ChecklistItemCount { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CompletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ConversationThreadId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DueDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? GoalIds { get; set; }

        [Parameter(Mandatory = false)]
        public bool? HasChat { get; set; }

        [Parameter(Mandatory = false)]
        public bool? HasDescription { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsArchived { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsOnMyDay { get; set; }

        [Parameter(Mandatory = false)]
        public global::Microsoft.Kiota.Abstractions.Date? IsOnMyDayLastModifiedDate { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? OrderHint { get; set; }

        [Parameter(Mandatory = false)]
        public int? PercentComplete { get; set; }

        [Parameter(Mandatory = false)]
        public string? PlanId { get; set; }

        [Parameter(Mandatory = false)]
        public int? Priority { get; set; }

        [Parameter(Mandatory = false)]
        public int? ReferenceCount { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? StartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Title { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerAppliedCategories? AppliedCategories { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerArchivalInfo? ArchivalInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerAssignments? Assignments { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.IdentitySet? CompletedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.IdentitySet? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerTaskCreation? CreationSource { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.IdentitySet? LastModifiedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerPreviewType? PreviewType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerTaskRecurrence? Recurrence { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerTaskCompletionRequirements? SpecifiedCompletionRequirements { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PlannerTaskId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerTask();

    if (this.IsParameterBound(nameof(ActiveChecklistItemCount)))
        body.ActiveChecklistItemCount = ActiveChecklistItemCount;

    if (this.IsParameterBound(nameof(AssigneePriority)))
        body.AssigneePriority = AssigneePriority;

    if (this.IsParameterBound(nameof(BucketId)))
        body.BucketId = BucketId;

    if (this.IsParameterBound(nameof(ChecklistItemCount)))
        body.ChecklistItemCount = ChecklistItemCount;

    if (this.IsParameterBound(nameof(CompletedDateTime)))
        body.CompletedDateTime = CompletedDateTime;

    if (this.IsParameterBound(nameof(ConversationThreadId)))
        body.ConversationThreadId = ConversationThreadId;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(DueDateTime)))
        body.DueDateTime = DueDateTime;

    if (this.IsParameterBound(nameof(GoalIds)))
        body.GoalIds = GoalIds!.ToList();

    if (this.IsParameterBound(nameof(HasChat)))
        body.HasChat = HasChat;

    if (this.IsParameterBound(nameof(HasDescription)))
        body.HasDescription = HasDescription;

    if (this.IsParameterBound(nameof(IsArchived)))
        body.IsArchived = IsArchived;

    if (this.IsParameterBound(nameof(IsOnMyDay)))
        body.IsOnMyDay = IsOnMyDay;

    if (this.IsParameterBound(nameof(IsOnMyDayLastModifiedDate)))
        body.IsOnMyDayLastModifiedDate = IsOnMyDayLastModifiedDate;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(OrderHint)))
        body.OrderHint = OrderHint;

    if (this.IsParameterBound(nameof(PercentComplete)))
        body.PercentComplete = PercentComplete;

    if (this.IsParameterBound(nameof(PlanId)))
        body.PlanId = PlanId;

    if (this.IsParameterBound(nameof(Priority)))
        body.Priority = Priority;

    if (this.IsParameterBound(nameof(ReferenceCount)))
        body.ReferenceCount = ReferenceCount;

    if (this.IsParameterBound(nameof(StartDateTime)))
        body.StartDateTime = StartDateTime;

    if (this.IsParameterBound(nameof(Title)))
        body.Title = Title;

    if (this.IsParameterBound(nameof(AppliedCategories)))
        body.AppliedCategories = AppliedCategories;

    if (this.IsParameterBound(nameof(ArchivalInfo)))
        body.ArchivalInfo = ArchivalInfo;

    if (this.IsParameterBound(nameof(Assignments)))
        body.Assignments = Assignments;

    if (this.IsParameterBound(nameof(CompletedBy)))
        body.CompletedBy = CompletedBy;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(CreationSource)))
        body.CreationSource = CreationSource;

    if (this.IsParameterBound(nameof(LastModifiedBy)))
        body.LastModifiedBy = LastModifiedBy;

    if (this.IsParameterBound(nameof(PreviewType)))
        body.PreviewType = PreviewType;

    if (this.IsParameterBound(nameof(Recurrence)))
        body.Recurrence = Recurrence;

    if (this.IsParameterBound(nameof(SpecifiedCompletionRequirements)))
        body.SpecifiedCompletionRequirements = SpecifiedCompletionRequirements;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.PlannerTask? result;
            try
            {
                result = client.Groups[GroupId].Team.PrimaryChannel.Planner.Plans[PlannerPlanId].Tasks[PlannerTaskId].PatchAsync(body, requestConfiguration =>
                {

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
                    result = client.Groups[GroupId].Team.PrimaryChannel.Planner.Plans[PlannerPlanId].Tasks[PlannerTaskId].GetAsync().GetAwaiter().GetResult();
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
