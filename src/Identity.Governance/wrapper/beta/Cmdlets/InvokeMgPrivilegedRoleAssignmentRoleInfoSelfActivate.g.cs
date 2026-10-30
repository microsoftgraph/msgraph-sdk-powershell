#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Governance.Client;
using Microsoft.Graph.PowerShell.Identity.Governance.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("POST", "/privilegedRoleAssignments/{privilegedRoleAssignment-id}/roleInfo/selfActivate")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgPrivilegedRoleAssignmentRoleInfoSelfActivate", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PrivilegedRoleAssignment))]
    public class InvokeMgPrivilegedRoleAssignmentRoleInfoSelfActivateCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PrivilegedRoleAssignmentId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Reason { get; set; }

        [Parameter(Mandatory = false)]
        public string? Duration { get; set; }

        [Parameter(Mandatory = false)]
        public string? TicketNumber { get; set; }

        [Parameter(Mandatory = false)]
        public string? TicketSystem { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PrivilegedRoleAssignmentId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.Governance.Client.PrivilegedRoleAssignments.Item.RoleInfo.SelfActivate.SelfActivatePostRequestBody();

    if (this.IsParameterBound(nameof(Reason)))
        body.Reason = Reason;

    if (this.IsParameterBound(nameof(Duration)))
        body.Duration = Duration;

    if (this.IsParameterBound(nameof(TicketNumber)))
        body.TicketNumber = TicketNumber;

    if (this.IsParameterBound(nameof(TicketSystem)))
        body.TicketSystem = TicketSystem;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PrivilegedRoleAssignment? result;
            try
            {
                result = client.PrivilegedRoleAssignments[PrivilegedRoleAssignmentId].RoleInfo.SelfActivate.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PrivilegedRoleAssignmentId);
                return;
            }

            WriteObject(result);
        }
    }
}
