#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("POST", "/domains/{domain-id}/federationConfiguration")]
    [Cmdlet(VerbsCommon.New, "MgDomainFederationConfiguration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.InternalDomainFederation))]
    public class NewMgDomainFederationConfigurationCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DomainId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? IssuerUri { get; set; }

        [Parameter(Mandatory = false)]
        public string? MetadataExchangeUri { get; set; }

        [Parameter(Mandatory = false)]
        public string? PassiveSignInUri { get; set; }

        [Parameter(Mandatory = false)]
        public string? SigningCertificate { get; set; }

        [Parameter(Mandatory = false)]
        public string? ActiveSignInUri { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsSignedAuthenticationRequestRequired { get; set; }

        [Parameter(Mandatory = false)]
        public string? NextSigningCertificate { get; set; }

        [Parameter(Mandatory = false)]
        public string? PasswordResetUri { get; set; }

        [Parameter(Mandatory = false)]
        public string? SignOutUri { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.AuthenticationProtocol? PreferredAuthenticationProtocol { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.FederatedIdpMfaBehavior? FederatedIdpMfaBehavior { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.PromptLoginBehavior? PromptLoginBehavior { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.SigningCertificateUpdateStatus? SigningCertificateUpdateStatus { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DomainId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.InternalDomainFederation();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IssuerUri)))
        body.IssuerUri = IssuerUri;

    if (this.IsParameterBound(nameof(MetadataExchangeUri)))
        body.MetadataExchangeUri = MetadataExchangeUri;

    if (this.IsParameterBound(nameof(PassiveSignInUri)))
        body.PassiveSignInUri = PassiveSignInUri;

    if (this.IsParameterBound(nameof(SigningCertificate)))
        body.SigningCertificate = SigningCertificate;

    if (this.IsParameterBound(nameof(ActiveSignInUri)))
        body.ActiveSignInUri = ActiveSignInUri;

    if (this.IsParameterBound(nameof(IsSignedAuthenticationRequestRequired)))
        body.IsSignedAuthenticationRequestRequired = IsSignedAuthenticationRequestRequired;

    if (this.IsParameterBound(nameof(NextSigningCertificate)))
        body.NextSigningCertificate = NextSigningCertificate;

    if (this.IsParameterBound(nameof(PasswordResetUri)))
        body.PasswordResetUri = PasswordResetUri;

    if (this.IsParameterBound(nameof(SignOutUri)))
        body.SignOutUri = SignOutUri;

    if (this.IsParameterBound(nameof(PreferredAuthenticationProtocol)))
        body.PreferredAuthenticationProtocol = PreferredAuthenticationProtocol;

    if (this.IsParameterBound(nameof(FederatedIdpMfaBehavior)))
        body.FederatedIdpMfaBehavior = FederatedIdpMfaBehavior;

    if (this.IsParameterBound(nameof(PromptLoginBehavior)))
        body.PromptLoginBehavior = PromptLoginBehavior;

    if (this.IsParameterBound(nameof(SigningCertificateUpdateStatus)))
        body.SigningCertificateUpdateStatus = SigningCertificateUpdateStatus;


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

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.InternalDomainFederation? result;
            try
            {
                result = client.Domains[DomainId].FederationConfiguration.PostAsync(body, requestConfiguration =>
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
