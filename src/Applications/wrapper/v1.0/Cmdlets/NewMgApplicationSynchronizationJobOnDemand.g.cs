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
    [GraphRoute("POST", "/applications/{application-id}/synchronization/jobs/{synchronizationJob-id}/provisionOnDemand")]
    [Cmdlet(VerbsCommon.New, "MgApplicationSynchronizationJobOnDemand", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Applications.Client.Models.StringKeyStringValuePair))]
    public class NewMgApplicationSynchronizationJobOnDemandCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ApplicationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SynchronizationJobId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Applications.Client.Models.SynchronizationJobApplicationParameters[]? Parameters { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SynchronizationJobId, "New"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Applications.Client.Applications.Item.Synchronization.Jobs.Item.ProvisionOnDemand.ProvisionOnDemandPostRequestBody();

    if (this.IsParameterBound(nameof(Parameters)))
        body.Parameters = Parameters!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Applications.Client.Models.StringKeyStringValuePair? result;
            try
            {
                result = client.Applications[ApplicationId].Synchronization.Jobs[SynchronizationJobId].ProvisionOnDemand.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, SynchronizationJobId);
                return;
            }

            WriteObject(result);
        }
    }
}
