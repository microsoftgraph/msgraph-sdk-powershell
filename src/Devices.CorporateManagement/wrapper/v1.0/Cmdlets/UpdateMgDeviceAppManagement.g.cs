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
    [GraphRoute("PATCH", "/deviceAppManagement")]
    [Cmdlet(VerbsData.Update, "MgDeviceAppManagement", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.DeviceAppManagement))]
    public class UpdateMgDeviceAppManagementCommand : PSCmdlet
    {


        [Parameter(Mandatory = false)]
        public bool? IsEnabledForMicrosoftStoreForBusiness { get; set; }

        [Parameter(Mandatory = false)]
        public string? MicrosoftStoreForBusinessLanguage { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? MicrosoftStoreForBusinessLastCompletedApplicationSyncTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? MicrosoftStoreForBusinessLastSuccessfulSyncDateTime { get; set; }





        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.DeviceAppManagement();

    if (this.IsParameterBound(nameof(IsEnabledForMicrosoftStoreForBusiness)))
        body.IsEnabledForMicrosoftStoreForBusiness = IsEnabledForMicrosoftStoreForBusiness;

    if (this.IsParameterBound(nameof(MicrosoftStoreForBusinessLanguage)))
        body.MicrosoftStoreForBusinessLanguage = MicrosoftStoreForBusinessLanguage;

    if (this.IsParameterBound(nameof(MicrosoftStoreForBusinessLastCompletedApplicationSyncTime)))
        body.MicrosoftStoreForBusinessLastCompletedApplicationSyncTime = MicrosoftStoreForBusinessLastCompletedApplicationSyncTime;

    if (this.IsParameterBound(nameof(MicrosoftStoreForBusinessLastSuccessfulSyncDateTime)))
        body.MicrosoftStoreForBusinessLastSuccessfulSyncDateTime = MicrosoftStoreForBusinessLastSuccessfulSyncDateTime;



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

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.DeviceAppManagement? result;
            try
            {
                result = client.DeviceAppManagement.PatchAsync(body, requestConfiguration =>
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
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, null));
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceAppManagement.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, null));
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
