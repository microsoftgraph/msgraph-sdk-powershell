#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Sites.Client;
using Microsoft.Graph.PowerShell.Sites.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Sites
{
    [GraphRoute("PATCH", "/sites/{site-id}/lists/{list-id}/subscriptions/{subscription-id}")]
    [Cmdlet(VerbsData.Update, "MgSiteListSubscription", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.Subscription))]
    public class UpdateMgSiteListSubscriptionCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ListId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string SubscriptionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ApplicationId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ChangeType { get; set; }

        [Parameter(Mandatory = false)]
        public string? ClientState { get; set; }

        [Parameter(Mandatory = false)]
        public string? CreatorId { get; set; }

        [Parameter(Mandatory = false)]
        public string? EncryptionCertificate { get; set; }

        [Parameter(Mandatory = false)]
        public string? EncryptionCertificateId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IncludeResourceData { get; set; }

        [Parameter(Mandatory = false)]
        public string? LatestSupportedTlsVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? LifecycleNotificationUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? NotificationQueryOptions { get; set; }

        [Parameter(Mandatory = false)]
        public string? NotificationUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? NotificationUrlAppId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Resource { get; set; }





        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SubscriptionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Sites.Client.Models.Subscription();

    if (this.IsParameterBound(nameof(ApplicationId)))
        body.ApplicationId = ApplicationId;

    if (this.IsParameterBound(nameof(ChangeType)))
        body.ChangeType = ChangeType;

    if (this.IsParameterBound(nameof(ClientState)))
        body.ClientState = ClientState;

    if (this.IsParameterBound(nameof(CreatorId)))
        body.CreatorId = CreatorId;

    if (this.IsParameterBound(nameof(EncryptionCertificate)))
        body.EncryptionCertificate = EncryptionCertificate;

    if (this.IsParameterBound(nameof(EncryptionCertificateId)))
        body.EncryptionCertificateId = EncryptionCertificateId;

    if (this.IsParameterBound(nameof(ExpirationDateTime)))
        body.ExpirationDateTime = ExpirationDateTime;

    if (this.IsParameterBound(nameof(IncludeResourceData)))
        body.IncludeResourceData = IncludeResourceData;

    if (this.IsParameterBound(nameof(LatestSupportedTlsVersion)))
        body.LatestSupportedTlsVersion = LatestSupportedTlsVersion;

    if (this.IsParameterBound(nameof(LifecycleNotificationUrl)))
        body.LifecycleNotificationUrl = LifecycleNotificationUrl;

    if (this.IsParameterBound(nameof(NotificationQueryOptions)))
        body.NotificationQueryOptions = NotificationQueryOptions;

    if (this.IsParameterBound(nameof(NotificationUrl)))
        body.NotificationUrl = NotificationUrl;

    if (this.IsParameterBound(nameof(NotificationUrlAppId)))
        body.NotificationUrlAppId = NotificationUrlAppId;

    if (this.IsParameterBound(nameof(Resource)))
        body.Resource = Resource;



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

            Microsoft.Graph.PowerShell.Sites.Client.Models.Subscription? result;
            try
            {
                result = client.Sites[SiteId].Lists[ListId].Subscriptions[SubscriptionId].PatchAsync(body, requestConfiguration =>
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
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, SubscriptionId));
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Sites[SiteId].Lists[ListId].Subscriptions[SubscriptionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, SubscriptionId));
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
