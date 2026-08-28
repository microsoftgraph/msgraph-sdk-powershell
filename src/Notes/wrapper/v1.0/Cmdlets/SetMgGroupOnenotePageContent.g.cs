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
    [GraphRoute("PUT", "/groups/{group-id}/onenote/pages/{onenotePage-id}/content")]
    [Cmdlet(VerbsCommon.Set, "MgGroupOnenotePageContent", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Notes.Client.Models.OnenotePage))]
    public class SetMgGroupOnenotePageContentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
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
                result = client.Groups[GroupId].Onenote.Pages[OnenotePageId].Content.PutAsync(content, requestConfiguration =>
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
