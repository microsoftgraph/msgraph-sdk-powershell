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
    [GraphRoute("POST", "/deviceManagement/deviceManagementScripts/{deviceManagementScript-id}/userRunStates/{deviceManagementScriptUserState-id}/deviceRunStates")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementDeviceManagementScriptUserRunStateDeviceRunState", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementScriptDeviceState))]
    public class NewMgDeviceManagementDeviceManagementScriptUserRunStateDeviceRunStateCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceManagementScriptId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DeviceManagementScriptUserStateId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? ErrorCode { get; set; }

        [Parameter(Mandatory = false)]
        public string? ErrorDescription { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastStateUpdateDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResultMessage { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.RunState? RunState { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceManagementScriptUserStateId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementScriptDeviceState();

    if (this.IsParameterBound(nameof(ErrorCode)))
        body.ErrorCode = ErrorCode;

    if (this.IsParameterBound(nameof(ErrorDescription)))
        body.ErrorDescription = ErrorDescription;

    if (this.IsParameterBound(nameof(LastStateUpdateDateTime)))
        body.LastStateUpdateDateTime = LastStateUpdateDateTime;

    if (this.IsParameterBound(nameof(ResultMessage)))
        body.ResultMessage = ResultMessage;

    if (this.IsParameterBound(nameof(RunState)))
        body.RunState = RunState;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementScriptDeviceState? result;
            try
            {
                result = client.DeviceManagement.DeviceManagementScripts[DeviceManagementScriptId].UserRunStates[DeviceManagementScriptUserStateId].DeviceRunStates.PostAsync(body, requestConfiguration =>
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
