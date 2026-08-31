#nullable enable

using System;
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
    [GraphRoute("GET", "/users/{user-id}/onenote/sections/{onenoteSection-id}/pages/{onenotePage-id}/parentNotebook")]
    [Cmdlet(VerbsCommon.Get, "MgUserOnenoteSectionPageParentNotebook")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Notes.Client.Models.Notebook))]
    public class GetMgUserOnenoteSectionPageParentNotebookCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string OnenoteSectionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string OnenotePageId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Notes.Client.Models.Notebook? result;
            try
            {
                result = client.Users[UserId].Onenote.Sections[OnenoteSectionId].Pages[OnenotePageId].ParentNotebook.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, OnenotePageId);
                return;
            }

            WriteObject(result);
        }
    }
}
