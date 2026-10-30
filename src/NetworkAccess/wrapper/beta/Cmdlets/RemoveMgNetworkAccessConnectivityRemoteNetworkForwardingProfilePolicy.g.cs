#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.NetworkAccess.Client;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.NetworkAccess
{
    [GraphRoute("DELETE", "/networkAccess/connectivity/remoteNetworks/{remoteNetwork-id}/forwardingProfiles/{forwardingProfile-id}/policies/{policyLink-id}")]
    [Cmdlet(VerbsCommon.Remove, "MgNetworkAccessConnectivityRemoteNetworkForwardingProfilePolicy", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    public class RemoveMgNetworkAccessConnectivityRemoteNetworkForwardingProfilePolicyCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string RemoteNetworkId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ForwardingProfileId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string PolicyLinkId { get; set; } = string.Empty;


        [Parameter(Mandatory = false,
            HelpMessage = "Sets the 'If-Match' request header (for example an ETag for optimistic concurrency; some Graph APIs require it even where the spec marks it optional).")]
        public string? IfMatch { get; set; }




        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PolicyLinkId, "Remove"))
                return;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            // DeleteAsync returns a plain Task: a standard delete response has no body.
            try
            {
                client.NetworkAccess.Connectivity.RemoteNetworks[RemoteNetworkId].ForwardingProfiles[ForwardingProfileId].Policies[PolicyLinkId].DeleteAsync(requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(IfMatch)))
                            requestConfiguration.Headers.Add("If-Match", IfMatch!);

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PolicyLinkId);
                return;
            }
        }
    }
}
