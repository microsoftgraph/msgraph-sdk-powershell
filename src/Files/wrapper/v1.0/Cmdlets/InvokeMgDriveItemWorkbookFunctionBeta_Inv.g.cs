#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Files.Client;
using Microsoft.Graph.PowerShell.Files.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Files
{
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/functions/beta_Inv")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveItemWorkbookFunctionBeta_Inv", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult))]
    public class InvokeMgDriveItemWorkbookFunctionBeta_InvCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public object? Probability { get; set; }

        [Parameter(Mandatory = false)]
        public object? Alpha { get; set; }

        [Parameter(Mandatory = false)]
        public object? Beta { get; set; }

        [Parameter(Mandatory = false)]
        public object? A { get; set; }

        [Parameter(Mandatory = false)]
        public object? B { get; set; }



        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Functions.Beta_Inv.Beta_InvPostRequestBody();

    if (this.IsParameterBound(nameof(Probability)))
    {
        var untypedProbability = UntypedValue.From(Probability);
        if (untypedProbability is not null)
            body.Probability = untypedProbability;
    }

    if (this.IsParameterBound(nameof(Alpha)))
    {
        var untypedAlpha = UntypedValue.From(Alpha);
        if (untypedAlpha is not null)
            body.Alpha = untypedAlpha;
    }

    if (this.IsParameterBound(nameof(Beta)))
    {
        var untypedBeta = UntypedValue.From(Beta);
        if (untypedBeta is not null)
            body.Beta = untypedBeta;
    }

    if (this.IsParameterBound(nameof(A)))
    {
        var untypedA = UntypedValue.From(A);
        if (untypedA is not null)
            body.A = untypedA;
    }

    if (this.IsParameterBound(nameof(B)))
    {
        var untypedB = UntypedValue.From(B);
        if (untypedB is not null)
            body.B = untypedB;
    }

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

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Functions.Beta_Inv.PostAsync(body, requestConfiguration =>
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
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, DriveItemId));
                return;
            }

            WriteObject(result);
        }
    }
}
