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
    [GraphRoute("POST", "/identityGovernance/entitlementManagement/accessPackages/{accessPackage-id}/moveToCatalog")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgEntitlementManagementAccessPackageMoveToCatalog", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgEntitlementManagementAccessPackageMoveToCatalogCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessPackageId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? CatalogId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AccessPackageId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.Governance.Client.IdentityGovernance.EntitlementManagement.AccessPackages.Item.MoveToCatalog.MoveToCatalogPostRequestBody();

    if (this.IsParameterBound(nameof(CatalogId)))
        body.CatalogId = CatalogId;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.IdentityGovernance.EntitlementManagement.AccessPackages[AccessPackageId].MoveToCatalog.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AccessPackageId);
                return;
            }

        }
    }
}
