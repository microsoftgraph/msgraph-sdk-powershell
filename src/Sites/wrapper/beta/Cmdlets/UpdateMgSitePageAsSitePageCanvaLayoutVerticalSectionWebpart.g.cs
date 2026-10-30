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
    [GraphRoute("PATCH", "/sites/{site-id}/pages/{baseSitePage-id}/graph.sitePage/canvasLayout/verticalSection/webparts/{webPart-id}")]
    [Cmdlet(VerbsData.Update, "MgSitePageAsSitePageCanvaLayoutVerticalSectionWebpart", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.WebPart))]
    public class UpdateMgSitePageAsSitePageCanvaLayoutVerticalSectionWebpartCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string BaseSitePageId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string WebPartId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(WebPartId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Sites.Client.Models.WebPart();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.WebPart? result;
            try
            {
                result = client.Sites[SiteId].Pages[BaseSitePageId].GraphSitePage.CanvasLayout.VerticalSection.Webparts[WebPartId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, WebPartId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Sites[SiteId].Pages[BaseSitePageId].GraphSitePage.CanvasLayout.VerticalSection.Webparts[WebPartId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, WebPartId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
