#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Groups.Client;
using Microsoft.Graph.PowerShell.Groups.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Groups
{
    [GraphRoute("POST", "/groups/{group-id}/threads/{conversationThread-id}/posts/{post-id}/inReplyTo/attachments/createUploadSession")]
    [Cmdlet(VerbsCommon.New, "MgGroupThreadPostInReplyToAttachmentUploadSession", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Groups.Client.Models.UploadSession))]
    public class NewMgGroupThreadPostInReplyToAttachmentUploadSessionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ConversationThreadId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string PostId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Groups.Client.Models.AttachmentItem? AttachmentItem { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PostId, "New"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Groups.Client.Groups.Item.Threads.Item.Posts.Item.InReplyTo.Attachments.CreateUploadSession.CreateUploadSessionPostRequestBody();

    if (this.IsParameterBound(nameof(AttachmentItem)))
        body.AttachmentItem = AttachmentItem;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Groups.Client.Models.UploadSession? result;
            try
            {
                result = client.Groups[GroupId].Threads[ConversationThreadId].Posts[PostId].InReplyTo.Attachments.CreateUploadSession.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, PostId);
                return;
            }

            WriteObject(result);
        }
    }
}
