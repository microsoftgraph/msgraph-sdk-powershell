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
    [GraphRoute("POST", "/deviceManagement/managedDeviceWindowsOSImages")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementManagedDeviceWindowsOSImage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDeviceWindowsOperatingSystemImage))]
    public class NewMgDeviceManagementManagedDeviceWindowsOSImageCommand : GraphClientCmdlet
    {



        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDeviceWindowsOperatingSystemUpdate[]? AvailableUpdates { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDeviceArchitecture?[]? SupportedArchitectures { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDeviceWindowsOperatingSystemEdition[]? SupportedEditions { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
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
                result = client.DeviceManagement.ManagedDeviceWindowsOSImages.PostAsync(body, requestConfiguration =>
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
