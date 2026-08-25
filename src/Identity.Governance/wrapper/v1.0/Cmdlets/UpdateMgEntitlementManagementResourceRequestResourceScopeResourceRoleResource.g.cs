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
    [GraphRoute("POST", "/identityGovernance/entitlementManagement/resourceRequests/{accessPackageResourceRequest-id}/resource/scopes/{accessPackageResourceScope-id}/resource/roles/{accessPackageResourceRole-id}/resource/refresh")]
    [Cmdlet(VerbsData.Update, "MgEntitlementManagementResourceRequestResourceScopeResourceRoleResource", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class UpdateMgEntitlementManagementResourceRequestResourceScopeResourceRoleResourceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessPackageResourceRequestId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AccessPackageResourceScopeId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string AccessPackageResourceRoleId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AccessPackageResourceRoleId, "Update"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.IdentityGovernance.EntitlementManagement.ResourceRequests[AccessPackageResourceRequestId].Resource.Scopes[AccessPackageResourceScopeId].Resource.Roles[AccessPackageResourceRoleId].Resource.Refresh.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, AccessPackageResourceRoleId);
                return;
            }

        }
    }
}
