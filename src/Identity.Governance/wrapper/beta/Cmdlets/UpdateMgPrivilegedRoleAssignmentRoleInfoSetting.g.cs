#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Governance.Client;
using Microsoft.Graph.PowerShell.Identity.Governance.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("PATCH", "/privilegedRoleAssignments/{privilegedRoleAssignment-id}/roleInfo/settings")]
    [Cmdlet(VerbsData.Update, "MgPrivilegedRoleAssignmentRoleInfoSetting", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PrivilegedRoleSettings))]
    public class UpdateMgPrivilegedRoleAssignmentRoleInfoSettingCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PrivilegedRoleAssignmentId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? ApprovalOnElevation { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ApproverIds { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.TimeSpan? ElevationDuration { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsMfaOnElevationConfigurable { get; set; }

        [Parameter(Mandatory = false)]
        public bool? LastGlobalAdmin { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.TimeSpan? MaxElavationDuration { get; set; }

        [Parameter(Mandatory = false)]
        public bool? MfaOnElevation { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.TimeSpan? MinElevationDuration { get; set; }

        [Parameter(Mandatory = false)]
        public bool? NotificationToUserOnElevation { get; set; }

        [Parameter(Mandatory = false)]
        public bool? TicketingInfoOnElevation { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PrivilegedRoleAssignmentId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PrivilegedRoleSettings();

    if (this.IsParameterBound(nameof(ApprovalOnElevation)))
        body.ApprovalOnElevation = ApprovalOnElevation;

    if (this.IsParameterBound(nameof(ApproverIds)))
        body.ApproverIds = ApproverIds!.ToList();

    if (this.IsParameterBound(nameof(ElevationDuration)))
        body.ElevationDuration = ElevationDuration;

    if (this.IsParameterBound(nameof(IsMfaOnElevationConfigurable)))
        body.IsMfaOnElevationConfigurable = IsMfaOnElevationConfigurable;

    if (this.IsParameterBound(nameof(LastGlobalAdmin)))
        body.LastGlobalAdmin = LastGlobalAdmin;

    if (this.IsParameterBound(nameof(MaxElavationDuration)))
        body.MaxElavationDuration = MaxElavationDuration;

    if (this.IsParameterBound(nameof(MfaOnElevation)))
        body.MfaOnElevation = MfaOnElevation;

    if (this.IsParameterBound(nameof(MinElevationDuration)))
        body.MinElevationDuration = MinElevationDuration;

    if (this.IsParameterBound(nameof(NotificationToUserOnElevation)))
        body.NotificationToUserOnElevation = NotificationToUserOnElevation;

    if (this.IsParameterBound(nameof(TicketingInfoOnElevation)))
        body.TicketingInfoOnElevation = TicketingInfoOnElevation;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PrivilegedRoleSettings? result;
            try
            {
                result = client.PrivilegedRoleAssignments[PrivilegedRoleAssignmentId].RoleInfo.Settings.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PrivilegedRoleAssignmentId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.PrivilegedRoleAssignments[PrivilegedRoleAssignmentId].RoleInfo.Settings.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, PrivilegedRoleAssignmentId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
