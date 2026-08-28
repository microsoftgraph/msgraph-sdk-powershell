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
    [GraphRoute("PATCH", "/drives/{drive-id}/list/contentTypes/{contentType-id}/columnLinks/{columnLink-id}")]
    [Cmdlet(VerbsData.Update, "MgDriveListContentTypeColumnLink", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.ColumnLink))]
    public class UpdateMgDriveListContentTypeColumnLinkCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ContentTypeId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ColumnLinkId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ColumnLinkId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Files.Client.Models.ColumnLink();

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.ColumnLink? result;
            try
            {
                result = client.Drives[DriveId].List.ContentTypes[ContentTypeId].ColumnLinks[ColumnLinkId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ColumnLinkId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Drives[DriveId].List.ContentTypes[ContentTypeId].ColumnLinks[ColumnLinkId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, ColumnLinkId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
