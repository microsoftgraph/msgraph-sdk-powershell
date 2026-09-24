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
    [GraphRoute("PATCH", "/deviceManagement/reports/cachedReportConfigurations/{deviceManagementCachedReportConfiguration-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementReportCachedReportConfiguration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.DeviceManagementCachedReportConfiguration))]
    public class UpdateMgDeviceManagementReportCachedReportConfigurationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceManagementCachedReportConfigurationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastRefreshDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Metadata { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? OrderBy { get; set; }

        [Parameter(Mandatory = false)]
        public string? ReportName { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Select { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.DeviceManagementReportStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceManagementCachedReportConfigurationId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.DeviceManagementCachedReportConfiguration();

    if (this.IsParameterBound(nameof(ExpirationDateTime)))
        body.ExpirationDateTime = ExpirationDateTime;

    if (this.IsParameterBound(nameof(Filter)))
        body.Filter = Filter;

    if (this.IsParameterBound(nameof(LastRefreshDateTime)))
        body.LastRefreshDateTime = LastRefreshDateTime;

    if (this.IsParameterBound(nameof(Metadata)))
        body.Metadata = Metadata;

    if (this.IsParameterBound(nameof(OrderBy)))
        body.OrderBy = OrderBy!.ToList();

    if (this.IsParameterBound(nameof(ReportName)))
        body.ReportName = ReportName;

    if (this.IsParameterBound(nameof(Select)))
        body.Select = Select!.ToList();

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.DeviceManagementCachedReportConfiguration? result;
            try
            {
                result = client.DeviceManagement.Reports.CachedReportConfigurations[DeviceManagementCachedReportConfigurationId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceManagementCachedReportConfigurationId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.Reports.CachedReportConfigurations[DeviceManagementCachedReportConfigurationId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, DeviceManagementCachedReportConfigurationId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
