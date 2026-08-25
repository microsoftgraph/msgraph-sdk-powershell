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
    [GraphRoute("POST", "/sites/{site-id}/lists/{list-id}/items/{listItem-id}/documentSetVersions/{documentSetVersion-id}/restore")]
    [Cmdlet(VerbsData.Restore, "MgSiteListItemDocumentSetVersion", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class RestoreMgSiteListItemDocumentSetVersionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ListId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ListItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string DocumentSetVersionId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DocumentSetVersionId, "Restore"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Sites[SiteId].Lists[ListId].Items[ListItemId].DocumentSetVersions[DocumentSetVersionId].Restore.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, DocumentSetVersionId);
                return;
            }

        }
    }
}
