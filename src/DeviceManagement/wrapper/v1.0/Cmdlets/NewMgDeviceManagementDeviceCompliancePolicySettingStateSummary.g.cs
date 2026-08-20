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
    [GraphRoute("POST", "/deviceManagement/deviceCompliancePolicySettingStateSummaries")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementDeviceCompliancePolicySettingStateSummary", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceCompliancePolicySettingStateSummary))]
    public class NewMgDeviceManagementDeviceCompliancePolicySettingStateSummaryCommand : PSCmdlet
    {


        [Parameter(Mandatory = false)]
        public int? CompliantDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? ConflictDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? ErrorDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? NonCompliantDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? NotApplicableDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? RemediatedDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public string? Setting { get; set; }

        [Parameter(Mandatory = false)]
        public string? SettingName { get; set; }

        [Parameter(Mandatory = false)]
        public int? UnknownDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.PolicyPlatformType? PlatformType { get; set; }




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

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceCompliancePolicySettingStateSummary();

    if (this.IsParameterBound(nameof(CompliantDeviceCount)))
        body.CompliantDeviceCount = CompliantDeviceCount;

    if (this.IsParameterBound(nameof(ConflictDeviceCount)))
        body.ConflictDeviceCount = ConflictDeviceCount;

    if (this.IsParameterBound(nameof(ErrorDeviceCount)))
        body.ErrorDeviceCount = ErrorDeviceCount;

    if (this.IsParameterBound(nameof(NonCompliantDeviceCount)))
        body.NonCompliantDeviceCount = NonCompliantDeviceCount;

    if (this.IsParameterBound(nameof(NotApplicableDeviceCount)))
        body.NotApplicableDeviceCount = NotApplicableDeviceCount;

    if (this.IsParameterBound(nameof(RemediatedDeviceCount)))
        body.RemediatedDeviceCount = RemediatedDeviceCount;

    if (this.IsParameterBound(nameof(Setting)))
        body.Setting = Setting;

    if (this.IsParameterBound(nameof(SettingName)))
        body.SettingName = SettingName;

    if (this.IsParameterBound(nameof(UnknownDeviceCount)))
        body.UnknownDeviceCount = UnknownDeviceCount;

    if (this.IsParameterBound(nameof(PlatformType)))
        body.PlatformType = PlatformType;


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

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceCompliancePolicySettingStateSummary? result;
            try
            {
                result = client.DeviceManagement.DeviceCompliancePolicySettingStateSummaries.PostAsync(body, requestConfiguration =>
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
