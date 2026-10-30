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
    [GraphRoute("PATCH", "/deviceAppManagement/windowsInformationProtectionWipeActions/{windowsInformationProtectionWipeAction-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceAppManagementWindowsInformationProtectionWipeAction", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsInformationProtectionWipeAction))]
    public class UpdateMgDeviceAppManagementWindowsInformationProtectionWipeActionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string WindowsInformationProtectionWipeActionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastCheckInDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? TargetedDeviceMacAddress { get; set; }

        [Parameter(Mandatory = false)]
        public string? TargetedDeviceName { get; set; }

        [Parameter(Mandatory = false)]
        public string? TargetedDeviceRegistrationId { get; set; }

        [Parameter(Mandatory = false)]
        public string? TargetedUserId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ActionState? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(WindowsInformationProtectionWipeActionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsInformationProtectionWipeAction();

    if (this.IsParameterBound(nameof(LastCheckInDateTime)))
        body.LastCheckInDateTime = LastCheckInDateTime;

    if (this.IsParameterBound(nameof(TargetedDeviceMacAddress)))
        body.TargetedDeviceMacAddress = TargetedDeviceMacAddress;

    if (this.IsParameterBound(nameof(TargetedDeviceName)))
        body.TargetedDeviceName = TargetedDeviceName;

    if (this.IsParameterBound(nameof(TargetedDeviceRegistrationId)))
        body.TargetedDeviceRegistrationId = TargetedDeviceRegistrationId;

    if (this.IsParameterBound(nameof(TargetedUserId)))
        body.TargetedUserId = TargetedUserId;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsInformationProtectionWipeAction? result;
            try
            {
                result = client.DeviceAppManagement.WindowsInformationProtectionWipeActions[WindowsInformationProtectionWipeActionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, WindowsInformationProtectionWipeActionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceAppManagement.WindowsInformationProtectionWipeActions[WindowsInformationProtectionWipeActionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, WindowsInformationProtectionWipeActionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
