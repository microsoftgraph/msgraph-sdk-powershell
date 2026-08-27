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
    [GraphRoute("POST", "/communications/onlineMeetingConversations/{onlineMeetingEngagementConversation-id}/messages/{engagementConversationMessage-id}/replies/{engagementConversationMessage-id1}/reactions")]
    [Cmdlet(VerbsCommon.New, "MgCommunicationOnlineMeetingConversationMessageReplyReaction", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.EngagementConversationMessageReaction))]
    public class NewMgCommunicationOnlineMeetingConversationMessageReplyReactionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OnlineMeetingEngagementConversationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EngagementConversationMessageId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string EngagementConversationMessageId1 { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.EngagementIdentitySet? ReactionBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.EngagementConversationMessageReactionType? ReactionType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EngagementConversationMessageId1, "New"))
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
                result = client.Communications.OnlineMeetingConversations[OnlineMeetingEngagementConversationId].Messages[EngagementConversationMessageId].Replies[EngagementConversationMessageId1].Reactions.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
