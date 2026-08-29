#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Applications.Client;
using Microsoft.Graph.PowerShell.Applications.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Applications
{
    [GraphRoute("POST", "/servicePrincipals")]
    [Cmdlet(VerbsCommon.New, "MgServicePrincipal", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.ServicePrincipal))]
    public class NewMgServicePrincipalCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DeletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AccountEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? AlternativeNames { get; set; }

        [Parameter(Mandatory = false)]
        public string? AppDescription { get; set; }

        [Parameter(Mandatory = false)]
        public string? AppDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? AppId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ApplicationTemplateId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? AppOwnerOrganizationId { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AppRoleAssignmentRequired { get; set; }

        [Parameter(Mandatory = false)]
        public string? CreatedByAppId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisabledByMicrosoftStatus { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Homepage { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsDisabled { get; set; }

        [Parameter(Mandatory = false)]
        public string? LoginUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? LogoutUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? Notes { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? NotificationEmailAddresses { get; set; }

        [Parameter(Mandatory = false)]
        public string? PreferredSingleSignOnMode { get; set; }

        [Parameter(Mandatory = false)]
        public string? PreferredTokenSigningKeyThumbprint { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ReplyUrls { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ServicePrincipalNames { get; set; }

        [Parameter(Mandatory = false)]
        public string? ServicePrincipalType { get; set; }

        [Parameter(Mandatory = false)]
        public string? SignInAudience { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Tags { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? TokenEncryptionKeyId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.AddIn[]? AddIns { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.AppRole[]? AppRoles { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.CustomSecurityAttributeValue? CustomSecurityAttributes { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.InformationalUrl? Info { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.KeyCredential[]? KeyCredentials { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.PermissionScope[]? Oauth2PermissionScopes { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.PasswordCredential[]? PasswordCredentials { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.ResourceSpecificPermission[]? ResourceSpecificApplicationPermissions { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.SamlSingleSignOnSettings? SamlSingleSignOnSettings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.VerifiedPublisher? VerifiedPublisher { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Applications.Client.Models.ServicePrincipal();

    if (this.IsParameterBound(nameof(DeletedDateTime)))
        body.DeletedDateTime = DeletedDateTime;

    if (this.IsParameterBound(nameof(AccountEnabled)))
        body.AccountEnabled = AccountEnabled;

    if (this.IsParameterBound(nameof(AlternativeNames)))
        body.AlternativeNames = AlternativeNames!.ToList();

    if (this.IsParameterBound(nameof(AppDescription)))
        body.AppDescription = AppDescription;

    if (this.IsParameterBound(nameof(AppDisplayName)))
        body.AppDisplayName = AppDisplayName;

    if (this.IsParameterBound(nameof(AppId)))
        body.AppId = AppId;

    if (this.IsParameterBound(nameof(ApplicationTemplateId)))
        body.ApplicationTemplateId = ApplicationTemplateId;

    if (this.IsParameterBound(nameof(AppOwnerOrganizationId)))
        body.AppOwnerOrganizationId = AppOwnerOrganizationId;

    if (this.IsParameterBound(nameof(AppRoleAssignmentRequired)))
        body.AppRoleAssignmentRequired = AppRoleAssignmentRequired;

    if (this.IsParameterBound(nameof(CreatedByAppId)))
        body.CreatedByAppId = CreatedByAppId;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisabledByMicrosoftStatus)))
        body.DisabledByMicrosoftStatus = DisabledByMicrosoftStatus;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(Homepage)))
        body.Homepage = Homepage;

    if (this.IsParameterBound(nameof(IsDisabled)))
        body.IsDisabled = IsDisabled;

    if (this.IsParameterBound(nameof(LoginUrl)))
        body.LoginUrl = LoginUrl;

    if (this.IsParameterBound(nameof(LogoutUrl)))
        body.LogoutUrl = LogoutUrl;

    if (this.IsParameterBound(nameof(Notes)))
        body.Notes = Notes;

    if (this.IsParameterBound(nameof(NotificationEmailAddresses)))
        body.NotificationEmailAddresses = NotificationEmailAddresses!.ToList();

    if (this.IsParameterBound(nameof(PreferredSingleSignOnMode)))
        body.PreferredSingleSignOnMode = PreferredSingleSignOnMode;

    if (this.IsParameterBound(nameof(PreferredTokenSigningKeyThumbprint)))
        body.PreferredTokenSigningKeyThumbprint = PreferredTokenSigningKeyThumbprint;

    if (this.IsParameterBound(nameof(ReplyUrls)))
        body.ReplyUrls = ReplyUrls!.ToList();

    if (this.IsParameterBound(nameof(ServicePrincipalNames)))
        body.ServicePrincipalNames = ServicePrincipalNames!.ToList();

    if (this.IsParameterBound(nameof(ServicePrincipalType)))
        body.ServicePrincipalType = ServicePrincipalType;

    if (this.IsParameterBound(nameof(SignInAudience)))
        body.SignInAudience = SignInAudience;

    if (this.IsParameterBound(nameof(Tags)))
        body.Tags = Tags!.ToList();

    if (this.IsParameterBound(nameof(TokenEncryptionKeyId)))
        body.TokenEncryptionKeyId = TokenEncryptionKeyId;

    if (this.IsParameterBound(nameof(AddIns)))
        body.AddIns = AddIns!.ToList();

    if (this.IsParameterBound(nameof(AppRoles)))
        body.AppRoles = AppRoles!.ToList();

    if (this.IsParameterBound(nameof(CustomSecurityAttributes)))
        body.CustomSecurityAttributes = CustomSecurityAttributes;

    if (this.IsParameterBound(nameof(Info)))
        body.Info = Info;

    if (this.IsParameterBound(nameof(KeyCredentials)))
        body.KeyCredentials = KeyCredentials!.ToList();

    if (this.IsParameterBound(nameof(Oauth2PermissionScopes)))
        body.Oauth2PermissionScopes = Oauth2PermissionScopes!.ToList();

    if (this.IsParameterBound(nameof(PasswordCredentials)))
        body.PasswordCredentials = PasswordCredentials!.ToList();

    if (this.IsParameterBound(nameof(ResourceSpecificApplicationPermissions)))
        body.ResourceSpecificApplicationPermissions = ResourceSpecificApplicationPermissions!.ToList();

    if (this.IsParameterBound(nameof(SamlSingleSignOnSettings)))
        body.SamlSingleSignOnSettings = SamlSingleSignOnSettings;

    if (this.IsParameterBound(nameof(VerifiedPublisher)))
        body.VerifiedPublisher = VerifiedPublisher;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Applications.Client.Models.ServicePrincipal? result;
            try
            {
                result = client.ServicePrincipals.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
