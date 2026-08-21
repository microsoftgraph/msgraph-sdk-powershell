#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.SignIns
{
    [GraphRoute("POST", "/identity/apiConnectors/{identityApiConnector-id}/uploadClientCertificate")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgUploadIdentityApiConnectorClientCertificate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.IdentityApiConnector))]
    public class InvokeMgUploadIdentityApiConnectorClientCertificateCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string IdentityApiConnectorId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Pkcs12Value { get; set; }

        [Parameter(Mandatory = false)]
        public string? Password { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(IdentityApiConnectorId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.SignIns.Client.Identity.ApiConnectors.Item.UploadClientCertificate.UploadClientCertificatePostRequestBody();

    if (this.IsParameterBound(nameof(Pkcs12Value)))
        body.Pkcs12Value = Pkcs12Value;

    if (this.IsParameterBound(nameof(Password)))
        body.Password = Password;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.IdentityApiConnector? result;
            try
            {
                result = client.Identity.ApiConnectors[IdentityApiConnectorId].UploadClientCertificate.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, IdentityApiConnectorId);
                return;
            }

            WriteObject(result);
        }
    }
}
