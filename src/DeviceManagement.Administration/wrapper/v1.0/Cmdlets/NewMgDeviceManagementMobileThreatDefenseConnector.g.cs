#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Administration
{
    [GraphRoute("POST", "/deviceManagement/mobileThreatDefenseConnectors")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementMobileThreatDefenseConnector", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.MobileThreatDefenseConnector))]
    public class NewMgDeviceManagementMobileThreatDefenseConnectorCommand : PSCmdlet
    {


        [Parameter(Mandatory = false)]
        public bool? AllowPartnerToCollectIOSApplicationMetadata { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AllowPartnerToCollectIOSPersonalApplicationMetadata { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AndroidDeviceBlockedOnMissingPartnerData { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AndroidEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AndroidMobileApplicationManagementEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IosDeviceBlockedOnMissingPartnerData { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IosEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IosMobileApplicationManagementEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastHeartbeatDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? MicrosoftDefenderForEndpointAttachEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public int? PartnerUnresponsivenessThresholdInDays { get; set; }

        [Parameter(Mandatory = false)]
        public bool? PartnerUnsupportedOsVersionBlocked { get; set; }

        [Parameter(Mandatory = false)]
        public bool? WindowsDeviceBlockedOnMissingPartnerData { get; set; }

        [Parameter(Mandatory = false)]
        public bool? WindowsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.MobileThreatPartnerTenantState? PartnerState { get; set; }




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

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.MobileThreatDefenseConnector();

    if (this.IsParameterBound(nameof(AllowPartnerToCollectIOSApplicationMetadata)))
        body.AllowPartnerToCollectIOSApplicationMetadata = AllowPartnerToCollectIOSApplicationMetadata;

    if (this.IsParameterBound(nameof(AllowPartnerToCollectIOSPersonalApplicationMetadata)))
        body.AllowPartnerToCollectIOSPersonalApplicationMetadata = AllowPartnerToCollectIOSPersonalApplicationMetadata;

    if (this.IsParameterBound(nameof(AndroidDeviceBlockedOnMissingPartnerData)))
        body.AndroidDeviceBlockedOnMissingPartnerData = AndroidDeviceBlockedOnMissingPartnerData;

    if (this.IsParameterBound(nameof(AndroidEnabled)))
        body.AndroidEnabled = AndroidEnabled;

    if (this.IsParameterBound(nameof(AndroidMobileApplicationManagementEnabled)))
        body.AndroidMobileApplicationManagementEnabled = AndroidMobileApplicationManagementEnabled;

    if (this.IsParameterBound(nameof(IosDeviceBlockedOnMissingPartnerData)))
        body.IosDeviceBlockedOnMissingPartnerData = IosDeviceBlockedOnMissingPartnerData;

    if (this.IsParameterBound(nameof(IosEnabled)))
        body.IosEnabled = IosEnabled;

    if (this.IsParameterBound(nameof(IosMobileApplicationManagementEnabled)))
        body.IosMobileApplicationManagementEnabled = IosMobileApplicationManagementEnabled;

    if (this.IsParameterBound(nameof(LastHeartbeatDateTime)))
        body.LastHeartbeatDateTime = LastHeartbeatDateTime;

    if (this.IsParameterBound(nameof(MicrosoftDefenderForEndpointAttachEnabled)))
        body.MicrosoftDefenderForEndpointAttachEnabled = MicrosoftDefenderForEndpointAttachEnabled;

    if (this.IsParameterBound(nameof(PartnerUnresponsivenessThresholdInDays)))
        body.PartnerUnresponsivenessThresholdInDays = PartnerUnresponsivenessThresholdInDays;

    if (this.IsParameterBound(nameof(PartnerUnsupportedOsVersionBlocked)))
        body.PartnerUnsupportedOsVersionBlocked = PartnerUnsupportedOsVersionBlocked;

    if (this.IsParameterBound(nameof(WindowsDeviceBlockedOnMissingPartnerData)))
        body.WindowsDeviceBlockedOnMissingPartnerData = WindowsDeviceBlockedOnMissingPartnerData;

    if (this.IsParameterBound(nameof(WindowsEnabled)))
        body.WindowsEnabled = WindowsEnabled;

    if (this.IsParameterBound(nameof(PartnerState)))
        body.PartnerState = PartnerState;


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

            Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.MobileThreatDefenseConnector? result;
            try
            {
                result = client.DeviceManagement.MobileThreatDefenseConnectors.PostAsync(body, requestConfiguration =>
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
