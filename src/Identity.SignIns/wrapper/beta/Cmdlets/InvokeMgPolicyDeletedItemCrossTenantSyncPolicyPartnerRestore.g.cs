#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client;
using Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.SignIns
{
    [GraphRoute("POST", "/policies/deletedItems/crossTenantSyncPolicyPartners/{crossTenantIdentitySyncPolicyPartner-tenantId}/restore")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgPolicyDeletedItemCrossTenantSyncPolicyPartnerRestore", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantIdentitySyncPolicyPartner))]
    public class InvokeMgPolicyDeletedItemCrossTenantSyncPolicyPartnerRestoreCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CrossTenantIdentitySyncPolicyPartnerTenantId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CrossTenantIdentitySyncPolicyPartnerTenantId, "Invoke"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantIdentitySyncPolicyPartner? result;
            try
            {
                result = client.Policies.DeletedItems.CrossTenantSyncPolicyPartners[CrossTenantIdentitySyncPolicyPartnerTenantId].Restore.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CrossTenantIdentitySyncPolicyPartnerTenantId);
                return;
            }

            WriteObject(result);
        }
    }
}
