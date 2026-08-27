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
    [GraphRoute("PATCH", "/deviceManagement/managedDevices/{managedDevice-id}/windowsProtectionState")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementManagedDeviceWindowsProtectionState", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.WindowsProtectionState))]
    public class UpdateMgDeviceManagementManagedDeviceWindowsProtectionStateCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedDeviceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AntiMalwareVersion { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ControlledConfigurationEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public string? EngineVersion { get; set; }

        [Parameter(Mandatory = false)]
        public bool? FullScanOverdue { get; set; }

        [Parameter(Mandatory = false)]
        public bool? FullScanRequired { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsVirtualMachine { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastFullScanDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? LastFullScanSignatureVersion { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastQuickScanDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? LastQuickScanSignatureVersion { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastReportedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? MalwareProtectionEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? NetworkInspectionSystemEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? QuickScanOverdue { get; set; }

        [Parameter(Mandatory = false)]
        public bool? RealTimeProtectionEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? RebootRequired { get; set; }

        [Parameter(Mandatory = false)]
        public bool? SignatureUpdateOverdue { get; set; }

        [Parameter(Mandatory = false)]
        public string? SignatureVersion { get; set; }

        [Parameter(Mandatory = false)]
        public bool? TamperProtectionEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.WindowsDeviceHealthState? DeviceState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.WindowsDefenderProductStatus? ProductStatus { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ManagedDeviceId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.WindowsProtectionState();

    if (this.IsParameterBound(nameof(AntiMalwareVersion)))
        body.AntiMalwareVersion = AntiMalwareVersion;

    if (this.IsParameterBound(nameof(ControlledConfigurationEnabled)))
        body.ControlledConfigurationEnabled = ControlledConfigurationEnabled;

    if (this.IsParameterBound(nameof(EngineVersion)))
        body.EngineVersion = EngineVersion;

    if (this.IsParameterBound(nameof(FullScanOverdue)))
        body.FullScanOverdue = FullScanOverdue;

    if (this.IsParameterBound(nameof(FullScanRequired)))
        body.FullScanRequired = FullScanRequired;

    if (this.IsParameterBound(nameof(IsVirtualMachine)))
        body.IsVirtualMachine = IsVirtualMachine;

    if (this.IsParameterBound(nameof(LastFullScanDateTime)))
        body.LastFullScanDateTime = LastFullScanDateTime;

    if (this.IsParameterBound(nameof(LastFullScanSignatureVersion)))
        body.LastFullScanSignatureVersion = LastFullScanSignatureVersion;

    if (this.IsParameterBound(nameof(LastQuickScanDateTime)))
        body.LastQuickScanDateTime = LastQuickScanDateTime;

    if (this.IsParameterBound(nameof(LastQuickScanSignatureVersion)))
        body.LastQuickScanSignatureVersion = LastQuickScanSignatureVersion;

    if (this.IsParameterBound(nameof(LastReportedDateTime)))
        body.LastReportedDateTime = LastReportedDateTime;

    if (this.IsParameterBound(nameof(MalwareProtectionEnabled)))
        body.MalwareProtectionEnabled = MalwareProtectionEnabled;

    if (this.IsParameterBound(nameof(NetworkInspectionSystemEnabled)))
        body.NetworkInspectionSystemEnabled = NetworkInspectionSystemEnabled;

    if (this.IsParameterBound(nameof(QuickScanOverdue)))
        body.QuickScanOverdue = QuickScanOverdue;

    if (this.IsParameterBound(nameof(RealTimeProtectionEnabled)))
        body.RealTimeProtectionEnabled = RealTimeProtectionEnabled;

    if (this.IsParameterBound(nameof(RebootRequired)))
        body.RebootRequired = RebootRequired;

    if (this.IsParameterBound(nameof(SignatureUpdateOverdue)))
        body.SignatureUpdateOverdue = SignatureUpdateOverdue;

    if (this.IsParameterBound(nameof(SignatureVersion)))
        body.SignatureVersion = SignatureVersion;

    if (this.IsParameterBound(nameof(TamperProtectionEnabled)))
        body.TamperProtectionEnabled = TamperProtectionEnabled;

    if (this.IsParameterBound(nameof(DeviceState)))
        body.DeviceState = DeviceState;

    if (this.IsParameterBound(nameof(ProductStatus)))
        body.ProductStatus = ProductStatus;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.WindowsProtectionState? result;
            try
            {
                result = client.DeviceManagement.ManagedDevices[ManagedDeviceId].WindowsProtectionState.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, ManagedDeviceId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.ManagedDevices[ManagedDeviceId].WindowsProtectionState.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
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
