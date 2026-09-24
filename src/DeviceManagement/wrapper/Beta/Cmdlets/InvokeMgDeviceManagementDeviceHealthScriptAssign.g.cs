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
    [GraphRoute("POST", "/deviceManagement/deviceHealthScripts/{deviceHealthScript-id}/assign")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementDeviceHealthScriptAssign", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgDeviceManagementDeviceHealthScriptAssignCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceHealthScriptId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceHealthScriptAssignment[]? DeviceHealthScriptAssignments { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceHealthScriptId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.DeviceHealthScripts.Item.Assign.AssignPostRequestBody();

    if (this.IsParameterBound(nameof(DeviceHealthScriptAssignments)))
        body.DeviceHealthScriptAssignments = DeviceHealthScriptAssignments!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceManagement.DeviceHealthScripts[DeviceHealthScriptId].Assign.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceHealthScriptId);
                return;
            }

        }
    }
}
