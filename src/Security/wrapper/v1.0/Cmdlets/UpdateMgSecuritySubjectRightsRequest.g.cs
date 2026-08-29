#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("PATCH", "/security/subjectRightsRequests/{subjectRightsRequest-id}")]
    [Cmdlet(VerbsData.Update, "MgSecuritySubjectRightsRequest", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.SubjectRightsRequest))]
    public class UpdateMgSecuritySubjectRightsRequestCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SubjectRightsRequestId { get; set; } = string.Empty;

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
        public Microsoft.Graph.PowerShell.Security.Client.Models.Identity? AssignedTo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.IdentitySet? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.DataSubject? DataSubject { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.DataSubjectType? DataSubjectType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.SubjectRightsRequestHistory[]? History { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.SubjectRightsRequestDetail? Insight { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.IdentitySet? LastModifiedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.SubjectRightsRequestMailboxLocation? MailboxLocations { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.SubjectRightsRequestSiteLocation? SiteLocations { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.SubjectRightsRequestStageDetail[]? Stages { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.SubjectRightsRequestStatus? Status { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.SubjectRightsRequestType? Type { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SubjectRightsRequestId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.SubjectRightsRequest();

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

            Microsoft.Graph.PowerShell.Security.Client.Models.SubjectRightsRequest? result;
            try
            {
                result = client.Security.SubjectRightsRequests[SubjectRightsRequestId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SubjectRightsRequestId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.SubjectRightsRequests[SubjectRightsRequestId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, SubjectRightsRequestId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
