#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Notes.Client;
using Microsoft.Graph.PowerShell.Notes.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Notes
{
    [GraphRoute("POST", "/sites/{site-id}/onenote/notebooks/{notebook-id}/sections/{onenoteSection-id}/pages/{onenotePage-id}/copyToSection")]
    [Cmdlet(VerbsCommon.Copy, "MgSiteOnenoteNotebookSectionPageToSection", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Notes.Client.Models.OnenoteOperation))]
    public class CopyMgSiteOnenoteNotebookSectionPageToSectionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string NotebookId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string OnenoteSectionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string OnenotePageId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? GroupId { get; set; }

        [Parameter(Mandatory = false)]
        public string? SiteCollectionId { get; set; }

        [Parameter(Mandatory = false)]
        public string? SiteId1 { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OnenotePageId, "Copy"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Notes.Client.Sites.Item.Onenote.Notebooks.Item.Sections.Item.Pages.Item.CopyToSection.CopyToSectionPostRequestBody();

    if (this.IsParameterBound(nameof(GroupId)))
        body.GroupId = GroupId;

    if (this.IsParameterBound(nameof(SiteCollectionId)))
        body.SiteCollectionId = SiteCollectionId;

    if (this.IsParameterBound(nameof(SiteId1)))
        body.SiteId = SiteId1;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Notes.Client.Models.OnenoteOperation? result;
            try
            {
                result = client.Sites[SiteId].Onenote.Notebooks[NotebookId].Sections[OnenoteSectionId].Pages[OnenotePageId].CopyToSection.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, OnenotePageId);
                return;
            }

            WriteObject(result);
        }
    }
}
