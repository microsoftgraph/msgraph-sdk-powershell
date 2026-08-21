#nullable enable

using System;
using System.Collections.Generic;
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
    [GraphRoute("GET", "/shares/{sharedDriveItem-id}/list/contentTypes/{contentType-id}/isPublished()")]
    [Cmdlet(VerbsDiagnostic.Test, "MgShareListContentTypePublished")]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Files.Client.Shares.Item.List.ContentTypes.Item.IsPublished.IsPublishedGetResponse))]
    public class TestMgShareListContentTypePublishedCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string SharedDriveItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ContentTypeId { get; set; } = string.Empty;









        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            global::Microsoft.Graph.PowerShell.Files.Client.Shares.Item.List.ContentTypes.Item.IsPublished.IsPublishedGetResponse? result;
            try
            {
                result = client.Shares[SharedDriveItemId].List.ContentTypes[ContentTypeId].IsPublished.GetAsIsPublishedGetResponseAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, ContentTypeId);
                return;
            }

            WriteObject(result);
        }
    }
}
