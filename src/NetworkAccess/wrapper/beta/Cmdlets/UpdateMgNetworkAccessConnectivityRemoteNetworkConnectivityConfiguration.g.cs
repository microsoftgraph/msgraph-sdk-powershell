#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.NetworkAccess.Client;
using Microsoft.Graph.PowerShell.NetworkAccess.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.NetworkAccess
{
    [GraphRoute("PATCH", "/networkAccess/connectivity/remoteNetworks/{remoteNetwork-id}/connectivityConfiguration")]
    [Cmdlet(VerbsData.Update, "MgNetworkAccessConnectivityRemoteNetworkConnectivityConfiguration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.RemoteNetworkConnectivityConfiguration))]
    public class UpdateMgNetworkAccessConnectivityRemoteNetworkConnectivityConfigurationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string RemoteNetworkId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? RemoteNetworkId1 { get; set; }

        [Parameter(Mandatory = false)]
        public string? RemoteNetworkName { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(RemoteNetworkId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.RemoteNetworkConnectivityConfiguration();

    if (this.IsParameterBound(nameof(RemoteNetworkId1)))
        body.RemoteNetworkId = RemoteNetworkId1;

    if (this.IsParameterBound(nameof(RemoteNetworkName)))
        body.RemoteNetworkName = RemoteNetworkName;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.RemoteNetworkConnectivityConfiguration? result;
            try
            {
                result = client.NetworkAccess.Connectivity.RemoteNetworks[RemoteNetworkId].ConnectivityConfiguration.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, RemoteNetworkId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.NetworkAccess.Connectivity.RemoteNetworks[RemoteNetworkId].ConnectivityConfiguration.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, RemoteNetworkId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
