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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/thumbnails")]
    [Cmdlet(VerbsCommon.New, "MgDriveItemThumbnail", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.ThumbnailSet))]
    public class NewMgDriveItemThumbnailCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;


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
            if (!ShouldProcess(DriveItemId, "New"))
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
                result = client.Drives[DriveId].Items[DriveItemId].Thumbnails.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
