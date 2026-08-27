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
    [GraphRoute("PUT", "/users/{user-id}/onenote/notebooks/{notebook-id}/sectionGroups/{sectionGroup-id}/sections/{onenoteSection-id}/pages/{onenotePage-id}/content")]
    [Cmdlet(VerbsCommon.Set, "MgUserOnenoteNotebookSectionGroupSectionPageContent", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Notes.Client.Models.OnenotePage))]
    public class SetMgUserOnenoteNotebookSectionGroupSectionPageContentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string NotebookId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string SectionGroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string OnenoteSectionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 4)]
        public string OnenotePageId { get; set; } = string.Empty;

                [Parameter(Mandatory = true,
                    HelpMessage = "Path to the file whose contents are uploaded.")]
                public string InFile { get; set; } = string.Empty;






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OnenotePageId, "Set"))
                return;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Notes.Client.Models.OnenotePage? result;
            try
            {
                using var content = System.IO.File.OpenRead(InFile);
                result = client.Users[UserId].Onenote.Notebooks[NotebookId].SectionGroups[SectionGroupId].Sections[OnenoteSectionId].Pages[OnenotePageId].Content.PutAsync(content, requestConfiguration =>
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
