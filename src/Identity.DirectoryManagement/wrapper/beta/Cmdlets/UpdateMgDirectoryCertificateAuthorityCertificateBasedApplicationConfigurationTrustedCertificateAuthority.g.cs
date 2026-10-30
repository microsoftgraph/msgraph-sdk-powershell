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
    [GraphRoute("PATCH", "/directory/certificateAuthorities/certificateBasedApplicationConfigurations/{certificateBasedApplicationConfiguration-id}/trustedCertificateAuthorities/{certificateAuthorityAsEntity-id}")]
    [Cmdlet(VerbsData.Update, "MgDirectoryCertificateAuthorityCertificateBasedApplicationConfigurationTrustedCertificateAuthority", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.CertificateAuthorityAsEntity))]
    public class UpdateMgDirectoryCertificateAuthorityCertificateBasedApplicationConfigurationTrustedCertificateAuthorityCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CertificateBasedApplicationConfigurationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string CertificateAuthorityAsEntityId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public byte[]? Certificate { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsRootAuthority { get; set; }

        [Parameter(Mandatory = false)]
        public string? Issuer { get; set; }

        [Parameter(Mandatory = false)]
        public string? IssuerSubjectKeyIdentifier { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CertificateAuthorityAsEntityId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.CertificateAuthorityAsEntity();

    if (this.IsParameterBound(nameof(Certificate)))
        body.Certificate = Certificate;

    if (this.IsParameterBound(nameof(IsRootAuthority)))
        body.IsRootAuthority = IsRootAuthority;

    if (this.IsParameterBound(nameof(Issuer)))
        body.Issuer = Issuer;

    if (this.IsParameterBound(nameof(IssuerSubjectKeyIdentifier)))
        body.IssuerSubjectKeyIdentifier = IssuerSubjectKeyIdentifier;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.CertificateAuthorityAsEntity? result;
            try
            {
                result = client.Directory.CertificateAuthorities.CertificateBasedApplicationConfigurations[CertificateBasedApplicationConfigurationId].TrustedCertificateAuthorities[CertificateAuthorityAsEntityId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CertificateAuthorityAsEntityId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Directory.CertificateAuthorities.CertificateBasedApplicationConfigurations[CertificateBasedApplicationConfigurationId].TrustedCertificateAuthorities[CertificateAuthorityAsEntityId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, CertificateAuthorityAsEntityId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
