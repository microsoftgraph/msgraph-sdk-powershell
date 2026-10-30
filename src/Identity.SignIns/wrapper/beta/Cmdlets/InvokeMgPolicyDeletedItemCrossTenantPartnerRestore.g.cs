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
    [GraphRoute("POST", "/policies/deletedItems/crossTenantPartners/{crossTenantAccessPolicyConfigurationPartner-tenantId}/restore")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgPolicyDeletedItemCrossTenantPartnerRestore", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantAccessPolicyConfigurationPartner))]
    public class InvokeMgPolicyDeletedItemCrossTenantPartnerRestoreCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CrossTenantAccessPolicyConfigurationPartnerTenantId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CrossTenantAccessPolicyConfigurationPartnerTenantId, "Invoke"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.CrossTenantAccessPolicyConfigurationPartner? result;
            try
            {
                result = client.Policies.DeletedItems.CrossTenantPartners[CrossTenantAccessPolicyConfigurationPartnerTenantId].Restore.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CrossTenantAccessPolicyConfigurationPartnerTenantId);
                return;
            }

            WriteObject(result);
        }
    }
}
