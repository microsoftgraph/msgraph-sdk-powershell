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
    [GraphRoute("PATCH", "/identityGovernance/entitlementManagement/resourceRequests/{accessPackageResourceRequest-id}/catalog")]
    [Cmdlet(VerbsData.Update, "MgEntitlementManagementResourceRequestCatalog", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageCatalog))]
    public class UpdateMgEntitlementManagementResourceRequestCatalogCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessPackageResourceRequestId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsExternallyVisible { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageCatalogType? CatalogType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageCatalogState? State { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AccessPackageResourceRequestId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageCatalog();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IsExternallyVisible)))
        body.IsExternallyVisible = IsExternallyVisible;

    if (this.IsParameterBound(nameof(ModifiedDateTime)))
        body.ModifiedDateTime = ModifiedDateTime;

    if (this.IsParameterBound(nameof(CatalogType)))
        body.CatalogType = CatalogType;

    if (this.IsParameterBound(nameof(State)))
        body.State = State;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AccessPackageCatalog? result;
            try
            {
                result = client.IdentityGovernance.EntitlementManagement.ResourceRequests[AccessPackageResourceRequestId].Catalog.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, AccessPackageResourceRequestId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityGovernance.EntitlementManagement.ResourceRequests[AccessPackageResourceRequestId].Catalog.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, AccessPackageResourceRequestId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
