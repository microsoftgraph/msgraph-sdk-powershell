#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("PATCH", "/security/labels/retentionLabels/{retentionLabel-id}/dispositionReviewStages/{dispositionReviewStage-stageNumber}")]
    [Cmdlet(VerbsData.Update, "MgSecurityLabelRetentionLabelDispositionReviewStage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.DispositionReviewStage))]
    public class UpdateMgSecurityLabelRetentionLabelDispositionReviewStageCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string RetentionLabelId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DispositionReviewStageStageNumber { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ReviewersEmailAddresses { get; set; }

        [Parameter(Mandatory = false)]
        public string? StageNumber { get; set; }





        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DispositionReviewStageStageNumber, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.DispositionReviewStage();

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(ReviewersEmailAddresses)))
        body.ReviewersEmailAddresses = ReviewersEmailAddresses!.ToList();

    if (this.IsParameterBound(nameof(StageNumber)))
        body.StageNumber = StageNumber;



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

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.DispositionReviewStage? result;
            try
            {
                result = client.Security.Labels.RetentionLabels[RetentionLabelId].DispositionReviewStages[DispositionReviewStageStageNumber].PatchAsync(body, requestConfiguration =>
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
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, DispositionReviewStageStageNumber));
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.Labels.RetentionLabels[RetentionLabelId].DispositionReviewStages[DispositionReviewStageStageNumber].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, DispositionReviewStageStageNumber));
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
