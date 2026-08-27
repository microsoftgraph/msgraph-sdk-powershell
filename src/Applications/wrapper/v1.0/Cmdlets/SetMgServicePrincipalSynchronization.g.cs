#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Applications.Client;
using Microsoft.Graph.PowerShell.Applications.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Applications
{
    [GraphRoute("PUT", "/servicePrincipals/{servicePrincipal-id}/synchronization")]
    [Cmdlet(VerbsCommon.Set, "MgServicePrincipalSynchronization", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.Synchronization))]
    public class SetMgServicePrincipalSynchronizationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ServicePrincipalId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.SynchronizationSecretKeyStringValuePair[]? Secrets { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ServicePrincipalId, "Set"))
                return;

            var body = new Microsoft.Graph.PowerShell.Applications.Client.Models.Synchronization();


    if (this.IsParameterBound(nameof(Secrets)))
        body.Secrets = Secrets!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Applications.Client.Models.Synchronization? result;
            try
            {
                result = client.ServicePrincipals[ServicePrincipalId].Synchronization.PutAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, ServicePrincipalId);
                return;
            }


            if (result is not null)
                WriteObject(result);
        }
    }
}
