#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Mail.Client;
using Microsoft.Graph.PowerShell.Mail.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Mail
{
    [GraphRoute("POST", "/users/{user-id}/mailFolders/{mailFolder-id}/messages/{message-id}/attachments")]
    [Cmdlet(VerbsCommon.New, "MgUserMailFolderMessageAttachment", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Mail.Client.Models.Attachment))]
    public class NewMgUserMailFolderMessageAttachmentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string MailFolderId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string MessageId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ContentType { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsInline { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Name { get; set; }

        [Parameter(Mandatory = false)]
        public int? Size { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MessageId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Mail.Client.Models.Attachment();

    if (this.IsParameterBound(nameof(ContentType)))
        body.ContentType = ContentType;

    if (this.IsParameterBound(nameof(IsInline)))
        body.IsInline = IsInline;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(Name)))
        body.Name = Name;

    if (this.IsParameterBound(nameof(Size)))
        body.Size = Size;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Mail.Client.Models.Attachment? result;
            try
            {
                result = client.Users[UserId].MailFolders[MailFolderId].Messages[MessageId].Attachments.PostAsync(body, requestConfiguration =>
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
