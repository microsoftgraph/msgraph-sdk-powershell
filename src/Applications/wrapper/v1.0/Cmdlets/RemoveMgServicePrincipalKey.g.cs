#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Applications.Client;
using Microsoft.Graph.PowerShell.Applications.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Applications
{
    [GraphRoute("POST", "/servicePrincipals/{servicePrincipal-id}/removeKey")]
    [Cmdlet(VerbsCommon.Remove, "MgServicePrincipalKey", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class RemoveMgServicePrincipalKeyCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ServicePrincipalId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.Guid? KeyId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Proof { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ServicePrincipalId, "Remove"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Applications.Client.ServicePrincipals.Item.RemoveKey.RemoveKeyPostRequestBody();

    if (this.IsParameterBound(nameof(KeyId)))
        body.KeyId = KeyId;

    if (this.IsParameterBound(nameof(Proof)))
        body.Proof = Proof;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.ServicePrincipals[ServicePrincipalId].RemoveKey.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ServicePrincipalId);
                return;
            }

        }
    }
}
