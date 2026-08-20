#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.SignIns
{
    [GraphRoute("POST", "/invitations")]
    [Cmdlet(VerbsCommon.New, "MgInvitation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.Invitation))]
    public class NewMgInvitationCommand : PSCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? InvitedUserDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? InvitedUserEmailAddress { get; set; }

        [Parameter(Mandatory = false)]
        public string? InvitedUserType { get; set; }

        [Parameter(Mandatory = false)]
        public string? InviteRedeemUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? InviteRedirectUrl { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ResetRedemption { get; set; }

        [Parameter(Mandatory = false)]
        public bool? SendInvitationMessage { get; set; }

        [Parameter(Mandatory = false)]
        public string? Status { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.InvitedUserMessageInfo? InvitedUserMessageInfo { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.Invitation();

    if (this.IsParameterBound(nameof(InvitedUserDisplayName)))
        body.InvitedUserDisplayName = InvitedUserDisplayName;

    if (this.IsParameterBound(nameof(InvitedUserEmailAddress)))
        body.InvitedUserEmailAddress = InvitedUserEmailAddress;

    if (this.IsParameterBound(nameof(InvitedUserType)))
        body.InvitedUserType = InvitedUserType;

    if (this.IsParameterBound(nameof(InviteRedeemUrl)))
        body.InviteRedeemUrl = InviteRedeemUrl;

    if (this.IsParameterBound(nameof(InviteRedirectUrl)))
        body.InviteRedirectUrl = InviteRedirectUrl;

    if (this.IsParameterBound(nameof(ResetRedemption)))
        body.ResetRedemption = ResetRedemption;

    if (this.IsParameterBound(nameof(SendInvitationMessage)))
        body.SendInvitationMessage = SendInvitationMessage;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(InvitedUserMessageInfo)))
        body.InvitedUserMessageInfo = InvitedUserMessageInfo;


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

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.Invitation? result;
            try
            {
                result = client.Invitations.PostAsync(body, requestConfiguration =>
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
