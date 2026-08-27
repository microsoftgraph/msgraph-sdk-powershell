#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Files.Client;
using Microsoft.Graph.PowerShell.Files.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Files
{
    [GraphRoute("PATCH", "/shares/{sharedDriveItem-id}/list/items/{listItem-id}/documentSetVersions/{documentSetVersion-id}/fields")]
    [Cmdlet(VerbsData.Update, "MgShareListItemDocumentSetVersionField", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.FieldValueSet))]
    public class UpdateMgShareListItemDocumentSetVersionFieldCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SharedDriveItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ListItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string DocumentSetVersionId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DocumentSetVersionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Files.Client.Models.FieldValueSet();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.FieldValueSet? result;
            try
            {
                result = client.Shares[SharedDriveItemId].List.Items[ListItemId].DocumentSetVersions[DocumentSetVersionId].Fields.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, DocumentSetVersionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Shares[SharedDriveItemId].List.Items[ListItemId].DocumentSetVersions[DocumentSetVersionId].Fields.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, DocumentSetVersionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
