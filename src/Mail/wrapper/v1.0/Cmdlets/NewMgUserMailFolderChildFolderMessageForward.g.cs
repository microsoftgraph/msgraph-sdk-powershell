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
    [GraphRoute("POST", "/users/{user-id}/mailFolders/{mailFolder-id}/childFolders/{mailFolder-id1}/messages/{message-id}/createForward")]
    [Cmdlet(VerbsCommon.New, "MgUserMailFolderChildFolderMessageForward", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Mail.Client.Models.Message))]
    public class NewMgUserMailFolderChildFolderMessageForwardCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string MailFolderId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string MailFolderId1 { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string MessageId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Comment { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Mail.Client.Models.Recipient[]? ToRecipients { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Mail.Client.Models.Message? Message { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MessageId, "New"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Mail.Client.Users.Item.MailFolders.Item.ChildFolders.Item.Messages.Item.CreateForward.CreateForwardPostRequestBody();

    if (this.IsParameterBound(nameof(Comment)))
        body.Comment = Comment;
    if (this.IsParameterBound(nameof(ToRecipients)))
        body.ToRecipients = ToRecipients!.ToList();

    if (this.IsParameterBound(nameof(Message)))
        body.Message = Message;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Mail.Client.Models.Message? result;
            try
            {
                result = client.Users[UserId].MailFolders[MailFolderId].ChildFolders[MailFolderId1].Messages[MessageId].CreateForward.PostAsync(body, requestConfiguration =>
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
