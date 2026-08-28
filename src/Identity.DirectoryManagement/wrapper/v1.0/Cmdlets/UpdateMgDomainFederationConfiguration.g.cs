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
    [GraphRoute("PATCH", "/domains/{domain-id}/federationConfiguration/{internalDomainFederation-id}")]
    [Cmdlet(VerbsData.Update, "MgDomainFederationConfiguration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.InternalDomainFederation))]
    public class UpdateMgDomainFederationConfigurationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DomainId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string InternalDomainFederationId { get; set; } = string.Empty;

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

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.SystemBrowserEnabledOn? SystemBrowserEnabledOn { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(InternalDomainFederationId, "Update"))
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

    if (this.IsParameterBound(nameof(SystemBrowserEnabledOn)))
        body.SystemBrowserEnabledOn = SystemBrowserEnabledOn;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.InternalDomainFederation? result;
            try
            {
                result = client.Domains[DomainId].FederationConfiguration[InternalDomainFederationId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, InternalDomainFederationId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Domains[DomainId].FederationConfiguration[InternalDomainFederationId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, InternalDomainFederationId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
