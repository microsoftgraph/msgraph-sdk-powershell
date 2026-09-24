#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Enrollment
{
    [GraphRoute("POST", "/roleManagement/deviceManagement/resourceNamespaces/{unifiedRbacResourceNamespace-id}/importResourceActions")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgRoleManagementDeviceManagementResourceNamespaceImportResourceActions", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.UnifiedRbacResourceNamespace))]
    public class InvokeMgRoleManagementDeviceManagementResourceNamespaceImportResourceActionsCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
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

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.RoleManagement.DeviceManagement.ResourceNamespaces.Item.ImportResourceActions.ImportResourceActionsPostRequestBody();

    if (this.IsParameterBound(nameof(Format)))
        body.Format = Format;

    if (this.IsParameterBound(nameof(Value)))
        body.Value = Value;

    if (this.IsParameterBound(nameof(OverwriteResourceNamespace)))
        body.OverwriteResourceNamespace = OverwriteResourceNamespace;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.UnifiedRbacResourceNamespace? result;
            try
            {
                result = client.RoleManagement.DeviceManagement.ResourceNamespaces[UnifiedRbacResourceNamespaceId].ImportResourceActions.PostAsync(body, requestConfiguration =>
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
