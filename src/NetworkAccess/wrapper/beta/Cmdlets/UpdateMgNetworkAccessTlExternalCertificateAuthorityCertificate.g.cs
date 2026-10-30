#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.NetworkAccess.Client;
using Microsoft.Graph.PowerShell.NetworkAccess.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.NetworkAccess
{
    [GraphRoute("PATCH", "/networkAccess/tls/externalCertificateAuthorityCertificates/{externalCertificateAuthorityCertificate-id}")]
    [Cmdlet(VerbsData.Update, "MgNetworkAccessTlExternalCertificateAuthorityCertificate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.ExternalCertificateAuthorityCertificate))]
    public class UpdateMgNetworkAccessTlExternalCertificateAuthorityCertificateCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ExternalCertificateAuthorityCertificateId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Certificate { get; set; }

        [Parameter(Mandatory = false)]
        public string? CertificateSigningRequest { get; set; }

        [Parameter(Mandatory = false)]
        public string? Chain { get; set; }

        [Parameter(Mandatory = false)]
        public string? CommonName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public string? OrganizationName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.TlsCertificateStatus? Status { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.ValidityDate? Validity { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ExternalCertificateAuthorityCertificateId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.ExternalCertificateAuthorityCertificate();

    if (this.IsParameterBound(nameof(Certificate)))
        body.Certificate = Certificate;

    if (this.IsParameterBound(nameof(CertificateSigningRequest)))
        body.CertificateSigningRequest = CertificateSigningRequest;

    if (this.IsParameterBound(nameof(Chain)))
        body.Chain = Chain;

    if (this.IsParameterBound(nameof(CommonName)))
        body.CommonName = CommonName;

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(OrganizationName)))
        body.OrganizationName = OrganizationName;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(Validity)))
        body.Validity = Validity;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.ExternalCertificateAuthorityCertificate? result;
            try
            {
                result = client.NetworkAccess.Tls.ExternalCertificateAuthorityCertificates[ExternalCertificateAuthorityCertificateId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ExternalCertificateAuthorityCertificateId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.NetworkAccess.Tls.ExternalCertificateAuthorityCertificates[ExternalCertificateAuthorityCertificateId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ExternalCertificateAuthorityCertificateId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
