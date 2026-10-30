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
    [GraphRoute("POST", "/networkAccess/connectivity/remoteNetworks/{remoteNetwork-id}/connectivityConfiguration/links")]
    [Cmdlet(VerbsCommon.New, "MgNetworkAccessConnectivityRemoteNetworkConnectivityConfigurationLink", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.ConnectivityConfigurationLink))]
    public class NewMgNetworkAccessConnectivityRemoteNetworkConnectivityConfigurationLinkCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string RemoteNetworkId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.LocalConnectivityConfiguration[]? LocalConfigurations { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.Networkaccess.PeerConnectivityConfiguration? PeerConfiguration { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(RemoteNetworkId, "New"))
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
                result = client.NetworkAccess.Connectivity.RemoteNetworks[RemoteNetworkId].ConnectivityConfiguration.Links.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
