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
    [GraphRoute("POST", "/servicePrincipals/{servicePrincipal-id}/updatePasswordSingleSignOnCredentials")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgServicePrincipalUpdatePasswordSingleSignOnCredentials", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgServicePrincipalUpdatePasswordSingleSignOnCredentialsCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ServicePrincipalId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.Credential[]? Credentials { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ServicePrincipalId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Applications.Client.ServicePrincipals.Item.UpdatePasswordSingleSignOnCredentials.UpdatePasswordSingleSignOnCredentialsPostRequestBody();

    if (this.IsParameterBound(nameof(Credentials)))
        body.Credentials = Credentials!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.ServicePrincipals[ServicePrincipalId].UpdatePasswordSingleSignOnCredentials.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ServicePrincipalId);
                return;
            }

        }
    }
}
