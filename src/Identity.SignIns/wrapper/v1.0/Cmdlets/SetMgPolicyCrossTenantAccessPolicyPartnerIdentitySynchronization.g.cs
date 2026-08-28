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
    [GraphRoute("PUT", "/policies/crossTenantAccessPolicy/partners/{crossTenantAccessPolicyConfigurationPartner-tenantId}/identitySynchronization")]
    [Cmdlet(VerbsCommon.Set, "MgPolicyCrossTenantAccessPolicyPartnerIdentitySynchronization", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantIdentitySyncPolicyPartner))]
    public class SetMgPolicyCrossTenantAccessPolicyPartnerIdentitySynchronizationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CrossTenantAccessPolicyConfigurationPartnerTenantId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? TenantId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantUserSyncInbound? UserSyncInbound { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CrossTenantAccessPolicyConfigurationPartnerTenantId, "Set"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantIdentitySyncPolicyPartner();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(TenantId)))
        body.TenantId = TenantId;

    if (this.IsParameterBound(nameof(UserSyncInbound)))
        body.UserSyncInbound = UserSyncInbound;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantIdentitySyncPolicyPartner? result;
            try
            {
                result = client.Policies.CrossTenantAccessPolicy.Partners[CrossTenantAccessPolicyConfigurationPartnerTenantId].IdentitySynchronization.PutAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, CrossTenantAccessPolicyConfigurationPartnerTenantId);
                return;
            }


            if (result is not null)
                WriteObject(result);
        }
    }
}
