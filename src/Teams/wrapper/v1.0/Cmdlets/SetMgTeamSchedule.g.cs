#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Teams.Client;
using Microsoft.Graph.PowerShell.Teams.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Teams
{
    [GraphRoute("PUT", "/teams/{team-id}/schedule")]
    [Cmdlet(VerbsCommon.Set, "MgTeamSchedule", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.Schedule))]
    public class SetMgTeamScheduleCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TeamId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? Enabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsActivitiesIncludedWhenCopyingShiftsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? OfferShiftRequestsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? OpenShiftsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? SwapShiftsRequestsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? TimeClockEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? TimeOffRequestsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public string? TimeZone { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? WorkforceIntegrationIds { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.DayOfWeekObject? StartDayOfWeek { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TimeClockSettings? TimeClockSettings { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TeamId, "Set"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.Schedule();

    if (this.IsParameterBound(nameof(Enabled)))
        body.Enabled = Enabled;

    if (this.IsParameterBound(nameof(IsActivitiesIncludedWhenCopyingShiftsEnabled)))
        body.IsActivitiesIncludedWhenCopyingShiftsEnabled = IsActivitiesIncludedWhenCopyingShiftsEnabled;

    if (this.IsParameterBound(nameof(OfferShiftRequestsEnabled)))
        body.OfferShiftRequestsEnabled = OfferShiftRequestsEnabled;

    if (this.IsParameterBound(nameof(OpenShiftsEnabled)))
        body.OpenShiftsEnabled = OpenShiftsEnabled;

    if (this.IsParameterBound(nameof(SwapShiftsRequestsEnabled)))
        body.SwapShiftsRequestsEnabled = SwapShiftsRequestsEnabled;

    if (this.IsParameterBound(nameof(TimeClockEnabled)))
        body.TimeClockEnabled = TimeClockEnabled;

    if (this.IsParameterBound(nameof(TimeOffRequestsEnabled)))
        body.TimeOffRequestsEnabled = TimeOffRequestsEnabled;

    if (this.IsParameterBound(nameof(TimeZone)))
        body.TimeZone = TimeZone;

    if (this.IsParameterBound(nameof(WorkforceIntegrationIds)))
        body.WorkforceIntegrationIds = WorkforceIntegrationIds!.ToList();

    if (this.IsParameterBound(nameof(StartDayOfWeek)))
        body.StartDayOfWeek = StartDayOfWeek;

    if (this.IsParameterBound(nameof(TimeClockSettings)))
        body.TimeClockSettings = TimeClockSettings;


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

            Microsoft.Graph.PowerShell.Teams.Client.Models.Schedule? result;
            try
            {
                result = client.Teams[TeamId].Schedule.PutAsync(body, requestConfiguration =>
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
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, TeamId));
                return;
            }


            if (result is not null)
                WriteObject(result);
        }
    }
}
