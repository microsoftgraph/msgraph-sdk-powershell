#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("GET", "/directory/publicKeyInfrastructure/certificateBasedAuthConfigurations/{certificateBasedAuthPki-id}/certificateAuthorities/{certificateAuthorityDetail-id}")]
    [Cmdlet(VerbsCommon.Get, "MgDirectoryPublicKeyInfrastructureCertificateBasedAuthConfigurationCertificateAuthority_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.CertificateAuthorityDetail))]
    public class GetMgDirectoryPublicKeyInfrastructureCertificateBasedAuthConfigurationCertificateAuthority_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CertificateBasedAuthPkiId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string CertificateAuthorityDetailId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.CertificateAuthorityDetail? result;
            try
            {
                result = client.Directory.PublicKeyInfrastructure.CertificateBasedAuthConfigurations[CertificateBasedAuthPkiId].CertificateAuthorities[CertificateAuthorityDetailId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, CertificateAuthorityDetailId);
                return;
            }

            WriteObject(result);
        }
    }
}
