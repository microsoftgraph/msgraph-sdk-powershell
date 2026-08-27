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
    [GraphRoute("PUT", "/applications/{application-id}/synchronization")]
    [Cmdlet(VerbsCommon.Set, "MgApplicationSynchronization", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.Synchronization))]
    public class SetMgApplicationSynchronizationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ApplicationId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.SynchronizationSecretKeyStringValuePair[]? Secrets { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ApplicationId, "Set"))
                return;

            var body = new Microsoft.Graph.PowerShell.Applications.Client.Models.Synchronization();


    if (this.IsParameterBound(nameof(Secrets)))
        body.Secrets = Secrets!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Applications.Client.Models.Synchronization? result;
            try
            {
                result = client.Applications[ApplicationId].Synchronization.PutAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, ApplicationId);
                return;
            }


            if (result is not null)
                WriteObject(result);
        }
    }
}
