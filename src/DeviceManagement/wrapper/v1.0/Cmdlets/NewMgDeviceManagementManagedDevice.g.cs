#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.DeviceManagement.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement
{
    [GraphRoute("POST", "/deviceManagement/managedDevices")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementManagedDevice", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDevice))]
    public class NewMgDeviceManagementManagedDeviceCommand : PSCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? ManagedDeviceName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Notes { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ComplianceState? ComplianceState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceEnrollmentType? DeviceEnrollmentType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceRegistrationState? DeviceRegistrationState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementExchangeAccessState? ExchangeAccessState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementExchangeAccessStateReason? ExchangeAccessStateReason { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDeviceOwnerType? ManagedDeviceOwnerType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagementAgentType? ManagementAgent { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagementState? ManagementState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDevicePartnerReportedHealthState? PartnerReportedThreatState { get; set; }




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

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDevice();

    if (this.IsParameterBound(nameof(ManagedDeviceName)))
        body.ManagedDeviceName = ManagedDeviceName;

    if (this.IsParameterBound(nameof(Notes)))
        body.Notes = Notes;

    if (this.IsParameterBound(nameof(ComplianceState)))
        body.ComplianceState = ComplianceState;

    if (this.IsParameterBound(nameof(DeviceEnrollmentType)))
        body.DeviceEnrollmentType = DeviceEnrollmentType;

    if (this.IsParameterBound(nameof(DeviceRegistrationState)))
        body.DeviceRegistrationState = DeviceRegistrationState;

    if (this.IsParameterBound(nameof(ExchangeAccessState)))
        body.ExchangeAccessState = ExchangeAccessState;

    if (this.IsParameterBound(nameof(ExchangeAccessStateReason)))
        body.ExchangeAccessStateReason = ExchangeAccessStateReason;

    if (this.IsParameterBound(nameof(ManagedDeviceOwnerType)))
        body.ManagedDeviceOwnerType = ManagedDeviceOwnerType;

    if (this.IsParameterBound(nameof(ManagementAgent)))
        body.ManagementAgent = ManagementAgent;

    if (this.IsParameterBound(nameof(ManagementState)))
        body.ManagementState = ManagementState;

    if (this.IsParameterBound(nameof(PartnerReportedThreatState)))
        body.PartnerReportedThreatState = PartnerReportedThreatState;


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

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDevice? result;
            try
            {
                result = client.DeviceManagement.ManagedDevices.PostAsync(body, requestConfiguration =>
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
