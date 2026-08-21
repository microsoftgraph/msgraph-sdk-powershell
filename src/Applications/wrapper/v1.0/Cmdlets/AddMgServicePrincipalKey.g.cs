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
    [GraphRoute("POST", "/servicePrincipals/{servicePrincipal-id}/addKey")]
    [Cmdlet(VerbsCommon.Add, "MgServicePrincipalKey", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.KeyCredential))]
    public class AddMgServicePrincipalKeyCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ServicePrincipalId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Proof { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.KeyCredential? KeyCredential { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.PasswordCredential? PasswordCredential { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ServicePrincipalId, "Add"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Applications.Client.ServicePrincipals.Item.AddKey.AddKeyPostRequestBody();

    if (this.IsParameterBound(nameof(Proof)))
        body.Proof = Proof;
    if (this.IsParameterBound(nameof(KeyCredential)))
        body.KeyCredential = KeyCredential;

    if (this.IsParameterBound(nameof(PasswordCredential)))
        body.PasswordCredential = PasswordCredential;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Applications.Client.Models.KeyCredential? result;
            try
            {
                result = client.ServicePrincipals[ServicePrincipalId].AddKey.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, ServicePrincipalId);
                return;
            }

            WriteObject(result);
        }
    }
}
