#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Files.Client;
using Microsoft.Graph.PowerShell.Files.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Files
{
    [GraphRoute("POST", "/shares/{sharedDriveItem-id}/list/items/{listItem-id}/documentSetVersions/{documentSetVersion-id}/restore")]
    [Cmdlet(VerbsData.Restore, "MgShareListItemDocumentSetVersion", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class RestoreMgShareListItemDocumentSetVersionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SharedDriveItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ListItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string DocumentSetVersionId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DocumentSetVersionId, "Restore"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Shares[SharedDriveItemId].List.Items[ListItemId].DocumentSetVersions[DocumentSetVersionId].Restore.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, DocumentSetVersionId);
                return;
            }

        }
    }
}
