#nullable enable

using System;
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
    [GraphRoute("GET", "/admin/reportSettings/sharePoint/apiUsageReportMetrics/{apiUsageReportEnablementStatus-metric}")]
    [Cmdlet(VerbsCommon.Get, "MgAdminReportSettingSharePointApiUsageReportMetric_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.ApiUsageReportEnablementStatus))]
    public class GetMgAdminReportSettingSharePointApiUsageReportMetric_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ApiUsageReportEnablementStatusMetric { get; set; } = string.Empty;



        [Parameter(Mandatory = false)]
        [Alias("Select")]
        public string[]? Property { get; set; }
        [Parameter(Mandatory = false)]
        [Alias("Expand")]
        public string[]? ExpandProperty { get; set; }



        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.ApiUsageReportEnablementStatus? result;
            try
            {
                result = client.Admin.ReportSettings.SharePoint.ApiUsageReportMetrics[ApiUsageReportEnablementStatusMetric].GetAsync(requestConfiguration =>
                {
                    if (this.IsParameterBound(nameof(Property)))
                        requestConfiguration.QueryParameters.Select = Property;

                    if (this.IsParameterBound(nameof(ExpandProperty)))
                        requestConfiguration.QueryParameters.Expand = ExpandProperty;



        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ApiUsageReportEnablementStatusMetric);
                return;
            }

            WriteObject(result);
        }
    }
}
