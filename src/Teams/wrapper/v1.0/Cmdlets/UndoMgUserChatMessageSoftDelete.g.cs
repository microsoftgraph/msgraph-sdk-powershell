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
    [GraphRoute("POST", "/users/{user-id}/chats/{chat-id}/messages/{chatMessage-id}/undoSoftDelete")]
    [Cmdlet(VerbsCommon.Undo, "MgUserChatMessageSoftDelete", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class UndoMgUserChatMessageSoftDeleteCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ChatId { get; set; } = string.Empty;
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
                client.Users[UserId].Chats[ChatId].Messages[ChatMessageId].UndoSoftDelete.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ChatMessageId);
                return;
            }

        }
    }
}
