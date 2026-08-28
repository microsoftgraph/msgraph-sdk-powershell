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
    [GraphRoute("POST", "/drives/{drive-id}/list/items/{listItem-id}/createLink")]
    [Cmdlet(VerbsCommon.New, "MgDriveListItemLink", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.Permission))]
    public class NewMgDriveListItemLinkCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ListItemId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Type { get; set; }

        [Parameter(Mandatory = false)]
        public string? Scope { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Password { get; set; }

        [Parameter(Mandatory = false)]
        public string? Message { get; set; }

        [Parameter(Mandatory = false)]
        public bool? RetainInheritedPermissions { get; set; }

        [Parameter(Mandatory = false)]
        public bool? SendNotification { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Files.Client.Models.DriveRecipient[]? Recipients { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ListItemId, "New"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Files.Client.Drives.Item.List.Items.Item.CreateLink.CreateLinkPostRequestBody();

    if (this.IsParameterBound(nameof(Type)))
        body.Type = Type;

    if (this.IsParameterBound(nameof(Scope)))
        body.Scope = Scope;

    if (this.IsParameterBound(nameof(ExpirationDateTime)))
        body.ExpirationDateTime = ExpirationDateTime;

    if (this.IsParameterBound(nameof(Password)))
        body.Password = Password;

    if (this.IsParameterBound(nameof(Message)))
        body.Message = Message;

    if (this.IsParameterBound(nameof(RetainInheritedPermissions)))
        body.RetainInheritedPermissions = RetainInheritedPermissions;

    if (this.IsParameterBound(nameof(SendNotification)))
        body.SendNotification = SendNotification;
    if (this.IsParameterBound(nameof(Recipients)))
        body.Recipients = Recipients!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.Permission? result;
            try
            {
                result = client.Drives[DriveId].List.Items[ListItemId].CreateLink.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ListItemId);
                return;
            }

            WriteObject(result);
        }
    }
}
