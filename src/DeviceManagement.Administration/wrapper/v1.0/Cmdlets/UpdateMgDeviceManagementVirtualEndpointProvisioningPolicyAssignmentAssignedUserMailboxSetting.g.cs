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
    [GraphRoute("PATCH", "/deviceManagement/virtualEndpoint/provisioningPolicies/{cloudPcProvisioningPolicy-id}/assignments/{cloudPcProvisioningPolicyAssignment-id}/assignedUsers/{user-id}/mailboxSettings")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementVirtualEndpointProvisioningPolicyAssignmentAssignedUserMailboxSetting", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.MailboxSettings))]
    public class UpdateMgDeviceManagementVirtualEndpointProvisioningPolicyAssignmentAssignedUserMailboxSettingCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CloudPcProvisioningPolicyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string CloudPcProvisioningPolicyAssignmentId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ArchiveFolder { get; set; }

        [Parameter(Mandatory = false)]
        public string? DateFormat { get; set; }

        [Parameter(Mandatory = false)]
        public string? TimeFormat { get; set; }

        [Parameter(Mandatory = false)]
        public string? TimeZone { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.AutomaticRepliesSetting? AutomaticRepliesSetting { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.DelegateMeetingMessageDeliveryOptions? DelegateMeetingMessageDeliveryOptions { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.LocaleInfo? Language { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.UserPurpose? UserPurpose { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.WorkingHours? WorkingHours { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.MailboxSettings();

    if (this.IsParameterBound(nameof(ArchiveFolder)))
        body.ArchiveFolder = ArchiveFolder;

    if (this.IsParameterBound(nameof(DateFormat)))
        body.DateFormat = DateFormat;

    if (this.IsParameterBound(nameof(TimeFormat)))
        body.TimeFormat = TimeFormat;

    if (this.IsParameterBound(nameof(TimeZone)))
        body.TimeZone = TimeZone;

    if (this.IsParameterBound(nameof(AutomaticRepliesSetting)))
        body.AutomaticRepliesSetting = AutomaticRepliesSetting;

    if (this.IsParameterBound(nameof(DelegateMeetingMessageDeliveryOptions)))
        body.DelegateMeetingMessageDeliveryOptions = DelegateMeetingMessageDeliveryOptions;

    if (this.IsParameterBound(nameof(Language)))
        body.Language = Language;

    if (this.IsParameterBound(nameof(UserPurpose)))
        body.UserPurpose = UserPurpose;

    if (this.IsParameterBound(nameof(WorkingHours)))
        body.WorkingHours = WorkingHours;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models.MailboxSettings? result;
            try
            {
                result = client.DeviceManagement.VirtualEndpoint.ProvisioningPolicies[CloudPcProvisioningPolicyId].Assignments[CloudPcProvisioningPolicyAssignmentId].AssignedUsers[UserId].MailboxSettings.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, UserId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.VirtualEndpoint.ProvisioningPolicies[CloudPcProvisioningPolicyId].Assignments[CloudPcProvisioningPolicyAssignmentId].AssignedUsers[UserId].MailboxSettings.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, UserId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
