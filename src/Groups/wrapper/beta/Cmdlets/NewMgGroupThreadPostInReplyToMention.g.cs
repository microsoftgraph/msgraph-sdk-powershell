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
    [GraphRoute("POST", "/groups/{group-id}/threads/{conversationThread-id}/posts/{post-id}/inReplyTo/mentions")]
    [Cmdlet(VerbsCommon.New, "MgGroupThreadPostInReplyToMention", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Groups.Client.Models.Mention))]
    public class NewMgGroupThreadPostInReplyToMentionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ConversationThreadId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string PostId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Application { get; set; }

        [Parameter(Mandatory = false)]
        public string? ClientReference { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeepLink { get; set; }

        [Parameter(Mandatory = false)]
        public string? MentionText { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ServerCreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Groups.Client.Models.EmailAddress? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Groups.Client.Models.EmailAddress? Mentioned { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PostId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Groups.Client.Models.Mention();

    if (this.IsParameterBound(nameof(Application)))
        body.Application = Application;

    if (this.IsParameterBound(nameof(ClientReference)))
        body.ClientReference = ClientReference;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(DeepLink)))
        body.DeepLink = DeepLink;

    if (this.IsParameterBound(nameof(MentionText)))
        body.MentionText = MentionText;

    if (this.IsParameterBound(nameof(ServerCreatedDateTime)))
        body.ServerCreatedDateTime = ServerCreatedDateTime;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(Mentioned)))
        body.Mentioned = Mentioned;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Groups.Client.Models.Mention? result;
            try
            {
                result = client.Groups[GroupId].Threads[ConversationThreadId].Posts[PostId].InReplyTo.Mentions.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
