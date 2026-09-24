#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Reports.Client;
using Microsoft.Graph.PowerShell.Reports.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Reports
{
    [GraphRoute("POST", "/reports/identityAnalytics/groups")]
    [Cmdlet(VerbsCommon.New, "MgReportIdentityAnalyticGroup", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.GroupAnalytics))]
    public class NewMgReportIdentityAnalyticGroupCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public long? AssignedRoleCount { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CalculatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public long? DirectGroupMemberCount { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? DynamicMembershipType { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? GroupExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public long? GuestOwnerCount { get; set; }

        [Parameter(Mandatory = false)]
        public long? GuestTransitiveUserCount { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsCloudDistributionListGroup { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsCloudM365Group { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsCloudMailEnabledSecurityGroup { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsCloudSecurityGroup { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsDynamicGroup { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsOnPremiseDistributionListGroup { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsOnPremiseMailEnabledSecurityGroup { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsOnPremiseSecurityGroup { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsValidGroup { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastRestorationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public long? MemberOwnerCount { get; set; }

        [Parameter(Mandatory = false)]
        public long? MembershipRuleContainsCount { get; set; }

        [Parameter(Mandatory = false)]
        public long? MembershipRuleExpressionCount { get; set; }

        [Parameter(Mandatory = false)]
        public long? MembershipRuleMatchCount { get; set; }

        [Parameter(Mandatory = false)]
        public long? MembershipRuleMemberOfCount { get; set; }

        [Parameter(Mandatory = false)]
        public string? MembershipRuleProcessingState { get; set; }

        [Parameter(Mandatory = false)]
        public long? MemberTransitiveUserCount { get; set; }

        [Parameter(Mandatory = false)]
        public string? PreferredDataLocation { get; set; }

        [Parameter(Mandatory = false)]
        public long? SensitivityLabelCount { get; set; }

        [Parameter(Mandatory = false)]
        public long? ServicePrincipalOwnerCount { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? SoftDeletionDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? TenantId { get; set; }

        [Parameter(Mandatory = false)]
        public long? TransitiveServicePrincipalCount { get; set; }

        [Parameter(Mandatory = false)]
        public long? TransitiveUserCount { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.GroupTypeEnum? GroupType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.GroupAnalytics();

    if (this.IsParameterBound(nameof(AssignedRoleCount)))
        body.AssignedRoleCount = AssignedRoleCount;

    if (this.IsParameterBound(nameof(CalculatedDateTime)))
        body.CalculatedDateTime = CalculatedDateTime;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(DirectGroupMemberCount)))
        body.DirectGroupMemberCount = DirectGroupMemberCount;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(DynamicMembershipType)))
        body.DynamicMembershipType = DynamicMembershipType;

    if (this.IsParameterBound(nameof(GroupExpirationDateTime)))
        body.GroupExpirationDateTime = GroupExpirationDateTime;

    if (this.IsParameterBound(nameof(GuestOwnerCount)))
        body.GuestOwnerCount = GuestOwnerCount;

    if (this.IsParameterBound(nameof(GuestTransitiveUserCount)))
        body.GuestTransitiveUserCount = GuestTransitiveUserCount;

    if (this.IsParameterBound(nameof(IsCloudDistributionListGroup)))
        body.IsCloudDistributionListGroup = IsCloudDistributionListGroup;

    if (this.IsParameterBound(nameof(IsCloudM365Group)))
        body.IsCloudM365Group = IsCloudM365Group;

    if (this.IsParameterBound(nameof(IsCloudMailEnabledSecurityGroup)))
        body.IsCloudMailEnabledSecurityGroup = IsCloudMailEnabledSecurityGroup;

    if (this.IsParameterBound(nameof(IsCloudSecurityGroup)))
        body.IsCloudSecurityGroup = IsCloudSecurityGroup;

    if (this.IsParameterBound(nameof(IsDynamicGroup)))
        body.IsDynamicGroup = IsDynamicGroup;

    if (this.IsParameterBound(nameof(IsOnPremiseDistributionListGroup)))
        body.IsOnPremiseDistributionListGroup = IsOnPremiseDistributionListGroup;

    if (this.IsParameterBound(nameof(IsOnPremiseMailEnabledSecurityGroup)))
        body.IsOnPremiseMailEnabledSecurityGroup = IsOnPremiseMailEnabledSecurityGroup;

    if (this.IsParameterBound(nameof(IsOnPremiseSecurityGroup)))
        body.IsOnPremiseSecurityGroup = IsOnPremiseSecurityGroup;

    if (this.IsParameterBound(nameof(IsValidGroup)))
        body.IsValidGroup = IsValidGroup;

    if (this.IsParameterBound(nameof(LastRestorationDateTime)))
        body.LastRestorationDateTime = LastRestorationDateTime;

    if (this.IsParameterBound(nameof(MemberOwnerCount)))
        body.MemberOwnerCount = MemberOwnerCount;

    if (this.IsParameterBound(nameof(MembershipRuleContainsCount)))
        body.MembershipRuleContainsCount = MembershipRuleContainsCount;

    if (this.IsParameterBound(nameof(MembershipRuleExpressionCount)))
        body.MembershipRuleExpressionCount = MembershipRuleExpressionCount;

    if (this.IsParameterBound(nameof(MembershipRuleMatchCount)))
        body.MembershipRuleMatchCount = MembershipRuleMatchCount;

    if (this.IsParameterBound(nameof(MembershipRuleMemberOfCount)))
        body.MembershipRuleMemberOfCount = MembershipRuleMemberOfCount;

    if (this.IsParameterBound(nameof(MembershipRuleProcessingState)))
        body.MembershipRuleProcessingState = MembershipRuleProcessingState;

    if (this.IsParameterBound(nameof(MemberTransitiveUserCount)))
        body.MemberTransitiveUserCount = MemberTransitiveUserCount;

    if (this.IsParameterBound(nameof(PreferredDataLocation)))
        body.PreferredDataLocation = PreferredDataLocation;

    if (this.IsParameterBound(nameof(SensitivityLabelCount)))
        body.SensitivityLabelCount = SensitivityLabelCount;

    if (this.IsParameterBound(nameof(ServicePrincipalOwnerCount)))
        body.ServicePrincipalOwnerCount = ServicePrincipalOwnerCount;

    if (this.IsParameterBound(nameof(SoftDeletionDateTime)))
        body.SoftDeletionDateTime = SoftDeletionDateTime;

    if (this.IsParameterBound(nameof(TenantId)))
        body.TenantId = TenantId;

    if (this.IsParameterBound(nameof(TransitiveServicePrincipalCount)))
        body.TransitiveServicePrincipalCount = TransitiveServicePrincipalCount;

    if (this.IsParameterBound(nameof(TransitiveUserCount)))
        body.TransitiveUserCount = TransitiveUserCount;

    if (this.IsParameterBound(nameof(GroupType)))
        body.GroupType = GroupType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.GroupAnalytics? result;
            try
            {
                result = client.Reports.IdentityAnalytics.Groups.PostAsync(body, requestConfiguration =>
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
