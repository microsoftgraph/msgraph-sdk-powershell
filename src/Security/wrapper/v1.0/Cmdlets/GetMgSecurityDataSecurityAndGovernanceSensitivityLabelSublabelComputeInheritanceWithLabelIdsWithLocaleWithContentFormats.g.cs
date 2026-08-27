#nullable enable

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("GET", "/security/dataSecurityAndGovernance/sensitivityLabels/{sensitivityLabel-id}/sublabels/computeInheritance(labelIds={labelIds},locale='{locale}',contentFormats={contentFormats})")]
    [Cmdlet(VerbsCommon.Get, "MgSecurityDataSecurityAndGovernanceSensitivityLabelSublabelComputeInheritanceWithLabelIdsWithLocaleWithContentFormats")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.SensitivityLabel))]
    public class GetMgSecurityDataSecurityAndGovernanceSensitivityLabelSublabelComputeInheritanceWithLabelIdsWithLocaleWithContentFormatsCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SensitivityLabelId { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 1,
            HelpMessage = "Value for the 'labelIds' parameter of this OData function.")]
        public string LabelIds { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 2,
            HelpMessage = "Value for the 'locale' parameter of this OData function.")]
        public string Locale { get; set; } = string.Empty;

        [Parameter(Mandatory = true, Position = 3,
            HelpMessage = "Value for the 'contentFormats' parameter of this OData function.")]
        public string ContentFormats { get; set; } = string.Empty;

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
            { "sensitivityLabel%2Did", SensitivityLabelId },
            { "labelIds", LabelIds },
            { "locale", Locale },
            { "contentFormats", ContentFormats },
        };
        var requestBuilder = new global::Microsoft.Graph.PowerShell.Security.Client.Security.DataSecurityAndGovernance.SensitivityLabels.Item.Sublabels.ComputeInheritanceWithLabelIdsWithLocaleWithContentFormats.ComputeInheritanceWithLabelIdsWithLocaleWithContentFormatsRequestBuilder(pathParameters, requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.SensitivityLabel? result;
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
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, SensitivityLabelId));
                return;
            }

            WriteObject(result);
        }
    }
}
