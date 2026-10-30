#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("POST", "/security/securityCopilot/workspaces/{workspace-id}/sessions/{session-id}/prompts/{prompt-id}/evaluations")]
    [Cmdlet(VerbsCommon.New, "MgSecurityCopilotWorkspaceSessionPromptEvaluation", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.SecurityCopilot.Evaluation))]
    public class NewMgSecurityCopilotWorkspaceSessionPromptEvaluationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string WorkspaceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SessionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string PromptId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CompletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public long? ExecutionCount { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsCancelled { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? RunStartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.SecurityCopilot.EvaluationResult? Result { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.SecurityCopilot.EvaluationState? State { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PromptId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.SecurityCopilot.Evaluation();

    if (this.IsParameterBound(nameof(CompletedDateTime)))
        body.CompletedDateTime = CompletedDateTime;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(ExecutionCount)))
        body.ExecutionCount = ExecutionCount;

    if (this.IsParameterBound(nameof(IsCancelled)))
        body.IsCancelled = IsCancelled;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(RunStartDateTime)))
        body.RunStartDateTime = RunStartDateTime;

    if (this.IsParameterBound(nameof(Result)))
        body.Result = Result;

    if (this.IsParameterBound(nameof(State)))
        body.State = State;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.SecurityCopilot.Evaluation? result;
            try
            {
                result = client.Security.SecurityCopilot.Workspaces[WorkspaceId].Sessions[SessionId].Prompts[PromptId].Evaluations.PostAsync(body, requestConfiguration =>
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
