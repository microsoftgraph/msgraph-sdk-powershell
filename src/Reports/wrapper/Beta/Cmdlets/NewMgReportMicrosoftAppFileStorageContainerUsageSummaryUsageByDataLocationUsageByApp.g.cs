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
    [GraphRoute("POST", "/reports/microsoftAppsFileStorageContainerUsageSummary/usageByDataLocation/{microsoftAppsFileStorageContainerGeoUsage-dataLocationCode}/usageByApp")]
    [Cmdlet(VerbsCommon.New, "MgReportMicrosoftAppFileStorageContainerUsageSummaryUsageByDataLocationUsageByApp", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.MicrosoftAppsFileStorageContainerAppUsage))]
    public class NewMgReportMicrosoftAppFileStorageContainerUsageSummaryUsageByDataLocationUsageByAppCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MicrosoftAppsFileStorageContainerGeoUsageDataLocationCode { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MicrosoftAppsFileStorageContainerGeoUsageDataLocationCode, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.MicrosoftAppsFileStorageContainerAppUsage();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.MicrosoftAppsFileStorageContainerAppUsage? result;
            try
            {
                result = client.Reports.MicrosoftAppsFileStorageContainerUsageSummary.UsageByDataLocation[MicrosoftAppsFileStorageContainerGeoUsageDataLocationCode].UsageByApp.PostAsync(body, requestConfiguration =>
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
