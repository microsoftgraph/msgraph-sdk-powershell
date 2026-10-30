#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("PATCH", "/organization/{organization-id}/branding/themes/{organizationalBrandingTheme-id}/localizations/{organizationalBrandingThemeLocalization-locale}")]
    [Cmdlet(VerbsData.Update, "MgOrganizationBrandingThemeLocalization", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.OrganizationalBrandingThemeLocalization))]
    public class UpdateMgOrganizationBrandingThemeLocalizationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OrganizationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string OrganizationalBrandingThemeId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string OrganizationalBrandingThemeLocalizationLocale { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public byte[]? BackgroundImage { get; set; }

        [Parameter(Mandatory = false)]
        public string? BackgroundImageRelativeUrl { get; set; }

        [Parameter(Mandatory = false)]
        public byte[]? BannerLogo { get; set; }

        [Parameter(Mandatory = false)]
        public string? BannerLogoRelativeUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? CdnHosts { get; set; }

        [Parameter(Mandatory = false)]
        public byte[]? CustomCSS { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomCSSRelativeUrl { get; set; }

        [Parameter(Mandatory = false)]
        public byte[]? Favicon { get; set; }

        [Parameter(Mandatory = false)]
        public string? FaviconRelativeUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? HeaderBackgroundColor { get; set; }

        [Parameter(Mandatory = false)]
        public byte[]? HeaderLogo { get; set; }

        [Parameter(Mandatory = false)]
        public string? HeaderLogoRelativeUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? Locale { get; set; }

        [Parameter(Mandatory = false)]
        public string? PageBackgroundColor { get; set; }

        [Parameter(Mandatory = false)]
        public string? SignInPageText { get; set; }

        [Parameter(Mandatory = false)]
        public byte[]? SquareLogo { get; set; }

        [Parameter(Mandatory = false)]
        public byte[]? SquareLogoDark { get; set; }

        [Parameter(Mandatory = false)]
        public string? SquareLogoDarkRelativeUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? SquareLogoRelativeUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? UsernameHintText { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.LoginPageBrandingVisualElement? AccountResetCredentials { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.LoginPageBrandingVisualElement? CannotAccessYourAccount { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.ContentCustomization? ContentCustomization { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.LoginPageBrandingVisualElement? ForgotMyPassword { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.LoginPageLayoutConfiguration? LoginPageLayoutConfiguration { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.LoginPageBrandingVisualElement? PrivacyAndCookies { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.LoginPageBrandingVisualElement? ResetItNow { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.LoginPageBrandingVisualElement? TermsOfUse { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OrganizationalBrandingThemeLocalizationLocale, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.OrganizationalBrandingThemeLocalization();

    if (this.IsParameterBound(nameof(BackgroundImage)))
        body.BackgroundImage = BackgroundImage;

    if (this.IsParameterBound(nameof(BackgroundImageRelativeUrl)))
        body.BackgroundImageRelativeUrl = BackgroundImageRelativeUrl;

    if (this.IsParameterBound(nameof(BannerLogo)))
        body.BannerLogo = BannerLogo;

    if (this.IsParameterBound(nameof(BannerLogoRelativeUrl)))
        body.BannerLogoRelativeUrl = BannerLogoRelativeUrl;

    if (this.IsParameterBound(nameof(CdnHosts)))
        body.CdnHosts = CdnHosts!.ToList();

    if (this.IsParameterBound(nameof(CustomCSS)))
        body.CustomCSS = CustomCSS;

    if (this.IsParameterBound(nameof(CustomCSSRelativeUrl)))
        body.CustomCSSRelativeUrl = CustomCSSRelativeUrl;

    if (this.IsParameterBound(nameof(Favicon)))
        body.Favicon = Favicon;

    if (this.IsParameterBound(nameof(FaviconRelativeUrl)))
        body.FaviconRelativeUrl = FaviconRelativeUrl;

    if (this.IsParameterBound(nameof(HeaderBackgroundColor)))
        body.HeaderBackgroundColor = HeaderBackgroundColor;

    if (this.IsParameterBound(nameof(HeaderLogo)))
        body.HeaderLogo = HeaderLogo;

    if (this.IsParameterBound(nameof(HeaderLogoRelativeUrl)))
        body.HeaderLogoRelativeUrl = HeaderLogoRelativeUrl;

    if (this.IsParameterBound(nameof(Locale)))
        body.Locale = Locale;

    if (this.IsParameterBound(nameof(PageBackgroundColor)))
        body.PageBackgroundColor = PageBackgroundColor;

    if (this.IsParameterBound(nameof(SignInPageText)))
        body.SignInPageText = SignInPageText;

    if (this.IsParameterBound(nameof(SquareLogo)))
        body.SquareLogo = SquareLogo;

    if (this.IsParameterBound(nameof(SquareLogoDark)))
        body.SquareLogoDark = SquareLogoDark;

    if (this.IsParameterBound(nameof(SquareLogoDarkRelativeUrl)))
        body.SquareLogoDarkRelativeUrl = SquareLogoDarkRelativeUrl;

    if (this.IsParameterBound(nameof(SquareLogoRelativeUrl)))
        body.SquareLogoRelativeUrl = SquareLogoRelativeUrl;

    if (this.IsParameterBound(nameof(UsernameHintText)))
        body.UsernameHintText = UsernameHintText;

    if (this.IsParameterBound(nameof(AccountResetCredentials)))
        body.AccountResetCredentials = AccountResetCredentials;

    if (this.IsParameterBound(nameof(CannotAccessYourAccount)))
        body.CannotAccessYourAccount = CannotAccessYourAccount;

    if (this.IsParameterBound(nameof(ContentCustomization)))
        body.ContentCustomization = ContentCustomization;

    if (this.IsParameterBound(nameof(ForgotMyPassword)))
        body.ForgotMyPassword = ForgotMyPassword;

    if (this.IsParameterBound(nameof(LoginPageLayoutConfiguration)))
        body.LoginPageLayoutConfiguration = LoginPageLayoutConfiguration;

    if (this.IsParameterBound(nameof(PrivacyAndCookies)))
        body.PrivacyAndCookies = PrivacyAndCookies;

    if (this.IsParameterBound(nameof(ResetItNow)))
        body.ResetItNow = ResetItNow;

    if (this.IsParameterBound(nameof(TermsOfUse)))
        body.TermsOfUse = TermsOfUse;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.OrganizationalBrandingThemeLocalization? result;
            try
            {
                result = client.Organization[OrganizationId].Branding.Themes[OrganizationalBrandingThemeId].Localizations[OrganizationalBrandingThemeLocalizationLocale].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, OrganizationalBrandingThemeLocalizationLocale);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Organization[OrganizationId].Branding.Themes[OrganizationalBrandingThemeId].Localizations[OrganizationalBrandingThemeLocalizationLocale].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, OrganizationalBrandingThemeLocalizationLocale);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
