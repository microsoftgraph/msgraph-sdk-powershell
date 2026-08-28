#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Users.Client;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Users
{
    [GraphRoute("PUT", "/users/{user-id}/todo/lists/{todoTaskList-id}/tasks/{todoTask-id}/attachmentSessions/{attachmentSession-id}/content")]
    [Cmdlet(VerbsCommon.Set, "MgUserTodoListTaskAttachmentSessionContent", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Users.Client.Models.AttachmentSession))]
    public class SetMgUserTodoListTaskAttachmentSessionContentCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string TodoTaskListId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string TodoTaskId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string AttachmentSessionId { get; set; } = string.Empty;

                [Parameter(Mandatory = true,
                    HelpMessage = "Path to the file whose contents are uploaded.")]
                public string InFile { get; set; } = string.Empty;






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AttachmentSessionId, "Set"))
                return;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Users.Client.Models.AttachmentSession? result;
            try
            {
                using var content = System.IO.File.OpenRead(InFile);
                result = client.Users[UserId].Todo.Lists[TodoTaskListId].Tasks[TodoTaskId].AttachmentSessions[AttachmentSessionId].Content.PutAsync(content, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, AttachmentSessionId);
                return;
            }

            WriteObject(result);
        }
    }
}
