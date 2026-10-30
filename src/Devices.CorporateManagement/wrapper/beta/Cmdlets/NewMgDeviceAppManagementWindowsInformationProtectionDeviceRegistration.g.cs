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
    [GraphRoute("POST", "/deviceAppManagement/windowsInformationProtectionDeviceRegistrations")]
    [Cmdlet(VerbsCommon.New, "MgDeviceAppManagementWindowsInformationProtectionDeviceRegistration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsInformationProtectionDeviceRegistration))]
    public class NewMgDeviceAppManagementWindowsInformationProtectionDeviceRegistrationCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? DeviceMacAddress { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceName { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceRegistrationId { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceType { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastCheckInDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsInformationProtectionDeviceRegistration();

    if (this.IsParameterBound(nameof(DeviceMacAddress)))
        body.DeviceMacAddress = DeviceMacAddress;

    if (this.IsParameterBound(nameof(DeviceName)))
        body.DeviceName = DeviceName;

    if (this.IsParameterBound(nameof(DeviceRegistrationId)))
        body.DeviceRegistrationId = DeviceRegistrationId;

    if (this.IsParameterBound(nameof(DeviceType)))
        body.DeviceType = DeviceType;

    if (this.IsParameterBound(nameof(LastCheckInDateTime)))
        body.LastCheckInDateTime = LastCheckInDateTime;

    if (this.IsParameterBound(nameof(UserId)))
        body.UserId = UserId;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsInformationProtectionDeviceRegistration? result;
            try
            {
                result = client.DeviceAppManagement.WindowsInformationProtectionDeviceRegistrations.PostAsync(body, requestConfiguration =>
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
