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
    [GraphRoute("PATCH", "/drives/{drive-id}/list/contentTypes/{contentType-id}")]
    [Cmdlet(VerbsData.Update, "MgDriveListContentType", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.ContentType))]
    public class UpdateMgDriveListContentTypeCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ContentTypeId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? AssociatedHubsUrls { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? Group { get; set; }

        [Parameter(Mandatory = false)]
        public bool? Hidden { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsBuiltIn { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public string? ParentId { get; set; }

        [Parameter(Mandatory = false)]
        public bool? PropagateChanges { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ReadOnly { get; set; }

        [Parameter(Mandatory = false)]
        public bool? Sealed { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.DocumentSet? DocumentSet { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.DocumentSetContent? DocumentTemplate { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.ItemReference? InheritedFrom { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.ContentTypeOrder? Order { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ContentTypeId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Files.Client.Models.ContentType();

    if (this.IsParameterBound(nameof(AssociatedHubsUrls)))
        body.AssociatedHubsUrls = AssociatedHubsUrls!.ToList();

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(Group)))
        body.Group = Group;

    if (this.IsParameterBound(nameof(Hidden)))
        body.Hidden = Hidden;

    if (this.IsParameterBound(nameof(IsBuiltIn)))
        body.IsBuiltIn = IsBuiltIn;

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(ParentId)))
        body.ParentId = ParentId;

    if (this.IsParameterBound(nameof(PropagateChanges)))
        body.PropagateChanges = PropagateChanges;

    if (this.IsParameterBound(nameof(ReadOnly)))
        body.ReadOnly = ReadOnly;

    if (this.IsParameterBound(nameof(Sealed)))
        body.Sealed = Sealed;

    if (this.IsParameterBound(nameof(DocumentSet)))
        body.DocumentSet = DocumentSet;

    if (this.IsParameterBound(nameof(DocumentTemplate)))
        body.DocumentTemplate = DocumentTemplate;

    if (this.IsParameterBound(nameof(InheritedFrom)))
        body.InheritedFrom = InheritedFrom;

    if (this.IsParameterBound(nameof(Order)))
        body.Order = Order;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.ContentType? result;
            try
            {
                result = client.Drives[DriveId].List.ContentTypes[ContentTypeId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ContentTypeId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Drives[DriveId].List.ContentTypes[ContentTypeId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, ContentTypeId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
