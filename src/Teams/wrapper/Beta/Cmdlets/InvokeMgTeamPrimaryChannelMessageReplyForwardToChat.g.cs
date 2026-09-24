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
    [GraphRoute("POST", "/teams/{team-id}/primaryChannel/messages/{chatMessage-id}/replies/forwardToChat")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgTeamPrimaryChannelMessageReplyForwardToChat", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Teams.Client.Teams.Item.PrimaryChannel.Messages.Item.Replies.ForwardToChat.ForwardToChatPostResponse))]
    public class InvokeMgTeamPrimaryChannelMessageReplyForwardToChatCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TeamId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ChatMessageId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? TargetChatIds { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? MessageIds { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.ChatMessage? AdditionalMessage { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ChatMessageId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Teams.Client.Teams.Item.PrimaryChannel.Messages.Item.Replies.ForwardToChat.ForwardToChatPostRequestBody();

    if (this.IsParameterBound(nameof(TargetChatIds)))
        body.TargetChatIds = TargetChatIds!.ToList();

    if (this.IsParameterBound(nameof(MessageIds)))
        body.MessageIds = MessageIds!.ToList();
    if (this.IsParameterBound(nameof(AdditionalMessage)))
        body.AdditionalMessage = AdditionalMessage;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Teams.Client.Teams.Item.PrimaryChannel.Messages.Item.Replies.ForwardToChat.ForwardToChatPostResponse? result;
            try
            {
                result = client.Teams[TeamId].PrimaryChannel.Messages[ChatMessageId].Replies.ForwardToChat.PostAsForwardToChatPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ChatMessageId);
                return;
            }

            WriteObject(result);
        }
    }
}
