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
    [GraphRoute("PATCH", "/identityGovernance/entitlementManagement/accessPackageAssignments/{accessPackageAssignment-id}")]
    [Cmdlet(VerbsData.Update, "MgEntitlementManagementAccessPackageAssignment", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageAssignment))]
    public class UpdateMgEntitlementManagementAccessPackageAssignmentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessPackageAssignmentId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AccessPackageId { get; set; }

        [Parameter(Mandatory = false)]
        public string? AssignmentPolicyId { get; set; }

        [Parameter(Mandatory = false)]
        public string? AssignmentState { get; set; }

        [Parameter(Mandatory = false)]
        public string? AssignmentStatus { get; set; }

        [Parameter(Mandatory = false)]
        public string? CatalogId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpiredDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsExtended { get; set; }

        [Parameter(Mandatory = false)]
        public string? TargetId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.CustomExtensionCalloutInstance[]? CustomExtensionCalloutInstances { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.RequestSchedule? Schedule { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AccessPackageAssignmentId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageAssignment();

    if (this.IsParameterBound(nameof(AccessPackageId)))
        body.AccessPackageId = AccessPackageId;

    if (this.IsParameterBound(nameof(AssignmentPolicyId)))
        body.AssignmentPolicyId = AssignmentPolicyId;

    if (this.IsParameterBound(nameof(AssignmentState)))
        body.AssignmentState = AssignmentState;

    if (this.IsParameterBound(nameof(AssignmentStatus)))
        body.AssignmentStatus = AssignmentStatus;

    if (this.IsParameterBound(nameof(CatalogId)))
        body.CatalogId = CatalogId;

    if (this.IsParameterBound(nameof(ExpiredDateTime)))
        body.ExpiredDateTime = ExpiredDateTime;

    if (this.IsParameterBound(nameof(IsExtended)))
        body.IsExtended = IsExtended;

    if (this.IsParameterBound(nameof(TargetId)))
        body.TargetId = TargetId;

    if (this.IsParameterBound(nameof(CustomExtensionCalloutInstances)))
        body.CustomExtensionCalloutInstances = CustomExtensionCalloutInstances!.ToList();

    if (this.IsParameterBound(nameof(Schedule)))
        body.Schedule = Schedule;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageAssignment? result;
            try
            {
                result = client.IdentityGovernance.EntitlementManagement.AccessPackageAssignments[AccessPackageAssignmentId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AccessPackageAssignmentId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityGovernance.EntitlementManagement.AccessPackageAssignments[AccessPackageAssignmentId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, AccessPackageAssignmentId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
