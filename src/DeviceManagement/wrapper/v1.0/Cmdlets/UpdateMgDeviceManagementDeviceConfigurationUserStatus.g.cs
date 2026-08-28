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
    [GraphRoute("PATCH", "/deviceManagement/deviceConfigurations/{deviceConfiguration-id}/userStatuses/{deviceConfigurationUserStatus-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementDeviceConfigurationUserStatus", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceConfigurationUserStatus))]
    public class UpdateMgDeviceManagementDeviceConfigurationUserStatusCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceConfigurationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DeviceConfigurationUserStatusId { get; set; } = string.Empty;

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
            if (!ShouldProcess(DeviceConfigurationUserStatusId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceConfigurationUserStatus();

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

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceConfigurationUserStatus? result;
            try
            {
                result = client.DeviceManagement.DeviceConfigurations[DeviceConfigurationId].UserStatuses[DeviceConfigurationUserStatusId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, DeviceConfigurationUserStatusId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.DeviceConfigurations[DeviceConfigurationId].UserStatuses[DeviceConfigurationUserStatusId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, DeviceConfigurationUserStatusId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
