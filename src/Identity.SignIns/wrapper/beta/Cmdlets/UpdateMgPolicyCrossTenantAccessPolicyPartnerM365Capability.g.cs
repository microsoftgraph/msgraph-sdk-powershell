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
    [GraphRoute("PATCH", "/policies/crossTenantAccessPolicy/partners/{crossTenantAccessPolicyConfigurationPartner-tenantId}/m365Capabilities/{m365CapabilityBase-name}")]
    [Cmdlet(VerbsData.Update, "MgPolicyCrossTenantAccessPolicyPartnerM365Capability", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.M365CapabilityBase))]
    public class UpdateMgPolicyCrossTenantAccessPolicyPartnerM365CapabilityCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CrossTenantAccessPolicyConfigurationPartnerTenantId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string M365CapabilityBaseName { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.M365CapabilityInboundAccess? InboundAccess { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(M365CapabilityBaseName, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.M365CapabilityBase();

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(InboundAccess)))
        body.InboundAccess = InboundAccess;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.SignIns.Client.Models.M365CapabilityBase? result;
            try
            {
                result = client.Policies.CrossTenantAccessPolicy.Partners[CrossTenantAccessPolicyConfigurationPartnerTenantId].M365Capabilities[M365CapabilityBaseName].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, M365CapabilityBaseName);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Policies.CrossTenantAccessPolicy.Partners[CrossTenantAccessPolicyConfigurationPartnerTenantId].M365Capabilities[M365CapabilityBaseName].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, M365CapabilityBaseName);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
