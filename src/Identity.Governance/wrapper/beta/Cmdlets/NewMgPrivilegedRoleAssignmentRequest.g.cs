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
    [GraphRoute("POST", "/privilegedRoleAssignmentRequests")]
    [Cmdlet(VerbsCommon.New, "MgPrivilegedRoleAssignmentRequest", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PrivilegedRoleAssignmentRequest))]
    public class NewMgPrivilegedRoleAssignmentRequestCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? AssignmentState { get; set; }

        [Parameter(Mandatory = false)]
        public string? Duration { get; set; }

        [Parameter(Mandatory = false)]
        public string? Reason { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? RequestedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? RoleId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Status { get; set; }

        [Parameter(Mandatory = false)]
        public string? TicketNumber { get; set; }

        [Parameter(Mandatory = false)]
        public string? TicketSystem { get; set; }

        [Parameter(Mandatory = false)]
        public string? Type { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.GovernanceSchedule? Schedule { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PrivilegedRoleAssignmentRequest();

    if (this.IsParameterBound(nameof(AssignmentState)))
        body.AssignmentState = AssignmentState;

    if (this.IsParameterBound(nameof(Duration)))
        body.Duration = Duration;

    if (this.IsParameterBound(nameof(Reason)))
        body.Reason = Reason;

    if (this.IsParameterBound(nameof(RequestedDateTime)))
        body.RequestedDateTime = RequestedDateTime;

    if (this.IsParameterBound(nameof(RoleId)))
        body.RoleId = RoleId;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(TicketNumber)))
        body.TicketNumber = TicketNumber;

    if (this.IsParameterBound(nameof(TicketSystem)))
        body.TicketSystem = TicketSystem;

    if (this.IsParameterBound(nameof(Type)))
        body.Type = Type;

    if (this.IsParameterBound(nameof(UserId)))
        body.UserId = UserId;

    if (this.IsParameterBound(nameof(Schedule)))
        body.Schedule = Schedule;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PrivilegedRoleAssignmentRequest? result;
            try
            {
                result = client.PrivilegedRoleAssignmentRequests.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
