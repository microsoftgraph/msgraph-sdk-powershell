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
    [GraphRoute("POST", "/deviceManagement/deviceShellScripts/{deviceShellScript-id}/groupAssignments")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementDeviceShellScriptGroupAssignment", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementScriptGroupAssignment))]
    public class NewMgDeviceManagementDeviceShellScriptGroupAssignmentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceShellScriptId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? TargetGroupId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceShellScriptId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementScriptGroupAssignment();

    if (this.IsParameterBound(nameof(TargetGroupId)))
        body.TargetGroupId = TargetGroupId;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementScriptGroupAssignment? result;
            try
            {
                result = client.DeviceManagement.DeviceShellScripts[DeviceShellScriptId].GroupAssignments.PostAsync(body, requestConfiguration =>
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
