#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Planner.Client;
using Microsoft.Graph.PowerShell.Planner.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Planner
{
    [GraphRoute("POST", "/planner/tasks_v2/{task-id}/messages")]
    [Cmdlet(VerbsCommon.New, "MgPlannerTaskV2Message", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerChatMessage))]
    public class NewMgPlannerTaskV2MessageCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TaskId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Content { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DeletedTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EditedTime { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsDeleted { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsEdited { get; set; }

        [Parameter(Mandatory = false)]
        public string? ParentEntityId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerChatMessageType? MessageType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.ChatMessageProperties? Properties { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerChatThreadType? ThreadType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TaskId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerChatMessage();

    if (this.IsParameterBound(nameof(Content)))
        body.Content = Content;

    if (this.IsParameterBound(nameof(DeletedTime)))
        body.DeletedTime = DeletedTime;

    if (this.IsParameterBound(nameof(EditedTime)))
        body.EditedTime = EditedTime;

    if (this.IsParameterBound(nameof(IsDeleted)))
        body.IsDeleted = IsDeleted;

    if (this.IsParameterBound(nameof(IsEdited)))
        body.IsEdited = IsEdited;

    if (this.IsParameterBound(nameof(ParentEntityId)))
        body.ParentEntityId = ParentEntityId;

    if (this.IsParameterBound(nameof(MessageType)))
        body.MessageType = MessageType;

    if (this.IsParameterBound(nameof(Properties)))
        body.Properties = Properties;

    if (this.IsParameterBound(nameof(ThreadType)))
        body.ThreadType = ThreadType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Planner.Client.Models.PlannerChatMessage? result;
            try
            {
                result = client.Planner.Tasks_v2[TaskId].Messages.PostAsync(body, requestConfiguration =>
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
