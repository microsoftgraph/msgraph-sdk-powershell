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
    [GraphRoute("PATCH", "/privilegedAccess/{privilegedAccess-id}/resources/{governanceResource-id}/roleAssignmentRequests/{governanceRoleAssignmentRequest-id}")]
    [Cmdlet(VerbsData.Update, "MgPrivilegedAccessResourceRoleAssignmentRequest", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.GovernanceRoleAssignmentRequest))]
    public class UpdateMgPrivilegedAccessResourceRoleAssignmentRequestCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PrivilegedAccessId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string GovernanceResourceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string GovernanceRoleAssignmentRequestId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AssignmentState { get; set; }

        [Parameter(Mandatory = false)]
        public string? LinkedEligibleRoleAssignmentId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Reason { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? RequestedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResourceId { get; set; }

        [Parameter(Mandatory = false)]
        public string? RoleDefinitionId { get; set; }

        [Parameter(Mandatory = false)]
        public string? SubjectId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Type { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.GovernanceSchedule? Schedule { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.GovernanceRoleAssignmentRequestStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(GovernanceRoleAssignmentRequestId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.GovernanceRoleAssignmentRequest();

    if (this.IsParameterBound(nameof(AssignmentState)))
        body.AssignmentState = AssignmentState;

    if (this.IsParameterBound(nameof(LinkedEligibleRoleAssignmentId)))
        body.LinkedEligibleRoleAssignmentId = LinkedEligibleRoleAssignmentId;

    if (this.IsParameterBound(nameof(Reason)))
        body.Reason = Reason;

    if (this.IsParameterBound(nameof(RequestedDateTime)))
        body.RequestedDateTime = RequestedDateTime;

    if (this.IsParameterBound(nameof(ResourceId)))
        body.ResourceId = ResourceId;

    if (this.IsParameterBound(nameof(RoleDefinitionId)))
        body.RoleDefinitionId = RoleDefinitionId;

    if (this.IsParameterBound(nameof(SubjectId)))
        body.SubjectId = SubjectId;

    if (this.IsParameterBound(nameof(Type)))
        body.Type = Type;

    if (this.IsParameterBound(nameof(Schedule)))
        body.Schedule = Schedule;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.GovernanceRoleAssignmentRequest? result;
            try
            {
                result = client.PrivilegedAccess[PrivilegedAccessId].Resources[GovernanceResourceId].RoleAssignmentRequests[GovernanceRoleAssignmentRequestId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, GovernanceRoleAssignmentRequestId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.PrivilegedAccess[PrivilegedAccessId].Resources[GovernanceResourceId].RoleAssignmentRequests[GovernanceRoleAssignmentRequestId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, GovernanceRoleAssignmentRequestId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
