#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Files.Client;
using Microsoft.Graph.PowerShell.Files.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Files
{
    [GraphRoute("POST", "/drives/{drive-id}/list/permissions/{permission-id}/revokeGrants")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDriveListPermissionRevokeGrants", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.Permission))]
    public class InvokeMgDriveListPermissionRevokeGrantsCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PermissionId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.DriveRecipient[]? Grantees { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PermissionId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.List.Permissions.Item.RevokeGrants.RevokeGrantsPostRequestBody();

    if (this.IsParameterBound(nameof(Grantees)))
        body.Grantees = Grantees!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.Permission? result;
            try
            {
                result = client.Drives[DriveId].List.Permissions[PermissionId].RevokeGrants.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PermissionId);
                return;
            }

            WriteObject(result);
        }
    }
}
