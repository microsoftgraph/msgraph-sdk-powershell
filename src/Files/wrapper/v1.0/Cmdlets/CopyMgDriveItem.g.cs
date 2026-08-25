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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/copy")]
    [Cmdlet(VerbsCommon.Copy, "MgDriveItem", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.DriveItem))]
    public class CopyMgDriveItemCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ChildrenOnly { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IncludeAllVersionHistory { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.ItemReference? ParentReference { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Copy"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Copy.CopyPostRequestBody();

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(ChildrenOnly)))
        body.ChildrenOnly = ChildrenOnly;

    if (this.IsParameterBound(nameof(IncludeAllVersionHistory)))
        body.IncludeAllVersionHistory = IncludeAllVersionHistory;
    if (this.IsParameterBound(nameof(ParentReference)))
        body.ParentReference = ParentReference;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.DriveItem? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Copy.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, DriveItemId);
                return;
            }

            WriteObject(result);
        }
    }
}
