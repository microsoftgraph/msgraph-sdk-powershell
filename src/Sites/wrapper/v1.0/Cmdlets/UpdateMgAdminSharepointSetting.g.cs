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
    [GraphRoute("PATCH", "/admin/sharepoint/settings")]
    [Cmdlet(VerbsData.Update, "MgAdminSharepointSetting", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.SharepointSettings))]
    public class UpdateMgAdminSharepointSettingCommand : PSCmdlet
    {


        [Parameter(Mandatory = false)]
        public global::System.Guid?[]? AllowedDomainGuidsForSyncApp { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? AvailableManagedPathsForSiteCreation { get; set; }

        [Parameter(Mandatory = false)]
        public int? DeletedUserPersonalSiteRetentionPeriodInDays { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ExcludedFileExtensionsForSyncApp { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsCommentingOnSitePagesEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsFileActivityNotificationEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsLegacyAuthProtocolsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsLoopEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsMacSyncAppEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsRequireAcceptingUserToMatchInvitedUserEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsResharingByExternalUsersEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsSharePointMobileNotificationEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsSharePointNewsfeedEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsSiteCreationEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsSiteCreationUIEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsSitePagesCreationEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsSitesStorageLimitAutomatic { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsSyncButtonHiddenOnPersonalSite { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsUnmanagedSyncAppForTenantRestricted { get; set; }

        [Parameter(Mandatory = false)]
        public long? PersonalSiteDefaultStorageLimitInMB { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? SharingAllowedDomainList { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? SharingBlockedDomainList { get; set; }

        [Parameter(Mandatory = false)]
        public string? SiteCreationDefaultManagedPath { get; set; }

        [Parameter(Mandatory = false)]
        public int? SiteCreationDefaultStorageLimitInMB { get; set; }

        [Parameter(Mandatory = false)]
        public string? TenantDefaultTimezone { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.IdleSessionSignOut? IdleSessionSignOut { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.ImageTaggingChoice? ImageTaggingOption { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.SharingCapabilities? SharingCapability { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.SharingDomainRestrictionMode? SharingDomainRestrictionMode { get; set; }




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

            var body = new Microsoft.Graph.PowerShell.Sites.Client.Models.SharepointSettings();

    if (this.IsParameterBound(nameof(AllowedDomainGuidsForSyncApp)))
        body.AllowedDomainGuidsForSyncApp = AllowedDomainGuidsForSyncApp!.ToList();

    if (this.IsParameterBound(nameof(AvailableManagedPathsForSiteCreation)))
        body.AvailableManagedPathsForSiteCreation = AvailableManagedPathsForSiteCreation!.ToList();

    if (this.IsParameterBound(nameof(DeletedUserPersonalSiteRetentionPeriodInDays)))
        body.DeletedUserPersonalSiteRetentionPeriodInDays = DeletedUserPersonalSiteRetentionPeriodInDays;

    if (this.IsParameterBound(nameof(ExcludedFileExtensionsForSyncApp)))
        body.ExcludedFileExtensionsForSyncApp = ExcludedFileExtensionsForSyncApp!.ToList();

    if (this.IsParameterBound(nameof(IsCommentingOnSitePagesEnabled)))
        body.IsCommentingOnSitePagesEnabled = IsCommentingOnSitePagesEnabled;

    if (this.IsParameterBound(nameof(IsFileActivityNotificationEnabled)))
        body.IsFileActivityNotificationEnabled = IsFileActivityNotificationEnabled;

    if (this.IsParameterBound(nameof(IsLegacyAuthProtocolsEnabled)))
        body.IsLegacyAuthProtocolsEnabled = IsLegacyAuthProtocolsEnabled;

    if (this.IsParameterBound(nameof(IsLoopEnabled)))
        body.IsLoopEnabled = IsLoopEnabled;

    if (this.IsParameterBound(nameof(IsMacSyncAppEnabled)))
        body.IsMacSyncAppEnabled = IsMacSyncAppEnabled;

    if (this.IsParameterBound(nameof(IsRequireAcceptingUserToMatchInvitedUserEnabled)))
        body.IsRequireAcceptingUserToMatchInvitedUserEnabled = IsRequireAcceptingUserToMatchInvitedUserEnabled;

    if (this.IsParameterBound(nameof(IsResharingByExternalUsersEnabled)))
        body.IsResharingByExternalUsersEnabled = IsResharingByExternalUsersEnabled;

    if (this.IsParameterBound(nameof(IsSharePointMobileNotificationEnabled)))
        body.IsSharePointMobileNotificationEnabled = IsSharePointMobileNotificationEnabled;

    if (this.IsParameterBound(nameof(IsSharePointNewsfeedEnabled)))
        body.IsSharePointNewsfeedEnabled = IsSharePointNewsfeedEnabled;

    if (this.IsParameterBound(nameof(IsSiteCreationEnabled)))
        body.IsSiteCreationEnabled = IsSiteCreationEnabled;

    if (this.IsParameterBound(nameof(IsSiteCreationUIEnabled)))
        body.IsSiteCreationUIEnabled = IsSiteCreationUIEnabled;

    if (this.IsParameterBound(nameof(IsSitePagesCreationEnabled)))
        body.IsSitePagesCreationEnabled = IsSitePagesCreationEnabled;

    if (this.IsParameterBound(nameof(IsSitesStorageLimitAutomatic)))
        body.IsSitesStorageLimitAutomatic = IsSitesStorageLimitAutomatic;

    if (this.IsParameterBound(nameof(IsSyncButtonHiddenOnPersonalSite)))
        body.IsSyncButtonHiddenOnPersonalSite = IsSyncButtonHiddenOnPersonalSite;

    if (this.IsParameterBound(nameof(IsUnmanagedSyncAppForTenantRestricted)))
        body.IsUnmanagedSyncAppForTenantRestricted = IsUnmanagedSyncAppForTenantRestricted;

    if (this.IsParameterBound(nameof(PersonalSiteDefaultStorageLimitInMB)))
        body.PersonalSiteDefaultStorageLimitInMB = PersonalSiteDefaultStorageLimitInMB;

    if (this.IsParameterBound(nameof(SharingAllowedDomainList)))
        body.SharingAllowedDomainList = SharingAllowedDomainList!.ToList();

    if (this.IsParameterBound(nameof(SharingBlockedDomainList)))
        body.SharingBlockedDomainList = SharingBlockedDomainList!.ToList();

    if (this.IsParameterBound(nameof(SiteCreationDefaultManagedPath)))
        body.SiteCreationDefaultManagedPath = SiteCreationDefaultManagedPath;

    if (this.IsParameterBound(nameof(SiteCreationDefaultStorageLimitInMB)))
        body.SiteCreationDefaultStorageLimitInMB = SiteCreationDefaultStorageLimitInMB;

    if (this.IsParameterBound(nameof(TenantDefaultTimezone)))
        body.TenantDefaultTimezone = TenantDefaultTimezone;

    if (this.IsParameterBound(nameof(IdleSessionSignOut)))
        body.IdleSessionSignOut = IdleSessionSignOut;

    if (this.IsParameterBound(nameof(ImageTaggingOption)))
        body.ImageTaggingOption = ImageTaggingOption;

    if (this.IsParameterBound(nameof(SharingCapability)))
        body.SharingCapability = SharingCapability;

    if (this.IsParameterBound(nameof(SharingDomainRestrictionMode)))
        body.SharingDomainRestrictionMode = SharingDomainRestrictionMode;


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

            Microsoft.Graph.PowerShell.Sites.Client.Models.SharepointSettings? result;
            try
            {
                result = client.Admin.Sharepoint.Settings.PatchAsync(body, requestConfiguration =>
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
                    result = client.Admin.Sharepoint.Settings.GetAsync().GetAwaiter().GetResult();
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
