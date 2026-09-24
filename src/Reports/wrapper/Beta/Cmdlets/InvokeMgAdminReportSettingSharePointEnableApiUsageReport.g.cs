#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Reports.Client;
using Microsoft.Graph.PowerShell.Reports.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Reports
{
    [GraphRoute("POST", "/admin/reportSettings/sharePoint/enableApiUsageReport")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgAdminReportSettingSharePointEnableApiUsageReport", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.ApiUsageReportEnablementStatus))]
    public class InvokeMgAdminReportSettingSharePointEnableApiUsageReportCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? Metric { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Reports.Client.Admin.ReportSettings.SharePoint.EnableApiUsageReport.EnableApiUsageReportPostRequestBody();

    if (this.IsParameterBound(nameof(Metric)))
        body.Metric = Metric;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.ApiUsageReportEnablementStatus? result;
            try
            {
                result = client.Admin.ReportSettings.SharePoint.EnableApiUsageReport.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
