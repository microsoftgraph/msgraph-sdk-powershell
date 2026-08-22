#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.CloudCommunications.Client;
using Microsoft.Graph.PowerShell.CloudCommunications.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.CloudCommunications
{
    [GraphRoute("PATCH", "/communications/onlineMeetingConversations/{onlineMeetingEngagementConversation-id}/starter/replies/{engagementConversationMessage-id}/reactions/{engagementConversationMessageReaction-id}")]
    [Cmdlet(VerbsData.Update, "MgCommunicationOnlineMeetingConversationStarterReplyReaction", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.EngagementConversationMessageReaction))]
    public class UpdateMgCommunicationOnlineMeetingConversationStarterReplyReactionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OnlineMeetingEngagementConversationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EngagementConversationMessageId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string EngagementConversationMessageReactionId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.EngagementIdentitySet? ReactionBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.EngagementConversationMessageReactionType? ReactionType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EngagementConversationMessageReactionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.EngagementConversationMessageReaction();


    if (this.IsParameterBound(nameof(ReactionBy)))
        body.ReactionBy = ReactionBy;

    if (this.IsParameterBound(nameof(ReactionType)))
        body.ReactionType = ReactionType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.EngagementConversationMessageReaction? result;
            try
            {
                result = client.Communications.OnlineMeetingConversations[OnlineMeetingEngagementConversationId].Starter.Replies[EngagementConversationMessageId].Reactions[EngagementConversationMessageReactionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, EngagementConversationMessageReactionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Communications.OnlineMeetingConversations[OnlineMeetingEngagementConversationId].Starter.Replies[EngagementConversationMessageId].Reactions[EngagementConversationMessageReactionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, EngagementConversationMessageReactionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
