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
    [GraphRoute("PATCH", "/roleManagement/entitlementManagement/resourceNamespaces/{unifiedRbacResourceNamespace-id}/resourceActions/{unifiedRbacResourceAction-id}")]
    [Cmdlet(VerbsData.Update, "MgRoleManagementEntitlementManagementResourceNamespaceResourceAction", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRbacResourceAction))]
    public class UpdateMgRoleManagementEntitlementManagementResourceNamespaceResourceActionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UnifiedRbacResourceNamespaceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string UnifiedRbacResourceActionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ActionVerb { get; set; }

        [Parameter(Mandatory = false)]
        public string? AuthenticationContextId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsAuthenticationContextSettable { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public string? ResourceScopeId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UnifiedRbacResourceActionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRbacResourceAction();

    if (this.IsParameterBound(nameof(ActionVerb)))
        body.ActionVerb = ActionVerb;

    if (this.IsParameterBound(nameof(AuthenticationContextId)))
        body.AuthenticationContextId = AuthenticationContextId;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(IsAuthenticationContextSettable)))
        body.IsAuthenticationContextSettable = IsAuthenticationContextSettable;

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(ResourceScopeId)))
        body.ResourceScopeId = ResourceScopeId;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRbacResourceAction? result;
            try
            {
                result = client.RoleManagement.EntitlementManagement.ResourceNamespaces[UnifiedRbacResourceNamespaceId].ResourceActions[UnifiedRbacResourceActionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UnifiedRbacResourceActionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.RoleManagement.EntitlementManagement.ResourceNamespaces[UnifiedRbacResourceNamespaceId].ResourceActions[UnifiedRbacResourceActionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, UnifiedRbacResourceActionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
