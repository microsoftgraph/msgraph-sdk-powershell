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
    [GraphRoute("POST", "/organization/{organization-id}/branding/localizations")]
    [Cmdlet(VerbsCommon.New, "MgOrganizationBrandingLocalization", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.OrganizationalBrandingLocalization))]
    public class NewMgOrganizationBrandingLocalizationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OrganizationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? BackgroundColor { get; set; }

        [Parameter(Mandatory = false)]
        public byte[]? BackgroundImage { get; set; }

        [Parameter(Mandatory = false)]
        public string? BackgroundImageRelativeUrl { get; set; }

        [Parameter(Mandatory = false)]
        public byte[]? BannerLogo { get; set; }

        [Parameter(Mandatory = false)]
        public string? BannerLogoRelativeUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? CdnList { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomAccountResetCredentialsUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomCannotAccessYourAccountText { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomCannotAccessYourAccountUrl { get; set; }

        [Parameter(Mandatory = false)]
        public byte[]? CustomCSS { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomCSSRelativeUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomForgotMyPasswordText { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomPrivacyAndCookiesText { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomPrivacyAndCookiesUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomResetItNowText { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomTermsOfUseText { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomTermsOfUseUrl { get; set; }

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
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.ContentCustomization? ContentCustomization { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.LoginPageLayoutConfiguration? LoginPageLayoutConfiguration { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.LoginPageTextVisibilitySettings? LoginPageTextVisibilitySettings { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OrganizationId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.OrganizationalBrandingLocalization();

    if (this.IsParameterBound(nameof(BackgroundColor)))
        body.BackgroundColor = BackgroundColor;

    if (this.IsParameterBound(nameof(BackgroundImage)))
        body.BackgroundImage = BackgroundImage;

    if (this.IsParameterBound(nameof(BackgroundImageRelativeUrl)))
        body.BackgroundImageRelativeUrl = BackgroundImageRelativeUrl;

    if (this.IsParameterBound(nameof(BannerLogo)))
        body.BannerLogo = BannerLogo;

    if (this.IsParameterBound(nameof(BannerLogoRelativeUrl)))
        body.BannerLogoRelativeUrl = BannerLogoRelativeUrl;

    if (this.IsParameterBound(nameof(CdnList)))
        body.CdnList = CdnList!.ToList();

    if (this.IsParameterBound(nameof(CustomAccountResetCredentialsUrl)))
        body.CustomAccountResetCredentialsUrl = CustomAccountResetCredentialsUrl;

    if (this.IsParameterBound(nameof(CustomCannotAccessYourAccountText)))
        body.CustomCannotAccessYourAccountText = CustomCannotAccessYourAccountText;

    if (this.IsParameterBound(nameof(CustomCannotAccessYourAccountUrl)))
        body.CustomCannotAccessYourAccountUrl = CustomCannotAccessYourAccountUrl;

    if (this.IsParameterBound(nameof(CustomCSS)))
        body.CustomCSS = CustomCSS;

    if (this.IsParameterBound(nameof(CustomCSSRelativeUrl)))
        body.CustomCSSRelativeUrl = CustomCSSRelativeUrl;

    if (this.IsParameterBound(nameof(CustomForgotMyPasswordText)))
        body.CustomForgotMyPasswordText = CustomForgotMyPasswordText;

    if (this.IsParameterBound(nameof(CustomPrivacyAndCookiesText)))
        body.CustomPrivacyAndCookiesText = CustomPrivacyAndCookiesText;

    if (this.IsParameterBound(nameof(CustomPrivacyAndCookiesUrl)))
        body.CustomPrivacyAndCookiesUrl = CustomPrivacyAndCookiesUrl;

    if (this.IsParameterBound(nameof(CustomResetItNowText)))
        body.CustomResetItNowText = CustomResetItNowText;

    if (this.IsParameterBound(nameof(CustomTermsOfUseText)))
        body.CustomTermsOfUseText = CustomTermsOfUseText;

    if (this.IsParameterBound(nameof(CustomTermsOfUseUrl)))
        body.CustomTermsOfUseUrl = CustomTermsOfUseUrl;

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

    if (this.IsParameterBound(nameof(ContentCustomization)))
        body.ContentCustomization = ContentCustomization;

    if (this.IsParameterBound(nameof(LoginPageLayoutConfiguration)))
        body.LoginPageLayoutConfiguration = LoginPageLayoutConfiguration;

    if (this.IsParameterBound(nameof(LoginPageTextVisibilitySettings)))
        body.LoginPageTextVisibilitySettings = LoginPageTextVisibilitySettings;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.OrganizationalBrandingLocalization? result;
            try
            {
                result = client.Organization[OrganizationId].Branding.Localizations.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
