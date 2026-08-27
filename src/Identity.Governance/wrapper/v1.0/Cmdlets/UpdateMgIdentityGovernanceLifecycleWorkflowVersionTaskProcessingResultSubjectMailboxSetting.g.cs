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
    [GraphRoute("PATCH", "/identityGovernance/lifecycleWorkflows/workflows/{workflow-id}/versions/{workflowVersion-versionNumber}/tasks/{task-id}/taskProcessingResults/{taskProcessingResult-id}/subject/mailboxSettings")]
    [Cmdlet(VerbsData.Update, "MgIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResultSubjectMailboxSetting", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.MailboxSettings))]
    public class UpdateMgIdentityGovernanceLifecycleWorkflowVersionTaskProcessingResultSubjectMailboxSettingCommand : PSCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string WorkflowId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string WorkflowVersionVersionNumber { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string TaskId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string TaskProcessingResultId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? ArchiveFolder { get; set; }

        [Parameter(Mandatory = false)]
        public string? DateFormat { get; set; }

        [Parameter(Mandatory = false)]
        public string? TimeFormat { get; set; }

        [Parameter(Mandatory = false)]
        public string? TimeZone { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.AutomaticRepliesSetting? AutomaticRepliesSetting { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.DelegateMeetingMessageDeliveryOptions? DelegateMeetingMessageDeliveryOptions { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.LocaleInfo? Language { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.UserPurpose? UserPurpose { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.WorkingHours? WorkingHours { get; set; }




        [Parameter(Mandatory = false,
            HelpMessage = "Additional HTTP request headers to send, keyed by header name.")]
        public System.Collections.IDictionary? Headers { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Bearer access token. Omit if you have already run Connect-MgGraph.")]
        public string? AccessToken { get; set; }

        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TaskProcessingResultId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.MailboxSettings();

    if (this.IsParameterBound(nameof(ArchiveFolder)))
        body.ArchiveFolder = ArchiveFolder;

    if (this.IsParameterBound(nameof(DateFormat)))
        body.DateFormat = DateFormat;

    if (this.IsParameterBound(nameof(TimeFormat)))
        body.TimeFormat = TimeFormat;

    if (this.IsParameterBound(nameof(TimeZone)))
        body.TimeZone = TimeZone;

    if (this.IsParameterBound(nameof(AutomaticRepliesSetting)))
        body.AutomaticRepliesSetting = AutomaticRepliesSetting;

    if (this.IsParameterBound(nameof(DelegateMeetingMessageDeliveryOptions)))
        body.DelegateMeetingMessageDeliveryOptions = DelegateMeetingMessageDeliveryOptions;

    if (this.IsParameterBound(nameof(Language)))
        body.Language = Language;

    if (this.IsParameterBound(nameof(UserPurpose)))
        body.UserPurpose = UserPurpose;

    if (this.IsParameterBound(nameof(WorkingHours)))
        body.WorkingHours = WorkingHours;


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

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.MailboxSettings? result;
            try
            {
                result = client.IdentityGovernance.LifecycleWorkflows.Workflows[WorkflowId].Versions[WorkflowVersionVersionNumber].Tasks[TaskId].TaskProcessingResults[TaskProcessingResultId].Subject.MailboxSettings.PatchAsync(body, requestConfiguration =>
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
                ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, TaskProcessingResultId));
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.IdentityGovernance.LifecycleWorkflows.Workflows[WorkflowId].Versions[WorkflowVersionVersionNumber].Tasks[TaskId].TaskProcessingResults[TaskProcessingResultId].Subject.MailboxSettings.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowTerminatingError(new ErrorRecord(ex, "GraphRequestFailed", ErrorCategory.InvalidOperation, TaskProcessingResultId));
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
