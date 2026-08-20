#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Users.Actions.Client;
using Microsoft.Graph.PowerShell.Users.Actions.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Users.Actions
{
    [GraphRoute("POST", "/users/{user-id}/findMeetingTimes")]
    [Cmdlet(VerbsCommon.Find, "MgUserMeetingTime", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Users.Actions.Client.Models.MeetingTimeSuggestionsResult))]
    public class FindMgUserMeetingTimeCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.TimeSpan? MeetingDuration { get; set; }

        [Parameter(Mandatory = false)]
        public int? MaxCandidates { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsOrganizerOptional { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ReturnSuggestionReasons { get; set; }

        [Parameter(Mandatory = false)]
        public double? MinimumAttendeePercentage { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Actions.Client.Models.AttendeeBase[]? Attendees { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Actions.Client.Models.LocationConstraint? LocationConstraint { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Actions.Client.Models.TimeConstraint? TimeConstraint { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Find"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Users.Actions.Client.Users.Item.FindMeetingTimes.FindMeetingTimesPostRequestBody();

    if (this.IsParameterBound(nameof(MeetingDuration)))
        body.MeetingDuration = MeetingDuration;

    if (this.IsParameterBound(nameof(MaxCandidates)))
        body.MaxCandidates = MaxCandidates;

    if (this.IsParameterBound(nameof(IsOrganizerOptional)))
        body.IsOrganizerOptional = IsOrganizerOptional;

    if (this.IsParameterBound(nameof(ReturnSuggestionReasons)))
        body.ReturnSuggestionReasons = ReturnSuggestionReasons;

    if (this.IsParameterBound(nameof(MinimumAttendeePercentage)))
        body.MinimumAttendeePercentage = MinimumAttendeePercentage;
    if (this.IsParameterBound(nameof(Attendees)))
        body.Attendees = Attendees!.ToList();

    if (this.IsParameterBound(nameof(LocationConstraint)))
        body.LocationConstraint = LocationConstraint;

    if (this.IsParameterBound(nameof(TimeConstraint)))
        body.TimeConstraint = TimeConstraint;

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

            Microsoft.Graph.PowerShell.Users.Actions.Client.Models.MeetingTimeSuggestionsResult? result;
            try
            {
                result = client.Users[UserId].FindMeetingTimes.PostAsync(body, requestConfiguration =>
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
