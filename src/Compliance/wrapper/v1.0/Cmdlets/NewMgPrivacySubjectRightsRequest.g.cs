#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Compliance.Client;
using Microsoft.Graph.PowerShell.Compliance.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Compliance
{
    [GraphRoute("POST", "/privacy/subjectRightsRequests")]
    [Cmdlet(VerbsCommon.New, "MgPrivacySubjectRightsRequest", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Compliance.Client.Models.SubjectRightsRequest))]
    public class NewMgPrivacySubjectRightsRequestCommand : PSCmdlet
    {


        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ClosedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ContentQuery { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? ExternalId { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IncludeAllVersions { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IncludeAuthoredContent { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? InternalDueDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? PauseAfterEstimate { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Regulations { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Compliance.Client.Models.Identity? AssignedTo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Compliance.Client.Models.IdentitySet? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Compliance.Client.Models.DataSubject? DataSubject { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Compliance.Client.Models.DataSubjectType? DataSubjectType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Compliance.Client.Models.SubjectRightsRequestHistory[]? History { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Compliance.Client.Models.SubjectRightsRequestDetail? Insight { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Compliance.Client.Models.IdentitySet? LastModifiedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Compliance.Client.Models.SubjectRightsRequestMailboxLocation? MailboxLocations { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Compliance.Client.Models.SubjectRightsRequestSiteLocation? SiteLocations { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Compliance.Client.Models.SubjectRightsRequestStageDetail[]? Stages { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Compliance.Client.Models.SubjectRightsRequestStatus? Status { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Compliance.Client.Models.SubjectRightsRequestType? Type { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Compliance.Client.Models.SubjectRightsRequest();

    if (this.IsParameterBound(nameof(ClosedDateTime)))
        body.ClosedDateTime = ClosedDateTime;

    if (this.IsParameterBound(nameof(ContentQuery)))
        body.ContentQuery = ContentQuery;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(ExternalId)))
        body.ExternalId = ExternalId;

    if (this.IsParameterBound(nameof(IncludeAllVersions)))
        body.IncludeAllVersions = IncludeAllVersions;

    if (this.IsParameterBound(nameof(IncludeAuthoredContent)))
        body.IncludeAuthoredContent = IncludeAuthoredContent;

    if (this.IsParameterBound(nameof(InternalDueDateTime)))
        body.InternalDueDateTime = InternalDueDateTime;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(PauseAfterEstimate)))
        body.PauseAfterEstimate = PauseAfterEstimate;

    if (this.IsParameterBound(nameof(Regulations)))
        body.Regulations = Regulations!.ToList();

    if (this.IsParameterBound(nameof(AssignedTo)))
        body.AssignedTo = AssignedTo;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(DataSubject)))
        body.DataSubject = DataSubject;

    if (this.IsParameterBound(nameof(DataSubjectType)))
        body.DataSubjectType = DataSubjectType;

    if (this.IsParameterBound(nameof(History)))
        body.History = History!.ToList();

    if (this.IsParameterBound(nameof(Insight)))
        body.Insight = Insight;

    if (this.IsParameterBound(nameof(LastModifiedBy)))
        body.LastModifiedBy = LastModifiedBy;

    if (this.IsParameterBound(nameof(MailboxLocations)))
        body.MailboxLocations = MailboxLocations;

    if (this.IsParameterBound(nameof(SiteLocations)))
        body.SiteLocations = SiteLocations;

    if (this.IsParameterBound(nameof(Stages)))
        body.Stages = Stages!.ToList();

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(Type)))
        body.Type = Type;


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

            Microsoft.Graph.PowerShell.Compliance.Client.Models.SubjectRightsRequest? result;
            try
            {
                result = client.Privacy.SubjectRightsRequests.PostAsync(body, requestConfiguration =>
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
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, body));
                return;
            }

            WriteObject(result);
        }
    }
}
