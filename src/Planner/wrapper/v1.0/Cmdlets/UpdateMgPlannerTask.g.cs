#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Planner.Client;
using Microsoft.Graph.PowerShell.Planner.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Planner
{
    [GraphRoute("PATCH", "/planner/tasks/{plannerTask-id}")]
    [Cmdlet(VerbsData.Update, "MgPlannerTask", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerTask))]
    public class UpdateMgPlannerTaskCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
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
        public bool? HasDescription { get; set; }

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
        public Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerAppliedCategories? AppliedCategories { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerAssignments? Assignments { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.IdentitySet? CompletedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.IdentitySet? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerPreviewType? PreviewType { get; set; }



        [Parameter(Mandatory = false,
            HelpMessage = "Sets the 'If-Match' request header (for example an ETag for optimistic concurrency; some Graph APIs require it even where the spec marks it optional).")]
        public string? IfMatch { get; set; }


        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PlannerTaskId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerTask();

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

    if (this.IsParameterBound(nameof(HasDescription)))
        body.HasDescription = HasDescription;

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

    if (this.IsParameterBound(nameof(Assignments)))
        body.Assignments = Assignments;

    if (this.IsParameterBound(nameof(CompletedBy)))
        body.CompletedBy = CompletedBy;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(PreviewType)))
        body.PreviewType = PreviewType;


        // ── Choose HttpClient + auth provider ─────────────────────────────
        HttpClient httpClient;
        IAuthenticationProvider authProvider;

        if (this.IsParameterBound(nameof(AccessToken)))
        {
            httpClient = new HttpClient();
            authProvider = new StaticBearerTokenAuthenticationProvider(AccessToken!);
        }
        else
        {
            WriteVerbose("No -AccessToken supplied, using the active Connect-MgGraph session.");
            try
            {
                httpClient = HttpHelpers.GetGraphHttpClient();
            }
            catch (Exception ex)
            {
                ThrowTerminatingError(new ErrorRecord(
                    new InvalidOperationException(
                        "No active Graph session. Run Connect-MgGraph first, or supply -AccessToken.", ex),
                    "NoGraphSession",
                    ErrorCategory.AuthenticationError,
                    null));
                return;
            }
            authProvider = new AnonymousAuthenticationProvider();
        }

        var requestAdapter = new HttpClientRequestAdapter(authProvider, httpClient: httpClient);
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerTask? result;
            try
            {
                result = client.Planner.Tasks[PlannerTaskId].PatchAsync(body, requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(IfMatch)))
                            requestConfiguration.Headers.Add("If-Match", IfMatch!);

                        if (this.IsParameterBound(nameof(Headers)))
                        {
                            foreach (System.Collections.DictionaryEntry entry in Headers!)
                                requestConfiguration.Headers.Add(entry.Key.ToString()!, entry.Value?.ToString() ?? string.Empty);
                        }
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, PlannerTaskId));
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Planner.Tasks[PlannerTaskId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, PlannerTaskId));
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
