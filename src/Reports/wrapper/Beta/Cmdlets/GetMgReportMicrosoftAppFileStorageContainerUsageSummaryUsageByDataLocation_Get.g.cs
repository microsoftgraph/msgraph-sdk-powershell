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
    [GraphRoute("GET", "/reports/microsoftAppsFileStorageContainerUsageSummary/usageByDataLocation/{microsoftAppsFileStorageContainerGeoUsage-dataLocationCode}")]
    [Cmdlet(VerbsCommon.Get, "MgReportMicrosoftAppFileStorageContainerUsageSummaryUsageByDataLocation_Get")]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.MicrosoftAppsFileStorageContainerGeoUsage))]
    public class GetMgReportMicrosoftAppFileStorageContainerUsageSummaryUsageByDataLocation_GetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string MicrosoftAppsFileStorageContainerGeoUsageDataLocationCode { get; set; } = string.Empty;



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

            Microsoft.Graph.PowerShell.Reports.Client.Models.MicrosoftAppsFileStorageContainerGeoUsage? result;
            try
            {
                result = client.Reports.MicrosoftAppsFileStorageContainerUsageSummary.UsageByDataLocation[MicrosoftAppsFileStorageContainerGeoUsageDataLocationCode].GetAsync(requestConfiguration =>
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
                ThrowGraphRequestFailed(ex, MicrosoftAppsFileStorageContainerGeoUsageDataLocationCode);
                return;
            }

            WriteObject(result);
        }
    }
}
