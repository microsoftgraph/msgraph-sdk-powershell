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
    [GraphRoute("POST", "/roleManagement/enterpriseApps/{rbacApplication-id}/resourceNamespaces/{unifiedRbacResourceNamespace-id}/importResourceActions")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgRoleManagementEnterpriseAppResourceNamespaceImportResourceActions", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRbacResourceNamespace))]
    public class InvokeMgRoleManagementEnterpriseAppResourceNamespaceImportResourceActionsCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string RbacApplicationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string UnifiedRbacResourceNamespaceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Format { get; set; }

        [Parameter(Mandatory = false)]
        public string? Value { get; set; }

        [Parameter(Mandatory = false)]
        public bool? OverwriteResourceNamespace { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UnifiedRbacResourceNamespaceId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Identity.Governance.Client.RoleManagement.EnterpriseApps.Item.ResourceNamespaces.Item.ImportResourceActions.ImportResourceActionsPostRequestBody();

    if (this.IsParameterBound(nameof(Format)))
        body.Format = Format;

    if (this.IsParameterBound(nameof(Value)))
        body.Value = Value;

    if (this.IsParameterBound(nameof(OverwriteResourceNamespace)))
        body.OverwriteResourceNamespace = OverwriteResourceNamespace;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UnifiedRbacResourceNamespace? result;
            try
            {
                result = client.RoleManagement.EnterpriseApps[RbacApplicationId].ResourceNamespaces[UnifiedRbacResourceNamespaceId].ImportResourceActions.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UnifiedRbacResourceNamespaceId);
                return;
            }

            WriteObject(result);
        }
    }
}
