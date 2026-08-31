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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/checkin")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgCheckinDriveItem", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgCheckinDriveItemCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? CheckInAs { get; set; }

        [Parameter(Mandatory = false)]
        public string? Comment { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Checkin.CheckinPostRequestBody();

    if (this.IsParameterBound(nameof(CheckInAs)))
        body.CheckInAs = CheckInAs;

    if (this.IsParameterBound(nameof(Comment)))
        body.Comment = Comment;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Drives[DriveId].Items[DriveItemId].Checkin.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DriveItemId);
                return;
            }

        }
    }
}
