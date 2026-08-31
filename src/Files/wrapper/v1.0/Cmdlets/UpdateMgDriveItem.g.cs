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
    [GraphRoute("PATCH", "/drives/{drive-id}/items/{driveItem-id}")]
    [Cmdlet(VerbsData.Update, "MgDriveItem", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.DriveItem))]
    public class UpdateMgDriveItemCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? ETag { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public string? WebUrl { get; set; }

        [Parameter(Mandatory = false)]
        public byte[]? Content { get; set; }

        [Parameter(Mandatory = false)]
        public string? CTag { get; set; }

        [Parameter(Mandatory = false)]
        public long? Size { get; set; }

        [Parameter(Mandatory = false)]
        public string? WebDavUrl { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.IdentitySet? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.IdentitySet? LastModifiedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.ItemReference? ParentReference { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.Audio? Audio { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.Bundle? Bundle { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.Deleted? Deleted { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.FileObject? File { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.FileSystemInfo? FileSystemInfo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.Folder? Folder { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.Image? Image { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.GeoCoordinates? Location { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.Malware? Malware { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.Package? Package { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.PendingOperations? PendingOperations { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.Photo? Photo { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.PublicationFacet? Publication { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.RemoteItem? RemoteItem { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.Root? Root { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.SearchResult? SearchResult { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.Shared? Shared { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.SharepointIds? SharepointIds { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.SpecialFolder? SpecialFolder { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.Video? Video { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Files.Client.Models.DriveItem();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(ETag)))
        body.ETag = ETag;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(WebUrl)))
        body.WebUrl = WebUrl;

    if (this.IsParameterBound(nameof(Content)))
        body.Content = Content;

    if (this.IsParameterBound(nameof(CTag)))
        body.CTag = CTag;

    if (this.IsParameterBound(nameof(Size)))
        body.Size = Size;

    if (this.IsParameterBound(nameof(WebDavUrl)))
        body.WebDavUrl = WebDavUrl;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(LastModifiedBy)))
        body.LastModifiedBy = LastModifiedBy;

    if (this.IsParameterBound(nameof(ParentReference)))
        body.ParentReference = ParentReference;

    if (this.IsParameterBound(nameof(Audio)))
        body.Audio = Audio;

    if (this.IsParameterBound(nameof(Bundle)))
        body.Bundle = Bundle;

    if (this.IsParameterBound(nameof(Deleted)))
        body.Deleted = Deleted;

    if (this.IsParameterBound(nameof(File)))
        body.File = File;

    if (this.IsParameterBound(nameof(FileSystemInfo)))
        body.FileSystemInfo = FileSystemInfo;

    if (this.IsParameterBound(nameof(Folder)))
        body.Folder = Folder;

    if (this.IsParameterBound(nameof(Image)))
        body.Image = Image;

    if (this.IsParameterBound(nameof(Location)))
        body.Location = Location;

    if (this.IsParameterBound(nameof(Malware)))
        body.Malware = Malware;

    if (this.IsParameterBound(nameof(Package)))
        body.Package = Package;

    if (this.IsParameterBound(nameof(PendingOperations)))
        body.PendingOperations = PendingOperations;

    if (this.IsParameterBound(nameof(Photo)))
        body.Photo = Photo;

    if (this.IsParameterBound(nameof(Publication)))
        body.Publication = Publication;

    if (this.IsParameterBound(nameof(RemoteItem)))
        body.RemoteItem = RemoteItem;

    if (this.IsParameterBound(nameof(Root)))
        body.Root = Root;

    if (this.IsParameterBound(nameof(SearchResult)))
        body.SearchResult = SearchResult;

    if (this.IsParameterBound(nameof(Shared)))
        body.Shared = Shared;

    if (this.IsParameterBound(nameof(SharepointIds)))
        body.SharepointIds = SharepointIds;

    if (this.IsParameterBound(nameof(SpecialFolder)))
        body.SpecialFolder = SpecialFolder;

    if (this.IsParameterBound(nameof(Video)))
        body.Video = Video;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.DriveItem? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DriveItemId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Drives[DriveId].Items[DriveItemId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, DriveItemId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
