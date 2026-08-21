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
    [GraphRoute("POST", "/deviceManagement/deviceConfigurations/{deviceConfiguration-id}/userStatuses")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementDeviceConfigurationUserStatus", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceConfigurationUserStatus))]
    public class NewMgDeviceManagementDeviceConfigurationUserStatusCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceConfigurationId { get; set; } = string.Empty;

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
            if (!ShouldProcess(DeviceConfigurationId, "New"))
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
                result = client.DeviceManagement.DeviceConfigurations[DeviceConfigurationId].UserStatuses.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
