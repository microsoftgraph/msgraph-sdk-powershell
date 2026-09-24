#nullable enable

using System;
using System.Collections.Generic;
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
    [GraphRoute("GET", "/deviceManagement/deviceHealthScripts/{deviceHealthScript-id}/getRemediationHistory()")]
    [Cmdlet(VerbsCommon.Get, "MgDeviceManagementDeviceHealthScriptGetRemediationHistory")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceHealthScriptRemediationHistory))]
    public class GetMgDeviceManagementDeviceHealthScriptGetRemediationHistoryCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceHealthScriptId { get; set; } = string.Empty;









        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceHealthScriptRemediationHistory? result;
            try
            {
                result = client.DeviceManagement.DeviceHealthScripts[DeviceHealthScriptId].GetRemediationHistory.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceHealthScriptId);
                return;
            }

            WriteObject(result);
        }
    }
}
