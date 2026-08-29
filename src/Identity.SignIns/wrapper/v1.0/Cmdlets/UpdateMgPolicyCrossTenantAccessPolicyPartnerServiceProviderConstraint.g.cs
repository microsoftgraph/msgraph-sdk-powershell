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
    [GraphRoute("PATCH", "/policies/crossTenantAccessPolicy/partners/{crossTenantAccessPolicyConfigurationPartner-tenantId}/serviceProviderConstraints")]
    [Cmdlet(VerbsData.Update, "MgPolicyCrossTenantAccessPolicyPartnerServiceProviderConstraint", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.ServiceProviderConstraints))]
    public class UpdateMgPolicyCrossTenantAccessPolicyPartnerServiceProviderConstraintCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CrossTenantAccessPolicyConfigurationPartnerTenantId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CrossTenantAccessPolicyConfigurationPartnerTenantId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.ServiceProviderConstraints();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.ServiceProviderConstraints? result;
            try
            {
                result = client.Policies.CrossTenantAccessPolicy.Partners[CrossTenantAccessPolicyConfigurationPartnerTenantId].ServiceProviderConstraints.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CrossTenantAccessPolicyConfigurationPartnerTenantId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Policies.CrossTenantAccessPolicy.Partners[CrossTenantAccessPolicyConfigurationPartnerTenantId].ServiceProviderConstraints.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, CrossTenantAccessPolicyConfigurationPartnerTenantId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
