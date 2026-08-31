#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Files.Client;
using Microsoft.Graph.PowerShell.Files.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Files
{
    [GraphRoute("POST", "/drives/{drive-id}/list/subscriptions/{subscription-id}/reauthorize")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgReauthorizeDriveListSubscription", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgReauthorizeDriveListSubscriptionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SubscriptionId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SubscriptionId, "Invoke"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Drives[DriveId].List.Subscriptions[SubscriptionId].Reauthorize.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SubscriptionId);
                return;
            }

        }
    }
}
