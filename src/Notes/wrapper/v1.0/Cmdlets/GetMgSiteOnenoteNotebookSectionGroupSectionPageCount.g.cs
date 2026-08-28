#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Notes.Client;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Notes
{
    [GraphRoute("GET", "/sites/{site-id}/onenote/notebooks/{notebook-id}/sectionGroups/{sectionGroup-id}/sections/{onenoteSection-id}/pages/$count")]
    [Cmdlet(VerbsCommon.Get, "MgSiteOnenoteNotebookSectionGroupSectionPageCount")]
    [OutputType(typeof(int))]
    public class GetMgSiteOnenoteNotebookSectionGroupSectionPageCountCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string NotebookId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string SectionGroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string OnenoteSectionId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false)]
        public string? Search { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            int? result;
            try
            {
                result = client.Sites[SiteId].Onenote.Notebooks[NotebookId].SectionGroups[SectionGroupId].Sections[OnenoteSectionId].Pages.Count.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Filter)))
                        requestConfiguration.QueryParameters.Filter = Filter;

                    if (this.IsParameterBound(nameof(Search)))
                        requestConfiguration.QueryParameters.Search = Search;

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, OnenoteSectionId);
                return;
            }

            if (result is not null)
                WriteObject(result);
        }
    }
}
