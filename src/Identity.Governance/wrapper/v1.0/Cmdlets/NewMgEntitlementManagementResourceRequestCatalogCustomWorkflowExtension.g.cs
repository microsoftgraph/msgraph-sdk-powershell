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
    [GraphRoute("POST", "/identityGovernance/entitlementManagement/resourceRequests/{accessPackageResourceRequest-id}/catalog/customWorkflowExtensions")]
    [Cmdlet(VerbsCommon.New, "MgEntitlementManagementResourceRequestCatalogCustomWorkflowExtension", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.CustomCalloutExtension))]
    public class NewMgEntitlementManagementResourceRequestCatalogCustomWorkflowExtensionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessPackageResourceRequestId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.CustomExtensionAuthenticationConfiguration? AuthenticationConfiguration { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.CustomExtensionClientConfiguration? ClientConfiguration { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.CustomExtensionEndpointConfiguration? EndpointConfiguration { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AccessPackageResourceRequestId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.CustomCalloutExtension();

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(AuthenticationConfiguration)))
        body.AuthenticationConfiguration = AuthenticationConfiguration;

    if (this.IsParameterBound(nameof(ClientConfiguration)))
        body.ClientConfiguration = ClientConfiguration;

    if (this.IsParameterBound(nameof(EndpointConfiguration)))
        body.EndpointConfiguration = EndpointConfiguration;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.CustomCalloutExtension? result;
            try
            {
                result = client.IdentityGovernance.EntitlementManagement.ResourceRequests[AccessPackageResourceRequestId].Catalog.CustomWorkflowExtensions.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
