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
    [GraphRoute("PATCH", "/tenantRelationships/multiTenantOrganization/joinRequest")]
    [Cmdlet(VerbsData.Update, "MgTenantRelationshipMultiTenantOrganizationJoinRequest", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.MultiTenantOrganizationJoinRequestRecord))]
    public class UpdateMgTenantRelationshipMultiTenantOrganizationJoinRequestCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? AddedByTenantId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.MultiTenantOrganizationMemberState? MemberState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.MultiTenantOrganizationMemberRole? Role { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.MultiTenantOrganizationJoinRequestTransitionDetails? TransitionDetails { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.MultiTenantOrganizationJoinRequestRecord();

    if (this.IsParameterBound(nameof(AddedByTenantId)))
        body.AddedByTenantId = AddedByTenantId;

    if (this.IsParameterBound(nameof(MemberState)))
        body.MemberState = MemberState;

    if (this.IsParameterBound(nameof(Role)))
        body.Role = Role;

    if (this.IsParameterBound(nameof(TransitionDetails)))
        body.TransitionDetails = TransitionDetails;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.MultiTenantOrganizationJoinRequestRecord? result;
            try
            {
                result = client.TenantRelationships.MultiTenantOrganization.JoinRequest.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.TenantRelationships.MultiTenantOrganization.JoinRequest.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, null);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
