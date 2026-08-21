#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Sites.Client;
using Microsoft.Graph.PowerShell.Sites.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Sites
{
    [GraphRoute("PATCH", "/sites/{site-id}/lists/{list-id}/subscriptions/{subscription-id}")]
    [Cmdlet(VerbsData.Update, "MgSiteListSubscription", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.Subscription))]
    public class UpdateMgSiteListSubscriptionCommand : GraphClientCmdlet
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



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.Subscription? result;
            try
            {
                result = client.Sites[SiteId].Lists[ListId].Subscriptions[SubscriptionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, SubscriptionId);
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
                    ThrowGraphRequestFailed(ex, SubscriptionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
