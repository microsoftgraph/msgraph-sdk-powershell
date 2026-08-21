#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Teams.Client;
using Microsoft.Graph.PowerShell.Teams.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Teams
{
    [GraphRoute("POST", "/chats/{chat-id}/messages/{chatMessage-id}/replies/{chatMessage-id1}/hostedContents")]
    [Cmdlet(VerbsCommon.New, "MgChatMessageReplyHostedContent", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Teams.Client.Models.ChatMessageHostedContent))]
    public class NewMgChatMessageReplyHostedContentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ChatId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ChatMessageId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ChatMessageId1 { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public byte[]? ContentBytes { get; set; }

        [Parameter(Mandatory = false)]
        public string? ContentType { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ChatMessageId1, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Teams.Client.Models.ChatMessageHostedContent();

    if (this.IsParameterBound(nameof(ContentBytes)))
        body.ContentBytes = ContentBytes;

    if (this.IsParameterBound(nameof(ContentType)))
        body.ContentType = ContentType;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Teams.Client.Models.ChatMessageHostedContent? result;
            try
            {
                result = client.Chats[ChatId].Messages[ChatMessageId].Replies[ChatMessageId1].HostedContents.PostAsync(body, requestConfiguration =>
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
