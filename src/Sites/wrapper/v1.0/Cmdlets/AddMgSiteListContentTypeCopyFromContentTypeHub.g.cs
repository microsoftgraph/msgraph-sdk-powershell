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
    [GraphRoute("POST", "/sites/{site-id}/lists/{list-id}/contentTypes/addCopyFromContentTypeHub")]
    [Cmdlet(VerbsCommon.Add, "MgSiteListContentTypeCopyFromContentTypeHub", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.ContentType))]
    public class AddMgSiteListContentTypeCopyFromContentTypeHubCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ListId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ContentTypeId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ListId, "Add"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Sites.Client.Sites.Item.Lists.Item.ContentTypes.AddCopyFromContentTypeHub.AddCopyFromContentTypeHubPostRequestBody();

    if (this.IsParameterBound(nameof(ContentTypeId)))
        body.ContentTypeId = ContentTypeId;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.ContentType? result;
            try
            {
                result = client.Sites[SiteId].Lists[ListId].ContentTypes.AddCopyFromContentTypeHub.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ListId);
                return;
            }

            WriteObject(result);
        }
    }
}
