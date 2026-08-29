#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client;
using Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Identity.DirectoryManagement
{
    [GraphRoute("PATCH", "/directory/recovery/jobs/{recoveryJobBase-id}")]
    [Cmdlet(VerbsData.Update, "MgDirectoryRecoveryJob", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.EntraRecoveryServices.RecoveryJobBase))]
    public class UpdateMgDirectoryRecoveryJobCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string RecoveryJobBaseId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? JobCompletionDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? JobStartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? TargetStateDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public int? TotalChangedLinksCalculated { get; set; }

        [Parameter(Mandatory = false)]
        public int? TotalChangedObjectsCalculated { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.EntraRecoveryServices.RecoveryJobFilteringCriteriaBase? FilteringCriteria { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.EntraRecoveryServices.RecoveryStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(RecoveryJobBaseId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.EntraRecoveryServices.RecoveryJobBase();

    if (this.IsParameterBound(nameof(JobCompletionDateTime)))
        body.JobCompletionDateTime = JobCompletionDateTime;

    if (this.IsParameterBound(nameof(JobStartDateTime)))
        body.JobStartDateTime = JobStartDateTime;

    if (this.IsParameterBound(nameof(TargetStateDateTime)))
        body.TargetStateDateTime = TargetStateDateTime;

    if (this.IsParameterBound(nameof(TotalChangedLinksCalculated)))
        body.TotalChangedLinksCalculated = TotalChangedLinksCalculated;

    if (this.IsParameterBound(nameof(TotalChangedObjectsCalculated)))
        body.TotalChangedObjectsCalculated = TotalChangedObjectsCalculated;

    if (this.IsParameterBound(nameof(FilteringCriteria)))
        body.FilteringCriteria = FilteringCriteria;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Identity.DirectoryManagement.Client.Models.EntraRecoveryServices.RecoveryJobBase? result;
            try
            {
                result = client.Directory.Recovery.Jobs[RecoveryJobBaseId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, RecoveryJobBaseId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Directory.Recovery.Jobs[RecoveryJobBaseId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, RecoveryJobBaseId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
