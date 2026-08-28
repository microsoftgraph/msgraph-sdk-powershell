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
    [GraphRoute("POST", "/groups/{group-id}/team/primaryChannel/messages/{chatMessage-id}/unsetReaction")]
    [Cmdlet(VerbsCommon.Clear, "MgGroupTeamPrimaryChannelMessageReaction", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class ClearMgGroupTeamPrimaryChannelMessageReactionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ChatMessageId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ReactionType { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ChatMessageId, "Clear"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Teams.Client.Groups.Item.Team.PrimaryChannel.Messages.Item.UnsetReaction.UnsetReactionPostRequestBody();

    if (this.IsParameterBound(nameof(ReactionType)))
        body.ReactionType = ReactionType;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Groups[GroupId].Team.PrimaryChannel.Messages[ChatMessageId].UnsetReaction.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ChatMessageId);
                return;
            }

        }
    }
}
