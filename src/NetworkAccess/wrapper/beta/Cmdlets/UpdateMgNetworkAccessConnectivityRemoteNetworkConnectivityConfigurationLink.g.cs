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
    [GraphRoute("PATCH", "/networkAccess/connectivity/remoteNetworks/{remoteNetwork-id}/connectivityConfiguration/links/{connectivityConfigurationLink-id}")]
    [Cmdlet(VerbsData.Update, "MgNetworkAccessConnectivityRemoteNetworkConnectivityConfigurationLink", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.ConnectivityConfigurationLink))]
    public class UpdateMgNetworkAccessConnectivityRemoteNetworkConnectivityConfigurationLinkCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string RemoteNetworkId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ConnectivityConfigurationLinkId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.LocalConnectivityConfiguration[]? LocalConfigurations { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.PeerConnectivityConfiguration? PeerConfiguration { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ConnectivityConfigurationLinkId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.ConnectivityConfigurationLink();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(LocalConfigurations)))
        body.LocalConfigurations = LocalConfigurations!.ToList();

    if (this.IsParameterBound(nameof(PeerConfiguration)))
        body.PeerConfiguration = PeerConfiguration;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.ConnectivityConfigurationLink? result;
            try
            {
                result = client.NetworkAccess.Connectivity.RemoteNetworks[RemoteNetworkId].ConnectivityConfiguration.Links[ConnectivityConfigurationLinkId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ConnectivityConfigurationLinkId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.NetworkAccess.Connectivity.RemoteNetworks[RemoteNetworkId].ConnectivityConfiguration.Links[ConnectivityConfigurationLinkId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ConnectivityConfigurationLinkId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
