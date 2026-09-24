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
    [GraphRoute("PATCH", "/deviceManagement/resourceAccessProfiles/{deviceManagementResourceAccessProfileBase-id}/assignments/{deviceManagementResourceAccessProfileAssignment-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementResourceAccessProfileAssignment", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementResourceAccessProfileAssignment))]
    public class UpdateMgDeviceManagementResourceAccessProfileAssignmentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceManagementResourceAccessProfileBaseId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DeviceManagementResourceAccessProfileAssignmentId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? SourceId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementResourceAccessProfileIntent? Intent { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceAndAppManagementAssignmentTarget? Target { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceManagementResourceAccessProfileAssignmentId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementResourceAccessProfileAssignment();

    if (this.IsParameterBound(nameof(SourceId)))
        body.SourceId = SourceId;

    if (this.IsParameterBound(nameof(Intent)))
        body.Intent = Intent;

    if (this.IsParameterBound(nameof(Target)))
        body.Target = Target;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementResourceAccessProfileAssignment? result;
            try
            {
                result = client.DeviceManagement.ResourceAccessProfiles[DeviceManagementResourceAccessProfileBaseId].Assignments[DeviceManagementResourceAccessProfileAssignmentId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceManagementResourceAccessProfileAssignmentId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.ResourceAccessProfiles[DeviceManagementResourceAccessProfileBaseId].Assignments[DeviceManagementResourceAccessProfileAssignmentId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, DeviceManagementResourceAccessProfileAssignmentId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
