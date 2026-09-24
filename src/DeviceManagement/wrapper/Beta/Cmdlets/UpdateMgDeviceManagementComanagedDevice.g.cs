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
    [GraphRoute("PATCH", "/deviceManagement/comanagedDevices/{managedDevice-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementComanagedDevice", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDevice))]
    public class UpdateMgDeviceManagementComanagedDeviceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedDeviceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? DeviceFirmwareConfigurationInterfaceManaged { get; set; }

        [Parameter(Mandatory = false)]
        public string? ManagedDeviceName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Notes { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? RoleScopeTagIds { get; set; }

        [Parameter(Mandatory = false)]
        public string? SkuFamily { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ChassisType? ChassisType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ChromeOSDeviceProperty[]? ChromeOSDeviceInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.CloudPcRemoteActionResult[]? CloudPcRemoteActionResults { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ComplianceState? ComplianceState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ConfigurationManagerClientHealthState? ConfigurationManagerClientHealthState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ConfigurationManagerClientInformation? ConfigurationManagerClientInformation { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceEnrollmentType? DeviceEnrollmentType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceRegistrationState? DeviceRegistrationState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceType? DeviceType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementExchangeAccessState? ExchangeAccessState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementExchangeAccessStateReason? ExchangeAccessStateReason { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.JoinType? JoinType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.LostModeState? LostModeState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDeviceOwnerType? ManagedDeviceOwnerType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagementAgentType? ManagementAgent { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDeviceManagementFeatures? ManagementFeatures { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagementState? ManagementState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.OwnerType? OwnerType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDevicePartnerReportedHealthState? PartnerReportedThreatState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDeviceArchitecture? ProcessorArchitecture { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ManagedDeviceId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDevice();

    if (this.IsParameterBound(nameof(DeviceFirmwareConfigurationInterfaceManaged)))
        body.DeviceFirmwareConfigurationInterfaceManaged = DeviceFirmwareConfigurationInterfaceManaged;

    if (this.IsParameterBound(nameof(ManagedDeviceName)))
        body.ManagedDeviceName = ManagedDeviceName;

    if (this.IsParameterBound(nameof(Notes)))
        body.Notes = Notes;

    if (this.IsParameterBound(nameof(RoleScopeTagIds)))
        body.RoleScopeTagIds = RoleScopeTagIds!.ToList();

    if (this.IsParameterBound(nameof(SkuFamily)))
        body.SkuFamily = SkuFamily;

    if (this.IsParameterBound(nameof(ChassisType)))
        body.ChassisType = ChassisType;

    if (this.IsParameterBound(nameof(ChromeOSDeviceInfo)))
        body.ChromeOSDeviceInfo = ChromeOSDeviceInfo!.ToList();

    if (this.IsParameterBound(nameof(CloudPcRemoteActionResults)))
        body.CloudPcRemoteActionResults = CloudPcRemoteActionResults!.ToList();

    if (this.IsParameterBound(nameof(ComplianceState)))
        body.ComplianceState = ComplianceState;

    if (this.IsParameterBound(nameof(ConfigurationManagerClientHealthState)))
        body.ConfigurationManagerClientHealthState = ConfigurationManagerClientHealthState;

    if (this.IsParameterBound(nameof(ConfigurationManagerClientInformation)))
        body.ConfigurationManagerClientInformation = ConfigurationManagerClientInformation;

    if (this.IsParameterBound(nameof(DeviceEnrollmentType)))
        body.DeviceEnrollmentType = DeviceEnrollmentType;

    if (this.IsParameterBound(nameof(DeviceRegistrationState)))
        body.DeviceRegistrationState = DeviceRegistrationState;

    if (this.IsParameterBound(nameof(DeviceType)))
        body.DeviceType = DeviceType;

    if (this.IsParameterBound(nameof(ExchangeAccessState)))
        body.ExchangeAccessState = ExchangeAccessState;

    if (this.IsParameterBound(nameof(ExchangeAccessStateReason)))
        body.ExchangeAccessStateReason = ExchangeAccessStateReason;

    if (this.IsParameterBound(nameof(JoinType)))
        body.JoinType = JoinType;

    if (this.IsParameterBound(nameof(LostModeState)))
        body.LostModeState = LostModeState;

    if (this.IsParameterBound(nameof(ManagedDeviceOwnerType)))
        body.ManagedDeviceOwnerType = ManagedDeviceOwnerType;

    if (this.IsParameterBound(nameof(ManagementAgent)))
        body.ManagementAgent = ManagementAgent;

    if (this.IsParameterBound(nameof(ManagementFeatures)))
        body.ManagementFeatures = ManagementFeatures;

    if (this.IsParameterBound(nameof(ManagementState)))
        body.ManagementState = ManagementState;

    if (this.IsParameterBound(nameof(OwnerType)))
        body.OwnerType = OwnerType;

    if (this.IsParameterBound(nameof(PartnerReportedThreatState)))
        body.PartnerReportedThreatState = PartnerReportedThreatState;

    if (this.IsParameterBound(nameof(ProcessorArchitecture)))
        body.ProcessorArchitecture = ProcessorArchitecture;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDevice? result;
            try
            {
                result = client.DeviceManagement.ComanagedDevices[ManagedDeviceId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ManagedDeviceId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.ComanagedDevices[ManagedDeviceId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
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
