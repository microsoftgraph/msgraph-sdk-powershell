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
    [GraphRoute("PATCH", "/deviceManagement/iosUpdateStatuses/{iosUpdateDeviceStatus-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementIoUpdateStatus", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.IosUpdateDeviceStatus))]
    public class UpdateMgDeviceManagementIoUpdateStatusCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string IosUpdateDeviceStatusId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ComplianceGracePeriodExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceId { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceModel { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastReportedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? OsVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserId { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserName { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserPrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.IosUpdatesInstallStatus? InstallStatus { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.ComplianceStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(IosUpdateDeviceStatusId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.IosUpdateDeviceStatus();

    if (this.IsParameterBound(nameof(ComplianceGracePeriodExpirationDateTime)))
        body.ComplianceGracePeriodExpirationDateTime = ComplianceGracePeriodExpirationDateTime;

    if (this.IsParameterBound(nameof(DeviceDisplayName)))
        body.DeviceDisplayName = DeviceDisplayName;

    if (this.IsParameterBound(nameof(DeviceId)))
        body.DeviceId = DeviceId;

    if (this.IsParameterBound(nameof(DeviceModel)))
        body.DeviceModel = DeviceModel;

    if (this.IsParameterBound(nameof(LastReportedDateTime)))
        body.LastReportedDateTime = LastReportedDateTime;

    if (this.IsParameterBound(nameof(OsVersion)))
        body.OsVersion = OsVersion;

    if (this.IsParameterBound(nameof(UserId)))
        body.UserId = UserId;

    if (this.IsParameterBound(nameof(UserName)))
        body.UserName = UserName;

    if (this.IsParameterBound(nameof(UserPrincipalName)))
        body.UserPrincipalName = UserPrincipalName;

    if (this.IsParameterBound(nameof(InstallStatus)))
        body.InstallStatus = InstallStatus;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.IosUpdateDeviceStatus? result;
            try
            {
                result = client.DeviceManagement.IosUpdateStatuses[IosUpdateDeviceStatusId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, IosUpdateDeviceStatusId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.IosUpdateStatuses[IosUpdateDeviceStatusId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, IosUpdateDeviceStatusId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
