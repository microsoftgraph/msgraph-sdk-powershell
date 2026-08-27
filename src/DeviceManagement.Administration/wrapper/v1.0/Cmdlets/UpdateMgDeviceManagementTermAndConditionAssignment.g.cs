#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Administration
{
    [GraphRoute("PATCH", "/deviceManagement/termsAndConditions/{termsAndConditions-id}/assignments/{termsAndConditionsAssignment-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementTermAndConditionAssignment", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.TermsAndConditionsAssignment))]
    public class UpdateMgDeviceManagementTermAndConditionAssignmentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TermsAndConditionsId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string TermsAndConditionsAssignmentId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.DeviceAndAppManagementAssignmentTarget? Target { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TermsAndConditionsAssignmentId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.TermsAndConditionsAssignment();


    if (this.IsParameterBound(nameof(Target)))
        body.Target = Target;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.TermsAndConditionsAssignment? result;
            try
            {
                result = client.DeviceManagement.TermsAndConditions[TermsAndConditionsId].Assignments[TermsAndConditionsAssignmentId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, TermsAndConditionsAssignmentId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.TermsAndConditions[TermsAndConditionsId].Assignments[TermsAndConditionsAssignmentId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, TermsAndConditionsAssignmentId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
