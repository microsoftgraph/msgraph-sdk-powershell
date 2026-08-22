#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Teams.Client;
using Microsoft.Graph.PowerShell.Teams.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Teams
{
    [GraphRoute("PATCH", "/users/{user-id}/chats/{chat-id}/messages/{chatMessage-id}/replies/{chatMessage-id1}/hostedContents/{chatMessageHostedContent-id}")]
    [Cmdlet(VerbsData.Update, "MgUserChatMessageReplyHostedContent", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.ChatMessageHostedContent))]
    public class UpdateMgUserChatMessageReplyHostedContentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ChatId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ChatMessageId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string ChatMessageId1 { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 4)]
        public string ChatMessageHostedContentId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public byte[]? ContentBytes { get; set; }

        [Parameter(Mandatory = false)]
        public string? ContentType { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ChatMessageHostedContentId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.ChatMessageHostedContent();

    if (this.IsParameterBound(nameof(ContentBytes)))
        body.ContentBytes = ContentBytes;

    if (this.IsParameterBound(nameof(ContentType)))
        body.ContentType = ContentType;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.ChatMessageHostedContent? result;
            try
            {
                result = client.Users[UserId].Chats[ChatId].Messages[ChatMessageId].Replies[ChatMessageId1].HostedContents[ChatMessageHostedContentId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, ChatMessageHostedContentId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].Chats[ChatId].Messages[ChatMessageId].Replies[ChatMessageId1].HostedContents[ChatMessageHostedContentId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, ChatMessageHostedContentId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
