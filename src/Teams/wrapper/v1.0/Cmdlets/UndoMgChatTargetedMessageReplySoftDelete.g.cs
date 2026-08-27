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
    [GraphRoute("POST", "/chats/{chat-id}/targetedMessages/{targetedChatMessage-id}/replies/{chatMessage-id}/undoSoftDelete")]
    [Cmdlet(VerbsCommon.Undo, "MgChatTargetedMessageReplySoftDelete", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class UndoMgChatTargetedMessageReplySoftDeleteCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ChatId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string TargetedChatMessageId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ChatMessageId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ChatMessageId, "Undo"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Chats[ChatId].TargetedMessages[TargetedChatMessageId].Replies[ChatMessageId].UndoSoftDelete.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, ChatMessageId);
                return;
            }

        }
    }
}
