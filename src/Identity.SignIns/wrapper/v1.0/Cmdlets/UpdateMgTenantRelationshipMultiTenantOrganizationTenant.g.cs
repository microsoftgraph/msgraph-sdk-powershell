#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.SignIns
{
    [GraphRoute("PATCH", "/tenantRelationships/multiTenantOrganization/tenants/{multiTenantOrganizationMember-id}")]
    [Cmdlet(VerbsData.Update, "MgTenantRelationshipMultiTenantOrganizationTenant", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.MultiTenantOrganizationMember))]
    public class UpdateMgTenantRelationshipMultiTenantOrganizationTenantCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MultiTenantOrganizationMemberId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DeletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.Guid? AddedByTenantId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? AddedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? JoinedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? TenantId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.MultiTenantOrganizationMemberRole? Role { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.MultiTenantOrganizationMemberState? State { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.MultiTenantOrganizationMemberTransitionDetails? TransitionDetails { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MultiTenantOrganizationMemberId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.MultiTenantOrganizationMember();

    if (this.IsParameterBound(nameof(DeletedDateTime)))
        body.DeletedDateTime = DeletedDateTime;

    if (this.IsParameterBound(nameof(AddedByTenantId)))
        body.AddedByTenantId = AddedByTenantId;

    if (this.IsParameterBound(nameof(AddedDateTime)))
        body.AddedDateTime = AddedDateTime;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(JoinedDateTime)))
        body.JoinedDateTime = JoinedDateTime;

    if (this.IsParameterBound(nameof(TenantId)))
        body.TenantId = TenantId;

    if (this.IsParameterBound(nameof(Role)))
        body.Role = Role;

    if (this.IsParameterBound(nameof(State)))
        body.State = State;

    if (this.IsParameterBound(nameof(TransitionDetails)))
        body.TransitionDetails = TransitionDetails;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.MultiTenantOrganizationMember? result;
            try
            {
                result = client.TenantRelationships.MultiTenantOrganization.Tenants[MultiTenantOrganizationMemberId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, MultiTenantOrganizationMemberId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.TenantRelationships.MultiTenantOrganization.Tenants[MultiTenantOrganizationMemberId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, MultiTenantOrganizationMemberId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
