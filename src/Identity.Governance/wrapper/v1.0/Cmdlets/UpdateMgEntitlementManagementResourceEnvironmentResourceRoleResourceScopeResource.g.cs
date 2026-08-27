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
    [GraphRoute("POST", "/identityGovernance/entitlementManagement/resourceEnvironments/{accessPackageResourceEnvironment-id}/resources/{accessPackageResource-id}/roles/{accessPackageResourceRole-id}/resource/scopes/{accessPackageResourceScope-id}/resource/refresh")]
    [Cmdlet(VerbsData.Update, "MgEntitlementManagementResourceEnvironmentResourceRoleResourceScopeResource", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class UpdateMgEntitlementManagementResourceEnvironmentResourceRoleResourceScopeResourceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessPackageResourceEnvironmentId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AccessPackageResourceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string AccessPackageResourceRoleId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string AccessPackageResourceScopeId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AccessPackageResourceScopeId, "Update"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.IdentityGovernance.EntitlementManagement.ResourceEnvironments[AccessPackageResourceEnvironmentId].Resources[AccessPackageResourceId].Roles[AccessPackageResourceRoleId].Resource.Scopes[AccessPackageResourceScopeId].Resource.Refresh.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, AccessPackageResourceScopeId);
                return;
            }

        }
    }
}
