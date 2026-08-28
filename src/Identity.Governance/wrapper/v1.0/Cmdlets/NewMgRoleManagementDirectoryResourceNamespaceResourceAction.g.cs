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
    [GraphRoute("POST", "/roleManagement/directory/resourceNamespaces/{unifiedRbacResourceNamespace-id}/resourceActions")]
    [Cmdlet(VerbsCommon.New, "MgRoleManagementDirectoryResourceNamespaceResourceAction", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRbacResourceAction))]
    public class NewMgRoleManagementDirectoryResourceNamespaceResourceActionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UnifiedRbacResourceNamespaceId { get; set; } = string.Empty;

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
            if (!ShouldProcess(UnifiedRbacResourceNamespaceId, "New"))
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
                result = client.RoleManagement.Directory.ResourceNamespaces[UnifiedRbacResourceNamespaceId].ResourceActions.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
