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
    [GraphRoute("POST", "/groups/{group-id}/team/channels/{channel-id}/messages/replyWithQuote")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgGraphGroupTeamChannelMessage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.ChatMessage))]
    public class InvokeMgGraphGroupTeamChannelMessageCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ChannelId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? MessageIds { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.ChatMessage? ReplyMessage { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ChannelId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Teams.Client.Groups.Item.Team.Channels.Item.Messages.ReplyWithQuote.ReplyWithQuotePostRequestBody();

    if (this.IsParameterBound(nameof(MessageIds)))
        body.MessageIds = MessageIds!.ToList();
    if (this.IsParameterBound(nameof(ReplyMessage)))
        body.ReplyMessage = ReplyMessage;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.ChatMessage? result;
            try
            {
                result = client.Groups[GroupId].Team.Channels[ChannelId].Messages.ReplyWithQuote.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ChannelId);
                return;
            }

            WriteObject(result);
        }
    }
}
