#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Users.Client;
using Microsoft.Graph.PowerShell.Users.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Users
{
    [GraphRoute("POST", "/users/{user-id}/todo/lists/{todoTaskList-id}/tasks/{todoTask-id}/attachments/createUploadSession")]
    [Cmdlet(VerbsCommon.New, "MgUserTodoListTaskAttachmentUploadSession", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Users.Client.Models.UploadSession))]
    public class NewMgUserTodoListTaskAttachmentUploadSessionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string TodoTaskListId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string TodoTaskId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Users.Client.Models.AttachmentInfo? AttachmentInfo { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TodoTaskId, "New"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Users.Client.Users.Item.Todo.Lists.Item.Tasks.Item.Attachments.CreateUploadSession.CreateUploadSessionPostRequestBody();

    if (this.IsParameterBound(nameof(AttachmentInfo)))
        body.AttachmentInfo = AttachmentInfo;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Users.Client.Models.UploadSession? result;
            try
            {
                result = client.Users[UserId].Todo.Lists[TodoTaskListId].Tasks[TodoTaskId].Attachments.CreateUploadSession.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, TodoTaskId);
                return;
            }

            WriteObject(result);
        }
    }
}
