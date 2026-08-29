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
    [GraphRoute("PATCH", "/identityGovernance/entitlementManagement/accessPackages/{accessPackage-id}/assignmentPolicies/{accessPackageAssignmentPolicy-id}")]
    [Cmdlet(VerbsData.Update, "MgEntitlementManagementAccessPackageAssignmentPolicy", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageAssignmentPolicy))]
    public class UpdateMgEntitlementManagementAccessPackageAssignmentPolicyCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessPackageId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AccessPackageAssignmentPolicyId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AllowedTargetScope? AllowedTargetScope { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageAutomaticRequestSettings? AutomaticRequestSettings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.ExpirationPattern? Expiration { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageNotificationSettings? NotificationSettings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageAssignmentApprovalSettings? RequestApprovalSettings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageAssignmentRequestorSettings? RequestorSettings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageAssignmentReviewSettings? ReviewSettings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.SubjectSet[]? SpecificAllowedTargets { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AccessPackageAssignmentPolicyId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageAssignmentPolicy();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(ModifiedDateTime)))
        body.ModifiedDateTime = ModifiedDateTime;

    if (this.IsParameterBound(nameof(AllowedTargetScope)))
        body.AllowedTargetScope = AllowedTargetScope;

    if (this.IsParameterBound(nameof(AutomaticRequestSettings)))
        body.AutomaticRequestSettings = AutomaticRequestSettings;

    if (this.IsParameterBound(nameof(Expiration)))
        body.Expiration = Expiration;

    if (this.IsParameterBound(nameof(NotificationSettings)))
        body.NotificationSettings = NotificationSettings;

    if (this.IsParameterBound(nameof(RequestApprovalSettings)))
        body.RequestApprovalSettings = RequestApprovalSettings;

    if (this.IsParameterBound(nameof(RequestorSettings)))
        body.RequestorSettings = RequestorSettings;

    if (this.IsParameterBound(nameof(ReviewSettings)))
        body.ReviewSettings = ReviewSettings;

    if (this.IsParameterBound(nameof(SpecificAllowedTargets)))
        body.SpecificAllowedTargets = SpecificAllowedTargets!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageAssignmentPolicy? result;
            try
            {
                result = client.IdentityGovernance.EntitlementManagement.AccessPackages[AccessPackageId].AssignmentPolicies[AccessPackageAssignmentPolicyId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AccessPackageAssignmentPolicyId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityGovernance.EntitlementManagement.AccessPackages[AccessPackageId].AssignmentPolicies[AccessPackageAssignmentPolicyId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, AccessPackageAssignmentPolicyId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
