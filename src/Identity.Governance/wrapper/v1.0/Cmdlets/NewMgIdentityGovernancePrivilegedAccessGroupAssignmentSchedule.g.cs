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
    [GraphRoute("POST", "/identityGovernance/privilegedAccess/group/assignmentSchedules")]
    [Cmdlet(VerbsCommon.New, "MgIdentityGovernancePrivilegedAccessGroupAssignmentSchedule", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PrivilegedAccessGroupAssignmentSchedule))]
    public class NewMgIdentityGovernancePrivilegedAccessGroupAssignmentScheduleCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? CreatedUsing { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Status { get; set; }

        [Parameter(Mandatory = false)]
        public string? GroupId { get; set; }

        [Parameter(Mandatory = false)]
        public string? PrincipalId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.RequestSchedule? ScheduleInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PrivilegedAccessGroupRelationships? AccessId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PrivilegedAccessGroupAssignmentType? AssignmentType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PrivilegedAccessGroupMemberType? MemberType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PrivilegedAccessGroupAssignmentSchedule();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(CreatedUsing)))
        body.CreatedUsing = CreatedUsing;

    if (this.IsParameterBound(nameof(ModifiedDateTime)))
        body.ModifiedDateTime = ModifiedDateTime;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(GroupId)))
        body.GroupId = GroupId;

    if (this.IsParameterBound(nameof(PrincipalId)))
        body.PrincipalId = PrincipalId;

    if (this.IsParameterBound(nameof(ScheduleInfo)))
        body.ScheduleInfo = ScheduleInfo;

    if (this.IsParameterBound(nameof(AccessId)))
        body.AccessId = AccessId;

    if (this.IsParameterBound(nameof(AssignmentType)))
        body.AssignmentType = AssignmentType;

    if (this.IsParameterBound(nameof(MemberType)))
        body.MemberType = MemberType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PrivilegedAccessGroupAssignmentSchedule? result;
            try
            {
                result = client.IdentityGovernance.PrivilegedAccess.Group.AssignmentSchedules.PostAsync(body, requestConfiguration =>
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
