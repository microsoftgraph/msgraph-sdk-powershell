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
    [GraphRoute("PATCH", "/deviceManagement/complianceManagementPartners/{complianceManagementPartner-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementComplianceManagementPartner", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.ComplianceManagementPartner))]
    public class UpdateMgDeviceManagementComplianceManagementPartnerCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ComplianceManagementPartnerId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? AndroidOnboarded { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IosOnboarded { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastHeartbeatDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? MacOsOnboarded { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.ComplianceManagementPartnerAssignment[]? AndroidEnrollmentAssignments { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.ComplianceManagementPartnerAssignment[]? IosEnrollmentAssignments { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.ComplianceManagementPartnerAssignment[]? MacOsEnrollmentAssignments { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.DeviceManagementPartnerTenantState? PartnerState { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ComplianceManagementPartnerId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.ComplianceManagementPartner();

    if (this.IsParameterBound(nameof(AndroidOnboarded)))
        body.AndroidOnboarded = AndroidOnboarded;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IosOnboarded)))
        body.IosOnboarded = IosOnboarded;

    if (this.IsParameterBound(nameof(LastHeartbeatDateTime)))
        body.LastHeartbeatDateTime = LastHeartbeatDateTime;

    if (this.IsParameterBound(nameof(MacOsOnboarded)))
        body.MacOsOnboarded = MacOsOnboarded;

    if (this.IsParameterBound(nameof(AndroidEnrollmentAssignments)))
        body.AndroidEnrollmentAssignments = AndroidEnrollmentAssignments!.ToList();

    if (this.IsParameterBound(nameof(IosEnrollmentAssignments)))
        body.IosEnrollmentAssignments = IosEnrollmentAssignments!.ToList();

    if (this.IsParameterBound(nameof(MacOsEnrollmentAssignments)))
        body.MacOsEnrollmentAssignments = MacOsEnrollmentAssignments!.ToList();

    if (this.IsParameterBound(nameof(PartnerState)))
        body.PartnerState = PartnerState;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.ComplianceManagementPartner? result;
            try
            {
                result = client.DeviceManagement.ComplianceManagementPartners[ComplianceManagementPartnerId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ComplianceManagementPartnerId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.ComplianceManagementPartners[ComplianceManagementPartnerId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, ComplianceManagementPartnerId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
