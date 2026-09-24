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
    [GraphRoute("PATCH", "/deviceManagement/microsoftTunnelSites/{microsoftTunnelSite-id}/microsoftTunnelConfiguration")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementMicrosoftTunnelSiteMicrosoftTunnelConfiguration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MicrosoftTunnelConfiguration))]
    public class UpdateMgDeviceManagementMicrosoftTunnelSiteMicrosoftTunnelConfigurationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MicrosoftTunnelSiteId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DefaultDomainSuffix { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public bool? DisableUdpConnections { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? DnsServers { get; set; }

        [Parameter(Mandatory = false)]
        public string? Ipv6Network { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastUpdateDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public int? ListenPort { get; set; }

        [Parameter(Mandatory = false)]
        public string? Network { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? RoleScopeTagIds { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? RouteExcludes { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? RouteIncludes { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? RoutesExclude { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? RoutesInclude { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? SplitDNS { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.KeyValuePair[]? AdvancedSettings { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MicrosoftTunnelSiteId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MicrosoftTunnelConfiguration();

    if (this.IsParameterBound(nameof(DefaultDomainSuffix)))
        body.DefaultDomainSuffix = DefaultDomainSuffix;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisableUdpConnections)))
        body.DisableUdpConnections = DisableUdpConnections;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(DnsServers)))
        body.DnsServers = DnsServers!.ToList();

    if (this.IsParameterBound(nameof(Ipv6Network)))
        body.Ipv6Network = Ipv6Network;

    if (this.IsParameterBound(nameof(LastUpdateDateTime)))
        body.LastUpdateDateTime = LastUpdateDateTime;

    if (this.IsParameterBound(nameof(ListenPort)))
        body.ListenPort = ListenPort;

    if (this.IsParameterBound(nameof(Network)))
        body.Network = Network;

    if (this.IsParameterBound(nameof(RoleScopeTagIds)))
        body.RoleScopeTagIds = RoleScopeTagIds!.ToList();

    if (this.IsParameterBound(nameof(RouteExcludes)))
        body.RouteExcludes = RouteExcludes!.ToList();

    if (this.IsParameterBound(nameof(RouteIncludes)))
        body.RouteIncludes = RouteIncludes!.ToList();

    if (this.IsParameterBound(nameof(RoutesExclude)))
        body.RoutesExclude = RoutesExclude!.ToList();

    if (this.IsParameterBound(nameof(RoutesInclude)))
        body.RoutesInclude = RoutesInclude!.ToList();

    if (this.IsParameterBound(nameof(SplitDNS)))
        body.SplitDNS = SplitDNS!.ToList();

    if (this.IsParameterBound(nameof(AdvancedSettings)))
        body.AdvancedSettings = AdvancedSettings!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MicrosoftTunnelConfiguration? result;
            try
            {
                result = client.DeviceManagement.MicrosoftTunnelSites[MicrosoftTunnelSiteId].MicrosoftTunnelConfiguration.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, MicrosoftTunnelSiteId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.MicrosoftTunnelSites[MicrosoftTunnelSiteId].MicrosoftTunnelConfiguration.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, MicrosoftTunnelSiteId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
