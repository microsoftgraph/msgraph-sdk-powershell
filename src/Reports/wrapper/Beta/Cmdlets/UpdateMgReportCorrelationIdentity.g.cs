#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Reports.Client;
using Microsoft.Graph.PowerShell.Reports.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Reports
{
    [GraphRoute("PATCH", "/reports/correlations/{identityCorrelation-id}/identities/{correlatedIdentity-id}")]
    [Cmdlet(VerbsData.Update, "MgReportCorrelationIdentity", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.CorrelatedIdentity))]
    public class UpdateMgReportCorrelationIdentityCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string IdentityCorrelationId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string CorrelatedIdentityId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CorrelatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Status { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.CorrelationError? Error { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.IdentityInfo? SourceIdentity { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.IdentityInfo? TargetIdentity { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CorrelatedIdentityId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.CorrelatedIdentity();

    if (this.IsParameterBound(nameof(CorrelatedDateTime)))
        body.CorrelatedDateTime = CorrelatedDateTime;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;

    if (this.IsParameterBound(nameof(Error)))
        body.Error = Error;

    if (this.IsParameterBound(nameof(SourceIdentity)))
        body.SourceIdentity = SourceIdentity;

    if (this.IsParameterBound(nameof(TargetIdentity)))
        body.TargetIdentity = TargetIdentity;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.CorrelatedIdentity? result;
            try
            {
                result = client.Reports.Correlations[IdentityCorrelationId].Identities[CorrelatedIdentityId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CorrelatedIdentityId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Reports.Correlations[IdentityCorrelationId].Identities[CorrelatedIdentityId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, CorrelatedIdentityId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
