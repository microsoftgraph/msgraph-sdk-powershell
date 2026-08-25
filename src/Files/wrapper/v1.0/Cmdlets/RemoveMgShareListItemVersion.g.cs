#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Files.Client;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Files
{
    [GraphRoute("DELETE", "/shares/{sharedDriveItem-id}/list/items/{listItem-id}/versions/{listItemVersion-id}")]
    [Cmdlet(VerbsCommon.Remove, "MgShareListItemVersion", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    public class RemoveMgShareListItemVersionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SharedDriveItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ListItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ListItemVersionId { get; set; } = string.Empty;


        [Parameter(Mandatory = false,
            HelpMessage = "Sets the 'If-Match' request header (for example an ETag for optimistic concurrency; some Graph APIs require it even where the spec marks it optional).")]
        public string? IfMatch { get; set; }




        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ListItemVersionId, "Remove"))
                return;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            // DeleteAsync returns a plain Task: a standard delete response has no body.
            try
            {
                client.Shares[SharedDriveItemId].List.Items[ListItemId].Versions[ListItemVersionId].DeleteAsync(requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(IfMatch)))
                            requestConfiguration.Headers.Add("If-Match", IfMatch!);

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ListItemVersionId);
                return;
            }
        }
    }
}
