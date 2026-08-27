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
    [GraphRoute("PATCH", "/roleManagement/directory/resourceNamespaces/{unifiedRbacResourceNamespace-id}")]
    [Cmdlet(VerbsData.Update, "MgRoleManagementDirectoryResourceNamespace", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRbacResourceNamespace))]
    public class UpdateMgRoleManagementDirectoryResourceNamespaceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UnifiedRbacResourceNamespaceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UnifiedRbacResourceNamespaceId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRbacResourceNamespace();

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRbacResourceNamespace? result;
            try
            {
                result = client.RoleManagement.Directory.ResourceNamespaces[UnifiedRbacResourceNamespaceId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, UnifiedRbacResourceNamespaceId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.RoleManagement.Directory.ResourceNamespaces[UnifiedRbacResourceNamespaceId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, UnifiedRbacResourceNamespaceId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
