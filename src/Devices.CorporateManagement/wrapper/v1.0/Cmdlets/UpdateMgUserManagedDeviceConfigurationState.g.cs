#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.CorporateManagement
{
    [GraphRoute("PATCH", "/users/{user-id}/managedDevices/{managedDevice-id}/deviceConfigurationStates/{deviceConfigurationState-id}")]
    [Cmdlet(VerbsData.Update, "MgUserManagedDeviceConfigurationState", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.DeviceConfigurationState))]
    public class UpdateMgUserManagedDeviceConfigurationStateCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ManagedDeviceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string DeviceConfigurationStateId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public int? SettingCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? Version { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.PolicyPlatformType? PlatformType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.DeviceConfigurationSettingState[]? SettingStates { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ComplianceStatus? State { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceConfigurationStateId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.DeviceConfigurationState();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(SettingCount)))
        body.SettingCount = SettingCount;

    if (this.IsParameterBound(nameof(Version)))
        body.Version = Version;

    if (this.IsParameterBound(nameof(PlatformType)))
        body.PlatformType = PlatformType;

    if (this.IsParameterBound(nameof(SettingStates)))
        body.SettingStates = SettingStates!.ToList();

    if (this.IsParameterBound(nameof(State)))
        body.State = State;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.DeviceConfigurationState? result;
            try
            {
                result = client.Users[UserId].ManagedDevices[ManagedDeviceId].DeviceConfigurationStates[DeviceConfigurationStateId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, DeviceConfigurationStateId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].ManagedDevices[ManagedDeviceId].DeviceConfigurationStates[DeviceConfigurationStateId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, DeviceConfigurationStateId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
