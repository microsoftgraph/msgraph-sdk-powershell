#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.Governance.Client;
using Microsoft.Graph.PowerShell.Identity.Governance.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.Governance
{
    [GraphRoute("POST", "/identityGovernance/lifecycleWorkflows/workflows")]
    [Cmdlet(VerbsCommon.New, "MgIdentityGovernanceLifecycleWorkflow", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.IdentityGovernance.Workflow))]
    public class NewMgIdentityGovernanceLifecycleWorkflowCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsSchedulingEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DeletedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? NextScheduleRunDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public int? Version { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.IdentityGovernance.LifecycleWorkflowCategory? Category { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.IdentityGovernance.WorkflowExecutionConditions? ExecutionConditions { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.IdentityGovernance.SubjectType? TargetSubjectType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.IdentityGovernance.QuarantineDetails? QuarantineDetails { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.IdentityGovernance.WorkflowSetting? Settings { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.IdentityGovernance.Workflow();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IsEnabled)))
        body.IsEnabled = IsEnabled;

    if (this.IsParameterBound(nameof(IsSchedulingEnabled)))
        body.IsSchedulingEnabled = IsSchedulingEnabled;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(DeletedDateTime)))
        body.DeletedDateTime = DeletedDateTime;

    if (this.IsParameterBound(nameof(NextScheduleRunDateTime)))
        body.NextScheduleRunDateTime = NextScheduleRunDateTime;

    if (this.IsParameterBound(nameof(Version)))
        body.Version = Version;

    if (this.IsParameterBound(nameof(Category)))
        body.Category = Category;

    if (this.IsParameterBound(nameof(ExecutionConditions)))
        body.ExecutionConditions = ExecutionConditions;

    if (this.IsParameterBound(nameof(TargetSubjectType)))
        body.TargetSubjectType = TargetSubjectType;

    if (this.IsParameterBound(nameof(QuarantineDetails)))
        body.QuarantineDetails = QuarantineDetails;

    if (this.IsParameterBound(nameof(Settings)))
        body.Settings = Settings;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.Governance.Client.Models.IdentityGovernance.Workflow? result;
            try
            {
                result = client.IdentityGovernance.LifecycleWorkflows.Workflows.PostAsync(body, requestConfiguration =>
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
