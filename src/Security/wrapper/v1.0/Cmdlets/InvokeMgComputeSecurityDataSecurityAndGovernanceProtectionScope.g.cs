#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
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
    [GraphRoute("POST", "/security/dataSecurityAndGovernance/protectionScopes/compute")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgComputeSecurityDataSecurityAndGovernanceProtectionScope", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Security.Client.Security.DataSecurityAndGovernance.ProtectionScopes.Compute.ComputePostResponse))]
    public class InvokeMgComputeSecurityDataSecurityAndGovernanceProtectionScopeCommand : PSCmdlet
    {



        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.UserActivityTypes? Activities { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.PolicyLocation[]? Locations { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.PolicyPivotProperty? PivotOn { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.DeviceMetadata? DeviceMetadata { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.IntegratedApplicationMetadata? IntegratedAppMetadata { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Security.Client.Security.DataSecurityAndGovernance.ProtectionScopes.Compute.ComputePostRequestBody();

    if (this.IsParameterBound(nameof(Activities)))
        body.Activities = Activities;

    if (this.IsParameterBound(nameof(Locations)))
        body.Locations = Locations!.ToList();

    if (this.IsParameterBound(nameof(PivotOn)))
        body.PivotOn = PivotOn;

    if (this.IsParameterBound(nameof(DeviceMetadata)))
        body.DeviceMetadata = DeviceMetadata;

    if (this.IsParameterBound(nameof(IntegratedAppMetadata)))
        body.IntegratedAppMetadata = IntegratedAppMetadata;

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

            global::Microsoft.Graph.PowerShell.Security.Client.Security.DataSecurityAndGovernance.ProtectionScopes.Compute.ComputePostResponse? result;
            try
            {
                result = client.Security.DataSecurityAndGovernance.ProtectionScopes.Compute.PostAsComputePostResponseAsync(body, requestConfiguration =>
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
