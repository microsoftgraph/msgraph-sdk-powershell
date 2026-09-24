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
    [GraphRoute("PATCH", "/deviceManagement/managedDeviceCleanupRules/{managedDeviceCleanupRule-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementManagedDeviceCleanupRule", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDeviceCleanupRule))]
    public class UpdateMgDeviceManagementManagedDeviceCleanupRuleCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedDeviceCleanupRuleId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public int? DeviceInactivityBeforeRetirementInDays { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceCleanupRulePlatformType? DeviceCleanupRulePlatformType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ManagedDeviceCleanupRuleId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDeviceCleanupRule();

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DeviceInactivityBeforeRetirementInDays)))
        body.DeviceInactivityBeforeRetirementInDays = DeviceInactivityBeforeRetirementInDays;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(DeviceCleanupRulePlatformType)))
        body.DeviceCleanupRulePlatformType = DeviceCleanupRulePlatformType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ManagedDeviceCleanupRule? result;
            try
            {
                result = client.DeviceManagement.ManagedDeviceCleanupRules[ManagedDeviceCleanupRuleId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ManagedDeviceCleanupRuleId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.ManagedDeviceCleanupRules[ManagedDeviceCleanupRuleId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ManagedDeviceCleanupRuleId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
