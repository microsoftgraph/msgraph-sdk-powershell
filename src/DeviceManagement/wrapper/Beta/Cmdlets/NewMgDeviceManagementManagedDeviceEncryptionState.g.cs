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
    [GraphRoute("POST", "/deviceManagement/managedDeviceEncryptionStates")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementManagedDeviceEncryptionState", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDeviceEncryptionState))]
    public class NewMgDeviceManagementManagedDeviceEncryptionStateCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? DeviceName { get; set; }

        [Parameter(Mandatory = false)]
        public string? OsVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? TpmSpecificationVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserPrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.AdvancedBitLockerState? AdvancedBitLockerStates { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceTypes? DeviceType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ComplianceStatus? EncryptionPolicySettingState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.EncryptionReadinessState? EncryptionReadinessState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.EncryptionState? EncryptionState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.FileVaultState? FileVaultStates { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.EncryptionReportPolicyDetails[]? PolicyDetails { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDeviceEncryptionState();

    if (this.IsParameterBound(nameof(DeviceName)))
        body.DeviceName = DeviceName;

    if (this.IsParameterBound(nameof(OsVersion)))
        body.OsVersion = OsVersion;

    if (this.IsParameterBound(nameof(TpmSpecificationVersion)))
        body.TpmSpecificationVersion = TpmSpecificationVersion;

    if (this.IsParameterBound(nameof(UserPrincipalName)))
        body.UserPrincipalName = UserPrincipalName;

    if (this.IsParameterBound(nameof(AdvancedBitLockerStates)))
        body.AdvancedBitLockerStates = AdvancedBitLockerStates;

    if (this.IsParameterBound(nameof(DeviceType)))
        body.DeviceType = DeviceType;

    if (this.IsParameterBound(nameof(EncryptionPolicySettingState)))
        body.EncryptionPolicySettingState = EncryptionPolicySettingState;

    if (this.IsParameterBound(nameof(EncryptionReadinessState)))
        body.EncryptionReadinessState = EncryptionReadinessState;

    if (this.IsParameterBound(nameof(EncryptionState)))
        body.EncryptionState = EncryptionState;

    if (this.IsParameterBound(nameof(FileVaultStates)))
        body.FileVaultStates = FileVaultStates;

    if (this.IsParameterBound(nameof(PolicyDetails)))
        body.PolicyDetails = PolicyDetails!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDeviceEncryptionState? result;
            try
            {
                result = client.DeviceManagement.ManagedDeviceEncryptionStates.PostAsync(body, requestConfiguration =>
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
