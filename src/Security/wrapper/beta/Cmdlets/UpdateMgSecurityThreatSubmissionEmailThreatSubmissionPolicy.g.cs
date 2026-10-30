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
    [GraphRoute("PATCH", "/security/threatSubmission/emailThreatSubmissionPolicies/{emailThreatSubmissionPolicy-id}")]
    [Cmdlet(VerbsData.Update, "MgSecurityThreatSubmissionEmailThreatSubmissionPolicy", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.EmailThreatSubmissionPolicy))]
    public class UpdateMgSecurityThreatSubmissionEmailThreatSubmissionPolicyCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EmailThreatSubmissionPolicyId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? CustomizedNotificationSenderEmailAddress { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomizedReportRecipientEmailAddress { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsAlwaysReportEnabledForUsers { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsAskMeEnabledForUsers { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsCustomizedMessageEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsCustomizedMessageEnabledForPhishing { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsCustomizedNotificationSenderEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsNeverReportEnabledForUsers { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsOrganizationBrandingEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsReportFromQuarantineEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsReportToCustomizedEmailAddressEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsReportToMicrosoftEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsReviewEmailNotificationEnabled { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EmailThreatSubmissionPolicyId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.EmailThreatSubmissionPolicy();

    if (this.IsParameterBound(nameof(CustomizedNotificationSenderEmailAddress)))
        body.CustomizedNotificationSenderEmailAddress = CustomizedNotificationSenderEmailAddress;

    if (this.IsParameterBound(nameof(CustomizedReportRecipientEmailAddress)))
        body.CustomizedReportRecipientEmailAddress = CustomizedReportRecipientEmailAddress;

    if (this.IsParameterBound(nameof(IsAlwaysReportEnabledForUsers)))
        body.IsAlwaysReportEnabledForUsers = IsAlwaysReportEnabledForUsers;

    if (this.IsParameterBound(nameof(IsAskMeEnabledForUsers)))
        body.IsAskMeEnabledForUsers = IsAskMeEnabledForUsers;

    if (this.IsParameterBound(nameof(IsCustomizedMessageEnabled)))
        body.IsCustomizedMessageEnabled = IsCustomizedMessageEnabled;

    if (this.IsParameterBound(nameof(IsCustomizedMessageEnabledForPhishing)))
        body.IsCustomizedMessageEnabledForPhishing = IsCustomizedMessageEnabledForPhishing;

    if (this.IsParameterBound(nameof(IsCustomizedNotificationSenderEnabled)))
        body.IsCustomizedNotificationSenderEnabled = IsCustomizedNotificationSenderEnabled;

    if (this.IsParameterBound(nameof(IsNeverReportEnabledForUsers)))
        body.IsNeverReportEnabledForUsers = IsNeverReportEnabledForUsers;

    if (this.IsParameterBound(nameof(IsOrganizationBrandingEnabled)))
        body.IsOrganizationBrandingEnabled = IsOrganizationBrandingEnabled;

    if (this.IsParameterBound(nameof(IsReportFromQuarantineEnabled)))
        body.IsReportFromQuarantineEnabled = IsReportFromQuarantineEnabled;

    if (this.IsParameterBound(nameof(IsReportToCustomizedEmailAddressEnabled)))
        body.IsReportToCustomizedEmailAddressEnabled = IsReportToCustomizedEmailAddressEnabled;

    if (this.IsParameterBound(nameof(IsReportToMicrosoftEnabled)))
        body.IsReportToMicrosoftEnabled = IsReportToMicrosoftEnabled;

    if (this.IsParameterBound(nameof(IsReviewEmailNotificationEnabled)))
        body.IsReviewEmailNotificationEnabled = IsReviewEmailNotificationEnabled;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.EmailThreatSubmissionPolicy? result;
            try
            {
                result = client.Security.ThreatSubmission.EmailThreatSubmissionPolicies[EmailThreatSubmissionPolicyId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, EmailThreatSubmissionPolicyId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.ThreatSubmission.EmailThreatSubmissionPolicies[EmailThreatSubmissionPolicyId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, EmailThreatSubmissionPolicyId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
