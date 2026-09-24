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
    [GraphRoute("PATCH", "/deviceManagement/comanagedDevices/{managedDevice-id}/assignmentFilterEvaluationStatusDetails/{assignmentFilterEvaluationStatusDetails-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementComanagedDeviceAssignmentFilterEvaluationStatusDetail", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.AssignmentFilterEvaluationStatusDetails))]
    public class UpdateMgDeviceManagementComanagedDeviceAssignmentFilterEvaluationStatusDetailCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedDeviceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AssignmentFilterEvaluationStatusDetailsId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? PayloadId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AssignmentFilterEvaluationStatusDetailsId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.AssignmentFilterEvaluationStatusDetails();

    if (this.IsParameterBound(nameof(PayloadId)))
        body.PayloadId = PayloadId;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.AssignmentFilterEvaluationStatusDetails? result;
            try
            {
                result = client.DeviceManagement.ComanagedDevices[ManagedDeviceId].AssignmentFilterEvaluationStatusDetails[AssignmentFilterEvaluationStatusDetailsId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AssignmentFilterEvaluationStatusDetailsId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.ComanagedDevices[ManagedDeviceId].AssignmentFilterEvaluationStatusDetails[AssignmentFilterEvaluationStatusDetailsId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, AssignmentFilterEvaluationStatusDetailsId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
