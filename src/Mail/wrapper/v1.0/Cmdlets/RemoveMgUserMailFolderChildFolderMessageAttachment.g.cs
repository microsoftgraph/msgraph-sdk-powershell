#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Mail.Client;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Mail
{
    [GraphRoute("DELETE", "/users/{user-id}/mailFolders/{mailFolder-id}/childFolders/{mailFolder-id1}/messages/{message-id}/attachments/{attachment-id}")]
    [Cmdlet(VerbsCommon.Remove, "MgUserMailFolderChildFolderMessageAttachment", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    public class RemoveMgUserMailFolderChildFolderMessageAttachmentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string MailFolderId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string MailFolderId1 { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string MessageId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 4)]
        public string AttachmentId { get; set; } = string.Empty;


        [Parameter(Mandatory = false,
            HelpMessage = "Sets the 'If-Match' request header (for example an ETag for optimistic concurrency; some Graph APIs require it even where the spec marks it optional).")]
        public string? IfMatch { get; set; }




        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AttachmentId, "Remove"))
                return;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            // DeleteAsync returns a plain Task: a standard delete response has no body.
            try
            {
                client.Users[UserId].MailFolders[MailFolderId].ChildFolders[MailFolderId1].Messages[MessageId].Attachments[AttachmentId].DeleteAsync(requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(IfMatch)))
                            requestConfiguration.Headers.Add("If-Match", IfMatch!);

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AttachmentId);
                return;
            }
        }
    }
}
