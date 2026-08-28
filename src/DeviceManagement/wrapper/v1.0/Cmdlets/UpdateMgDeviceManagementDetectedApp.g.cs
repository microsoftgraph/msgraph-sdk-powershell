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
    [GraphRoute("PATCH", "/deviceManagement/detectedApps/{detectedApp-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementDetectedApp", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DetectedApp))]
    public class UpdateMgDeviceManagementDetectedAppCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DetectedAppId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? DeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Publisher { get; set; }

        [Parameter(Mandatory = false)]
        public long? SizeInByte { get; set; }

        [Parameter(Mandatory = false)]
        public string? Version { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DetectedAppPlatformType? Platform { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DetectedAppId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DetectedApp();

    if (this.IsParameterBound(nameof(DeviceCount)))
        body.DeviceCount = DeviceCount;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(Publisher)))
        body.Publisher = Publisher;

    if (this.IsParameterBound(nameof(SizeInByte)))
        body.SizeInByte = SizeInByte;

    if (this.IsParameterBound(nameof(Version)))
        body.Version = Version;

    if (this.IsParameterBound(nameof(Platform)))
        body.Platform = Platform;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DetectedApp? result;
            try
            {
                result = client.DeviceManagement.DetectedApps[DetectedAppId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, DetectedAppId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.DetectedApps[DetectedAppId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, DetectedAppId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
