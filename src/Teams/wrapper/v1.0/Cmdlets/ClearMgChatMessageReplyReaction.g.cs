#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Teams.Client;
using Microsoft.Graph.PowerShell.Teams.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Teams
{
    [GraphRoute("POST", "/chats/{chat-id}/messages/{chatMessage-id}/replies/{chatMessage-id1}/unsetReaction")]
    [Cmdlet(VerbsCommon.Clear, "MgChatMessageReplyReaction", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class ClearMgChatMessageReplyReactionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ChatId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ChatMessageId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ChatMessageId1 { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ReactionType { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ChatMessageId1, "Clear"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Teams.Client.Chats.Item.Messages.Item.Replies.Item.UnsetReaction.UnsetReactionPostRequestBody();

    if (this.IsParameterBound(nameof(ReactionType)))
        body.ReactionType = ReactionType;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Chats[ChatId].Messages[ChatMessageId].Replies[ChatMessageId1].UnsetReaction.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, ChatMessageId1);
                return;
            }

        }
    }
}
