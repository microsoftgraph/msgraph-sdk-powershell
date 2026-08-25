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
    [GraphRoute("POST", "/drives/{drive-id}/items/{driveItem-id}/invite")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgInviteDriveItem", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Invite.InvitePostResponse))]
    public class InvokeMgInviteDriveItemCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? RequireSignIn { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Roles { get; set; }

        [Parameter(Mandatory = false)]
        public bool? SendInvitation { get; set; }

        [Parameter(Mandatory = false)]
        public string? Message { get; set; }

        [Parameter(Mandatory = false)]
        public bool? RetainInheritedPermissions { get; set; }

        [Parameter(Mandatory = false)]
        public string? ExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Password { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.DriveRecipient[]? Recipients { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DriveItemId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Invite.InvitePostRequestBody();

    if (this.IsParameterBound(nameof(RequireSignIn)))
        body.RequireSignIn = RequireSignIn;

    if (this.IsParameterBound(nameof(Roles)))
        body.Roles = Roles!.ToList();

    if (this.IsParameterBound(nameof(SendInvitation)))
        body.SendInvitation = SendInvitation;

    if (this.IsParameterBound(nameof(Message)))
        body.Message = Message;

    if (this.IsParameterBound(nameof(RetainInheritedPermissions)))
        body.RetainInheritedPermissions = RetainInheritedPermissions;

    if (this.IsParameterBound(nameof(ExpirationDateTime)))
        body.ExpirationDateTime = ExpirationDateTime;

    if (this.IsParameterBound(nameof(Password)))
        body.Password = Password;
    if (this.IsParameterBound(nameof(Recipients)))
        body.Recipients = Recipients!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.Items.Item.Invite.InvitePostResponse? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Invite.PostAsInvitePostResponseAsync(body, requestConfiguration =>
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
