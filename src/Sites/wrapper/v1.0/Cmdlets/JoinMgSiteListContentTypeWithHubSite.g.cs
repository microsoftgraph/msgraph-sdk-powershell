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
    [GraphRoute("POST", "/sites/{site-id}/lists/{list-id}/contentTypes/{contentType-id}/associateWithHubSites")]
    [Cmdlet(VerbsCommon.Join, "MgSiteListContentTypeWithHubSite", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class JoinMgSiteListContentTypeWithHubSiteCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ListId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ContentTypeId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? HubSiteUrls { get; set; }

        [Parameter(Mandatory = false)]
        public bool? PropagateToExistingLists { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ContentTypeId, "Join"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Sites.Client.Sites.Item.Lists.Item.ContentTypes.Item.AssociateWithHubSites.AssociateWithHubSitesPostRequestBody();

    if (this.IsParameterBound(nameof(HubSiteUrls)))
        body.HubSiteUrls = HubSiteUrls!.ToList();

    if (this.IsParameterBound(nameof(PropagateToExistingLists)))
        body.PropagateToExistingLists = PropagateToExistingLists;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Sites[SiteId].Lists[ListId].ContentTypes[ContentTypeId].AssociateWithHubSites.PostAsync(body, requestConfiguration =>
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
