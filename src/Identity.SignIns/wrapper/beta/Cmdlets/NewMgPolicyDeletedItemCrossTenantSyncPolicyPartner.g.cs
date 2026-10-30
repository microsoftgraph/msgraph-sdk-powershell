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
    [GraphRoute("POST", "/policies/deletedItems/crossTenantSyncPolicyPartners")]
    [Cmdlet(VerbsCommon.New, "MgPolicyDeletedItemCrossTenantSyncPolicyPartner", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantIdentitySyncPolicyPartner))]
    public class NewMgPolicyDeletedItemCrossTenantSyncPolicyPartnerCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DeletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? ExternalCloudAuthorizedApplicationId { get; set; }

        [Parameter(Mandatory = false)]
        public string? TenantId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantGroupSyncInbound? GroupSyncInbound { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantRoleEnabledGroupSyncInbound? RoleEnabledGroupSyncInbound { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantUserSyncInbound? UserSyncInbound { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantIdentitySyncPolicyPartner();

    if (this.IsParameterBound(nameof(DeletedDateTime)))
        body.DeletedDateTime = DeletedDateTime;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(ExternalCloudAuthorizedApplicationId)))
        body.ExternalCloudAuthorizedApplicationId = ExternalCloudAuthorizedApplicationId;

    if (this.IsParameterBound(nameof(TenantId)))
        body.TenantId = TenantId;

    if (this.IsParameterBound(nameof(GroupSyncInbound)))
        body.GroupSyncInbound = GroupSyncInbound;

    if (this.IsParameterBound(nameof(RoleEnabledGroupSyncInbound)))
        body.RoleEnabledGroupSyncInbound = RoleEnabledGroupSyncInbound;

    if (this.IsParameterBound(nameof(UserSyncInbound)))
        body.UserSyncInbound = UserSyncInbound;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantIdentitySyncPolicyPartner? result;
            try
            {
                result = client.Policies.DeletedItems.CrossTenantSyncPolicyPartners.PostAsync(body, requestConfiguration =>
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
