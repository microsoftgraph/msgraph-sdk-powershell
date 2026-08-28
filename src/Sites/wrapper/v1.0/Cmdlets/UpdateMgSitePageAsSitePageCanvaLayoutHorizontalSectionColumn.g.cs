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
    [GraphRoute("PATCH", "/sites/{site-id}/pages/{baseSitePage-id}/graph.sitePage/canvasLayout/horizontalSections/{horizontalSection-id}/columns/{horizontalSectionColumn-id}")]
    [Cmdlet(VerbsData.Update, "MgSitePageAsSitePageCanvaLayoutHorizontalSectionColumn", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.HorizontalSectionColumn))]
    public class UpdateMgSitePageAsSitePageCanvaLayoutHorizontalSectionColumnCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string BaseSitePageId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string HorizontalSectionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string HorizontalSectionColumnId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? Width { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(HorizontalSectionColumnId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Sites.Client.Models.HorizontalSectionColumn();

    if (this.IsParameterBound(nameof(Width)))
        body.Width = Width;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.HorizontalSectionColumn? result;
            try
            {
                result = client.Sites[SiteId].Pages[BaseSitePageId].GraphSitePage.CanvasLayout.HorizontalSections[HorizontalSectionId].Columns[HorizontalSectionColumnId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, HorizontalSectionColumnId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Sites[SiteId].Pages[BaseSitePageId].GraphSitePage.CanvasLayout.HorizontalSections[HorizontalSectionId].Columns[HorizontalSectionColumnId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, HorizontalSectionColumnId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
