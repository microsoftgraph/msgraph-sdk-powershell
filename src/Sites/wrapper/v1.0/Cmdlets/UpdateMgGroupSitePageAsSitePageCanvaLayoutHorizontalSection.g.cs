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
    [GraphRoute("PATCH", "/groups/{group-id}/sites/{site-id}/pages/{baseSitePage-id}/graph.sitePage/canvasLayout/horizontalSections/{horizontalSection-id}")]
    [Cmdlet(VerbsData.Update, "MgGroupSitePageAsSitePageCanvaLayoutHorizontalSection", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.HorizontalSection))]
    public class UpdateMgGroupSitePageAsSitePageCanvaLayoutHorizontalSectionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string BaseSitePageId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string HorizontalSectionId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.SectionEmphasisType? Emphasis { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.HorizontalSectionLayoutType? Layout { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(HorizontalSectionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Sites.Client.Models.HorizontalSection();


    if (this.IsParameterBound(nameof(Emphasis)))
        body.Emphasis = Emphasis;

    if (this.IsParameterBound(nameof(Layout)))
        body.Layout = Layout;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.HorizontalSection? result;
            try
            {
                result = client.Groups[GroupId].Sites[SiteId].Pages[BaseSitePageId].GraphSitePage.CanvasLayout.HorizontalSections[HorizontalSectionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, HorizontalSectionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Groups[GroupId].Sites[SiteId].Pages[BaseSitePageId].GraphSitePage.CanvasLayout.HorizontalSections[HorizontalSectionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, HorizontalSectionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
