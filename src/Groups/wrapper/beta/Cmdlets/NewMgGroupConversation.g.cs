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
    [GraphRoute("POST", "/groups/{group-id}/conversations")]
    [Cmdlet(VerbsCommon.New, "MgGroupConversation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Groups.Client.Models.Conversation))]
    public class NewMgGroupConversationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? HasAttachments { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastDeliveredDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Preview { get; set; }

        [Parameter(Mandatory = false)]
        public string? Topic { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? UniqueSenders { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(GroupId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Groups.Client.Models.Conversation();

    if (this.IsParameterBound(nameof(HasAttachments)))
        body.HasAttachments = HasAttachments;

    if (this.IsParameterBound(nameof(LastDeliveredDateTime)))
        body.LastDeliveredDateTime = LastDeliveredDateTime;

    if (this.IsParameterBound(nameof(Preview)))
        body.Preview = Preview;

    if (this.IsParameterBound(nameof(Topic)))
        body.Topic = Topic;

    if (this.IsParameterBound(nameof(UniqueSenders)))
        body.UniqueSenders = UniqueSenders!.ToList();



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Groups.Client.Models.Conversation? result;
            try
            {
                result = client.Groups[GroupId].Conversations.PostAsync(body, requestConfiguration =>
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
