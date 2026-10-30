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
    [GraphRoute("POST", "/groups/{group-id}/sites/{site-id}/contentModels/{contentModel-id}/addToDrive")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgGroupSiteContentModelAddToDrive", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.ContentModelUsage))]
    public class InvokeMgGroupSiteContentModelAddToDriveCommand : GraphClientCmdlet
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

            var body = new global::Microsoft.Graph.PowerShell.Sites.Client.Groups.Item.Sites.Item.ContentModels.Item.AddToDrive.AddToDrivePostRequestBody();

    if (this.IsParameterBound(nameof(DriveId)))
        body.DriveId = DriveId;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.ContentModelUsage? result;
            try
            {
                result = client.Groups[GroupId].Sites[SiteId].ContentModels[ContentModelId].AddToDrive.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ContentModelId);
                return;
            }

            WriteObject(result);
        }
    }
}
