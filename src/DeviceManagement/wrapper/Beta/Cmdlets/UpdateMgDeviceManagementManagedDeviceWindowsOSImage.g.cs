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
    [GraphRoute("PATCH", "/deviceManagement/managedDeviceWindowsOSImages/{managedDeviceWindowsOperatingSystemImage-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementManagedDeviceWindowsOSImage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDeviceWindowsOperatingSystemImage))]
    public class UpdateMgDeviceManagementManagedDeviceWindowsOSImageCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedDeviceWindowsOperatingSystemImageId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDeviceWindowsOperatingSystemUpdate[]? AvailableUpdates { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDeviceArchitecture?[]? SupportedArchitectures { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDeviceWindowsOperatingSystemEdition[]? SupportedEditions { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ManagedDeviceWindowsOperatingSystemImageId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDeviceWindowsOperatingSystemImage();


    if (this.IsParameterBound(nameof(AvailableUpdates)))
        body.AvailableUpdates = AvailableUpdates!.ToList();

    if (this.IsParameterBound(nameof(SupportedArchitectures)))
        body.SupportedArchitectures = SupportedArchitectures!.ToList();

    if (this.IsParameterBound(nameof(SupportedEditions)))
        body.SupportedEditions = SupportedEditions!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDeviceWindowsOperatingSystemImage? result;
            try
            {
                result = client.DeviceManagement.ManagedDeviceWindowsOSImages[ManagedDeviceWindowsOperatingSystemImageId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ManagedDeviceWindowsOperatingSystemImageId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.ManagedDeviceWindowsOSImages[ManagedDeviceWindowsOperatingSystemImageId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ManagedDeviceWindowsOperatingSystemImageId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
