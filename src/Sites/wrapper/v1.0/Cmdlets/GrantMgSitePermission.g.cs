#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Sites.Client;
using Microsoft.Graph.PowerShell.Sites.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Sites
{
    [GraphRoute("POST", "/sites/{site-id}/permissions/{permission-id}/grant")]
    [Cmdlet(VerbsSecurity.Grant, "MgSitePermission", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Sites.Client.Sites.Item.Permissions.Item.Grant.GrantPostResponse))]
    public class GrantMgSitePermissionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string PermissionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? Roles { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.DriveRecipient[]? Recipients { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PermissionId, "Grant"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Sites.Client.Sites.Item.Permissions.Item.Grant.GrantPostRequestBody();

    if (this.IsParameterBound(nameof(Roles)))
        body.Roles = Roles!.ToList();
    if (this.IsParameterBound(nameof(Recipients)))
        body.Recipients = Recipients!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Sites.Client.Sites.Item.Permissions.Item.Grant.GrantPostResponse? result;
            try
            {
                result = client.Sites[SiteId].Permissions[PermissionId].Grant.PostAsGrantPostResponseAsync(body, requestConfiguration =>
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
