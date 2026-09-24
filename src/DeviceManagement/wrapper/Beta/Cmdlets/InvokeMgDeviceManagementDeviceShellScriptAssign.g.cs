#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement
{
    [GraphRoute("POST", "/deviceManagement/deviceShellScripts/{deviceShellScript-id}/assign")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementDeviceShellScriptAssign", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgDeviceManagementDeviceShellScriptAssignCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceShellScriptId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementScriptGroupAssignment[]? DeviceManagementScriptGroupAssignments { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementScriptAssignment[]? DeviceManagementScriptAssignments { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceShellScriptId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.DeviceShellScripts.Item.Assign.AssignPostRequestBody();

    if (this.IsParameterBound(nameof(DeviceManagementScriptGroupAssignments)))
        body.DeviceManagementScriptGroupAssignments = DeviceManagementScriptGroupAssignments!.ToList();

    if (this.IsParameterBound(nameof(DeviceManagementScriptAssignments)))
        body.DeviceManagementScriptAssignments = DeviceManagementScriptAssignments!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceManagement.DeviceShellScripts[DeviceShellScriptId].Assign.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceShellScriptId);
                return;
            }

        }
    }
}
