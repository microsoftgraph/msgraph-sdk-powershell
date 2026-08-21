#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.CorporateManagement
{
    [GraphRoute("PATCH", "/deviceAppManagement/mobileAppConfigurations/{managedDeviceMobileAppConfiguration-id}/deviceStatusSummary")]
    [Cmdlet(VerbsData.Update, "MgDeviceAppManagementMobileAppConfigurationDeviceStatusSummary", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedDeviceMobileAppConfigurationDeviceSummary))]
    public class UpdateMgDeviceAppManagementMobileAppConfigurationDeviceStatusSummaryCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedDeviceMobileAppConfigurationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? ConfigurationVersion { get; set; }

        [Parameter(Mandatory = false)]
        public int? ErrorCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? FailedCount { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastUpdateDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public int? NotApplicableCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? PendingCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? SuccessCount { get; set; }





        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ManagedDeviceMobileAppConfigurationId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedDeviceMobileAppConfigurationDeviceSummary();

    if (this.IsParameterBound(nameof(ConfigurationVersion)))
        body.ConfigurationVersion = ConfigurationVersion;

    if (this.IsParameterBound(nameof(ErrorCount)))
        body.ErrorCount = ErrorCount;

    if (this.IsParameterBound(nameof(FailedCount)))
        body.FailedCount = FailedCount;

    if (this.IsParameterBound(nameof(LastUpdateDateTime)))
        body.LastUpdateDateTime = LastUpdateDateTime;

    if (this.IsParameterBound(nameof(NotApplicableCount)))
        body.NotApplicableCount = NotApplicableCount;

    if (this.IsParameterBound(nameof(PendingCount)))
        body.PendingCount = PendingCount;

    if (this.IsParameterBound(nameof(SuccessCount)))
        body.SuccessCount = SuccessCount;



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

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedDeviceMobileAppConfigurationDeviceSummary? result;
            try
            {
                result = client.DeviceAppManagement.MobileAppConfigurations[ManagedDeviceMobileAppConfigurationId].DeviceStatusSummary.PatchAsync(body, requestConfiguration =>
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
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, ManagedDeviceMobileAppConfigurationId));
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceAppManagement.MobileAppConfigurations[ManagedDeviceMobileAppConfigurationId].DeviceStatusSummary.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, ManagedDeviceMobileAppConfigurationId));
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
