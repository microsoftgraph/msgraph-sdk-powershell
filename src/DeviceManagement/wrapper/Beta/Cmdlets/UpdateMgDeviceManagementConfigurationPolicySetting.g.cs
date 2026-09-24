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
    [GraphRoute("PATCH", "/deviceManagement/configurationPolicies/{deviceManagementConfigurationPolicy-id}/settings/{deviceManagementConfigurationSetting-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementConfigurationPolicySetting", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementConfigurationSetting))]
    public class UpdateMgDeviceManagementConfigurationPolicySettingCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceManagementConfigurationPolicyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DeviceManagementConfigurationSettingId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementConfigurationSettingInstance? SettingInstance { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceManagementConfigurationSettingId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementConfigurationSetting();


    if (this.IsParameterBound(nameof(SettingInstance)))
        body.SettingInstance = SettingInstance;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementConfigurationSetting? result;
            try
            {
                result = client.DeviceManagement.ConfigurationPolicies[DeviceManagementConfigurationPolicyId].Settings[DeviceManagementConfigurationSettingId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceManagementConfigurationSettingId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.ConfigurationPolicies[DeviceManagementConfigurationPolicyId].Settings[DeviceManagementConfigurationSettingId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, DeviceManagementConfigurationSettingId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
