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
    [GraphRoute("POST", "/applications/{application-id}/synchronization/jobs/{synchronizationJob-id}/start")]
    [Cmdlet(VerbsLifecycle.Start, "MgApplicationSynchronizationJob", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class StartMgApplicationSynchronizationJobCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ApplicationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SynchronizationJobId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SynchronizationJobId, "Start"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Applications[ApplicationId].Synchronization.Jobs[SynchronizationJobId].Start.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SynchronizationJobId);
                return;
            }

        }
    }
}
