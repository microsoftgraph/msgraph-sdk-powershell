#nullable enable

using System;
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
    [GraphRoute("GET", "/groups/{group-id}/threads/{conversationThread-id}/posts/{post-id}/inReplyTo/attachments/{attachment-id}")]
    [Cmdlet(VerbsCommon.Get, "MgGroupThreadPostInReplyToAttachment_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Groups.Client.Models.Attachment))]
    public class GetMgGroupThreadPostInReplyToAttachment_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ConversationThreadId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string PostId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string AttachmentId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Groups.Client.Models.Attachment? result;
            try
            {
                result = client.Groups[GroupId].Threads[ConversationThreadId].Posts[PostId].InReplyTo.Attachments[AttachmentId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, AttachmentId);
                return;
            }

            WriteObject(result);
        }
    }
}
