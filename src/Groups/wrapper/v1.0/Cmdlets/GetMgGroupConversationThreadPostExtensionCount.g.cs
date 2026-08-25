#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Groups.Client;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Groups
{
    [GraphRoute("GET", "/groups/{group-id}/conversations/{conversation-id}/threads/{conversationThread-id}/posts/{post-id}/extensions/$count")]
    [Cmdlet(VerbsCommon.Get, "MgGroupConversationThreadPostExtensionCount")]
    [OutputType(typeof(int))]
    public class GetMgGroupConversationThreadPostExtensionCountCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ConversationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string ConversationThreadId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string PostId { get; set; } = string.Empty;



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
                result = client.Groups[GroupId].Conversations[ConversationId].Threads[ConversationThreadId].Posts[PostId].Extensions.Count.GetAsync(requestConfiguration =>
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
                ThrowGraphRequestFailed(ex, PostId);
                return;
            }

            if (result is not null)
                WriteObject(result);
        }
    }
}
