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
    [GraphRoute("PATCH", "/sites/{site-id}/lists/{list-id}/contentTypes/{contentType-id}/columnLinks/{columnLink-id}")]
    [Cmdlet(VerbsData.Update, "MgSiteListContentTypeColumnLink", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.ColumnLink))]
    public class UpdateMgSiteListContentTypeColumnLinkCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ListId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ContentTypeId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string ColumnLinkId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ColumnLinkId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Sites.Client.Models.ColumnLink();

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.ColumnLink? result;
            try
            {
                result = client.Sites[SiteId].Lists[ListId].ContentTypes[ContentTypeId].ColumnLinks[ColumnLinkId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ColumnLinkId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Sites[SiteId].Lists[ListId].ContentTypes[ContentTypeId].ColumnLinks[ColumnLinkId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, ColumnLinkId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
