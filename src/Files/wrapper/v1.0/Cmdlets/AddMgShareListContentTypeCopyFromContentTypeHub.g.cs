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
    [GraphRoute("POST", "/shares/{sharedDriveItem-id}/list/contentTypes/addCopyFromContentTypeHub")]
    [Cmdlet(VerbsCommon.Add, "MgShareListContentTypeCopyFromContentTypeHub", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.ContentType))]
    public class AddMgShareListContentTypeCopyFromContentTypeHubCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SharedDriveItemId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ContentTypeId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(SharedDriveItemId, "Add"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Shares.Item.List.ContentTypes.AddCopyFromContentTypeHub.AddCopyFromContentTypeHubPostRequestBody();

    if (this.IsParameterBound(nameof(ContentTypeId)))
        body.ContentTypeId = ContentTypeId;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.ContentType? result;
            try
            {
                result = client.Shares[SharedDriveItemId].List.ContentTypes.AddCopyFromContentTypeHub.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, SharedDriveItemId);
                return;
            }

            WriteObject(result);
        }
    }
}
