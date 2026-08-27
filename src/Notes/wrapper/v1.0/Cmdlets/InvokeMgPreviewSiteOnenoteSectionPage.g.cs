#nullable enable

using System;
using System.Collections.Generic;
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
    [GraphRoute("GET", "/sites/{site-id}/onenote/sections/{onenoteSection-id}/pages/{onenotePage-id}/preview()")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgPreviewSiteOnenoteSectionPage")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Notes.Client.Models.OnenotePagePreview))]
    public class InvokeMgPreviewSiteOnenoteSectionPageCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string OnenoteSectionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string OnenotePageId { get; set; } = string.Empty;









        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            Microsoft.Graph.PowerShell.Notes.Client.Models.OnenotePagePreview? result;
            try
            {
                result = client.Sites[SiteId].Onenote.Sections[OnenoteSectionId].Pages[OnenotePageId].Preview.GetAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, OnenotePageId);
                return;
            }

            WriteObject(result);
        }
    }
}
