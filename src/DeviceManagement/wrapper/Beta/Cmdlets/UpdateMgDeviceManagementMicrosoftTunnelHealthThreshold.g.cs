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
    [GraphRoute("PATCH", "/deviceManagement/microsoftTunnelHealthThresholds/{microsoftTunnelHealthThreshold-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementMicrosoftTunnelHealthThreshold", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MicrosoftTunnelHealthThreshold))]
    public class UpdateMgDeviceManagementMicrosoftTunnelHealthThresholdCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MicrosoftTunnelHealthThresholdId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public long? DefaultHealthyThreshold { get; set; }

        [Parameter(Mandatory = false)]
        public long? DefaultUnhealthyThreshold { get; set; }

        [Parameter(Mandatory = false)]
        public long? HealthyThreshold { get; set; }

        [Parameter(Mandatory = false)]
        public long? UnhealthyThreshold { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MicrosoftTunnelHealthThresholdId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MicrosoftTunnelHealthThreshold();

    if (this.IsParameterBound(nameof(DefaultHealthyThreshold)))
        body.DefaultHealthyThreshold = DefaultHealthyThreshold;

    if (this.IsParameterBound(nameof(DefaultUnhealthyThreshold)))
        body.DefaultUnhealthyThreshold = DefaultUnhealthyThreshold;

    if (this.IsParameterBound(nameof(HealthyThreshold)))
        body.HealthyThreshold = HealthyThreshold;

    if (this.IsParameterBound(nameof(UnhealthyThreshold)))
        body.UnhealthyThreshold = UnhealthyThreshold;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.MicrosoftTunnelHealthThreshold? result;
            try
            {
                result = client.DeviceManagement.MicrosoftTunnelHealthThresholds[MicrosoftTunnelHealthThresholdId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, MicrosoftTunnelHealthThresholdId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.MicrosoftTunnelHealthThresholds[MicrosoftTunnelHealthThresholdId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, MicrosoftTunnelHealthThresholdId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
