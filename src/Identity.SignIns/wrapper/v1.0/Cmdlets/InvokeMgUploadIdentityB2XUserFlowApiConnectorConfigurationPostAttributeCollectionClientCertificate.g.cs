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
    [GraphRoute("POST", "/identity/b2xUserFlows/{b2xIdentityUserFlow-id}/apiConnectorConfiguration/postAttributeCollection/uploadClientCertificate")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgUploadIdentityB2XUserFlowApiConnectorConfigurationPostAttributeCollectionClientCertificate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.IdentityApiConnector))]
    public class InvokeMgUploadIdentityB2XUserFlowApiConnectorConfigurationPostAttributeCollectionClientCertificateCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string B2xIdentityUserFlowId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Pkcs12Value { get; set; }

        [Parameter(Mandatory = false)]
        public string? Password { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(B2xIdentityUserFlowId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.SignIns.Client.Identity.B2xUserFlows.Item.ApiConnectorConfiguration.PostAttributeCollection.UploadClientCertificate.UploadClientCertificatePostRequestBody();

    if (this.IsParameterBound(nameof(Pkcs12Value)))
        body.Pkcs12Value = Pkcs12Value;

    if (this.IsParameterBound(nameof(Password)))
        body.Password = Password;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.IdentityApiConnector? result;
            try
            {
                result = client.Identity.B2xUserFlows[B2xIdentityUserFlowId].ApiConnectorConfiguration.PostAttributeCollection.UploadClientCertificate.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, B2xIdentityUserFlowId);
                return;
            }

            WriteObject(result);
        }
    }
}
