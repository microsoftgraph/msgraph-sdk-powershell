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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/workbook/functions/hypGeom_Dist")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveItemWorkbookFunctionHypGeom_Dist", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookFunctionResult))]
    public class InvokeMgDriveItemWorkbookFunctionHypGeom_DistCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public object? SampleS { get; set; }

        [Parameter(Mandatory = false)]
        public object? NumberSample { get; set; }

        [Parameter(Mandatory = false)]
        public object? PopulationS { get; set; }

        [Parameter(Mandatory = false)]
        public object? NumberPop { get; set; }

        [Parameter(Mandatory = false)]
        public object? Cumulative { get; set; }



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

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Workbook.Functions.HypGeom_Dist.HypGeom_DistPostRequestBody();

    if (this.IsParameterBound(nameof(SampleS)))
    {
        var untypedSampleS = UntypedValue.From(SampleS);
        if (untypedSampleS is not null)
            body.SampleS = untypedSampleS;
    }

    if (this.IsParameterBound(nameof(NumberSample)))
    {
        var untypedNumberSample = UntypedValue.From(NumberSample);
        if (untypedNumberSample is not null)
            body.NumberSample = untypedNumberSample;
    }

    if (this.IsParameterBound(nameof(PopulationS)))
    {
        var untypedPopulationS = UntypedValue.From(PopulationS);
        if (untypedPopulationS is not null)
            body.PopulationS = untypedPopulationS;
    }

    if (this.IsParameterBound(nameof(NumberPop)))
    {
        var untypedNumberPop = UntypedValue.From(NumberPop);
        if (untypedNumberPop is not null)
            body.NumberPop = untypedNumberPop;
    }

    if (this.IsParameterBound(nameof(Cumulative)))
    {
        var untypedCumulative = UntypedValue.From(Cumulative);
        if (untypedCumulative is not null)
            body.Cumulative = untypedCumulative;
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
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Functions.HypGeom_Dist.PostAsync(body, requestConfiguration =>
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
