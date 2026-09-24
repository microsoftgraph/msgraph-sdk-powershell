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
    [GraphRoute("PATCH", "/reports/dailyPrintUsageByUser/{printUsageByUser-id}")]
    [Cmdlet(VerbsData.Update, "MgReportDailyPrintUsageByUser", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.PrintUsageByUser))]
    public class UpdateMgReportDailyPrintUsageByUserCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string PrintUsageByUserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public long? BlackAndWhitePageCount { get; set; }

        [Parameter(Mandatory = false)]
        public long? ColorPageCount { get; set; }

        [Parameter(Mandatory = false)]
        public long? CompletedBlackAndWhiteJobCount { get; set; }

        [Parameter(Mandatory = false)]
        public long? CompletedColorJobCount { get; set; }

        [Parameter(Mandatory = false)]
        public long? CompletedJobCount { get; set; }

        [Parameter(Mandatory = false)]
        public long? DoubleSidedSheetCount { get; set; }

        [Parameter(Mandatory = false)]
        public long? IncompleteJobCount { get; set; }

        [Parameter(Mandatory = false)]
        public long? MediaSheetCount { get; set; }

        [Parameter(Mandatory = false)]
        public long? PageCount { get; set; }

        [Parameter(Mandatory = false)]
        public long? SingleSidedSheetCount { get; set; }

        [Parameter(Mandatory = false)]
        public global::Microsoft.Kiota.Abstractions.Date? UsageDate { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserPrincipalName { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(PrintUsageByUserId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.PrintUsageByUser();

    if (this.IsParameterBound(nameof(BlackAndWhitePageCount)))
        body.BlackAndWhitePageCount = BlackAndWhitePageCount;

    if (this.IsParameterBound(nameof(ColorPageCount)))
        body.ColorPageCount = ColorPageCount;

    if (this.IsParameterBound(nameof(CompletedBlackAndWhiteJobCount)))
        body.CompletedBlackAndWhiteJobCount = CompletedBlackAndWhiteJobCount;

    if (this.IsParameterBound(nameof(CompletedColorJobCount)))
        body.CompletedColorJobCount = CompletedColorJobCount;

    if (this.IsParameterBound(nameof(CompletedJobCount)))
        body.CompletedJobCount = CompletedJobCount;

    if (this.IsParameterBound(nameof(DoubleSidedSheetCount)))
        body.DoubleSidedSheetCount = DoubleSidedSheetCount;

    if (this.IsParameterBound(nameof(IncompleteJobCount)))
        body.IncompleteJobCount = IncompleteJobCount;

    if (this.IsParameterBound(nameof(MediaSheetCount)))
        body.MediaSheetCount = MediaSheetCount;

    if (this.IsParameterBound(nameof(PageCount)))
        body.PageCount = PageCount;

    if (this.IsParameterBound(nameof(SingleSidedSheetCount)))
        body.SingleSidedSheetCount = SingleSidedSheetCount;

    if (this.IsParameterBound(nameof(UsageDate)))
        body.UsageDate = UsageDate;

    if (this.IsParameterBound(nameof(UserPrincipalName)))
        body.UserPrincipalName = UserPrincipalName;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.PrintUsageByUser? result;
            try
            {
                result = client.Reports.DailyPrintUsageByUser[PrintUsageByUserId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, PrintUsageByUserId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Reports.DailyPrintUsageByUser[PrintUsageByUserId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, PrintUsageByUserId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
