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
    [GraphRoute("PATCH", "/policies/authorizationPolicy")]
    [Cmdlet(VerbsData.Update, "MgPolicyAuthorizationPolicy", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthorizationPolicy))]
    public class UpdateMgPolicyAuthorizationPolicyCommand : PSCmdlet
    {


        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DeletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AllowedToSignUpEmailBasedSubscriptions { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AllowedToUseSSPR { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AllowEmailVerifiedUsersToJoinOrganization { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AllowUserConsentForRiskyApps { get; set; }

        [Parameter(Mandatory = false)]
        public bool? BlockMsolPowerShell { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? GuestUserRoleId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AllowInvitesFrom? AllowInvitesFrom { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.DefaultUserRolePermissions? DefaultUserRolePermissions { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthorizationPolicy();

    if (this.IsParameterBound(nameof(DeletedDateTime)))
        body.DeletedDateTime = DeletedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(AllowedToSignUpEmailBasedSubscriptions)))
        body.AllowedToSignUpEmailBasedSubscriptions = AllowedToSignUpEmailBasedSubscriptions;

    if (this.IsParameterBound(nameof(AllowedToUseSSPR)))
        body.AllowedToUseSSPR = AllowedToUseSSPR;

    if (this.IsParameterBound(nameof(AllowEmailVerifiedUsersToJoinOrganization)))
        body.AllowEmailVerifiedUsersToJoinOrganization = AllowEmailVerifiedUsersToJoinOrganization;

    if (this.IsParameterBound(nameof(AllowUserConsentForRiskyApps)))
        body.AllowUserConsentForRiskyApps = AllowUserConsentForRiskyApps;

    if (this.IsParameterBound(nameof(BlockMsolPowerShell)))
        body.BlockMsolPowerShell = BlockMsolPowerShell;

    if (this.IsParameterBound(nameof(GuestUserRoleId)))
        body.GuestUserRoleId = GuestUserRoleId;

    if (this.IsParameterBound(nameof(AllowInvitesFrom)))
        body.AllowInvitesFrom = AllowInvitesFrom;

    if (this.IsParameterBound(nameof(DefaultUserRolePermissions)))
        body.DefaultUserRolePermissions = DefaultUserRolePermissions;


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

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.AuthorizationPolicy? result;
            try
            {
                result = client.Policies.AuthorizationPolicy.PatchAsync(body, requestConfiguration =>
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
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, null));
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Policies.AuthorizationPolicy.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, null));
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
