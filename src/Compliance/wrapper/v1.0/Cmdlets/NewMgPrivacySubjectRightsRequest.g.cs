#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Compliance.Client;
using Microsoft.Graph.PowerShell.Compliance.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Compliance
{
    [GraphRoute("POST", "/privacy/subjectRightsRequests")]
    [Cmdlet(VerbsCommon.New, "MgPrivacySubjectRightsRequest", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Compliance.Client.Models.SubjectRightsRequest))]
    public class NewMgPrivacySubjectRightsRequestCommand : GraphClientCmdlet
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


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Compliance.Client.Models.SubjectRightsRequest? result;
            try
            {
                result = client.Privacy.SubjectRightsRequests.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
