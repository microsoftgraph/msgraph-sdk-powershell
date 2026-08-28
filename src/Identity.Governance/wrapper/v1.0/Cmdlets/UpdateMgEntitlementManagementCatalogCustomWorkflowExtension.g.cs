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
    [GraphRoute("PATCH", "/identityGovernance/entitlementManagement/catalogs/{accessPackageCatalog-id}/customWorkflowExtensions/{customCalloutExtension-id}")]
    [Cmdlet(VerbsData.Update, "MgEntitlementManagementCatalogCustomWorkflowExtension", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.CustomCalloutExtension))]
    public class UpdateMgEntitlementManagementCatalogCustomWorkflowExtensionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AccessPackageCatalogId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string CustomCalloutExtensionId { get; set; } = string.Empty;

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
            if (!ShouldProcess(CustomCalloutExtensionId, "Update"))
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
                result = client.IdentityGovernance.EntitlementManagement.Catalogs[AccessPackageCatalogId].CustomWorkflowExtensions[CustomCalloutExtensionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, CustomCalloutExtensionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityGovernance.EntitlementManagement.Catalogs[AccessPackageCatalogId].CustomWorkflowExtensions[CustomCalloutExtensionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, CustomCalloutExtensionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
