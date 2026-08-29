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
    [GraphRoute("PATCH", "/groups/{group-id}/threads/{conversationThread-id}")]
    [Cmdlet(VerbsData.Update, "MgGroupThread", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Groups.Client.Models.ConversationThread))]
    public class UpdateMgGroupThreadCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string GroupId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ConversationThreadId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? HasAttachments { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsLocked { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastDeliveredDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Preview { get; set; }

        [Parameter(Mandatory = false)]
        public string? Topic { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? UniqueSenders { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Groups.Client.Models.Recipient[]? CcRecipients { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Groups.Client.Models.Recipient[]? ToRecipients { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ConversationThreadId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Groups.Client.Models.ConversationThread();

    if (this.IsParameterBound(nameof(HasAttachments)))
        body.HasAttachments = HasAttachments;

    if (this.IsParameterBound(nameof(IsLocked)))
        body.IsLocked = IsLocked;

    if (this.IsParameterBound(nameof(LastDeliveredDateTime)))
        body.LastDeliveredDateTime = LastDeliveredDateTime;

    if (this.IsParameterBound(nameof(Preview)))
        body.Preview = Preview;

    if (this.IsParameterBound(nameof(Topic)))
        body.Topic = Topic;

    if (this.IsParameterBound(nameof(UniqueSenders)))
        body.UniqueSenders = UniqueSenders!.ToList();

    if (this.IsParameterBound(nameof(CcRecipients)))
        body.CcRecipients = CcRecipients!.ToList();

    if (this.IsParameterBound(nameof(ToRecipients)))
        body.ToRecipients = ToRecipients!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Groups.Client.Models.ConversationThread? result;
            try
            {
                result = client.Groups[GroupId].Threads[ConversationThreadId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ConversationThreadId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Groups[GroupId].Threads[ConversationThreadId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ConversationThreadId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
