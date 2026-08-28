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
    [GraphRoute("PATCH", "/drives/{drive-id}/items/{driveItem-id}/thumbnails/{thumbnailSet-id}")]
    [Cmdlet(VerbsData.Update, "MgDriveItemThumbnail", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.ThumbnailSet))]
    public class UpdateMgDriveItemThumbnailCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ThumbnailSetId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.Thumbnail? Large { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.Thumbnail? Medium { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.Thumbnail? Small { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.Thumbnail? Source { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ThumbnailSetId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Files.Client.Models.ThumbnailSet();


    if (this.IsParameterBound(nameof(Large)))
        body.Large = Large;

    if (this.IsParameterBound(nameof(Medium)))
        body.Medium = Medium;

    if (this.IsParameterBound(nameof(Small)))
        body.Small = Small;

    if (this.IsParameterBound(nameof(Source)))
        body.Source = Source;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.ThumbnailSet? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Thumbnails[ThumbnailSetId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ThumbnailSetId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Drives[DriveId].Items[DriveItemId].Thumbnails[ThumbnailSetId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, ThumbnailSetId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
