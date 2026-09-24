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
    [GraphRoute("PATCH", "/deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicy-id}/deviceSettingStateSummaries/{settingStateDeviceSummary-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementDeviceCompliancePolicyDeviceSettingStateSummary", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.SettingStateDeviceSummary))]
    public class UpdateMgDeviceManagementDeviceCompliancePolicyDeviceSettingStateSummaryCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceCompliancePolicyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SettingStateDeviceSummaryId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? CompliantDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? ConflictDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? ErrorDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public string? InstancePath { get; set; }

        [Parameter(Mandatory = false)]
        public int? NonCompliantDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? NotApplicableDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? RemediatedDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public string? SettingName { get; set; }

        [Parameter(Mandatory = false)]
        public int? UnknownDeviceCount { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SettingStateDeviceSummaryId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.SettingStateDeviceSummary();

    if (this.IsParameterBound(nameof(CompliantDeviceCount)))
        body.CompliantDeviceCount = CompliantDeviceCount;

    if (this.IsParameterBound(nameof(ConflictDeviceCount)))
        body.ConflictDeviceCount = ConflictDeviceCount;

    if (this.IsParameterBound(nameof(ErrorDeviceCount)))
        body.ErrorDeviceCount = ErrorDeviceCount;

    if (this.IsParameterBound(nameof(InstancePath)))
        body.InstancePath = InstancePath;

    if (this.IsParameterBound(nameof(NonCompliantDeviceCount)))
        body.NonCompliantDeviceCount = NonCompliantDeviceCount;

    if (this.IsParameterBound(nameof(NotApplicableDeviceCount)))
        body.NotApplicableDeviceCount = NotApplicableDeviceCount;

    if (this.IsParameterBound(nameof(RemediatedDeviceCount)))
        body.RemediatedDeviceCount = RemediatedDeviceCount;

    if (this.IsParameterBound(nameof(SettingName)))
        body.SettingName = SettingName;

    if (this.IsParameterBound(nameof(UnknownDeviceCount)))
        body.UnknownDeviceCount = UnknownDeviceCount;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.SettingStateDeviceSummary? result;
            try
            {
                result = client.DeviceManagement.DeviceCompliancePolicies[DeviceCompliancePolicyId].DeviceSettingStateSummaries[SettingStateDeviceSummaryId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, SettingStateDeviceSummaryId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.DeviceCompliancePolicies[DeviceCompliancePolicyId].DeviceSettingStateSummaries[SettingStateDeviceSummaryId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, SettingStateDeviceSummaryId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
