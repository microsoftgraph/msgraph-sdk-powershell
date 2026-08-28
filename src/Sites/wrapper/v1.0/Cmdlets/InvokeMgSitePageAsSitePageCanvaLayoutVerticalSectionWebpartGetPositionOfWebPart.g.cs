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
    [GraphRoute("POST", "/sites/{site-id}/pages/{baseSitePage-id}/graph.sitePage/canvasLayout/verticalSection/webparts/{webPart-id}/getPositionOfWebPart")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgSitePageAsSitePageCanvaLayoutVerticalSectionWebpartGetPositionOfWebPart", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.WebPartPosition))]
    public class InvokeMgSitePageAsSitePageCanvaLayoutVerticalSectionWebpartGetPositionOfWebPartCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string BaseSitePageId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string WebPartId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(WebPartId, "Invoke"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Sites.Client.Models.WebPartPosition? result;
            try
            {
                result = client.Sites[SiteId].Pages[BaseSitePageId].GraphSitePage.CanvasLayout.VerticalSection.Webparts[WebPartId].GetPositionOfWebPart.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, WebPartId);
                return;
            }

            WriteObject(result);
        }
    }
}
