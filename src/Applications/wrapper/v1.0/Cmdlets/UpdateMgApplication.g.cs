#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Applications.Client;
using Microsoft.Graph.PowerShell.Applications.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Applications
{
    [GraphRoute("PATCH", "/applications/{application-id}")]
    [Cmdlet(VerbsData.Update, "MgApplication", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.Application))]
    public class UpdateMgApplicationCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ApplicationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DeletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? AppId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ApplicationTemplateId { get; set; }

        [Parameter(Mandatory = false)]
        public string? CreatedByAppId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DefaultRedirectUri { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisabledByMicrosoftStatus { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? GroupMembershipClaims { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? IdentifierUris { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsDeviceOnlyAuthSupported { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsDisabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsFallbackPublicClient { get; set; }

        [Parameter(Mandatory = false)]
        public byte[]? Logo { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid?[]? ManagerApplications { get; set; }

        [Parameter(Mandatory = false)]
        public string? Notes { get; set; }

        [Parameter(Mandatory = false)]
        public bool? Oauth2RequirePostResponse { get; set; }

        [Parameter(Mandatory = false)]
        public string? PublisherDomain { get; set; }

        [Parameter(Mandatory = false)]
        public string? SamlMetadataUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? ServiceManagementReference { get; set; }

        [Parameter(Mandatory = false)]
        public string? SignInAudience { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Tags { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? TokenEncryptionKeyId { get; set; }

        [Parameter(Mandatory = false)]
        public string? UniqueName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.AddIn[]? AddIns { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.ApiApplication? Api { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.AppRole[]? AppRoles { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.AuthenticationBehaviors? AuthenticationBehaviors { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.Certification? Certification { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.InformationalUrl? Info { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.KeyCredential[]? KeyCredentials { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.NativeAuthenticationApisEnabled? NativeAuthenticationApisEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.OptionalClaims? OptionalClaims { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.ParentalControlSettings? ParentalControlSettings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.PasswordCredential[]? PasswordCredentials { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.PublicClientApplication? PublicClient { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.RequestSignatureVerification? RequestSignatureVerification { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.RequiredResourceAccess[]? RequiredResourceAccess { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.ServicePrincipalLockConfiguration? ServicePrincipalLockConfiguration { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.SpaApplication? Spa { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.VerifiedPublisher? VerifiedPublisher { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.WebApplication? Web { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ApplicationId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Applications.Client.Models.Application();

    if (this.IsParameterBound(nameof(DeletedDateTime)))
        body.DeletedDateTime = DeletedDateTime;

    if (this.IsParameterBound(nameof(AppId)))
        body.AppId = AppId;

    if (this.IsParameterBound(nameof(ApplicationTemplateId)))
        body.ApplicationTemplateId = ApplicationTemplateId;

    if (this.IsParameterBound(nameof(CreatedByAppId)))
        body.CreatedByAppId = CreatedByAppId;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(DefaultRedirectUri)))
        body.DefaultRedirectUri = DefaultRedirectUri;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisabledByMicrosoftStatus)))
        body.DisabledByMicrosoftStatus = DisabledByMicrosoftStatus;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(GroupMembershipClaims)))
        body.GroupMembershipClaims = GroupMembershipClaims;

    if (this.IsParameterBound(nameof(IdentifierUris)))
        body.IdentifierUris = IdentifierUris!.ToList();

    if (this.IsParameterBound(nameof(IsDeviceOnlyAuthSupported)))
        body.IsDeviceOnlyAuthSupported = IsDeviceOnlyAuthSupported;

    if (this.IsParameterBound(nameof(IsDisabled)))
        body.IsDisabled = IsDisabled;

    if (this.IsParameterBound(nameof(IsFallbackPublicClient)))
        body.IsFallbackPublicClient = IsFallbackPublicClient;

    if (this.IsParameterBound(nameof(Logo)))
        body.Logo = Logo;

    if (this.IsParameterBound(nameof(ManagerApplications)))
        body.ManagerApplications = ManagerApplications!.ToList();

    if (this.IsParameterBound(nameof(Notes)))
        body.Notes = Notes;

    if (this.IsParameterBound(nameof(Oauth2RequirePostResponse)))
        body.Oauth2RequirePostResponse = Oauth2RequirePostResponse;

    if (this.IsParameterBound(nameof(PublisherDomain)))
        body.PublisherDomain = PublisherDomain;

    if (this.IsParameterBound(nameof(SamlMetadataUrl)))
        body.SamlMetadataUrl = SamlMetadataUrl;

    if (this.IsParameterBound(nameof(ServiceManagementReference)))
        body.ServiceManagementReference = ServiceManagementReference;

    if (this.IsParameterBound(nameof(SignInAudience)))
        body.SignInAudience = SignInAudience;

    if (this.IsParameterBound(nameof(Tags)))
        body.Tags = Tags!.ToList();

    if (this.IsParameterBound(nameof(TokenEncryptionKeyId)))
        body.TokenEncryptionKeyId = TokenEncryptionKeyId;

    if (this.IsParameterBound(nameof(UniqueName)))
        body.UniqueName = UniqueName;

    if (this.IsParameterBound(nameof(AddIns)))
        body.AddIns = AddIns!.ToList();

    if (this.IsParameterBound(nameof(Api)))
        body.Api = Api;

    if (this.IsParameterBound(nameof(AppRoles)))
        body.AppRoles = AppRoles!.ToList();

    if (this.IsParameterBound(nameof(AuthenticationBehaviors)))
        body.AuthenticationBehaviors = AuthenticationBehaviors;

    if (this.IsParameterBound(nameof(Certification)))
        body.Certification = Certification;

    if (this.IsParameterBound(nameof(Info)))
        body.Info = Info;

    if (this.IsParameterBound(nameof(KeyCredentials)))
        body.KeyCredentials = KeyCredentials!.ToList();

    if (this.IsParameterBound(nameof(NativeAuthenticationApisEnabled)))
        body.NativeAuthenticationApisEnabled = NativeAuthenticationApisEnabled;

    if (this.IsParameterBound(nameof(OptionalClaims)))
        body.OptionalClaims = OptionalClaims;

    if (this.IsParameterBound(nameof(ParentalControlSettings)))
        body.ParentalControlSettings = ParentalControlSettings;

    if (this.IsParameterBound(nameof(PasswordCredentials)))
        body.PasswordCredentials = PasswordCredentials!.ToList();

    if (this.IsParameterBound(nameof(PublicClient)))
        body.PublicClient = PublicClient;

    if (this.IsParameterBound(nameof(RequestSignatureVerification)))
        body.RequestSignatureVerification = RequestSignatureVerification;

    if (this.IsParameterBound(nameof(RequiredResourceAccess)))
        body.RequiredResourceAccess = RequiredResourceAccess!.ToList();

    if (this.IsParameterBound(nameof(ServicePrincipalLockConfiguration)))
        body.ServicePrincipalLockConfiguration = ServicePrincipalLockConfiguration;

    if (this.IsParameterBound(nameof(Spa)))
        body.Spa = Spa;

    if (this.IsParameterBound(nameof(VerifiedPublisher)))
        body.VerifiedPublisher = VerifiedPublisher;

    if (this.IsParameterBound(nameof(Web)))
        body.Web = Web;


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

            Microsoft.Graph.PowerShell.Applications.Client.Models.Application? result;
            try
            {
                result = client.Applications[ApplicationId].PatchAsync(body, requestConfiguration =>
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
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, ApplicationId));
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Applications[ApplicationId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, ApplicationId));
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
