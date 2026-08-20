#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("POST", "/security/attackSimulation/simulationAutomations/{simulationAutomation-id}/runs")]
    [Cmdlet(VerbsCommon.New, "MgSecurityAttackSimulationAutomationRun", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.SimulationAutomationRun))]
    public class NewMgSecurityAttackSimulationAutomationRunCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SimulationAutomationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EndDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? SimulationId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? StartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.SimulationAutomationRunStatus? Status { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SimulationAutomationId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.SimulationAutomationRun();

    if (this.IsParameterBound(nameof(EndDateTime)))
        body.EndDateTime = EndDateTime;

    if (this.IsParameterBound(nameof(SimulationId)))
        body.SimulationId = SimulationId;

    if (this.IsParameterBound(nameof(StartDateTime)))
        body.StartDateTime = StartDateTime;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


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

            Microsoft.Graph.PowerShell.Security.Client.Models.SimulationAutomationRun? result;
            try
            {
                result = client.Security.AttackSimulation.SimulationAutomations[SimulationAutomationId].Runs.PostAsync(body, requestConfiguration =>
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
