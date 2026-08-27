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
    [GraphRoute("PATCH", "/directory/publicKeyInfrastructure/certificateBasedAuthConfigurations/{certificateBasedAuthPki-id}/certificateAuthorities/{certificateAuthorityDetail-id}")]
    [Cmdlet(VerbsData.Update, "MgDirectoryPublicKeyInfrastructureCertificateBasedAuthConfigurationCertificateAuthority", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.CertificateAuthorityDetail))]
    public class UpdateMgDirectoryPublicKeyInfrastructureCertificateBasedAuthConfigurationCertificateAuthorityCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CertificateBasedAuthPkiId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string CertificateAuthorityDetailId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DeletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public byte[]? Certificate { get; set; }

        [Parameter(Mandatory = false)]
        public string? CertificateRevocationListUrl { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeltaCertificateRevocationListUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsIssuerHintEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public string? Issuer { get; set; }

        [Parameter(Mandatory = false)]
        public string? IssuerSubjectKeyIdentifier { get; set; }

        [Parameter(Mandatory = false)]
        public string? Thumbprint { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.CertificateAuthorityType? CertificateAuthorityType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CertificateAuthorityDetailId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.CertificateAuthorityDetail();

    if (this.IsParameterBound(nameof(DeletedDateTime)))
        body.DeletedDateTime = DeletedDateTime;

    if (this.IsParameterBound(nameof(Certificate)))
        body.Certificate = Certificate;

    if (this.IsParameterBound(nameof(CertificateRevocationListUrl)))
        body.CertificateRevocationListUrl = CertificateRevocationListUrl;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(DeltaCertificateRevocationListUrl)))
        body.DeltaCertificateRevocationListUrl = DeltaCertificateRevocationListUrl;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(ExpirationDateTime)))
        body.ExpirationDateTime = ExpirationDateTime;

    if (this.IsParameterBound(nameof(IsIssuerHintEnabled)))
        body.IsIssuerHintEnabled = IsIssuerHintEnabled;

    if (this.IsParameterBound(nameof(Issuer)))
        body.Issuer = Issuer;

    if (this.IsParameterBound(nameof(IssuerSubjectKeyIdentifier)))
        body.IssuerSubjectKeyIdentifier = IssuerSubjectKeyIdentifier;

    if (this.IsParameterBound(nameof(Thumbprint)))
        body.Thumbprint = Thumbprint;

    if (this.IsParameterBound(nameof(CertificateAuthorityType)))
        body.CertificateAuthorityType = CertificateAuthorityType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.CertificateAuthorityDetail? result;
            try
            {
                result = client.Directory.PublicKeyInfrastructure.CertificateBasedAuthConfigurations[CertificateBasedAuthPkiId].CertificateAuthorities[CertificateAuthorityDetailId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, CertificateAuthorityDetailId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Directory.PublicKeyInfrastructure.CertificateBasedAuthConfigurations[CertificateBasedAuthPkiId].CertificateAuthorities[CertificateAuthorityDetailId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, CertificateAuthorityDetailId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
