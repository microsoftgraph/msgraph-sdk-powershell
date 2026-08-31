#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Sites.Client;
using Microsoft.Graph.PowerShell.Sites.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Sites
{
    [GraphRoute("POST", "/groups/{group-id}/sites/{site-id}/lists/{list-id}/items/{listItem-id}/documentSetVersions")]
    [Cmdlet(VerbsCommon.New, "MgGroupSiteListItemDocumentSetVersion", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.DocumentSetVersion))]
    public class NewMgGroupSiteListItemDocumentSetVersionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ListId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string ListItemId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Comment { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ShouldCaptureMinorVersion { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.IdentitySet? LastModifiedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.PublicationFacet? Publication { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.IdentitySet? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.DocumentSetVersionItem[]? Items { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ListItemId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Sites.Client.Models.DocumentSetVersion();

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(Comment)))
        body.Comment = Comment;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(ShouldCaptureMinorVersion)))
        body.ShouldCaptureMinorVersion = ShouldCaptureMinorVersion;

    if (this.IsParameterBound(nameof(LastModifiedBy)))
        body.LastModifiedBy = LastModifiedBy;

    if (this.IsParameterBound(nameof(Publication)))
        body.Publication = Publication;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(Items)))
        body.Items = Items!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.DocumentSetVersion? result;
            try
            {
                result = client.Groups[GroupId].Sites[SiteId].Lists[ListId].Items[ListItemId].DocumentSetVersions.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
