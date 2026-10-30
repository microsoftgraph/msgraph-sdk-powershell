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
    [GraphRoute("PATCH", "/security/collaboration/analyzedEmails/{analyzedEmail-id}")]
    [Cmdlet(VerbsData.Update, "MgSecurityCollaborationAnalyzedEmail", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.AnalyzedEmail))]
    public class UpdateMgSecurityCollaborationAnalyzedEmailCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AnalyzedEmailId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? AlertIds { get; set; }

        [Parameter(Mandatory = false)]
        public string? BulkComplaintLevel { get; set; }

        [Parameter(Mandatory = false)]
        public string? ClientType { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Contexts { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? DetectionMethods { get; set; }

        [Parameter(Mandatory = false)]
        public string? DistributionList { get; set; }

        [Parameter(Mandatory = false)]
        public string? EmailClusterId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ForwardingDetail { get; set; }

        [Parameter(Mandatory = false)]
        public string? InboundConnectorFormattedName { get; set; }

        [Parameter(Mandatory = false)]
        public string? InternetMessageId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Language { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LoggedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? NetworkMessageId { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? OverrideSources { get; set; }

        [Parameter(Mandatory = false)]
        public string? PhishConfidenceLevel { get; set; }

        [Parameter(Mandatory = false)]
        public string? Policy { get; set; }

        [Parameter(Mandatory = false)]
        public string? PolicyAction { get; set; }

        [Parameter(Mandatory = false)]
        public string? PolicyType { get; set; }

        [Parameter(Mandatory = false)]
        public string? PrimaryOverrideSource { get; set; }

        [Parameter(Mandatory = false)]
        public string? RecipientEmailAddress { get; set; }

        [Parameter(Mandatory = false)]
        public string? ReturnPath { get; set; }

        [Parameter(Mandatory = false)]
        public int? SizeInBytes { get; set; }

        [Parameter(Mandatory = false)]
        public string? SpamConfidenceLevel { get; set; }

        [Parameter(Mandatory = false)]
        public string? Subject { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.AnalyzedEmailAttachment[]? Attachments { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.AnalyzedEmailAuthenticationDetail? AuthenticationDetails { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.AntispamDirectionality? Directionality { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.AnalyzedEmailDlpRuleInfo[]? DlpRules { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.AnalyzedEmailExchangeTransportRuleInfo[]? ExchangeTransportRules { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.AnalyzedEmailDeliveryDetail? LatestDelivery { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.AnalyzedEmailDeliveryDetail? OriginalDelivery { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.AnalyzedEmailRecipientDetail? RecipientDetail { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.AnalyzedEmailSenderDetail? SenderDetail { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.ThreatDetectionDetail[]? ThreatDetectionDetails { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.ThreatType?[]? ThreatTypes { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.TimelineEvent[]? TimelineEvents { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.AnalyzedEmailUrl[]? Urls { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AnalyzedEmailId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.AnalyzedEmail();

    if (this.IsParameterBound(nameof(AlertIds)))
        body.AlertIds = AlertIds!.ToList();

    if (this.IsParameterBound(nameof(BulkComplaintLevel)))
        body.BulkComplaintLevel = BulkComplaintLevel;

    if (this.IsParameterBound(nameof(ClientType)))
        body.ClientType = ClientType;

    if (this.IsParameterBound(nameof(Contexts)))
        body.Contexts = Contexts!.ToList();

    if (this.IsParameterBound(nameof(DetectionMethods)))
        body.DetectionMethods = DetectionMethods!.ToList();

    if (this.IsParameterBound(nameof(DistributionList)))
        body.DistributionList = DistributionList;

    if (this.IsParameterBound(nameof(EmailClusterId)))
        body.EmailClusterId = EmailClusterId;

    if (this.IsParameterBound(nameof(ForwardingDetail)))
        body.ForwardingDetail = ForwardingDetail;

    if (this.IsParameterBound(nameof(InboundConnectorFormattedName)))
        body.InboundConnectorFormattedName = InboundConnectorFormattedName;

    if (this.IsParameterBound(nameof(InternetMessageId)))
        body.InternetMessageId = InternetMessageId;

    if (this.IsParameterBound(nameof(Language)))
        body.Language = Language;

    if (this.IsParameterBound(nameof(LoggedDateTime)))
        body.LoggedDateTime = LoggedDateTime;

    if (this.IsParameterBound(nameof(NetworkMessageId)))
        body.NetworkMessageId = NetworkMessageId;

    if (this.IsParameterBound(nameof(OverrideSources)))
        body.OverrideSources = OverrideSources!.ToList();

    if (this.IsParameterBound(nameof(PhishConfidenceLevel)))
        body.PhishConfidenceLevel = PhishConfidenceLevel;

    if (this.IsParameterBound(nameof(Policy)))
        body.Policy = Policy;

    if (this.IsParameterBound(nameof(PolicyAction)))
        body.PolicyAction = PolicyAction;

    if (this.IsParameterBound(nameof(PolicyType)))
        body.PolicyType = PolicyType;

    if (this.IsParameterBound(nameof(PrimaryOverrideSource)))
        body.PrimaryOverrideSource = PrimaryOverrideSource;

    if (this.IsParameterBound(nameof(RecipientEmailAddress)))
        body.RecipientEmailAddress = RecipientEmailAddress;

    if (this.IsParameterBound(nameof(ReturnPath)))
        body.ReturnPath = ReturnPath;

    if (this.IsParameterBound(nameof(SizeInBytes)))
        body.SizeInBytes = SizeInBytes;

    if (this.IsParameterBound(nameof(SpamConfidenceLevel)))
        body.SpamConfidenceLevel = SpamConfidenceLevel;

    if (this.IsParameterBound(nameof(Subject)))
        body.Subject = Subject;

    if (this.IsParameterBound(nameof(Attachments)))
        body.Attachments = Attachments!.ToList();

    if (this.IsParameterBound(nameof(AuthenticationDetails)))
        body.AuthenticationDetails = AuthenticationDetails;

    if (this.IsParameterBound(nameof(Directionality)))
        body.Directionality = Directionality;

    if (this.IsParameterBound(nameof(DlpRules)))
        body.DlpRules = DlpRules!.ToList();

    if (this.IsParameterBound(nameof(ExchangeTransportRules)))
        body.ExchangeTransportRules = ExchangeTransportRules!.ToList();

    if (this.IsParameterBound(nameof(LatestDelivery)))
        body.LatestDelivery = LatestDelivery;

    if (this.IsParameterBound(nameof(OriginalDelivery)))
        body.OriginalDelivery = OriginalDelivery;

    if (this.IsParameterBound(nameof(RecipientDetail)))
        body.RecipientDetail = RecipientDetail;

    if (this.IsParameterBound(nameof(SenderDetail)))
        body.SenderDetail = SenderDetail;

    if (this.IsParameterBound(nameof(ThreatDetectionDetails)))
        body.ThreatDetectionDetails = ThreatDetectionDetails!.ToList();

    if (this.IsParameterBound(nameof(ThreatTypes)))
        body.ThreatTypes = ThreatTypes!.ToList();

    if (this.IsParameterBound(nameof(TimelineEvents)))
        body.TimelineEvents = TimelineEvents!.ToList();

    if (this.IsParameterBound(nameof(Urls)))
        body.Urls = Urls!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.AnalyzedEmail? result;
            try
            {
                result = client.Security.Collaboration.AnalyzedEmails[AnalyzedEmailId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AnalyzedEmailId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.Collaboration.AnalyzedEmails[AnalyzedEmailId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, AnalyzedEmailId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
