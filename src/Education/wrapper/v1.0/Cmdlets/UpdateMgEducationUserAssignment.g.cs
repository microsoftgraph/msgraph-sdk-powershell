#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Education.Client;
using Microsoft.Graph.PowerShell.Education.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Education
{
    [GraphRoute("PATCH", "/education/users/{educationUser-id}/assignments/{educationAssignment-id}")]
    [Cmdlet(VerbsData.Update, "MgEducationUserAssignment", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Education.Client.Models.EducationAssignment))]
    public class UpdateMgEducationUserAssignmentCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EducationUserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EducationAssignmentId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? AllowLateSubmissions { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AllowStudentsToAddResourcesToSubmission { get; set; }

        [Parameter(Mandatory = false)]
        public string? ClassId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CloseDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DueDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? LanguageTag { get; set; }

        [Parameter(Mandatory = false)]
        public string? ModuleUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? NotificationChannelUrl { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.EducationAddedStudentAction? AddedStudentAction { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.EducationAddToCalendarOptions? AddToCalendarAction { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.EducationAssignmentRecipient? AssignTo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.EducationAssignmentGradeType? Grading { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.EducationItemBody? Instructions { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EducationAssignmentId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Education.Client.Models.EducationAssignment();

    if (this.IsParameterBound(nameof(AllowLateSubmissions)))
        body.AllowLateSubmissions = AllowLateSubmissions;

    if (this.IsParameterBound(nameof(AllowStudentsToAddResourcesToSubmission)))
        body.AllowStudentsToAddResourcesToSubmission = AllowStudentsToAddResourcesToSubmission;

    if (this.IsParameterBound(nameof(ClassId)))
        body.ClassId = ClassId;

    if (this.IsParameterBound(nameof(CloseDateTime)))
        body.CloseDateTime = CloseDateTime;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(DueDateTime)))
        body.DueDateTime = DueDateTime;

    if (this.IsParameterBound(nameof(LanguageTag)))
        body.LanguageTag = LanguageTag;

    if (this.IsParameterBound(nameof(ModuleUrl)))
        body.ModuleUrl = ModuleUrl;

    if (this.IsParameterBound(nameof(NotificationChannelUrl)))
        body.NotificationChannelUrl = NotificationChannelUrl;

    if (this.IsParameterBound(nameof(AddedStudentAction)))
        body.AddedStudentAction = AddedStudentAction;

    if (this.IsParameterBound(nameof(AddToCalendarAction)))
        body.AddToCalendarAction = AddToCalendarAction;

    if (this.IsParameterBound(nameof(AssignTo)))
        body.AssignTo = AssignTo;

    if (this.IsParameterBound(nameof(Grading)))
        body.Grading = Grading;

    if (this.IsParameterBound(nameof(Instructions)))
        body.Instructions = Instructions;


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

            Microsoft.Graph.PowerShell.Education.Client.Models.EducationAssignment? result;
            try
            {
                result = client.Education.Users[EducationUserId].Assignments[EducationAssignmentId].PatchAsync(body, requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(Headers)))
                        {
                            foreach (System.Collections.DictionaryEntry entry in Headers!)
                                requestConfiguration.Headers.Add(entry.Key.ToString()!, entry.Value?.ToString() ?? string.Empty);
                        }
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, EducationAssignmentId));
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Education.Users[EducationUserId].Assignments[EducationAssignmentId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, EducationAssignmentId));
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
