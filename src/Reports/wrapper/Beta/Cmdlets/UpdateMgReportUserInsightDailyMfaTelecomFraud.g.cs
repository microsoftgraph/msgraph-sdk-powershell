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
    [GraphRoute("PATCH", "/reports/userInsights/daily/mfaTelecomFraud/{mfaTelecomFraudMetric-id}")]
    [Cmdlet(VerbsData.Update, "MgReportUserInsightDailyMfaTelecomFraud", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.MfaTelecomFraudMetric))]
    public class UpdateMgReportUserInsightDailyMfaTelecomFraudCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MfaTelecomFraudMetricId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public long? CaptchaFailureCount { get; set; }

        [Parameter(Mandatory = false)]
        public long? CaptchaNotTriggeredUserCount { get; set; }

        [Parameter(Mandatory = false)]
        public long? CaptchaShownUserCount { get; set; }

        [Parameter(Mandatory = false)]
        public long? CaptchaSuccessCount { get; set; }

        [Parameter(Mandatory = false)]
        public global::Microsoft.Kiota.Abstractions.Date? FactDate { get; set; }

        [Parameter(Mandatory = false)]
        public long? TelecomBlockedUserCount { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MfaTelecomFraudMetricId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.MfaTelecomFraudMetric();

    if (this.IsParameterBound(nameof(CaptchaFailureCount)))
        body.CaptchaFailureCount = CaptchaFailureCount;

    if (this.IsParameterBound(nameof(CaptchaNotTriggeredUserCount)))
        body.CaptchaNotTriggeredUserCount = CaptchaNotTriggeredUserCount;

    if (this.IsParameterBound(nameof(CaptchaShownUserCount)))
        body.CaptchaShownUserCount = CaptchaShownUserCount;

    if (this.IsParameterBound(nameof(CaptchaSuccessCount)))
        body.CaptchaSuccessCount = CaptchaSuccessCount;

    if (this.IsParameterBound(nameof(FactDate)))
        body.FactDate = FactDate;

    if (this.IsParameterBound(nameof(TelecomBlockedUserCount)))
        body.TelecomBlockedUserCount = TelecomBlockedUserCount;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.MfaTelecomFraudMetric? result;
            try
            {
                result = client.Reports.UserInsights.Daily.MfaTelecomFraud[MfaTelecomFraudMetricId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, MfaTelecomFraudMetricId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Reports.UserInsights.Daily.MfaTelecomFraud[MfaTelecomFraudMetricId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, MfaTelecomFraudMetricId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
