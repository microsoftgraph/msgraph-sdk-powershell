#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.CloudCommunications.Client;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.CloudCommunications
{
    [GraphRoute("DELETE", "/communications/onlineMeetingConversations/{onlineMeetingEngagementConversation-id}/messages/{engagementConversationMessage-id}/replies/{engagementConversationMessage-id1}")]
    [Cmdlet(VerbsCommon.Remove, "MgCommunicationOnlineMeetingConversationMessageReply", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.High)]
    public class RemoveMgCommunicationOnlineMeetingConversationMessageReplyCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OnlineMeetingEngagementConversationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EngagementConversationMessageId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string EngagementConversationMessageId1 { get; set; } = string.Empty;


        [Parameter(Mandatory = false,
            HelpMessage = "Sets the 'If-Match' request header (for example an ETag for optimistic concurrency; some Graph APIs require it even where the spec marks it optional).")]
        public string? IfMatch { get; set; }




        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EngagementConversationMessageId1, "Remove"))
                return;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            // DeleteAsync returns a plain Task: a standard delete response has no body.
            try
            {
                client.Communications.OnlineMeetingConversations[OnlineMeetingEngagementConversationId].Messages[EngagementConversationMessageId].Replies[EngagementConversationMessageId1].DeleteAsync(requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(IfMatch)))
                            requestConfiguration.Headers.Add("If-Match", IfMatch!);

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, EngagementConversationMessageId1);
                return;
            }
        }
    }
}
