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
    [GraphRoute("POST", "/groups/{group-id}/onenote/notebooks/getNotebookFromWebUrl")]
    [Cmdlet(VerbsCommon.Get, "MgGroupOnenoteNotebookFromWebUrl", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Notes.Client.Models.CopyNotebookModel))]
    public class GetMgGroupOnenoteNotebookFromWebUrlCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? WebUrl { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(GroupId, "Get"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Notes.Client.Groups.Item.Onenote.Notebooks.GetNotebookFromWebUrl.GetNotebookFromWebUrlPostRequestBody();

    if (this.IsParameterBound(nameof(WebUrl)))
        body.WebUrl = WebUrl;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Notes.Client.Models.CopyNotebookModel? result;
            try
            {
                result = client.Groups[GroupId].Onenote.Notebooks.GetNotebookFromWebUrl.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, GroupId);
                return;
            }

            WriteObject(result);
        }
    }
}
