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
    [GraphRoute("POST", "/groups/{group-id}/sites/{site-id}/pageTemplates/{pageTemplate-id}/canvasLayout/horizontalSections")]
    [Cmdlet(VerbsCommon.New, "MgGroupSitePageTemplateCanvaLayoutHorizontalSection", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Sites.Client.Models.HorizontalSection))]
    public class NewMgGroupSitePageTemplateCanvaLayoutHorizontalSectionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string PageTemplateId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.SectionEmphasisType? Emphasis { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Sites.Client.Models.HorizontalSectionLayoutType? Layout { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PageTemplateId, "New"))
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
                result = client.Groups[GroupId].Sites[SiteId].PageTemplates[PageTemplateId].CanvasLayout.HorizontalSections.PostAsync(body, requestConfiguration =>
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
