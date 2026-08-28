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
    [GraphRoute("POST", "/deviceManagement/managedDevices/{managedDevice-id}/wipe")]
    [Cmdlet(VerbsCommon.Clear, "MgDeviceManagementManagedDevice", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class ClearMgDeviceManagementManagedDeviceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedDeviceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? KeepEnrollmentData { get; set; }

        [Parameter(Mandatory = false)]
        public bool? KeepUserData { get; set; }

        [Parameter(Mandatory = false)]
        public string? MacOsUnlockCode { get; set; }

        [Parameter(Mandatory = false)]
        public bool? PersistEsimDataPlan { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ManagedDeviceId, "Clear"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.ManagedDevices.Item.Wipe.WipePostRequestBody();

    if (this.IsParameterBound(nameof(KeepEnrollmentData)))
        body.KeepEnrollmentData = KeepEnrollmentData;

    if (this.IsParameterBound(nameof(KeepUserData)))
        body.KeepUserData = KeepUserData;

    if (this.IsParameterBound(nameof(MacOsUnlockCode)))
        body.MacOsUnlockCode = MacOsUnlockCode;

    if (this.IsParameterBound(nameof(PersistEsimDataPlan)))
        body.PersistEsimDataPlan = PersistEsimDataPlan;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceManagement.ManagedDevices[ManagedDeviceId].Wipe.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ManagedDeviceId);
                return;
            }

        }
    }
}
