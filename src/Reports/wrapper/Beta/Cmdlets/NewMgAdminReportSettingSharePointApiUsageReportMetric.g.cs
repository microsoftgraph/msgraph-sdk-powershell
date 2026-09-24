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
    [GraphRoute("POST", "/admin/reportSettings/sharePoint/apiUsageReportMetrics")]
    [Cmdlet(VerbsCommon.New, "MgAdminReportSettingSharePointApiUsageReportMetric", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.ApiUsageReportEnablementStatus))]
    public class NewMgAdminReportSettingSharePointApiUsageReportMetricCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? Metric { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.ApiUsageReportOnboardingStatus? OnboardingStatus { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
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
                result = client.Admin.ReportSettings.SharePoint.ApiUsageReportMetrics.PostAsync(body, requestConfiguration =>
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
