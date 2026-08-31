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
    [GraphRoute("PATCH", "/users/{user-id}/todo/lists/{todoTaskList-id}/tasks/{todoTask-id}/linkedResources/{linkedResource-id}")]
    [Cmdlet(VerbsData.Update, "MgUserTodoListTaskLinkedResource", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Users.Client.Models.LinkedResource))]
    public class UpdateMgUserTodoListTaskLinkedResourceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string TodoTaskListId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string TodoTaskId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string LinkedResourceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ApplicationName { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? ExternalId { get; set; }

        [Parameter(Mandatory = false)]
        public string? WebUrl { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(LinkedResourceId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Users.Client.Models.LinkedResource();

    if (this.IsParameterBound(nameof(ApplicationName)))
        body.ApplicationName = ApplicationName;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(ExternalId)))
        body.ExternalId = ExternalId;

    if (this.IsParameterBound(nameof(WebUrl)))
        body.WebUrl = WebUrl;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Users.Client.Models.LinkedResource? result;
            try
            {
                result = client.Users[UserId].Todo.Lists[TodoTaskListId].Tasks[TodoTaskId].LinkedResources[LinkedResourceId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, LinkedResourceId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Users[UserId].Todo.Lists[TodoTaskListId].Tasks[TodoTaskId].LinkedResources[LinkedResourceId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, LinkedResourceId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
