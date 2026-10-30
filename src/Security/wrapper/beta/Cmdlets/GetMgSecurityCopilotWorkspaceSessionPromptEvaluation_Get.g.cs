#nullable enable

using System;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Security.Client;
using Microsoft.Graph.PowerShell.Security.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Security
{
    [GraphRoute("GET", "/security/securityCopilot/workspaces/{workspace-id}/sessions/{session-id}/prompts/{prompt-id}/evaluations/{evaluation-id}")]
    [Cmdlet(VerbsCommon.Get, "MgSecurityCopilotWorkspaceSessionPromptEvaluation_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.SecurityCopilot.Evaluation))]
    public class GetMgSecurityCopilotWorkspaceSessionPromptEvaluation_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string WorkspaceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string SessionId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string PromptId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string EvaluationId { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.SecurityCopilot.Evaluation? result;
            try
            {
                result = client.Security.SecurityCopilot.Workspaces[WorkspaceId].Sessions[SessionId].Prompts[PromptId].Evaluations[EvaluationId].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, EvaluationId);
                return;
            }

            WriteObject(result);
        }
    }
}
