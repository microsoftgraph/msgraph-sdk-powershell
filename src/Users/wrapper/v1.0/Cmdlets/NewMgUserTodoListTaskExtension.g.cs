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
    [GraphRoute("POST", "/users/{user-id}/todo/lists/{todoTaskList-id}/tasks/{todoTask-id}/extensions")]
    [Cmdlet(VerbsCommon.New, "MgUserTodoListTaskExtension", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Users.Client.Models.Extension))]
    public class NewMgUserTodoListTaskExtensionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string TodoTaskListId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string TodoTaskId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TodoTaskId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Users.Client.Models.Extension();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Users.Client.Models.Extension? result;
            try
            {
                result = client.Users[UserId].Todo.Lists[TodoTaskListId].Tasks[TodoTaskId].Extensions.PostAsync(body, requestConfiguration =>
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
