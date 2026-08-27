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
    [GraphRoute("POST", "/identityGovernance/entitlementManagement/catalogs/{accessPackageCatalog-id}/resourceScopes")]
    [Cmdlet(VerbsCommon.New, "MgEntitlementManagementCatalogResourceScope", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageResourceScope))]
    public class NewMgEntitlementManagementCatalogResourceScopeCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessPackageCatalogId { get; set; } = string.Empty;

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
            if (!ShouldProcess(AccessPackageCatalogId, "New"))
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
                result = client.IdentityGovernance.EntitlementManagement.Catalogs[AccessPackageCatalogId].ResourceScopes.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
