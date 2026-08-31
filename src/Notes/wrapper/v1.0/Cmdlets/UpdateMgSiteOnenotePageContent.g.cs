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
    [GraphRoute("POST", "/sites/{site-id}/onenote/pages/{onenotePage-id}/onenotePatchContent")]
    [Cmdlet(VerbsData.Update, "MgSiteOnenotePageContent", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class UpdateMgSiteOnenotePageContentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SiteId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string OnenotePageId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Notes.Client.Models.OnenotePatchContentCommand[]? Commands { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(OnenotePageId, "Update"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Notes.Client.Sites.Item.Onenote.Pages.Item.OnenotePatchContent.OnenotePatchContentPostRequestBody();

    if (this.IsParameterBound(nameof(Commands)))
        body.Commands = Commands!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Sites[SiteId].Onenote.Pages[OnenotePageId].OnenotePatchContent.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, OnenotePageId);
                return;
            }

        }
    }
}
