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
    [GraphRoute("PATCH", "/identityGovernance/privilegedAccess/group/assignmentApprovals/{approval-id}/stages/{approvalStage-id}")]
    [Cmdlet(VerbsData.Update, "MgIdentityGovernancePrivilegedAccessGroupAssignmentApprovalStage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.ApprovalStage))]
    public class UpdateMgIdentityGovernancePrivilegedAccessGroupAssignmentApprovalStageCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ApprovalId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ApprovalStageId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? AssignedToMe { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Justification { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ReviewedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ReviewResult { get; set; }

        [Parameter(Mandatory = false)]
        public string? Status { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.Identity? ReviewedBy { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ApprovalStageId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.ApprovalStage();

    if (this.IsParameterBound(nameof(AssignedToMe)))
        body.AssignedToMe = AssignedToMe;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(Justification)))
        body.Justification = Justification;

    if (this.IsParameterBound(nameof(ReviewedDateTime)))
        body.ReviewedDateTime = ReviewedDateTime;

    if (this.IsParameterBound(nameof(ReviewResult)))
        body.ReviewResult = ReviewResult;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(ReviewedBy)))
        body.ReviewedBy = ReviewedBy;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.ApprovalStage? result;
            try
            {
                result = client.IdentityGovernance.PrivilegedAccess.Group.AssignmentApprovals[ApprovalId].Stages[ApprovalStageId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ApprovalStageId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityGovernance.PrivilegedAccess.Group.AssignmentApprovals[ApprovalId].Stages[ApprovalStageId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, ApprovalStageId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
