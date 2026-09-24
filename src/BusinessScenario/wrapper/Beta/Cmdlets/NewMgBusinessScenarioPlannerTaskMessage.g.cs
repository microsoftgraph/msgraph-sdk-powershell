#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.BusinessScenario.Client;
using Microsoft.Graph.PowerShell.BusinessScenario.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.BusinessScenario
{
    [GraphRoute("POST", "/solutions/businessScenarios/{businessScenario-id}/planner/tasks/{businessScenarioTask-id}/messages")]
    [Cmdlet(VerbsCommon.New, "MgBusinessScenarioPlannerTaskMessage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.BusinessScenario.Client.Models.PlannerTaskChatMessage))]
    public class NewMgBusinessScenarioPlannerTaskMessageCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string BusinessScenarioId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string BusinessScenarioTaskId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Content { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DeletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EditedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ParentEntityId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BusinessScenario.Client.Models.IdentitySet? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BusinessScenario.Client.Models.PlannerTaskChatMention[]? Mentions { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BusinessScenario.Client.Models.PlannerTaskChatMessageType? MessageType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.BusinessScenario.Client.Models.PlannerTaskChatReaction[]? Reactions { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(BusinessScenarioTaskId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.BusinessScenario.Client.Models.PlannerTaskChatMessage();

    if (this.IsParameterBound(nameof(Content)))
        body.Content = Content;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(DeletedDateTime)))
        body.DeletedDateTime = DeletedDateTime;

    if (this.IsParameterBound(nameof(EditedDateTime)))
        body.EditedDateTime = EditedDateTime;

    if (this.IsParameterBound(nameof(ParentEntityId)))
        body.ParentEntityId = ParentEntityId;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(Mentions)))
        body.Mentions = Mentions!.ToList();

    if (this.IsParameterBound(nameof(MessageType)))
        body.MessageType = MessageType;

    if (this.IsParameterBound(nameof(Reactions)))
        body.Reactions = Reactions!.ToList();


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.BusinessScenario.Client.Models.PlannerTaskChatMessage? result;
            try
            {
                result = client.Solutions.BusinessScenarios[BusinessScenarioId].Planner.Tasks[BusinessScenarioTaskId].Messages.PostAsync(body, requestConfiguration =>
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
