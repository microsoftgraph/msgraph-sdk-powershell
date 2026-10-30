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
    [GraphRoute("PATCH", "/privilegedRoleAssignmentRequests/{privilegedRoleAssignmentRequest-id}/roleInfo/summary")]
    [Cmdlet(VerbsData.Update, "MgPrivilegedRoleAssignmentRequestRoleInfoSummary", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PrivilegedRoleSummary))]
    public class UpdateMgPrivilegedRoleAssignmentRequestRoleInfoSummaryCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PrivilegedRoleAssignmentRequestId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? ElevatedCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? ManagedCount { get; set; }

        [Parameter(Mandatory = false)]
        public bool? MfaEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public int? UsersCount { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.RoleSummaryStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PrivilegedRoleAssignmentRequestId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PrivilegedRoleSummary();

    if (this.IsParameterBound(nameof(ElevatedCount)))
        body.ElevatedCount = ElevatedCount;

    if (this.IsParameterBound(nameof(ManagedCount)))
        body.ManagedCount = ManagedCount;

    if (this.IsParameterBound(nameof(MfaEnabled)))
        body.MfaEnabled = MfaEnabled;

    if (this.IsParameterBound(nameof(UsersCount)))
        body.UsersCount = UsersCount;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.PrivilegedRoleSummary? result;
            try
            {
                result = client.PrivilegedRoleAssignmentRequests[PrivilegedRoleAssignmentRequestId].RoleInfo.Summary.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PrivilegedRoleAssignmentRequestId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.PrivilegedRoleAssignmentRequests[PrivilegedRoleAssignmentRequestId].RoleInfo.Summary.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, PrivilegedRoleAssignmentRequestId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
