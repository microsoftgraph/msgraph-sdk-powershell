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
    [GraphRoute("PATCH", "/deviceManagement/deviceManagementPartners/{deviceManagementPartner-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementPartner", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.DeviceManagementPartner))]
    public class UpdateMgDeviceManagementPartnerCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceManagementPartnerId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsConfigured { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastHeartbeatDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? SingleTenantAppId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? WhenPartnerDevicesWillBeMarkedAsNonCompliantDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? WhenPartnerDevicesWillBeRemovedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.DeviceManagementPartnerAssignment[]? GroupsRequiringPartnerEnrollment { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.DeviceManagementPartnerAppType? PartnerAppType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.DeviceManagementPartnerTenantState? PartnerState { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceManagementPartnerId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.DeviceManagementPartner();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IsConfigured)))
        body.IsConfigured = IsConfigured;

    if (this.IsParameterBound(nameof(LastHeartbeatDateTime)))
        body.LastHeartbeatDateTime = LastHeartbeatDateTime;

    if (this.IsParameterBound(nameof(SingleTenantAppId)))
        body.SingleTenantAppId = SingleTenantAppId;

    if (this.IsParameterBound(nameof(WhenPartnerDevicesWillBeMarkedAsNonCompliantDateTime)))
        body.WhenPartnerDevicesWillBeMarkedAsNonCompliantDateTime = WhenPartnerDevicesWillBeMarkedAsNonCompliantDateTime;

    if (this.IsParameterBound(nameof(WhenPartnerDevicesWillBeRemovedDateTime)))
        body.WhenPartnerDevicesWillBeRemovedDateTime = WhenPartnerDevicesWillBeRemovedDateTime;

    if (this.IsParameterBound(nameof(GroupsRequiringPartnerEnrollment)))
        body.GroupsRequiringPartnerEnrollment = GroupsRequiringPartnerEnrollment!.ToList();

    if (this.IsParameterBound(nameof(PartnerAppType)))
        body.PartnerAppType = PartnerAppType;

    if (this.IsParameterBound(nameof(PartnerState)))
        body.PartnerState = PartnerState;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.DeviceManagementPartner? result;
            try
            {
                result = client.DeviceManagement.DeviceManagementPartners[DeviceManagementPartnerId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, DeviceManagementPartnerId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.DeviceManagementPartners[DeviceManagementPartnerId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, DeviceManagementPartnerId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
