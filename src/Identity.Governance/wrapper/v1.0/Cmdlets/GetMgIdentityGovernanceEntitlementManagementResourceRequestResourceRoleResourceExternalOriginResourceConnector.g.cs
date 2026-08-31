#nullable enable

using System;
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
    [GraphRoute("GET", "/identityGovernance/entitlementManagement/resourceRequests/{accessPackageResourceRequest-id}/resource/roles/{accessPackageResourceRole-id}/resource/externalOriginResourceConnector")]
    [Cmdlet(VerbsCommon.Get, "MgIdentityGovernanceEntitlementManagementResourceRequestResourceRoleResourceExternalOriginResourceConnector")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.ExternalOriginResourceConnector))]
    public class GetMgIdentityGovernanceEntitlementManagementResourceRequestResourceRoleResourceExternalOriginResourceConnectorCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessPackageResourceRequestId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string AccessPackageResourceRoleId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.ExternalOriginResourceConnector? result;
            try
            {
                result = client.IdentityGovernance.EntitlementManagement.ResourceRequests[AccessPackageResourceRequestId].Resource.Roles[AccessPackageResourceRoleId].Resource.ExternalOriginResourceConnector.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AccessPackageResourceRoleId);
                return;
            }

            WriteObject(result);
        }
    }
}
