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
    [GraphRoute("PATCH", "/deviceManagement/reports/exportJobs/{deviceManagementExportJob-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementReportExportJob", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Reports.Client.Models.DeviceManagementExportJob))]
    public class UpdateMgDeviceManagementReportExportJobCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceManagementExportJobId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Filter { get; set; }

        [Parameter(Mandatory = false)]
        public string? ReportName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? RequestDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Search { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? Select { get; set; }

        [Parameter(Mandatory = false)]
        public string? SnapshotId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Url { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.DeviceManagementReportFileFormat? Format { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.DeviceManagementExportJobLocalizationType? LocalizationType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Reports.Client.Models.DeviceManagementReportStatus? Status { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceManagementExportJobId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Reports.Client.Models.DeviceManagementExportJob();

    if (this.IsParameterBound(nameof(ExpirationDateTime)))
        body.ExpirationDateTime = ExpirationDateTime;

    if (this.IsParameterBound(nameof(Filter)))
        body.Filter = Filter;

    if (this.IsParameterBound(nameof(ReportName)))
        body.ReportName = ReportName;

    if (this.IsParameterBound(nameof(RequestDateTime)))
        body.RequestDateTime = RequestDateTime;

    if (this.IsParameterBound(nameof(Search)))
        body.Search = Search;

    if (this.IsParameterBound(nameof(Select)))
        body.Select = Select!.ToList();

    if (this.IsParameterBound(nameof(SnapshotId)))
        body.SnapshotId = SnapshotId;

    if (this.IsParameterBound(nameof(Url)))
        body.Url = Url;

    if (this.IsParameterBound(nameof(Format)))
        body.Format = Format;

    if (this.IsParameterBound(nameof(LocalizationType)))
        body.LocalizationType = LocalizationType;

    if (this.IsParameterBound(nameof(Status)))
        body.Status = Status;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Reports.Client.Models.DeviceManagementExportJob? result;
            try
            {
                result = client.DeviceManagement.Reports.ExportJobs[DeviceManagementExportJobId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceManagementExportJobId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.Reports.ExportJobs[DeviceManagementExportJobId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, DeviceManagementExportJobId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
