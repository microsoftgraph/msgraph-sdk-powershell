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
    [GraphRoute("POST", "/deviceManagement/resourceAccessProfiles/{deviceManagementResourceAccessProfileBase-id}/assignments")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementResourceAccessProfileAssignment", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementResourceAccessProfileAssignment))]
    public class NewMgDeviceManagementResourceAccessProfileAssignmentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceManagementResourceAccessProfileBaseId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? SourceId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementResourceAccessProfileIntent? Intent { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceAndAppManagementAssignmentTarget? Target { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceManagementResourceAccessProfileBaseId, "New"))
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
                result = client.DeviceManagement.ResourceAccessProfiles[DeviceManagementResourceAccessProfileBaseId].Assignments.PostAsync(body, requestConfiguration =>
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
