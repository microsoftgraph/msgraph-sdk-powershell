#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement
{
    [GraphRoute("POST", "/deviceManagement/microsoftTunnelSites/{microsoftTunnelSite-id}/microsoftTunnelServers")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementMicrosoftTunnelSiteMicrosoftTunnelServer", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MicrosoftTunnelServer))]
    public class NewMgDeviceManagementMicrosoftTunnelSiteMicrosoftTunnelServerCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MicrosoftTunnelSiteId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AgentImageDigest { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastCheckinDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ServerImageDigest { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MicrosoftTunnelDeploymentMode? DeploymentMode { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MicrosoftTunnelServerHealthStatus? TunnelServerHealthStatus { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MicrosoftTunnelSiteId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MicrosoftTunnelServer();

    if (this.IsParameterBound(nameof(AgentImageDigest)))
        body.AgentImageDigest = AgentImageDigest;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(LastCheckinDateTime)))
        body.LastCheckinDateTime = LastCheckinDateTime;

    if (this.IsParameterBound(nameof(ServerImageDigest)))
        body.ServerImageDigest = ServerImageDigest;

    if (this.IsParameterBound(nameof(DeploymentMode)))
        body.DeploymentMode = DeploymentMode;

    if (this.IsParameterBound(nameof(TunnelServerHealthStatus)))
        body.TunnelServerHealthStatus = TunnelServerHealthStatus;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MicrosoftTunnelServer? result;
            try
            {
                result = client.DeviceManagement.MicrosoftTunnelSites[MicrosoftTunnelSiteId].MicrosoftTunnelServers.PostAsync(body, requestConfiguration =>
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
