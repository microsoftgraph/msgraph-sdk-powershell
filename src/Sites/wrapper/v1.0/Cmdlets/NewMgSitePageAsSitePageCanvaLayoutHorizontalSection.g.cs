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
    [GraphRoute("POST", "/sites/{site-id}/pages/{baseSitePage-id}/graph.sitePage/canvasLayout/horizontalSections")]
    [Cmdlet(VerbsCommon.New, "MgSitePageAsSitePageCanvaLayoutHorizontalSection", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.HorizontalSection))]
    public class NewMgSitePageAsSitePageCanvaLayoutHorizontalSectionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string BaseSitePageId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.SectionEmphasisType? Emphasis { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.HorizontalSectionLayoutType? Layout { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(BaseSitePageId, "New"))
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
                result = client.Sites[SiteId].Pages[BaseSitePageId].GraphSitePage.CanvasLayout.HorizontalSections.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
