#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Files.Client;
using Microsoft.Graph.PowerShell.Files.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Files
{
    [GraphRoute("PATCH", "/drives/{drive-id}/items/{driveItem-id}/workbook/worksheets/{workbookWorksheet-id}/charts/{workbookChart-id}/axes/seriesAxis/title")]
    [Cmdlet(VerbsData.Update, "MgDriveItemWorkbookWorksheetChartAxSeryAxisTitle", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookChartAxisTitle))]
    public class UpdateMgDriveItemWorkbookWorksheetChartAxSeryAxisTitleCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DriveId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DriveItemId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string WorkbookWorksheetId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 3)]
        public string WorkbookChartId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? Text { get; set; }

        [Parameter(Mandatory = false)]
        public bool? Visible { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(WorkbookChartId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookChartAxisTitle();

    if (this.IsParameterBound(nameof(Text)))
        body.Text = Text;

    if (this.IsParameterBound(nameof(Visible)))
        body.Visible = Visible;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Files.Client.Models.WorkbookChartAxisTitle? result;
            try
            {
                result = client.Drives[DriveId].Items[DriveItemId].Workbook.Worksheets[WorkbookWorksheetId].Charts[WorkbookChartId].Axes.SeriesAxis.Title.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, WorkbookChartId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.Drives[DriveId].Items[DriveItemId].Workbook.Worksheets[WorkbookWorksheetId].Charts[WorkbookChartId].Axes.SeriesAxis.Title.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, WorkbookChartId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
