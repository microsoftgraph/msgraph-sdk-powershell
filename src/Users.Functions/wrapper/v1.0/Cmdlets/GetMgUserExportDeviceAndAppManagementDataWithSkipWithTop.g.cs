#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Users.Functions.Client;
using Microsoft.Graph.PowerShell.Users.Functions.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Users.Functions
{
    [GraphRoute("GET", "/users/{user-id}/exportDeviceAndAppManagementData(skip={skip},top={top})")]
    [Cmdlet(VerbsCommon.Get, "MgUserExportDeviceAndAppManagementDataWithSkipWithTop")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Users.Functions.Client.Models.DeviceAndAppManagementData))]
    public class GetMgUserExportDeviceAndAppManagementDataWithSkipWithTopCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 1,
            HelpMessage = "Value for the 'skip' parameter of this OData function.")]
        public string Skip { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 2,
            HelpMessage = "Value for the 'top' parameter of this OData function.")]
        public string Top { get; set; } = string.Empty;

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
            { "user%2Did", UserId },
            { "skip", Skip },
            { "top", Top },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.Users.Functions.Client.Users.Item.ExportDeviceAndAppManagementDataWithSkipWithTop.ExportDeviceAndAppManagementDataWithSkipWithTopRequestBuilder(pathParameters, requestAdapter);

            Microsoft.Graph.PowerShell.Users.Functions.Client.Models.DeviceAndAppManagementData? result;
            try
            {
                result = requestBuilder.GetAsync(requestConfiguration =>
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
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, UserId));
                return;
            }

            WriteObject(result);
        }
    }
}
