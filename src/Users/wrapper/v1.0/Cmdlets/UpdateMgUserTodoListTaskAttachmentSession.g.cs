#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Users.Client;
using Microsoft.Graph.PowerShell.Users.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Users
{
    [GraphRoute("PATCH", "/users/{user-id}/todo/lists/{todoTaskList-id}/tasks/{todoTask-id}/attachmentSessions/{attachmentSession-id}")]
    [Cmdlet(VerbsData.Update, "MgUserTodoListTaskAttachmentSession", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Users.Client.Models.AttachmentSession))]
    public class UpdateMgUserTodoListTaskAttachmentSessionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string TodoTaskListId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string TodoTaskId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string AttachmentSessionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public byte[]? Content { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? NextExpectedRanges { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AttachmentSessionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Users.Client.Models.AttachmentSession();

    if (this.IsParameterBound(nameof(Content)))
        body.Content = Content;

    if (this.IsParameterBound(nameof(ExpirationDateTime)))
        body.ExpirationDateTime = ExpirationDateTime;

    if (this.IsParameterBound(nameof(NextExpectedRanges)))
        body.NextExpectedRanges = NextExpectedRanges!.ToList();



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Users.Client.Models.AttachmentSession? result;
            try
            {
                result = client.Users[UserId].Todo.Lists[TodoTaskListId].Tasks[TodoTaskId].AttachmentSessions[AttachmentSessionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, AttachmentSessionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].Todo.Lists[TodoTaskListId].Tasks[TodoTaskId].AttachmentSessions[AttachmentSessionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, AttachmentSessionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
