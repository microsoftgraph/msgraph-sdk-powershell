#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.CloudCommunications.Client;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.CloudCommunications
{
    [GraphRoute("GET", "/communications/onlineMeetingConversations/{onlineMeetingEngagementConversation-id}/messages/{engagementConversationMessage-id}/replies/{engagementConversationMessage-id1}/reactions/$count")]
    [Cmdlet(VerbsCommon.Get, "MgCommunicationOnlineMeetingConversationMessageReplyReactionCount")]
    [OutputType(typeof(int))]
    public class GetMgCommunicationOnlineMeetingConversationMessageReplyReactionCountCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OnlineMeetingEngagementConversationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EngagementConversationMessageId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string EngagementConversationMessageId1 { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false)]
        public string? Search { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            int? result;
            try
            {
                result = client.Communications.OnlineMeetingConversations[OnlineMeetingEngagementConversationId].Messages[EngagementConversationMessageId].Replies[EngagementConversationMessageId1].Reactions.Count.GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Filter)))
                        requestConfiguration.QueryParameters.Filter = Filter;

                    if (this.IsParameterBound(nameof(Search)))
                        requestConfiguration.QueryParameters.Search = Search;

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, EngagementConversationMessageId1);
                return;
            }

            if (result is not null)
                WriteObject(result);
        }
    }
}
