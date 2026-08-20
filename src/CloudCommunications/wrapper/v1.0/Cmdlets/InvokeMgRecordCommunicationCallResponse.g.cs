#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.CloudCommunications.Client;
using Microsoft.Graph.PowerShell.CloudCommunications.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.CloudCommunications
{
    [GraphRoute("POST", "/communications/calls/{call-id}/recordResponse")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgRecordCommunicationCallResponse", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.RecordOperation))]
    public class InvokeMgRecordCommunicationCallResponseCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CallId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? BargeInAllowed { get; set; }

        [Parameter(Mandatory = false)]
        public int? InitialSilenceTimeoutInSeconds { get; set; }

        [Parameter(Mandatory = false)]
        public int? MaxSilenceTimeoutInSeconds { get; set; }

        [Parameter(Mandatory = false)]
        public int? MaxRecordDurationInSeconds { get; set; }

        [Parameter(Mandatory = false)]
        public bool? PlayBeep { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? StopTones { get; set; }

        [Parameter(Mandatory = false)]
        public string? ClientContext { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.Prompt[]? Prompts { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CallId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.CloudCommunications.Client.Communications.Calls.Item.RecordResponse.RecordResponsePostRequestBody();

    if (this.IsParameterBound(nameof(BargeInAllowed)))
        body.BargeInAllowed = BargeInAllowed;

    if (this.IsParameterBound(nameof(InitialSilenceTimeoutInSeconds)))
        body.InitialSilenceTimeoutInSeconds = InitialSilenceTimeoutInSeconds;

    if (this.IsParameterBound(nameof(MaxSilenceTimeoutInSeconds)))
        body.MaxSilenceTimeoutInSeconds = MaxSilenceTimeoutInSeconds;

    if (this.IsParameterBound(nameof(MaxRecordDurationInSeconds)))
        body.MaxRecordDurationInSeconds = MaxRecordDurationInSeconds;

    if (this.IsParameterBound(nameof(PlayBeep)))
        body.PlayBeep = PlayBeep;

    if (this.IsParameterBound(nameof(StopTones)))
        body.StopTones = StopTones!.ToList();

    if (this.IsParameterBound(nameof(ClientContext)))
        body.ClientContext = ClientContext;
    if (this.IsParameterBound(nameof(Prompts)))
        body.Prompts = Prompts!.ToList();

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

            Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.RecordOperation? result;
            try
            {
                result = client.Communications.Calls[CallId].RecordResponse.PostAsync(body, requestConfiguration =>
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
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, CallId));
                return;
            }

            WriteObject(result);
        }
    }
}
