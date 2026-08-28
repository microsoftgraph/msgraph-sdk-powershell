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
    [GraphRoute("POST", "/teamwork/deletedTeams/{deletedTeam-id}/channels/{channel-id}/messages/{chatMessage-id}/replies/replyWithQuote")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgGraphTeamworkDeletedTeamChannelMessageReply", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.ChatMessage))]
    public class InvokeMgGraphTeamworkDeletedTeamChannelMessageReplyCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeletedTeamId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ChannelId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ChatMessageId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? MessageIds { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.ChatMessage? ReplyMessage { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ChatMessageId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Teams.Client.Teamwork.DeletedTeams.Item.Channels.Item.Messages.Item.Replies.ReplyWithQuote.ReplyWithQuotePostRequestBody();

    if (this.IsParameterBound(nameof(MessageIds)))
        body.MessageIds = MessageIds!.ToList();
    if (this.IsParameterBound(nameof(ReplyMessage)))
        body.ReplyMessage = ReplyMessage;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.ChatMessage? result;
            try
            {
                result = client.Teamwork.DeletedTeams[DeletedTeamId].Channels[ChannelId].Messages[ChatMessageId].Replies.ReplyWithQuote.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ChatMessageId);
                return;
            }

            WriteObject(result);
        }
    }
}
