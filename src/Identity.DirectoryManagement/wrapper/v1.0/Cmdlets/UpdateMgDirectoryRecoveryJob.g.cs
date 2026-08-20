#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("PATCH", "/directory/recovery/jobs/{recoveryJobBase-id}")]
    [Cmdlet(VerbsData.Update, "MgDirectoryRecoveryJob", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.EntraRecoveryServices.RecoveryJobBase))]
    public class UpdateMgDirectoryRecoveryJobCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string RecoveryJobBaseId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? JobCompletionDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? JobStartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? TargetStateDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public int? TotalChangedLinksCalculated { get; set; }

        [Parameter(Mandatory = false)]
        public int? TotalChangedObjectsCalculated { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.EntraRecoveryServices.RecoveryJobFilteringCriteriaBase? FilteringCriteria { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.EntraRecoveryServices.RecoveryStatus? Status { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(RecoveryJobBaseId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.EntraRecoveryServices.RecoveryJobBase();

    if (this.IsParameterBound(nameof(JobCompletionDateTime)))
        body.JobCompletionDateTime = JobCompletionDateTime;

    if (this.IsParameterBound(nameof(JobStartDateTime)))
        body.JobStartDateTime = JobStartDateTime;

    if (this.IsParameterBound(nameof(TargetStateDateTime)))
        body.TargetStateDateTime = TargetStateDateTime;

    if (this.IsParameterBound(nameof(TotalChangedLinksCalculated)))
        body.TotalChangedLinksCalculated = TotalChangedLinksCalculated;

    if (this.IsParameterBound(nameof(TotalChangedObjectsCalculated)))
        body.TotalChangedObjectsCalculated = TotalChangedObjectsCalculated;

    if (this.IsParameterBound(nameof(FilteringCriteria)))
        body.FilteringCriteria = FilteringCriteria;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


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

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.EntraRecoveryServices.RecoveryJobBase? result;
            try
            {
                result = client.Directory.Recovery.Jobs[RecoveryJobBaseId].PatchAsync(body, requestConfiguration =>
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
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, RecoveryJobBaseId));
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Directory.Recovery.Jobs[RecoveryJobBaseId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, RecoveryJobBaseId));
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
