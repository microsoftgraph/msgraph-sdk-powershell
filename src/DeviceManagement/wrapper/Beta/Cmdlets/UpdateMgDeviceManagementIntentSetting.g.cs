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
    [GraphRoute("PATCH", "/deviceManagement/intents/{deviceManagementIntent-id}/settings/{deviceManagementSettingInstance-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementIntentSetting", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementSettingInstance))]
    public class UpdateMgDeviceManagementIntentSettingCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceManagementIntentId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DeviceManagementSettingInstanceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DefinitionId { get; set; }

        [Parameter(Mandatory = false)]
        public string? ValueJson { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceManagementSettingInstanceId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementSettingInstance();

    if (this.IsParameterBound(nameof(DefinitionId)))
        body.DefinitionId = DefinitionId;

    if (this.IsParameterBound(nameof(ValueJson)))
        body.ValueJson = ValueJson;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementSettingInstance? result;
            try
            {
                result = client.DeviceManagement.Intents[DeviceManagementIntentId].Settings[DeviceManagementSettingInstanceId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceManagementSettingInstanceId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.Intents[DeviceManagementIntentId].Settings[DeviceManagementSettingInstanceId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, DeviceManagementSettingInstanceId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
