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
    [GraphRoute("POST", "/reports/userInsights/daily/mfaTelecomFraud")]
    [Cmdlet(VerbsCommon.New, "MgReportUserInsightDailyMfaTelecomFraud", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.MfaTelecomFraudMetric))]
    public class NewMgReportUserInsightDailyMfaTelecomFraudCommand : GraphClientCmdlet
    {


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
            if (!ShouldProcess(null, "New"))
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
                result = client.Reports.UserInsights.Daily.MfaTelecomFraud.PostAsync(body, requestConfiguration =>
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
