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
    [GraphRoute("POST", "/security/secureScores")]
    [Cmdlet(VerbsCommon.New, "MgSecuritySecureScore", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.SecureScore))]
    public class NewMgSecuritySecureScoreCommand : PSCmdlet
    {


        [Parameter(Mandatory = false)]
        public int? ActiveUserCount { get; set; }

        [Parameter(Mandatory = false)]
        public string? AzureTenantId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public double? CurrentScore { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? EnabledServices { get; set; }

        [Parameter(Mandatory = false)]
        public int? LicensedUserCount { get; set; }

        [Parameter(Mandatory = false)]
        public double? MaxScore { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.AverageComparativeScore[]? AverageComparativeScores { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.ControlScore[]? ControlScores { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.SecurityVendorInformation? VendorInformation { get; set; }




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

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.SecureScore();

    if (this.IsParameterBound(nameof(ActiveUserCount)))
        body.ActiveUserCount = ActiveUserCount;

    if (this.IsParameterBound(nameof(AzureTenantId)))
        body.AzureTenantId = AzureTenantId;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(CurrentScore)))
        body.CurrentScore = CurrentScore;

    if (this.IsParameterBound(nameof(EnabledServices)))
        body.EnabledServices = EnabledServices!.ToList();

    if (this.IsParameterBound(nameof(LicensedUserCount)))
        body.LicensedUserCount = LicensedUserCount;

    if (this.IsParameterBound(nameof(MaxScore)))
        body.MaxScore = MaxScore;

    if (this.IsParameterBound(nameof(AverageComparativeScores)))
        body.AverageComparativeScores = AverageComparativeScores!.ToList();

    if (this.IsParameterBound(nameof(ControlScores)))
        body.ControlScores = ControlScores!.ToList();

    if (this.IsParameterBound(nameof(VendorInformation)))
        body.VendorInformation = VendorInformation;


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

            Microsoft.Graph.PowerShell.Security.Client.Models.SecureScore? result;
            try
            {
                result = client.Security.SecureScores.PostAsync(body, requestConfiguration =>
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
