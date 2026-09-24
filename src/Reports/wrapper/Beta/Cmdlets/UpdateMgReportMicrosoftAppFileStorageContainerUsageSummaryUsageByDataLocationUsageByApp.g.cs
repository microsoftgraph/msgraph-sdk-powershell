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
    [GraphRoute("PATCH", "/reports/microsoftAppsFileStorageContainerUsageSummary/usageByDataLocation/{microsoftAppsFileStorageContainerGeoUsage-dataLocationCode}/usageByApp/{microsoftAppsFileStorageContainerAppUsage-appId}")]
    [Cmdlet(VerbsData.Update, "MgReportMicrosoftAppFileStorageContainerUsageSummaryUsageByDataLocationUsageByApp", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.MicrosoftAppsFileStorageContainerAppUsage))]
    public class UpdateMgReportMicrosoftAppFileStorageContainerUsageSummaryUsageByDataLocationUsageByAppCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MicrosoftAppsFileStorageContainerGeoUsageDataLocationCode { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string MicrosoftAppsFileStorageContainerAppUsageAppId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(MicrosoftAppsFileStorageContainerAppUsageAppId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.MicrosoftAppsFileStorageContainerAppUsage();




        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.MicrosoftAppsFileStorageContainerAppUsage? result;
            try
            {
                result = client.Reports.MicrosoftAppsFileStorageContainerUsageSummary.UsageByDataLocation[MicrosoftAppsFileStorageContainerGeoUsageDataLocationCode].UsageByApp[MicrosoftAppsFileStorageContainerAppUsageAppId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, MicrosoftAppsFileStorageContainerAppUsageAppId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Reports.MicrosoftAppsFileStorageContainerUsageSummary.UsageByDataLocation[MicrosoftAppsFileStorageContainerGeoUsageDataLocationCode].UsageByApp[MicrosoftAppsFileStorageContainerAppUsageAppId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, MicrosoftAppsFileStorageContainerAppUsageAppId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
