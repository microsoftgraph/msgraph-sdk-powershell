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
    [GraphRoute("POST", "/deviceManagement/microsoftTunnelSites/{microsoftTunnelSite-id}/microsoftTunnelServers/{microsoftTunnelServer-id}/getHealthMetricTimeSeries")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementMicrosoftTunnelSiteMicrosoftTunnelServerGetHealthMetricTimeSeries", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.MicrosoftTunnelSites.Item.MicrosoftTunnelServers.Item.GetHealthMetricTimeSeries.GetHealthMetricTimeSeriesPostResponse))]
    public class InvokeMgDeviceManagementMicrosoftTunnelSiteMicrosoftTunnelServerGetHealthMetricTimeSeriesCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MicrosoftTunnelSiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string MicrosoftTunnelServerId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? MetricName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? StartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EndDateTime { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MicrosoftTunnelServerId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.MicrosoftTunnelSites.Item.MicrosoftTunnelServers.Item.GetHealthMetricTimeSeries.GetHealthMetricTimeSeriesPostRequestBody();

    if (this.IsParameterBound(nameof(MetricName)))
        body.MetricName = MetricName;

    if (this.IsParameterBound(nameof(StartDateTime)))
        body.StartDateTime = StartDateTime;

    if (this.IsParameterBound(nameof(EndDateTime)))
        body.EndDateTime = EndDateTime;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.MicrosoftTunnelSites.Item.MicrosoftTunnelServers.Item.GetHealthMetricTimeSeries.GetHealthMetricTimeSeriesPostResponse? result;
            try
            {
                result = client.DeviceManagement.MicrosoftTunnelSites[MicrosoftTunnelSiteId].MicrosoftTunnelServers[MicrosoftTunnelServerId].GetHealthMetricTimeSeries.PostAsGetHealthMetricTimeSeriesPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, MicrosoftTunnelServerId);
                return;
            }

            WriteObject(result);
        }
    }
}
