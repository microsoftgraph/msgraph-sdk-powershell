#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.CorporateManagement
{
    [GraphRoute("PATCH", "/users/{user-id}/managedDevices/{managedDevice-id}/assignmentFilterEvaluationStatusDetails/{assignmentFilterEvaluationStatusDetails-id}")]
    [Cmdlet(VerbsData.Update, "MgUserManagedDeviceAssignmentFilterEvaluationStatusDetail", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.AssignmentFilterEvaluationStatusDetails))]
    public class UpdateMgUserManagedDeviceAssignmentFilterEvaluationStatusDetailCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ManagedDeviceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string AssignmentFilterEvaluationStatusDetailsId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? PayloadId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AssignmentFilterEvaluationStatusDetailsId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.AssignmentFilterEvaluationStatusDetails();

    if (this.IsParameterBound(nameof(PayloadId)))
        body.PayloadId = PayloadId;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.AssignmentFilterEvaluationStatusDetails? result;
            try
            {
                result = client.Users[UserId].ManagedDevices[ManagedDeviceId].AssignmentFilterEvaluationStatusDetails[AssignmentFilterEvaluationStatusDetailsId].PatchAsync(body, requestConfiguration =>
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
                    result = client.Users[UserId].ManagedDevices[ManagedDeviceId].AssignmentFilterEvaluationStatusDetails[AssignmentFilterEvaluationStatusDetailsId].GetAsync().GetAwaiter().GetResult();
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
