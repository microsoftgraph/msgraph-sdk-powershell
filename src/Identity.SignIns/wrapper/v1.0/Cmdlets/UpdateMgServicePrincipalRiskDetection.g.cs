#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.SignIns
{
    [GraphRoute("PATCH", "/identityProtection/servicePrincipalRiskDetections/{servicePrincipalRiskDetection-id}")]
    [Cmdlet(VerbsData.Update, "MgServicePrincipalRiskDetection", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.ServicePrincipalRiskDetection))]
    public class UpdateMgServicePrincipalRiskDetectionCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ServicePrincipalRiskDetectionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ActivityDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? AdditionalInfo { get; set; }

        [Parameter(Mandatory = false)]
        public string? AppId { get; set; }

        [Parameter(Mandatory = false)]
        public string? CorrelationId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DetectedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? IpAddress { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? KeyIds { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastUpdatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? RequestId { get; set; }

        [Parameter(Mandatory = false)]
        public string? RiskEventType { get; set; }

        [Parameter(Mandatory = false)]
        public string? ServicePrincipalDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? ServicePrincipalId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Source { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.ActivityType? Activity { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskDetectionTimingType? DetectionTimingType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.SignInLocation? Location { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskDetail? RiskDetail { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskLevel? RiskLevel { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.RiskState? RiskState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.TokenIssuerType? TokenIssuerType { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ServicePrincipalRiskDetectionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.ServicePrincipalRiskDetection();

    if (this.IsParameterBound(nameof(ActivityDateTime)))
        body.ActivityDateTime = ActivityDateTime;

    if (this.IsParameterBound(nameof(AdditionalInfo)))
        body.AdditionalInfo = AdditionalInfo;

    if (this.IsParameterBound(nameof(AppId)))
        body.AppId = AppId;

    if (this.IsParameterBound(nameof(CorrelationId)))
        body.CorrelationId = CorrelationId;

    if (this.IsParameterBound(nameof(DetectedDateTime)))
        body.DetectedDateTime = DetectedDateTime;

    if (this.IsParameterBound(nameof(IpAddress)))
        body.IpAddress = IpAddress;

    if (this.IsParameterBound(nameof(KeyIds)))
        body.KeyIds = KeyIds!.ToList();

    if (this.IsParameterBound(nameof(LastUpdatedDateTime)))
        body.LastUpdatedDateTime = LastUpdatedDateTime;

    if (this.IsParameterBound(nameof(RequestId)))
        body.RequestId = RequestId;

    if (this.IsParameterBound(nameof(RiskEventType)))
        body.RiskEventType = RiskEventType;

    if (this.IsParameterBound(nameof(ServicePrincipalDisplayName)))
        body.ServicePrincipalDisplayName = ServicePrincipalDisplayName;

    if (this.IsParameterBound(nameof(ServicePrincipalId)))
        body.ServicePrincipalId = ServicePrincipalId;

    if (this.IsParameterBound(nameof(Source)))
        body.Source = Source;

    if (this.IsParameterBound(nameof(Activity)))
        body.Activity = Activity;

    if (this.IsParameterBound(nameof(DetectionTimingType)))
        body.DetectionTimingType = DetectionTimingType;

    if (this.IsParameterBound(nameof(Location)))
        body.Location = Location;

    if (this.IsParameterBound(nameof(RiskDetail)))
        body.RiskDetail = RiskDetail;

    if (this.IsParameterBound(nameof(RiskLevel)))
        body.RiskLevel = RiskLevel;

    if (this.IsParameterBound(nameof(RiskState)))
        body.RiskState = RiskState;

    if (this.IsParameterBound(nameof(TokenIssuerType)))
        body.TokenIssuerType = TokenIssuerType;


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

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.ServicePrincipalRiskDetection? result;
            try
            {
                result = client.IdentityProtection.ServicePrincipalRiskDetections[ServicePrincipalRiskDetectionId].PatchAsync(body, requestConfiguration =>
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
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, ServicePrincipalRiskDetectionId));
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityProtection.ServicePrincipalRiskDetections[ServicePrincipalRiskDetectionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, ServicePrincipalRiskDetectionId));
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
