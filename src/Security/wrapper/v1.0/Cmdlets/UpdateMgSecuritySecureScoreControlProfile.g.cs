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
    [GraphRoute("PATCH", "/security/secureScoreControlProfiles/{secureScoreControlProfile-id}")]
    [Cmdlet(VerbsData.Update, "MgSecuritySecureScoreControlProfile", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.SecureScoreControlProfile))]
    public class UpdateMgSecuritySecureScoreControlProfileCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SecureScoreControlProfileId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ActionType { get; set; }

        [Parameter(Mandatory = false)]
        public string? ActionUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? AzureTenantId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ControlCategory { get; set; }

        [Parameter(Mandatory = false)]
        public bool? Deprecated { get; set; }

        [Parameter(Mandatory = false)]
        public string? ImplementationCost { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public double? MaxScore { get; set; }

        [Parameter(Mandatory = false)]
        public int? Rank { get; set; }

        [Parameter(Mandatory = false)]
        public string? Remediation { get; set; }

        [Parameter(Mandatory = false)]
        public string? RemediationImpact { get; set; }

        [Parameter(Mandatory = false)]
        public string? Service { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Threats { get; set; }

        [Parameter(Mandatory = false)]
        public string? Tier { get; set; }

        [Parameter(Mandatory = false)]
        public string? Title { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserImpact { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.ComplianceInformation[]? ComplianceInformation { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.SecureScoreControlStateUpdate[]? ControlStateUpdates { get; set; }

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
            if (!ShouldProcess(SecureScoreControlProfileId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.SecureScoreControlProfile();

    if (this.IsParameterBound(nameof(ActionType)))
        body.ActionType = ActionType;

    if (this.IsParameterBound(nameof(ActionUrl)))
        body.ActionUrl = ActionUrl;

    if (this.IsParameterBound(nameof(AzureTenantId)))
        body.AzureTenantId = AzureTenantId;

    if (this.IsParameterBound(nameof(ControlCategory)))
        body.ControlCategory = ControlCategory;

    if (this.IsParameterBound(nameof(Deprecated)))
        body.Deprecated = Deprecated;

    if (this.IsParameterBound(nameof(ImplementationCost)))
        body.ImplementationCost = ImplementationCost;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(MaxScore)))
        body.MaxScore = MaxScore;

    if (this.IsParameterBound(nameof(Rank)))
        body.Rank = Rank;

    if (this.IsParameterBound(nameof(Remediation)))
        body.Remediation = Remediation;

    if (this.IsParameterBound(nameof(RemediationImpact)))
        body.RemediationImpact = RemediationImpact;

    if (this.IsParameterBound(nameof(Service)))
        body.Service = Service;

    if (this.IsParameterBound(nameof(Threats)))
        body.Threats = Threats!.ToList();

    if (this.IsParameterBound(nameof(Tier)))
        body.Tier = Tier;

    if (this.IsParameterBound(nameof(Title)))
        body.Title = Title;

    if (this.IsParameterBound(nameof(UserImpact)))
        body.UserImpact = UserImpact;

    if (this.IsParameterBound(nameof(ComplianceInformation)))
        body.ComplianceInformation = ComplianceInformation!.ToList();

    if (this.IsParameterBound(nameof(ControlStateUpdates)))
        body.ControlStateUpdates = ControlStateUpdates!.ToList();

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

            Microsoft.Graph.PowerShell.Security.Client.Models.SecureScoreControlProfile? result;
            try
            {
                result = client.Security.SecureScoreControlProfiles[SecureScoreControlProfileId].PatchAsync(body, requestConfiguration =>
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
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, SecureScoreControlProfileId));
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.SecureScoreControlProfiles[SecureScoreControlProfileId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, SecureScoreControlProfileId));
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
