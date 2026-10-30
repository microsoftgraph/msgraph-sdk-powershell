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
    [GraphRoute("PATCH", "/planner/tasks_v2/{task-id}")]
    [Cmdlet(VerbsData.Update, "MgPlannerTaskV2", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Planner.Client.Models.TaskObject))]
    public class UpdateMgPlannerTaskV2Command : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TaskId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? BucketId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CompletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? GoalIds { get; set; }

        [Parameter(Mandatory = false)]
        public bool? HasChat { get; set; }

        [Parameter(Mandatory = false)]
        public bool? HasChildren { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsCritical { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ParentTaskId { get; set; }

        [Parameter(Mandatory = false)]
        public int? PercentComplete { get; set; }

        [Parameter(Mandatory = false)]
        public string? PlanId { get; set; }

        [Parameter(Mandatory = false)]
        public int? Priority { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerArchivalInfo? ArchivalInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.IdentitySet? CompletedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.DateWithOptionalTime? DueDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.ExtensionFieldCollection? Extensions { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.DateWithOptionalTime? FinishDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.IdentitySet? LastModifiedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.ItemBody? Notes { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.TaskPersonalView? PersonalView { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.TaskPlanView? PlanView { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerTaskRecurrence? Recurrence { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.DateWithOptionalTime? StartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerTaskStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TaskId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Planner.Client.Models.TaskObject();

    if (this.IsParameterBound(nameof(BucketId)))
        body.BucketId = BucketId;

    if (this.IsParameterBound(nameof(CompletedDateTime)))
        body.CompletedDateTime = CompletedDateTime;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(GoalIds)))
        body.GoalIds = GoalIds!.ToList();

    if (this.IsParameterBound(nameof(HasChat)))
        body.HasChat = HasChat;

    if (this.IsParameterBound(nameof(HasChildren)))
        body.HasChildren = HasChildren;

    if (this.IsParameterBound(nameof(IsCritical)))
        body.IsCritical = IsCritical;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(ParentTaskId)))
        body.ParentTaskId = ParentTaskId;

    if (this.IsParameterBound(nameof(PercentComplete)))
        body.PercentComplete = PercentComplete;

    if (this.IsParameterBound(nameof(PlanId)))
        body.PlanId = PlanId;

    if (this.IsParameterBound(nameof(Priority)))
        body.Priority = Priority;

    if (this.IsParameterBound(nameof(ArchivalInfo)))
        body.ArchivalInfo = ArchivalInfo;

    if (this.IsParameterBound(nameof(CompletedBy)))
        body.CompletedBy = CompletedBy;

    if (this.IsParameterBound(nameof(DueDateTime)))
        body.DueDateTime = DueDateTime;

    if (this.IsParameterBound(nameof(Extensions)))
        body.Extensions = Extensions;

    if (this.IsParameterBound(nameof(FinishDateTime)))
        body.FinishDateTime = FinishDateTime;

    if (this.IsParameterBound(nameof(LastModifiedBy)))
        body.LastModifiedBy = LastModifiedBy;

    if (this.IsParameterBound(nameof(Notes)))
        body.Notes = Notes;

    if (this.IsParameterBound(nameof(PersonalView)))
        body.PersonalView = PersonalView;

    if (this.IsParameterBound(nameof(PlanView)))
        body.PlanView = PlanView;

    if (this.IsParameterBound(nameof(Recurrence)))
        body.Recurrence = Recurrence;

    if (this.IsParameterBound(nameof(StartDateTime)))
        body.StartDateTime = StartDateTime;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Planner.Client.Models.TaskObject? result;
            try
            {
                result = client.Planner.Tasks_v2[TaskId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, TaskId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Planner.Tasks_v2[TaskId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, TaskId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
