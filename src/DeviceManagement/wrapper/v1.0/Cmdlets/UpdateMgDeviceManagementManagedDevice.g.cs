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
    [GraphRoute("PATCH", "/deviceManagement/managedDevices/{managedDevice-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementManagedDevice", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDevice))]
    public class UpdateMgDeviceManagementManagedDeviceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedDeviceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ManagedDeviceName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Notes { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ComplianceState? ComplianceState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceEnrollmentType? DeviceEnrollmentType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceRegistrationState? DeviceRegistrationState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementExchangeAccessState? ExchangeAccessState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementExchangeAccessStateReason? ExchangeAccessStateReason { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDeviceOwnerType? ManagedDeviceOwnerType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagementAgentType? ManagementAgent { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagementState? ManagementState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDevicePartnerReportedHealthState? PartnerReportedThreatState { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ManagedDeviceId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDevice();

    if (this.IsParameterBound(nameof(ManagedDeviceName)))
        body.ManagedDeviceName = ManagedDeviceName;

    if (this.IsParameterBound(nameof(Notes)))
        body.Notes = Notes;

    if (this.IsParameterBound(nameof(ComplianceState)))
        body.ComplianceState = ComplianceState;

    if (this.IsParameterBound(nameof(DeviceEnrollmentType)))
        body.DeviceEnrollmentType = DeviceEnrollmentType;

    if (this.IsParameterBound(nameof(DeviceRegistrationState)))
        body.DeviceRegistrationState = DeviceRegistrationState;

    if (this.IsParameterBound(nameof(ExchangeAccessState)))
        body.ExchangeAccessState = ExchangeAccessState;

    if (this.IsParameterBound(nameof(ExchangeAccessStateReason)))
        body.ExchangeAccessStateReason = ExchangeAccessStateReason;

    if (this.IsParameterBound(nameof(ManagedDeviceOwnerType)))
        body.ManagedDeviceOwnerType = ManagedDeviceOwnerType;

    if (this.IsParameterBound(nameof(ManagementAgent)))
        body.ManagementAgent = ManagementAgent;

    if (this.IsParameterBound(nameof(ManagementState)))
        body.ManagementState = ManagementState;

    if (this.IsParameterBound(nameof(PartnerReportedThreatState)))
        body.PartnerReportedThreatState = PartnerReportedThreatState;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDevice? result;
            try
            {
                result = client.DeviceManagement.ManagedDevices[ManagedDeviceId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ManagedDeviceId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.ManagedDevices[ManagedDeviceId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, ManagedDeviceId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
