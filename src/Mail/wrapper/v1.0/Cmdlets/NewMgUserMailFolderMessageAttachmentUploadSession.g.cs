#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Mail.Client;
using Microsoft.Graph.PowerShell.Mail.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Mail
{
    [GraphRoute("POST", "/users/{user-id}/mailFolders/{mailFolder-id}/messages/{message-id}/attachments/createUploadSession")]
    [Cmdlet(VerbsCommon.New, "MgUserMailFolderMessageAttachmentUploadSession", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Mail.Client.Models.UploadSession))]
    public class NewMgUserMailFolderMessageAttachmentUploadSessionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string MailFolderId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string MessageId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Mail.Client.Models.AttachmentItem? AttachmentItem { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MessageId, "New"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Mail.Client.Users.Item.MailFolders.Item.Messages.Item.Attachments.CreateUploadSession.CreateUploadSessionPostRequestBody();

    if (this.IsParameterBound(nameof(AttachmentItem)))
        body.AttachmentItem = AttachmentItem;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Mail.Client.Models.UploadSession? result;
            try
            {
                result = client.Users[UserId].MailFolders[MailFolderId].Messages[MessageId].Attachments.CreateUploadSession.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, MessageId);
                return;
            }

            WriteObject(result);
        }
    }
}
