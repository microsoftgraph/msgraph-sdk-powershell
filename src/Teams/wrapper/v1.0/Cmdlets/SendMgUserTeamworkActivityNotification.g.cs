#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Teams.Client;
using Microsoft.Graph.PowerShell.Teams.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Teams
{
    [GraphRoute("POST", "/users/{user-id}/teamwork/sendActivityNotification")]
    [Cmdlet(VerbsCommunications.Send, "MgUserTeamworkActivityNotification", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class SendMgUserTeamworkActivityNotificationCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ActivityType { get; set; }

        [Parameter(Mandatory = false)]
        public long? ChainId { get; set; }

        [Parameter(Mandatory = false)]
        public string? TeamsAppId { get; set; }

        [Parameter(Mandatory = false)]
        public string? IconId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TeamworkActivityTopic? Topic { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.ItemBody? PreviewText { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.KeyValuePair[]? TemplateParameters { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Send"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Teams.Client.Users.Item.Teamwork.SendActivityNotification.SendActivityNotificationPostRequestBody();

    if (this.IsParameterBound(nameof(ActivityType)))
        body.ActivityType = ActivityType;

    if (this.IsParameterBound(nameof(ChainId)))
        body.ChainId = ChainId;

    if (this.IsParameterBound(nameof(TeamsAppId)))
        body.TeamsAppId = TeamsAppId;

    if (this.IsParameterBound(nameof(IconId)))
        body.IconId = IconId;
    if (this.IsParameterBound(nameof(Topic)))
        body.Topic = Topic;

    if (this.IsParameterBound(nameof(PreviewText)))
        body.PreviewText = PreviewText;

    if (this.IsParameterBound(nameof(TemplateParameters)))
        body.TemplateParameters = TemplateParameters!.ToList();

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


            try
            {
                client.Users[UserId].Teamwork.SendActivityNotification.PostAsync(body, requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(Headers)))
                        {
                            foreach (System.Collections.DictionaryEntry entry in Headers!)
                                requestConfiguration.Headers.Add(entry.Key.ToString()!, entry.Value?.ToString() ?? string.Empty);
                        }
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, UserId));
                return;
            }

        }
    }
}
