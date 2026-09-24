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
    [GraphRoute("PATCH", "/deviceManagement/microsoftTunnelSites/{microsoftTunnelSite-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementMicrosoftTunnelSite", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MicrosoftTunnelSite))]
    public class UpdateMgDeviceManagementMicrosoftTunnelSiteCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MicrosoftTunnelSiteId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? InternalNetworkProbeUrl { get; set; }

        [Parameter(Mandatory = false)]
        public string? PublicAddress { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? RoleScopeTagIds { get; set; }

        [Parameter(Mandatory = false)]
        public bool? UpgradeAutomatically { get; set; }

        [Parameter(Mandatory = false)]
        public bool? UpgradeAvailable { get; set; }

        [Parameter(Mandatory = false)]
        public global::Microsoft.Kiota.Abstractions.Time? UpgradeWindowEndTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::Microsoft.Kiota.Abstractions.Time? UpgradeWindowStartTime { get; set; }

        [Parameter(Mandatory = false)]
        public int? UpgradeWindowUtcOffsetInMinutes { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MicrosoftTunnelSiteId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MicrosoftTunnelSite();

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(InternalNetworkProbeUrl)))
        body.InternalNetworkProbeUrl = InternalNetworkProbeUrl;

    if (this.IsParameterBound(nameof(PublicAddress)))
        body.PublicAddress = PublicAddress;

    if (this.IsParameterBound(nameof(RoleScopeTagIds)))
        body.RoleScopeTagIds = RoleScopeTagIds!.ToList();

    if (this.IsParameterBound(nameof(UpgradeAutomatically)))
        body.UpgradeAutomatically = UpgradeAutomatically;

    if (this.IsParameterBound(nameof(UpgradeAvailable)))
        body.UpgradeAvailable = UpgradeAvailable;

    if (this.IsParameterBound(nameof(UpgradeWindowEndTime)))
        body.UpgradeWindowEndTime = UpgradeWindowEndTime;

    if (this.IsParameterBound(nameof(UpgradeWindowStartTime)))
        body.UpgradeWindowStartTime = UpgradeWindowStartTime;

    if (this.IsParameterBound(nameof(UpgradeWindowUtcOffsetInMinutes)))
        body.UpgradeWindowUtcOffsetInMinutes = UpgradeWindowUtcOffsetInMinutes;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MicrosoftTunnelSite? result;
            try
            {
                result = client.DeviceManagement.MicrosoftTunnelSites[MicrosoftTunnelSiteId].PatchAsync(body, requestConfiguration =>
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
                    result = client.DeviceManagement.MicrosoftTunnelSites[MicrosoftTunnelSiteId].GetAsync().GetAwaiter().GetResult();
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
