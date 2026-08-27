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
    [GraphRoute("POST", "/groups/{group-id}/onenote/notebooks/{notebook-id}/sections/{onenoteSection-id}/copyToNotebook")]
    [Cmdlet(VerbsCommon.Copy, "MgGroupOnenoteNotebookSectionToNotebook", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Notes.Client.Models.OnenoteOperation))]
    public class CopyMgGroupOnenoteNotebookSectionToNotebookCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string NotebookId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string OnenoteSectionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? GroupId1 { get; set; }

        [Parameter(Mandatory = false)]
        public string? RenameAs { get; set; }

        [Parameter(Mandatory = false)]
        public string? SiteCollectionId { get; set; }

        [Parameter(Mandatory = false)]
        public string? SiteId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OnenoteSectionId, "Copy"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Notes.Client.Groups.Item.Onenote.Notebooks.Item.Sections.Item.CopyToNotebook.CopyToNotebookPostRequestBody();

    if (this.IsParameterBound(nameof(GroupId1)))
        body.GroupId = GroupId1;

    if (this.IsParameterBound(nameof(RenameAs)))
        body.RenameAs = RenameAs;

    if (this.IsParameterBound(nameof(SiteCollectionId)))
        body.SiteCollectionId = SiteCollectionId;

    if (this.IsParameterBound(nameof(SiteId)))
        body.SiteId = SiteId;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Notes.Client.Models.OnenoteOperation? result;
            try
            {
                result = client.Groups[GroupId].Onenote.Notebooks[NotebookId].Sections[OnenoteSectionId].CopyToNotebook.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, OnenoteSectionId);
                return;
            }

            WriteObject(result);
        }
    }
}
