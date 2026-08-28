#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Groups.Client;
using Microsoft.Graph.PowerShell.Groups.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Groups
{
    [GraphRoute("POST", "/groups/{group-id}/conversations/{conversation-id}/threads/{conversationThread-id}/posts/{post-id}/inReplyTo/extensions")]
    [Cmdlet(VerbsCommon.New, "MgGroupConversationThreadPostInReplyToExtension", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Groups.Client.Models.Extension))]
    public class NewMgGroupConversationThreadPostInReplyToExtensionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ConversationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ConversationThreadId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string PostId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PostId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Groups.Client.Models.Extension();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Groups.Client.Models.Extension? result;
            try
            {
                result = client.Groups[GroupId].Conversations[ConversationId].Threads[ConversationThreadId].Posts[PostId].InReplyTo.Extensions.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
