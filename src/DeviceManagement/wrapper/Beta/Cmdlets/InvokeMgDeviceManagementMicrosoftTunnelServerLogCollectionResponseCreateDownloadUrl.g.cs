#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement
{
    [GraphRoute("POST", "/deviceManagement/microsoftTunnelServerLogCollectionResponses/{microsoftTunnelServerLogCollectionResponse-id}/createDownloadUrl")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementMicrosoftTunnelServerLogCollectionResponseCreateDownloadUrl", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.MicrosoftTunnelServerLogCollectionResponses.Item.CreateDownloadUrl.CreateDownloadUrlPostResponse))]
    public class InvokeMgDeviceManagementMicrosoftTunnelServerLogCollectionResponseCreateDownloadUrlCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MicrosoftTunnelServerLogCollectionResponseId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MicrosoftTunnelServerLogCollectionResponseId, "Invoke"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.MicrosoftTunnelServerLogCollectionResponses.Item.CreateDownloadUrl.CreateDownloadUrlPostResponse? result;
            try
            {
                result = client.DeviceManagement.MicrosoftTunnelServerLogCollectionResponses[MicrosoftTunnelServerLogCollectionResponseId].CreateDownloadUrl.PostAsCreateDownloadUrlPostResponseAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, MicrosoftTunnelServerLogCollectionResponseId);
                return;
            }

            WriteObject(result);
        }
    }
}
