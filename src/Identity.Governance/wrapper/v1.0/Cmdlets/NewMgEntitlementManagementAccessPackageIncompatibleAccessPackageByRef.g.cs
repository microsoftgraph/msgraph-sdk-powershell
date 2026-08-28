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
    [GraphRoute("POST", "/identityGovernance/entitlementManagement/accessPackages/{accessPackage-id}/incompatibleAccessPackages/$ref")]
    [Cmdlet(VerbsCommon.New, "MgEntitlementManagementAccessPackageIncompatibleAccessPackageByRef", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class NewMgEntitlementManagementAccessPackageIncompatibleAccessPackageByRefCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessPackageId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? OdataId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AccessPackageId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.ReferenceCreate();

    if (this.IsParameterBound(nameof(OdataId)))
        body.OdataId = OdataId;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.IdentityGovernance.EntitlementManagement.AccessPackages[AccessPackageId].IncompatibleAccessPackages.Ref.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, AccessPackageId);
                return;
            }

        }
    }
}
