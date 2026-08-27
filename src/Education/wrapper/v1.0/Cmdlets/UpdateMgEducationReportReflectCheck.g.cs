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
    [GraphRoute("PATCH", "/education/reports/reflectCheckInResponses/{reflectCheckInResponse-id}")]
    [Cmdlet(VerbsData.Update, "MgEducationReportReflectCheck", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Education.Client.Models.ReflectCheckInResponse))]
    public class UpdateMgEducationReportReflectCheckCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ReflectCheckInResponseId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? CheckInId { get; set; }

        [Parameter(Mandatory = false)]
        public string? CheckInTitle { get; set; }

        [Parameter(Mandatory = false)]
        public string? ClassId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? CreatorId { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsClosed { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResponderId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? SubmitDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.ResponseEmotionType? ResponseEmotion { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Education.Client.Models.ResponseFeedbackType? ResponseFeedback { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ReflectCheckInResponseId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Education.Client.Models.ReflectCheckInResponse();

    if (this.IsParameterBound(nameof(CheckInId)))
        body.CheckInId = CheckInId;

    if (this.IsParameterBound(nameof(CheckInTitle)))
        body.CheckInTitle = CheckInTitle;

    if (this.IsParameterBound(nameof(ClassId)))
        body.ClassId = ClassId;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(CreatorId)))
        body.CreatorId = CreatorId;

    if (this.IsParameterBound(nameof(IsClosed)))
        body.IsClosed = IsClosed;

    if (this.IsParameterBound(nameof(ResponderId)))
        body.ResponderId = ResponderId;

    if (this.IsParameterBound(nameof(SubmitDateTime)))
        body.SubmitDateTime = SubmitDateTime;

    if (this.IsParameterBound(nameof(ResponseEmotion)))
        body.ResponseEmotion = ResponseEmotion;

    if (this.IsParameterBound(nameof(ResponseFeedback)))
        body.ResponseFeedback = ResponseFeedback;


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

            Microsoft.Graph.PowerShell.Education.Client.Models.ReflectCheckInResponse? result;
            try
            {
                result = client.Education.Reports.ReflectCheckInResponses[ReflectCheckInResponseId].PatchAsync(body, requestConfiguration =>
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
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, ReflectCheckInResponseId));
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Education.Reports.ReflectCheckInResponses[ReflectCheckInResponseId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, ReflectCheckInResponseId));
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
