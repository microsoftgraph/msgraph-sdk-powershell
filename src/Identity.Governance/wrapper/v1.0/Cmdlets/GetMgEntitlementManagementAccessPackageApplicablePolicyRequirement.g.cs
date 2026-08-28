#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Governance.Client;
using Microsoft.Graph.PowerShell.Identity.Governance.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("POST", "/identityGovernance/entitlementManagement/accessPackages/{accessPackage-id}/getApplicablePolicyRequirements")]
    [Cmdlet(VerbsCommon.Get, "MgEntitlementManagementAccessPackageApplicablePolicyRequirement", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Identity.Governance.Client.IdentityGovernance.EntitlementManagement.AccessPackages.Item.GetApplicablePolicyRequirements.GetApplicablePolicyRequirementsPostResponse))]
    public class GetMgEntitlementManagementAccessPackageApplicablePolicyRequirementCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessPackageId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AccessPackageId, "Get"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Identity.Governance.Client.IdentityGovernance.EntitlementManagement.AccessPackages.Item.GetApplicablePolicyRequirements.GetApplicablePolicyRequirementsPostResponse? result;
            try
            {
                result = client.IdentityGovernance.EntitlementManagement.AccessPackages[AccessPackageId].GetApplicablePolicyRequirements.PostAsGetApplicablePolicyRequirementsPostResponseAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, AccessPackageId);
                return;
            }

            WriteObject(result);
        }
    }
}
