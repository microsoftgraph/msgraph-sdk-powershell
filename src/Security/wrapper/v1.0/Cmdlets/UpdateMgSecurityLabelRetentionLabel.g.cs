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
    [GraphRoute("PATCH", "/security/labels/retentionLabels/{retentionLabel-id}")]
    [Cmdlet(VerbsData.Update, "MgSecurityLabelRetentionLabel", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Security.Client.Models.Security.RetentionLabel))]
    public class UpdateMgSecurityLabelRetentionLabelCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string RetentionLabelId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DescriptionForAdmins { get; set; }

        [Parameter(Mandatory = false)]
        public string? DescriptionForUsers { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsInUse { get; set; }

        [Parameter(Mandatory = false)]
        public string? LabelToBeApplied { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.ActionAfterRetentionPeriod? ActionAfterRetentionPeriod { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.BehaviorDuringRetentionPeriod? BehaviorDuringRetentionPeriod { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.IdentitySet? CreatedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.DefaultRecordBehavior? DefaultRecordBehavior { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.IdentitySet? LastModifiedBy { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.RetentionDuration? RetentionDuration { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Security.Client.Models.Security.RetentionTrigger? RetentionTrigger { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(RetentionLabelId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Security.Client.Models.Security.RetentionLabel();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(DescriptionForAdmins)))
        body.DescriptionForAdmins = DescriptionForAdmins;

    if (this.IsParameterBound(nameof(DescriptionForUsers)))
        body.DescriptionForUsers = DescriptionForUsers;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(IsInUse)))
        body.IsInUse = IsInUse;

    if (this.IsParameterBound(nameof(LabelToBeApplied)))
        body.LabelToBeApplied = LabelToBeApplied;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(ActionAfterRetentionPeriod)))
        body.ActionAfterRetentionPeriod = ActionAfterRetentionPeriod;

    if (this.IsParameterBound(nameof(BehaviorDuringRetentionPeriod)))
        body.BehaviorDuringRetentionPeriod = BehaviorDuringRetentionPeriod;

    if (this.IsParameterBound(nameof(CreatedBy)))
        body.CreatedBy = CreatedBy;

    if (this.IsParameterBound(nameof(DefaultRecordBehavior)))
        body.DefaultRecordBehavior = DefaultRecordBehavior;

    if (this.IsParameterBound(nameof(LastModifiedBy)))
        body.LastModifiedBy = LastModifiedBy;

    if (this.IsParameterBound(nameof(RetentionDuration)))
        body.RetentionDuration = RetentionDuration;

    if (this.IsParameterBound(nameof(RetentionTrigger)))
        body.RetentionTrigger = RetentionTrigger;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Security.Client.Models.Security.RetentionLabel? result;
            try
            {
                result = client.Security.Labels.RetentionLabels[RetentionLabelId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, RetentionLabelId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Security.Labels.RetentionLabels[RetentionLabelId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, RetentionLabelId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
