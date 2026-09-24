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
    [GraphRoute("PATCH", "/deviceManagement/embeddedSIMActivationCodePools/{embeddedSIMActivationCodePool-id}/assignments/{embeddedSIMActivationCodePoolAssignment-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementEmbeddedSIMActivationCodePoolAssignment", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.EmbeddedSIMActivationCodePoolAssignment))]
    public class UpdateMgDeviceManagementEmbeddedSIMActivationCodePoolAssignmentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string EmbeddedSIMActivationCodePoolId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EmbeddedSIMActivationCodePoolAssignmentId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceAndAppManagementAssignmentTarget? Target { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EmbeddedSIMActivationCodePoolAssignmentId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.EmbeddedSIMActivationCodePoolAssignment();


    if (this.IsParameterBound(nameof(Target)))
        body.Target = Target;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.EmbeddedSIMActivationCodePoolAssignment? result;
            try
            {
                result = client.DeviceManagement.EmbeddedSIMActivationCodePools[EmbeddedSIMActivationCodePoolId].Assignments[EmbeddedSIMActivationCodePoolAssignmentId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, EmbeddedSIMActivationCodePoolAssignmentId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.EmbeddedSIMActivationCodePools[EmbeddedSIMActivationCodePoolId].Assignments[EmbeddedSIMActivationCodePoolAssignmentId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, EmbeddedSIMActivationCodePoolAssignmentId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
