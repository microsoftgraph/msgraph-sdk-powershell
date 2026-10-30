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
    [GraphRoute("PATCH", "/security/threatSubmission/emailThreats/{emailThreatSubmission-id}")]
    [Cmdlet(VerbsData.Update, "MgSecurityThreatSubmissionEmailThreat", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.EmailThreatSubmission))]
    public class UpdateMgSecurityThreatSubmissionEmailThreatCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EmailThreatSubmissionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? TenantId { get; set; }

        [Parameter(Mandatory = false)]
        public string? InternetMessageId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ReceivedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? RecipientEmailAddress { get; set; }

        [Parameter(Mandatory = false)]
        public string? Sender { get; set; }

        [Parameter(Mandatory = false)]
        public string? SenderIP { get; set; }

        [Parameter(Mandatory = false)]
        public string? Subject { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.SubmissionAdminReview? AdminReview { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.SubmissionCategory? Category { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.SubmissionClientSource? ClientSource { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.SubmissionContentType? ContentType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.SubmissionUserIdentity? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.SubmissionResult? Result { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.SubmissionSource? Source { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.LongRunningOperationStatus? Status { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.AttackSimulationInfo? AttackSimulationInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.SubmissionCategory? OriginalCategory { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.TenantAllowOrBlockListAction? TenantAllowOrBlockListAction { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EmailThreatSubmissionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.EmailThreatSubmission();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(TenantId)))
        body.TenantId = TenantId;

    if (this.IsParameterBound(nameof(InternetMessageId)))
        body.InternetMessageId = InternetMessageId;

    if (this.IsParameterBound(nameof(ReceivedDateTime)))
        body.ReceivedDateTime = ReceivedDateTime;

    if (this.IsParameterBound(nameof(RecipientEmailAddress)))
        body.RecipientEmailAddress = RecipientEmailAddress;

    if (this.IsParameterBound(nameof(Sender)))
        body.Sender = Sender;

    if (this.IsParameterBound(nameof(SenderIP)))
        body.SenderIP = SenderIP;

    if (this.IsParameterBound(nameof(Subject)))
        body.Subject = Subject;

    if (this.IsParameterBound(nameof(AdminReview)))
        body.AdminReview = AdminReview;

    if (this.IsParameterBound(nameof(Category)))
        body.Category = Category;

    if (this.IsParameterBound(nameof(ClientSource)))
        body.ClientSource = ClientSource;

    if (this.IsParameterBound(nameof(ContentType)))
        body.ContentType = ContentType;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(Result)))
        body.Result = Result;

    if (this.IsParameterBound(nameof(Source)))
        body.Source = Source;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(AttackSimulationInfo)))
        body.AttackSimulationInfo = AttackSimulationInfo;

    if (this.IsParameterBound(nameof(OriginalCategory)))
        body.OriginalCategory = OriginalCategory;

    if (this.IsParameterBound(nameof(TenantAllowOrBlockListAction)))
        body.TenantAllowOrBlockListAction = TenantAllowOrBlockListAction;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.EmailThreatSubmission? result;
            try
            {
                result = client.Security.ThreatSubmission.EmailThreats[EmailThreatSubmissionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, EmailThreatSubmissionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.ThreatSubmission.EmailThreats[EmailThreatSubmissionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, EmailThreatSubmissionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
