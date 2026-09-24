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
    [GraphRoute("PATCH", "/deviceManagement/deviceManagementScripts/{deviceManagementScript-id}/userRunStates/{deviceManagementScriptUserState-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementDeviceManagementScriptUserRunState", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementScriptUserState))]
    public class UpdateMgDeviceManagementDeviceManagementScriptUserRunStateCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceManagementScriptId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DeviceManagementScriptUserStateId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? ErrorDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? SuccessDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserPrincipalName { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceManagementScriptUserStateId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementScriptUserState();

    if (this.IsParameterBound(nameof(ErrorDeviceCount)))
        body.ErrorDeviceCount = ErrorDeviceCount;

    if (this.IsParameterBound(nameof(SuccessDeviceCount)))
        body.SuccessDeviceCount = SuccessDeviceCount;

    if (this.IsParameterBound(nameof(UserPrincipalName)))
        body.UserPrincipalName = UserPrincipalName;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementScriptUserState? result;
            try
            {
                result = client.DeviceManagement.DeviceManagementScripts[DeviceManagementScriptId].UserRunStates[DeviceManagementScriptUserStateId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceManagementScriptUserStateId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.DeviceManagementScripts[DeviceManagementScriptId].UserRunStates[DeviceManagementScriptUserStateId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, DeviceManagementScriptUserStateId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
