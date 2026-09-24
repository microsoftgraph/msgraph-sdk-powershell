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
    [GraphRoute("PATCH", "/reports/applicationSignInDetailedSummary/{applicationSignInDetailedSummary-id}")]
    [Cmdlet(VerbsData.Update, "MgReportApplicationSignInDetailedSummary", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.ApplicationSignInDetailedSummary))]
    public class UpdateMgReportApplicationSignInDetailedSummaryCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ApplicationSignInDetailedSummaryId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? AggregatedEventDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? AppDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? AppId { get; set; }

        [Parameter(Mandatory = false)]
        public long? SignInCount { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.SignInStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ApplicationSignInDetailedSummaryId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.ApplicationSignInDetailedSummary();

    if (this.IsParameterBound(nameof(AggregatedEventDateTime)))
        body.AggregatedEventDateTime = AggregatedEventDateTime;

    if (this.IsParameterBound(nameof(AppDisplayName)))
        body.AppDisplayName = AppDisplayName;

    if (this.IsParameterBound(nameof(AppId)))
        body.AppId = AppId;

    if (this.IsParameterBound(nameof(SignInCount)))
        body.SignInCount = SignInCount;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.ApplicationSignInDetailedSummary? result;
            try
            {
                result = client.Reports.ApplicationSignInDetailedSummary[ApplicationSignInDetailedSummaryId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ApplicationSignInDetailedSummaryId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Reports.ApplicationSignInDetailedSummary[ApplicationSignInDetailedSummaryId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ApplicationSignInDetailedSummaryId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
