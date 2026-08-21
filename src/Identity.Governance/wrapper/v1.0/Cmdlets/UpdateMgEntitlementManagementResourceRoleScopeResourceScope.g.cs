#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Governance.Client;
using Microsoft.Graph.PowerShell.Identity.Governance.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("PATCH", "/identityGovernance/entitlementManagement/resourceRoleScopes/{accessPackageResourceRoleScope-id}/scope/resource/scopes/{accessPackageResourceScope-id}")]
    [Cmdlet(VerbsData.Update, "MgEntitlementManagementResourceRoleScopeResourceScope", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageResourceScope))]
    public class UpdateMgEntitlementManagementResourceRoleScopeResourceScopeCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessPackageResourceRoleScopeId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AccessPackageResourceScopeId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsRootScope { get; set; }

        [Parameter(Mandatory = false)]
        public string? OriginId { get; set; }

        [Parameter(Mandatory = false)]
        public string? OriginSystem { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AccessPackageResourceScopeId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageResourceScope();

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IsRootScope)))
        body.IsRootScope = IsRootScope;

    if (this.IsParameterBound(nameof(OriginId)))
        body.OriginId = OriginId;

    if (this.IsParameterBound(nameof(OriginSystem)))
        body.OriginSystem = OriginSystem;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageResourceScope? result;
            try
            {
                result = client.IdentityGovernance.EntitlementManagement.ResourceRoleScopes[AccessPackageResourceRoleScopeId].Scope.Resource.Scopes[AccessPackageResourceScopeId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, AccessPackageResourceScopeId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityGovernance.EntitlementManagement.ResourceRoleScopes[AccessPackageResourceRoleScopeId].Scope.Resource.Scopes[AccessPackageResourceScopeId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, AccessPackageResourceScopeId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
