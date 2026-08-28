#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
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
    [GraphRoute("POST", "/directory/publicKeyInfrastructure/certificateBasedAuthConfigurations/{certificateBasedAuthPki-id}/upload")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgUploadDirectoryPublicKeyInfrastructureCertificateBasedAuthConfiguration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgUploadDirectoryPublicKeyInfrastructureCertificateBasedAuthConfigurationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CertificateBasedAuthPkiId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? UploadUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? Sha256FileHash { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CertificateBasedAuthPkiId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.DirectoryNamespace.PublicKeyInfrastructure.CertificateBasedAuthConfigurations.Item.Upload.UploadPostRequestBody();

    if (this.IsParameterBound(nameof(UploadUrl)))
        body.UploadUrl = UploadUrl;

    if (this.IsParameterBound(nameof(Sha256FileHash)))
        body.Sha256FileHash = Sha256FileHash;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Directory.PublicKeyInfrastructure.CertificateBasedAuthConfigurations[CertificateBasedAuthPkiId].Upload.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CertificateBasedAuthPkiId);
                return;
            }

        }
    }
}
