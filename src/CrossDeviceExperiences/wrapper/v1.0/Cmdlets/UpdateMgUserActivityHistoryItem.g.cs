#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.CrossDeviceExperiences.Client;
using Microsoft.Graph.PowerShell.CrossDeviceExperiences.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.CrossDeviceExperiences
{
    [GraphRoute("PATCH", "/users/{user-id}/activities/{userActivity-id}/historyItems/{activityHistoryItem-id}")]
    [Cmdlet(VerbsData.Update, "MgUserActivityHistoryItem", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CrossDeviceExperiences.Client.Models.ActivityHistoryItem))]
    public class UpdateMgUserActivityHistoryItemCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string UserActivityId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ActivityHistoryItemId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? ActiveDurationSeconds { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastActiveDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? StartedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserTimezone { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CrossDeviceExperiences.Client.Models.Status? Status { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CrossDeviceExperiences.Client.Models.UserActivity? Activity { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ActivityHistoryItemId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.CrossDeviceExperiences.Client.Models.ActivityHistoryItem();

    if (this.IsParameterBound(nameof(ActiveDurationSeconds)))
        body.ActiveDurationSeconds = ActiveDurationSeconds;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(ExpirationDateTime)))
        body.ExpirationDateTime = ExpirationDateTime;

    if (this.IsParameterBound(nameof(LastActiveDateTime)))
        body.LastActiveDateTime = LastActiveDateTime;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(StartedDateTime)))
        body.StartedDateTime = StartedDateTime;

    if (this.IsParameterBound(nameof(UserTimezone)))
        body.UserTimezone = UserTimezone;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(Activity)))
        body.Activity = Activity;


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

            Microsoft.Graph.PowerShell.CrossDeviceExperiences.Client.Models.ActivityHistoryItem? result;
            try
            {
                result = client.Users[UserId].Activities[UserActivityId].HistoryItems[ActivityHistoryItemId].PatchAsync(body, requestConfiguration =>
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
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, ActivityHistoryItemId));
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].Activities[UserActivityId].HistoryItems[ActivityHistoryItemId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, ActivityHistoryItemId));
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
