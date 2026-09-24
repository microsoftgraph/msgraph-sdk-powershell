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
    [GraphRoute("PATCH", "/admin/reportSettings/sharePoint/apiUsageReportMetrics/{apiUsageReportEnablementStatus-metric}")]
    [Cmdlet(VerbsData.Update, "MgAdminReportSettingSharePointApiUsageReportMetric", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.ApiUsageReportEnablementStatus))]
    public class UpdateMgAdminReportSettingSharePointApiUsageReportMetricCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ApiUsageReportEnablementStatusMetric { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Metric { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.ApiUsageReportOnboardingStatus? OnboardingStatus { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ApiUsageReportEnablementStatusMetric, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.ApiUsageReportEnablementStatus();

    if (this.IsParameterBound(nameof(Metric)))
        body.Metric = Metric;

    if (this.IsParameterBound(nameof(OnboardingStatus)))
        body.OnboardingStatus = OnboardingStatus;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.ApiUsageReportEnablementStatus? result;
            try
            {
                result = client.Admin.ReportSettings.SharePoint.ApiUsageReportMetrics[ApiUsageReportEnablementStatusMetric].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ApiUsageReportEnablementStatusMetric);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Admin.ReportSettings.SharePoint.ApiUsageReportMetrics[ApiUsageReportEnablementStatusMetric].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ApiUsageReportEnablementStatusMetric);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
