#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.PowerShell.Authentication.Helpers;
using Microsoft.Graph.PowerShell.Identity.Governance.Client;
using Microsoft.Graph.PowerShell.Identity.Governance.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("PATCH", "/identityGovernance/lifecycleWorkflows/workflows/{workflow-id}/tasks/{task-id}")]
    [Cmdlet(VerbsData.Update, "MgIdentityGovernanceLifecycleWorkflowTask", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.IdentityGovernance.TaskObject))]
    public class UpdateMgIdentityGovernanceLifecycleWorkflowTaskCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string WorkflowId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string TaskId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? ContinueOnError { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public int? ExecutionSequence { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public string? TaskDefinitionId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.KeyValuePair[]? Arguments { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.IdentityGovernance.LifecycleTaskCategory? Category { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TaskId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.IdentityGovernance.TaskObject();

    if (this.IsParameterBound(nameof(ContinueOnError)))
        body.ContinueOnError = ContinueOnError;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(ExecutionSequence)))
        body.ExecutionSequence = ExecutionSequence;

    if (this.IsParameterBound(nameof(IsEnabled)))
        body.IsEnabled = IsEnabled;

    if (this.IsParameterBound(nameof(TaskDefinitionId)))
        body.TaskDefinitionId = TaskDefinitionId;

    if (this.IsParameterBound(nameof(Arguments)))
        body.Arguments = Arguments!.ToList();

    if (this.IsParameterBound(nameof(Category)))
        body.Category = Category;


        // ── Choose HttpClient + auth provider ─────────────────────────────
        HttpClient httpClient;
        IAuthenticationProvider authProvider;

        if (this.IsParameterBound(nameof(AccessToken)))
        {
            httpClient = new HttpClient();
            authProvider = new StaticBearerTokenAuthenticationProvider(AccessToken!);
        }
        else
        {
            WriteVerbose("No -AccessToken supplied, using the active Connect-MgGraph session.");
            try
            {
                httpClient = HttpHelpers.GetGraphHttpClient();
            }
            catch (Exception ex)
            {
                ThrowTerminatingError(new ErrorRecord(
                    new InvalidOperationException(
                        "No active Graph session. Run Connect-MgGraph first, or supply -AccessToken.", ex),
                    "NoGraphSession",
                    ErrorCategory.AuthenticationError,
                    null));
                return;
            }
            authProvider = new AnonymousAuthenticationProvider();
        }

        var requestAdapter = new HttpClientRequestAdapter(authProvider, httpClient: httpClient);
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.IdentityGovernance.TaskObject? result;
            try
            {
                result = client.IdentityGovernance.LifecycleWorkflows.Workflows[WorkflowId].Tasks[TaskId].PatchAsync(body, requestConfiguration =>
                {

                        if (this.IsParameterBound(nameof(Headers)))
                        {
                            foreach (System.Collections.DictionaryEntry entry in Headers!)
                                requestConfiguration.Headers.Add(entry.Key.ToString()!, entry.Value?.ToString() ?? string.Empty);
                        }
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, TaskId));
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityGovernance.LifecycleWorkflows.Workflows[WorkflowId].Tasks[TaskId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, TaskId));
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
