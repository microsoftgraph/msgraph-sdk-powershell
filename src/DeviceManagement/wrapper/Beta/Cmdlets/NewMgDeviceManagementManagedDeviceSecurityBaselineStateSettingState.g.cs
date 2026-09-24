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
    [GraphRoute("POST", "/deviceManagement/managedDevices/{managedDevice-id}/securityBaselineStates/{securityBaselineState-id}/settingStates")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementManagedDeviceSecurityBaselineStateSettingState", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.SecurityBaselineSettingState))]
    public class NewMgDeviceManagementManagedDeviceSecurityBaselineStateSettingStateCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedDeviceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SecurityBaselineStateId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ErrorCode { get; set; }

        [Parameter(Mandatory = false)]
        public string? SettingCategoryId { get; set; }

        [Parameter(Mandatory = false)]
        public string? SettingCategoryName { get; set; }

        [Parameter(Mandatory = false)]
        public string? SettingId { get; set; }

        [Parameter(Mandatory = false)]
        public string? SettingName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.SecurityBaselineContributingPolicy[]? ContributingPolicies { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.SettingSource[]? SourcePolicies { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.SecurityBaselineComplianceState? State { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SecurityBaselineStateId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.SecurityBaselineSettingState();

    if (this.IsParameterBound(nameof(ErrorCode)))
        body.ErrorCode = ErrorCode;

    if (this.IsParameterBound(nameof(SettingCategoryId)))
        body.SettingCategoryId = SettingCategoryId;

    if (this.IsParameterBound(nameof(SettingCategoryName)))
        body.SettingCategoryName = SettingCategoryName;

    if (this.IsParameterBound(nameof(SettingId)))
        body.SettingId = SettingId;

    if (this.IsParameterBound(nameof(SettingName)))
        body.SettingName = SettingName;

    if (this.IsParameterBound(nameof(ContributingPolicies)))
        body.ContributingPolicies = ContributingPolicies!.ToList();

    if (this.IsParameterBound(nameof(SourcePolicies)))
        body.SourcePolicies = SourcePolicies!.ToList();

    if (this.IsParameterBound(nameof(State)))
        body.State = State;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.SecurityBaselineSettingState? result;
            try
            {
                result = client.DeviceManagement.ManagedDevices[ManagedDeviceId].SecurityBaselineStates[SecurityBaselineStateId].SettingStates.PostAsync(body, requestConfiguration =>
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
