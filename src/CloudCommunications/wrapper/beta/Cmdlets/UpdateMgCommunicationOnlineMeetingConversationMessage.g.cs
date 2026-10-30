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
    [GraphRoute("PATCH", "/communications/onlineMeetingConversations/{onlineMeetingEngagementConversation-id}/messages/{engagementConversationMessage-id}")]
    [Cmdlet(VerbsData.Update, "MgCommunicationOnlineMeetingConversationMessage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.EngagementConversationMessage))]
    public class UpdateMgCommunicationOnlineMeetingConversationMessageCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string OnlineMeetingEngagementConversationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string EngagementConversationMessageId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ReplyToId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.ItemBody? Body { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.EngagementCreationMode? CreationMode { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.EngagementIdentitySet? From { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.EngagementConversation? Conversation { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(EngagementConversationMessageId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.EngagementConversationMessage();

    if (this.IsParameterBound(nameof(ReplyToId)))
        body.ReplyToId = ReplyToId;

    if (this.IsParameterBound(nameof(Body)))
        body.Body = Body;

    if (this.IsParameterBound(nameof(CreationMode)))
        body.CreationMode = CreationMode;

    if (this.IsParameterBound(nameof(From)))
        body.From = From;

    if (this.IsParameterBound(nameof(Conversation)))
        body.Conversation = Conversation;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.EngagementConversationMessage? result;
            try
            {
                result = client.Communications.OnlineMeetingConversations[OnlineMeetingEngagementConversationId].Messages[EngagementConversationMessageId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, EngagementConversationMessageId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Communications.OnlineMeetingConversations[OnlineMeetingEngagementConversationId].Messages[EngagementConversationMessageId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, EngagementConversationMessageId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
