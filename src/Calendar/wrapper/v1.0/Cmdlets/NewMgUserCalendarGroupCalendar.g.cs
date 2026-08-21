#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Calendar.Client;
using Microsoft.Graph.PowerShell.Calendar.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Calendar
{
    [GraphRoute("POST", "/users/{user-id}/calendarGroups/{calendarGroup-id}/calendars")]
    [Cmdlet(VerbsCommon.New, "MgUserCalendarGroupCalendar", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Calendar.Client.Models.Calendar))]
    public class NewMgUserCalendarGroupCalendarCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string CalendarGroupId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? CanEdit { get; set; }

        [Parameter(Mandatory = false)]
        public bool? CanShare { get; set; }

        [Parameter(Mandatory = false)]
        public bool? CanViewPrivateItems { get; set; }

        [Parameter(Mandatory = false)]
        public string? ChangeKey { get; set; }

        [Parameter(Mandatory = false)]
        public string? HexColor { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsDefaultCalendar { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsRemovable { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsTallyingResponses { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.OnlineMeetingProviderType?[]? AllowedOnlineMeetingProviders { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.CalendarColor? Color { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.OnlineMeetingProviderType? DefaultOnlineMeetingProvider { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Calendar.Client.Models.EmailAddress? Owner { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CalendarGroupId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Calendar.Client.Models.Calendar();

    if (this.IsParameterBound(nameof(CanEdit)))
        body.CanEdit = CanEdit;

    if (this.IsParameterBound(nameof(CanShare)))
        body.CanShare = CanShare;

    if (this.IsParameterBound(nameof(CanViewPrivateItems)))
        body.CanViewPrivateItems = CanViewPrivateItems;

    if (this.IsParameterBound(nameof(ChangeKey)))
        body.ChangeKey = ChangeKey;

    if (this.IsParameterBound(nameof(HexColor)))
        body.HexColor = HexColor;

    if (this.IsParameterBound(nameof(IsDefaultCalendar)))
        body.IsDefaultCalendar = IsDefaultCalendar;

    if (this.IsParameterBound(nameof(IsRemovable)))
        body.IsRemovable = IsRemovable;

    if (this.IsParameterBound(nameof(IsTallyingResponses)))
        body.IsTallyingResponses = IsTallyingResponses;

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(AllowedOnlineMeetingProviders)))
        body.AllowedOnlineMeetingProviders = AllowedOnlineMeetingProviders!.ToList();

    if (this.IsParameterBound(nameof(Color)))
        body.Color = Color;

    if (this.IsParameterBound(nameof(DefaultOnlineMeetingProvider)))
        body.DefaultOnlineMeetingProvider = DefaultOnlineMeetingProvider;

    if (this.IsParameterBound(nameof(Owner)))
        body.Owner = Owner;


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

            Microsoft.Graph.PowerShell.Calendar.Client.Models.Calendar? result;
            try
            {
                result = client.Users[UserId].CalendarGroups[CalendarGroupId].Calendars.PostAsync(body, requestConfiguration =>
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
