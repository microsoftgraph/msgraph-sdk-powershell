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
    [GraphRoute("POST", "/groups/{group-id}/sites/{site-id}/contentModels/{contentModel-id}/removeFromDrive")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgGroupSiteContentModelRemoveFromDrive", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgGroupSiteContentModelRemoveFromDriveCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ContentModelId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DriveId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ContentModelId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Sites.Client.Groups.Item.Sites.Item.ContentModels.Item.RemoveFromDrive.RemoveFromDrivePostRequestBody();

    if (this.IsParameterBound(nameof(DriveId)))
        body.DriveId = DriveId;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Groups[GroupId].Sites[SiteId].ContentModels[ContentModelId].RemoveFromDrive.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ContentModelId);
                return;
            }

        }
    }
}
