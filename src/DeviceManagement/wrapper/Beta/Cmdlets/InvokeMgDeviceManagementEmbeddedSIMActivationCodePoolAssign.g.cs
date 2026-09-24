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
    [GraphRoute("POST", "/deviceManagement/embeddedSIMActivationCodePools/{embeddedSIMActivationCodePool-id}/assign")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementEmbeddedSIMActivationCodePoolAssign", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.EmbeddedSIMActivationCodePools.Item.Assign.AssignPostResponse))]
    public class InvokeMgDeviceManagementEmbeddedSIMActivationCodePoolAssignCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EmbeddedSIMActivationCodePoolId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.EmbeddedSIMActivationCodePoolAssignment[]? Assignments { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EmbeddedSIMActivationCodePoolId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.EmbeddedSIMActivationCodePools.Item.Assign.AssignPostRequestBody();

    if (this.IsParameterBound(nameof(Assignments)))
        body.Assignments = Assignments!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.EmbeddedSIMActivationCodePools.Item.Assign.AssignPostResponse? result;
            try
            {
                result = client.DeviceManagement.EmbeddedSIMActivationCodePools[EmbeddedSIMActivationCodePoolId].Assign.PostAsAssignPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, EmbeddedSIMActivationCodePoolId);
                return;
            }

            WriteObject(result);
        }
    }
}
