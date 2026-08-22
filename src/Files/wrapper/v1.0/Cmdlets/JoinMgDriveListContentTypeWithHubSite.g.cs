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
    [GraphRoute("POST", "/drives/{drive-id}/list/contentTypes/{contentType-id}/associateWithHubSites")]
    [Cmdlet(VerbsCommon.Join, "MgDriveListContentTypeWithHubSite", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class JoinMgDriveListContentTypeWithHubSiteCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ContentTypeId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? HubSiteUrls { get; set; }

        [Parameter(Mandatory = false)]
        public bool? PropagateToExistingLists { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ContentTypeId, "Join"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.List.ContentTypes.Item.AssociateWithHubSites.AssociateWithHubSitesPostRequestBody();

    if (this.IsParameterBound(nameof(HubSiteUrls)))
        body.HubSiteUrls = HubSiteUrls!.ToList();

    if (this.IsParameterBound(nameof(PropagateToExistingLists)))
        body.PropagateToExistingLists = PropagateToExistingLists;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Drives[DriveId].List.ContentTypes[ContentTypeId].AssociateWithHubSites.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, ContentTypeId);
                return;
            }

        }
    }
}
