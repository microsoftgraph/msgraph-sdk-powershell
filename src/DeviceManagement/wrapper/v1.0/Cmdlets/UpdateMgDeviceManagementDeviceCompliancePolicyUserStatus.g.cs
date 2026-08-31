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
    [GraphRoute("PATCH", "/deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicy-id}/userStatuses/{deviceComplianceUserStatus-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementDeviceCompliancePolicyUserStatus", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceComplianceUserStatus))]
    public class UpdateMgDeviceManagementDeviceCompliancePolicyUserStatusCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceCompliancePolicyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DeviceComplianceUserStatusId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? DevicesCount { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastReportedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserPrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ComplianceStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceComplianceUserStatusId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceComplianceUserStatus();

    if (this.IsParameterBound(nameof(DevicesCount)))
        body.DevicesCount = DevicesCount;

    if (this.IsParameterBound(nameof(LastReportedDateTime)))
        body.LastReportedDateTime = LastReportedDateTime;

    if (this.IsParameterBound(nameof(UserDisplayName)))
        body.UserDisplayName = UserDisplayName;

    if (this.IsParameterBound(nameof(UserPrincipalName)))
        body.UserPrincipalName = UserPrincipalName;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceComplianceUserStatus? result;
            try
            {
                result = client.DeviceManagement.DeviceCompliancePolicies[DeviceCompliancePolicyId].UserStatuses[DeviceComplianceUserStatusId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceComplianceUserStatusId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.DeviceCompliancePolicies[DeviceCompliancePolicyId].UserStatuses[DeviceComplianceUserStatusId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, DeviceComplianceUserStatusId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
