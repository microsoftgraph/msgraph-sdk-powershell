#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.DeviceManagement.Functions.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Functions.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Functions
{
    [GraphRoute("GET", "/deviceManagement/verifyWindowsEnrollmentAutoDiscovery(domainName='{domainName}')")]
    [Cmdlet(VerbsCommon.Get, "MgDeviceManagementVerifyWindowsEnrollmentAutoDiscoveryWithDomainName")]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.DeviceManagement.Functions.Client.DeviceManagement.VerifyWindowsEnrollmentAutoDiscoveryWithDomainName.VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameGetResponse))]
    public class GetMgDeviceManagementVerifyWindowsEnrollmentAutoDiscoveryWithDomainNameCommand : PSCmdlet
    {


        [Parameter(Mandatory = true, Position = 0,
            HelpMessage = "Value for the 'domainName' parameter of this OData function.")]
        public string DomainName { get; set; } = string.Empty;

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }





        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }


        protected override void ProcessRecord()
        {

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

        var pathParameters = new Dictionary<string, object>
        {
            { "baseurl", requestAdapter.BaseUrl! },
            { "domainName", DomainName },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.DeviceManagement.Functions.Client.DeviceManagement.VerifyWindowsEnrollmentAutoDiscoveryWithDomainName.VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameRequestBuilder(pathParameters, requestAdapter);

            global::Microsoft.Graph.PowerShell.DeviceManagement.Functions.Client.DeviceManagement.VerifyWindowsEnrollmentAutoDiscoveryWithDomainName.VerifyWindowsEnrollmentAutoDiscoveryWithDomainNameGetResponse? result;
            try
            {
                result = requestBuilder.GetAsVerifyWindowsEnrollmentAutoDiscoveryWithDomainNameGetResponseAsync(requestConfiguration =>
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

            WriteObject(result);
        }
    }
}
