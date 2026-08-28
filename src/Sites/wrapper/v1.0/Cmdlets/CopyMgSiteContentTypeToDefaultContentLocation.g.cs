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
    [GraphRoute("POST", "/sites/{site-id}/contentTypes/{contentType-id}/copyToDefaultContentLocation")]
    [Cmdlet(VerbsCommon.Copy, "MgSiteContentTypeToDefaultContentLocation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class CopyMgSiteContentTypeToDefaultContentLocationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ContentTypeId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DestinationFileName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.ItemReference? SourceFile { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ContentTypeId, "Copy"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Sites.Client.Sites.Item.ContentTypes.Item.CopyToDefaultContentLocation.CopyToDefaultContentLocationPostRequestBody();

    if (this.IsParameterBound(nameof(DestinationFileName)))
        body.DestinationFileName = DestinationFileName;
    if (this.IsParameterBound(nameof(SourceFile)))
        body.SourceFile = SourceFile;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Sites[SiteId].ContentTypes[ContentTypeId].CopyToDefaultContentLocation.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ContentTypeId);
                return;
            }

        }
    }
}
