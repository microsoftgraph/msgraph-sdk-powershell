#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Groups.Client;
using Microsoft.Graph.PowerShell.Groups.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Groups
{
    [GraphRoute("POST", "/groups/{group-id}/threads/{conversationThread-id}/posts/{post-id}/inReplyTo/reply")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgReplyGroupThreadPostInReplyTo", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgReplyGroupThreadPostInReplyToCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ConversationThreadId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string PostId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Groups.Client.Models.Post? Post { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PostId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Groups.Client.Groups.Item.Threads.Item.Posts.Item.InReplyTo.Reply.ReplyPostRequestBody();

    if (this.IsParameterBound(nameof(Post)))
        body.Post = Post;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Groups[GroupId].Threads[ConversationThreadId].Posts[PostId].InReplyTo.Reply.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, PostId);
                return;
            }

        }
    }
}
