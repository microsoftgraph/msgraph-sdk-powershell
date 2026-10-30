#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.NetworkAccess.Client;
using Microsoft.Graph.PowerShell.NetworkAccess.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.NetworkAccess
{
    [GraphRoute("GET", "/networkAccess/connectivity/remoteNetworks/{remoteNetwork-id}/forwardingProfiles/{forwardingProfile-id}/servicePrincipal")]
    [Cmdlet(VerbsCommon.Get, "MgNetworkAccessConnectivityRemoteNetworkForwardingProfileServicePrincipal")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.ServicePrincipal))]
    public class GetMgNetworkAccessConnectivityRemoteNetworkForwardingProfileServicePrincipalCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string RemoteNetworkId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ForwardingProfileId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.NetworkAccess.Client.Models.ServicePrincipal? result;
            try
            {
                result = client.NetworkAccess.Connectivity.RemoteNetworks[RemoteNetworkId].ForwardingProfiles[ForwardingProfileId].ServicePrincipal.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ForwardingProfileId);
                return;
            }

            WriteObject(result);
        }
    }
}
